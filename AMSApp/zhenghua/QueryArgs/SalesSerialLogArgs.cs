
/******************************************************************** FR 1.20E *******
* 项目名称：   AMSApp
* 文件名:   	SalesSerialLogArgs.cs
* 作者:	     郑华
* 创建日期:    2009-7-25
* 功能描述:    销售入库流水表日志

*                                                           Copyright(C) 2009 zhenghua
*************************************************************************************/
#region 引用
using System;
using AMSApp.zhenghua.Common;
#endregion
namespace AMSApp.zhenghua.QueryArgs
{
	/// <summary>
	/// **功能名称：销售入库流水表日志查询参数类
	/// </summary>
	public class SalesSerialLogArgs
	{
		/// <summary>
		/// 表名
		/// </summary>
		public string TableName = "tbSalesSerialLog";
				
		/// <summary>
		/// 
		/// </summary>
		public QueryConditionField cnnSerialNo = new QueryConditionField("cnnSerialNo");

		/// <summary>
		/// 
		/// </summary>
		public QueryConditionField cnnSalesSerialNo = new QueryConditionField("cnnSalesSerialNo");

		/// <summary>
		/// 
		/// </summary>
		public QueryConditionField cnvcName = new QueryConditionField("cnvcName");

		/// <summary>
		/// 
		/// </summary>
		public QueryConditionField cnvcCode = new QueryConditionField("cnvcCode");

		/// <summary>
		/// 
		/// </summary>
		public QueryConditionField cnnCount = new QueryConditionField("cnnCount");

		/// <summary>
		/// 
		/// </summary>
		public QueryConditionField cnnAddCount = new QueryConditionField("cnnAddCount");

		/// <summary>
		/// 
		/// </summary>
		public QueryConditionField cnnReduceCount = new QueryConditionField("cnnReduceCount");

		/// <summary>
		/// 
		/// </summary>
		public QueryConditionField cndCreateDate = new QueryConditionField("cndCreateDate");

		/// <summary>
		/// 
		/// </summary>
		public QueryConditionField cnvcDeptID = new QueryConditionField("cnvcDeptID");

		/// <summary>
		/// 
		/// </summary>
		public QueryConditionField cnvcOperID = new QueryConditionField("cnvcOperID");

		/// <summary>
		/// 
		/// </summary>
		public QueryConditionField cndOperDate = new QueryConditionField("cndOperDate");

		/// <summary>
		/// 
		/// </summary>
		public QueryConditionField cnvcComments = new QueryConditionField("cnvcComments");
	}	
}
