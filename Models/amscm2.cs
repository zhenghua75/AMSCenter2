using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace AMSCM.Models
{
    public partial class AMSCM
    {
        public AMSCM()
            : base()
        {
            //this.Database.Connection.ConnectionString = "";
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbProduceDetailReduce>().ToTable("tbProduceDetailReduce");
            modelBuilder.Entity<tbProduceLog>().ToTable("tbProduceLog");
            modelBuilder.Entity<tbProduceOrderLog>().ToTable("tbProduceOrderLog");
            modelBuilder.Entity<tbProductSerial>().ToTable("tbProductSerial");
            modelBuilder.Entity<dtproperties>().ToTable("dtproperties");
            modelBuilder.Entity<tbUnitInvert>().ToTable("tbUnitInvert");
            modelBuilder.Entity<tbCheckSerial>().ToTable("tbCheckSerial");
            //modelBuilder.Entity<tbCommCodeTmp>().ToTable("tbCommCodeTmp");
            //modelBuilder.Entity<tbGoodsTmp>().ToTable("tbGoodsTmp");
            modelBuilder.Entity<tbProductLostSerial>().ToTable("tbProductLostSerial");
            //modelBuilder.Entity<tbConsItemHung>().ToTable("tbConsItemHung");
            modelBuilder.Entity<tbProductLostSerialLog>().ToTable("tbProductLostSerialLog");
            modelBuilder.Entity<tbProductSerialLog>().ToTable("tbProductSerialLog");
            modelBuilder.Entity<tbLogin>().ToTable("tbLogin");
            modelBuilder.Entity<tbCheckSerialLog>().ToTable("tbCheckSerialLog");
            modelBuilder.Entity<tbDataSoftUpdateLog>().ToTable("tbDataSoftUpdateLog");
            modelBuilder.Entity<tbSellDayCheckLog>().ToTable("tbSellDayCheckLog");
            modelBuilder.Entity<tbMaterialEnter>().ToTable("tbMaterialEnter");
            modelBuilder.Entity<tbEmpSign>().ToTable("tbEmpSign");
            //modelBuilder.Entity<tbEmpSignTmp>().ToTable("tbEmpSignTmp");
            modelBuilder.Entity<tbFillFee>().ToTable("tbFillFee");
            //modelBuilder.Entity<tbMaterialParaMonthBak>().ToTable("tbMaterialParaMonthBak");
            modelBuilder.Entity<tbMaterialOut>().ToTable("tbMaterialOut");
            modelBuilder.Entity<tbEmployee>().ToTable("tbEmployee");
            modelBuilder.Entity<tbMaterialPara>().ToTable("tbMaterialPara");
            modelBuilder.Entity<tbMaterial>().ToTable("tbMaterial");
            //modelBuilder.Entity<tbEmployeeTmp>().ToTable("tbEmployeeTmp");
            modelBuilder.Entity<tbDosage>().ToTable("tbDosage");
            modelBuilder.Entity<tbMacAddress>().ToTable("tbMacAddress");
            modelBuilder.Entity<tbProductClass>().ToTable("tbProductClass");
            //modelBuilder.Entity<tbAssChange>().ToTable("tbAssChange");
            //modelBuilder.Entity<tbGoods_tmp>().ToTable("tbGoods_tmp");
            modelBuilder.Entity<tbConsItemOther>().ToTable("tbConsItemOther");
            //modelBuilder.Entity<tbGoods_20101130>().ToTable("tbGoods_20101130");
            //modelBuilder.Entity<tbEmpSchLog>().ToTable("tbEmpSchLog");
            modelBuilder.Entity<tbGroupGoods>().ToTable("tbGroupGoods");
            modelBuilder.Entity<tbSignList>().ToTable("tbSignList");
            modelBuilder.Entity<tbBillOther>().ToTable("tbBillOther");
            modelBuilder.Entity<tbIntegralLogOther>().ToTable("tbIntegralLogOther");
            modelBuilder.Entity<tbFillFeeOther>().ToTable("tbFillFeeOther");
            modelBuilder.Entity<tbBusiLogOther>().ToTable("tbBusiLogOther");
            modelBuilder.Entity<tbInventory>().ToTable("tbInventory");
            modelBuilder.Entity<tbMakeDetail>().ToTable("tbMakeDetail");
            modelBuilder.Entity<tbGroupMake>().ToTable("tbGroupMake");
            modelBuilder.Entity<tbComputationGroup>().ToTable("tbComputationGroup");
            modelBuilder.Entity<tbComputationUnit>().ToTable("tbComputationUnit");
            modelBuilder.Entity<tbWarehouse>().ToTable("tbWarehouse");
            //modelBuilder.Entity<tbProviderNew>().ToTable("tbProviderNew");
            modelBuilder.Entity<tbRepAssDailyIGCharge>().ToTable("tbRepAssDailyIGCharge");
            modelBuilder.Entity<tbStockPlan>().ToTable("tbStockPlan");
            modelBuilder.Entity<tbStockPlanDetail>().ToTable("tbStockPlanDetail");
            modelBuilder.Entity<tbRepAssCount>().ToTable("tbRepAssCount");
            modelBuilder.Entity<tbProduceCheckLog>().ToTable("tbProduceCheckLog");
            modelBuilder.Entity<tbRepAssFill>().ToTable("tbRepAssFill");
            modelBuilder.Entity<tbBillHis>().ToTable("tbBillHis");
            modelBuilder.Entity<tbRepAssConsDaily>().ToTable("tbRepAssConsDaily");
            modelBuilder.Entity<tbBusiLogHis>().ToTable("tbBusiLogHis");
            modelBuilder.Entity<tbRepAssLarg>().ToTable("tbRepAssLarg");
            modelBuilder.Entity<tbConsItemHis>().ToTable("tbConsItemHis");
            modelBuilder.Entity<tbFunc>().ToTable("tbFunc");
            modelBuilder.Entity<tbRepAssSpecCons>().ToTable("tbRepAssSpecCons");
            modelBuilder.Entity<tbFillFeeHis>().ToTable("tbFillFeeHis");
            modelBuilder.Entity<tbOperFunc>().ToTable("tbOperFunc");
            modelBuilder.Entity<tbOperLog>().ToTable("tbOperLog");
            modelBuilder.Entity<tbIntegralLogHis>().ToTable("tbIntegralLogHis");
            modelBuilder.Entity<tbAssignDetail>().ToTable("tbAssignDetail");
            modelBuilder.Entity<tbAssignDetailLog>().ToTable("tbAssignDetailLog");
            modelBuilder.Entity<tbBespeakLog>().ToTable("tbBespeakLog");
            modelBuilder.Entity<tbBillOfEnterStorageLog>().ToTable("tbBillOfEnterStorageLog");
            modelBuilder.Entity<tbAssignLog>().ToTable("tbAssignLog");
            //modelBuilder.Entity<tbProvider>().ToTable("tbProvider");
            modelBuilder.Entity<tbDept>().ToTable("tbDept");
            modelBuilder.Entity<tbBillOfEnterStorageDetail>().ToTable("tbBillOfEnterStorageDetail");
            modelBuilder.Entity<tbFormula>().ToTable("tbFormula");
            modelBuilder.Entity<tbBusiIncomeReport>().ToTable("tbBusiIncomeReport");
            modelBuilder.Entity<tbSysErrorLog>().ToTable("tbSysErrorLog");
            modelBuilder.Entity<tbSellDayCheckDetail>().ToTable("tbSellDayCheckDetail");
            //modelBuilder.Entity<tbSellDayCheckDetailTmp>().ToTable("tbSellDayCheckDetailTmp");
            modelBuilder.Entity<tbAssociatorSync>().ToTable("tbAssociatorSync");
            modelBuilder.Entity<tbMakeLog>().ToTable("tbMakeLog");
            modelBuilder.Entity<tbAssociatorLog>().ToTable("tbAssociatorLog");
            modelBuilder.Entity<tbStorage>().ToTable("tbStorage");
            modelBuilder.Entity<tbNameCode>().ToTable("tbNameCode");
            modelBuilder.Entity<tbStorageLog>().ToTable("tbStorageLog");
            modelBuilder.Entity<tbOperStandard>().ToTable("tbOperStandard");
            modelBuilder.Entity<tbOrderAddLog>().ToTable("tbOrderAddLog");
            modelBuilder.Entity<tbBillOfReceiveDetail>().ToTable("tbBillOfReceiveDetail");
            modelBuilder.Entity<tbOrderBook>().ToTable("tbOrderBook");
            modelBuilder.Entity<tbAssociator>().ToTable("tbAssociator");
            modelBuilder.Entity<tbBillOfReceiveLog>().ToTable("tbBillOfReceiveLog");
            modelBuilder.Entity<tbOrderBookDetail>().ToTable("tbOrderBookDetail");
            modelBuilder.Entity<tbBill>().ToTable("tbBill");
            modelBuilder.Entity<tbBusiLog>().ToTable("tbBusiLog");
            //modelBuilder.Entity<tbDeptMapInfo>().ToTable("tbDeptMapInfo");
            modelBuilder.Entity<tbOrderReduceLog>().ToTable("tbOrderReduceLog");
            //modelBuilder.Entity<tbCommCode>().ToTable("tbCommCode");
            modelBuilder.Entity<tbMoveDetail>().ToTable("tbMoveDetail");
            modelBuilder.Entity<tbConsItem>().ToTable("tbConsItem");
            modelBuilder.Entity<tbOrderSerialNo>().ToTable("tbOrderSerialNo");
            //modelBuilder.Entity<tbAssociatorDownUpTmp>().ToTable("tbAssociatorDownUpTmp");
            modelBuilder.Entity<tbConsSerialNo>().ToTable("tbConsSerialNo");
            modelBuilder.Entity<tbMoveLog>().ToTable("tbMoveLog");
            //modelBuilder.Entity<tbBillDownUpTmp>().ToTable("tbBillDownUpTmp");
            //modelBuilder.Entity<tbBusiLogDownUpTmp>().ToTable("tbBusiLogDownUpTmp");
            modelBuilder.Entity<tbGoods>().ToTable("tbGoods");
            modelBuilder.Entity<tbSellLoseLog>().ToTable("tbSellLoseLog");
            //modelBuilder.Entity<tbConsItemDownUpTmp>().ToTable("tbConsItemDownUpTmp");
            modelBuilder.Entity<tbIntegralLog>().ToTable("tbIntegralLog");
            modelBuilder.Entity<tbProduceDetail>().ToTable("tbProduceDetail");
            //modelBuilder.Entity<tbFillFeeDownUpTmp>().ToTable("tbFillFeeDownUpTmp");
            modelBuilder.Entity<tbOper>().ToTable("tbOper");
            modelBuilder.Entity<tbNotice>().ToTable("tbNotice");
            //modelBuilder.Entity<tbIntegralLogDownUpTmp>().ToTable("tbIntegralLogDownUpTmp");
            modelBuilder.Entity<tbProduceDetailAdd>().ToTable("tbProduceDetailAdd");
            modelBuilder.Entity<tbSupplier>().ToTable("tbSupplier");
            modelBuilder.Entity<tbStockMain>().ToTable("tbStockMain");
            modelBuilder.Entity<tbStockDetail>().ToTable("tbStockDetail");
            modelBuilder.Entity<tbStockMainLog>().ToTable("tbStockMainLog");
            modelBuilder.Entity<tbStockDetailLog>().ToTable("tbStockDetailLog");
            modelBuilder.Entity<tbMonthlyBalance>().ToTable("tbMonthlyBalance");
            modelBuilder.Entity<tbMonthlyBalanceLog>().ToTable("tbMonthlyBalanceLog");


            modelBuilder.Entity<tbStockDetail>().Property(o => o.cnnQuantity).HasPrecision(24, 9);
            modelBuilder.Entity<tbStockDetail>().Property(o => o.cnnPrice).HasPrecision(24, 9);
            modelBuilder.Entity<tbStockDetail>().Property(o => o.cnnAmount).HasPrecision(24, 9);
            modelBuilder.Entity<tbStockDetail>().Property(o => o.cnnMainQuantity).HasPrecision(24, 9);
            base.OnModelCreating(modelBuilder);

        }
    }
}
