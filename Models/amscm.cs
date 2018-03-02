using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AMSCM.Models 
{		
		 			
		public class tbProduceDetailReduce : INotifyPropertyChanged							
		{
						
			private Decimal _cnnProduceSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnProduceSerialNo 
			{
				get { return _cnnProduceSerialNo;}
				set
				{
					 _cnnProduceSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnProduceSerialNo"));
				}
			}						
							
			private Decimal _cnnReduceSerialNo; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public Decimal cnnReduceSerialNo 
			{
				get { return _cnnReduceSerialNo;}
				set
				{
					 _cnnReduceSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnReduceSerialNo"));
				}
			}						
							
			private String _cnvcCode; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String cnvcCode 
			{
				get { return _cnvcCode;}
				set
				{
					 _cnvcCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCode"));
				}
			}						
							
			private String _cnvcName; 
							 			
			public String cnvcName 
			{
				get { return _cnvcName;}
				set
				{
					 _cnvcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcName"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnCount; 
							 			
			public Decimal? cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private String _cnvcState; 
							 			
			public String cnvcState 
			{
				get { return _cnvcState;}
				set
				{
					 _cnvcState = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcState"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbProduceLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnProduceSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnProduceSerialNo 
			{
				get { return _cnnProduceSerialNo;}
				set
				{
					 _cnnProduceSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnProduceSerialNo"));
				}
			}						
							
			private String _cnvcProduceDeptID; 
							 			
			public String cnvcProduceDeptID 
			{
				get { return _cnvcProduceDeptID;}
				set
				{
					 _cnvcProduceDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProduceDeptID"));
				}
			}						
							
			private DateTime? _cndProduceDate; 
							 			
			public DateTime? cndProduceDate 
			{
				get { return _cndProduceDate;}
				set
				{
					 _cndProduceDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndProduceDate"));
				}
			}						
							
			private DateTime? _cndShipBeginDate; 
							 			
			public DateTime? cndShipBeginDate 
			{
				get { return _cndShipBeginDate;}
				set
				{
					 _cndShipBeginDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndShipBeginDate"));
				}
			}						
							
			private DateTime? _cndShipEndDate; 
							 			
			public DateTime? cndShipEndDate 
			{
				get { return _cndShipEndDate;}
				set
				{
					 _cndShipEndDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndShipEndDate"));
				}
			}						
							
			private String _cnvcProduceState; 
							 			
			public String cnvcProduceState 
			{
				get { return _cnvcProduceState;}
				set
				{
					 _cnvcProduceState = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProduceState"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbProduceOrderLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnProduceSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnProduceSerialNo 
			{
				get { return _cnnProduceSerialNo;}
				set
				{
					 _cnnProduceSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnProduceSerialNo"));
				}
			}						
							
			private Decimal _cnnOrderSerialNo; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public Decimal cnnOrderSerialNo 
			{
				get { return _cnnOrderSerialNo;}
				set
				{
					 _cnnOrderSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOrderSerialNo"));
				}
			}						
							
			private String _cnvcType; 
							 			
			public String cnvcType 
			{
				get { return _cnvcType;}
				set
				{
					 _cnvcType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcType"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbProductSerial : INotifyPropertyChanged							
		{
						
			private Int32 _cnnSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int32 cnnSerialNo 
			{
				get { return _cnnSerialNo;}
				set
				{
					 _cnnSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSerialNo"));
				}
			}						
							
			private String _cnvcName; 
							 			
			public String cnvcName 
			{
				get { return _cnvcName;}
				set
				{
					 _cnvcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcName"));
				}
			}						
							
			private String _cnvcCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcCode 
			{
				get { return _cnvcCode;}
				set
				{
					 _cnvcCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCode"));
				}
			}						
							
			private Int32 _cnnCount; 
							 			
			public Int32 cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private Int32 _cnnAddCount; 
							 			
			public Int32 cnnAddCount 
			{
				get { return _cnnAddCount;}
				set
				{
					 _cnnAddCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAddCount"));
				}
			}						
							
			private Int32 _cnnReduceCount; 
							 			
			public Int32 cnnReduceCount 
			{
				get { return _cnnReduceCount;}
				set
				{
					 _cnnReduceCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnReduceCount"));
				}
			}						
							
			private DateTime _cndCreateDate; 
							 			
			public DateTime cndCreateDate 
			{
				get { return _cndCreateDate;}
				set
				{
					 _cndCreateDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndCreateDate"));
				}
			}						
							
			private String _cnvcDeptID; 
							 			
			public String cnvcDeptID 
			{
				get { return _cnvcDeptID;}
				set
				{
					 _cnvcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptID"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class dtproperties : INotifyPropertyChanged							
		{
						
			private Int32 _id; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int32 id 
			{
				get { return _id;}
				set
				{
					 _id = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("id"));
				}
			}						
							
			private Int32? _objectid; 
							 			
			public Int32? objectid 
			{
				get { return _objectid;}
				set
				{
					 _objectid = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("objectid"));
				}
			}						
							
			private String _property; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String property 
			{
				get { return _property;}
				set
				{
					 _property = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("property"));
				}
			}						
							
			private String _value; 
							 			
			public String value 
			{
				get { return _value;}
				set
				{
					 _value = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("value"));
				}
			}						
							
			private String _uvalue; 
							 			
			public String uvalue 
			{
				get { return _uvalue;}
				set
				{
					 _uvalue = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("uvalue"));
				}
			}						
							
			private Byte[] _lvalue; 
							 			
			public Byte[] lvalue 
			{
				get { return _lvalue;}
				set
				{
					 _lvalue = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("lvalue"));
				}
			}						
							
			private Int32 _version; 
							 			
			public Int32 version 
			{
				get { return _version;}
				set
				{
					 _version = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("version"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbUnitInvert : INotifyPropertyChanged							
		{
						
			private String _cnvcUnit; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private String _cnvcStandardUnit; 
							 			
			public String cnvcStandardUnit 
			{
				get { return _cnvcStandardUnit;}
				set
				{
					 _cnvcStandardUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcStandardUnit"));
				}
			}						
							
			private Decimal? _cnnStatdardCount; 
							 			
			public Decimal? cnnStatdardCount 
			{
				get { return _cnnStatdardCount;}
				set
				{
					 _cnnStatdardCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnStatdardCount"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbCheckSerial : INotifyPropertyChanged							
		{
						
			private Int32 _cnnSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int32 cnnSerialNo 
			{
				get { return _cnnSerialNo;}
				set
				{
					 _cnnSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSerialNo"));
				}
			}						
							
			private String _cnvcName; 
							 			
			public String cnvcName 
			{
				get { return _cnvcName;}
				set
				{
					 _cnvcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcName"));
				}
			}						
							
			private String _cnvcCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcCode 
			{
				get { return _cnvcCode;}
				set
				{
					 _cnvcCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCode"));
				}
			}						
							
			private Int32 _cnnCount; 
							 			
			public Int32 cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private Int32 _cnnAddCount; 
							 			
			public Int32 cnnAddCount 
			{
				get { return _cnnAddCount;}
				set
				{
					 _cnnAddCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAddCount"));
				}
			}						
							
			private Int32 _cnnReduceCount; 
							 			
			public Int32 cnnReduceCount 
			{
				get { return _cnnReduceCount;}
				set
				{
					 _cnnReduceCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnReduceCount"));
				}
			}						
							
			private DateTime _cndCreateDate; 
							 			
			public DateTime cndCreateDate 
			{
				get { return _cndCreateDate;}
				set
				{
					 _cndCreateDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndCreateDate"));
				}
			}						
							
			private String _cnvcDeptID; 
							 			
			public String cnvcDeptID 
			{
				get { return _cnvcDeptID;}
				set
				{
					 _cnvcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptID"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
							
			private Boolean? _cnbIsSales; 
							 			
			public Boolean? cnbIsSales 
			{
				get { return _cnbIsSales;}
				set
				{
					 _cnbIsSales = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnbIsSales"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbProductLostSerial : INotifyPropertyChanged							
		{
						
			private Int32 _cnnSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int32 cnnSerialNo 
			{
				get { return _cnnSerialNo;}
				set
				{
					 _cnnSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSerialNo"));
				}
			}						
							
			private String _cnvcName; 
							 			
			public String cnvcName 
			{
				get { return _cnvcName;}
				set
				{
					 _cnvcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcName"));
				}
			}						
							
			private String _cnvcCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcCode 
			{
				get { return _cnvcCode;}
				set
				{
					 _cnvcCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCode"));
				}
			}						
							
			private Int32 _cnnCount; 
							 			
			public Int32 cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private Int32 _cnnAddCount; 
							 			
			public Int32 cnnAddCount 
			{
				get { return _cnnAddCount;}
				set
				{
					 _cnnAddCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAddCount"));
				}
			}						
							
			private Int32 _cnnReduceCount; 
							 			
			public Int32 cnnReduceCount 
			{
				get { return _cnnReduceCount;}
				set
				{
					 _cnnReduceCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnReduceCount"));
				}
			}						
							
			private DateTime _cndLostDate; 
							 			
			public DateTime cndLostDate 
			{
				get { return _cndLostDate;}
				set
				{
					 _cndLostDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndLostDate"));
				}
			}						
							
			private String _cnvcDeptID; 
							 			
			public String cnvcDeptID 
			{
				get { return _cnvcDeptID;}
				set
				{
					 _cnvcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptID"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbStockDetail : INotifyPropertyChanged							
		{
						
			private Int64 _cnnDetailId; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 cnnDetailId 
			{
				get { return _cnnDetailId;}
				set
				{
					 _cnnDetailId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnDetailId"));
				}
			}						
							
			private Int64 _cnnMainId; 
							 			
			public Int64 cnnMainId 
			{
				get { return _cnnMainId;}
				set
				{
					 _cnnMainId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMainId"));
				}
			}						
							
			private String _cnvcInvCode; 
							 			
			public String cnvcInvCode 
			{
				get { return _cnvcInvCode;}
				set
				{
					 _cnvcInvCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcInvCode"));
				}
			}						
							
			private String _cnvcComUnitCode; 
							 			
			public String cnvcComUnitCode 
			{
				get { return _cnvcComUnitCode;}
				set
				{
					 _cnvcComUnitCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComUnitCode"));
				}
			}						
							
			private Decimal _cnnQuantity; 
							 			
			public Decimal cnnQuantity 
			{
				get { return _cnnQuantity;}
				set
				{
					 _cnnQuantity = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnQuantity"));
				}
			}						
							
			private String _cnvcMainComUnitCode; 
							 			
			public String cnvcMainComUnitCode 
			{
				get { return _cnvcMainComUnitCode;}
				set
				{
					 _cnvcMainComUnitCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMainComUnitCode"));
				}
			}						
							
			private Decimal _cnnMainQuantity; 
							 			
			public Decimal cnnMainQuantity 
			{
				get { return _cnnMainQuantity;}
				set
				{
					 _cnnMainQuantity = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMainQuantity"));
				}
			}						
							
			private Decimal _cnnPrice; 
							 			
			public Decimal cnnPrice 
			{
				get { return _cnnPrice;}
				set
				{
					 _cnnPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPrice"));
				}
			}						
							
			private Decimal _cnnAmount; 
							 			
			public Decimal cnnAmount 
			{
				get { return _cnnAmount;}
				set
				{
					 _cnnAmount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAmount"));
				}
			}						
							
			private DateTime _cndOperDate; 
							 			
			public DateTime cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private String _cnvcOper; 
							 			
			public String cnvcOper 
			{
				get { return _cnvcOper;}
				set
				{
					 _cnvcOper = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOper"));
				}
			}						
							
			private String _cnvcOperName; 
							 			
			public String cnvcOperName 
			{
				get { return _cnvcOperName;}
				set
				{
					 _cnvcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperName"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbStockDetailLog : INotifyPropertyChanged							
		{
						
			private Int64 _cnnId; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 cnnId 
			{
				get { return _cnnId;}
				set
				{
					 _cnnId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnId"));
				}
			}						
							
			private Int64 _cnnDetailId; 
							 			
			public Int64 cnnDetailId 
			{
				get { return _cnnDetailId;}
				set
				{
					 _cnnDetailId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnDetailId"));
				}
			}						
							
			private Int64 _cnnMainId; 
							 			
			public Int64 cnnMainId 
			{
				get { return _cnnMainId;}
				set
				{
					 _cnnMainId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMainId"));
				}
			}						
							
			private String _cnvcInvCode; 
							 			
			public String cnvcInvCode 
			{
				get { return _cnvcInvCode;}
				set
				{
					 _cnvcInvCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcInvCode"));
				}
			}						
							
			private String _cnvcComUnitCode; 
							 			
			public String cnvcComUnitCode 
			{
				get { return _cnvcComUnitCode;}
				set
				{
					 _cnvcComUnitCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComUnitCode"));
				}
			}						
							
			private Decimal _cnnQuantity; 
							 			
			public Decimal cnnQuantity 
			{
				get { return _cnnQuantity;}
				set
				{
					 _cnnQuantity = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnQuantity"));
				}
			}						
							
			private String _cnvcMainComUnitCode; 
							 			
			public String cnvcMainComUnitCode 
			{
				get { return _cnvcMainComUnitCode;}
				set
				{
					 _cnvcMainComUnitCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMainComUnitCode"));
				}
			}						
							
			private Decimal _cnnMainQuantity; 
							 			
			public Decimal cnnMainQuantity 
			{
				get { return _cnnMainQuantity;}
				set
				{
					 _cnnMainQuantity = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMainQuantity"));
				}
			}						
							
			private Decimal _cnnPrice; 
							 			
			public Decimal cnnPrice 
			{
				get { return _cnnPrice;}
				set
				{
					 _cnnPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPrice"));
				}
			}						
							
			private Decimal _cnnAmount; 
							 			
			public Decimal cnnAmount 
			{
				get { return _cnnAmount;}
				set
				{
					 _cnnAmount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAmount"));
				}
			}						
							
			private DateTime _cndOperDate; 
							 			
			public DateTime cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private String _cnvcOper; 
							 			
			public String cnvcOper 
			{
				get { return _cnvcOper;}
				set
				{
					 _cnvcOper = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOper"));
				}
			}						
							
			private String _cnvcOperName; 
							 			
			public String cnvcOperName 
			{
				get { return _cnvcOperName;}
				set
				{
					 _cnvcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperName"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbProductLostSerialLog : INotifyPropertyChanged							
		{
						
			private Int32 _cnnSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int32 cnnSerialNo 
			{
				get { return _cnnSerialNo;}
				set
				{
					 _cnnSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSerialNo"));
				}
			}						
							
			private Int32 _cnnProductLostSerialNo; 
							 			
			public Int32 cnnProductLostSerialNo 
			{
				get { return _cnnProductLostSerialNo;}
				set
				{
					 _cnnProductLostSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnProductLostSerialNo"));
				}
			}						
							
			private String _cnvcName; 
							 			
			public String cnvcName 
			{
				get { return _cnvcName;}
				set
				{
					 _cnvcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcName"));
				}
			}						
							
			private String _cnvcCode; 
							 			
			public String cnvcCode 
			{
				get { return _cnvcCode;}
				set
				{
					 _cnvcCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCode"));
				}
			}						
							
			private Int32 _cnnCount; 
							 			
			public Int32 cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private Int32 _cnnAddCount; 
							 			
			public Int32 cnnAddCount 
			{
				get { return _cnnAddCount;}
				set
				{
					 _cnnAddCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAddCount"));
				}
			}						
							
			private Int32 _cnnReduceCount; 
							 			
			public Int32 cnnReduceCount 
			{
				get { return _cnnReduceCount;}
				set
				{
					 _cnnReduceCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnReduceCount"));
				}
			}						
							
			private DateTime _cndLostDate; 
							 			
			public DateTime cndLostDate 
			{
				get { return _cndLostDate;}
				set
				{
					 _cndLostDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndLostDate"));
				}
			}						
							
			private String _cnvcDeptID; 
							 			
			public String cnvcDeptID 
			{
				get { return _cnvcDeptID;}
				set
				{
					 _cnvcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptID"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbProductSerialLog : INotifyPropertyChanged							
		{
						
			private Int32 _cnnSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int32 cnnSerialNo 
			{
				get { return _cnnSerialNo;}
				set
				{
					 _cnnSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSerialNo"));
				}
			}						
							
			private Int32 _cnnProductSerialNo; 
							 			
			public Int32 cnnProductSerialNo 
			{
				get { return _cnnProductSerialNo;}
				set
				{
					 _cnnProductSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnProductSerialNo"));
				}
			}						
							
			private String _cnvcName; 
							 			
			public String cnvcName 
			{
				get { return _cnvcName;}
				set
				{
					 _cnvcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcName"));
				}
			}						
							
			private String _cnvcCode; 
							 			
			public String cnvcCode 
			{
				get { return _cnvcCode;}
				set
				{
					 _cnvcCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCode"));
				}
			}						
							
			private Int32 _cnnCount; 
							 			
			public Int32 cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private Int32 _cnnAddCount; 
							 			
			public Int32 cnnAddCount 
			{
				get { return _cnnAddCount;}
				set
				{
					 _cnnAddCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAddCount"));
				}
			}						
							
			private Int32 _cnnReduceCount; 
							 			
			public Int32 cnnReduceCount 
			{
				get { return _cnnReduceCount;}
				set
				{
					 _cnnReduceCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnReduceCount"));
				}
			}						
							
			private DateTime _cndCreateDate; 
							 			
			public DateTime cndCreateDate 
			{
				get { return _cndCreateDate;}
				set
				{
					 _cndCreateDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndCreateDate"));
				}
			}						
							
			private String _cnvcDeptID; 
							 			
			public String cnvcDeptID 
			{
				get { return _cnvcDeptID;}
				set
				{
					 _cnvcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptID"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbLogin : INotifyPropertyChanged							
		{
						
			private String _vcLoginID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcLoginID 
			{
				get { return _vcLoginID;}
				set
				{
					 _vcLoginID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcLoginID"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private String _vcLimit; 
							 			
			public String vcLimit 
			{
				get { return _vcLimit;}
				set
				{
					 _vcLimit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcLimit"));
				}
			}						
							
			private String _vcPwd; 
							 			
			public String vcPwd 
			{
				get { return _vcPwd;}
				set
				{
					 _vcPwd = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcPwd"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbStockMain : INotifyPropertyChanged							
		{
						
			private Int64 _cnnMainId; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 cnnMainId 
			{
				get { return _cnnMainId;}
				set
				{
					 _cnnMainId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMainId"));
				}
			}						
							
			private String _cnvcSupplierCode; 
							 			
			public String cnvcSupplierCode 
			{
				get { return _cnvcSupplierCode;}
				set
				{
					 _cnvcSupplierCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcSupplierCode"));
				}
			}						
							
			private String _cnvcWhCode; 
							 			
			public String cnvcWhCode 
			{
				get { return _cnvcWhCode;}
				set
				{
					 _cnvcWhCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcWhCode"));
				}
			}						
							
			private String _cnvcDeptId; 
							 			
			public String cnvcDeptId 
			{
				get { return _cnvcDeptId;}
				set
				{
					 _cnvcDeptId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptId"));
				}
			}						
							
			private Int32 _cnnOperType; 
							 			
			public Int32 cnnOperType 
			{
				get { return _cnnOperType;}
				set
				{
					 _cnnOperType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOperType"));
				}
			}						
							
			private Int64 _cnnSource; 
							 			
			public Int64 cnnSource 
			{
				get { return _cnnSource;}
				set
				{
					 _cnnSource = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSource"));
				}
			}						
							
			private DateTime _cndCreateDate; 
							 			
			public DateTime cndCreateDate 
			{
				get { return _cndCreateDate;}
				set
				{
					 _cndCreateDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndCreateDate"));
				}
			}						
							
			private String _cnvcCreaterId; 
							 			
			public String cnvcCreaterId 
			{
				get { return _cnvcCreaterId;}
				set
				{
					 _cnvcCreaterId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCreaterId"));
				}
			}						
							
			private String _cnvcCreaterName; 
							 			
			public String cnvcCreaterName 
			{
				get { return _cnvcCreaterName;}
				set
				{
					 _cnvcCreaterName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCreaterName"));
				}
			}						
							
			private DateTime? _cndModifyDate; 
							 			
			public DateTime? cndModifyDate 
			{
				get { return _cndModifyDate;}
				set
				{
					 _cndModifyDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndModifyDate"));
				}
			}						
							
			private String _cnvcModifier; 
							 			
			public String cnvcModifier 
			{
				get { return _cnvcModifier;}
				set
				{
					 _cnvcModifier = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcModifier"));
				}
			}						
							
			private String _cnvcModifierName; 
							 			
			public String cnvcModifierName 
			{
				get { return _cnvcModifierName;}
				set
				{
					 _cnvcModifierName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcModifierName"));
				}
			}						
							
			private DateTime? _cndCheckDate; 
							 			
			public DateTime? cndCheckDate 
			{
				get { return _cndCheckDate;}
				set
				{
					 _cndCheckDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndCheckDate"));
				}
			}						
							
			private String _cnvcCheckerId; 
							 			
			public String cnvcCheckerId 
			{
				get { return _cnvcCheckerId;}
				set
				{
					 _cnvcCheckerId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCheckerId"));
				}
			}						
							
			private String _cnvcCheckerName; 
							 			
			public String cnvcCheckerName 
			{
				get { return _cnvcCheckerName;}
				set
				{
					 _cnvcCheckerName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCheckerName"));
				}
			}						
							
			private DateTime _cndBusinessDate; 
							 			
			public DateTime cndBusinessDate 
			{
				get { return _cndBusinessDate;}
				set
				{
					 _cndBusinessDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndBusinessDate"));
				}
			}						
							
			private Int32 _cnnYear; 
							 			
			public Int32 cnnYear 
			{
				get { return _cnnYear;}
				set
				{
					 _cnnYear = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnYear"));
				}
			}						
							
			private Int32 _cnnMonth; 
							 			
			public Int32 cnnMonth 
			{
				get { return _cnnMonth;}
				set
				{
					 _cnnMonth = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMonth"));
				}
			}						
							
			private Int32 _cnnStatus; 
							 			
			public Int32 cnnStatus 
			{
				get { return _cnnStatus;}
				set
				{
					 _cnnStatus = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnStatus"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
							
			private Int32 _cnnDirection; 
							 			
			public Int32 cnnDirection 
			{
				get { return _cnnDirection;}
				set
				{
					 _cnnDirection = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnDirection"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbCheckSerialLog : INotifyPropertyChanged							
		{
						
			private Int32 _cnnSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int32 cnnSerialNo 
			{
				get { return _cnnSerialNo;}
				set
				{
					 _cnnSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSerialNo"));
				}
			}						
							
			private Int32 _cnnCheckSerialNo; 
							 			
			public Int32 cnnCheckSerialNo 
			{
				get { return _cnnCheckSerialNo;}
				set
				{
					 _cnnCheckSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCheckSerialNo"));
				}
			}						
							
			private String _cnvcName; 
							 			
			public String cnvcName 
			{
				get { return _cnvcName;}
				set
				{
					 _cnvcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcName"));
				}
			}						
							
			private String _cnvcCode; 
							 			
			public String cnvcCode 
			{
				get { return _cnvcCode;}
				set
				{
					 _cnvcCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCode"));
				}
			}						
							
			private Int32 _cnnCount; 
							 			
			public Int32 cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private Int32 _cnnAddCount; 
							 			
			public Int32 cnnAddCount 
			{
				get { return _cnnAddCount;}
				set
				{
					 _cnnAddCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAddCount"));
				}
			}						
							
			private Int32 _cnnReduceCount; 
							 			
			public Int32 cnnReduceCount 
			{
				get { return _cnnReduceCount;}
				set
				{
					 _cnnReduceCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnReduceCount"));
				}
			}						
							
			private DateTime _cndCreateDate; 
							 			
			public DateTime cndCreateDate 
			{
				get { return _cndCreateDate;}
				set
				{
					 _cndCreateDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndCreateDate"));
				}
			}						
							
			private String _cnvcDeptID; 
							 			
			public String cnvcDeptID 
			{
				get { return _cnvcDeptID;}
				set
				{
					 _cnvcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptID"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
							
			private Boolean? _cnbIsSales; 
							 			
			public Boolean? cnbIsSales 
			{
				get { return _cnbIsSales;}
				set
				{
					 _cnbIsSales = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnbIsSales"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbDataSoftUpdateLog : INotifyPropertyChanged							
		{
						
			private String _vcFileName; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcFileName 
			{
				get { return _vcFileName;}
				set
				{
					 _vcFileName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcFileName"));
				}
			}						
							
			private Int64? _FileSize; 
							 			
			public Int64? FileSize 
			{
				get { return _FileSize;}
				set
				{
					 _FileSize = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("FileSize"));
				}
			}						
							
			private Int32? _FileCount; 
							 			
			public Int32? FileCount 
			{
				get { return _FileCount;}
				set
				{
					 _FileCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("FileCount"));
				}
			}						
							
			private DateTime? _dtStartDate; 
							 			
			public DateTime? dtStartDate 
			{
				get { return _dtStartDate;}
				set
				{
					 _dtStartDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtStartDate"));
				}
			}						
							
			private DateTime? _dtFinDate; 
							 			
			public DateTime? dtFinDate 
			{
				get { return _dtFinDate;}
				set
				{
					 _dtFinDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtFinDate"));
				}
			}						
							
			private String _Type; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String Type 
			{
				get { return _Type;}
				set
				{
					 _Type = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("Type"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbSellDayCheckLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnCheckSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnCheckSerialNo 
			{
				get { return _cnnCheckSerialNo;}
				set
				{
					 _cnnCheckSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCheckSerialNo"));
				}
			}						
							
			private String _cnvcCheckDeptID; 
							 			
			public String cnvcCheckDeptID 
			{
				get { return _cnvcCheckDeptID;}
				set
				{
					 _cnvcCheckDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCheckDeptID"));
				}
			}						
							
			private DateTime? _cndCheckDate; 
							 			
			public DateTime? cndCheckDate 
			{
				get { return _cndCheckDate;}
				set
				{
					 _cndCheckDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndCheckDate"));
				}
			}						
							
			private String _cnvcWeather; 
							 			
			public String cnvcWeather 
			{
				get { return _cnvcWeather;}
				set
				{
					 _cnvcWeather = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcWeather"));
				}
			}						
							
			private String _cnvcCheckOperID; 
							 			
			public String cnvcCheckOperID 
			{
				get { return _cnvcCheckOperID;}
				set
				{
					 _cnvcCheckOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCheckOperID"));
				}
			}						
							
			private String _cnvcManageOperID; 
							 			
			public String cnvcManageOperID 
			{
				get { return _cnvcManageOperID;}
				set
				{
					 _cnvcManageOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcManageOperID"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbStockMainLog : INotifyPropertyChanged							
		{
						
			private Int64 _cnnId; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 cnnId 
			{
				get { return _cnnId;}
				set
				{
					 _cnnId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnId"));
				}
			}						
							
			private Int64 _cnnMainId; 
							 			
			public Int64 cnnMainId 
			{
				get { return _cnnMainId;}
				set
				{
					 _cnnMainId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMainId"));
				}
			}						
							
			private String _cnvcSupplierCode; 
							 			
			public String cnvcSupplierCode 
			{
				get { return _cnvcSupplierCode;}
				set
				{
					 _cnvcSupplierCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcSupplierCode"));
				}
			}						
							
			private String _cnvcWhCode; 
							 			
			public String cnvcWhCode 
			{
				get { return _cnvcWhCode;}
				set
				{
					 _cnvcWhCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcWhCode"));
				}
			}						
							
			private String _cnvcDeptId; 
							 			
			public String cnvcDeptId 
			{
				get { return _cnvcDeptId;}
				set
				{
					 _cnvcDeptId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptId"));
				}
			}						
							
			private Int32 _cnnOperType; 
							 			
			public Int32 cnnOperType 
			{
				get { return _cnnOperType;}
				set
				{
					 _cnnOperType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOperType"));
				}
			}						
							
			private Int64 _cnnSource; 
							 			
			public Int64 cnnSource 
			{
				get { return _cnnSource;}
				set
				{
					 _cnnSource = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSource"));
				}
			}						
							
			private DateTime _cndCreateDate; 
							 			
			public DateTime cndCreateDate 
			{
				get { return _cndCreateDate;}
				set
				{
					 _cndCreateDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndCreateDate"));
				}
			}						
							
			private String _cnvcCreaterId; 
							 			
			public String cnvcCreaterId 
			{
				get { return _cnvcCreaterId;}
				set
				{
					 _cnvcCreaterId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCreaterId"));
				}
			}						
							
			private String _cnvcCreaterName; 
							 			
			public String cnvcCreaterName 
			{
				get { return _cnvcCreaterName;}
				set
				{
					 _cnvcCreaterName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCreaterName"));
				}
			}						
							
			private DateTime? _cndModifyDate; 
							 			
			public DateTime? cndModifyDate 
			{
				get { return _cndModifyDate;}
				set
				{
					 _cndModifyDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndModifyDate"));
				}
			}						
							
			private String _cnvcModifier; 
							 			
			public String cnvcModifier 
			{
				get { return _cnvcModifier;}
				set
				{
					 _cnvcModifier = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcModifier"));
				}
			}						
							
			private String _cnvcModifierName; 
							 			
			public String cnvcModifierName 
			{
				get { return _cnvcModifierName;}
				set
				{
					 _cnvcModifierName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcModifierName"));
				}
			}						
							
			private DateTime? _cndCheckDate; 
							 			
			public DateTime? cndCheckDate 
			{
				get { return _cndCheckDate;}
				set
				{
					 _cndCheckDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndCheckDate"));
				}
			}						
							
			private String _cnvcCheckerId; 
							 			
			public String cnvcCheckerId 
			{
				get { return _cnvcCheckerId;}
				set
				{
					 _cnvcCheckerId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCheckerId"));
				}
			}						
							
			private String _cnvcCheckerName; 
							 			
			public String cnvcCheckerName 
			{
				get { return _cnvcCheckerName;}
				set
				{
					 _cnvcCheckerName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCheckerName"));
				}
			}						
							
			private DateTime _cndBusinessDate; 
							 			
			public DateTime cndBusinessDate 
			{
				get { return _cndBusinessDate;}
				set
				{
					 _cndBusinessDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndBusinessDate"));
				}
			}						
							
			private Int32 _cnnYear; 
							 			
			public Int32 cnnYear 
			{
				get { return _cnnYear;}
				set
				{
					 _cnnYear = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnYear"));
				}
			}						
							
			private Int32 _cnnMonth; 
							 			
			public Int32 cnnMonth 
			{
				get { return _cnnMonth;}
				set
				{
					 _cnnMonth = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMonth"));
				}
			}						
							
			private Int32 _cnnStatus; 
							 			
			public Int32 cnnStatus 
			{
				get { return _cnnStatus;}
				set
				{
					 _cnnStatus = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnStatus"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
							
			private Int32 _cnnDirection; 
							 			
			public Int32 cnnDirection 
			{
				get { return _cnnDirection;}
				set
				{
					 _cnnDirection = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnDirection"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbMaterialEnter : INotifyPropertyChanged							
		{
						
			private Decimal _cnnSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnSerialNo 
			{
				get { return _cnnSerialNo;}
				set
				{
					 _cnnSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSerialNo"));
				}
			}						
							
			private String _cnvcBatchNo; 
							 			
			public String cnvcBatchNo 
			{
				get { return _cnvcBatchNo;}
				set
				{
					 _cnvcBatchNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcBatchNo"));
				}
			}						
							
			private Decimal _cnnMaterialCode; 
							 			
			public Decimal cnnMaterialCode 
			{
				get { return _cnnMaterialCode;}
				set
				{
					 _cnnMaterialCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMaterialCode"));
				}
			}						
							
			private String _cnvcMaterialName; 
							 			
			public String cnvcMaterialName 
			{
				get { return _cnvcMaterialName;}
				set
				{
					 _cnvcMaterialName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMaterialName"));
				}
			}						
							
			private String _cnvcStandardUnit; 
							 			
			public String cnvcStandardUnit 
			{
				get { return _cnvcStandardUnit;}
				set
				{
					 _cnvcStandardUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcStandardUnit"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnPrice; 
							 			
			public Decimal? cnnPrice 
			{
				get { return _cnnPrice;}
				set
				{
					 _cnnPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPrice"));
				}
			}						
							
			private String _cnvcProviderName; 
							 			
			public String cnvcProviderName 
			{
				get { return _cnvcProviderName;}
				set
				{
					 _cnvcProviderName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProviderName"));
				}
			}						
							
			private String _cnvcMaterialType; 
							 			
			public String cnvcMaterialType 
			{
				get { return _cnvcMaterialType;}
				set
				{
					 _cnvcMaterialType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMaterialType"));
				}
			}						
							
			private Decimal? _cnnLastCount; 
							 			
			public Decimal? cnnLastCount 
			{
				get { return _cnnLastCount;}
				set
				{
					 _cnnLastCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnLastCount"));
				}
			}						
							
			private Decimal? _cnnEnterCount; 
							 			
			public Decimal? cnnEnterCount 
			{
				get { return _cnnEnterCount;}
				set
				{
					 _cnnEnterCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnEnterCount"));
				}
			}						
							
			private Decimal? _cnnCount; 
							 			
			public Decimal? cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private String _cnvcOperType; 
							 			
			public String cnvcOperType 
			{
				get { return _cnvcOperType;}
				set
				{
					 _cnvcOperType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperType"));
				}
			}						
							
			private Decimal? _cnnLinkSerialNo; 
							 			
			public Decimal? cnnLinkSerialNo 
			{
				get { return _cnnLinkSerialNo;}
				set
				{
					 _cnnLinkSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnLinkSerialNo"));
				}
			}						
							
			private DateTime? _cndEnterDate; 
							 			
			public DateTime? cndEnterDate 
			{
				get { return _cndEnterDate;}
				set
				{
					 _cndEnterDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndEnterDate"));
				}
			}						
							
			private String _cnvcDeptID; 
							 			
			public String cnvcDeptID 
			{
				get { return _cnvcDeptID;}
				set
				{
					 _cnvcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private String _cnvcOperName; 
							 			
			public String cnvcOperName 
			{
				get { return _cnvcOperName;}
				set
				{
					 _cnvcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperName"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbEmpSign : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private String _vcEmpName; 
							 			
			public String vcEmpName 
			{
				get { return _vcEmpName;}
				set
				{
					 _vcEmpName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcEmpName"));
				}
			}						
							
			private DateTime? _dtSignDate; 
							 			
			public DateTime? dtSignDate 
			{
				get { return _dtSignDate;}
				set
				{
					 _dtSignDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtSignDate"));
				}
			}						
							
			private String _vcClass; 
							 			
			public String vcClass 
			{
				get { return _vcClass;}
				set
				{
					 _vcClass = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcClass"));
				}
			}						
							
			private String _vcSignFlag; 
							 			
			public String vcSignFlag 
			{
				get { return _vcSignFlag;}
				set
				{
					 _vcSignFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcSignFlag"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private String _vcDeptID; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbFillFee : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private Int64? _iAssID; 
							 			
			public Int64? iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private Decimal? _nFillFee; 
							 			
			public Decimal? nFillFee 
			{
				get { return _nFillFee;}
				set
				{
					 _nFillFee = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFillFee"));
				}
			}						
							
			private Decimal? _nFillProm; 
							 			
			public Decimal? nFillProm 
			{
				get { return _nFillProm;}
				set
				{
					 _nFillProm = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFillProm"));
				}
			}						
							
			private Decimal? _nFeeLast; 
							 			
			public Decimal? nFeeLast 
			{
				get { return _nFeeLast;}
				set
				{
					 _nFeeLast = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFeeLast"));
				}
			}						
							
			private Decimal? _nFeeCur; 
							 			
			public Decimal? nFeeCur 
			{
				get { return _nFeeCur;}
				set
				{
					 _nFeeCur = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFeeCur"));
				}
			}						
							
			private DateTime? _dtFillDate; 
							 			
			public DateTime? dtFillDate 
			{
				get { return _dtFillDate;}
				set
				{
					 _dtFillDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtFillDate"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbMaterialOut : INotifyPropertyChanged							
		{
						
			private Decimal _cnnSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnSerialNo 
			{
				get { return _cnnSerialNo;}
				set
				{
					 _cnnSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSerialNo"));
				}
			}						
							
			private String _cnvcBatchNo; 
							 			
			public String cnvcBatchNo 
			{
				get { return _cnvcBatchNo;}
				set
				{
					 _cnvcBatchNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcBatchNo"));
				}
			}						
							
			private Decimal _cnnMaterialCode; 
							 			
			public Decimal cnnMaterialCode 
			{
				get { return _cnnMaterialCode;}
				set
				{
					 _cnnMaterialCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMaterialCode"));
				}
			}						
							
			private String _cnvcMaterialName; 
							 			
			public String cnvcMaterialName 
			{
				get { return _cnvcMaterialName;}
				set
				{
					 _cnvcMaterialName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMaterialName"));
				}
			}						
							
			private String _cnvcStandardUnit; 
							 			
			public String cnvcStandardUnit 
			{
				get { return _cnvcStandardUnit;}
				set
				{
					 _cnvcStandardUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcStandardUnit"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnPrice; 
							 			
			public Decimal? cnnPrice 
			{
				get { return _cnnPrice;}
				set
				{
					 _cnnPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPrice"));
				}
			}						
							
			private String _cnvcProviderName; 
							 			
			public String cnvcProviderName 
			{
				get { return _cnvcProviderName;}
				set
				{
					 _cnvcProviderName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProviderName"));
				}
			}						
							
			private String _cnvcMaterialType; 
							 			
			public String cnvcMaterialType 
			{
				get { return _cnvcMaterialType;}
				set
				{
					 _cnvcMaterialType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMaterialType"));
				}
			}						
							
			private Decimal? _cnnLastCount; 
							 			
			public Decimal? cnnLastCount 
			{
				get { return _cnnLastCount;}
				set
				{
					 _cnnLastCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnLastCount"));
				}
			}						
							
			private Decimal? _cnnOutCount; 
							 			
			public Decimal? cnnOutCount 
			{
				get { return _cnnOutCount;}
				set
				{
					 _cnnOutCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOutCount"));
				}
			}						
							
			private Decimal? _cnnCount; 
							 			
			public Decimal? cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private String _cnvcOperType; 
							 			
			public String cnvcOperType 
			{
				get { return _cnvcOperType;}
				set
				{
					 _cnvcOperType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperType"));
				}
			}						
							
			private Decimal? _cnnLinkSerialNo; 
							 			
			public Decimal? cnnLinkSerialNo 
			{
				get { return _cnnLinkSerialNo;}
				set
				{
					 _cnnLinkSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnLinkSerialNo"));
				}
			}						
							
			private DateTime? _cndOutDate; 
							 			
			public DateTime? cndOutDate 
			{
				get { return _cndOutDate;}
				set
				{
					 _cndOutDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOutDate"));
				}
			}						
							
			private String _cnvcDeptID; 
							 			
			public String cnvcDeptID 
			{
				get { return _cnvcDeptID;}
				set
				{
					 _cnvcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private String _cnvcOperName; 
							 			
			public String cnvcOperName 
			{
				get { return _cnvcOperName;}
				set
				{
					 _cnvcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperName"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbEmployee : INotifyPropertyChanged							
		{
						
			private String _vcCardID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private String _vcEmpName; 
							 			
			public String vcEmpName 
			{
				get { return _vcEmpName;}
				set
				{
					 _vcEmpName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcEmpName"));
				}
			}						
							
			private String _vcSex; 
							 			
			public String vcSex 
			{
				get { return _vcSex;}
				set
				{
					 _vcSex = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcSex"));
				}
			}						
							
			private String _vcEmpNbr; 
							 			
			public String vcEmpNbr 
			{
				get { return _vcEmpNbr;}
				set
				{
					 _vcEmpNbr = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcEmpNbr"));
				}
			}						
							
			private DateTime? _dtInDate; 
							 			
			public DateTime? dtInDate 
			{
				get { return _dtInDate;}
				set
				{
					 _dtInDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtInDate"));
				}
			}						
							
			private String _vcDegree; 
							 			
			public String vcDegree 
			{
				get { return _vcDegree;}
				set
				{
					 _vcDegree = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDegree"));
				}
			}						
							
			private String _vcLinkPhone; 
							 			
			public String vcLinkPhone 
			{
				get { return _vcLinkPhone;}
				set
				{
					 _vcLinkPhone = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcLinkPhone"));
				}
			}						
							
			private String _vcAddress; 
							 			
			public String vcAddress 
			{
				get { return _vcAddress;}
				set
				{
					 _vcAddress = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAddress"));
				}
			}						
							
			private String _vcPwd; 
							 			
			public String vcPwd 
			{
				get { return _vcPwd;}
				set
				{
					 _vcPwd = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcPwd"));
				}
			}						
							
			private String _vcOfficer; 
							 			
			public String vcOfficer 
			{
				get { return _vcOfficer;}
				set
				{
					 _vcOfficer = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOfficer"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
							
			private String _vcFlag; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcFlag 
			{
				get { return _vcFlag;}
				set
				{
					 _vcFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcFlag"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private DateTime? _dtOperDate; 
							 			
			public DateTime? dtOperDate 
			{
				get { return _dtOperDate;}
				set
				{
					 _dtOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtOperDate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbMaterialPara : INotifyPropertyChanged							
		{
						
			private String _cnvcBatchNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcBatchNo 
			{
				get { return _cnvcBatchNo;}
				set
				{
					 _cnvcBatchNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcBatchNo"));
				}
			}						
							
			private Decimal _cnnMaterialCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public Decimal cnnMaterialCode 
			{
				get { return _cnnMaterialCode;}
				set
				{
					 _cnnMaterialCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMaterialCode"));
				}
			}						
							
			private String _cnvcMaterialName; 
							 			
			public String cnvcMaterialName 
			{
				get { return _cnvcMaterialName;}
				set
				{
					 _cnvcMaterialName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMaterialName"));
				}
			}						
							
			private String _cnvcStandardUnit; 
							 			
			public String cnvcStandardUnit 
			{
				get { return _cnvcStandardUnit;}
				set
				{
					 _cnvcStandardUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcStandardUnit"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnPrice; 
							 			
			public Decimal? cnnPrice 
			{
				get { return _cnnPrice;}
				set
				{
					 _cnnPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPrice"));
				}
			}						
							
			private String _cnvcProviderName; 
							 			
			public String cnvcProviderName 
			{
				get { return _cnvcProviderName;}
				set
				{
					 _cnvcProviderName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProviderName"));
				}
			}						
							
			private String _cnvcMaterialType; 
							 			
			public String cnvcMaterialType 
			{
				get { return _cnvcMaterialType;}
				set
				{
					 _cnvcMaterialType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMaterialType"));
				}
			}						
							
			private Decimal? _cnnAlarmCount; 
							 			
			public Decimal? cnnAlarmCount 
			{
				get { return _cnnAlarmCount;}
				set
				{
					 _cnnAlarmCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAlarmCount"));
				}
			}						
							
			private Decimal? _cnnCurCount; 
							 			
			public Decimal? cnnCurCount 
			{
				get { return _cnnCurCount;}
				set
				{
					 _cnnCurCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCurCount"));
				}
			}						
							
			private String _cnvcFlag; 
							 			
			public String cnvcFlag 
			{
				get { return _cnvcFlag;}
				set
				{
					 _cnvcFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcFlag"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbMaterial : INotifyPropertyChanged							
		{
						
			private String _cnvcMaterialCode; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcMaterialCode 
			{
				get { return _cnvcMaterialCode;}
				set
				{
					 _cnvcMaterialCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMaterialCode"));
				}
			}						
							
			private String _cnvcMaterialName; 
							 			
			public String cnvcMaterialName 
			{
				get { return _cnvcMaterialName;}
				set
				{
					 _cnvcMaterialName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMaterialName"));
				}
			}						
							
			private String _cnvcLeastUnit; 
							 			
			public String cnvcLeastUnit 
			{
				get { return _cnvcLeastUnit;}
				set
				{
					 _cnvcLeastUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcLeastUnit"));
				}
			}						
							
			private Decimal? _cnnConversion; 
							 			
			public Decimal? cnnConversion 
			{
				get { return _cnnConversion;}
				set
				{
					 _cnnConversion = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnConversion"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private String _cnvcStandardUnit; 
							 			
			public String cnvcStandardUnit 
			{
				get { return _cnvcStandardUnit;}
				set
				{
					 _cnvcStandardUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcStandardUnit"));
				}
			}						
							
			private Decimal? _cnnStatdardCount; 
							 			
			public Decimal? cnnStatdardCount 
			{
				get { return _cnnStatdardCount;}
				set
				{
					 _cnnStatdardCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnStatdardCount"));
				}
			}						
							
			private Decimal? _cnnPrice; 
							 			
			public Decimal? cnnPrice 
			{
				get { return _cnnPrice;}
				set
				{
					 _cnnPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPrice"));
				}
			}						
							
			private String _cnvcProductType; 
							 			
			public String cnvcProductType 
			{
				get { return _cnvcProductType;}
				set
				{
					 _cnvcProductType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductType"));
				}
			}						
							
			private String _cnvcProductClass; 
							 			
			public String cnvcProductClass 
			{
				get { return _cnvcProductClass;}
				set
				{
					 _cnvcProductClass = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductClass"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbDosage : INotifyPropertyChanged							
		{
						
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductType; 
							 			
			public String cnvcProductType 
			{
				get { return _cnvcProductType;}
				set
				{
					 _cnvcProductType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductType"));
				}
			}						
							
			private String _cnvcCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcCode 
			{
				get { return _cnvcCode;}
				set
				{
					 _cnvcCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCode"));
				}
			}						
							
			private String _cnvcName; 
							 			
			public String cnvcName 
			{
				get { return _cnvcName;}
				set
				{
					 _cnvcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcName"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnCount; 
							 			
			public Decimal? cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private Decimal? _cnnPrice; 
							 			
			public Decimal? cnnPrice 
			{
				get { return _cnnPrice;}
				set
				{
					 _cnnPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPrice"));
				}
			}						
							
			private Decimal? _cnnSum; 
							 			
			public Decimal? cnnSum 
			{
				get { return _cnnSum;}
				set
				{
					 _cnnSum = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSum"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbMacAddress : INotifyPropertyChanged							
		{
						
			private String _vcMacAddress; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcMacAddress 
			{
				get { return _vcMacAddress;}
				set
				{
					 _vcMacAddress = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcMacAddress"));
				}
			}						
							
			private String _vcName; 
							 			
			public String vcName 
			{
				get { return _vcName;}
				set
				{
					 _vcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcName"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbProductClass : INotifyPropertyChanged							
		{
						
			private String _cnvcProductType; 
							 			
			public String cnvcProductType 
			{
				get { return _cnvcProductType;}
				set
				{
					 _cnvcProductType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductType"));
				}
			}						
							
			private String _cnvcProductClassName; 
							 			
			public String cnvcProductClassName 
			{
				get { return _cnvcProductClassName;}
				set
				{
					 _cnvcProductClassName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductClassName"));
				}
			}						
							
			private String _cnvcProductClassCode; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcProductClassCode 
			{
				get { return _cnvcProductClassCode;}
				set
				{
					 _cnvcProductClassCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductClassCode"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
							
			private Int32 _cnnDays; 
							 			
			public Int32 cnnDays 
			{
				get { return _cnnDays;}
				set
				{
					 _cnnDays = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnDays"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbConsItemOther : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private String _vcGoodsID; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcGoodsID 
			{
				get { return _vcGoodsID;}
				set
				{
					 _vcGoodsID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcGoodsID"));
				}
			}						
							
			private Int64? _iAssID; 
							 			
			public Int64? iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private Decimal? _nPrice; 
							 			
			public Decimal? nPrice 
			{
				get { return _nPrice;}
				set
				{
					 _nPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nPrice"));
				}
			}						
							
			private Int32? _iCount; 
							 			
			public Int32? iCount 
			{
				get { return _iCount;}
				set
				{
					 _iCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iCount"));
				}
			}						
							
			private Decimal? _nTRate; 
							 			
			public Decimal? nTRate 
			{
				get { return _nTRate;}
				set
				{
					 _nTRate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nTRate"));
				}
			}						
							
			private Decimal? _nFee; 
							 			
			public Decimal? nFee 
			{
				get { return _nFee;}
				set
				{
					 _nFee = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFee"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private String _cFlag; 
							 			
			public String cFlag 
			{
				get { return _cFlag;}
				set
				{
					 _cFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cFlag"));
				}
			}						
							
			private DateTime? _dtConsDate; 
							 			
			public DateTime? dtConsDate 
			{
				get { return _dtConsDate;}
				set
				{
					 _dtConsDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtConsDate"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private String _vcDeptID; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbGroupGoods : INotifyPropertyChanged							
		{
						
			private String _cnvcProductType; 
							 			
			public String cnvcProductType 
			{
				get { return _cnvcProductType;}
				set
				{
					 _cnvcProductType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductType"));
				}
			}						
							
			private String _cnvcProductClass; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcProductClass 
			{
				get { return _cnvcProductClass;}
				set
				{
					 _cnvcProductClass = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductClass"));
				}
			}						
							
			private String _cnvcGroupCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcGroupCode 
			{
				get { return _cnvcGroupCode;}
				set
				{
					 _cnvcGroupCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcGroupCode"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbSignList : INotifyPropertyChanged							
		{
						
			private String _vcSignDate; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcSignDate 
			{
				get { return _vcSignDate;}
				set
				{
					 _vcSignDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcSignDate"));
				}
			}						
							
			private String _vcCardID; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private String _vcClass; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String vcClass 
			{
				get { return _vcClass;}
				set
				{
					 _vcClass = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcClass"));
				}
			}						
							
			private String _vcEmpName; 
							 			
			public String vcEmpName 
			{
				get { return _vcEmpName;}
				set
				{
					 _vcEmpName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcEmpName"));
				}
			}						
							
			private String _vcDept; 
							 			
			public String vcDept 
			{
				get { return _vcDept;}
				set
				{
					 _vcDept = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDept"));
				}
			}						
							
			private String _vcOfficer; 
							 			
			public String vcOfficer 
			{
				get { return _vcOfficer;}
				set
				{
					 _vcOfficer = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOfficer"));
				}
			}						
							
			private DateTime? _dtSignIn; 
							 			
			public DateTime? dtSignIn 
			{
				get { return _dtSignIn;}
				set
				{
					 _dtSignIn = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtSignIn"));
				}
			}						
							
			private DateTime? _dtSignOut; 
							 			
			public DateTime? dtSignOut 
			{
				get { return _dtSignOut;}
				set
				{
					 _dtSignOut = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtSignOut"));
				}
			}						
							
			private String _vcSignState; 
							 			
			public String vcSignState 
			{
				get { return _vcSignState;}
				set
				{
					 _vcSignState = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcSignState"));
				}
			}						
							
			private String _vcSignResult; 
							 			
			public String vcSignResult 
			{
				get { return _vcSignResult;}
				set
				{
					 _vcSignResult = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcSignResult"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbBillOther : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private Int64? _iAssID; 
							 			
			public Int64? iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private Decimal? _nTRate; 
							 			
			public Decimal? nTRate 
			{
				get { return _nTRate;}
				set
				{
					 _nTRate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nTRate"));
				}
			}						
							
			private Decimal? _nFee; 
							 			
			public Decimal? nFee 
			{
				get { return _nFee;}
				set
				{
					 _nFee = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFee"));
				}
			}						
							
			private Decimal? _nPay; 
							 			
			public Decimal? nPay 
			{
				get { return _nPay;}
				set
				{
					 _nPay = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nPay"));
				}
			}						
							
			private Decimal? _nBalance; 
							 			
			public Decimal? nBalance 
			{
				get { return _nBalance;}
				set
				{
					 _nBalance = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nBalance"));
				}
			}						
							
			private Int32? _iIgValue; 
							 			
			public Int32? iIgValue 
			{
				get { return _iIgValue;}
				set
				{
					 _iIgValue = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgValue"));
				}
			}						
							
			private String _vcConsType; 
							 			
			public String vcConsType 
			{
				get { return _vcConsType;}
				set
				{
					 _vcConsType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcConsType"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private DateTime? _dtConsDate; 
							 			
			public DateTime? dtConsDate 
			{
				get { return _dtConsDate;}
				set
				{
					 _dtConsDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtConsDate"));
				}
			}						
							
			private String _vcDeptID; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbIntegralLogOther : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private Int64 _iAssID; 
							 			
			public Int64 iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private String _vcIgType; 
							 			
			public String vcIgType 
			{
				get { return _vcIgType;}
				set
				{
					 _vcIgType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcIgType"));
				}
			}						
							
			private Int32? _iIgLast; 
							 			
			public Int32? iIgLast 
			{
				get { return _iIgLast;}
				set
				{
					 _iIgLast = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgLast"));
				}
			}						
							
			private Int32? _iIgGet; 
							 			
			public Int32? iIgGet 
			{
				get { return _iIgGet;}
				set
				{
					 _iIgGet = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgGet"));
				}
			}						
							
			private Int32? _iIgArrival; 
							 			
			public Int32? iIgArrival 
			{
				get { return _iIgArrival;}
				set
				{
					 _iIgArrival = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgArrival"));
				}
			}						
							
			private Int64? _iLinkCons; 
							 			
			public Int64? iLinkCons 
			{
				get { return _iLinkCons;}
				set
				{
					 _iLinkCons = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iLinkCons"));
				}
			}						
							
			private DateTime? _dtIgDate; 
							 			
			public DateTime? dtIgDate 
			{
				get { return _dtIgDate;}
				set
				{
					 _dtIgDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtIgDate"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private String _vcDeptID; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbFillFeeOther : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private Int64? _iAssID; 
							 			
			public Int64? iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private Decimal? _nFillFee; 
							 			
			public Decimal? nFillFee 
			{
				get { return _nFillFee;}
				set
				{
					 _nFillFee = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFillFee"));
				}
			}						
							
			private Decimal? _nFillProm; 
							 			
			public Decimal? nFillProm 
			{
				get { return _nFillProm;}
				set
				{
					 _nFillProm = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFillProm"));
				}
			}						
							
			private Decimal? _nFeeLast; 
							 			
			public Decimal? nFeeLast 
			{
				get { return _nFeeLast;}
				set
				{
					 _nFeeLast = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFeeLast"));
				}
			}						
							
			private Decimal? _nFeeCur; 
							 			
			public Decimal? nFeeCur 
			{
				get { return _nFeeCur;}
				set
				{
					 _nFeeCur = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFeeCur"));
				}
			}						
							
			private DateTime? _dtFillDate; 
							 			
			public DateTime? dtFillDate 
			{
				get { return _dtFillDate;}
				set
				{
					 _dtFillDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtFillDate"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private String _vcDeptID; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbBusiLogOther : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private Int64? _iAssID; 
							 			
			public Int64? iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private String _vcOperType; 
							 			
			public String vcOperType 
			{
				get { return _vcOperType;}
				set
				{
					 _vcOperType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperType"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private DateTime? _dtOperDate; 
							 			
			public DateTime? dtOperDate 
			{
				get { return _dtOperDate;}
				set
				{
					 _dtOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtOperDate"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private String _vcDeptID; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbInventory : INotifyPropertyChanged							
		{
						
			private Boolean _cnbProductBill; 
							 			
			public Boolean cnbProductBill 
			{
				get { return _cnbProductBill;}
				set
				{
					 _cnbProductBill = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnbProductBill"));
				}
			}						
							
			private String _cnvcInvCode; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcInvCode 
			{
				get { return _cnvcInvCode;}
				set
				{
					 _cnvcInvCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcInvCode"));
				}
			}						
							
			private String _cnvcInvName; 
							 			
			public String cnvcInvName 
			{
				get { return _cnvcInvName;}
				set
				{
					 _cnvcInvName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcInvName"));
				}
			}						
							
			private String _cnvcInvStd; 
							 			
			public String cnvcInvStd 
			{
				get { return _cnvcInvStd;}
				set
				{
					 _cnvcInvStd = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcInvStd"));
				}
			}						
							
			private String _cnvcInvCCode; 
							 			
			public String cnvcInvCCode 
			{
				get { return _cnvcInvCCode;}
				set
				{
					 _cnvcInvCCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcInvCCode"));
				}
			}						
							
			private Boolean _cnbSale; 
							 			
			public Boolean cnbSale 
			{
				get { return _cnbSale;}
				set
				{
					 _cnbSale = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnbSale"));
				}
			}						
							
			private Boolean _cnbPurchase; 
							 			
			public Boolean cnbPurchase 
			{
				get { return _cnbPurchase;}
				set
				{
					 _cnbPurchase = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnbPurchase"));
				}
			}						
							
			private Boolean _cnbSelf; 
							 			
			public Boolean cnbSelf 
			{
				get { return _cnbSelf;}
				set
				{
					 _cnbSelf = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnbSelf"));
				}
			}						
							
			private Boolean _cnbComsume; 
							 			
			public Boolean cnbComsume 
			{
				get { return _cnbComsume;}
				set
				{
					 _cnbComsume = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnbComsume"));
				}
			}						
							
			private Decimal? _cniInvCCost; 
							 			
			public Decimal? cniInvCCost 
			{
				get { return _cniInvCCost;}
				set
				{
					 _cniInvCCost = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cniInvCCost"));
				}
			}						
							
			private Decimal? _cniInvNCost; 
							 			
			public Decimal? cniInvNCost 
			{
				get { return _cniInvNCost;}
				set
				{
					 _cniInvNCost = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cniInvNCost"));
				}
			}						
							
			private Decimal? _cniSafeNum; 
							 			
			public Decimal? cniSafeNum 
			{
				get { return _cniSafeNum;}
				set
				{
					 _cniSafeNum = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cniSafeNum"));
				}
			}						
							
			private Decimal? _cniLowSum; 
							 			
			public Decimal? cniLowSum 
			{
				get { return _cniLowSum;}
				set
				{
					 _cniLowSum = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cniLowSum"));
				}
			}						
							
			private DateTime? _cndSDate; 
							 			
			public DateTime? cndSDate 
			{
				get { return _cndSDate;}
				set
				{
					 _cndSDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndSDate"));
				}
			}						
							
			private DateTime? _cndEDate; 
							 			
			public DateTime? cndEDate 
			{
				get { return _cndEDate;}
				set
				{
					 _cndEDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndEDate"));
				}
			}						
							
			private String _cnvcCreatePerson; 
							 			
			public String cnvcCreatePerson 
			{
				get { return _cnvcCreatePerson;}
				set
				{
					 _cnvcCreatePerson = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCreatePerson"));
				}
			}						
							
			private String _cnvcModifyPerson; 
							 			
			public String cnvcModifyPerson 
			{
				get { return _cnvcModifyPerson;}
				set
				{
					 _cnvcModifyPerson = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcModifyPerson"));
				}
			}						
							
			private DateTime? _cndModifyDate; 
							 			
			public DateTime? cndModifyDate 
			{
				get { return _cndModifyDate;}
				set
				{
					 _cndModifyDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndModifyDate"));
				}
			}						
							
			private String _cnvcValueType; 
							 			
			public String cnvcValueType 
			{
				get { return _cnvcValueType;}
				set
				{
					 _cnvcValueType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcValueType"));
				}
			}						
							
			private String _cnvcGroupCode; 
							 			
			public String cnvcGroupCode 
			{
				get { return _cnvcGroupCode;}
				set
				{
					 _cnvcGroupCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcGroupCode"));
				}
			}						
							
			private String _cnvcComUnitCode; 
							 			
			public String cnvcComUnitCode 
			{
				get { return _cnvcComUnitCode;}
				set
				{
					 _cnvcComUnitCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComUnitCode"));
				}
			}						
							
			private String _cnvcSAComUnitCode; 
							 			
			public String cnvcSAComUnitCode 
			{
				get { return _cnvcSAComUnitCode;}
				set
				{
					 _cnvcSAComUnitCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcSAComUnitCode"));
				}
			}						
							
			private String _cnvcPUComUnitCode; 
							 			
			public String cnvcPUComUnitCode 
			{
				get { return _cnvcPUComUnitCode;}
				set
				{
					 _cnvcPUComUnitCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcPUComUnitCode"));
				}
			}						
							
			private String _cnvcSTComUnitCode; 
							 			
			public String cnvcSTComUnitCode 
			{
				get { return _cnvcSTComUnitCode;}
				set
				{
					 _cnvcSTComUnitCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcSTComUnitCode"));
				}
			}						
							
			private String _cnvcProduceUnitCode; 
							 			
			public String cnvcProduceUnitCode 
			{
				get { return _cnvcProduceUnitCode;}
				set
				{
					 _cnvcProduceUnitCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProduceUnitCode"));
				}
			}						
							
			private Decimal? _cnfRetailPrice; 
							 			
			public Decimal? cnfRetailPrice 
			{
				get { return _cnfRetailPrice;}
				set
				{
					 _cnfRetailPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnfRetailPrice"));
				}
			}						
							
			private String _cnvcShopUnitCode; 
							 			
			public String cnvcShopUnitCode 
			{
				get { return _cnvcShopUnitCode;}
				set
				{
					 _cnvcShopUnitCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcShopUnitCode"));
				}
			}						
							
			private String _cnvcFeel; 
							 			
			public String cnvcFeel 
			{
				get { return _cnvcFeel;}
				set
				{
					 _cnvcFeel = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcFeel"));
				}
			}						
							
			private String _cnvcOrganise; 
							 			
			public String cnvcOrganise 
			{
				get { return _cnvcOrganise;}
				set
				{
					 _cnvcOrganise = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOrganise"));
				}
			}						
							
			private String _cnvcColor; 
							 			
			public String cnvcColor 
			{
				get { return _cnvcColor;}
				set
				{
					 _cnvcColor = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcColor"));
				}
			}						
							
			private String _cnvcTaste; 
							 			
			public String cnvcTaste 
			{
				get { return _cnvcTaste;}
				set
				{
					 _cnvcTaste = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcTaste"));
				}
			}						
							
			private Int32 _cnnExpire; 
							 			
			public Int32 cnnExpire 
			{
				get { return _cnnExpire;}
				set
				{
					 _cnnExpire = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnExpire"));
				}
			}						
							
			private Int32 _cnnDue; 
							 			
			public Int32 cnnDue 
			{
				get { return _cnnDue;}
				set
				{
					 _cnnDue = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnDue"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbMakeDetail : INotifyPropertyChanged							
		{
						
			private Decimal _cnnMakeSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnMakeSerialNo 
			{
				get { return _cnnMakeSerialNo;}
				set
				{
					 _cnnMakeSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMakeSerialNo"));
				}
			}						
							
			private String _cnvcCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcCode 
			{
				get { return _cnvcCode;}
				set
				{
					 _cnvcCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCode"));
				}
			}						
							
			private String _cnvcName; 
							 			
			public String cnvcName 
			{
				get { return _cnvcName;}
				set
				{
					 _cnvcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcName"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnCount; 
							 			
			public Decimal? cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbGroupMake : INotifyPropertyChanged							
		{
						
			private String _cnvcProductType; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcProductType 
			{
				get { return _cnvcProductType;}
				set
				{
					 _cnvcProductType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductType"));
				}
			}						
							
			private String _cnvcGroupCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcGroupCode 
			{
				get { return _cnvcGroupCode;}
				set
				{
					 _cnvcGroupCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcGroupCode"));
				}
			}						
							
			private String _cnvcMakeName; 
							 			
			public String cnvcMakeName 
			{
				get { return _cnvcMakeName;}
				set
				{
					 _cnvcMakeName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMakeName"));
				}
			}						
							
			private String _cnvcMakeType; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String cnvcMakeType 
			{
				get { return _cnvcMakeType;}
				set
				{
					 _cnvcMakeType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMakeType"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbComputationGroup : INotifyPropertyChanged							
		{
						
			private String _cnvcGroupCode; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcGroupCode 
			{
				get { return _cnvcGroupCode;}
				set
				{
					 _cnvcGroupCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcGroupCode"));
				}
			}						
							
			private String _cnvcGroupName; 
							 			
			public String cnvcGroupName 
			{
				get { return _cnvcGroupName;}
				set
				{
					 _cnvcGroupName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcGroupName"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbComputationUnit : INotifyPropertyChanged							
		{
						
			private String _cnvcComunitCode; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcComunitCode 
			{
				get { return _cnvcComunitCode;}
				set
				{
					 _cnvcComunitCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComunitCode"));
				}
			}						
							
			private String _cnvcComUnitName; 
							 			
			public String cnvcComUnitName 
			{
				get { return _cnvcComUnitName;}
				set
				{
					 _cnvcComUnitName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComUnitName"));
				}
			}						
							
			private String _cnvcGroupCode; 
							 			
			public String cnvcGroupCode 
			{
				get { return _cnvcGroupCode;}
				set
				{
					 _cnvcGroupCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcGroupCode"));
				}
			}						
							
			private Boolean _cnbMainUnit; 
							 			
			public Boolean cnbMainUnit 
			{
				get { return _cnbMainUnit;}
				set
				{
					 _cnbMainUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnbMainUnit"));
				}
			}						
							
			private Decimal _cniChangRate; 
							 			
			public Decimal cniChangRate 
			{
				get { return _cniChangRate;}
				set
				{
					 _cniChangRate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cniChangRate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbRepAssDailyIGCharge : INotifyPropertyChanged							
		{
						
			private String _vcCardID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private String _vcDate; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcDate 
			{
				get { return _vcDate;}
				set
				{
					 _vcDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDate"));
				}
			}						
							
			private DateTime? _dtIgDate; 
							 			
			public DateTime? dtIgDate 
			{
				get { return _dtIgDate;}
				set
				{
					 _dtIgDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtIgDate"));
				}
			}						
							
			private DateTime? _dtFillDate; 
							 			
			public DateTime? dtFillDate 
			{
				get { return _dtFillDate;}
				set
				{
					 _dtFillDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtFillDate"));
				}
			}						
							
			private Decimal? _DailyIG; 
							 			
			public Decimal? DailyIG 
			{
				get { return _DailyIG;}
				set
				{
					 _DailyIG = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("DailyIG"));
				}
			}						
							
			private Decimal? _DailyCharge; 
							 			
			public Decimal? DailyCharge 
			{
				get { return _DailyCharge;}
				set
				{
					 _DailyCharge = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("DailyCharge"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbStockPlan : INotifyPropertyChanged							
		{
						
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private Decimal? _cnnPlanCount; 
							 			
			public Decimal? cnnPlanCount 
			{
				get { return _cnnPlanCount;}
				set
				{
					 _cnnPlanCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPlanCount"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private String _cnvcMonth; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcMonth 
			{
				get { return _cnvcMonth;}
				set
				{
					 _cnvcMonth = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMonth"));
				}
			}						
							
			private DateTime? _cndStartDate1; 
							 			
			public DateTime? cndStartDate1 
			{
				get { return _cndStartDate1;}
				set
				{
					 _cndStartDate1 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndStartDate1"));
				}
			}						
							
			private Decimal? _cnnCount1; 
							 			
			public Decimal? cnnCount1 
			{
				get { return _cnnCount1;}
				set
				{
					 _cnnCount1 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount1"));
				}
			}						
							
			private Decimal? _cnnSumFee1; 
							 			
			public Decimal? cnnSumFee1 
			{
				get { return _cnnSumFee1;}
				set
				{
					 _cnnSumFee1 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSumFee1"));
				}
			}						
							
			private DateTime? _cndStartDate2; 
							 			
			public DateTime? cndStartDate2 
			{
				get { return _cndStartDate2;}
				set
				{
					 _cndStartDate2 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndStartDate2"));
				}
			}						
							
			private Decimal? _cnnCount2; 
							 			
			public Decimal? cnnCount2 
			{
				get { return _cnnCount2;}
				set
				{
					 _cnnCount2 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount2"));
				}
			}						
							
			private Decimal? _cnnSumFee2; 
							 			
			public Decimal? cnnSumFee2 
			{
				get { return _cnnSumFee2;}
				set
				{
					 _cnnSumFee2 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSumFee2"));
				}
			}						
							
			private DateTime? _cndStartDate3; 
							 			
			public DateTime? cndStartDate3 
			{
				get { return _cndStartDate3;}
				set
				{
					 _cndStartDate3 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndStartDate3"));
				}
			}						
							
			private Decimal? _cnnCount3; 
							 			
			public Decimal? cnnCount3 
			{
				get { return _cnnCount3;}
				set
				{
					 _cnnCount3 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount3"));
				}
			}						
							
			private Decimal? _cnnSumFee3; 
							 			
			public Decimal? cnnSumFee3 
			{
				get { return _cnnSumFee3;}
				set
				{
					 _cnnSumFee3 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSumFee3"));
				}
			}						
							
			private DateTime? _cndStartDate4; 
							 			
			public DateTime? cndStartDate4 
			{
				get { return _cndStartDate4;}
				set
				{
					 _cndStartDate4 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndStartDate4"));
				}
			}						
							
			private Decimal? _cnnCount4; 
							 			
			public Decimal? cnnCount4 
			{
				get { return _cnnCount4;}
				set
				{
					 _cnnCount4 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount4"));
				}
			}						
							
			private Decimal? _cnnSumFee4; 
							 			
			public Decimal? cnnSumFee4 
			{
				get { return _cnnSumFee4;}
				set
				{
					 _cnnSumFee4 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSumFee4"));
				}
			}						
							
			private Decimal? _cnnSumFee; 
							 			
			public Decimal? cnnSumFee 
			{
				get { return _cnnSumFee;}
				set
				{
					 _cnnSumFee = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSumFee"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbStockPlanDetail : INotifyPropertyChanged							
		{
						
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private Decimal? _cnnPlanCount; 
							 			
			public Decimal? cnnPlanCount 
			{
				get { return _cnnPlanCount;}
				set
				{
					 _cnnPlanCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPlanCount"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private String _cnvcMonth; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcMonth 
			{
				get { return _cnvcMonth;}
				set
				{
					 _cnvcMonth = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMonth"));
				}
			}						
							
			private String _cnvcPlanDeptID; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String cnvcPlanDeptID 
			{
				get { return _cnvcPlanDeptID;}
				set
				{
					 _cnvcPlanDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcPlanDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbRepAssCount : INotifyPropertyChanged							
		{
						
			private String _vcDeptID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
							
			private String _vcDate; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcDate 
			{
				get { return _vcDate;}
				set
				{
					 _vcDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDate"));
				}
			}						
							
			private Int32? _NewAss; 
							 			
			public Int32? NewAss 
			{
				get { return _NewAss;}
				set
				{
					 _NewAss = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("NewAss"));
				}
			}						
							
			private Int32? _LoseAss; 
							 			
			public Int32? LoseAss 
			{
				get { return _LoseAss;}
				set
				{
					 _LoseAss = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("LoseAss"));
				}
			}						
							
			private Int32? _RelaseLoseAss; 
							 			
			public Int32? RelaseLoseAss 
			{
				get { return _RelaseLoseAss;}
				set
				{
					 _RelaseLoseAss = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("RelaseLoseAss"));
				}
			}						
							
			private Int32? _OnlyAss; 
							 			
			public Int32? OnlyAss 
			{
				get { return _OnlyAss;}
				set
				{
					 _OnlyAss = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("OnlyAss"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbProduceCheckLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnProduceSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnProduceSerialNo 
			{
				get { return _cnnProduceSerialNo;}
				set
				{
					 _cnnProduceSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnProduceSerialNo"));
				}
			}						
							
			private String _cnvcProduceDeptID; 
							 			
			public String cnvcProduceDeptID 
			{
				get { return _cnvcProduceDeptID;}
				set
				{
					 _cnvcProduceDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProduceDeptID"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private String _cnvcName; 
							 			
			public String cnvcName 
			{
				get { return _cnvcName;}
				set
				{
					 _cnvcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcName"));
				}
			}						
							
			private String _cnvcCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcCode 
			{
				get { return _cnvcCode;}
				set
				{
					 _cnvcCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCode"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnOrderCount; 
							 			
			public Decimal? cnnOrderCount 
			{
				get { return _cnnOrderCount;}
				set
				{
					 _cnnOrderCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOrderCount"));
				}
			}						
							
			private Decimal? _cnnAddCount; 
							 			
			public Decimal? cnnAddCount 
			{
				get { return _cnnAddCount;}
				set
				{
					 _cnnAddCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAddCount"));
				}
			}						
							
			private Decimal? _cnnReduceCount; 
							 			
			public Decimal? cnnReduceCount 
			{
				get { return _cnnReduceCount;}
				set
				{
					 _cnnReduceCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnReduceCount"));
				}
			}						
							
			private Decimal? _cnnProduceCount; 
							 			
			public Decimal? cnnProduceCount 
			{
				get { return _cnnProduceCount;}
				set
				{
					 _cnnProduceCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnProduceCount"));
				}
			}						
							
			private Decimal? _cnnCheckCount; 
							 			
			public Decimal? cnnCheckCount 
			{
				get { return _cnnCheckCount;}
				set
				{
					 _cnnCheckCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCheckCount"));
				}
			}						
							
			private Decimal _cnnAssignCount; 
							 			
			public Decimal cnnAssignCount 
			{
				get { return _cnnAssignCount;}
				set
				{
					 _cnnAssignCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAssignCount"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbRepAssFill : INotifyPropertyChanged							
		{
						
			private String _vcDeptID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
							
			private String _vcDate; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcDate 
			{
				get { return _vcDate;}
				set
				{
					 _vcDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDate"));
				}
			}						
							
			private Int32 _AssCount; 
							 			
			public Int32 AssCount 
			{
				get { return _AssCount;}
				set
				{
					 _AssCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("AssCount"));
				}
			}						
							
			private Decimal _FillFee; 
							 			
			public Decimal FillFee 
			{
				get { return _FillFee;}
				set
				{
					 _FillFee = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("FillFee"));
				}
			}						
							
			private Decimal _PromFee; 
							 			
			public Decimal PromFee 
			{
				get { return _PromFee;}
				set
				{
					 _PromFee = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("PromFee"));
				}
			}						
							
			private Int32 _FillCount; 
							 			
			public Int32 FillCount 
			{
				get { return _FillCount;}
				set
				{
					 _FillCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("FillCount"));
				}
			}						
							
			private String _vcAssBelongDept; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String vcAssBelongDept 
			{
				get { return _vcAssBelongDept;}
				set
				{
					 _vcAssBelongDept = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssBelongDept"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbBillHis : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private Int64? _iAssID; 
							 			
			public Int64? iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private Decimal? _nTRate; 
							 			
			public Decimal? nTRate 
			{
				get { return _nTRate;}
				set
				{
					 _nTRate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nTRate"));
				}
			}						
							
			private Decimal? _nFee; 
							 			
			public Decimal? nFee 
			{
				get { return _nFee;}
				set
				{
					 _nFee = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFee"));
				}
			}						
							
			private Decimal? _nPay; 
							 			
			public Decimal? nPay 
			{
				get { return _nPay;}
				set
				{
					 _nPay = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nPay"));
				}
			}						
							
			private Decimal? _nBalance; 
							 			
			public Decimal? nBalance 
			{
				get { return _nBalance;}
				set
				{
					 _nBalance = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nBalance"));
				}
			}						
							
			private Int32? _iIgValue; 
							 			
			public Int32? iIgValue 
			{
				get { return _iIgValue;}
				set
				{
					 _iIgValue = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgValue"));
				}
			}						
							
			private String _vcConsType; 
							 			
			public String vcConsType 
			{
				get { return _vcConsType;}
				set
				{
					 _vcConsType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcConsType"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private DateTime? _dtConsDate; 
							 			
			public DateTime? dtConsDate 
			{
				get { return _dtConsDate;}
				set
				{
					 _dtConsDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtConsDate"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbRepAssConsDaily : INotifyPropertyChanged							
		{
						
			private String _vcDeptID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
							
			private String _vcDate; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcDate 
			{
				get { return _vcDate;}
				set
				{
					 _vcDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDate"));
				}
			}						
							
			private String _vcAssType; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String vcAssType 
			{
				get { return _vcAssType;}
				set
				{
					 _vcAssType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssType"));
				}
			}						
							
			private Int32? _AssCount; 
							 			
			public Int32? AssCount 
			{
				get { return _AssCount;}
				set
				{
					 _AssCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("AssCount"));
				}
			}						
							
			private Decimal? _nFee; 
							 			
			public Decimal? nFee 
			{
				get { return _nFee;}
				set
				{
					 _nFee = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFee"));
				}
			}						
							
			private Int32? _iIgValue; 
							 			
			public Int32? iIgValue 
			{
				get { return _iIgValue;}
				set
				{
					 _iIgValue = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgValue"));
				}
			}						
							
			private Int32? _ConsTimes; 
							 			
			public Int32? ConsTimes 
			{
				get { return _ConsTimes;}
				set
				{
					 _ConsTimes = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("ConsTimes"));
				}
			}						
							
			private Int32? _GoodsCount; 
							 			
			public Int32? GoodsCount 
			{
				get { return _GoodsCount;}
				set
				{
					 _GoodsCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("GoodsCount"));
				}
			}						
							
			private String _vcAssBelongDept; 
						
			
			[Key]
			[Column(Order=3)]
			[Required()]									 			
			public String vcAssBelongDept 
			{
				get { return _vcAssBelongDept;}
				set
				{
					 _vcAssBelongDept = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssBelongDept"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbBusiLogHis : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private Int64? _iAssID; 
							 			
			public Int64? iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private String _vcOperType; 
							 			
			public String vcOperType 
			{
				get { return _vcOperType;}
				set
				{
					 _vcOperType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperType"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private DateTime? _dtOperDate; 
							 			
			public DateTime? dtOperDate 
			{
				get { return _dtOperDate;}
				set
				{
					 _dtOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtOperDate"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbRepAssLarg : INotifyPropertyChanged							
		{
						
			private String _vcDeptID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
							
			private String _vcDate; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcDate 
			{
				get { return _vcDate;}
				set
				{
					 _vcDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDate"));
				}
			}						
							
			private Int32 _LargTimes; 
							 			
			public Int32 LargTimes 
			{
				get { return _LargTimes;}
				set
				{
					 _LargTimes = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("LargTimes"));
				}
			}						
							
			private Int32 _GoodsCount; 
							 			
			public Int32 GoodsCount 
			{
				get { return _GoodsCount;}
				set
				{
					 _GoodsCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("GoodsCount"));
				}
			}						
							
			private String _vcAssBelongDept; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String vcAssBelongDept 
			{
				get { return _vcAssBelongDept;}
				set
				{
					 _vcAssBelongDept = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssBelongDept"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbConsItemHis : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private String _vcGoodsID; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcGoodsID 
			{
				get { return _vcGoodsID;}
				set
				{
					 _vcGoodsID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcGoodsID"));
				}
			}						
							
			private Int64? _iAssID; 
							 			
			public Int64? iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private Decimal? _nPrice; 
							 			
			public Decimal? nPrice 
			{
				get { return _nPrice;}
				set
				{
					 _nPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nPrice"));
				}
			}						
							
			private Int32? _iCount; 
							 			
			public Int32? iCount 
			{
				get { return _iCount;}
				set
				{
					 _iCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iCount"));
				}
			}						
							
			private Decimal? _nTRate; 
							 			
			public Decimal? nTRate 
			{
				get { return _nTRate;}
				set
				{
					 _nTRate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nTRate"));
				}
			}						
							
			private Decimal? _nFee; 
							 			
			public Decimal? nFee 
			{
				get { return _nFee;}
				set
				{
					 _nFee = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFee"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private String _cFlag; 
							 			
			public String cFlag 
			{
				get { return _cFlag;}
				set
				{
					 _cFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cFlag"));
				}
			}						
							
			private DateTime? _dtConsDate; 
							 			
			public DateTime? dtConsDate 
			{
				get { return _dtConsDate;}
				set
				{
					 _dtConsDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtConsDate"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbFunc : INotifyPropertyChanged							
		{
						
			private String _cnvcFuncName; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcFuncName 
			{
				get { return _cnvcFuncName;}
				set
				{
					 _cnvcFuncName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcFuncName"));
				}
			}						
							
			private String _cnvcFuncParentName; 
							 			
			public String cnvcFuncParentName 
			{
				get { return _cnvcFuncParentName;}
				set
				{
					 _cnvcFuncParentName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcFuncParentName"));
				}
			}						
							
			private String _cnvcFuncAddress; 
							 			
			public String cnvcFuncAddress 
			{
				get { return _cnvcFuncAddress;}
				set
				{
					 _cnvcFuncAddress = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcFuncAddress"));
				}
			}						
							
			private String _cnvcFuncType; 
							 			
			public String cnvcFuncType 
			{
				get { return _cnvcFuncType;}
				set
				{
					 _cnvcFuncType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcFuncType"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbRepAssSpecCons : INotifyPropertyChanged							
		{
						
			private String _vcDeptID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
							
			private String _vcDate; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcDate 
			{
				get { return _vcDate;}
				set
				{
					 _vcDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDate"));
				}
			}						
							
			private Int32 _SpecConsTimes; 
							 			
			public Int32 SpecConsTimes 
			{
				get { return _SpecConsTimes;}
				set
				{
					 _SpecConsTimes = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("SpecConsTimes"));
				}
			}						
							
			private Int32 _GoodsCount; 
							 			
			public Int32 GoodsCount 
			{
				get { return _GoodsCount;}
				set
				{
					 _GoodsCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("GoodsCount"));
				}
			}						
							
			private String _vcConsType; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String vcConsType 
			{
				get { return _vcConsType;}
				set
				{
					 _vcConsType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcConsType"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbFillFeeHis : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private Int64? _iAssID; 
							 			
			public Int64? iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private Decimal? _nFillFee; 
							 			
			public Decimal? nFillFee 
			{
				get { return _nFillFee;}
				set
				{
					 _nFillFee = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFillFee"));
				}
			}						
							
			private Decimal? _nFillProm; 
							 			
			public Decimal? nFillProm 
			{
				get { return _nFillProm;}
				set
				{
					 _nFillProm = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFillProm"));
				}
			}						
							
			private Decimal? _nFeeLast; 
							 			
			public Decimal? nFeeLast 
			{
				get { return _nFeeLast;}
				set
				{
					 _nFeeLast = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFeeLast"));
				}
			}						
							
			private Decimal? _nFeeCur; 
							 			
			public Decimal? nFeeCur 
			{
				get { return _nFeeCur;}
				set
				{
					 _nFeeCur = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFeeCur"));
				}
			}						
							
			private DateTime? _dtFillDate; 
							 			
			public DateTime? dtFillDate 
			{
				get { return _dtFillDate;}
				set
				{
					 _dtFillDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtFillDate"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbOperFunc : INotifyPropertyChanged							
		{
						
			private String _vcOperID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcOperID 
			{
				get { return _vcOperID;}
				set
				{
					 _vcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperID"));
				}
			}						
							
			private String _vcFuncName; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcFuncName 
			{
				get { return _vcFuncName;}
				set
				{
					 _vcFuncName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcFuncName"));
				}
			}						
							
			private String _vcFuncAddress; 
							 			
			public String vcFuncAddress 
			{
				get { return _vcFuncAddress;}
				set
				{
					 _vcFuncAddress = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcFuncAddress"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbMonthlyBalance : INotifyPropertyChanged							
		{
						
			private Int32 _cnnYear; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int32 cnnYear 
			{
				get { return _cnnYear;}
				set
				{
					 _cnnYear = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnYear"));
				}
			}						
							
			private Int32 _cnnMonth; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public Int32 cnnMonth 
			{
				get { return _cnnMonth;}
				set
				{
					 _cnnMonth = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMonth"));
				}
			}						
							
			private Boolean _cnbIsBalance; 
							 			
			public Boolean cnbIsBalance 
			{
				get { return _cnbIsBalance;}
				set
				{
					 _cnbIsBalance = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnbIsBalance"));
				}
			}						
							
			private String _cnvcCreater; 
							 			
			public String cnvcCreater 
			{
				get { return _cnvcCreater;}
				set
				{
					 _cnvcCreater = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCreater"));
				}
			}						
							
			private String _cnvcCreaterName; 
							 			
			public String cnvcCreaterName 
			{
				get { return _cnvcCreaterName;}
				set
				{
					 _cnvcCreaterName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCreaterName"));
				}
			}						
							
			private DateTime _cndCreateDate; 
							 			
			public DateTime cndCreateDate 
			{
				get { return _cndCreateDate;}
				set
				{
					 _cndCreateDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndCreateDate"));
				}
			}						
							
			private String _cnvcModifier; 
							 			
			public String cnvcModifier 
			{
				get { return _cnvcModifier;}
				set
				{
					 _cnvcModifier = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcModifier"));
				}
			}						
							
			private String _cnvcModifierName; 
							 			
			public String cnvcModifierName 
			{
				get { return _cnvcModifierName;}
				set
				{
					 _cnvcModifierName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcModifierName"));
				}
			}						
							
			private DateTime? _cndModifyDate; 
							 			
			public DateTime? cndModifyDate 
			{
				get { return _cndModifyDate;}
				set
				{
					 _cndModifyDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndModifyDate"));
				}
			}						
							
			private String _cnvcBalancer; 
							 			
			public String cnvcBalancer 
			{
				get { return _cnvcBalancer;}
				set
				{
					 _cnvcBalancer = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcBalancer"));
				}
			}						
							
			private String _cnvcBalancerName; 
							 			
			public String cnvcBalancerName 
			{
				get { return _cnvcBalancerName;}
				set
				{
					 _cnvcBalancerName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcBalancerName"));
				}
			}						
							
			private DateTime? _cndBalanceDate; 
							 			
			public DateTime? cndBalanceDate 
			{
				get { return _cndBalanceDate;}
				set
				{
					 _cndBalanceDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndBalanceDate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbOperLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnOperSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnOperSerialNo 
			{
				get { return _cnnOperSerialNo;}
				set
				{
					 _cnnOperSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOperSerialNo"));
				}
			}						
							
			private String _cnvcOperType; 
							 			
			public String cnvcOperType 
			{
				get { return _cnvcOperType;}
				set
				{
					 _cnvcOperType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperType"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private String _cnvcDeptID; 
							 			
			public String cnvcDeptID 
			{
				get { return _cnvcDeptID;}
				set
				{
					 _cnvcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbIntegralLogHis : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private Int64 _iAssID; 
							 			
			public Int64 iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private String _vcIgType; 
							 			
			public String vcIgType 
			{
				get { return _vcIgType;}
				set
				{
					 _vcIgType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcIgType"));
				}
			}						
							
			private Int32? _iIgLast; 
							 			
			public Int32? iIgLast 
			{
				get { return _iIgLast;}
				set
				{
					 _iIgLast = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgLast"));
				}
			}						
							
			private Int32? _iIgGet; 
							 			
			public Int32? iIgGet 
			{
				get { return _iIgGet;}
				set
				{
					 _iIgGet = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgGet"));
				}
			}						
							
			private Int32? _iIgArrival; 
							 			
			public Int32? iIgArrival 
			{
				get { return _iIgArrival;}
				set
				{
					 _iIgArrival = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgArrival"));
				}
			}						
							
			private Int64? _iLinkCons; 
							 			
			public Int64? iLinkCons 
			{
				get { return _iLinkCons;}
				set
				{
					 _iLinkCons = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iLinkCons"));
				}
			}						
							
			private DateTime? _dtIgDate; 
							 			
			public DateTime? dtIgDate 
			{
				get { return _dtIgDate;}
				set
				{
					 _dtIgDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtIgDate"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbAssignDetail : INotifyPropertyChanged							
		{
						
			private Decimal _cnnAssignSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnAssignSerialNo 
			{
				get { return _cnnAssignSerialNo;}
				set
				{
					 _cnnAssignSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAssignSerialNo"));
				}
			}						
							
			private Decimal _cnnOrderSerialNo; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public Decimal cnnOrderSerialNo 
			{
				get { return _cnnOrderSerialNo;}
				set
				{
					 _cnnOrderSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOrderSerialNo"));
				}
			}						
							
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnPrice; 
							 			
			public Decimal? cnnPrice 
			{
				get { return _cnnPrice;}
				set
				{
					 _cnnPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPrice"));
				}
			}						
							
			private Decimal? _cnnOrderCount; 
							 			
			public Decimal? cnnOrderCount 
			{
				get { return _cnnOrderCount;}
				set
				{
					 _cnnOrderCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOrderCount"));
				}
			}						
							
			private Decimal? _cnnCount; 
							 			
			public Decimal? cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private Decimal? _cnnSum; 
							 			
			public Decimal? cnnSum 
			{
				get { return _cnnSum;}
				set
				{
					 _cnnSum = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSum"));
				}
			}						
							
			private Decimal _cnnProduceSerialNo; 
						
			
			[Key]
			[Column(Order=3)]
			[Required()]									 			
			public Decimal cnnProduceSerialNo 
			{
				get { return _cnnProduceSerialNo;}
				set
				{
					 _cnnProduceSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnProduceSerialNo"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbMonthlyBalanceLog : INotifyPropertyChanged							
		{
						
			private Int64 _cnnId; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 cnnId 
			{
				get { return _cnnId;}
				set
				{
					 _cnnId = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnId"));
				}
			}						
							
			private Int32 _cnnYear; 
							 			
			public Int32 cnnYear 
			{
				get { return _cnnYear;}
				set
				{
					 _cnnYear = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnYear"));
				}
			}						
							
			private Int32 _cnnMonth; 
							 			
			public Int32 cnnMonth 
			{
				get { return _cnnMonth;}
				set
				{
					 _cnnMonth = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMonth"));
				}
			}						
							
			private Boolean _cnbIsBalance; 
							 			
			public Boolean cnbIsBalance 
			{
				get { return _cnbIsBalance;}
				set
				{
					 _cnbIsBalance = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnbIsBalance"));
				}
			}						
							
			private String _cnvcCreater; 
							 			
			public String cnvcCreater 
			{
				get { return _cnvcCreater;}
				set
				{
					 _cnvcCreater = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCreater"));
				}
			}						
							
			private String _cnvcCreaterName; 
							 			
			public String cnvcCreaterName 
			{
				get { return _cnvcCreaterName;}
				set
				{
					 _cnvcCreaterName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCreaterName"));
				}
			}						
							
			private DateTime _cndCreateDate; 
							 			
			public DateTime cndCreateDate 
			{
				get { return _cndCreateDate;}
				set
				{
					 _cndCreateDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndCreateDate"));
				}
			}						
							
			private String _cnvcModifier; 
							 			
			public String cnvcModifier 
			{
				get { return _cnvcModifier;}
				set
				{
					 _cnvcModifier = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcModifier"));
				}
			}						
							
			private String _cnvcModifierName; 
							 			
			public String cnvcModifierName 
			{
				get { return _cnvcModifierName;}
				set
				{
					 _cnvcModifierName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcModifierName"));
				}
			}						
							
			private DateTime? _cndModifyDate; 
							 			
			public DateTime? cndModifyDate 
			{
				get { return _cndModifyDate;}
				set
				{
					 _cndModifyDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndModifyDate"));
				}
			}						
							
			private String _cnvcBalancer; 
							 			
			public String cnvcBalancer 
			{
				get { return _cnvcBalancer;}
				set
				{
					 _cnvcBalancer = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcBalancer"));
				}
			}						
							
			private String _cnvcBalancerName; 
							 			
			public String cnvcBalancerName 
			{
				get { return _cnvcBalancerName;}
				set
				{
					 _cnvcBalancerName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcBalancerName"));
				}
			}						
							
			private DateTime? _cndBalanceDate; 
							 			
			public DateTime? cndBalanceDate 
			{
				get { return _cndBalanceDate;}
				set
				{
					 _cndBalanceDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndBalanceDate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbAssignDetailLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnSerialNo 
			{
				get { return _cnnSerialNo;}
				set
				{
					 _cnnSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSerialNo"));
				}
			}						
							
			private Decimal? _cnnAssignSerialNo; 
							 			
			public Decimal? cnnAssignSerialNo 
			{
				get { return _cnnAssignSerialNo;}
				set
				{
					 _cnnAssignSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAssignSerialNo"));
				}
			}						
							
			private Decimal? _cnnOrderSerialNo; 
							 			
			public Decimal? cnnOrderSerialNo 
			{
				get { return _cnnOrderSerialNo;}
				set
				{
					 _cnnOrderSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOrderSerialNo"));
				}
			}						
							
			private String _cnvcProductCode; 
							 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnPrice; 
							 			
			public Decimal? cnnPrice 
			{
				get { return _cnnPrice;}
				set
				{
					 _cnnPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPrice"));
				}
			}						
							
			private Decimal? _cnnOrderCount; 
							 			
			public Decimal? cnnOrderCount 
			{
				get { return _cnnOrderCount;}
				set
				{
					 _cnnOrderCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOrderCount"));
				}
			}						
							
			private Decimal? _cnnCount; 
							 			
			public Decimal? cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private Decimal? _cnnSum; 
							 			
			public Decimal? cnnSum 
			{
				get { return _cnnSum;}
				set
				{
					 _cnnSum = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSum"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbBespeakLog : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private String _vcBesName; 
							 			
			public String vcBesName 
			{
				get { return _vcBesName;}
				set
				{
					 _vcBesName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcBesName"));
				}
			}						
							
			private String _vcLinkPhone; 
							 			
			public String vcLinkPhone 
			{
				get { return _vcLinkPhone;}
				set
				{
					 _vcLinkPhone = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcLinkPhone"));
				}
			}						
							
			private String _vcBesComments; 
							 			
			public String vcBesComments 
			{
				get { return _vcBesComments;}
				set
				{
					 _vcBesComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcBesComments"));
				}
			}						
							
			private Int32? _iBesCount; 
							 			
			public Int32? iBesCount 
			{
				get { return _iBesCount;}
				set
				{
					 _iBesCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iBesCount"));
				}
			}						
							
			private DateTime? _dtBesDate; 
							 			
			public DateTime? dtBesDate 
			{
				get { return _dtBesDate;}
				set
				{
					 _dtBesDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtBesDate"));
				}
			}						
							
			private DateTime? _dtFatchDate; 
							 			
			public DateTime? dtFatchDate 
			{
				get { return _dtFatchDate;}
				set
				{
					 _dtFatchDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtFatchDate"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
							
			private String _vcFlag; 
							 			
			public String vcFlag 
			{
				get { return _vcFlag;}
				set
				{
					 _vcFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcFlag"));
				}
			}						
							
			private DateTime? _dtFinalDate; 
							 			
			public DateTime? dtFinalDate 
			{
				get { return _dtFinalDate;}
				set
				{
					 _dtFinalDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtFinalDate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbBillOfEnterStorageLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnEnterSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnEnterSerialNo 
			{
				get { return _cnnEnterSerialNo;}
				set
				{
					 _cnnEnterSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnEnterSerialNo"));
				}
			}						
							
			private String _cnvcProviderCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcProviderCode 
			{
				get { return _cnvcProviderCode;}
				set
				{
					 _cnvcProviderCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProviderCode"));
				}
			}						
							
			private DateTime? _cndEnterDate; 
							 			
			public DateTime? cndEnterDate 
			{
				get { return _cndEnterDate;}
				set
				{
					 _cndEnterDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndEnterDate"));
				}
			}						
							
			private String _cnvcDeliverMan; 
							 			
			public String cnvcDeliverMan 
			{
				get { return _cnvcDeliverMan;}
				set
				{
					 _cnvcDeliverMan = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeliverMan"));
				}
			}						
							
			private String _cnvcValidateOperID; 
							 			
			public String cnvcValidateOperID 
			{
				get { return _cnvcValidateOperID;}
				set
				{
					 _cnvcValidateOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcValidateOperID"));
				}
			}						
							
			private String _cnvcSafeOperID; 
							 			
			public String cnvcSafeOperID 
			{
				get { return _cnvcSafeOperID;}
				set
				{
					 _cnvcSafeOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcSafeOperID"));
				}
			}						
							
			private String _cnvcStorageOperID; 
							 			
			public String cnvcStorageOperID 
			{
				get { return _cnvcStorageOperID;}
				set
				{
					 _cnvcStorageOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcStorageOperID"));
				}
			}						
							
			private String _cnvcBillOperID; 
							 			
			public String cnvcBillOperID 
			{
				get { return _cnvcBillOperID;}
				set
				{
					 _cnvcBillOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcBillOperID"));
				}
			}						
							
			private String _cnvcEnterType; 
							 			
			public String cnvcEnterType 
			{
				get { return _cnvcEnterType;}
				set
				{
					 _cnvcEnterType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcEnterType"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbAssignLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnAssignSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnAssignSerialNo 
			{
				get { return _cnnAssignSerialNo;}
				set
				{
					 _cnnAssignSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAssignSerialNo"));
				}
			}						
							
			private Decimal _cnnOrderSerialNo; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public Decimal cnnOrderSerialNo 
			{
				get { return _cnnOrderSerialNo;}
				set
				{
					 _cnnOrderSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOrderSerialNo"));
				}
			}						
							
			private String _cnvcShipDeptID; 
							 			
			public String cnvcShipDeptID 
			{
				get { return _cnvcShipDeptID;}
				set
				{
					 _cnvcShipDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcShipDeptID"));
				}
			}						
							
			private String _cnvcShipOperID; 
							 			
			public String cnvcShipOperID 
			{
				get { return _cnvcShipOperID;}
				set
				{
					 _cnvcShipOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcShipOperID"));
				}
			}						
							
			private String _cnvcReceiveDeptID; 
							 			
			public String cnvcReceiveDeptID 
			{
				get { return _cnvcReceiveDeptID;}
				set
				{
					 _cnvcReceiveDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcReceiveDeptID"));
				}
			}						
							
			private String _cnvcReceiveOperID; 
							 			
			public String cnvcReceiveOperID 
			{
				get { return _cnvcReceiveOperID;}
				set
				{
					 _cnvcReceiveOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcReceiveOperID"));
				}
			}						
							
			private DateTime? _cndShipDate; 
							 			
			public DateTime? cndShipDate 
			{
				get { return _cndShipDate;}
				set
				{
					 _cndShipDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndShipDate"));
				}
			}						
							
			private DateTime? _cndReceiveDate; 
							 			
			public DateTime? cndReceiveDate 
			{
				get { return _cndReceiveDate;}
				set
				{
					 _cndReceiveDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndReceiveDate"));
				}
			}						
							
			private String _cnvcSalesroomOperID; 
							 			
			public String cnvcSalesroomOperID 
			{
				get { return _cnvcSalesroomOperID;}
				set
				{
					 _cnvcSalesroomOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcSalesroomOperID"));
				}
			}						
							
			private String _cnvcTransportOperID; 
							 			
			public String cnvcTransportOperID 
			{
				get { return _cnvcTransportOperID;}
				set
				{
					 _cnvcTransportOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcTransportOperID"));
				}
			}						
							
			private String _cnvcStorageOperID; 
							 			
			public String cnvcStorageOperID 
			{
				get { return _cnvcStorageOperID;}
				set
				{
					 _cnvcStorageOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcStorageOperID"));
				}
			}						
							
			private String _cnvcCustomerValidate; 
							 			
			public String cnvcCustomerValidate 
			{
				get { return _cnvcCustomerValidate;}
				set
				{
					 _cnvcCustomerValidate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCustomerValidate"));
				}
			}						
							
			private String _cnvcCustomerIdea; 
							 			
			public String cnvcCustomerIdea 
			{
				get { return _cnvcCustomerIdea;}
				set
				{
					 _cnvcCustomerIdea = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCustomerIdea"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
							
			private Decimal _cnnProduceSerialNo; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public Decimal cnnProduceSerialNo 
			{
				get { return _cnnProduceSerialNo;}
				set
				{
					 _cnnProduceSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnProduceSerialNo"));
				}
			}						
							
			private Int32 _cnnPrintFlag; 
							 			
			public Int32 cnnPrintFlag 
			{
				get { return _cnnPrintFlag;}
				set
				{
					 _cnnPrintFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPrintFlag"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbDept : INotifyPropertyChanged							
		{
						
			private String _cnvcDeptName; 
							 			
			public String cnvcDeptName 
			{
				get { return _cnvcDeptName;}
				set
				{
					 _cnvcDeptName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptName"));
				}
			}						
							
			private String _cnvcDeptID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcDeptID 
			{
				get { return _cnvcDeptID;}
				set
				{
					 _cnvcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptID"));
				}
			}						
							
			private String _cnvcDeptType; 
							 			
			public String cnvcDeptType 
			{
				get { return _cnvcDeptType;}
				set
				{
					 _cnvcDeptType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptType"));
				}
			}						
							
			private String _cnvcParentDeptID; 
							 			
			public String cnvcParentDeptID 
			{
				get { return _cnvcParentDeptID;}
				set
				{
					 _cnvcParentDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcParentDeptID"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
							
			private Int32? _cnnPriority; 
							 			
			public Int32? cnnPriority 
			{
				get { return _cnnPriority;}
				set
				{
					 _cnnPriority = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPriority"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbBillOfEnterStorageDetail : INotifyPropertyChanged							
		{
						
			private Decimal _cnnEnterSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnEnterSerialNo 
			{
				get { return _cnnEnterSerialNo;}
				set
				{
					 _cnnEnterSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnEnterSerialNo"));
				}
			}						
							
			private String _cnvcProviderCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcProviderCode 
			{
				get { return _cnvcProviderCode;}
				set
				{
					 _cnvcProviderCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProviderCode"));
				}
			}						
							
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private String _cnvcStandardUnit; 
							 			
			public String cnvcStandardUnit 
			{
				get { return _cnvcStandardUnit;}
				set
				{
					 _cnvcStandardUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcStandardUnit"));
				}
			}						
							
			private Decimal? _cnnStandardCount; 
							 			
			public Decimal? cnnStandardCount 
			{
				get { return _cnnStandardCount;}
				set
				{
					 _cnnStandardCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnStandardCount"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnPrice; 
							 			
			public Decimal? cnnPrice 
			{
				get { return _cnnPrice;}
				set
				{
					 _cnnPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPrice"));
				}
			}						
							
			private Decimal? _cnnCount; 
							 			
			public Decimal? cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private Decimal? _cnnSum; 
							 			
			public Decimal? cnnSum 
			{
				get { return _cnnSum;}
				set
				{
					 _cnnSum = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSum"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbFormula : INotifyPropertyChanged							
		{
						
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private String _cnvcProductType; 
							 			
			public String cnvcProductType 
			{
				get { return _cnvcProductType;}
				set
				{
					 _cnvcProductType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductType"));
				}
			}						
							
			private String _cnvcProductClass; 
							 			
			public String cnvcProductClass 
			{
				get { return _cnvcProductClass;}
				set
				{
					 _cnvcProductClass = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductClass"));
				}
			}						
							
			private Byte[] _cnbProductImage; 
							 			
			public Byte[] cnbProductImage 
			{
				get { return _cnbProductImage;}
				set
				{
					 _cnbProductImage = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnbProductImage"));
				}
			}						
							
			private Decimal? _cnnMaterialCostSum; 
							 			
			public Decimal? cnnMaterialCostSum 
			{
				get { return _cnnMaterialCostSum;}
				set
				{
					 _cnnMaterialCostSum = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMaterialCostSum"));
				}
			}						
							
			private Decimal? _cnnPackingCostSum; 
							 			
			public Decimal? cnnPackingCostSum 
			{
				get { return _cnnPackingCostSum;}
				set
				{
					 _cnnPackingCostSum = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPackingCostSum"));
				}
			}						
							
			private Decimal? _cnnCostSum; 
							 			
			public Decimal? cnnCostSum 
			{
				get { return _cnnCostSum;}
				set
				{
					 _cnnCostSum = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCostSum"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnPortionCount; 
							 			
			public Decimal? cnnPortionCount 
			{
				get { return _cnnPortionCount;}
				set
				{
					 _cnnPortionCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPortionCount"));
				}
			}						
							
			private String _cnvcPortionUnit; 
							 			
			public String cnvcPortionUnit 
			{
				get { return _cnvcPortionUnit;}
				set
				{
					 _cnvcPortionUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcPortionUnit"));
				}
			}						
							
			private String _cnvcFeel; 
							 			
			public String cnvcFeel 
			{
				get { return _cnvcFeel;}
				set
				{
					 _cnvcFeel = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcFeel"));
				}
			}						
							
			private String _cnvcOrganise; 
							 			
			public String cnvcOrganise 
			{
				get { return _cnvcOrganise;}
				set
				{
					 _cnvcOrganise = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOrganise"));
				}
			}						
							
			private String _cnvcColor; 
							 			
			public String cnvcColor 
			{
				get { return _cnvcColor;}
				set
				{
					 _cnvcColor = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcColor"));
				}
			}						
							
			private String _cnvcTaste; 
							 			
			public String cnvcTaste 
			{
				get { return _cnvcTaste;}
				set
				{
					 _cnvcTaste = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcTaste"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbBusiIncomeReport : INotifyPropertyChanged							
		{
						
			private String _vcDateZoom; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcDateZoom 
			{
				get { return _vcDateZoom;}
				set
				{
					 _vcDateZoom = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDateZoom"));
				}
			}						
							
			private String _vcDeptID; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
							
			private String _Type; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String Type 
			{
				get { return _Type;}
				set
				{
					 _Type = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("Type"));
				}
			}						
							
			private Int32 _REP1; 
							 			
			public Int32 REP1 
			{
				get { return _REP1;}
				set
				{
					 _REP1 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("REP1"));
				}
			}						
							
			private Int32 _REP2; 
							 			
			public Int32 REP2 
			{
				get { return _REP2;}
				set
				{
					 _REP2 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("REP2"));
				}
			}						
							
			private Decimal _REP3; 
							 			
			public Decimal REP3 
			{
				get { return _REP3;}
				set
				{
					 _REP3 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("REP3"));
				}
			}						
							
			private Decimal _REP4; 
							 			
			public Decimal REP4 
			{
				get { return _REP4;}
				set
				{
					 _REP4 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("REP4"));
				}
			}						
							
			private Decimal _REP5; 
							 			
			public Decimal REP5 
			{
				get { return _REP5;}
				set
				{
					 _REP5 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("REP5"));
				}
			}						
							
			private Decimal _REP6; 
							 			
			public Decimal REP6 
			{
				get { return _REP6;}
				set
				{
					 _REP6 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("REP6"));
				}
			}						
							
			private Int32 _REP7; 
							 			
			public Int32 REP7 
			{
				get { return _REP7;}
				set
				{
					 _REP7 = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("REP7"));
				}
			}						
							
			private Int32? _ReNo; 
							 			
			public Int32? ReNo 
			{
				get { return _ReNo;}
				set
				{
					 _ReNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("ReNo"));
				}
			}						
							
			private DateTime? _dtCreateDate; 
							 			
			public DateTime? dtCreateDate 
			{
				get { return _dtCreateDate;}
				set
				{
					 _dtCreateDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtCreateDate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbSysErrorLog : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private String _vcDeptID; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
							
			private DateTime? _dtErrDate; 
							 			
			public DateTime? dtErrDate 
			{
				get { return _dtErrDate;}
				set
				{
					 _dtErrDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtErrDate"));
				}
			}						
							
			private String _vcErrorDes; 
							 			
			public String vcErrorDes 
			{
				get { return _vcErrorDes;}
				set
				{
					 _vcErrorDes = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcErrorDes"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbSellDayCheckDetail : INotifyPropertyChanged							
		{
						
			private Decimal _cnnCheckSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnCheckSerialNo 
			{
				get { return _cnnCheckSerialNo;}
				set
				{
					 _cnnCheckSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCheckSerialNo"));
				}
			}						
							
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private Decimal? _cnnProductPrice; 
							 			
			public Decimal? cnnProductPrice 
			{
				get { return _cnnProductPrice;}
				set
				{
					 _cnnProductPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnProductPrice"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnOriginalStorage; 
							 			
			public Decimal? cnnOriginalStorage 
			{
				get { return _cnnOriginalStorage;}
				set
				{
					 _cnnOriginalStorage = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOriginalStorage"));
				}
			}						
							
			private Decimal? _cnnOrderCount; 
							 			
			public Decimal? cnnOrderCount 
			{
				get { return _cnnOrderCount;}
				set
				{
					 _cnnOrderCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOrderCount"));
				}
			}						
							
			private Decimal? _cnnMoveOutCount; 
							 			
			public Decimal? cnnMoveOutCount 
			{
				get { return _cnnMoveOutCount;}
				set
				{
					 _cnnMoveOutCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMoveOutCount"));
				}
			}						
							
			private Decimal? _cnnMoveInCount; 
							 			
			public Decimal? cnnMoveInCount 
			{
				get { return _cnnMoveInCount;}
				set
				{
					 _cnnMoveInCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMoveInCount"));
				}
			}						
							
			private Decimal? _cnnLoseCount; 
							 			
			public Decimal? cnnLoseCount 
			{
				get { return _cnnLoseCount;}
				set
				{
					 _cnnLoseCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnLoseCount"));
				}
			}						
							
			private Decimal? _cnnFreeCount; 
							 			
			public Decimal? cnnFreeCount 
			{
				get { return _cnnFreeCount;}
				set
				{
					 _cnnFreeCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnFreeCount"));
				}
			}						
							
			private Decimal? _cnnUseCount; 
							 			
			public Decimal? cnnUseCount 
			{
				get { return _cnnUseCount;}
				set
				{
					 _cnnUseCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnUseCount"));
				}
			}						
							
			private Decimal? _cnnSellCount; 
							 			
			public Decimal? cnnSellCount 
			{
				get { return _cnnSellCount;}
				set
				{
					 _cnnSellCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSellCount"));
				}
			}						
							
			private Decimal? _cnnSystemCount; 
							 			
			public Decimal? cnnSystemCount 
			{
				get { return _cnnSystemCount;}
				set
				{
					 _cnnSystemCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSystemCount"));
				}
			}						
							
			private Decimal? _cnnRealCount; 
							 			
			public Decimal? cnnRealCount 
			{
				get { return _cnnRealCount;}
				set
				{
					 _cnnRealCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnRealCount"));
				}
			}						
							
			private Decimal? _cnnDifferentCount; 
							 			
			public Decimal? cnnDifferentCount 
			{
				get { return _cnnDifferentCount;}
				set
				{
					 _cnnDifferentCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnDifferentCount"));
				}
			}						
							
			private Decimal? _cnnDifferentSum; 
							 			
			public Decimal? cnnDifferentSum 
			{
				get { return _cnnDifferentSum;}
				set
				{
					 _cnnDifferentSum = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnDifferentSum"));
				}
			}						
							
			private Decimal? _cnnReceiveCount; 
							 			
			public Decimal? cnnReceiveCount 
			{
				get { return _cnnReceiveCount;}
				set
				{
					 _cnnReceiveCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnReceiveCount"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbAssociatorSync : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private String _vcAssName; 
							 			
			public String vcAssName 
			{
				get { return _vcAssName;}
				set
				{
					 _vcAssName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssName"));
				}
			}						
							
			private String _vcSpell; 
							 			
			public String vcSpell 
			{
				get { return _vcSpell;}
				set
				{
					 _vcSpell = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcSpell"));
				}
			}						
							
			private String _vcAssNbr; 
							 			
			public String vcAssNbr 
			{
				get { return _vcAssNbr;}
				set
				{
					 _vcAssNbr = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssNbr"));
				}
			}						
							
			private String _vcLinkPhone; 
							 			
			public String vcLinkPhone 
			{
				get { return _vcLinkPhone;}
				set
				{
					 _vcLinkPhone = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcLinkPhone"));
				}
			}						
							
			private String _vcLinkAddress; 
							 			
			public String vcLinkAddress 
			{
				get { return _vcLinkAddress;}
				set
				{
					 _vcLinkAddress = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcLinkAddress"));
				}
			}						
							
			private String _vcEmail; 
							 			
			public String vcEmail 
			{
				get { return _vcEmail;}
				set
				{
					 _vcEmail = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcEmail"));
				}
			}						
							
			private String _vcAssType; 
							 			
			public String vcAssType 
			{
				get { return _vcAssType;}
				set
				{
					 _vcAssType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssType"));
				}
			}						
							
			private String _vcAssState; 
							 			
			public String vcAssState 
			{
				get { return _vcAssState;}
				set
				{
					 _vcAssState = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssState"));
				}
			}						
							
			private Decimal? _nCharge; 
							 			
			public Decimal? nCharge 
			{
				get { return _nCharge;}
				set
				{
					 _nCharge = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nCharge"));
				}
			}						
							
			private Int32? _iIgValue; 
							 			
			public Int32? iIgValue 
			{
				get { return _iIgValue;}
				set
				{
					 _iIgValue = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgValue"));
				}
			}						
							
			private String _vcCardFlag; 
							 			
			public String vcCardFlag 
			{
				get { return _vcCardFlag;}
				set
				{
					 _vcCardFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardFlag"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private DateTime? _dtCreateDate; 
							 			
			public DateTime? dtCreateDate 
			{
				get { return _dtCreateDate;}
				set
				{
					 _dtCreateDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtCreateDate"));
				}
			}						
							
			private DateTime? _dtOperDate; 
							 			
			public DateTime? dtOperDate 
			{
				get { return _dtOperDate;}
				set
				{
					 _dtOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtOperDate"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
							
			private String _vcCardSerial; 
							 			
			public String vcCardSerial 
			{
				get { return _vcCardSerial;}
				set
				{
					 _vcCardSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardSerial"));
				}
			}						
							
			private Int64? _iUpdateCount; 
							 			
			public Int64? iUpdateCount 
			{
				get { return _iUpdateCount;}
				set
				{
					 _iUpdateCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iUpdateCount"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbMakeLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnProduceSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnProduceSerialNo 
			{
				get { return _cnnProduceSerialNo;}
				set
				{
					 _cnnProduceSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnProduceSerialNo"));
				}
			}						
							
			private Decimal _cnnMakeSerialNo; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public Decimal cnnMakeSerialNo 
			{
				get { return _cnnMakeSerialNo;}
				set
				{
					 _cnnMakeSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMakeSerialNo"));
				}
			}						
							
			private String _cnvcGroup; 
							 			
			public String cnvcGroup 
			{
				get { return _cnvcGroup;}
				set
				{
					 _cnvcGroup = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcGroup"));
				}
			}						
							
			private String _cnvcMakeName; 
							 			
			public String cnvcMakeName 
			{
				get { return _cnvcMakeName;}
				set
				{
					 _cnvcMakeName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMakeName"));
				}
			}						
							
			private String _cnvcMakeType; 
							 			
			public String cnvcMakeType 
			{
				get { return _cnvcMakeType;}
				set
				{
					 _cnvcMakeType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMakeType"));
				}
			}						
							
			private String _cnvcClass; 
							 			
			public String cnvcClass 
			{
				get { return _cnvcClass;}
				set
				{
					 _cnvcClass = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcClass"));
				}
			}						
							
			private String _cnvcInChargeOperID; 
							 			
			public String cnvcInChargeOperID 
			{
				get { return _cnvcInChargeOperID;}
				set
				{
					 _cnvcInChargeOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcInChargeOperID"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbAssociatorLog : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private Int64 _iAssID; 
							 			
			public Int64 iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private String _vcAssName; 
							 			
			public String vcAssName 
			{
				get { return _vcAssName;}
				set
				{
					 _vcAssName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssName"));
				}
			}						
							
			private String _vcSpell; 
							 			
			public String vcSpell 
			{
				get { return _vcSpell;}
				set
				{
					 _vcSpell = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcSpell"));
				}
			}						
							
			private String _vcAssNbr; 
							 			
			public String vcAssNbr 
			{
				get { return _vcAssNbr;}
				set
				{
					 _vcAssNbr = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssNbr"));
				}
			}						
							
			private String _vcLinkPhone; 
							 			
			public String vcLinkPhone 
			{
				get { return _vcLinkPhone;}
				set
				{
					 _vcLinkPhone = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcLinkPhone"));
				}
			}						
							
			private String _vcLinkAddress; 
							 			
			public String vcLinkAddress 
			{
				get { return _vcLinkAddress;}
				set
				{
					 _vcLinkAddress = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcLinkAddress"));
				}
			}						
							
			private String _vcEmail; 
							 			
			public String vcEmail 
			{
				get { return _vcEmail;}
				set
				{
					 _vcEmail = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcEmail"));
				}
			}						
							
			private String _vcAssType; 
							 			
			public String vcAssType 
			{
				get { return _vcAssType;}
				set
				{
					 _vcAssType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssType"));
				}
			}						
							
			private String _vcAssState; 
							 			
			public String vcAssState 
			{
				get { return _vcAssState;}
				set
				{
					 _vcAssState = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssState"));
				}
			}						
							
			private Decimal? _nCharge; 
							 			
			public Decimal? nCharge 
			{
				get { return _nCharge;}
				set
				{
					 _nCharge = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nCharge"));
				}
			}						
							
			private Int32? _iIgValue; 
							 			
			public Int32? iIgValue 
			{
				get { return _iIgValue;}
				set
				{
					 _iIgValue = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgValue"));
				}
			}						
							
			private String _vcCardFlag; 
							 			
			public String vcCardFlag 
			{
				get { return _vcCardFlag;}
				set
				{
					 _vcCardFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardFlag"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private DateTime? _dtCreateDate; 
							 			
			public DateTime? dtCreateDate 
			{
				get { return _dtCreateDate;}
				set
				{
					 _dtCreateDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtCreateDate"));
				}
			}						
							
			private DateTime? _dtOperDate; 
							 			
			public DateTime? dtOperDate 
			{
				get { return _dtOperDate;}
				set
				{
					 _dtOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtOperDate"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private String _vcOperDeptID; 
							 			
			public String vcOperDeptID 
			{
				get { return _vcOperDeptID;}
				set
				{
					 _vcOperDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperDeptID"));
				}
			}						
							
			private String _vcCardSerial; 
							 			
			public String vcCardSerial 
			{
				get { return _vcCardSerial;}
				set
				{
					 _vcCardSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardSerial"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbStorage : INotifyPropertyChanged							
		{
						
			private String _cnvcStorageDeptID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcStorageDeptID 
			{
				get { return _cnvcStorageDeptID;}
				set
				{
					 _cnvcStorageDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcStorageDeptID"));
				}
			}						
							
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnCount; 
							 			
			public Decimal? cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private Decimal? _cnnSafeCount; 
							 			
			public Decimal? cnnSafeCount 
			{
				get { return _cnnSafeCount;}
				set
				{
					 _cnnSafeCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSafeCount"));
				}
			}						
							
			private Decimal? _cnnSafeUpCount; 
							 			
			public Decimal? cnnSafeUpCount 
			{
				get { return _cnnSafeUpCount;}
				set
				{
					 _cnnSafeUpCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSafeUpCount"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbNameCode : INotifyPropertyChanged							
		{
						
			private String _cnvcType; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcType 
			{
				get { return _cnvcType;}
				set
				{
					 _cnvcType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcType"));
				}
			}						
							
			private String _cnvcCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcCode 
			{
				get { return _cnvcCode;}
				set
				{
					 _cnvcCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCode"));
				}
			}						
							
			private String _cnvcName; 
							 			
			public String cnvcName 
			{
				get { return _cnvcName;}
				set
				{
					 _cnvcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcName"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbStorageLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnSerialNo 
			{
				get { return _cnnSerialNo;}
				set
				{
					 _cnnSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSerialNo"));
				}
			}						
							
			private String _cnvcStorageDeptID; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcStorageDeptID 
			{
				get { return _cnvcStorageDeptID;}
				set
				{
					 _cnvcStorageDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcStorageDeptID"));
				}
			}						
							
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnCount; 
							 			
			public Decimal? cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private Decimal? _cnnSafeCount; 
							 			
			public Decimal? cnnSafeCount 
			{
				get { return _cnnSafeCount;}
				set
				{
					 _cnnSafeCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSafeCount"));
				}
			}						
							
			private Decimal? _cnnSafeUpCount; 
							 			
			public Decimal? cnnSafeUpCount 
			{
				get { return _cnnSafeUpCount;}
				set
				{
					 _cnnSafeUpCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSafeUpCount"));
				}
			}						
							
			private String _cnvcOperType; 
							 			
			public String cnvcOperType 
			{
				get { return _cnvcOperType;}
				set
				{
					 _cnvcOperType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperType"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbBillOfMaterials : INotifyPropertyChanged							
		{
						
			private String _cnvcPartInvCode; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcPartInvCode 
			{
				get { return _cnvcPartInvCode;}
				set
				{
					 _cnvcPartInvCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcPartInvCode"));
				}
			}						
							
			private String _cnvcComponentInvCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcComponentInvCode 
			{
				get { return _cnvcComponentInvCode;}
				set
				{
					 _cnvcComponentInvCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComponentInvCode"));
				}
			}						
							
			private Decimal _cnnBaseQtyN; 
							 			
			public Decimal cnnBaseQtyN 
			{
				get { return _cnnBaseQtyN;}
				set
				{
					 _cnnBaseQtyN = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnBaseQtyN"));
				}
			}						
							
			private Decimal _cnnBaseQtyD; 
							 			
			public Decimal cnnBaseQtyD 
			{
				get { return _cnnBaseQtyD;}
				set
				{
					 _cnnBaseQtyD = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnBaseQtyD"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbOperStandard : INotifyPropertyChanged							
		{
						
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private Int32 _cnnSort; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public Int32 cnnSort 
			{
				get { return _cnnSort;}
				set
				{
					 _cnnSort = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSort"));
				}
			}						
							
			private String _cnvcStandard; 
							 			
			public String cnvcStandard 
			{
				get { return _cnvcStandard;}
				set
				{
					 _cnvcStandard = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcStandard"));
				}
			}						
							
			private String _cnvcKey; 
							 			
			public String cnvcKey 
			{
				get { return _cnvcKey;}
				set
				{
					 _cnvcKey = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcKey"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbCurrentStock : INotifyPropertyChanged							
		{
						
			private Decimal _cnnAutoID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnAutoID 
			{
				get { return _cnnAutoID;}
				set
				{
					 _cnnAutoID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAutoID"));
				}
			}						
							
			private String _cnvcWhCode; 
							 			
			public String cnvcWhCode 
			{
				get { return _cnvcWhCode;}
				set
				{
					 _cnvcWhCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcWhCode"));
				}
			}						
							
			private String _cnvcInvCode; 
							 			
			public String cnvcInvCode 
			{
				get { return _cnvcInvCode;}
				set
				{
					 _cnvcInvCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcInvCode"));
				}
			}						
							
			private Decimal? _cnnQuantity; 
							 			
			public Decimal? cnnQuantity 
			{
				get { return _cnnQuantity;}
				set
				{
					 _cnnQuantity = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnQuantity"));
				}
			}						
							
			private Decimal? _cnnOutQuantity; 
							 			
			public Decimal? cnnOutQuantity 
			{
				get { return _cnnOutQuantity;}
				set
				{
					 _cnnOutQuantity = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOutQuantity"));
				}
			}						
							
			private Decimal? _cnnInQuantity; 
							 			
			public Decimal? cnnInQuantity 
			{
				get { return _cnnInQuantity;}
				set
				{
					 _cnnInQuantity = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnInQuantity"));
				}
			}						
							
			private String _cnvcStopFlag; 
							 			
			public String cnvcStopFlag 
			{
				get { return _cnvcStopFlag;}
				set
				{
					 _cnvcStopFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcStopFlag"));
				}
			}						
							
			private Decimal? _cnnTransInQuantity; 
							 			
			public Decimal? cnnTransInQuantity 
			{
				get { return _cnnTransInQuantity;}
				set
				{
					 _cnnTransInQuantity = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnTransInQuantity"));
				}
			}						
							
			private DateTime? _cndMdate; 
							 			
			public DateTime? cndMdate 
			{
				get { return _cndMdate;}
				set
				{
					 _cndMdate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndMdate"));
				}
			}						
							
			private Decimal? _cnnTransOutQuantity; 
							 			
			public Decimal? cnnTransOutQuantity 
			{
				get { return _cnnTransOutQuantity;}
				set
				{
					 _cnnTransOutQuantity = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnTransOutQuantity"));
				}
			}						
							
			private Decimal? _cnnPlanQuantity; 
							 			
			public Decimal? cnnPlanQuantity 
			{
				get { return _cnnPlanQuantity;}
				set
				{
					 _cnnPlanQuantity = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPlanQuantity"));
				}
			}						
							
			private Decimal? _cnnDisableQuantity; 
							 			
			public Decimal? cnnDisableQuantity 
			{
				get { return _cnnDisableQuantity;}
				set
				{
					 _cnnDisableQuantity = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnDisableQuantity"));
				}
			}						
							
			private Decimal? _cnnAvaQuantity; 
							 			
			public Decimal? cnnAvaQuantity 
			{
				get { return _cnnAvaQuantity;}
				set
				{
					 _cnnAvaQuantity = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAvaQuantity"));
				}
			}						
							
			private Int32? _cnnMassDate; 
							 			
			public Int32? cnnMassDate 
			{
				get { return _cnnMassDate;}
				set
				{
					 _cnnMassDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMassDate"));
				}
			}						
							
			private String _cnvcMassUnit; 
							 			
			public String cnvcMassUnit 
			{
				get { return _cnvcMassUnit;}
				set
				{
					 _cnvcMassUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMassUnit"));
				}
			}						
							
			private Decimal? _cnnStopQuantity; 
							 			
			public Decimal? cnnStopQuantity 
			{
				get { return _cnnStopQuantity;}
				set
				{
					 _cnnStopQuantity = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnStopQuantity"));
				}
			}						
							
			private Decimal? _cnnStopNum; 
							 			
			public Decimal? cnnStopNum 
			{
				get { return _cnnStopNum;}
				set
				{
					 _cnnStopNum = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnStopNum"));
				}
			}						
							
			private DateTime? _cndExpDate; 
							 			
			public DateTime? cndExpDate 
			{
				get { return _cndExpDate;}
				set
				{
					 _cndExpDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndExpDate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbOrderAddLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnAddSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnAddSerialNo 
			{
				get { return _cnnAddSerialNo;}
				set
				{
					 _cnnAddSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAddSerialNo"));
				}
			}						
							
			private Decimal _cnnOrderSerialNo; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public Decimal cnnOrderSerialNo 
			{
				get { return _cnnOrderSerialNo;}
				set
				{
					 _cnnOrderSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOrderSerialNo"));
				}
			}						
							
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private Decimal? _cnnAddCount; 
							 			
			public Decimal? cnnAddCount 
			{
				get { return _cnnAddCount;}
				set
				{
					 _cnnAddCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAddCount"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnPrice; 
							 			
			public Decimal? cnnPrice 
			{
				get { return _cnnPrice;}
				set
				{
					 _cnnPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPrice"));
				}
			}						
							
			private Decimal? _cnnSum; 
							 			
			public Decimal? cnnSum 
			{
				get { return _cnnSum;}
				set
				{
					 _cnnSum = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSum"));
				}
			}						
							
			private String _cnvcAddType; 
							 			
			public String cnvcAddType 
			{
				get { return _cnvcAddType;}
				set
				{
					 _cnvcAddType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcAddType"));
				}
			}						
							
			private String _cnvcAddState; 
							 			
			public String cnvcAddState 
			{
				get { return _cnvcAddState;}
				set
				{
					 _cnvcAddState = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcAddState"));
				}
			}						
							
			private String _cnvcAddComments; 
							 			
			public String cnvcAddComments 
			{
				get { return _cnvcAddComments;}
				set
				{
					 _cnvcAddComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcAddComments"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbBillOfReceiveDetail : INotifyPropertyChanged							
		{
						
			private Decimal _cnnReceiveSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnReceiveSerialNo 
			{
				get { return _cnnReceiveSerialNo;}
				set
				{
					 _cnnReceiveSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnReceiveSerialNo"));
				}
			}						
							
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private String _cnvcStandardUnit; 
							 			
			public String cnvcStandardUnit 
			{
				get { return _cnvcStandardUnit;}
				set
				{
					 _cnvcStandardUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcStandardUnit"));
				}
			}						
							
			private Decimal? _cnnStandardCount; 
							 			
			public Decimal? cnnStandardCount 
			{
				get { return _cnnStandardCount;}
				set
				{
					 _cnnStandardCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnStandardCount"));
				}
			}						
							
			private Decimal? _cnnReceiveCount; 
							 			
			public Decimal? cnnReceiveCount 
			{
				get { return _cnnReceiveCount;}
				set
				{
					 _cnnReceiveCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnReceiveCount"));
				}
			}						
							
			private Decimal? _cnnClassStorage; 
							 			
			public Decimal? cnnClassStorage 
			{
				get { return _cnnClassStorage;}
				set
				{
					 _cnnClassStorage = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnClassStorage"));
				}
			}						
							
			private Decimal? _cnnOutCount; 
							 			
			public Decimal? cnnOutCount 
			{
				get { return _cnnOutCount;}
				set
				{
					 _cnnOutCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOutCount"));
				}
			}						
							
			private Decimal? _cnnCount; 
							 			
			public Decimal? cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private String _cnvcReceiveOperID; 
							 			
			public String cnvcReceiveOperID 
			{
				get { return _cnvcReceiveOperID;}
				set
				{
					 _cnvcReceiveOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcReceiveOperID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbOrderBook : INotifyPropertyChanged							
		{
						
			private Decimal _cnnOrderSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnOrderSerialNo 
			{
				get { return _cnnOrderSerialNo;}
				set
				{
					 _cnnOrderSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOrderSerialNo"));
				}
			}						
							
			private String _cnvcOrderDeptID; 
							 			
			public String cnvcOrderDeptID 
			{
				get { return _cnvcOrderDeptID;}
				set
				{
					 _cnvcOrderDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOrderDeptID"));
				}
			}						
							
			private String _cnvcProduceDeptID; 
							 			
			public String cnvcProduceDeptID 
			{
				get { return _cnvcProduceDeptID;}
				set
				{
					 _cnvcProduceDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProduceDeptID"));
				}
			}						
							
			private String _cnvcOrderType; 
							 			
			public String cnvcOrderType 
			{
				get { return _cnvcOrderType;}
				set
				{
					 _cnvcOrderType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOrderType"));
				}
			}						
							
			private String _cnvcOrderComments; 
							 			
			public String cnvcOrderComments 
			{
				get { return _cnvcOrderComments;}
				set
				{
					 _cnvcOrderComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOrderComments"));
				}
			}						
							
			private String _cnvcOrderOperID; 
							 			
			public String cnvcOrderOperID 
			{
				get { return _cnvcOrderOperID;}
				set
				{
					 _cnvcOrderOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOrderOperID"));
				}
			}						
							
			private DateTime? _cndOrderDate; 
							 			
			public DateTime? cndOrderDate 
			{
				get { return _cndOrderDate;}
				set
				{
					 _cndOrderDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOrderDate"));
				}
			}						
							
			private DateTime? _cndShipDate; 
							 			
			public DateTime? cndShipDate 
			{
				get { return _cndShipDate;}
				set
				{
					 _cndShipDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndShipDate"));
				}
			}						
							
			private String _cnvcCustomName; 
							 			
			public String cnvcCustomName 
			{
				get { return _cnvcCustomName;}
				set
				{
					 _cnvcCustomName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCustomName"));
				}
			}						
							
			private String _cnvcShipAddress; 
							 			
			public String cnvcShipAddress 
			{
				get { return _cnvcShipAddress;}
				set
				{
					 _cnvcShipAddress = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcShipAddress"));
				}
			}						
							
			private String _cnvcLinkPhone; 
							 			
			public String cnvcLinkPhone 
			{
				get { return _cnvcLinkPhone;}
				set
				{
					 _cnvcLinkPhone = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcLinkPhone"));
				}
			}						
							
			private DateTime? _cndArrivedDate; 
							 			
			public DateTime? cndArrivedDate 
			{
				get { return _cndArrivedDate;}
				set
				{
					 _cndArrivedDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndArrivedDate"));
				}
			}						
							
			private String _cnvcOrderState; 
							 			
			public String cnvcOrderState 
			{
				get { return _cnvcOrderState;}
				set
				{
					 _cnvcOrderState = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOrderState"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbSupplier : INotifyPropertyChanged							
		{
						
			private String _cnvcCode; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcCode 
			{
				get { return _cnvcCode;}
				set
				{
					 _cnvcCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCode"));
				}
			}						
							
			private String _cnvcName; 
							 			
			public String cnvcName 
			{
				get { return _cnvcName;}
				set
				{
					 _cnvcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcName"));
				}
			}						
							
			private String _cnvcAddress; 
							 			
			public String cnvcAddress 
			{
				get { return _cnvcAddress;}
				set
				{
					 _cnvcAddress = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcAddress"));
				}
			}						
							
			private String _cnvcPostCode; 
							 			
			public String cnvcPostCode 
			{
				get { return _cnvcPostCode;}
				set
				{
					 _cnvcPostCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcPostCode"));
				}
			}						
							
			private String _cnvcPhone; 
							 			
			public String cnvcPhone 
			{
				get { return _cnvcPhone;}
				set
				{
					 _cnvcPhone = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcPhone"));
				}
			}						
							
			private String _cnvcFax; 
							 			
			public String cnvcFax 
			{
				get { return _cnvcFax;}
				set
				{
					 _cnvcFax = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcFax"));
				}
			}						
							
			private String _cnvcEmail; 
							 			
			public String cnvcEmail 
			{
				get { return _cnvcEmail;}
				set
				{
					 _cnvcEmail = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcEmail"));
				}
			}						
							
			private String _cnvcLinkName; 
							 			
			public String cnvcLinkName 
			{
				get { return _cnvcLinkName;}
				set
				{
					 _cnvcLinkName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcLinkName"));
				}
			}						
							
			private String _cnvcCreateOper; 
							 			
			public String cnvcCreateOper 
			{
				get { return _cnvcCreateOper;}
				set
				{
					 _cnvcCreateOper = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCreateOper"));
				}
			}						
							
			private DateTime _cndCreateDate; 
							 			
			public DateTime cndCreateDate 
			{
				get { return _cndCreateDate;}
				set
				{
					 _cndCreateDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndCreateDate"));
				}
			}						
							
			private Boolean _cnbInvalid; 
							 			
			public Boolean cnbInvalid 
			{
				get { return _cnbInvalid;}
				set
				{
					 _cnbInvalid = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnbInvalid"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbAssociator : INotifyPropertyChanged							
		{
						
			private Int64 _iAssID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private String _vcAssName; 
							 			
			public String vcAssName 
			{
				get { return _vcAssName;}
				set
				{
					 _vcAssName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssName"));
				}
			}						
							
			private String _vcSpell; 
							 			
			public String vcSpell 
			{
				get { return _vcSpell;}
				set
				{
					 _vcSpell = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcSpell"));
				}
			}						
							
			private String _vcAssNbr; 
							 			
			public String vcAssNbr 
			{
				get { return _vcAssNbr;}
				set
				{
					 _vcAssNbr = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssNbr"));
				}
			}						
							
			private String _vcLinkPhone; 
							 			
			public String vcLinkPhone 
			{
				get { return _vcLinkPhone;}
				set
				{
					 _vcLinkPhone = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcLinkPhone"));
				}
			}						
							
			private String _vcLinkAddress; 
							 			
			public String vcLinkAddress 
			{
				get { return _vcLinkAddress;}
				set
				{
					 _vcLinkAddress = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcLinkAddress"));
				}
			}						
							
			private String _vcEmail; 
							 			
			public String vcEmail 
			{
				get { return _vcEmail;}
				set
				{
					 _vcEmail = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcEmail"));
				}
			}						
							
			private String _vcAssType; 
							 			
			public String vcAssType 
			{
				get { return _vcAssType;}
				set
				{
					 _vcAssType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssType"));
				}
			}						
							
			private String _vcAssState; 
							 			
			public String vcAssState 
			{
				get { return _vcAssState;}
				set
				{
					 _vcAssState = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcAssState"));
				}
			}						
							
			private Decimal? _nCharge; 
							 			
			public Decimal? nCharge 
			{
				get { return _nCharge;}
				set
				{
					 _nCharge = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nCharge"));
				}
			}						
							
			private Int32? _iIgValue; 
							 			
			public Int32? iIgValue 
			{
				get { return _iIgValue;}
				set
				{
					 _iIgValue = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgValue"));
				}
			}						
							
			private String _vcCardFlag; 
							 			
			public String vcCardFlag 
			{
				get { return _vcCardFlag;}
				set
				{
					 _vcCardFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardFlag"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private DateTime? _dtCreateDate; 
							 			
			public DateTime? dtCreateDate 
			{
				get { return _dtCreateDate;}
				set
				{
					 _dtCreateDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtCreateDate"));
				}
			}						
							
			private DateTime? _dtOperDate; 
							 			
			public DateTime? dtOperDate 
			{
				get { return _dtOperDate;}
				set
				{
					 _dtOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtOperDate"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
							
			private String _vcCardSerial; 
							 			
			public String vcCardSerial 
			{
				get { return _vcCardSerial;}
				set
				{
					 _vcCardSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardSerial"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbBillOfReceiveLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnReceiveSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnReceiveSerialNo 
			{
				get { return _cnnReceiveSerialNo;}
				set
				{
					 _cnnReceiveSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnReceiveSerialNo"));
				}
			}						
							
			private Decimal? _cnnMakeSerialNo; 
							 			
			public Decimal? cnnMakeSerialNo 
			{
				get { return _cnnMakeSerialNo;}
				set
				{
					 _cnnMakeSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMakeSerialNo"));
				}
			}						
							
			private String _cnvcReceiveDeptID; 
							 			
			public String cnvcReceiveDeptID 
			{
				get { return _cnvcReceiveDeptID;}
				set
				{
					 _cnvcReceiveDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcReceiveDeptID"));
				}
			}						
							
			private String _cnvcGroup; 
							 			
			public String cnvcGroup 
			{
				get { return _cnvcGroup;}
				set
				{
					 _cnvcGroup = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcGroup"));
				}
			}						
							
			private DateTime? _cndReceiveDate; 
							 			
			public DateTime? cndReceiveDate 
			{
				get { return _cndReceiveDate;}
				set
				{
					 _cndReceiveDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndReceiveDate"));
				}
			}						
							
			private String _cnvcClass; 
							 			
			public String cnvcClass 
			{
				get { return _cnvcClass;}
				set
				{
					 _cnvcClass = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcClass"));
				}
			}						
							
			private String _cnvcMaterialInchargeOperID; 
							 			
			public String cnvcMaterialInchargeOperID 
			{
				get { return _cnvcMaterialInchargeOperID;}
				set
				{
					 _cnvcMaterialInchargeOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcMaterialInchargeOperID"));
				}
			}						
							
			private String _cnvcStorageInchargeOperID; 
							 			
			public String cnvcStorageInchargeOperID 
			{
				get { return _cnvcStorageInchargeOperID;}
				set
				{
					 _cnvcStorageInchargeOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcStorageInchargeOperID"));
				}
			}						
							
			private String _cnvcSendOperID; 
							 			
			public String cnvcSendOperID 
			{
				get { return _cnvcSendOperID;}
				set
				{
					 _cnvcSendOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcSendOperID"));
				}
			}						
							
			private String _cnvcReceiveType; 
							 			
			public String cnvcReceiveType 
			{
				get { return _cnvcReceiveType;}
				set
				{
					 _cnvcReceiveType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcReceiveType"));
				}
			}						
							
			private String _cnvcBillState; 
							 			
			public String cnvcBillState 
			{
				get { return _cnvcBillState;}
				set
				{
					 _cnvcBillState = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcBillState"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbOrderBookDetail : INotifyPropertyChanged							
		{
						
			private Decimal _cnnOrderSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnOrderSerialNo 
			{
				get { return _cnnOrderSerialNo;}
				set
				{
					 _cnnOrderSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOrderSerialNo"));
				}
			}						
							
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private Decimal? _cnnOrderCount; 
							 			
			public Decimal? cnnOrderCount 
			{
				get { return _cnnOrderCount;}
				set
				{
					 _cnnOrderCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOrderCount"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnPrice; 
							 			
			public Decimal? cnnPrice 
			{
				get { return _cnnPrice;}
				set
				{
					 _cnnPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPrice"));
				}
			}						
							
			private Decimal? _cnnSum; 
							 			
			public Decimal? cnnSum 
			{
				get { return _cnnSum;}
				set
				{
					 _cnnSum = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSum"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private Decimal _cnnAssignCount; 
							 			
			public Decimal cnnAssignCount 
			{
				get { return _cnnAssignCount;}
				set
				{
					 _cnnAssignCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAssignCount"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbBill : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private Int64? _iAssID; 
							 			
			public Int64? iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private Decimal? _nTRate; 
							 			
			public Decimal? nTRate 
			{
				get { return _nTRate;}
				set
				{
					 _nTRate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nTRate"));
				}
			}						
							
			private Decimal? _nFee; 
							 			
			public Decimal? nFee 
			{
				get { return _nFee;}
				set
				{
					 _nFee = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFee"));
				}
			}						
							
			private Decimal? _nPay; 
							 			
			public Decimal? nPay 
			{
				get { return _nPay;}
				set
				{
					 _nPay = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nPay"));
				}
			}						
							
			private Decimal? _nBalance; 
							 			
			public Decimal? nBalance 
			{
				get { return _nBalance;}
				set
				{
					 _nBalance = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nBalance"));
				}
			}						
							
			private Int32? _iIgValue; 
							 			
			public Int32? iIgValue 
			{
				get { return _iIgValue;}
				set
				{
					 _iIgValue = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgValue"));
				}
			}						
							
			private String _vcConsType; 
							 			
			public String vcConsType 
			{
				get { return _vcConsType;}
				set
				{
					 _vcConsType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcConsType"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private DateTime? _dtConsDate; 
							 			
			public DateTime? dtConsDate 
			{
				get { return _dtConsDate;}
				set
				{
					 _dtConsDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtConsDate"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbBusiLog : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private Int64? _iAssID; 
							 			
			public Int64? iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private String _vcOperType; 
							 			
			public String vcOperType 
			{
				get { return _vcOperType;}
				set
				{
					 _vcOperType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperType"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private DateTime? _dtOperDate; 
							 			
			public DateTime? dtOperDate 
			{
				get { return _dtOperDate;}
				set
				{
					 _dtOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtOperDate"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbOrderReduceLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnReduceSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnReduceSerialNo 
			{
				get { return _cnnReduceSerialNo;}
				set
				{
					 _cnnReduceSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnReduceSerialNo"));
				}
			}						
							
			private Decimal _cnnOrderSerialNo; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public Decimal cnnOrderSerialNo 
			{
				get { return _cnnOrderSerialNo;}
				set
				{
					 _cnnOrderSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnOrderSerialNo"));
				}
			}						
							
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private Decimal? _cnnReduceCount; 
							 			
			public Decimal? cnnReduceCount 
			{
				get { return _cnnReduceCount;}
				set
				{
					 _cnnReduceCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnReduceCount"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnPrice; 
							 			
			public Decimal? cnnPrice 
			{
				get { return _cnnPrice;}
				set
				{
					 _cnnPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnPrice"));
				}
			}						
							
			private Decimal? _cnnSum; 
							 			
			public Decimal? cnnSum 
			{
				get { return _cnnSum;}
				set
				{
					 _cnnSum = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSum"));
				}
			}						
							
			private String _cnvcReduceType; 
							 			
			public String cnvcReduceType 
			{
				get { return _cnvcReduceType;}
				set
				{
					 _cnvcReduceType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcReduceType"));
				}
			}						
							
			private String _cnvcReduceState; 
							 			
			public String cnvcReduceState 
			{
				get { return _cnvcReduceState;}
				set
				{
					 _cnvcReduceState = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcReduceState"));
				}
			}						
							
			private String _cnvcReduceComments; 
							 			
			public String cnvcReduceComments 
			{
				get { return _cnvcReduceComments;}
				set
				{
					 _cnvcReduceComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcReduceComments"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbMoveDetail : INotifyPropertyChanged							
		{
						
			private Decimal _cnnMoveSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnMoveSerialNo 
			{
				get { return _cnnMoveSerialNo;}
				set
				{
					 _cnnMoveSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMoveSerialNo"));
				}
			}						
							
			private String _cnvcProductCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnMoveCount; 
							 			
			public Decimal? cnnMoveCount 
			{
				get { return _cnnMoveCount;}
				set
				{
					 _cnnMoveCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMoveCount"));
				}
			}						
							
			private Decimal? _cnnRealMoveCount; 
							 			
			public Decimal? cnnRealMoveCount 
			{
				get { return _cnnRealMoveCount;}
				set
				{
					 _cnnRealMoveCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnRealMoveCount"));
				}
			}						
							
			private String _cnvcComments; 
							 			
			public String cnvcComments 
			{
				get { return _cnvcComments;}
				set
				{
					 _cnvcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcComments"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbConsItem : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private String _vcGoodsID; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String vcGoodsID 
			{
				get { return _vcGoodsID;}
				set
				{
					 _vcGoodsID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcGoodsID"));
				}
			}						
							
			private Int64? _iAssID; 
							 			
			public Int64? iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private Decimal? _nPrice; 
							 			
			public Decimal? nPrice 
			{
				get { return _nPrice;}
				set
				{
					 _nPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nPrice"));
				}
			}						
							
			private Int32? _iCount; 
							 			
			public Int32? iCount 
			{
				get { return _iCount;}
				set
				{
					 _iCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iCount"));
				}
			}						
							
			private Decimal? _nTRate; 
							 			
			public Decimal? nTRate 
			{
				get { return _nTRate;}
				set
				{
					 _nTRate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nTRate"));
				}
			}						
							
			private Decimal? _nFee; 
							 			
			public Decimal? nFee 
			{
				get { return _nFee;}
				set
				{
					 _nFee = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nFee"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private String _cFlag; 
							 			
			public String cFlag 
			{
				get { return _cFlag;}
				set
				{
					 _cFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cFlag"));
				}
			}						
							
			private DateTime? _dtConsDate; 
							 			
			public DateTime? dtConsDate 
			{
				get { return _dtConsDate;}
				set
				{
					 _dtConsDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtConsDate"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbWarehouse : INotifyPropertyChanged							
		{
						
			private String _cnvcWhCode; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String cnvcWhCode 
			{
				get { return _cnvcWhCode;}
				set
				{
					 _cnvcWhCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcWhCode"));
				}
			}						
							
			private String _cnvcWhName; 
							 			
			public String cnvcWhName 
			{
				get { return _cnvcWhName;}
				set
				{
					 _cnvcWhName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcWhName"));
				}
			}						
							
			private String _cnvcDepID; 
							 			
			public String cnvcDepID 
			{
				get { return _cnvcDepID;}
				set
				{
					 _cnvcDepID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDepID"));
				}
			}						
							
			private String _cnvcWhAddress; 
							 			
			public String cnvcWhAddress 
			{
				get { return _cnvcWhAddress;}
				set
				{
					 _cnvcWhAddress = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcWhAddress"));
				}
			}						
							
			private String _cnvcWhPhone; 
							 			
			public String cnvcWhPhone 
			{
				get { return _cnvcWhPhone;}
				set
				{
					 _cnvcWhPhone = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcWhPhone"));
				}
			}						
							
			private String _cnvcWhPerson; 
							 			
			public String cnvcWhPerson 
			{
				get { return _cnvcWhPerson;}
				set
				{
					 _cnvcWhPerson = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcWhPerson"));
				}
			}						
							
			private String _cnvcWhComments; 
							 			
			public String cnvcWhComments 
			{
				get { return _cnvcWhComments;}
				set
				{
					 _cnvcWhComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcWhComments"));
				}
			}						
							
			private Boolean _cnbInvalid; 
							 			
			public Boolean cnbInvalid 
			{
				get { return _cnbInvalid;}
				set
				{
					 _cnbInvalid = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnbInvalid"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbOrderSerialNo : INotifyPropertyChanged							
		{
						
			private Decimal _cnnSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnSerialNo 
			{
				get { return _cnnSerialNo;}
				set
				{
					 _cnnSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnSerialNo"));
				}
			}						
							
			private String _cnvcFill; 
							 			
			public String cnvcFill 
			{
				get { return _cnvcFill;}
				set
				{
					 _cnvcFill = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcFill"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbConsSerialNo : INotifyPropertyChanged							
		{
						
			private Int64 _iSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerialNo 
			{
				get { return _iSerialNo;}
				set
				{
					 _iSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerialNo"));
				}
			}						
							
			private String _vcFill; 
							 			
			public String vcFill 
			{
				get { return _vcFill;}
				set
				{
					 _vcFill = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcFill"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbMoveLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnMoveSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnMoveSerialNo 
			{
				get { return _cnnMoveSerialNo;}
				set
				{
					 _cnnMoveSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnMoveSerialNo"));
				}
			}						
							
			private String _cnvcOutDeptID; 
							 			
			public String cnvcOutDeptID 
			{
				get { return _cnvcOutDeptID;}
				set
				{
					 _cnvcOutDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOutDeptID"));
				}
			}						
							
			private String _cnvcOutOperID; 
							 			
			public String cnvcOutOperID 
			{
				get { return _cnvcOutOperID;}
				set
				{
					 _cnvcOutOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOutOperID"));
				}
			}						
							
			private String _cnvcInDeptID; 
							 			
			public String cnvcInDeptID 
			{
				get { return _cnvcInDeptID;}
				set
				{
					 _cnvcInDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcInDeptID"));
				}
			}						
							
			private String _cnvcInOperID; 
							 			
			public String cnvcInOperID 
			{
				get { return _cnvcInOperID;}
				set
				{
					 _cnvcInOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcInOperID"));
				}
			}						
							
			private DateTime? _cndMoveDate; 
							 			
			public DateTime? cndMoveDate 
			{
				get { return _cndMoveDate;}
				set
				{
					 _cndMoveDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndMoveDate"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndOperDate; 
							 			
			public DateTime? cndOperDate 
			{
				get { return _cndOperDate;}
				set
				{
					 _cndOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndOperDate"));
				}
			}						
							
			private String _cnvcBillState; 
							 			
			public String cnvcBillState 
			{
				get { return _cnvcBillState;}
				set
				{
					 _cnvcBillState = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcBillState"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbGoods : INotifyPropertyChanged							
		{
						
			private String _vcGoodsID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcGoodsID 
			{
				get { return _vcGoodsID;}
				set
				{
					 _vcGoodsID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcGoodsID"));
				}
			}						
							
			private String _vcGoodsName; 
							 			
			public String vcGoodsName 
			{
				get { return _vcGoodsName;}
				set
				{
					 _vcGoodsName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcGoodsName"));
				}
			}						
							
			private String _vcSpell; 
							 			
			public String vcSpell 
			{
				get { return _vcSpell;}
				set
				{
					 _vcSpell = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcSpell"));
				}
			}						
							
			private Decimal? _nPrice; 
							 			
			public Decimal? nPrice 
			{
				get { return _nPrice;}
				set
				{
					 _nPrice = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nPrice"));
				}
			}						
							
			private Decimal? _nRate; 
							 			
			public Decimal? nRate 
			{
				get { return _nRate;}
				set
				{
					 _nRate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("nRate"));
				}
			}						
							
			private Int32? _iIgValue; 
							 			
			public Int32? iIgValue 
			{
				get { return _iIgValue;}
				set
				{
					 _iIgValue = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgValue"));
				}
			}						
							
			private String _cNewFlag; 
							 			
			public String cNewFlag 
			{
				get { return _cNewFlag;}
				set
				{
					 _cNewFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cNewFlag"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbSellLoseLog : INotifyPropertyChanged							
		{
						
			private Decimal _cnnLoseSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnLoseSerialNo 
			{
				get { return _cnnLoseSerialNo;}
				set
				{
					 _cnnLoseSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnLoseSerialNo"));
				}
			}						
							
			private Decimal? _cnnLinkSerialNo; 
							 			
			public Decimal? cnnLinkSerialNo 
			{
				get { return _cnnLinkSerialNo;}
				set
				{
					 _cnnLinkSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnLinkSerialNo"));
				}
			}						
							
			private String _cnvcDeptID; 
							 			
			public String cnvcDeptID 
			{
				get { return _cnvcDeptID;}
				set
				{
					 _cnvcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDeptID"));
				}
			}						
							
			private DateTime? _cndLoseDate; 
							 			
			public DateTime? cndLoseDate 
			{
				get { return _cndLoseDate;}
				set
				{
					 _cndLoseDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndLoseDate"));
				}
			}						
							
			private String _cnvcProductCode; 
							 			
			public String cnvcProductCode 
			{
				get { return _cnvcProductCode;}
				set
				{
					 _cnvcProductCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductCode"));
				}
			}						
							
			private String _cnvcProductName; 
							 			
			public String cnvcProductName 
			{
				get { return _cnvcProductName;}
				set
				{
					 _cnvcProductName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcProductName"));
				}
			}						
							
			private Decimal? _cnnLoseCount; 
							 			
			public Decimal? cnnLoseCount 
			{
				get { return _cnnLoseCount;}
				set
				{
					 _cnnLoseCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnLoseCount"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private String _cnvcLoseComments; 
							 			
			public String cnvcLoseComments 
			{
				get { return _cnvcLoseComments;}
				set
				{
					 _cnvcLoseComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcLoseComments"));
				}
			}						
							
			private String _cnvcWeather; 
							 			
			public String cnvcWeather 
			{
				get { return _cnvcWeather;}
				set
				{
					 _cnvcWeather = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcWeather"));
				}
			}						
							
			private String _cnvcLoseType; 
							 			
			public String cnvcLoseType 
			{
				get { return _cnvcLoseType;}
				set
				{
					 _cnvcLoseType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcLoseType"));
				}
			}						
							
			private String _cnvcDestroyFlag; 
							 			
			public String cnvcDestroyFlag 
			{
				get { return _cnvcDestroyFlag;}
				set
				{
					 _cnvcDestroyFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDestroyFlag"));
				}
			}						
							
			private String _cnvcOperID; 
							 			
			public String cnvcOperID 
			{
				get { return _cnvcOperID;}
				set
				{
					 _cnvcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcOperID"));
				}
			}						
							
			private DateTime? _cndLoseOperDate; 
							 			
			public DateTime? cndLoseOperDate 
			{
				get { return _cndLoseOperDate;}
				set
				{
					 _cndLoseOperDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndLoseOperDate"));
				}
			}						
							
			private String _cnvcDestroyOperID; 
							 			
			public String cnvcDestroyOperID 
			{
				get { return _cnvcDestroyOperID;}
				set
				{
					 _cnvcDestroyOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcDestroyOperID"));
				}
			}						
							
			private DateTime? _cndDestroyDate; 
							 			
			public DateTime? cndDestroyDate 
			{
				get { return _cndDestroyDate;}
				set
				{
					 _cndDestroyDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cndDestroyDate"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbIntegralLog : INotifyPropertyChanged							
		{
						
			private Int64 _iSerial; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 iSerial 
			{
				get { return _iSerial;}
				set
				{
					 _iSerial = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iSerial"));
				}
			}						
							
			private Int64 _iAssID; 
							 			
			public Int64 iAssID 
			{
				get { return _iAssID;}
				set
				{
					 _iAssID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iAssID"));
				}
			}						
							
			private String _vcCardID; 
							 			
			public String vcCardID 
			{
				get { return _vcCardID;}
				set
				{
					 _vcCardID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcCardID"));
				}
			}						
							
			private String _vcIgType; 
							 			
			public String vcIgType 
			{
				get { return _vcIgType;}
				set
				{
					 _vcIgType = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcIgType"));
				}
			}						
							
			private Int32? _iIgLast; 
							 			
			public Int32? iIgLast 
			{
				get { return _iIgLast;}
				set
				{
					 _iIgLast = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgLast"));
				}
			}						
							
			private Int32? _iIgGet; 
							 			
			public Int32? iIgGet 
			{
				get { return _iIgGet;}
				set
				{
					 _iIgGet = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgGet"));
				}
			}						
							
			private Int32? _iIgArrival; 
							 			
			public Int32? iIgArrival 
			{
				get { return _iIgArrival;}
				set
				{
					 _iIgArrival = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iIgArrival"));
				}
			}						
							
			private Int64? _iLinkCons; 
							 			
			public Int64? iLinkCons 
			{
				get { return _iLinkCons;}
				set
				{
					 _iLinkCons = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("iLinkCons"));
				}
			}						
							
			private DateTime? _dtIgDate; 
							 			
			public DateTime? dtIgDate 
			{
				get { return _dtIgDate;}
				set
				{
					 _dtIgDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtIgDate"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbProduceDetail : INotifyPropertyChanged							
		{
						
			private Decimal _cnnProduceSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnProduceSerialNo 
			{
				get { return _cnnProduceSerialNo;}
				set
				{
					 _cnnProduceSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnProduceSerialNo"));
				}
			}						
							
			private String _cnvcCode; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public String cnvcCode 
			{
				get { return _cnvcCode;}
				set
				{
					 _cnvcCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCode"));
				}
			}						
							
			private String _cnvcName; 
							 			
			public String cnvcName 
			{
				get { return _cnvcName;}
				set
				{
					 _cnvcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcName"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnCount; 
							 			
			public Decimal? cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbOper : INotifyPropertyChanged							
		{
						
			private String _vcOperID; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public String vcOperID 
			{
				get { return _vcOperID;}
				set
				{
					 _vcOperID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperID"));
				}
			}						
							
			private String _vcOperName; 
							 			
			public String vcOperName 
			{
				get { return _vcOperName;}
				set
				{
					 _vcOperName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcOperName"));
				}
			}						
							
			private String _vcLimit; 
							 			
			public String vcLimit 
			{
				get { return _vcLimit;}
				set
				{
					 _vcLimit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcLimit"));
				}
			}						
							
			private String _vcPwd; 
							 			
			public String vcPwd 
			{
				get { return _vcPwd;}
				set
				{
					 _vcPwd = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcPwd"));
				}
			}						
							
			private String _vcDeptID; 
							 			
			public String vcDeptID 
			{
				get { return _vcDeptID;}
				set
				{
					 _vcDeptID = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptID"));
				}
			}						
							
			private String _vcActiveFlag; 
							 			
			public String vcActiveFlag 
			{
				get { return _vcActiveFlag;}
				set
				{
					 _vcActiveFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcActiveFlag"));
				}
			}						
							
			private String _vcPwdBeginFlag; 
							 			
			public String vcPwdBeginFlag 
			{
				get { return _vcPwdBeginFlag;}
				set
				{
					 _vcPwdBeginFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcPwdBeginFlag"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbNotice : INotifyPropertyChanged							
		{
						
			private Int64 _id; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Int64 id 
			{
				get { return _id;}
				set
				{
					 _id = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("id"));
				}
			}						
							
			private String _vcComments; 
							 			
			public String vcComments 
			{
				get { return _vcComments;}
				set
				{
					 _vcComments = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcComments"));
				}
			}						
							
			private DateTime? _dtCreateDate; 
							 			
			public DateTime? dtCreateDate 
			{
				get { return _dtCreateDate;}
				set
				{
					 _dtCreateDate = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("dtCreateDate"));
				}
			}						
							
			private String _vcActiveFlag; 
							 			
			public String vcActiveFlag 
			{
				get { return _vcActiveFlag;}
				set
				{
					 _vcActiveFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcActiveFlag"));
				}
			}						
							
			private String _vcDeptFlag; 
							 			
			public String vcDeptFlag 
			{
				get { return _vcDeptFlag;}
				set
				{
					 _vcDeptFlag = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("vcDeptFlag"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			 			
		public class tbProduceDetailAdd : INotifyPropertyChanged							
		{
						
			private Decimal _cnnProduceSerialNo; 
						
			
			[Key]
			[Column(Order=0)]
			[Required()]									 			
			public Decimal cnnProduceSerialNo 
			{
				get { return _cnnProduceSerialNo;}
				set
				{
					 _cnnProduceSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnProduceSerialNo"));
				}
			}						
							
			private Decimal _cnnAddSerialNo; 
						
			
			[Key]
			[Column(Order=1)]
			[Required()]									 			
			public Decimal cnnAddSerialNo 
			{
				get { return _cnnAddSerialNo;}
				set
				{
					 _cnnAddSerialNo = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnAddSerialNo"));
				}
			}						
							
			private String _cnvcCode; 
						
			
			[Key]
			[Column(Order=2)]
			[Required()]									 			
			public String cnvcCode 
			{
				get { return _cnvcCode;}
				set
				{
					 _cnvcCode = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcCode"));
				}
			}						
							
			private String _cnvcName; 
							 			
			public String cnvcName 
			{
				get { return _cnvcName;}
				set
				{
					 _cnvcName = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcName"));
				}
			}						
							
			private String _cnvcUnit; 
							 			
			public String cnvcUnit 
			{
				get { return _cnvcUnit;}
				set
				{
					 _cnvcUnit = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcUnit"));
				}
			}						
							
			private Decimal? _cnnCount; 
							 			
			public Decimal? cnnCount 
			{
				get { return _cnnCount;}
				set
				{
					 _cnnCount = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnnCount"));
				}
			}						
							
			private String _cnvcState; 
							 			
			public String cnvcState 
			{
				get { return _cnvcState;}
				set
				{
					 _cnvcState = value;
					 OnPropertyChanged(new PropertyChangedEventArgs("cnvcState"));
				}
			}						
					
			public event PropertyChangedEventHandler PropertyChanged;
        	public void OnPropertyChanged(PropertyChangedEventArgs e)
        	{
	            if (PropertyChanged != null)
	                PropertyChanged(this, e);
        	}
		}							
			
		public partial class AMSCM:DbContext
		{
		 	
			public DbSet<tbProduceDetailReduce> tbProduceDetailReduce {get;set;}
		 	
			public DbSet<tbProduceLog> tbProduceLog {get;set;}
		 	
			public DbSet<tbProduceOrderLog> tbProduceOrderLog {get;set;}
		 	
			public DbSet<tbProductSerial> tbProductSerial {get;set;}
		 	
			public DbSet<dtproperties> dtproperties {get;set;}
		 	
			public DbSet<tbUnitInvert> tbUnitInvert {get;set;}
		 	
			public DbSet<tbCheckSerial> tbCheckSerial {get;set;}
		 	
			public DbSet<tbProductLostSerial> tbProductLostSerial {get;set;}
		 	
			public DbSet<tbStockDetail> tbStockDetail {get;set;}
		 	
			public DbSet<tbStockDetailLog> tbStockDetailLog {get;set;}
		 	
			public DbSet<tbProductLostSerialLog> tbProductLostSerialLog {get;set;}
		 	
			public DbSet<tbProductSerialLog> tbProductSerialLog {get;set;}
		 	
			public DbSet<tbLogin> tbLogin {get;set;}
		 	
			public DbSet<tbStockMain> tbStockMain {get;set;}
		 	
			public DbSet<tbCheckSerialLog> tbCheckSerialLog {get;set;}
		 	
			public DbSet<tbDataSoftUpdateLog> tbDataSoftUpdateLog {get;set;}
		 	
			public DbSet<tbSellDayCheckLog> tbSellDayCheckLog {get;set;}
		 	
			public DbSet<tbStockMainLog> tbStockMainLog {get;set;}
		 	
			public DbSet<tbMaterialEnter> tbMaterialEnter {get;set;}
		 	
			public DbSet<tbEmpSign> tbEmpSign {get;set;}
		 	
			public DbSet<tbFillFee> tbFillFee {get;set;}
		 	
			public DbSet<tbMaterialOut> tbMaterialOut {get;set;}
		 	
			public DbSet<tbEmployee> tbEmployee {get;set;}
		 	
			public DbSet<tbMaterialPara> tbMaterialPara {get;set;}
		 	
			public DbSet<tbMaterial> tbMaterial {get;set;}
		 	
			public DbSet<tbDosage> tbDosage {get;set;}
		 	
			public DbSet<tbMacAddress> tbMacAddress {get;set;}
		 	
			public DbSet<tbProductClass> tbProductClass {get;set;}
		 	
			public DbSet<tbConsItemOther> tbConsItemOther {get;set;}
		 	
			public DbSet<tbGroupGoods> tbGroupGoods {get;set;}
		 	
			public DbSet<tbSignList> tbSignList {get;set;}
		 	
			public DbSet<tbBillOther> tbBillOther {get;set;}
		 	
			public DbSet<tbIntegralLogOther> tbIntegralLogOther {get;set;}
		 	
			public DbSet<tbFillFeeOther> tbFillFeeOther {get;set;}
		 	
			public DbSet<tbBusiLogOther> tbBusiLogOther {get;set;}
		 	
			public DbSet<tbInventory> tbInventory {get;set;}
		 	
			public DbSet<tbMakeDetail> tbMakeDetail {get;set;}
		 	
			public DbSet<tbGroupMake> tbGroupMake {get;set;}
		 	
			public DbSet<tbComputationGroup> tbComputationGroup {get;set;}
		 	
			public DbSet<tbComputationUnit> tbComputationUnit {get;set;}
		 	
			public DbSet<tbRepAssDailyIGCharge> tbRepAssDailyIGCharge {get;set;}
		 	
			public DbSet<tbStockPlan> tbStockPlan {get;set;}
		 	
			public DbSet<tbStockPlanDetail> tbStockPlanDetail {get;set;}
		 	
			public DbSet<tbRepAssCount> tbRepAssCount {get;set;}
		 	
			public DbSet<tbProduceCheckLog> tbProduceCheckLog {get;set;}
		 	
			public DbSet<tbRepAssFill> tbRepAssFill {get;set;}
		 	
			public DbSet<tbBillHis> tbBillHis {get;set;}
		 	
			public DbSet<tbRepAssConsDaily> tbRepAssConsDaily {get;set;}
		 	
			public DbSet<tbBusiLogHis> tbBusiLogHis {get;set;}
		 	
			public DbSet<tbRepAssLarg> tbRepAssLarg {get;set;}
		 	
			public DbSet<tbConsItemHis> tbConsItemHis {get;set;}
		 	
			public DbSet<tbFunc> tbFunc {get;set;}
		 	
			public DbSet<tbRepAssSpecCons> tbRepAssSpecCons {get;set;}
		 	
			public DbSet<tbFillFeeHis> tbFillFeeHis {get;set;}
		 	
			public DbSet<tbOperFunc> tbOperFunc {get;set;}
		 	
			public DbSet<tbMonthlyBalance> tbMonthlyBalance {get;set;}
		 	
			public DbSet<tbOperLog> tbOperLog {get;set;}
		 	
			public DbSet<tbIntegralLogHis> tbIntegralLogHis {get;set;}
		 	
			public DbSet<tbAssignDetail> tbAssignDetail {get;set;}
		 	
			public DbSet<tbMonthlyBalanceLog> tbMonthlyBalanceLog {get;set;}
		 	
			public DbSet<tbAssignDetailLog> tbAssignDetailLog {get;set;}
		 	
			public DbSet<tbBespeakLog> tbBespeakLog {get;set;}
		 	
			public DbSet<tbBillOfEnterStorageLog> tbBillOfEnterStorageLog {get;set;}
		 	
			public DbSet<tbAssignLog> tbAssignLog {get;set;}
		 	
			public DbSet<tbDept> tbDept {get;set;}
		 	
			public DbSet<tbBillOfEnterStorageDetail> tbBillOfEnterStorageDetail {get;set;}
		 	
			public DbSet<tbFormula> tbFormula {get;set;}
		 	
			public DbSet<tbBusiIncomeReport> tbBusiIncomeReport {get;set;}
		 	
			public DbSet<tbSysErrorLog> tbSysErrorLog {get;set;}
		 	
			public DbSet<tbSellDayCheckDetail> tbSellDayCheckDetail {get;set;}
		 	
			public DbSet<tbAssociatorSync> tbAssociatorSync {get;set;}
		 	
			public DbSet<tbMakeLog> tbMakeLog {get;set;}
		 	
			public DbSet<tbAssociatorLog> tbAssociatorLog {get;set;}
		 	
			public DbSet<tbStorage> tbStorage {get;set;}
		 	
			public DbSet<tbNameCode> tbNameCode {get;set;}
		 	
			public DbSet<tbStorageLog> tbStorageLog {get;set;}
		 	
			public DbSet<tbBillOfMaterials> tbBillOfMaterials {get;set;}
		 	
			public DbSet<tbOperStandard> tbOperStandard {get;set;}
		 	
			public DbSet<tbCurrentStock> tbCurrentStock {get;set;}
		 	
			public DbSet<tbOrderAddLog> tbOrderAddLog {get;set;}
		 	
			public DbSet<tbBillOfReceiveDetail> tbBillOfReceiveDetail {get;set;}
		 	
			public DbSet<tbOrderBook> tbOrderBook {get;set;}
		 	
			public DbSet<tbSupplier> tbSupplier {get;set;}
		 	
			public DbSet<tbAssociator> tbAssociator {get;set;}
		 	
			public DbSet<tbBillOfReceiveLog> tbBillOfReceiveLog {get;set;}
		 	
			public DbSet<tbOrderBookDetail> tbOrderBookDetail {get;set;}
		 	
			public DbSet<tbBill> tbBill {get;set;}
		 	
			public DbSet<tbBusiLog> tbBusiLog {get;set;}
		 	
			public DbSet<tbOrderReduceLog> tbOrderReduceLog {get;set;}
		 	
			public DbSet<tbMoveDetail> tbMoveDetail {get;set;}
		 	
			public DbSet<tbConsItem> tbConsItem {get;set;}
		 	
			public DbSet<tbWarehouse> tbWarehouse {get;set;}
		 	
			public DbSet<tbOrderSerialNo> tbOrderSerialNo {get;set;}
		 	
			public DbSet<tbConsSerialNo> tbConsSerialNo {get;set;}
		 	
			public DbSet<tbMoveLog> tbMoveLog {get;set;}
		 	
			public DbSet<tbGoods> tbGoods {get;set;}
		 	
			public DbSet<tbSellLoseLog> tbSellLoseLog {get;set;}
		 	
			public DbSet<tbIntegralLog> tbIntegralLog {get;set;}
		 	
			public DbSet<tbProduceDetail> tbProduceDetail {get;set;}
		 	
			public DbSet<tbOper> tbOper {get;set;}
		 	
			public DbSet<tbNotice> tbNotice {get;set;}
		 	
			public DbSet<tbProduceDetailAdd> tbProduceDetailAdd {get;set;}
		
		}
}