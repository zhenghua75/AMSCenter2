using System;
using System.Collections;
using System.ComponentModel;
using System.Web;
using System.Web.SessionState;
using System.Collections.Specialized;
using System.Data;
using DataAccess;
using CommCenter;
using System.Web.Security;
using System.Security.Principal;

namespace AMSApp 
{
	/// <summary>
	/// Summary description for Global.
	/// </summary>
	public class Global : System.Web.HttpApplication
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public Global()
		{
			InitializeComponent();
		}	
		
		protected void Application_Start(Object sender, EventArgs e)
		{
			Hashtable htapp=new Hashtable();
			htapp.Add("cons",System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
			Application["appconf"]=htapp;
			ParaInit(Application);
			AMSApp.zhenghua.Business.Helper.LoadInitCode(Application);
		}
        //protected void Application_AuthenticateRequest(Object sender,
        //                                       EventArgs e)
        //{

        //    // Get the authentication cookie
        //    string cookieName = FormsAuthentication.FormsCookieName;
        //    HttpCookie authCookie = Context.Request.Cookies[cookieName];

        //    // If the cookie can't be found, don't issue the ticket
        //    if (authCookie == null) return;

        //    // Get the authentication ticket and rebuild the principal 
        //    // & identity
        //    FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);
        //    string[] roles = authTicket.UserData.Split(new Char[] { '|' });
        //    GenericIdentity userIdentity =new GenericIdentity(authTicket.Name);
        //    GenericPrincipal userPrincipal = new GenericPrincipal(userIdentity, roles);
        //    Context.User = userPrincipal;
        //}
		protected void Session_Start(Object sender, EventArgs e)
		{

		}

		public void ParaInit(System.Web.HttpApplicationState app)
		{
			try
			{
				DataSet dsIn  = new DataSet();

				InitCode inc=new InitCode();
				Hashtable htapp=(Hashtable)Application["appconf"];
				string strcons=(string)htapp["cons"];
				DataSet dsOut = inc.LoadCodeTable(strcons);			
			
				//错误返回表

				//返回结果存放到Application
				app["tbCommCode"] = dsOut.Tables["tbCommCode"];
				app["AllMD"] = dsOut.Tables["AllMD"];
				app["MAC"] = dsOut.Tables["MAC"];
				app["OperFunc"] = dsOut.Tables["OperFunc"];
				app["IOTime"] = dsOut.Tables["IOTime"];
				app["Goods"] = dsOut.Tables["Goods"];
				app["PClass"] = dsOut.Tables["PClass"];
				app["AllMaterial"] = dsOut.Tables["AllMaterial"];
				app["Provider"] = dsOut.Tables["Provider"];
				app["NewDept"] = dsOut.Tables["NewDept"];
				app["tbNameCodeToStorage"] = dsOut.Tables["tbNameCodeToStorage"];
				app["tbFormula"] = dsOut.Tables["tbFormula"];
				app["DeptMapInfo"] = dsOut.Tables["DeptMapInfo"];
				app["Warehouse"] = dsOut.Tables["Warehouse"];
				app["ComputationGroup"] = dsOut.Tables["ComputationGroup"];
				app["ComputationUnit"] = dsOut.Tables["ComputationUnit"];

				Hashtable htOperFunc=new Hashtable();
				DataTable dttmp=dsOut.Tables["OperFunc"];
				if(dttmp.Rows.Count>0)
				{
					string strOperID="";
					ArrayList alFuncList=null;
					for(int i=0;i<dttmp.Rows.Count;i++)
					{
						CMSMStruct.MenuStruct menu1=new CMSMStruct.MenuStruct();
						menu1.strFuncName=dttmp.Rows[i]["vcFuncName"].ToString();
						menu1.strFuncAddress=dttmp.Rows[i]["vcFuncAddress"].ToString();
						if(strOperID==dttmp.Rows[i]["vcOperID"].ToString())
						{
							alFuncList.Add(menu1);
							if(i==dttmp.Rows.Count-1)
							{
								htOperFunc.Add(strOperID,alFuncList);
							}
						}
						else
						{
							if(strOperID!=""&&alFuncList.Count>0)
							{
								htOperFunc.Add(strOperID,alFuncList);
							}

							alFuncList=new ArrayList();
							alFuncList.Add(menu1);
							strOperID=dttmp.Rows[i]["vcOperID"].ToString();
							if(i==dttmp.Rows.Count-1)
							{
								htOperFunc.Add(strOperID,alFuncList);
							}
						}
					}
				}
				app["OperFunc"]=htOperFunc;

				Hashtable htIOTime=new Hashtable();
				dttmp=null;
				dttmp=dsOut.Tables["IOTime"];
				if(dttmp.Rows.Count>0)
				{
					string strOfficer="";
					ArrayList altmp=null;
					for(int i=0;i<dttmp.Rows.Count;i++)
					{
						CMSMStruct.SignIOTimeStruct sio1=new CommCenter.CMSMStruct.SignIOTimeStruct();
						sio1.strSIOTID=dttmp.Rows[i]["iotName"].ToString();
						sio1.strOfficer=dttmp.Rows[i]["Officer"].ToString();
						sio1.strClassName=dttmp.Rows[i]["vcClassName"].ToString();
						sio1.strClassId=dttmp.Rows[i]["vcClassId"].ToString();
						sio1.strInTime=dttmp.Rows[i]["InTime"].ToString();
						sio1.strOutTime=dttmp.Rows[i]["OutTime"].ToString();
						if(strOfficer==sio1.strOfficer)
						{
							altmp.Add(sio1);
							if(i==dttmp.Rows.Count-1)
							{
								htIOTime.Add(strOfficer,altmp);
							}
						}
						else
						{
							if(strOfficer!=""&&altmp.Count>0)
							{
								htIOTime.Add(strOfficer,altmp);
							}

							altmp=new ArrayList();
							altmp.Add(sio1);
							strOfficer=sio1.strOfficer;
							if(i==dttmp.Rows.Count-1)
							{
								htIOTime.Add(strOfficer,altmp);
							}
						}
					}
				}
				app["IOTime"]=htIOTime;

				app.UnLock();
			}
			catch(Exception e)
			{
				AMSLog clog=new AMSLog();
				clog.WriteLine(e);
			}
			
		}

		protected void Application_BeginRequest(Object sender, EventArgs e)
		{

		}

		protected void Application_EndRequest(Object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(Object sender, EventArgs e)
		{

		}

		protected void Application_Error(Object sender, EventArgs e)
		{

		}

		protected void Session_End(Object sender, EventArgs e)
		{

		}

		protected void Application_End(Object sender, EventArgs e)
		{

		}
			
		#region Web Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.components = new System.ComponentModel.Container();
		}
		#endregion
	}
}

