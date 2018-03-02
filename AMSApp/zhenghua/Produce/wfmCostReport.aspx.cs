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
using AMSApp.zhenghua;
using AMSApp.zhenghua.Business;
namespace AMSApp.zhenghua.Produce
{
	/// <summary>
	/// wfmCostReport ��ժҪ˵����
	/// </summary>
	public class wfmCostReport : wfmBase
	{
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.DropDownList ddlDept;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.TextBox txtBeginDate;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.TextBox txtEndDate;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.DropDownList DropDownList1;
		protected System.Web.UI.WebControls.DropDownList ddlProType;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.DropDownList ddlProClass;
		protected ucPageView UcPageView1;
		private void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
			if(!this.IsPostBack)
			{
				this.BindDept(ddlDept, "cnvcDeptType <>'Corp'");
				ListItem li = new ListItem("����", "%");
				this.ddlDept.Items.Add(li);
				this.SetDDL(this.ddlDept,this.oper.strDeptID);
				if(this.oper.strDeptID !="CEN00")
				{				
					this.ddlDept.Enabled = false;		
				}
				this.txtBeginDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
				this.txtEndDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

				this.FillDropDownList("tbNameCodeToStorage",this.ddlProType,"vcCommSign='PRODUCTTYPE'");
				//ListItem li = new ListItem("ȫ��","%");
				this.FillDropDownList("PClass",this.ddlProClass,"");

				this.ddlProType.Items.Insert(0,li);
				this.ddlProClass.Items.Insert(0,li);
			}
		}

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    
			this.ddlProType.SelectedIndexChanged += new System.EventHandler(this.ddlProType_SelectedIndexChanged);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private DataTable query()
		{
			DataTable dtOut1 = Helper.QueryLongTrans("ProduceCostReport '"+ddlDept.SelectedValue+"','"+txtBeginDate.Text+"','"+txtEndDate.Text+"'"+",'"+ddlProType.SelectedValue+"'"+",'"+ddlProClass.SelectedValue+"'");			
			return dtOut1;
		}
		private void Button1_Click(object sender, System.EventArgs e)
		{
			//����
			DataTable dt = query();
			string str = this.ExportTable(dt);
			this.ExportToXls(this,"�����ɱ����㱨��",str);
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			//��ѯ
			DataTable dtOut1 = query();
			UcPageView1.MyDataGrid.PageSize = 30;
			DataView dvOut =new DataView(dtOut1);
			this.UcPageView1.MyDataSource = dvOut;
			this.UcPageView1.BindGrid();
		}

		private void ddlProType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//
			this.FillDropDownList("PClass",this.ddlProClass,"vcCommSign='"+this.ddlProType.SelectedValue+"'");
			ListItem li = new ListItem("����", "%");
			this.ddlProClass.Items.Insert(0,li);
		}
	}
}