using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using BusiComm;
using CommCenter;
using System.Data.SqlClient;

namespace AMSApp.paraconf
{
	/// <summary>
	/// Summary description for wfmGoodsDetail.
	/// </summary>
	public class wfmGoodsDetail : wfmBase
	{
        protected System.Web.UI.WebControls.TextBox txtGoodsID;
        protected System.Web.UI.WebControls.TextBox txtGoodsName;
        protected System.Web.UI.WebControls.TextBox txtSpell;
        protected System.Web.UI.WebControls.TextBox txtPrice;
        protected System.Web.UI.WebControls.Button btcancel;
        protected System.Web.UI.WebControls.Button btAdd;
        protected System.Web.UI.WebControls.Button btMod;
        protected System.Web.UI.WebControls.TextBox txtigvalue;
        protected System.Web.UI.WebControls.TextBox txtComments;
        protected System.Web.UI.WebControls.Button btDel;
        protected System.Web.UI.WebControls.Label lbltitle;
        protected System.Web.UI.WebControls.Label lblPromt;
        protected System.Web.UI.WebControls.DropDownList ddlGoodsType;
        protected System.Web.UI.WebControls.DropDownList ddlGoodsTypeSum;
        protected System.Web.UI.WebControls.Label lbGoodsID;
        protected System.Web.UI.WebControls.Label lbGoodsType;

		Manager m1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if(Session["Login"]==null)
			{
				Response.Redirect("../Exit.aspx");
				return;
			}

			string strid=Request.QueryString["id"];
			Hashtable htapp=(Hashtable)Application["appconf"];
			string strcons=(string)htapp["cons"];
			m1=new Manager(strcons);
			this.btDel.Visible=false;

			if(!IsPostBack)
			{
				if(strid==""||strid==null)
				{
					this.btAdd.Enabled=true;
					this.btDel.Enabled=false;
					this.btMod.Enabled=false;
					this.txtGoodsID.ReadOnly=true;
					this.ddlGoodsType.Visible=true;
					this.lbGoodsType.Visible=true;
					this.txtGoodsID.Visible=false;
					this.lbGoodsID.Visible=false;
                    this.FillDropDownList("tbCommCode", ddlGoodsTypeSum, "vcCommSign ='GTSUM'");
                    this.FillDropDownList("tbCommCode", ddlGoodsType, "vcCommSign ='GT'");
                    this.txtComments.Text = this.ddlGoodsTypeSum.SelectedItem.Text + "--" + this.ddlGoodsType.SelectedItem.Text;
                    
					lbltitle.Text="新商品资料录入";
				}
				else
				{
					this.btAdd.Enabled=false;
					this.btDel.Enabled=false;
					this.btMod.Enabled=true;
					CMSMStruct.GoodsStruct gs=m1.GetGoodsInfo(strid);
					txtGoodsID.Text=gs.strGoodsID;
					txtGoodsName.Text=gs.strGoodsName;
					txtSpell.Text=gs.strSpell;
					txtPrice.Text=gs.dPrice.ToString();
					txtigvalue.Text=gs.iIgValue.ToString();
					txtComments.Text=gs.strComments;
					this.txtGoodsID.ReadOnly=true;
					this.txtGoodsName.ReadOnly=false;
					this.ddlGoodsType.Visible=false;
					this.lbGoodsType.Visible=false;
					this.txtGoodsID.Visible=true;
					this.lbGoodsID.Visible=true;
                    this.ddlGoodsTypeSum.Visible = false;
					lbltitle.Text="商品资料修改删除";
					Session["gsold"]=gs;
				}
			}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			this.btMod.Click += new System.EventHandler(this.btMod_Click);
			this.btDel.Click += new System.EventHandler(this.btDel_Click);
			this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btcancel_Click(object sender, System.EventArgs e)
		{
			this.RedirectPage("wfmGoods.aspx");
		}

