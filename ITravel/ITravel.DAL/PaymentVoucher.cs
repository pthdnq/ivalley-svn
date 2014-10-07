
/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace ITravel.DAL
{
	public abstract class _PaymentVoucher : SqlClientEntity
	{
		public _PaymentVoucher()
		{
			this.QuerySource = "PaymentVoucher";
			this.MappingName = "PaymentVoucher";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PaymentVoucherLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int PaymentVoucherID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.PaymentVoucherID, PaymentVoucherID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PaymentVoucherLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter PaymentVoucherID
			{
				get
				{
					return new SqlParameter("@PaymentVoucherID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter VoucherNumber
			{
				get
				{
					return new SqlParameter("@VoucherNumber", SqlDbType.NVarChar, 10);
				}
			}
			
			public static SqlParameter Amount
			{
				get
				{
					return new SqlParameter("@Amount", SqlDbType.Decimal, 0);
				}
			}
			
			public static SqlParameter PaidFor
			{
				get
				{
					return new SqlParameter("@PaidFor", SqlDbType.NVarChar, 200);
				}
			}
			
			public static SqlParameter PassengerId
			{
				get
				{
					return new SqlParameter("@PassengerId", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter IsCheque
			{
				get
				{
					return new SqlParameter("@IsCheque", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter BankName
			{
				get
				{
					return new SqlParameter("@BankName", SqlDbType.NVarChar, 200);
				}
			}
			
			public static SqlParameter ChuqueDate
			{
				get
				{
					return new SqlParameter("@ChuqueDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter Reason
			{
				get
				{
					return new SqlParameter("@Reason", SqlDbType.NVarChar, 400);
				}
			}
			
			public static SqlParameter VoucherDate
			{
				get
				{
					return new SqlParameter("@VoucherDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter CreatedBy
			{
				get
				{
					return new SqlParameter("@CreatedBy", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter LastUpdatedDate
			{
				get
				{
					return new SqlParameter("@LastUpdatedDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter LastUpdatedBy
			{
				get
				{
					return new SqlParameter("@LastUpdatedBy", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string PaymentVoucherID = "PaymentVoucherID";
            public const string VoucherNumber = "VoucherNumber";
            public const string Amount = "Amount";
            public const string PaidFor = "PaidFor";
            public const string PassengerId = "PassengerId";
            public const string IsCheque = "IsCheque";
            public const string BankName = "BankName";
            public const string ChuqueDate = "ChuqueDate";
            public const string Reason = "Reason";
            public const string VoucherDate = "VoucherDate";
            public const string CreatedBy = "CreatedBy";
            public const string LastUpdatedDate = "LastUpdatedDate";
            public const string LastUpdatedBy = "LastUpdatedBy";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[PaymentVoucherID] = _PaymentVoucher.PropertyNames.PaymentVoucherID;
					ht[VoucherNumber] = _PaymentVoucher.PropertyNames.VoucherNumber;
					ht[Amount] = _PaymentVoucher.PropertyNames.Amount;
					ht[PaidFor] = _PaymentVoucher.PropertyNames.PaidFor;
					ht[PassengerId] = _PaymentVoucher.PropertyNames.PassengerId;
					ht[IsCheque] = _PaymentVoucher.PropertyNames.IsCheque;
					ht[BankName] = _PaymentVoucher.PropertyNames.BankName;
					ht[ChuqueDate] = _PaymentVoucher.PropertyNames.ChuqueDate;
					ht[Reason] = _PaymentVoucher.PropertyNames.Reason;
					ht[VoucherDate] = _PaymentVoucher.PropertyNames.VoucherDate;
					ht[CreatedBy] = _PaymentVoucher.PropertyNames.CreatedBy;
					ht[LastUpdatedDate] = _PaymentVoucher.PropertyNames.LastUpdatedDate;
					ht[LastUpdatedBy] = _PaymentVoucher.PropertyNames.LastUpdatedBy;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string PaymentVoucherID = "PaymentVoucherID";
            public const string VoucherNumber = "VoucherNumber";
            public const string Amount = "Amount";
            public const string PaidFor = "PaidFor";
            public const string PassengerId = "PassengerId";
            public const string IsCheque = "IsCheque";
            public const string BankName = "BankName";
            public const string ChuqueDate = "ChuqueDate";
            public const string Reason = "Reason";
            public const string VoucherDate = "VoucherDate";
            public const string CreatedBy = "CreatedBy";
            public const string LastUpdatedDate = "LastUpdatedDate";
            public const string LastUpdatedBy = "LastUpdatedBy";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[PaymentVoucherID] = _PaymentVoucher.ColumnNames.PaymentVoucherID;
					ht[VoucherNumber] = _PaymentVoucher.ColumnNames.VoucherNumber;
					ht[Amount] = _PaymentVoucher.ColumnNames.Amount;
					ht[PaidFor] = _PaymentVoucher.ColumnNames.PaidFor;
					ht[PassengerId] = _PaymentVoucher.ColumnNames.PassengerId;
					ht[IsCheque] = _PaymentVoucher.ColumnNames.IsCheque;
					ht[BankName] = _PaymentVoucher.ColumnNames.BankName;
					ht[ChuqueDate] = _PaymentVoucher.ColumnNames.ChuqueDate;
					ht[Reason] = _PaymentVoucher.ColumnNames.Reason;
					ht[VoucherDate] = _PaymentVoucher.ColumnNames.VoucherDate;
					ht[CreatedBy] = _PaymentVoucher.ColumnNames.CreatedBy;
					ht[LastUpdatedDate] = _PaymentVoucher.ColumnNames.LastUpdatedDate;
					ht[LastUpdatedBy] = _PaymentVoucher.ColumnNames.LastUpdatedBy;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string PaymentVoucherID = "s_PaymentVoucherID";
            public const string VoucherNumber = "s_VoucherNumber";
            public const string Amount = "s_Amount";
            public const string PaidFor = "s_PaidFor";
            public const string PassengerId = "s_PassengerId";
            public const string IsCheque = "s_IsCheque";
            public const string BankName = "s_BankName";
            public const string ChuqueDate = "s_ChuqueDate";
            public const string Reason = "s_Reason";
            public const string VoucherDate = "s_VoucherDate";
            public const string CreatedBy = "s_CreatedBy";
            public const string LastUpdatedDate = "s_LastUpdatedDate";
            public const string LastUpdatedBy = "s_LastUpdatedBy";

		}
		#endregion		
		
		#region Properties
	
		public virtual int PaymentVoucherID
	    {
			get
	        {
				return base.Getint(ColumnNames.PaymentVoucherID);
			}
			set
	        {
				base.Setint(ColumnNames.PaymentVoucherID, value);
			}
		}

		public virtual string VoucherNumber
	    {
			get
	        {
				return base.Getstring(ColumnNames.VoucherNumber);
			}
			set
	        {
				base.Setstring(ColumnNames.VoucherNumber, value);
			}
		}

		public virtual decimal Amount
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.Amount);
			}
			set
	        {
				base.Setdecimal(ColumnNames.Amount, value);
			}
		}

		public virtual string PaidFor
	    {
			get
	        {
				return base.Getstring(ColumnNames.PaidFor);
			}
			set
	        {
				base.Setstring(ColumnNames.PaidFor, value);
			}
		}

		public virtual int PassengerId
	    {
			get
	        {
				return base.Getint(ColumnNames.PassengerId);
			}
			set
	        {
				base.Setint(ColumnNames.PassengerId, value);
			}
		}

		public virtual bool IsCheque
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsCheque);
			}
			set
	        {
				base.Setbool(ColumnNames.IsCheque, value);
			}
		}

		public virtual string BankName
	    {
			get
	        {
				return base.Getstring(ColumnNames.BankName);
			}
			set
	        {
				base.Setstring(ColumnNames.BankName, value);
			}
		}

		public virtual DateTime ChuqueDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.ChuqueDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.ChuqueDate, value);
			}
		}

		public virtual string Reason
	    {
			get
	        {
				return base.Getstring(ColumnNames.Reason);
			}
			set
	        {
				base.Setstring(ColumnNames.Reason, value);
			}
		}

		public virtual DateTime VoucherDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.VoucherDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.VoucherDate, value);
			}
		}

		public virtual Guid CreatedBy
	    {
			get
	        {
				return base.GetGuid(ColumnNames.CreatedBy);
			}
			set
	        {
				base.SetGuid(ColumnNames.CreatedBy, value);
			}
		}

		public virtual DateTime LastUpdatedDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.LastUpdatedDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.LastUpdatedDate, value);
			}
		}

		public virtual Guid LastUpdatedBy
	    {
			get
	        {
				return base.GetGuid(ColumnNames.LastUpdatedBy);
			}
			set
	        {
				base.SetGuid(ColumnNames.LastUpdatedBy, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_PaymentVoucherID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PaymentVoucherID) ? string.Empty : base.GetintAsString(ColumnNames.PaymentVoucherID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PaymentVoucherID);
				else
					this.PaymentVoucherID = base.SetintAsString(ColumnNames.PaymentVoucherID, value);
			}
		}

		public virtual string s_VoucherNumber
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.VoucherNumber) ? string.Empty : base.GetstringAsString(ColumnNames.VoucherNumber);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.VoucherNumber);
				else
					this.VoucherNumber = base.SetstringAsString(ColumnNames.VoucherNumber, value);
			}
		}

		public virtual string s_Amount
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Amount) ? string.Empty : base.GetdecimalAsString(ColumnNames.Amount);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Amount);
				else
					this.Amount = base.SetdecimalAsString(ColumnNames.Amount, value);
			}
		}

		public virtual string s_PaidFor
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PaidFor) ? string.Empty : base.GetstringAsString(ColumnNames.PaidFor);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PaidFor);
				else
					this.PaidFor = base.SetstringAsString(ColumnNames.PaidFor, value);
			}
		}

		public virtual string s_PassengerId
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PassengerId) ? string.Empty : base.GetintAsString(ColumnNames.PassengerId);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PassengerId);
				else
					this.PassengerId = base.SetintAsString(ColumnNames.PassengerId, value);
			}
		}

		public virtual string s_IsCheque
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsCheque) ? string.Empty : base.GetboolAsString(ColumnNames.IsCheque);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsCheque);
				else
					this.IsCheque = base.SetboolAsString(ColumnNames.IsCheque, value);
			}
		}

		public virtual string s_BankName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BankName) ? string.Empty : base.GetstringAsString(ColumnNames.BankName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BankName);
				else
					this.BankName = base.SetstringAsString(ColumnNames.BankName, value);
			}
		}

		public virtual string s_ChuqueDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ChuqueDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.ChuqueDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ChuqueDate);
				else
					this.ChuqueDate = base.SetDateTimeAsString(ColumnNames.ChuqueDate, value);
			}
		}

		public virtual string s_Reason
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Reason) ? string.Empty : base.GetstringAsString(ColumnNames.Reason);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Reason);
				else
					this.Reason = base.SetstringAsString(ColumnNames.Reason, value);
			}
		}

		public virtual string s_VoucherDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.VoucherDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.VoucherDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.VoucherDate);
				else
					this.VoucherDate = base.SetDateTimeAsString(ColumnNames.VoucherDate, value);
			}
		}

		public virtual string s_CreatedBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreatedBy) ? string.Empty : base.GetGuidAsString(ColumnNames.CreatedBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreatedBy);
				else
					this.CreatedBy = base.SetGuidAsString(ColumnNames.CreatedBy, value);
			}
		}

		public virtual string s_LastUpdatedDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LastUpdatedDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.LastUpdatedDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LastUpdatedDate);
				else
					this.LastUpdatedDate = base.SetDateTimeAsString(ColumnNames.LastUpdatedDate, value);
			}
		}

		public virtual string s_LastUpdatedBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LastUpdatedBy) ? string.Empty : base.GetGuidAsString(ColumnNames.LastUpdatedBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LastUpdatedBy);
				else
					this.LastUpdatedBy = base.SetGuidAsString(ColumnNames.LastUpdatedBy, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter PaymentVoucherID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PaymentVoucherID, Parameters.PaymentVoucherID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter VoucherNumber
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.VoucherNumber, Parameters.VoucherNumber);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Amount
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Amount, Parameters.Amount);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PaidFor
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PaidFor, Parameters.PaidFor);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PassengerId
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PassengerId, Parameters.PassengerId);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsCheque
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsCheque, Parameters.IsCheque);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BankName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BankName, Parameters.BankName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ChuqueDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ChuqueDate, Parameters.ChuqueDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Reason
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Reason, Parameters.Reason);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter VoucherDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.VoucherDate, Parameters.VoucherDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CreatedBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreatedBy, Parameters.CreatedBy);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter LastUpdatedDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LastUpdatedDate, Parameters.LastUpdatedDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter LastUpdatedBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LastUpdatedBy, Parameters.LastUpdatedBy);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter PaymentVoucherID
		    {
				get
		        {
					if(_PaymentVoucherID_W == null)
	        	    {
						_PaymentVoucherID_W = TearOff.PaymentVoucherID;
					}
					return _PaymentVoucherID_W;
				}
			}

			public WhereParameter VoucherNumber
		    {
				get
		        {
					if(_VoucherNumber_W == null)
	        	    {
						_VoucherNumber_W = TearOff.VoucherNumber;
					}
					return _VoucherNumber_W;
				}
			}

			public WhereParameter Amount
		    {
				get
		        {
					if(_Amount_W == null)
	        	    {
						_Amount_W = TearOff.Amount;
					}
					return _Amount_W;
				}
			}

			public WhereParameter PaidFor
		    {
				get
		        {
					if(_PaidFor_W == null)
	        	    {
						_PaidFor_W = TearOff.PaidFor;
					}
					return _PaidFor_W;
				}
			}

			public WhereParameter PassengerId
		    {
				get
		        {
					if(_PassengerId_W == null)
	        	    {
						_PassengerId_W = TearOff.PassengerId;
					}
					return _PassengerId_W;
				}
			}

			public WhereParameter IsCheque
		    {
				get
		        {
					if(_IsCheque_W == null)
	        	    {
						_IsCheque_W = TearOff.IsCheque;
					}
					return _IsCheque_W;
				}
			}

			public WhereParameter BankName
		    {
				get
		        {
					if(_BankName_W == null)
	        	    {
						_BankName_W = TearOff.BankName;
					}
					return _BankName_W;
				}
			}

			public WhereParameter ChuqueDate
		    {
				get
		        {
					if(_ChuqueDate_W == null)
	        	    {
						_ChuqueDate_W = TearOff.ChuqueDate;
					}
					return _ChuqueDate_W;
				}
			}

			public WhereParameter Reason
		    {
				get
		        {
					if(_Reason_W == null)
	        	    {
						_Reason_W = TearOff.Reason;
					}
					return _Reason_W;
				}
			}

			public WhereParameter VoucherDate
		    {
				get
		        {
					if(_VoucherDate_W == null)
	        	    {
						_VoucherDate_W = TearOff.VoucherDate;
					}
					return _VoucherDate_W;
				}
			}

			public WhereParameter CreatedBy
		    {
				get
		        {
					if(_CreatedBy_W == null)
	        	    {
						_CreatedBy_W = TearOff.CreatedBy;
					}
					return _CreatedBy_W;
				}
			}

			public WhereParameter LastUpdatedDate
		    {
				get
		        {
					if(_LastUpdatedDate_W == null)
	        	    {
						_LastUpdatedDate_W = TearOff.LastUpdatedDate;
					}
					return _LastUpdatedDate_W;
				}
			}

			public WhereParameter LastUpdatedBy
		    {
				get
		        {
					if(_LastUpdatedBy_W == null)
	        	    {
						_LastUpdatedBy_W = TearOff.LastUpdatedBy;
					}
					return _LastUpdatedBy_W;
				}
			}

			private WhereParameter _PaymentVoucherID_W = null;
			private WhereParameter _VoucherNumber_W = null;
			private WhereParameter _Amount_W = null;
			private WhereParameter _PaidFor_W = null;
			private WhereParameter _PassengerId_W = null;
			private WhereParameter _IsCheque_W = null;
			private WhereParameter _BankName_W = null;
			private WhereParameter _ChuqueDate_W = null;
			private WhereParameter _Reason_W = null;
			private WhereParameter _VoucherDate_W = null;
			private WhereParameter _CreatedBy_W = null;
			private WhereParameter _LastUpdatedDate_W = null;
			private WhereParameter _LastUpdatedBy_W = null;

			public void WhereClauseReset()
			{
				_PaymentVoucherID_W = null;
				_VoucherNumber_W = null;
				_Amount_W = null;
				_PaidFor_W = null;
				_PassengerId_W = null;
				_IsCheque_W = null;
				_BankName_W = null;
				_ChuqueDate_W = null;
				_Reason_W = null;
				_VoucherDate_W = null;
				_CreatedBy_W = null;
				_LastUpdatedDate_W = null;
				_LastUpdatedBy_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter PaymentVoucherID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PaymentVoucherID, Parameters.PaymentVoucherID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter VoucherNumber
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.VoucherNumber, Parameters.VoucherNumber);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Amount
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Amount, Parameters.Amount);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PaidFor
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PaidFor, Parameters.PaidFor);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PassengerId
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PassengerId, Parameters.PassengerId);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsCheque
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsCheque, Parameters.IsCheque);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BankName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BankName, Parameters.BankName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ChuqueDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ChuqueDate, Parameters.ChuqueDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Reason
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Reason, Parameters.Reason);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter VoucherDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.VoucherDate, Parameters.VoucherDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CreatedBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreatedBy, Parameters.CreatedBy);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter LastUpdatedDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LastUpdatedDate, Parameters.LastUpdatedDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter LastUpdatedBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LastUpdatedBy, Parameters.LastUpdatedBy);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter PaymentVoucherID
		    {
				get
		        {
					if(_PaymentVoucherID_W == null)
	        	    {
						_PaymentVoucherID_W = TearOff.PaymentVoucherID;
					}
					return _PaymentVoucherID_W;
				}
			}

			public AggregateParameter VoucherNumber
		    {
				get
		        {
					if(_VoucherNumber_W == null)
	        	    {
						_VoucherNumber_W = TearOff.VoucherNumber;
					}
					return _VoucherNumber_W;
				}
			}

			public AggregateParameter Amount
		    {
				get
		        {
					if(_Amount_W == null)
	        	    {
						_Amount_W = TearOff.Amount;
					}
					return _Amount_W;
				}
			}

			public AggregateParameter PaidFor
		    {
				get
		        {
					if(_PaidFor_W == null)
	        	    {
						_PaidFor_W = TearOff.PaidFor;
					}
					return _PaidFor_W;
				}
			}

			public AggregateParameter PassengerId
		    {
				get
		        {
					if(_PassengerId_W == null)
	        	    {
						_PassengerId_W = TearOff.PassengerId;
					}
					return _PassengerId_W;
				}
			}

			public AggregateParameter IsCheque
		    {
				get
		        {
					if(_IsCheque_W == null)
	        	    {
						_IsCheque_W = TearOff.IsCheque;
					}
					return _IsCheque_W;
				}
			}

			public AggregateParameter BankName
		    {
				get
		        {
					if(_BankName_W == null)
	        	    {
						_BankName_W = TearOff.BankName;
					}
					return _BankName_W;
				}
			}

			public AggregateParameter ChuqueDate
		    {
				get
		        {
					if(_ChuqueDate_W == null)
	        	    {
						_ChuqueDate_W = TearOff.ChuqueDate;
					}
					return _ChuqueDate_W;
				}
			}

			public AggregateParameter Reason
		    {
				get
		        {
					if(_Reason_W == null)
	        	    {
						_Reason_W = TearOff.Reason;
					}
					return _Reason_W;
				}
			}

			public AggregateParameter VoucherDate
		    {
				get
		        {
					if(_VoucherDate_W == null)
	        	    {
						_VoucherDate_W = TearOff.VoucherDate;
					}
					return _VoucherDate_W;
				}
			}

			public AggregateParameter CreatedBy
		    {
				get
		        {
					if(_CreatedBy_W == null)
	        	    {
						_CreatedBy_W = TearOff.CreatedBy;
					}
					return _CreatedBy_W;
				}
			}

			public AggregateParameter LastUpdatedDate
		    {
				get
		        {
					if(_LastUpdatedDate_W == null)
	        	    {
						_LastUpdatedDate_W = TearOff.LastUpdatedDate;
					}
					return _LastUpdatedDate_W;
				}
			}

			public AggregateParameter LastUpdatedBy
		    {
				get
		        {
					if(_LastUpdatedBy_W == null)
	        	    {
						_LastUpdatedBy_W = TearOff.LastUpdatedBy;
					}
					return _LastUpdatedBy_W;
				}
			}

			private AggregateParameter _PaymentVoucherID_W = null;
			private AggregateParameter _VoucherNumber_W = null;
			private AggregateParameter _Amount_W = null;
			private AggregateParameter _PaidFor_W = null;
			private AggregateParameter _PassengerId_W = null;
			private AggregateParameter _IsCheque_W = null;
			private AggregateParameter _BankName_W = null;
			private AggregateParameter _ChuqueDate_W = null;
			private AggregateParameter _Reason_W = null;
			private AggregateParameter _VoucherDate_W = null;
			private AggregateParameter _CreatedBy_W = null;
			private AggregateParameter _LastUpdatedDate_W = null;
			private AggregateParameter _LastUpdatedBy_W = null;

			public void AggregateClauseReset()
			{
				_PaymentVoucherID_W = null;
				_VoucherNumber_W = null;
				_Amount_W = null;
				_PaidFor_W = null;
				_PassengerId_W = null;
				_IsCheque_W = null;
				_BankName_W = null;
				_ChuqueDate_W = null;
				_Reason_W = null;
				_VoucherDate_W = null;
				_CreatedBy_W = null;
				_LastUpdatedDate_W = null;
				_LastUpdatedBy_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PaymentVoucherInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.PaymentVoucherID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PaymentVoucherUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PaymentVoucherDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.PaymentVoucherID);
			p.SourceColumn = ColumnNames.PaymentVoucherID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.PaymentVoucherID);
			p.SourceColumn = ColumnNames.PaymentVoucherID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.VoucherNumber);
			p.SourceColumn = ColumnNames.VoucherNumber;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Amount);
			p.SourceColumn = ColumnNames.Amount;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PaidFor);
			p.SourceColumn = ColumnNames.PaidFor;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PassengerId);
			p.SourceColumn = ColumnNames.PassengerId;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsCheque);
			p.SourceColumn = ColumnNames.IsCheque;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BankName);
			p.SourceColumn = ColumnNames.BankName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ChuqueDate);
			p.SourceColumn = ColumnNames.ChuqueDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Reason);
			p.SourceColumn = ColumnNames.Reason;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.VoucherDate);
			p.SourceColumn = ColumnNames.VoucherDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreatedBy);
			p.SourceColumn = ColumnNames.CreatedBy;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LastUpdatedDate);
			p.SourceColumn = ColumnNames.LastUpdatedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LastUpdatedBy);
			p.SourceColumn = ColumnNames.LastUpdatedBy;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
