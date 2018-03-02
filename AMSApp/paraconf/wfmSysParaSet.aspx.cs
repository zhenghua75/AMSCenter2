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

namespace AMSApp.paraconf
{
	/// <summary>
	/// Summary description for wfmSysParaSet.
	/// </summary>
	public class wfmSysParaSet : wfmBase
	{
		protected System.Web.UI.WebControls.Button btIg;
		protected System.Web.UI.WebControls.Button btProm;
		protected System.Web.UI.WebControls.ListBox lbtcurrent;
		protected System.Web.UI.WebControls.Button btAdd;
		protected System.Web.UI.WebControls.Button btDel;
		protected System.Web.UI.WebControls.Button btNewGoods;
		protected System.Web.UI.WebControls.ListBox lbtNew;
		protected System.Web.UI.WebControls.TextBox txtFee;
		protected System.Web.UI.WebControls.TextBox txtIg;
		protected System.Web.UI.WebControls.TextBox txtPromRate1;
		protected System.Web.UI.WebControls.TextBox txtPromRate2;
		protected System.Web.UI.WebControls.TextBox txtPromRate3;
		protected System.Web.UI.HtmlControls.HtmlForm Form3;
		protected System.Web.UI.WebControls.TextBox txtPromRate4;
		protected System.Web.UI.WebControls.TextBox txtPromRate5;

