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
	/// Summary description for wfmEmpEverySchAdd.
	/// </summary>
	public class wfmEmpEverySchAdd : wfmBase
	{
		protected System.Web.UI.WebControls.Button btcancel;
		protected System.Web.UI.WebControls.DropDownList ddlClass;
		protected System.Web.UI.WebControls.DropDownList ddlInMinute;
		protected System.Web.UI.WebControls.DropDownList ddlInHour;
		protected System.Web.UI.WebControls.DropDownList ddlOutMinute;
		protected System.Web.UI.WebControls.DropDownList ddlOutHour;
		protected System.Web.UI.WebControls.Button btadd;
		protected System.Web.UI.WebControls.TextBox txtDept;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;

		EmpBusi ebu;
		protected System.Web.UI.WebControls.TextBox txtSchDate;
		protected System.Web.UI.WebControls.ListBox ltbEmp;
		protected System.Web.UI.WebControls.Button btSelect;
		protected System.Web.UI.WebControls.Button btUnselect;
		protected System.Web.UI.WebControls.CheckBox chcSecDay;
		protected System.Web.UI.WebControls.ListBox ltbSelect;
		protected System.Web.UI.WebControls.Label lblDeptID;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if(Session["Login"]!=null)
			{
//				CMSMStruct.LoginStruct ls1=(CMSMStruct.LoginStruct)Session["Login"];
//				if(ls1.strLimit=="CL003"||ls1.strLimit=="CL004")
//				{
//					this.SetErrorMsgPageBydir("对不起，你没有权限使用此功能！");
//					return;
//				}
				if (!IsPostBack )
				{
					if(Request.QueryString.HasKeys())
					{
						this.lblDeptID.Text=Request.QueryString["deptid"];
						this.txtDept.Text=Request.QueryString["deptname"];
						this.txtSchDate.Text=Request.QueryString["date"];
						this.txtDept.ReadOnly=true;
						txtSchDate.ReadOnly=true;
					}
					this.FillDropDownList("tbCommCode", ddlClass, "vcCommSign ='EC'");
					for(int j=0;j<=23;j++)
					{
						if(j<10)
						{
							this.ddlInHour.Items.Add("0"+j.ToString());
							this.ddlOutHour.Items.Add("0"+j.ToString());
						}
						else
						{
							this.ddlInHour.Items.Add(j.ToString());
							this.ddlOutHour.Items.Add(j.ToString());
						}
					}
					this.ddlInMinute.Items.Add("00");
					this.ddlInMinute.Items.Add("15");
					this.ddlInMinute.Items.Add("30");
					this.ddlInMinute.Items.Add("45");

					this.ddlOutMinute.Items.Add("00");
					this.ddlOutMinute.Items.Add("15");
					this.ddlOutMinute.Items.Add("30");
					this.ddlOutMinute.Items.Add("45");

					Hashtable htapp=(Hashtable)Application["appconf"];
					string strcons=(string)htapp["cons"];
					ebu=new EmpBusi(strcons);

					DataTable dtout=ebu.GetAllEmpName(this.lblDeptID.Text.Trim(),this.txtSchDate.Text.Trim());
					for(int i=0;i<dtout.Rows.Count;i++)
					{
						this.ltbEmp.Items.Add(dtout.Rows[i]["vcEmpName"].ToString());
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
			this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
			this.btUnselect.Click += new System.EventHandler(this.btUnselect_Click);
			this.ddlClass.SelectedIndexChanged += new System.EventHandler(this.ddlClass_SelectedIndexChanged);
			this.btadd.Click += new System.EventHandler(this.btadd_Click);
			this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btadd_Click(object sender, System.EventArgs e)
		{
			Hashtable htapp=(Hashtable)Application["appconf"];
			string strcons=(string)htapp["cons"];
			ebu=new EmpBusi(strcons);

			string strManager="";
			if(this.lblDeptID.Text.Trim()!="")
			{
				DataTable dtMana=ebu.GetEmpManager(this.lblDeptID.Text.Trim());
				for(int i=0;i<dtMana.Rows.Count;i++)
				{
					strManager+=dtMana.Rows[i]["vcEmpName"].ToString()+",";
				}
				if(strManager!="")
				{
					strManager=strManager.Substring(0,strManager.Length-1);
				}
			}
			else
			{
				this.SetErrorMsgPageBydirHistory("门店信息错误！");
				return;
			}

			double strInHour=double.Parse(ddlInHour.SelectedItem.Text);
			double strInMinute=double.Parse(ddlInMinute.SelectedItem.Text);
			double strOutHour=double.Parse(ddlOutHour.SelectedItem.Text);
			double strOutMinute=double.Parse(ddlOutMinute.SelectedItem.Text);
			double dateHourLong=0;
			double dateMinuteLong=0;
			if(chcSecDay.Checked)
			{
				if(this.ddlClass.SelectedValue!="5")
				{
					dateHourLong=(24-strInHour)+strOutHour;
					if(strInMinute==strOutMinute)
					{
						dateMinuteLong=0;
					}
					else if(strInMinute<strOutMinute)
					{
						dateMinuteLong=Math.Round(((strOutMinute-strInMinute)/60),2);
					}
					else
					{
						dateMinuteLong=Math.Round((strInMinute-strOutMinute)/60,2);
					}
					if((dateHourLong+dateMinuteLong)<=2.5)
					{
						this.SetErrorMsgPageBydirHistory("每班次的上班时间不能小于等于2.5小时！");
						return;
					}
				}
			}
			else
			{
				if(this.ddlClass.SelectedValue!="5")
				{
					if(strInHour>strOutHour)
					{
						this.SetErrorMsgPageBydirHistory("上班时间不能大于下班时间！");
						return;
					}
					dateHourLong=strOutHour-strInHour;
					if(strInMinute==strOutMinute)
					{
						dateMinuteLong=0;
					}
					else if(strInMinute<strOutMinute)
					{
						dateMinuteLong=Math.Round((strOutMinute-strInMinute)/60,2);
					}
					else
					{
						dateMinuteLong=Math.Round((strInMinute-strOutMinute)/60,2);
					}
					if((dateHourLong+dateMinuteLong)<=2.5)
					{
						this.SetErrorMsgPageBydirHistory("每班次的上班时间不能小于等于2.5小时！");
						return;
					}
				}
			}

			ArrayList alsuc=new ArrayList();
			ArrayList alfail=new ArrayList();
			for(int k=0;k<this.ltbSelect.Items.Count;k++)
			{
				CMSMStruct.EmpSchLogStruct empschlog =new CMSMStruct.EmpSchLogStruct();
				empschlog.strManager=strManager;
				empschlog.strSchID=this.txtSchDate.Text.Trim();
				empschlog.strEmpName=this.ltbSelect.Items[k].Text.Trim();
				empschlog.strDeptName=this.txtDept.Text.Trim();
				empschlog.strClass=this.ddlClass.SelectedItem.Text;	
		
				CMSMStruct.EmployeeStruct emp1=ebu.GetEmpInfoByName(empschlog.strEmpName);
				if(emp1.strCardID==""||emp1.strCardID==null)
				{
					alfail.Add(empschlog.strEmpName+"  失败原因:获取卡号出错，请检查员工姓名是否正确！");
					continue;
				}
				else
				{
					empschlog.strCardID=emp1.strCardID;
					empschlog.strEmpOF=emp1.strOfficer;
				}
				
				if(ebu.IsEmpSchAllDayWork(empschlog.strSchID,empschlog.strCardID,empschlog.strClass))
				{
					alfail.Add(empschlog.strEmpName+"  失败原因:排班表中不可即有全日班或休息，又有其它班次！");
					continue;
				}

				if(ebu.IsEmpSchDupClass(empschlog.strSchID,empschlog.strCardID,empschlog.strClass))
				{
					alfail.Add(empschlog.strEmpName+"  失败原因:排班表中已经存在"+empschlog.strClass+"信息！");
					continue;
				}

				empschlog.strSchID=this.txtSchDate.Text.Trim();
				if(empschlog.strClass!="休息")
				{
					string strDate=empschlog.strSchID.Substring(0,4)+"-"+empschlog.strSchID.Substring(4,2)+"-"+empschlog.strSchID.Substring(6,2);
					empschlog.strCheckIn=strDate+" "+strInHour.ToString()+":"+strInMinute.ToString()+":00";
					if(chcSecDay.Checked)
					{
						DateTime dtdate=new DateTime(int.Parse(empschlog.strSchID.Substring(0,4)),int.Parse(empschlog.strSchID.Substring(4,2)),int.Parse(empschlog.strSchID.Substring(6,2)));
						DateTime dtnewdate=dtdate.AddDays(1);
						empschlog.strCheckOut=dtnewdate.ToShortDateString()+" "+strOutHour.ToString()+":"+strOutMinute.ToString()+":00";
					}
					else
					{
						empschlog.strCheckOut=strDate+" "+strOutHour.ToString()+":"+strOutMinute.ToString()+":00";
					}
				}
				if(empschlog.strClass!="休息"&&empschlog.strClass!="全日班")
				{
					if(ebu.IsErrorTimespanWithTwoClass(empschlog))
					{
						alfail.Add(empschlog.strEmpName+"  失败原因:两相邻班次之间的时间间隔不得小于2.5小时！");
						continue;
					}
				}
								
				if(ebu.SchedEmpDailyEvery(empschlog))
					alsuc.Add(empschlog.strEmpName);
			}

			string strinfo="--------成功员工列表--------<br>";
			for(int m=0;m<alsuc.Count;m++)
			{
				strinfo+=alsuc[m].ToString()+"<br>";
			}
			strinfo+="--------失败员工列表--------<br>";
			for(int n=0;n<alfail.Count;n++)
			{
				strinfo+=alfail[n].ToString()+"<br>";
			}
			this.SetSuccMsgPageBydir("添加员工排班表完成，如果有失败请检查是否该员工已经有该班次的排班信息了！<br>"+strinfo,"Employ/wfmWorkDailyEvery.aspx");
		}

		private void btcancel_Click(object sender, System.EventArgs e)
		{
			this.Response.Redirect("wfmWorkDailyEvery.aspx");
		}

		private void btSelect_Click(object sender, System.EventArgs e)
		{
			if(this.ltbEmp.SelectedIndex<0)
			{
				this.SetErrorMsgPageBydirHistory("请先选中要排班的员工！");
				return;
			}
			this.ltbSelect.Items.Add(this.ltbEmp.SelectedValue);
			this.ltbEmp.Items.Remove(this.ltbEmp.SelectedItem);
		}

		private void btUnselect_Click(object sender, System.EventArgs e)
		{
			if(this.ltbSelect.SelectedIndex<0)
			{
				this.SetErrorMsgPageBydirHistory("请先选中要移除的员工！");
				return;
			}
			this.ltbEmp.Items.Add(this.ltbSelect.SelectedValue);
			this.ltbSelect.Items.Remove(this.ltbSelect.SelectedItem);
		}

		private void ddlClass_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.ddlClass.SelectedValue=="5")
			{
				this.ddlInHour.Enabled=false;
				this.ddlInMinute.Enabled=false;
				this.ddlOutHour.Enabled=false;
				this.ddlOutMinute.Enabled=false;
			}
			else
			{
				this.ddlInHour.Enabled=true;
				this.ddlInMinute.Enabled=true;
				this.ddlOutHour.Enabled=true;
				this.ddlOutMinute.Enabled=true;
			}
		}
	}
}
