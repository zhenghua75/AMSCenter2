
/******************************************************************** FR 1.20E *******
* 项目名称：   AMSApp
* 文件名:   	SalesSerialLog.cs
* 作者:	     郑华
* 创建日期:    2009-7-25
* 功能描述:    销售入库流水表日志

*                                                           Copyright(C) 2009 zhenghua
*************************************************************************************/
#region Import NameSpace
using System;
using System.Data;
using AMSApp.zhenghua.EntityBase;
#endregion

namespace AMSApp.zhenghua.Entity
{
	/// <summary>
	/// **功能名称：销售入库流水表日志实体类
	/// </summary>
	[Serializable]
	[TableMapping("tbSalesSerialLog")]
	public class SalesSerialLog: EntityObjectBase
	{
		#region 数据表生成变量



		
		
		private int _cnnSerialNo;
		private int _cnnSalesSerialNo;
		private string _cnvcName = String.Empty;
		private string _cnvcCode = String.Empty;
		private int _cnnCount;
		private int _cnnAddCount;
		private int _cnnReduceCount;
		private DateTime _cndCreateDate;
		private string _cnvcDeptID = String.Empty;
		private string _cnvcOperID = String.Empty;
		private DateTime _cndOperDate;
		private string _cnvcComments = String.Empty;
		
		#endregion
		
		#region 构造函数




		public SalesSerialLog():base()
		{
		}
		
		public SalesSerialLog(DataRow row):base(row)
		{
		}
		
		public SalesSerialLog(DataTable table):base(table)
		{
		}
		
		public SalesSerialLog(string  strXML):base(strXML)
		{
		}
		#endregion
		
		#region 系统生成属性




				
		/// <summary>
		/// 
		/// </summary>
		[ColumnMapping("cnnSerialNo",IsPrimaryKey=true,IsIdentity=true,IsVersionNumber=false)]
		public int cnnSerialNo
		{
			get {return _cnnSerialNo;}
			set {_cnnSerialNo = value;}
		}

		/// <summary>
		/// 
		/// </summary>
		[ColumnMapping("cnnSalesSerialNo",IsPrimaryKey=false,IsIdentity=false,IsVersionNumber=false)]
		public int cnnSalesSerialNo
		{
			get {return _cnnSalesSerialNo;}
			set {_cnnSalesSerialNo = value;}
		}

		/// <summary>
		/// 
		/// </summary>
		[ColumnMapping("cnvcName",IsPrimaryKey=false,IsIdentity=false,IsVersionNumber=false)]
		public string cnvcName
		{
			get {return _cnvcName;}
			set {_cnvcName = value;}
		}

		/// <summary>
		/// 
		/// </summary>
		[ColumnMapping("cnvcCode",IsPrimaryKey=false,IsIdentity=false,IsVersionNumber=false)]
		public string cnvcCode
		{
			get {return _cnvcCode;}
			set {_cnvcCode = value;}
		}

		/// <summary>
		/// 
		/// </summary>
		[ColumnMapping("cnnCount",IsPrimaryKey=false,IsIdentity=false,IsVersionNumber=false)]
		public int cnnCount
		{
			get {return _cnnCount;}
			set {_cnnCount = value;}
		}

		/// <summary>
		/// 
		/// </summary>
		[ColumnMapping("cnnAddCount",IsPrimaryKey=false,IsIdentity=false,IsVersionNumber=false)]
		public int cnnAddCount
		{
			get {return _cnnAddCount;}
			set {_cnnAddCount = value;}
		}

		/// <summary>
		/// 
		/// </summary>
		[ColumnMapping("cnnReduceCount",IsPrimaryKey=false,IsIdentity=false,IsVersionNumber=false)]
		public int cnnReduceCount
		{
			get {return _cnnReduceCount;}
			set {_cnnReduceCount = value;}
		}

		/// <summary>
		/// 
		/// </summary>
		[ColumnMapping("cndCreateDate",IsPrimaryKey=false,IsIdentity=false,IsVersionNumber=false)]
		public DateTime cndCreateDate
		{
			get {return _cndCreateDate;}
			set {_cndCreateDate = value;}
		}

		/// <summary>
		/// 
		/// </summary>
		[ColumnMapping("cnvcDeptID",IsPrimaryKey=false,IsIdentity=false,IsVersionNumber=false)]
		public string cnvcDeptID
		{
			get {return _cnvcDeptID;}
			set {_cnvcDeptID = value;}
		}

		/// <summary>
		/// 
		/// </summary>
		[ColumnMapping("cnvcOperID",IsPrimaryKey=false,IsIdentity=false,IsVersionNumber=false)]
		public string cnvcOperID
		{
			get {return _cnvcOperID;}
			set {_cnvcOperID = value;}
		}

		/// <summary>
		/// 
		/// </summary>
		[ColumnMapping("cndOperDate",IsPrimaryKey=false,IsIdentity=false,IsVersionNumber=false)]
		public DateTime cndOperDate
		{
			get {return _cndOperDate;}
			set {_cndOperDate = value;}
		}

		/// <summary>
		/// 
		/// </summary>
		[ColumnMapping("cnvcComments",IsPrimaryKey=false,IsIdentity=false,IsVersionNumber=false)]
		public string cnvcComments
		{
			get {return _cnvcComments;}
			set {_cnvcComments = value;}
		}
		#endregion
	}	
}
