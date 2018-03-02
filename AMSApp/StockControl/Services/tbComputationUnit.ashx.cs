
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System.Web.UI.WebControls;
using System.Web.SessionState;

namespace AMSApp.StockControl.Services
{
    /// <summary>
    /// 计量单位
    /// </summary>
    public class tbComputationUnit : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string method = context.Request["method"];
            switch (method)
            {
                case "query":
                    context.Response.Write(GettbComputationUnit(context));
                    break;
                case "all":
                    context.Response.Write(GetAlltbComputationUnit(context));
                    break;
                case "update":
                    context.Response.Write(updatetbComputationUnit(context));
                    break;
                case "new":
                    context.Response.Write(newtbComputationUnit(context));
                    break;
                case "remove":
                    context.Response.Write(removetbComputationUnit(context));
                    break;
                case "excel":
                    tbComputationUnitExportToExcel(context);
                    break;
            }
        }
        private IQueryable<AMSCM.Models.tbComputationUnit> QueryCondition(HttpContext context, AMSCM.Models.AMSCM amscm)
        {
            string strcnvcComunitCode = context.Request["cnvcComunitCode"] == null ? string.Empty : context.Request["cnvcComunitCode"];
            string strcnvcComUnitName = context.Request["cnvcComUnitName"] == null ? string.Empty : context.Request["cnvcComUnitName"];
            string strcnvcGroupCode = context.Request["cnvcGroupCode"] == null ? string.Empty : context.Request["cnvcGroupCode"];
            string strcnbMainUnit = context.Request["cnbMainUnit"] == null ? string.Empty : context.Request["cnbMainUnit"];
            string strcniChangRate = context.Request["cniChangRate"] == null ? string.Empty : context.Request["cniChangRate"];
            string strq = context.Request["q"] == null ? string.Empty : context.Request["q"];  

            var q = from p in amscm.tbComputationUnit select p;
            if (strcnvcComunitCode != string.Empty) q = q.Where(w => w.cnvcComunitCode.Contains(strcnvcComunitCode));
            if (strcnvcComUnitName != string.Empty) q = q.Where(w => w.cnvcComUnitName.Contains(strcnvcComUnitName));
            if (strcnvcGroupCode != string.Empty) q = q.Where(w => w.cnvcGroupCode == strcnvcGroupCode);
            if (strcnbMainUnit != string.Empty)
            {
                //bool bcnbMainUnit = Convert.ToBoolean(strcnbMainUnit);
                q = q.Where(w => w.cnbMainUnit == true);
            }
            if (strcniChangRate != string.Empty)
            {
                decimal dcniChangeRate = Convert.ToDecimal(strcniChangRate);
                q = q.Where(w => w.cniChangRate == dcniChangeRate);
            }
            if (strq != string.Empty) q = q.Where(w => w.cnvcComunitCode.Contains(strq) || w.cnvcComUnitName.Contains(strq));
            return q;
        }
        private DataTable List2DataTable(HttpContext context, List<AMSCM.Models.tbComputationUnit> ltbComputationUnit)
        {
            DataTable dt = ltbComputationUnit.ToDataTable<AMSCM.Models.tbComputationUnit>();
            ServiceHelper.DataTableConvert(context, dt, "cnvcGroupCode", ServiceHelper.Table_tbComputationGroup, "cnvcGroupCode", "cnvcGroupName", "");
            ServiceHelper.DataTableConvert(context, dt, "cnbMainUnit");
            return dt;
        }
        private string GettbComputationUnit(HttpContext context)
        {
            int page = context.Request["page"] == null ? 1 : Convert.ToInt32(context.Request["page"]);
            int rows = context.Request["rows"] == null ? 10 : Convert.ToInt32(context.Request["rows"]);
            string totalcount = "";
            List<AMSCM.Models.tbComputationUnit> ltbComputationUnit = new List<AMSCM.Models.tbComputationUnit>();

            int skitCount = (page - 1) * rows;
            using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
            {

                var q = QueryCondition(context, amscm);
                totalcount = q.Count().ToString();
                ltbComputationUnit = q.OrderBy(o => o.cnvcComunitCode)
                    .Skip(skitCount)
                    .Take(rows).ToList();
            }
            DataTable dt = List2DataTable(context, ltbComputationUnit);
            return ServiceHelper.DataTableToEasyUIDataGridJson(dt, totalcount);

        }
        private string newtbComputationUnit(HttpContext context)
        {
            try
            {
                using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
                {
                    AMSCM.Models.tbComputationUnit tbComputationUnit = new AMSCM.Models.tbComputationUnit();
                    tbComputationUnit.cnvcComunitCode = context.Request.Form["cnvcComunitCode"];
                    tbComputationUnit.cnvcComUnitName = context.Request.Form["cnvcComUnitName"];
                    tbComputationUnit.cnvcGroupCode = context.Request.Form["cnvcGroupCode"];
                    tbComputationUnit.cnbMainUnit = context.Request.Form["cnbMainUnit"]=="on"?true:false;
                    if (tbComputationUnit.cnbMainUnit)
                    {
                        int icount = (from d in amscm.tbComputationUnit where d.cnbMainUnit && d.cnvcGroupCode == tbComputationUnit.cnvcGroupCode select d).Count();
                        if (icount > 0)
                        {
                            return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, "此计量单位组已有主计量单位，一个计量单位组只能有一个主计量单位！"));
                        }
                    }
                    if(context.Request.Form["cniChangRate"]!="")
                        tbComputationUnit.cniChangRate = Convert.ToDecimal(context.Request.Form["cniChangRate"]);

                    amscm.tbComputationUnit.Add(tbComputationUnit);
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
        private string updatetbComputationUnit(HttpContext context)
        {
            try
            {
                using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
                {
                    AMSCM.Models.tbComputationUnit tbComputationUnit = amscm.tbComputationUnit.Find(context.Request.Form["cnvcComunitCode"]);
                    tbComputationUnit.cnvcComunitCode = context.Request.Form["cnvcComunitCode"];
                    tbComputationUnit.cnvcComUnitName = context.Request.Form["cnvcComUnitName"];
                    tbComputationUnit.cnvcGroupCode = context.Request.Form["cnvcGroupCode"];
                    tbComputationUnit.cnbMainUnit = context.Request.Form["cnbMainUnit"]=="on"?true:false;
                    if(context.Request.Form["cniChangRate"]!="")
                        tbComputationUnit.cniChangRate = Convert.ToDecimal(context.Request.Form["cniChangRate"]);

                    if (tbComputationUnit.cnbMainUnit)
                    {
                        int icount = (from d in amscm.tbComputationUnit where d.cnbMainUnit && d.cnvcGroupCode == tbComputationUnit.cnvcGroupCode && d.cnvcComunitCode!= tbComputationUnit.cnvcComunitCode select d).Count();
                        if (icount > 0)
                        {
                            return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, "此计量单位组已有主计量单位，一个计量单位组只能有一个主计量单位！"));
                        }
                    }

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
        private string removetbComputationUnit(HttpContext context)
        {
            try
            {
                using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
                {
                    AMSCM.Models.tbComputationUnit tbComputationUnit = amscm.tbComputationUnit.Find(context.Request.Form["cnvcComunitCode"]);
                    amscm.tbComputationUnit.Remove(tbComputationUnit);
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
        private void tbComputationUnitExportToExcel(HttpContext context)
        {
            string fileName = "计量单位.xls";

            List<AMSCM.Models.tbComputationUnit> ltbComputationUnit = new List<AMSCM.Models.tbComputationUnit>();

            using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
            {
                var q = QueryCondition(context, amscm);
                ltbComputationUnit = q.OrderBy(o => o.cnvcComunitCode).ToList();
            }
            DataTable dt = List2DataTable(context, ltbComputationUnit);
            GridView view = new GridView();
            view.AutoGenerateColumns = false;

            BoundField field;

            field = new BoundField();
            field.DataField = "cnvcComunitCode";
            field.HeaderText = "计量单位编码";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cnvcComUnitName";
            field.HeaderText = "计量单位名称";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cnvcGroupCode";
            field.HeaderText = "计量单位组编码";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cnvcGroupCodeComments";
            field.HeaderText = "计量单位组名称";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cnbMainUnit";
            field.HeaderText = "是否主计量单位";
            view.Columns.Add(field);
            field = new BoundField();
            field.DataField = "cniChangRate";
            field.HeaderText = "换算率";
            view.Columns.Add(field);


            view.DataSource = dt;
            view.DataBind();

            ServiceHelper.DoExportToExcel(context, fileName, view);
        }
        private string GetAlltbComputationUnit(HttpContext context)
        {
            List<AMSCM.Models.tbComputationUnit> ltbComputationUnit = new List<AMSCM.Models.tbComputationUnit>();

            using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
            {

                ltbComputationUnit = amscm.tbComputationUnit.ToList();
            }
            DataTable dt = List2DataTable(context, ltbComputationUnit);
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