		private void btAdd_Click(object sender, System.EventArgs e)
		{
			CMSMStruct.GoodsStruct gs=new CMSMStruct.GoodsStruct();

			if(txtGoodsName.Text.Trim()=="")
			{
				this.SetErrorMsgPageBydir("商品名称不能为空！");
				return;
			}
			else if(m1.ChkGoodsNameDup(txtGoodsName.Text.Trim()))
			{
				gs.strGoodsName=txtGoodsName.Text.Trim();
			}
			else
			{
				this.SetErrorMsgPageBydir("该商品名称已经存在，请重新输入！");
				return;	
			}

			if(txtPrice.Text.Trim()=="")
			{
				this.SetErrorMsgPageBydir("商品单价不能为空！");
				return;
			}
			else
			{
				gs.dPrice=Double.Parse(txtPrice.Text.Trim());
			}

			if(txtigvalue.Text.Trim()==""||txtigvalue.Text.Trim()=="0"||int.Parse(txtigvalue.Text.Trim())<-1)
			{
				this.SetErrorMsgPageBydir("兑换分值不正确！");
				return;
			}
			else
			{
				gs.iIgValue=int.Parse(txtigvalue.Text.Trim());
			}


			gs.strSpell=txtSpell.Text.Trim().ToLower();
			gs.strComments=txtComments.Text.Trim();
			gs.strGoodsType=this.ddlGoodsType.SelectedValue;

			if(!m1.InsertGoods(gs))
			{
				this.SetErrorMsgPageBydir("添加商品信息失败，请重试！");
				return;
			}
			else
			{
				this.SetSuccMsgPageBydir("添加商品信息成功！","");
				return;
			}
		}

		private void btMod_Click(object sender, System.EventArgs e)
		{
			CMSMStruct.GoodsStruct gsold=(CMSMStruct.GoodsStruct)Session["gsold"];
			if(gsold.strGoodsID!=txtGoodsID.Text.Trim())
			{
				this.SetErrorMsgPageBydir("保存失败，请重试！");
				return;
			}

			CMSMStruct.GoodsStruct gsnew=new CMSMStruct.GoodsStruct();
			gsnew.strGoodsID=txtGoodsID.Text.Trim();

			if(txtGoodsName.Text.Trim()=="")
			{
				this.SetErrorMsgPageBydir("商品名称不能为空！");
				return;
			}
			else if(m1.ChkNewGoodsNameDup(txtGoodsName.Text.Trim(),gsnew.strGoodsID))
			{
				gsnew.strGoodsName=txtGoodsName.Text.Trim();
			}
			else
			{
				this.SetErrorMsgPageBydir("该商品名称已经存在，请重新输入！");
				return;	
			}

			if(txtPrice.Text.Trim()=="")
			{
				this.SetErrorMsgPageBydir("商品单价不能为空！");
				return;
			}
			else
			{
				gsnew.dPrice=Double.Parse(txtPrice.Text.Trim());
			}

			if(txtigvalue.Text.Trim()==""||txtigvalue.Text.Trim()=="0"||int.Parse(txtigvalue.Text.Trim())<-1)
			{
				this.SetErrorMsgPageBydir("兑换分值不正确！");
				return;
			}
			else
			{
				gsnew.iIgValue=int.Parse(txtigvalue.Text.Trim());
			}

			gsnew.strSpell=txtSpell.Text.Trim().ToLower();
			gsnew.strComments=txtComments.Text.Trim();
            gsnew.strGoodsName = this.txtGoodsName.Text.Trim();

			if(!m1.UpdateGoods(gsnew,gsold))
			{
				this.SetErrorMsgPageBydir("保存商品修改信息失败，请重试！");
				return;
			}
			else
			{
				this.SetSuccMsgPageBydir("保存商品修改信息成功！","");
				return;
			}
		}

		private void btDel_Click(object sender, System.EventArgs e)
		{
		
		}

        protected void ddlGoodsTypeSum_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.FillDropDownList("tbCommCode", ddlGoodsType, "vcCommCode like '" + this.ddlGoodsTypeSum.Text + "%'   and vcCommSign='GT'");
            this.txtComments.Text = this.ddlGoodsTypeSum.SelectedItem.Text + "--" + this.ddlGoodsType.SelectedItem.Text;
;
        }

        protected void ddlGoodsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillDropDownList("tbCommCode", ddlGoodsTypeSum, "vcCommCode = '" + this.ddlGoodsType.Text.Substring(0,2) + "'   and vcCommSign='GTSUM'");
            string aa = this.ddlGoodsTypeSum.SelectedItem.Text;
            this.FillDropDownList("tbCommCode", ddlGoodsTypeSum, "vcCommSign ='GTSUM'");
            this.ddlGoodsTypeSum.SelectedItem.Text = aa;
            this.txtComments.Text = this.ddlGoodsTypeSum.SelectedItem.Text + "--" + this.ddlGoodsType.SelectedItem.Text;
        }

	}
}
