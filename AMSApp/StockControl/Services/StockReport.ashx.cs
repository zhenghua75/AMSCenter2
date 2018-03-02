using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using CommCenter;
using System.Data.Entity.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace AMSApp.StockControl.Services
{
    /// <summary>
    /// StockReport 的摘要说明
    /// </summary>
    public class StockReport : IHttpHandler, IRequiresSessionState
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
                case "excel":
                    ComputationGroupExportToExcel(context);
                    break;
                case "compute":
                    context.Response.Write(UpdateCost(context));
                    break;
            }
        }
        private List<tbStockReportData> QueryCondition(HttpContext context, AMSCM.Models.AMSCM amscm)
        {
            string strcnvcWhCode = context.Request["cnvcWhCode"] == null ? string.Empty : context.Request["cnvcWhCode"];
            string strcnvcDeptId = context.Request["cnvcDeptId"] == null ? string.Empty : context.Request["cnvcDeptId"];
            string strcnvcInvCode = context.Request["cnvcInvCode"] == null ? string.Empty : context.Request["cnvcInvCode"];
            string strcnnYear = context.Request["cnnYear"] == null ? string.Empty : context.Request["cnnYear"];
            string strcnnMonth = context.Request["cnnMonth"] == null ? string.Empty : context.Request["cnnMonth"];
            //string strq = context.Request["q"] == null ? string.Empty : context.Request["q"];
            int icnnStatus = (int)StockStatus.Check;
            var q = from d in amscm.tbStockDetail
                    join main in amscm.tbStockMain on d.cnnMainId equals main.cnnMainId into md
                    from detail in md.DefaultIfEmpty()

                    join d1 in amscm.tbInventory on d.cnvcInvCode equals d1.cnvcInvCode into dd1
                    from inventory in dd1.DefaultIfEmpty()

                    join d2 in amscm.tbComputationUnit on inventory.cnvcSTComUnitCode equals d2.cnvcComunitCode into dd2
                    from uom in dd2.DefaultIfEmpty()

                    where detail.cnnStatus == icnnStatus
                    orderby d.cnnDetailId
                    select new tbStockReportData
                    {
                        cnnMainId = detail.cnnMainId,
                        //cnvcSupplierCode = main.cnvcSupplierCode,
                        cnvcWhCode = detail.cnvcWhCode,
                        cnvcDeptId = detail.cnvcDeptId,
                        cnnOperType = detail.cnnOperType,
                        //cndCreateDate = main.cndCreateDate,
                        //cnvcCreaterId = main.cnvcCreaterId,
                        //cnvcCreaterName = main.cnvcCreaterName,
                        //cndCheckDate = main.cndCheckDate,
                        //cnvcCheckerId = main.cnvcCheckerId,
                        //cnvcCheckerName = main.cnvcCheckerName,
                        cndBusinessDate = detail.cndBusinessDate,
                        cnnYear = detail.cnnYear,
                        cnnMonth = detail.cnnMonth,
                        //cnnStatus = main.cnnStatus,
                        //cnvcComments = main.cnvcComments,
                        //cnnDetailId = detail.cnnDetailId,
                        cnvcInvCode = d.cnvcInvCode,
                        cnvcInvName = inventory.cnvcInvName,
                        //cnvcComUnitCode = detail.cnvcComUnitCode,
                        //cnnQuantity = detail.cnnQuantity,
                        //cnvcMainComUnitCode = detail.cnvcMainComUnitCode,
                        //cnnMainQuantity = detail.cnnMainQuantity,
                        cnvcSTComUnitCode = inventory.cnvcSTComUnitCode,
                        cnvcSTComUnitName = uom.cnvcComUnitName,
                        cnnSTQuantity = d.cnnMainQuantity/(uom.cniChangRate==0?1:uom.cniChangRate),
                        //cnnPrice = detail.cnnPrice,
                        //cnnSTPrice = detail.cnnAmount/(detail.cnnMainQuantity/uom.cniChangRate),
                        cnnAmount = d.cnnAmount
                    };


            if (strcnvcWhCode != string.Empty) q = q.Where(w => w.cnvcWhCode == strcnvcWhCode);
            if (strcnvcDeptId != string.Empty) q = q.Where(w => w.cnvcDeptId == strcnvcDeptId);            
            if (strcnvcInvCode != string.Empty) q = q.Where(w => w.cnvcInvCode == strcnvcInvCode);
            int icnnYear = DateTime.Now.Year;
            if (strcnnYear != string.Empty)
                icnnYear = Convert.ToInt32(strcnnYear);
            q = q.Where(w => w.cnnYear == icnnYear);
            int icnnMonth = DateTime.Now.Month;
            if (strcnnMonth != string.Empty)
                icnnMonth = Convert.ToInt32(strcnnMonth);
            q = q.Where(w => w.cnnMonth == icnnMonth);
            //if (strq != string.Empty) q = q.Where(w => w.cnvcGroupCode.Contains(strq) || w.cnvcGroupName.Contains(strq));
            var q1 = q.ToList();
            q1.ForEach(delegate(tbStockReportData data) 
            {
                if (data.cnnOperType == 0)
                {
                    data.cnnInitQuantity = data.cnnSTQuantity;
                    data.cnnInitAmount = data.cnnAmount;
                }
                else
                {

                    if (data.cnnSTQuantity > 0)
                    {
                        data.cnnInQuantity = data.cnnSTQuantity;
                        data.cnnInAmount = data.cnnAmount;
                    }
                    else
                    {
                        data.cnnOutQuantity = Math.Abs(data.cnnSTQuantity.HasValue?data.cnnSTQuantity.Value:0);
                        data.cnnOutAmount = Math.Abs(data.cnnAmount.HasValue?data.cnnAmount.Value:0);
                    }
                }
                data.cnnEndQuantity = data.cnnSTQuantity;
                data.cnnEndAmount = data.cnnAmount;
            });
            var q2 = (from d in q1
                      where d.cnvcInvCode!=null
                     group d by new { d.cnvcInvCode, d.cnvcInvName,d.cnvcSTComUnitCode,d.cnvcSTComUnitName } into g
                     select new tbStockReportData
                     {
                         cnvcInvCode = g.Key.cnvcInvCode,
                         cnvcInvName = g.Key.cnvcInvName,
                         cnvcSTComUnitCode = g.Key.cnvcSTComUnitCode,
                         cnvcSTComUnitName = g.Key.cnvcSTComUnitName,
                         cnnInitQuantity = g.Sum(s => s.cnnInitQuantity),
                         cnnInitAmount = g.Sum(s => s.cnnInitAmount),
                         cnnInQuantity = g.Sum(s => s.cnnInQuantity),
                         cnnInAmount = g.Sum(s => s.cnnInAmount),
                         cnnOutQuantity = g.Sum(s => s.cnnOutQuantity),
                         cnnOutAmount = g.Sum(s => s.cnnOutAmount),
                         cnnEndQuantity = g.Sum(s => s.cnnEndQuantity),
                         cnnEndAmount = g.Sum(s => s.cnnEndAmount),
                         cnnSTPrice = g.Sum(s => s.cnnEndAmount) / (g.Sum(s => s.cnnEndQuantity) == 0 ? 1 : g.Sum(s => s.cnnEndQuantity))
                     }).ToList();
            return q2;
        }
        private DataTable List2DataTable(HttpContext context, List<tbStockReportData> ltbStockReportData)
        {
            DataTable dt = ltbStockReportData.ToDataTable<tbStockReportData>();
            return dt;
        }
        private string GetComputationGroup(HttpContext context)
        {
            int page = context.Request["page"] == null ? 1 : Convert.ToInt32(context.Request["page"]);
            int rows = context.Request["rows"] == null ? 10 : Convert.ToInt32(context.Request["rows"]);
            string totalcount = "";
            List<tbStockReportData> ltbStockReportData = new List<tbStockReportData>();

            int skitCount = (page - 1) * rows;
            using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
            {

                var q = QueryCondition(context, amscm);
                totalcount = q.Count.ToString();
                ltbStockReportData = q.OrderBy(o => o.cnvcInvCode)
                    .Skip(skitCount)
                    .Take(rows).ToList();
            }
            DataTable dt = List2DataTable(context, ltbStockReportData);
            return ServiceHelper.DataTableToEasyUIDataGridJson(dt, totalcount);

        }
        private void ComputationGroupExportToExcel(HttpContext context)
        {
            string fileName = "库存统计表.xls";

            List<tbStockReportData> ltbStockReportData = new List<tbStockReportData>();

            using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
            {
                var q = QueryCondition(context, amscm);
                ltbStockReportData = q.OrderBy(o => o.cnvcInvCode).ToList();
            }
            DataTable dt = List2DataTable(context, ltbStockReportData);
            GridView view = new GridView();
            view.AutoGenerateColumns = false;

            BoundField field = new BoundField();
            field.DataField = "cnvcInvCode";
            field.HeaderText = "存货编码";
            view.Columns.Add(field);

            field = new BoundField();
            field.DataField = "cnvcInvName";
            field.HeaderText = "存货名称";
            view.Columns.Add(field);

            field = new BoundField();
            field.DataField = "cnvcSTComUnitName";
            field.HeaderText = "单位";
            view.Columns.Add(field);

            field = new BoundField();
            field.DataField = "cnnInitQuantity";
            field.HeaderText = "期初数量";
            view.Columns.Add(field);

            field = new BoundField();
            field.DataField = "cnnInQuantity";
            field.HeaderText = "本期入库数量";
            view.Columns.Add(field);

            field = new BoundField();
            field.DataField = "cnnOutQuantity";
            field.HeaderText = "本期出库数量";
            view.Columns.Add(field);

            field = new BoundField();
            field.DataField = "cnnEndQuantity";
            field.HeaderText = "结余数量";
            view.Columns.Add(field);

            field = new BoundField();
            field.DataField = "cnnSTPrice";
            field.HeaderText = "单位成本";
            view.Columns.Add(field);

            field = new BoundField();
            field.DataField = "cnnEndAmount";
            field.HeaderText = "库存成本";
            view.Columns.Add(field);

            view.DataSource = dt;
            view.DataBind();

            ServiceHelper.DoExportToExcel(context, fileName, view);
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        private string UpdateCost(HttpContext context)
        {
            try
            {
                string strOperId = context.User.Identity.Name;
                CMSMStruct.LoginStruct ls1 = (CMSMStruct.LoginStruct)context.Session["Login"];
                string strOperName = ls1.strOperName;
                int icnnYear = Convert.ToInt32(context.Request.Form["cnnYear"]);
                int icnnMonth = Convert.ToInt32(context.Request.Form["cnnMonth"]);
                AMSCM.Models.tbMonthlyBalance tbMonthlyBalance = new AMSCM.Models.tbMonthlyBalance();
                tbMonthlyBalance.cnnYear = icnnYear;
                tbMonthlyBalance.cnnMonth = icnnMonth;
                using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
                {
                    Compute(amscm, tbMonthlyBalance, strOperId, strOperName);
                }
            }
            catch (DbUpdateException dex)
            {
                ExceptionPolicy.HandleException(dex, ServiceHelper.ExceptionPolicy);
                return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, dex.Message));
            }
            catch (Exception ex)
            {
                ExceptionPolicy.HandleException(ex, ServiceHelper.ExceptionPolicy);
                return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, ex.Message));
            }
            return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(true, ""));
        }
        private void Compute(AMSCM.Models.AMSCM amscm, AMSCM.Models.tbMonthlyBalance tbMonthlyBalance, string strOperId, string strOperName)
        {
            int icnnCheckStatus = (int)StockStatus.Check;
            List<tbStockMainAndDetail> ltbStockMainAndDetail = (from main in amscm.tbStockMain
                                                                join d in amscm.tbStockDetail on main.cnnMainId equals d.cnnMainId into md
                                                                from detail in md.DefaultIfEmpty()
                                                                where main.cnnYear == tbMonthlyBalance.cnnYear && main.cnnMonth == tbMonthlyBalance.cnnMonth
                                                                && main.cnnStatus == icnnCheckStatus
                                                                orderby main.cnnMainId
                                                                select new tbStockMainAndDetail
                                                                {
                                                                    cnnMainId = main.cnnMainId,
                                                                    //cnvcSupplierCode = main.cnvcSupplierCode,
                                                                    cnvcWhCode = main.cnvcWhCode,
                                                                    cnvcDeptId = main.cnvcDeptId,
                                                                    cnnOperType = main.cnnOperType,
                                                                    //cndCreateDate = main.cndCreateDate,
                                                                    //cnvcCreaterId = main.cnvcCreaterId,
                                                                    //cnvcCreaterName = main.cnvcCreaterName,
                                                                    //cndCheckDate = main.cndCheckDate,
                                                                    //cnvcCheckerId = main.cnvcCheckerId,
                                                                    //cnvcCheckerName = main.cnvcCheckerName,
                                                                    //cndBusinessDate = main.cndBusinessDate,
                                                                    cnnYear = main.cnnYear,
                                                                    cnnMonth = main.cnnMonth,
                                                                    //cnnStatus = main.cnnStatus,
                                                                    //cnvcComments = main.cnvcComments,
                                                                    cnnDetailId = detail.cnnDetailId,
                                                                    cnvcInvCode = detail.cnvcInvCode,
                                                                    cnvcComUnitCode = detail.cnvcComUnitCode,
                                                                    cnnQuantity = detail.cnnQuantity,
                                                                    cnvcMainComUnitCode = detail.cnvcMainComUnitCode,
                                                                    cnnMainQuantity = detail.cnnMainQuantity,
                                                                    cnnPrice = detail.cnnPrice,
                                                                    cnnAmount = detail.cnnAmount,
                                                                    isHave = false
                                                                    //cnnMainPrice = detail.cnnPrice==0?0:detail.cnnAmount / detail.cnnPrice
                                                                }).ToList();
            var ltbInventory = (from d in amscm.tbInventory
                                join d1 in amscm.tbComputationUnit on d.cnvcSTComUnitCode equals d1.cnvcComunitCode into dd1
                                from dd1s in dd1.DefaultIfEmpty()

                                join d2 in amscm.tbProductClass on d.cnvcInvCCode equals d2.cnvcProductClassCode into dd2
                                from dd2s in dd2.DefaultIfEmpty()

                                join d3 in amscm.tbComputationUnit on d.cnvcProduceUnitCode equals d3.cnvcComunitCode into dd3
                                from dd3s in dd3.DefaultIfEmpty()

                                select new
                                {
                                    d.cnvcInvCode,
                                    dd2s.cnvcProductType,
                                    d.cnvcProduceUnitCode,
                                    d.cnvcSTComUnitCode,
                                    cniChangRate = dd1s == null ? 0 : dd1s.cniChangRate,
                                    cniChangeRate2 = dd3s == null ? 0 : dd3s.cniChangRate
                                }).ToList();
            //foreach (tbStockMainAndDetail tbStockMainAndDetail in ltbStockMainAndDetail)
            //{
            //    tbStockMainAndDetail.cnnMainPrice = tbStockMainAndDetail.cnnAmount / tbStockMainAndDetail.cnnMainQuantity;
            //}
            //利用期初、采购的数据计算成本
            var g1 = (from d in ltbStockMainAndDetail
                      where d.cnnOperType == 0 || d.cnnOperType == 1
                      group d by new { d.cnvcInvCode, d.cnvcWhCode, d.cnvcDeptId } into g
                      select new
                      {
                          cnvcInvCode = g.Key.cnvcInvCode,
                          cnvcWhCode = g.Key.cnvcWhCode,
                          cnvcDeptId = g.Key.cnvcDeptId,
                          //cnnAvgPrice = g.Sum(s => s.cnnAmount) / g.Sum(s => s.cnnMainQuantity)
                          cnnAvgPrice = g.Sum(s => s.cnnMainQuantity)==0?g.Sum(s => s.cnnAmount):
                                        g.Sum(s => s.cnnAmount) / g.Sum(s => s.cnnMainQuantity) 
                      }).ToList();
            //var q1 = (from d in ltbStockMainAndDetail where d.cnnOperType==4 || d.cnnOperType==6 select d).ToList();
            //1、已有的取出成本
            foreach (var g2 in g1)
            {
                ltbStockMainAndDetail.ForEach(delegate(tbStockMainAndDetail md)
                {
                    if (md.cnvcInvCode == g2.cnvcInvCode && md.cnvcWhCode == g2.cnvcWhCode
                        && md.cnvcDeptId == g2.cnvcDeptId
                        && md.cnnOperType != 0 && md.cnnOperType != 1
                        )
                    {
                        md.cnnMainPrice = g2.cnnAvgPrice;
                        md.cnnPrice = md.cnnMainPrice * (md.cnnQuantity==0?1:md.cnnMainQuantity / md.cnnQuantity);
                        md.cnnAmount = md.cnnMainPrice * md.cnnMainQuantity;
                        md.isHave = true;
                    }
                });

            }
            //2、根据配方算出用量
            var lInv = (from d in ltbStockMainAndDetail where d.cnnOperType != 0 && d.cnnOperType != 1 && !d.isHave select d.cnvcInvCode).Distinct().ToList();
            List<AMSCM.Models.tbBillOfMaterials> lbom = ServiceHelper.getBOM(amscm);

            List<tbStockMainAndDetail> lm = new List<tbStockMainAndDetail>();
            foreach (string strInvCode in lInv)
            {
                if (!string.IsNullOrEmpty(strInvCode))
                {
                    //获取所有子件
                    List<AMSCM.Models.tbBillOfMaterials> lComponentInv = ServiceHelper.ProcBOM(lbom, strInvCode);

                    //获取子件生产单位数量
                    var lcis = from d in lComponentInv
                               group d by d.cnvcComponentInvCode into g
                               select new { cnvcInvCode = g.Key, cnnQuantity = g.Sum(s => s.cnnBaseQtyN) };
                    //获取主计量单位成本
                    decimal dPrice = (from d in lcis
                                      join d1 in ltbInventory on d.cnvcInvCode equals d1.cnvcInvCode into dd1
                                      from dd1s in dd1.DefaultIfEmpty()

                                      join d2 in g1 on d.cnvcInvCode equals d2.cnvcInvCode into dd2
                                      from dd2s in dd2.DefaultIfEmpty()
                                      select d.cnnQuantity * (dd1s == null ? 0 : dd1s.cniChangeRate2) * (dd2s == null || !dd2s.cnnAvgPrice.HasValue ? 0 : dd2s.cnnAvgPrice.Value)).Sum();
                    lm.Add(new tbStockMainAndDetail() { cnvcInvCode = strInvCode, cnnMainPrice = dPrice });
                }
            };
            ltbStockMainAndDetail.ForEach(delegate(tbStockMainAndDetail md)
            {
                if (md.cnnOperType != 0 && md.cnnOperType != 1 && !md.isHave)
                {
                    decimal? dcnnMainPrice = (from d in lm where d.cnvcInvCode == md.cnvcInvCode select d.cnnMainPrice).FirstOrDefault();
                    md.cnnMainPrice = dcnnMainPrice;
                    md.cnnAmount = dcnnMainPrice * md.cnnMainQuantity;
                    md.cnnPrice = md.cnnQuantity==0?md.cnnAmount:md.cnnAmount / md.cnnQuantity;
                }

            });
            //3、更新成本
            ltbStockMainAndDetail.ForEach(delegate(tbStockMainAndDetail md)
            {
                if (md.cnnOperType != 0 && md.cnnOperType != 1 && md.cnnDetailId.HasValue)
                {
                    AMSCM.Models.tbStockDetail tbStockDetail = amscm.tbStockDetail.Find(md.cnnDetailId);
                    tbStockDetail.cnnPrice = md.cnnPrice.Value;
                    tbStockDetail.cnnAmount = md.cnnAmount.Value;
                }
            });
            amscm.SaveChanges();
        }
        
    }
    public class tbStockReportData
    {
        public long cnnMainId { get; set; }
        public string cnvcSupplierCode { get; set; }
        public string cnvcWhCode { get; set; }
        public string cnvcDeptId { get; set; }
        public int cnnOperType { get; set; }
        public DateTime cndCreateDate { get; set; }
        public string cnvcCreaterId { get; set; }
        public string cnvcCreaterName { get; set; }
        public DateTime? cndCheckDate { get; set; }
        public string cnvcCheckerId { get; set; }
        public string cnvcCheckerName { get; set; }
        public DateTime cndBusinessDate { get; set; }
        public int cnnYear { get; set; }
        public int cnnMonth { get; set; }
        public int cnnStatus { get; set; }
        public string cnvcComments { get; set; }
        public long? cnnDetailId { get; set; }
        public string cnvcInvCode { get; set; }
        public string cnvcInvName { get; set; }
        public string cnvcComUnitCode { get; set; }
        public decimal? cnnQuantity { get; set; }
        public string cnvcMainComUnitCode { get; set; }
        public string cnvcSTComUnitCode { get; set; }
        public string cnvcSTComUnitName { get; set; }
        public decimal? cnnMainQuantity { get; set; }
        public decimal? cnnSTQuantity { get; set; }
        public decimal? cnnInitQuantity { get; set; }
        public decimal? cnnInQuantity { get; set; }
        public decimal? cnnOutQuantity { get; set; }
        public decimal? cnnEndQuantity { get; set; }
        public decimal? cnnPrice { get; set; }
        public decimal? cnnSTPrice { get; set; }
        public decimal? cnnMainPrice { get; set; }
        public decimal? cnnAmount { get; set; }
        public decimal? cnnInitAmount { get; set; }
        public decimal? cnnInAmount { get; set; }
        public decimal? cnnOutAmount { get; set; }
        public decimal? cnnEndAmount { get; set; }
    }
}