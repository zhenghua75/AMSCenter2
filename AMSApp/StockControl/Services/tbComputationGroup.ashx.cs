﻿using System;
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
    /// ComputationGroup 的摘要说明
    /// </summary>
    public class tbComputationGroup : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string method = context.Request["method"];
            switch (method)
            {
                case "query":
                    context.Response.Write(GetComputationGroup(context));
                    break;
                case "all":
                    context.Response.Write(GetAllComputationGroup(context));
                    break;
                case "update":
                    context.Response.Write(updateComputationGroup(context));
                    break;
                case "new":
                    context.Response.Write(newComputationGroup(context));
                    break;
                case "remove":
                    context.Response.Write(removeComputationGroup(context));
                    break;
                case "excel":
                    ComputationGroupExportToExcel(context);
                    break;
            }
        }
        private IQueryable<AMSCM.Models.tbComputationGroup> QueryCondition(HttpContext context, AMSCM.Models.AMSCM amscm)
        {
            string strcnvcGroupCode = context.Request["cnvcGroupCode"] == null ? string.Empty : context.Request["cnvcGroupCode"];
            string strcnvcGroupName = context.Request["cnvcGroupName"] == null ? string.Empty : context.Request["cnvcGroupName"];
            string strq = context.Request["q"] == null ? string.Empty : context.Request["q"]; 
            var q = from p in amscm.tbComputationGroup select p;
            if (strcnvcGroupCode != string.Empty) q = q.Where(w => w.cnvcGroupCode.Contains(strcnvcGroupCode));
            if (strcnvcGroupName != string.Empty) q = q.Where(w => w.cnvcGroupName.Contains(strcnvcGroupName));
            if (strq != string.Empty) q = q.Where(w => w.cnvcGroupCode.Contains(strq) || w.cnvcGroupName.Contains(strq));
            return q;
        }
        private DataTable List2DataTable(HttpContext context, List<AMSCM.Models.tbComputationGroup> lComputationGroup)
        {
            DataTable dt = lComputationGroup.ToDataTable<AMSCM.Models.tbComputationGroup>();
            return dt;
        }
        private string GetComputationGroup(HttpContext context)
        {
            int page = context.Request["page"] == null ? 1 : Convert.ToInt32(context.Request["page"]);
            int rows = context.Request["rows"] == null ? 10 : Convert.ToInt32(context.Request["rows"]);
            string totalcount = "";
            List<AMSCM.Models.tbComputationGroup> lComputationGroup = new List<AMSCM.Models.tbComputationGroup>();

            int skitCount = (page - 1) * rows;
            using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
            {

                var q = QueryCondition(context, amscm);
                totalcount = q.Count().ToString();
                lComputationGroup = q.OrderBy(o => o.cnvcGroupCode)
                    .Skip(skitCount)
                    .Take(rows).ToList();
            }
            DataTable dt = List2DataTable(context, lComputationGroup);
            return ServiceHelper.DataTableToEasyUIDataGridJson(dt, totalcount);

        }
        private string newComputationGroup(HttpContext context)
        {
            try
            {
                using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
                {
                    AMSCM.Models.tbComputationGroup computationGroup = new AMSCM.Models.tbComputationGroup();
                    computationGroup.cnvcGroupCode = context.Request.Form["cnvcGroupCode"];
                    computationGroup.cnvcGroupName = context.Request.Form["cnvcGroupName"];
                    amscm.tbComputationGroup.Add(computationGroup);
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
        private string updateComputationGroup(HttpContext context)
        {
            try
            {
                using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
                {
                    AMSCM.Models.tbComputationGroup computationGroup = amscm.tbComputationGroup.Find(context.Request.Form["cnvcGroupCode"]);
                    computationGroup.cnvcGroupCode = context.Request.Form["cnvcGroupCode"];
                    computationGroup.cnvcGroupName = context.Request.Form["cnvcGroupName"];
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
        private string removeComputationGroup(HttpContext context)
        {
            try
            {
                using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
                {
                    AMSCM.Models.tbComputationGroup computationGroup = amscm.tbComputationGroup.Find(context.Request.Form["cnvcGroupCode"]);
                    amscm.tbComputationGroup.Remove(computationGroup);
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
        private void ComputationGroupExportToExcel(HttpContext context)
        {
            string fileName = "计量单位组.xls";

            List<AMSCM.Models.tbComputationGroup> lComputationGroup = new List<AMSCM.Models.tbComputationGroup>();

            using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
            {
                var q = QueryCondition(context, amscm);
                lComputationGroup = q.OrderBy(o => o.cnvcGroupCode).ToList();
            }
            DataTable dt = List2DataTable(context, lComputationGroup);
            GridView view = new GridView();
            view.AutoGenerateColumns = false;

            BoundField field = new BoundField();
            field.DataField = "cnvcGroupCode";
            field.HeaderText = "计量单位组编码";
            view.Columns.Add(field);

            field = new BoundField();
            field.DataField = "cnvcGroupName";
            field.HeaderText = "计量单位组名称";
            view.Columns.Add(field);

            view.DataSource = dt;
            view.DataBind();

            ServiceHelper.DoExportToExcel(context, fileName, view);
        }
        private string GetAllComputationGroup(HttpContext context)
        {
            List<AMSCM.Models.tbComputationGroup> lComputationGroup = new List<AMSCM.Models.tbComputationGroup>();

            using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
            {

                lComputationGroup = amscm.tbComputationGroup.ToList();
            }
            DataTable dt = List2DataTable(context, lComputationGroup);
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