		Manager m1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if(Session["Login"]!=null)
			{
//				CMSMStruct.LoginStruct ls1=(CMSMStruct.LoginStruct)Session["Login"];
//				if(ls1.strLimit!="CL001")
//				{
//					this.SetErrorMsgPageBydir("对不起，你没有权限使用此功能！");
//					return;
//				}
				if (!IsPostBack )
				{
					Hashtable htapp=(Hashtable)Application["appconf"];
					string strcons=(string)htapp["cons"];
					m1=new Manager(strcons);

					DataTable dtgoods=m1.GetAllGoodsName();
					for(int i=0;i<dtgoods.Rows.Count;i++)
					{
						lbtcurrent.Items.Add(dtgoods.Rows[i]["vcGoodsName"].ToString());
						if(dtgoods.Rows[i]["cNewFlag"].ToString()=="1")
						{
							lbtNew.Items.Add(dtgoods.Rows[i]["vcGoodsName"].ToString());
						}	
					}

					DataTable dtig=m1.GetIgPara();
					if(dtig.Rows.Count>0)
					{
						txtFee.Text=dtig.Rows[0]["vcCommName"].ToString();
						txtIg.Text=dtig.Rows[0]["vcCommCode"].ToString();
					}
					else
					{
						txtFee.Text="";
						txtIg.Text="";
					}

					Hashtable htprom=m1.GetPromRate();
					if(htprom.ContainsKey("FP1"))
					{
						txtPromRate1.Text=htprom["FP1"].ToString();
					}
					else
					{
						txtPromRate1.Text="0";
					}
					if(htprom.ContainsKey("FP2"))
					{
						txtPromRate2.Text=htprom["FP2"].ToString();
					}
					else
					{
						txtPromRate2.Text="0";
					}

					if(htprom.ContainsKey("FP3"))
					{
						txtPromRate3.Text=htprom["FP3"].ToString();
					}
					else
					{
						txtPromRate3.Text="0";
					}
					if(htprom.ContainsKey("FP4"))
					{
						txtPromRate4.Text=htprom["FP4"].ToString();
					}
					else
					{
						txtPromRate4.Text="0";
					}
					if(htprom.ContainsKey("FP5"))
					{
						txtPromRate5.Text=htprom["FP5"].ToString();
					}
					else
					{
						txtPromRate5.Text="0";
					}
				}
			}
			else
			{
				Response.Redirect("../Exit.aspx");
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
			this.btDel.Click += new System.EventHandler(this.btDel_Click);
			this.btNewGoods.Click += new System.EventHandler(this.btNewGoods_Click);
			this.btIg.Click += new System.EventHandler(this.btIg_Click);
			this.btProm.Click += new System.EventHandler(this.btProm_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btAdd_Click(object sender, System.EventArgs e)
		{
			if(lbtcurrent.Items.Count==0)
			{
				this.SetErrorMsgPageBydir("没有商品信息，请先录入商品信息！");
				return;
			}
			if(lbtNew.Items.Count>=10)
			{
				this.SetErrorMsgPageBydir("推荐新品只能设置10个！");
				return;
			}
			for(int i=0;i<lbtNew.Items.Count;i++)
			{
				if(lbtcurrent.SelectedItem.Text==lbtNew.Items[i].ToString())
				{
					return;
				}
			}
			if(lbtcurrent.SelectedItem==null)
			{
				this.SetErrorMsgPageBydir("请确定选中某个商品！");
				return;
			}
			else
			{
				lbtNew.Items.Add(lbtcurrent.SelectedItem.Text);
			}
		}

		private void btDel_Click(object sender, System.EventArgs e)
		{
			if(lbtNew.Items.Count==0)
			{
				this.SetErrorMsgPageBydir("目前还没有要推荐的商品！");
				return;
			}
			lbtNew.Items.Remove(lbtNew.SelectedItem);
		}

		private void btNewGoods_Click(object sender, System.EventArgs e)
		{
			ArrayList al=new ArrayList();
			for(int i=0;i<lbtNew.Items.Count;i++)
			{
				al.Add(lbtNew.Items[i].Text.Trim());
			}
			Hashtable htapp=(Hashtable)Application["appconf"];
			string strcons=(string)htapp["cons"];
			m1=new Manager(strcons);

			if(m1.UpdateGoodsNewFlag(al))
			{
				this.SetSuccMsgPageBydir("推荐新品设置成功！","paraconf/wfmSysParaSet.aspx");
				return;
			}
			else
			{
				this.SetErrorMsgPageBydir("推荐新品设置失败！");
				return;
			}
		}

		private void btIg_Click(object sender, System.EventArgs e)
		{
			CMSMStruct.CommStruct cos=new CMSMStruct.CommStruct();
			if(txtFee.Text.Trim()=="")
			{
				cos.strCommName="0";
			}
			else if(double.Parse(txtFee.Text.Trim())<0)
			{
				this.SetErrorMsgPageBydir("消费金额不能小于0！");
				return;
			}
			else
			{
				cos.strCommName=txtFee.Text.Trim();
			}

			if(txtIg.Text.Trim()=="")
			{
				cos.strCommCode="0";
			}
			else if(double.Parse(txtIg.Text.Trim())<0)
			{
				this.SetErrorMsgPageBydir("赠送积分分值不能小于0！");
				return;
			}
			else
			{
				cos.strCommCode=txtIg.Text.Trim();
			}
			cos.strCommSign="IG";
			cos.strComments="积分赠送";

			Hashtable htapp=(Hashtable)Application["appconf"];
			string strcons=(string)htapp["cons"];
			m1=new Manager(strcons);

			if(m1.UpdateIgComm(cos))
			{
				this.SetSuccMsgPageBydir("消费积分设置成功！","paraconf/wfmSysParaSet.aspx");
				return;
			}
			else
			{
				this.SetErrorMsgPageBydir("消费积分设置失败！");
				return;
			}
		}

		private void btProm_Click(object sender, System.EventArgs e)
		{
			CMSMStruct.CommStruct cos=new CMSMStruct.CommStruct();
			Hashtable htpar=new Hashtable();
			if(txtPromRate1.Text.Trim()=="")
			{
				cos.strCommCode="0";
			}
			else if(double.Parse(txtPromRate1.Text.Trim())<0)
			{
				this.SetErrorMsgPageBydir("充值赠款比例不能小于0！");
				return;
			}
			else
			{
				cos.strCommCode=txtPromRate1.Text.Trim();
			}
			cos.strCommName="充值赠款100-200";
			cos.strCommSign="FP1";
			cos.strComments="充值赠款";
			htpar.Add("FP1",cos);

			CMSMStruct.CommStruct cos2=new CMSMStruct.CommStruct();
			if(txtPromRate2.Text.Trim()=="")
			{
				cos2.strCommCode="0";
			}
			else if(double.Parse(txtPromRate2.Text.Trim())<0)
			{
				this.SetErrorMsgPageBydir("充值赠款比例不能小于0！");
				return;
			}
			else
			{
				cos2.strCommCode=txtPromRate2.Text.Trim();
			}
			cos2.strCommName="充值赠款200-300";
			cos2.strCommSign="FP2";
			cos2.strComments="充值赠款";
			htpar.Add("FP2",cos2);

			CMSMStruct.CommStruct cos3=new CMSMStruct.CommStruct();
			if(txtPromRate3.Text.Trim()=="")
			{
				cos3.strCommCode="0";
			}
			else if(double.Parse(txtPromRate3.Text.Trim())<0)
			{
				this.SetErrorMsgPageBydir("充值赠款比例不能小于0！");
				return;
			}
			else
			{
				cos3.strCommCode=txtPromRate3.Text.Trim();
			}
			cos3.strCommName="充值赠款300-400";
			cos3.strCommSign="FP3";
			cos3.strComments="充值赠款";
			htpar.Add("FP3",cos3);

			CMSMStruct.CommStruct cos4=new CMSMStruct.CommStruct();
			if(txtPromRate4.Text.Trim()=="")
			{
				cos4.strCommCode="0";
			}
			else if(double.Parse(txtPromRate4.Text.Trim())<0)
			{
				this.SetErrorMsgPageBydir("充值赠款比例不能小于0！");
				return;
			}
			else
			{
				cos4.strCommCode=txtPromRate4.Text.Trim();
			}
			cos4.strCommName="充值赠款400-500";
			cos4.strCommSign="FP4";
			cos4.strComments="充值赠款";
			htpar.Add("FP4",cos4);

			CMSMStruct.CommStruct cos5=new CMSMStruct.CommStruct();
			if(txtPromRate5.Text.Trim()=="")
			{
				cos5.strCommCode="0";
			}
			else if(double.Parse(txtPromRate5.Text.Trim())<0)
			{
				this.SetErrorMsgPageBydir("充值赠款比例不能小于0！");
				return;
			}
			else
			{
				cos5.strCommCode=txtPromRate5.Text.Trim();
			}
			cos5.strCommName="充值赠款500以上";
			cos5.strCommSign="FP5";
			cos5.strComments="充值赠款";
			htpar.Add("FP5",cos5);

			Hashtable htapp=(Hashtable)Application["appconf"];
			string strcons=(string)htapp["cons"];
			m1=new Manager(strcons);

			if(m1.UpdateFillPromComm(htpar))
			{
				this.SetSuccMsgPageBydir("消费积分设置成功！","paraconf/wfmSysParaSet.aspx");
				return;
			}
			else
			{
				this.SetErrorMsgPageBydir("消费积分设置失败！");
				return;
			}
		}
	}
}
