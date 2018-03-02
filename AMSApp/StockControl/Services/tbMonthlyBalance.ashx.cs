using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Transactions;
using System.Data.Entity.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using CommCenter;
using System.Web.SessionState;
using System.Globalization;

namespace AMSApp.StockControl.Services
{
    /// <summary>
    /// tbMonthlyBalance 的摘要说明
    /// </summary>
    public class tbMonthlyBalance : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Server.ScriptTimeout = 600;
            context.Response.ContentType = "text/plain";

            string method = context.Request["method"];
            switch (method)
            {
                case "query":
                    context.Response.Write(GettbMonthlyBalance(context));
                    break;
                case "all":
                    context.Response.Write(GetAlltbMonthlyBalance(context));
                    break;
                case "newMonthlyBalance":
                    context.Response.Write(newtbMonthlyBalance(context));
                    break;
                case "balance":
                    context.Response.Write(balance(context));
                    break;
                case "cancelBalance":
                    context.Response.Write(cancelBalance(context));
                    break;
                case "cnnYear":
                    context.Response.Write(getYears(context));
                    break;
                case "cnnMonth":
                    context.Response.Write(getMonths(context));
                    break;
            }
        }
        private IQueryable<AMSCM.Models.tbMonthlyBalance> QueryCondition(HttpContext context, AMSCM.Models.AMSCM amscm)
        {
            var q = from p in amscm.tbMonthlyBalance select p;
            return q;
        }
        private string GettbMonthlyBalance(HttpContext context)
        {
            int page = context.Request["page"] == null ? 1 : Convert.ToInt32(context.Request["page"]);
            int rows = context.Request["rows"] == null ? 10 : Convert.ToInt32(context.Request["rows"]);
            string totalcount = "";
            List<AMSCM.Models.tbMonthlyBalance> ltbMonthlyBalance = new List<AMSCM.Models.tbMonthlyBalance>();

            int skitCount = (page - 1) * rows;
            using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
            {

                var q = QueryCondition(context, amscm);
                totalcount = q.Count().ToString();
                ltbMonthlyBalance = q.OrderBy(o => o.cnnYear).OrderBy(o => o.cnnMonth)
                    .Skip(skitCount)
                    .Take(rows).ToList();
            }
            DataTable dt = List2DataTable(context, ltbMonthlyBalance);
            return ServiceHelper.DataTableToEasyUIDataGridJson(dt, totalcount);

        }
        private DataTable List2DataTable(HttpContext context, List<AMSCM.Models.tbMonthlyBalance> ltbMonthlyBalance)
        {
            DataTable dt = ltbMonthlyBalance.ToDataTable<AMSCM.Models.tbMonthlyBalance>();
            return dt;
        }
        private string newtbMonthlyBalance(HttpContext context)
        {
            try
            {
                using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
                {
                    AMSCM.Models.tbMonthlyBalance tbMonthlyBalance = new AMSCM.Models.tbMonthlyBalance();
                    tbMonthlyBalance.cnnYear = Convert.ToInt32(context.Request.Form["cnnYear"]);
                    tbMonthlyBalance.cnnMonth = Convert.ToInt32(context.Request.Form["cnnMonth"]);
                    tbMonthlyBalance.cnbIsBalance = false;

                    tbMonthlyBalance.cndCreateDate = DateTime.Now;
                    tbMonthlyBalance.cnvcCreater = context.User.Identity.Name;
                    CMSMStruct.LoginStruct ls1 = (CMSMStruct.LoginStruct)context.Session["Login"];
                    tbMonthlyBalance.cnvcCreaterName = ls1.strOperName;

                    //tbMonthlyBalance.cndModifyDate = tbMonthlyBalance.cndCreateDate;
                    //tbMonthlyBalance.cnvcModifier = tbMonthlyBalance.cnvcCreater;
                    //tbMonthlyBalance.cnvcModifierName = tbMonthlyBalance.cnvcCreaterName;
                    amscm.tbMonthlyBalance.Add(tbMonthlyBalance);

                    AMSCM.Models.tbMonthlyBalanceLog tbMonthlyBalanceLog = new AMSCM.Models.tbMonthlyBalanceLog();
                    ServiceHelper.SetEntity<AMSCM.Models.tbMonthlyBalance, AMSCM.Models.tbMonthlyBalanceLog>(tbMonthlyBalance, tbMonthlyBalanceLog);
                    amscm.tbMonthlyBalanceLog.Add(tbMonthlyBalanceLog);

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
        private string balance(HttpContext context)
        {
            try
            {
                using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.RequiresNew,new TimeSpan(0,10,0)))
                {
                    using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
                    {
                        //amscm.Database.Connection.ConnectionTimeout = 600;

                        //更新月结表
                        int icnnYear = Convert.ToInt32(context.Request.Form["cnnYear"]);
                        int icnnMonth = Convert.ToInt32(context.Request.Form["cnnMonth"]);
                        int icount = (from d in amscm.tbMonthlyBalance
                                      where d.cnnYear <= icnnYear && d.cnnMonth < icnnMonth && !d.cnbIsBalance
                                      select d).Count();
                        if (icount > 0)
                        {
                            return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, "请先月结以前月份！"));
                        }
                        AMSCM.Models.tbMonthlyBalance tbMonthlyBalance = amscm.tbMonthlyBalance.Find(icnnYear, icnnMonth);
                        if (tbMonthlyBalance.cnbIsBalance)
                        {
                            return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, "已月结！"));
                        }

                        tbMonthlyBalance.cnbIsBalance = true;

                        string strOperId = context.User.Identity.Name;
                        CMSMStruct.LoginStruct ls1 = (CMSMStruct.LoginStruct)context.Session["Login"];
                        string strOperName = ls1.strOperName;
                        tbMonthlyBalance.cndBalanceDate = DateTime.Now;
                        tbMonthlyBalance.cnvcBalancer = strOperId;

                        tbMonthlyBalance.cnvcBalancerName = strOperName;


                        AMSCM.Models.tbMonthlyBalanceLog tbMonthlyBalanceLog = new AMSCM.Models.tbMonthlyBalanceLog();
                        ServiceHelper.SetEntity<AMSCM.Models.tbMonthlyBalance, AMSCM.Models.tbMonthlyBalanceLog>(tbMonthlyBalance, tbMonthlyBalanceLog);
                        amscm.tbMonthlyBalanceLog.Add(tbMonthlyBalanceLog);

                        //更新盘点和领料单的成本
                        Compute(amscm, tbMonthlyBalance, strOperId, strOperName);
                        amscm.SaveChanges();
                        transaction.Complete();
                    }
                }
            }
            catch (TimeoutException tex)
            {
                ExceptionPolicy.HandleException(tex, ServiceHelper.ExceptionPolicy);
                return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, tex.Message));
            }
            catch (DbUpdateException dex)
            {
                ExceptionPolicy.HandleException(dex, ServiceHelper.ExceptionPolicy);
                return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, dex.Message));
            }
            return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(true, ""));
        }
        private void Compute(AMSCM.Models.AMSCM amscm, AMSCM.Models.tbMonthlyBalance tbMonthlyBalance,string strOperId,string strOperName)
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
                                                                     isHave=false
                                                                     //cnnMainPrice = detail.cnnPrice==0?0:detail.cnnAmount / detail.cnnPrice
                                                                 }).ToList();
            var ltbInventory = (from d in amscm.tbInventory 
                                join d1 in amscm.tbComputationUnit on d.cnvcSTComUnitCode equals d1.cnvcComunitCode into dd1
                                from dd1s in dd1.DefaultIfEmpty()

                                join d2 in amscm.tbProductClass on d.cnvcInvCCode equals d2.cnvcProductClassCode into dd2
                                from dd2s in dd2.DefaultIfEmpty()

                                join d3 in amscm.tbComputationUnit on d.cnvcProduceUnitCode equals d3.cnvcComunitCode into dd3
                                from dd3s in dd3.DefaultIfEmpty()

                                select new { d.cnvcInvCode,dd2s.cnvcProductType,d.cnvcProduceUnitCode, d.cnvcSTComUnitCode, 
                                    cniChangRate=dd1s==null?0:dd1s.cniChangRate ,
                                    cniChangeRate2 = dd3s==null?0:dd3s.cniChangRate
                                }).ToList();
            //foreach (tbStockMainAndDetail tbStockMainAndDetail in ltbStockMainAndDetail)
            //{
            //    tbStockMainAndDetail.cnnMainPrice = tbStockMainAndDetail.cnnAmount / tbStockMainAndDetail.cnnMainQuantity;
            //}
            //利用期初、采购的数据计算成本
            var g1 = (from d in ltbStockMainAndDetail
                      where d.cnnOperType == 0 || d.cnnOperType == 1 
                      group d by new { d.cnvcInvCode, d.cnvcWhCode,d.cnvcDeptId } into g
                      select new { cnvcInvCode = g.Key.cnvcInvCode,cnvcWhCode=g.Key.cnvcWhCode, 
                          cnvcDeptId=g.Key.cnvcDeptId,
                          cnnAvgPrice = g.Sum(s => s.cnnMainQuantity)==0?g.Sum(s => s.cnnAmount):g.Sum(s => s.cnnAmount) / g.Sum(s => s.cnnMainQuantity) }).ToList();
            //var q1 = (from d in ltbStockMainAndDetail where d.cnnOperType==4 || d.cnnOperType==6 select d).ToList();
            //1、已有的取出成本
            foreach (var g2 in g1)
            {
                ltbStockMainAndDetail.ForEach(delegate(tbStockMainAndDetail md)
                {
                    if (md.cnvcInvCode == g2.cnvcInvCode && md.cnvcWhCode==g2.cnvcWhCode
                        && md.cnvcDeptId == g2.cnvcDeptId
                        && md.cnnOperType !=0 && md.cnnOperType !=1
                        )
                    {
                        md.cnnMainPrice = g2.cnnAvgPrice;
                        md.cnnPrice = md.cnnMainPrice * (md.cnnMainQuantity / (md.cnnQuantity==0?1:md.cnnQuantity));
                        md.cnnAmount = md.cnnMainPrice * md.cnnMainQuantity;
                        md.isHave = true;
                    }
                });
                
            }
            //2、根据配方算出用量
            var lInv = (from d in ltbStockMainAndDetail where d.cnnOperType != 0 && d.cnnOperType != 1 && !d.isHave select d.cnvcInvCode).Distinct().ToList();
            List<AMSCM.Models.tbBillOfMaterials> lbom = ServiceHelper.getBOM(amscm);
            
            List<tbStockMainAndDetail> lm = new List<tbStockMainAndDetail>();
            foreach(string strInvCode in lInv)
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
                    md.cnnPrice = md.cnnAmount / (md.cnnQuantity == 0 ? 1 : md.cnnQuantity);//md.cnnQuantity;
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

            

            //计算下月的期初库存
            var g3 = (from d in ltbStockMainAndDetail
                      join d1 in ltbInventory on d.cnvcInvCode equals d1.cnvcInvCode into dd1
                       from dd1s in dd1.DefaultIfEmpty()
                      //where d.cnnOperType == 0 || d.cnnOperType == 1 || d.cnnOperType == 2 || d.cnnOperType == 5
                      group d by new { d.cnvcInvCode, d.cnvcWhCode, d.cnvcDeptId, d.cnvcMainComUnitCode, cnvcSTComUnitCode = dd1s == null ? "" : dd1s.cnvcSTComUnitCode, cniChangRate=dd1s==null?0:dd1s.cniChangRate } into g
                      select new
                      {                          
                          cnvcWhCode=g.Key.cnvcWhCode,
                          cnvcDeptId=g.Key.cnvcDeptId,
                          cnvcInvCode = g.Key.cnvcInvCode,
                          cnvcMainComUnitCode = g.Key.cnvcMainComUnitCode,
                          cnvcComUnitCode = g.Key.cnvcSTComUnitCode,
                          cniChangRate = g.Key.cniChangRate,
                          cnnAmount = g.Sum(s => s.cnnAmount),                          
                          cnnMainQuantity = g.Sum(s => s.cnnMainQuantity),
                          cnnQuantity = g.Key.cniChangRate==0?0:g.Sum(s => s.cnnMainQuantity) / g.Key.cniChangRate,
                          cnnPrice = g.Sum(s => s.cnnMainQuantity)==0?0:(g.Sum(s => s.cnnAmount) / g.Sum(s => s.cnnMainQuantity)) * g.Key.cniChangRate
                      }).ToList();
            var g4 = (from d in g3 select new { d.cnvcWhCode, d.cnvcDeptId }).Distinct();
            int icnnYear = tbMonthlyBalance.cnnYear;
            int icnnMonth = tbMonthlyBalance.cnnMonth;
            if (icnnMonth == 12)
            {
                icnnYear += 1;
                icnnMonth = 1;
            }
            else
                icnnMonth += 1;
            DateTime cndBusinessDate = new DateTime(icnnYear, icnnMonth, 1);
            foreach (var g5 in g4)
            {
                var g6 = (from d in g3 where d.cnvcDeptId==g5.cnvcDeptId && d.cnvcWhCode==g5.cnvcWhCode&&d.cnvcInvCode!=null select d).ToList();
                if (g6.Count > 0)
                {
                    AMSCM.Models.tbStockMain tbStockMain = AddStockMain(amscm, g5.cnvcWhCode, g5.cnvcDeptId, strOperId, strOperName,0,cndBusinessDate);
                    foreach (var g7 in g6)
                    {
                        if (g7.cnnQuantity < 0 && g7.cnnAmount < 0 && g7.cnnMainQuantity < 0)
                        {
                            AMSCM.Models.tbStockMain tbStockMain2 = AddStockMain(amscm, g5.cnvcWhCode, g5.cnvcDeptId, strOperId, strOperName, 4, cndBusinessDate);
                            ServiceHelper.AddStockDetal(amscm, tbStockMain2, g7.cnvcInvCode, g7.cnvcComUnitCode, -g7.cnnQuantity.Value, g7.cnvcMainComUnitCode, -g7.cnnMainQuantity.Value, g7.cnnPrice.Value, -g7.cnnAmount.Value);
                            ServiceHelper.AddStockDetal(amscm, tbStockMain, g7.cnvcInvCode, g7.cnvcComUnitCode, 0, g7.cnvcMainComUnitCode, 0, g7.cnnPrice.Value, 0);
                        }
                        else
                        {
                            ServiceHelper.AddStockDetal(amscm, tbStockMain, g7.cnvcInvCode, g7.cnvcComUnitCode, g7.cnnQuantity.Value, g7.cnvcMainComUnitCode, g7.cnnMainQuantity.Value, g7.cnnPrice.Value, g7.cnnAmount.Value);
                        }
                    }
                }
            }

        }
        private AMSCM.Models.tbStockMain AddStockMain(AMSCM.Models.AMSCM amscm, string cnvcWhCode, string cnvcDeptId, string strOperId, string strOperName,
            int cnnOperType, DateTime cndBusinessDate)
        {
            AMSCM.Models.tbStockMain tbStockMain = new AMSCM.Models.tbStockMain();

            tbStockMain.cnvcWhCode = cnvcWhCode;
            tbStockMain.cnvcDeptId = cnvcDeptId;
            tbStockMain.cnnOperType = cnnOperType;
            tbStockMain.cnnSource = 1;

            tbStockMain.cndCreateDate = DateTime.Now;
            tbStockMain.cnvcCreaterId = strOperId;
            tbStockMain.cnvcCreaterName = strOperName;

            tbStockMain.cndCheckDate = tbStockMain.cndCreateDate;
            tbStockMain.cnvcCheckerId = tbStockMain.cnvcCreaterId;
            tbStockMain.cnvcCheckerName = tbStockMain.cnvcCreaterName;

            tbStockMain.cndBusinessDate = cndBusinessDate;
            tbStockMain.cnnYear = cndBusinessDate.Year;
            tbStockMain.cnnMonth = cndBusinessDate.Month;
            tbStockMain.cnnStatus = (int)StockStatus.Check;
            tbStockMain.cnvcComments = "月结自动生成下月期初库存";

            amscm.tbStockMain.Add(tbStockMain);

            amscm.SaveChanges();

            AMSCM.Models.tbStockMainLog tbStockMainLog = new AMSCM.Models.tbStockMainLog();
            ServiceHelper.SetEntity<AMSCM.Models.tbStockMain, AMSCM.Models.tbStockMainLog>(tbStockMain, tbStockMainLog);
            amscm.tbStockMainLog.Add(tbStockMainLog);
            return tbStockMain;
        }

        private string cancelBalance(HttpContext context)
        {
            try
            {
                //using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.RequiresNew, new TimeSpan(0, 20, 0)))
                //{
                using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
                {

                    int icnnYear = Convert.ToInt32(context.Request.Form["cnnYear"]);
                    int icnnMonth = Convert.ToInt32(context.Request.Form["cnnMonth"]);
                    int icount = (from d in amscm.tbMonthlyBalance
                                  where d.cnnYear >= icnnYear && d.cnnMonth > icnnMonth && d.cnbIsBalance
                                  select d).Count();
                    if (icount > 0)
                    {
                        return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, "请先取消以前月份月结！"));
                    }
                    AMSCM.Models.tbMonthlyBalance tbMonthlyBalance = amscm.tbMonthlyBalance.Find(icnnYear, icnnMonth);
                    if (!tbMonthlyBalance.cnbIsBalance)
                    {
                        return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, "未月结！"));
                    }

                    tbMonthlyBalance.cnbIsBalance = false;

                    tbMonthlyBalance.cndModifyDate = DateTime.Now;
                    tbMonthlyBalance.cnvcModifier = context.User.Identity.Name;
                    CMSMStruct.LoginStruct ls1 = (CMSMStruct.LoginStruct)context.Session["Login"];
                    tbMonthlyBalance.cnvcModifierName = ls1.strOperName;

                    tbMonthlyBalance.cndBalanceDate = null;
                    tbMonthlyBalance.cnvcBalancer = string.Empty;
                    tbMonthlyBalance.cnvcBalancerName = string.Empty;

                    //amscm.SaveChanges();
                    AMSCM.Models.tbMonthlyBalanceLog tbMonthlyBalanceLog = new AMSCM.Models.tbMonthlyBalanceLog();
                    ServiceHelper.SetEntity<AMSCM.Models.tbMonthlyBalance, AMSCM.Models.tbMonthlyBalanceLog>(tbMonthlyBalance, tbMonthlyBalanceLog);
                    amscm.tbMonthlyBalanceLog.Add(tbMonthlyBalanceLog);

                    int icnnCheckStatus = (int)StockStatus.Check;
                    List<long> lcnnDetailId = (from main in amscm.tbStockMain
                                               join d in amscm.tbStockDetail on main.cnnMainId equals d.cnnMainId into md
                                               from detail in md.DefaultIfEmpty()
                                               where main.cnnYear == tbMonthlyBalance.cnnYear && main.cnnMonth == tbMonthlyBalance.cnnMonth
                                               && main.cnnStatus == icnnCheckStatus && main.cnnOperType != 0 && main.cnnOperType != 1
                                               orderby main.cnnMainId
                                               select detail==null?0:detail.cnnDetailId).Distinct().ToList();
                    foreach (long cnnDetailId in lcnnDetailId)
                    {
                        if (cnnDetailId == 0) continue;
                        AMSCM.Models.tbStockDetail tbStockDetail = amscm.tbStockDetail.Find(cnnDetailId);
                        tbStockDetail.cnnPrice = 0;
                        tbStockDetail.cnnAmount = 0;

                        AMSCM.Models.tbStockDetailLog tbStockDetailLog = new AMSCM.Models.tbStockDetailLog();
                        ServiceHelper.SetEntity<AMSCM.Models.tbStockDetail, AMSCM.Models.tbStockDetailLog>(tbStockDetail, tbStockDetailLog);
                        amscm.tbStockDetailLog.Add(tbStockDetailLog);
                        //amscm.SaveChanges();
                    }
                    int inextcnnYear = icnnYear;
                    int inextcnnMonth = icnnMonth + 1;
                    if (icnnMonth == 12)
                    {
                        inextcnnYear += 1;
                        inextcnnMonth = 1;
                    }
                    var q = (from main in amscm.tbStockMain
                             join d in amscm.tbStockDetail on main.cnnMainId equals d.cnnMainId into md
                             from detail in md.DefaultIfEmpty()
                             where main.cnnYear == inextcnnYear && main.cnnMonth == inextcnnMonth
                             && main.cnnStatus == icnnCheckStatus && main.cnnSource == 1
                             orderby main.cnnMainId
                             select new { detail.cnnMainId, detail.cnnDetailId }).Distinct().ToList();
                    var q1 = (from d in q select d.cnnMainId).Distinct().ToList();
                    var q2 = (from d in q select d.cnnDetailId).Distinct().ToList();
                    if (q1.Count > 0)
                    {
                        foreach (long cnnMainId in q1)
                        {
                            AMSCM.Models.tbStockMain tbStockMain = amscm.tbStockMain.Find(cnnMainId);
                            tbStockMain.cnnStatus = (int)StockStatus.Delete;
                            amscm.tbStockMain.Remove(tbStockMain);

                            AMSCM.Models.tbStockMainLog tbStockMainLog = new AMSCM.Models.tbStockMainLog();
                            ServiceHelper.SetEntity<AMSCM.Models.tbStockMain, AMSCM.Models.tbStockMainLog>(tbStockMain, tbStockMainLog);
                            amscm.tbStockMainLog.Add(tbStockMainLog);
                            //amscm.SaveChanges();
                        }
                    }
                    if (q2.Count > 0)
                    {
                        foreach (long cnnDetailId in q2)
                        {
                            AMSCM.Models.tbStockDetail tbStockDetail = amscm.tbStockDetail.Find(cnnDetailId);
                            amscm.tbStockDetail.Remove(tbStockDetail);

                            AMSCM.Models.tbStockDetailLog tbStockDetailLog = new AMSCM.Models.tbStockDetailLog();
                            ServiceHelper.SetEntity<AMSCM.Models.tbStockDetail, AMSCM.Models.tbStockDetailLog>(tbStockDetail, tbStockDetailLog);
                            amscm.tbStockDetailLog.Add(tbStockDetailLog);
                            //amscm.SaveChanges();
                        }
                    }
                    amscm.SaveChanges();
                    //transaction.Complete();
                }
                //}
            }
            catch (TimeoutException tex)
            {
                ExceptionPolicy.HandleException(tex, ServiceHelper.ExceptionPolicy);
                return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, tex.Message));
            }
            catch (DbUpdateException dex)
            {
                ExceptionPolicy.HandleException(dex, ServiceHelper.ExceptionPolicy);
                return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(false, dex.Message));
            }
            return ServiceHelper.JsonSerializer<JEasyUIResult>(new JEasyUIResult(true, ""));
        }
        
        
        private string GetAlltbMonthlyBalance(HttpContext context)
        {
            using (AMSCM.Models.AMSCM amscm = new AMSCM.Models.AMSCM())
            {
                var ltbMonthlyBalance = (from l in amscm.tbMonthlyBalance select l).ToList();
                DataTable dt = List2DataTable(context, ltbMonthlyBalance);
                return ServiceHelper.DataTableToEasyUIJson(dt);
            }

        }
        private string getYears(HttpContext context)
        {
            List<int> lYears = new List<int>();
            lYears.Add(DateTime.Now.Year - 1);
            lYears.Add(DateTime.Now.Year);
            lYears.Add(DateTime.Now.Year + 1);
            List<SelectOption> y = (from d in lYears select new SelectOption { id = d.ToString(), text = d.ToString() + "年" }).ToList();
            DataTable dt = y.ToDataTable<SelectOption>();
            return ServiceHelper.DataTableToEasyUIJson(dt);
        }
        private string getMonths(HttpContext context)
        {
            IEnumerable<KeyValuePair<int, string>> lMonths = GetAllMonths();

            List<SelectOption> m = (from d in lMonths select new SelectOption { id = d.Key.ToString(), text = d.Value }).ToList();
            DataTable dt = m.ToDataTable<SelectOption>();
            return ServiceHelper.DataTableToEasyUIJson(dt);
        }
        private IEnumerable<KeyValuePair<int, string>> GetAllMonths()
        {
            for (int i = 1; i <= 12; i++)
            {
                yield return new KeyValuePair<int, string>(i, DateTimeFormatInfo.CurrentInfo.GetMonthName(i));
            }
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