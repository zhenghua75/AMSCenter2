
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using CommCenter;

namespace AMSApp.StockControl.Services
{
    /// <summary>
    /// 供应商
    /// </summary>
    public class tbSupplier : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string method = context.Request["method"];
            switch (method)
            {
                case "query":
                    context.Response.Write(GettbSupplier(context));
                    break;
                case "all":
                    context.Response.Write(GetAlltbSupplier(context));
                    break;
                case "update":
                    context.Response.Write(updatetbSupplier(context));
                    break;
                case "new":
                    context.Response.Write(newtbSupplier(context));
                    break;
                case "remove":
                    context.Response.Write(removetbSupplier(context));
                    break;
                case "excel":
                    tbSupplierExportToExcel(context);
                    break;
            }
        }
        private IQueryable<AMSCM.Models.tbSupplier> QueryCondition(HttpContext context, AMSCM.Models.AMSCM amscm)
        {
            string strcnvcCode = context.Request["cnvcCode"] == null ? string.Empty : context.Request["cnvcCode"];
            string strcnvcName = context.Request["cnvcName"] == null ? string.Empty : context.Request["cnvcName"];
            string strcnvcAddress = context.Request["cnvcAddress"] == null ? string.Empty : context.Request["cnvcAddress"];
            string strcnvcPostCode = context.Request["cnvcPostCode"] == null ? string.Empty : context.Request["cnvcPostCode"];
            string strcnvcPhone = context.Request["cnvcPhone"] == null ? string.Empty : context.Request["cnvcPhone"];
            string strcnvcFax = context.Request["cnvcFax"] == null ? string.Empty : context.Request["cnvcFax"];
            string strcnvcEmail = context.Request["cnvcEmail"] == null ? string.Empty : context.Request["cnvcEmail"];
            string strcnvcLinkName = context.Request["cnvcLinkName"] == null ? string.Empty : context.Request["cnvcLinkName"];
            string strcnvcCreateOper = context.Request["cnvcCreateOper"] == null ? string.Empty : context.Request["cnvcCreateOper"];
            string strcndCreateDate = context.Request["cndCreateDate"] == null ? string.Empty : context.Request["cndCreateDate"];
            string strcndCreateDate1 = context.Request["cndCreateDate1"] == null ? string.Empty : context.Request["cndCreateDate1"];
            string strcnbInvalid = context.Request["cnbInvalid"] == null ? string.Empty : context.Request["cnbInvalid"];
            string strIsInvalid = context.Request["IsInvalid"] == null ? string.Empty : context.Request["IsInvalid"];
            
            string strq = context.Request["q"] == null ? string.Empty : context.Request["q"];            
            var q = from p in amscm.tbSupplier select p;
            if (strcnvcCode != string.Empty) q = q.Where(w => w.cnvcCode.Contains(strcnvcCode));
            if (strcnvcName != string.Empty) q = q.Where(w => w.cnvcName.Contains(strcnvcName));
            if (strcnvcAddress != string.Empty) q = q.Where(w => w.cnvcAddress.Contains(strcnvcAddress));
            if (strcnvcPostCode != string.Empty) q = q.Where(w => w.cnvcPostCode.Contains(strcnvcPostCode));
            if (strcnvcPhone != string.Empty) q = q.Where(w => w.cnvcPhone.Contains(strcnvcPhone));
            if (strcnvcFax != string.Empty) q = q.Where(w => w.cnvcFax.Contains(strcnvcFax));
            if (strcnvcEmail != string.Empty) q = q.Where(w => w.cnvcEmail.Contains(strcnvcEmail));
            if (strcnvcLinkName != string.Empty) q = q.Where(w => w.cnvcLinkName.Contains(strcnvcLinkName));
            if (strcnvcCreateOper != string.Empty) q = q.Where(w => w.cnvcCreateOper == strcnvcCreateOper);
            if (strcndCreateDate != string.Empty)
            {
                DateTime dCreateDate = Convert.ToDateTime(strcndCreateDate);
                q = q.Where(w => w.cndCreateDate >= dCreateDate);
            }
            if (strcndCreateDate1 != string.Empty)
            {
                DateTime dCreateDate1 = Convert.ToDateTime(strcndCreateDate1);
                q = q.Where(w => w.cndCreateDate <= dCreateDate1);
            }
            if (strcnbInvalid != string.Empty) q = q.Where(w => w.cnbInvalid == true);
            if (strIsInvalid != string.Empty)
            {
                bool bInvalid = Convert.ToBoolean(strIsInvalid);
                q = q.Where(w => w.cnbInvalid == bInvalid);
            }
            if (strq != string.Empty) q = q.Where(w => w.cnvcCode.Contains(strq) || w.cnvcName.Contains(strq));
            return q;
        }
        private DataTable List2DataTable(HttpContext context, List<AMSCM.Models.tbSupplier> ltbSupplier)
        {
            DataTable dt = ltbSupplier.ToDataTable<AMSCM.Models.tbSupplier>();
            ServiceHelper.DataTableConvert(context, dt, "cnbInvalid");
            return dt;
        }
        private string GettbSupplier(HttpContext context)
        {
            int page = context.Request["page"] == null ? 1 : Convert.ToInt32(context.Request["page"]);
            int rows = context.Request["rows"] == null ? 10 : Convert.ToInt32(context.Request["rows"]);
            string totalcount = "";
            List<AMSCM.Models.tbSupplier> ltbSupplier = new List<AMSCM.Models.tbSupplier>();

            int skitCount = (page - 1) * rows;
            using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
            {

                var q = QueryCondition(context, amscm);
                totalcount = q.Count().ToString();
                ltbSupplier = q.OrderBy(o => o.cnvcCode)
                    .Skip(skitCount)
                    .Take(rows).ToList();
            }
            DataTable dt = List2DataTable(context, ltbSupplier);
            return ServiceHelper.DataTableToEasyUIDataGridJson(dt, totalcount);

        }
        private string newtbSupplier(HttpContext context)
        {
            try
            {
                using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
                {
                    AMSCM.Models.tbSupplier tbSupplier = new AMSCM.Models.tbSupplier();
                    tbSupplier.cnvcCode = context.Request.Form["cnvcCode"];
                    tbSupplier.cnvcName = context.Request.Form["cnvcName"];
                    tbSupplier.cnvcAddress = context.Request.Form["cnvcAddress"];
                    tbSupplier.cnvcPostCode = context.Request.Form["cnvcPostCode"];
                    tbSupplier.cnvcPhone = context.Request.Form["cnvcPhone"];
                    tbSupplier.cnvcFax = context.Request.Form["cnvcFax"];
                    tbSupplier.cnvcEmail = context.Request.Form["cnvcEmail"];
                    tbSupplier.cnvcLinkName = context.Request.Form["cnvcLinkName"];
                    //tbSupplier.cnvcCreateOper = context.Request.Form["cnvcCreateOper"];
                    CMSMStruct.LoginStruct ls1 = (CMSMStruct.LoginStruct)context.Session["Login"];
                    tbSupplier.cnvcCreateOper = ls1.strOperName;
                    tbSupplier.cndCreateDate = DateTime.Now;//context.Request.Form["cndCreateDate"];
                    tbSupplier.cnbInvalid = context.Request.Form["cnbInvalid"]=="on"?true:false;

                    amscm.tbSupplier.Add(tbSupplier);
                    amscm.SaveChanges();
                }
            }
            catch (DbUpdateException dex)
            {
                ExceptionPolicy.HandleException(dex, ServiceHelper.ExceptionPolicy);
                return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, dex.Message));
            }
            return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(true, ""));
        }
        private string updatetbSupplier(HttpContext context)
        {
            try
            {
                using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
                {
                    AMSCM.Models.tbSupplier tbSupplier = amscm.tbSupplier.Find(context.Request.Form["cnvcCode"]);
                    tbSupplier.cnvcCode = context.Request.Form["cnvcCode"];
                    tbSupplier.cnvcName = context.Request.Form["cnvcName"];
                    tbSupplier.cnvcAddress = context.Request.Form["cnvcAddress"];
                    tbSupplier.cnvcPostCode = context.Request.Form["cnvcPostCode"];
                    tbSupplier.cnvcPhone = context.Request.Form["cnvcPhone"];
                    tbSupplier.cnvcFax = context.Request.Form["cnvcFax"];
                    tbSupplier.cnvcEmail = context.Request.Form["cnvcEmail"];
                    tbSupplier.cnvcLinkName = context.Request.Form["cnvcLinkName"];
                    //CMSMStruct.LoginStruct ls1 = (CMSMStruct.LoginStruct)context.Session["Login"];
                    //tbSupplier.cnvcCreateOper = ls1.strOperName;
                    //tbSupplier.cnvcCreateOper = context.Request.Form["cnvcCreateOper"];
                    //tbSupplier.cndCreateDate = context.Request.Form["cndCreateDate"];
                    tbSupplier.cnbInvalid = context.Request.Form["cnbInvalid"]=="on"?true:false;

                    amscm.SaveChanges();
                }
            }
            catch (NullReferenceException nex)
            {
                ExceptionPolicy.HandleException(nex, ServiceHelper.ExceptionPolicy);
                return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, nex.Message));
            }
            catch (DbUpdateException dex)
            {
                ExceptionPolicy.HandleException(dex, ServiceHelper.ExceptionPolicy);
                return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, dex.Message));
            }
            return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(true, ""));
        }
        private string removetbSupplier(HttpContext context)
        {
            try
            {
                using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
                {
                    AMSCM.Models.tbSupplier tbSupplier = amscm.tbSupplier.Find(context.Request.Form["cnvcCode"]);
                    amscm.tbSupplier.Remove(tbSupplier);
                    amscm.SaveChanges();
                }
            }
            catch (ArgumentNullException aex)
            {
                ExceptionPolicy.HandleException(aex, ServiceHelper.ExceptionPolicy);
                return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, aex.Message));
            }
            catch (DbUpdateException dex)
            {
                ExceptionPolicy.HandleException(dex, ServiceHelper.ExceptionPolicy);
                return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, dex.Message));
            }
            return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(true, ""));
        }
        private void tbSupplierExportToExcel(HttpContext context)
        {
            string fileName = "供应商.xls";

            List<AMSCM.Models.tbSupplier> ltbSupplier = new List<AMSCM.Models.tbSupplier>();

            using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
            {
                var q = QueryCondition(context, amscm);
                ltbSupplier = q.OrderBy(o => o.cnvcCode).ToList();
            }
            DataTable dt = List2DataTable(context, ltbSupplier);
            GridView view = new GridView();
            view.AutoGenerateColumns = false;

            BoundField field;

            field = new BoundField();
            field.DataField = "cnvcCode";
            field.HeaderText = "";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cnvcName";
            field.HeaderText = "";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cnvcAddress";
            field.HeaderText = "";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cnvcPostCode";
            field.HeaderText = "";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cnvcPhone";
            field.HeaderText = "";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cnvcFax";
            field.HeaderText = "";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cnvcEmail";
            field.HeaderText = "";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cnvcLinkName";
            field.HeaderText = "";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cnvcCreateOper";
            field.HeaderText = "";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cndCreateDate";
            field.HeaderText = "";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cnbInvalid";
            field.HeaderText = "";
            view.Columns.Add(field);


            view.DataSource = dt;
            view.DataBind();

            ServiceHelper.DoExportToExcel(context, fileName, view);
        }
        private string GetAlltbSupplier(HttpContext context)
        {
            List<AMSCM.Models.tbSupplier> ltbSupplier = new List<AMSCM.Models.tbSupplier>();

            using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
            {

                ltbSupplier = amscm.tbSupplier.Where(w=>w.cnbInvalid==false).ToList();
            }
            DataTable dt = List2DataTable(context, ltbSupplier);
            return ServiceHelper.DataTableToEasyUIJson(dt);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
