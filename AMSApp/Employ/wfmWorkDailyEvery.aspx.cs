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
using CommCenter;
using BusiComm;

namespace AMSApp.Employ
{
	/// <summary>
	/// Summary description for wfmWorkDailyEvery.
	/// </summary>
	public class wfmWorkDailyEvery : wfmBase
	{
		protected System.Web.UI.WebControls.Button btquery;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.DropDownList ddlDept;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;

		EmpBusi ebu;
		protected string strSchDate;
		protected string strManager;
		protected System.Web.UI.WebControls.Button btnadd;
		protected System.Web.UI.WebControls.Button btnExport;
		protected ucPageView UcPageView1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here

			if(Session["Login"]!=null)
			{
				CMSMStruct.LoginStruct ls1=(CMSMStruct.LoginStruct)Session["Login"];
//				if(ls1.strLimit=="CL003"||ls1.strLimit=="CL004")
//				{
//					this.SetErrorMsgPageBydir("对不起，你没有权限使用此功能！");
//					return;
//				}
				if (!IsPostBack )
				{
					this.FillDropDownList("tbCommCode", ddlDept, "vcCommSign ='MD'");
					if(ls1.strLimit!="CL001")
					{
						ddlDept.Items.FindByValue(ls1.strDeptID).Selected=true;
						ddlDept.Enabled=false;
					}
					strSchDate=DateTime.Now.ToShortDateString();
				}
				else
				{
					strSchDate = Request.Form["txtSchDate"].ToString();
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
			this.btquery.Click += new System.EventHandler(this.btquery_Click);
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btquery_Click(object sender, System.EventArgs e)
		{
			Session.Remove("QUERY");
			string[] SchDatelist=strSchDate.Split('-');
			if(SchDatelist.Length!=3)
			{
				this.SetErrorMsgPageBydir("时间格式不正确！");
				return;
			}
			string strSchID=SchDatelist[0];
			if(int.Parse(SchDatelist[1])<10)
			{
				strSchID+="0" + SchDatelist[1];
			}
			else
			{
				strSchID+=SchDatelist[1];
			}
			if(int.Parse(SchDatelist[2])<10)
			{
				strSchID+="0" + SchDatelist[2];
			}
			else
			{
				strSchID+=SchDatelist[2];
			}
			DateTime datetimesch=new DateTime(int.Parse(SchDatelist[0]),int.Parse(SchDatelist[1]),int.Parse(SchDatelist[2]));
			if(datetimesch.CompareTo(DateTime.Today)<0)
			{
				this.SetErrorMsgPageBydir("不能对以前的排班计划进行修改！");
				return;
			}

			Hashtable htapp=(Hashtable)Application["appconf"];
			string strcons=(string)htapp["cons"];
			ebu=new EmpBusi(strcons);

			if(strSchDate=="")
			{
				this.SetErrorMsgPageBydir("请选择排班日期！");
				return;
			}

			try
			{
				string strDeptName=ddlDept.SelectedItem.Text;
				string strDeptID=ddlDept.SelectedValue;
				DataTable dtout=ebu.GetEveryEmpSchLog(strSchID,strDeptID,strDeptName);
				if(dtout==null)
				{
					this.SetErrorMsgPageBydir("查询排班情况出错！");
					return;
				}
				else
				{
					dtout.TableName="排班情况";
					Session["QUERY"] = dtout;
					UcPageView1.MyDataGrid.PageSize = 30;
					DataView dvOut =new DataView(dtout);
					this.UcPageView1.MyDataSource = dvOut;
					this.UcPageView1.BindGrid();
				}
			}
			catch(Exception er)
			{
				this.clog.WriteLine(er);
				this.SetErrorMsgPageBydir("查询错误，请重试！");
				return;
			}
		}

		private void btnadd_Click(object sender, System.EventArgs e)
		{
			string[] SchDatelist=strSchDate.Split('-');
			if(SchDatelist.Length!=3)
			{
				this.SetErrorMsgPageBydir("时间格式不正确！");
				return;
			}
			string strSchID=SchDatelist[0];
			if(int.Parse(SchDatelist[1])<10)
			{
				strSchID+="0" + SchDatelist[1];
			}
			else
			{
				strSchID+=SchDatelist[1];
			}
			if(int.Parse(SchDatelist[2])<10)
			{
				strSchID+="0" + SchDatelist[2];
			}
			else
			{
				strSchID+=SchDatelist[2];
			}
			DateTime datetimesch=new DateTime(int.Parse(SchDatelist[0]),int.Parse(SchDatelist[1]),int.Parse(SchDatelist[2]));
			if(datetimesch.CompareTo(DateTime.Today)<0)
			{
				this.SetErrorMsgPageBydir("不能对以前的排班计划进行修改！");
				return;
			}
			this.Response.Redirect("wfmEmpEverySchAdd.aspx?date="+strSchID+"&deptid="+ddlDept.SelectedValue+"&deptname="+ddlDept.SelectedItem.Text);
		}

		private void btnExport_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("../wfmFileUp.aspx?XlsType=EmpSch");
		}


	}
}
