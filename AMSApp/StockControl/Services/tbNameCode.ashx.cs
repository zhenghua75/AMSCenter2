using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.SessionState;

namespace AMSApp.StockControl.Services
{
    /// <summary>
    /// tbNameCode 的摘要说明
    /// </summary>
    public class tbNameCode : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(GetSomeNameCode(context));
            
        }
        private DataTable List2DataTable(HttpContext context, List<AMSCM.Models.tbNameCode> ltbNameCode)
        {
            DataTable dt = ltbNameCode.ToDataTable<AMSCM.Models.tbNameCode>();
            return dt;
        }
        private string GetSomeNameCode(HttpContext context)
        {
            List<AMSCM.Models.tbNameCode> ltbNameCode = new List<AMSCM.Models.tbNameCode>();
            string method = context.Request["method"];
            using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
            {
                ltbNameCode = amscm.tbNameCode.Where(w=>w.cnvcType==method).ToList();
            }
            DataTable dt = List2DataTable(context, ltbNameCode);
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