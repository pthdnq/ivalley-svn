
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

namespace Pricing.DAL
{
	public abstract class _PackageDetails : SqlClientEntity
	{
		public _PackageDetails()
		{
			this.QuerySource = "PackageDetails";
			this.MappingName = "PackageDetails";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PackageDetailsLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int PackageDetailsID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.PackageDetailsID, PackageDetailsID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PackageDetailsLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter PackID
			{
				get
				{
					return new SqlParameter("@PackID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Trade_Code
			{
				get
				{
					return new SqlParameter("@Trade_Code", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PackageDetailsID
			{
				get
				{
					return new SqlParameter("@PackageDetailsID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Unit_key
			{
				get
				{
					return new SqlParameter("@Unit_key", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Sub_unit
			{
				get
				{
					return new SqlParameter("@Sub_unit", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Conver_sub
			{
				get
				{
					return new SqlParameter("@Conver_sub", SqlDbType.Decimal, 0);
				}
			}
			
			public static SqlParameter Unit_price
			{
				get
				{
					return new SqlParameter("@Unit_price", SqlDbType.Money, 0);
				}
			}
			
			public static SqlParameter SuggestedPrice
			{
				get
				{
					return new SqlParameter("@SuggestedPrice", SqlDbType.Money, 0);
				}
			}
			
			public static SqlParameter FinalPrice
			{
				get
				{
					return new SqlParameter("@FinalPrice", SqlDbType.Money, 0);
				}
			}
			
			public static SqlParameter IsSync
			{
				get
				{
					return new SqlParameter("@IsSync", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string PackID = "PackID";
            public const string Trade_Code = "Trade_Code";
            public const string PackageDetailsID = "PackageDetailsID";
            public const string Unit_key = "unit_key";
            public const string Sub_unit = "sub_unit";
            public const string Conver_sub = "conver_sub";
            public const string Unit_price = "unit_price";
            public const string SuggestedPrice = "SuggestedPrice";
            public const string FinalPrice = "FinalPrice";
            public const string IsSync = "IsSync";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[PackID] = _PackageDetails.PropertyNames.PackID;
					ht[Trade_Code] = _PackageDetails.PropertyNames.Trade_Code;
					ht[PackageDetailsID] = _PackageDetails.PropertyNames.PackageDetailsID;
					ht[Unit_key] = _PackageDetails.PropertyNames.Unit_key;
					ht[Sub_unit] = _PackageDetails.PropertyNames.Sub_unit;
					ht[Conver_sub] = _PackageDetails.PropertyNames.Conver_sub;
					ht[Unit_price] = _PackageDetails.PropertyNames.Unit_price;
					ht[SuggestedPrice] = _PackageDetails.PropertyNames.SuggestedPrice;
					ht[FinalPrice] = _PackageDetails.PropertyNames.FinalPrice;
					ht[IsSync] = _PackageDetails.PropertyNames.IsSync;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string PackID = "PackID";
            public const string Trade_Code = "Trade_Code";
            public const string PackageDetailsID = "PackageDetailsID";
            public const string Unit_key = "Unit_key";
            public const string Sub_unit = "Sub_unit";
            public const string Conver_sub = "Conver_sub";
            public const string Unit_price = "Unit_price";
            public const string SuggestedPrice = "SuggestedPrice";
            public const string FinalPrice = "FinalPrice";
            public const string IsSync = "IsSync";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[PackID] = _PackageDetails.ColumnNames.PackID;
					ht[Trade_Code] = _PackageDetails.ColumnNames.Trade_Code;
					ht[PackageDetailsID] = _PackageDetails.ColumnNames.PackageDetailsID;
					ht[Unit_key] = _PackageDetails.ColumnNames.Unit_key;
					ht[Sub_unit] = _PackageDetails.ColumnNames.Sub_unit;
					ht[Conver_sub] = _PackageDetails.ColumnNames.Conver_sub;
					ht[Unit_price] = _PackageDetails.ColumnNames.Unit_price;
					ht[SuggestedPrice] = _PackageDetails.ColumnNames.SuggestedPrice;
					ht[FinalPrice] = _PackageDetails.ColumnNames.FinalPrice;
					ht[IsSync] = _PackageDetails.ColumnNames.IsSync;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string PackID = "s_PackID";
            public const string Trade_Code = "s_Trade_Code";
            public const string PackageDetailsID = "s_PackageDetailsID";
            public const string Unit_key = "s_Unit_key";
            public const string Sub_unit = "s_Sub_unit";
            public const string Conver_sub = "s_Conver_sub";
            public const string Unit_price = "s_Unit_price";
            public const string SuggestedPrice = "s_SuggestedPrice";
            public const string FinalPrice = "s_FinalPrice";
            public const string IsSync = "s_IsSync";

		}
		#endregion		
		
		#region Properties
	
		public virtual int PackID
	    {
			get
	        {
				return base.Getint(ColumnNames.PackID);
			}
			set
	        {
				base.Setint(ColumnNames.PackID, value);
			}
		}

		public virtual int Trade_Code
	    {
			get
	        {
				return base.Getint(ColumnNames.Trade_Code);
			}
			set
	        {
				base.Setint(ColumnNames.Trade_Code, value);
			}
		}

		public virtual int PackageDetailsID
	    {
			get
	        {
				return base.Getint(ColumnNames.PackageDetailsID);
			}
			set
	        {
				base.Setint(ColumnNames.PackageDetailsID, value);
			}
		}

		public virtual int Unit_key
	    {
			get
	        {
				return base.Getint(ColumnNames.Unit_key);
			}
			set
	        {
				base.Setint(ColumnNames.Unit_key, value);
			}
		}

		public virtual int Sub_unit
	    {
			get
	        {
				return base.Getint(ColumnNames.Sub_unit);
			}
			set
	        {
				base.Setint(ColumnNames.Sub_unit, value);
			}
		}

		public virtual decimal Conver_sub
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.Conver_sub);
			}
			set
	        {
				base.Setdecimal(ColumnNames.Conver_sub, value);
			}
		}

		public virtual decimal Unit_price
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.Unit_price);
			}
			set
	        {
				base.Setdecimal(ColumnNames.Unit_price, value);
			}
		}

		public virtual decimal SuggestedPrice
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.SuggestedPrice);
			}
			set
	        {
				base.Setdecimal(ColumnNames.SuggestedPrice, value);
			}
		}

		public virtual decimal FinalPrice
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.FinalPrice);
			}
			set
	        {
				base.Setdecimal(ColumnNames.FinalPrice, value);
			}
		}

		public virtual bool IsSync
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsSync);
			}
			set
	        {
				base.Setbool(ColumnNames.IsSync, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_PackID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PackID) ? string.Empty : base.GetintAsString(ColumnNames.PackID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PackID);
				else
					this.PackID = base.SetintAsString(ColumnNames.PackID, value);
			}
		}

		public virtual string s_Trade_Code
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Trade_Code) ? string.Empty : base.GetintAsString(ColumnNames.Trade_Code);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Trade_Code);
				else
					this.Trade_Code = base.SetintAsString(ColumnNames.Trade_Code, value);
			}
		}

		public virtual string s_PackageDetailsID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PackageDetailsID) ? string.Empty : base.GetintAsString(ColumnNames.PackageDetailsID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PackageDetailsID);
				else
					this.PackageDetailsID = base.SetintAsString(ColumnNames.PackageDetailsID, value);
			}
		}

		public virtual string s_Unit_key
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Unit_key) ? string.Empty : base.GetintAsString(ColumnNames.Unit_key);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Unit_key);
				else
					this.Unit_key = base.SetintAsString(ColumnNames.Unit_key, value);
			}
		}

		public virtual string s_Sub_unit
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Sub_unit) ? string.Empty : base.GetintAsString(ColumnNames.Sub_unit);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Sub_unit);
				else
					this.Sub_unit = base.SetintAsString(ColumnNames.Sub_unit, value);
			}
		}

		public virtual string s_Conver_sub
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Conver_sub) ? string.Empty : base.GetdecimalAsString(ColumnNames.Conver_sub);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Conver_sub);
				else
					this.Conver_sub = base.SetdecimalAsString(ColumnNames.Conver_sub, value);
			}
		}

		public virtual string s_Unit_price
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Unit_price) ? string.Empty : base.GetdecimalAsString(ColumnNames.Unit_price);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Unit_price);
				else
					this.Unit_price = base.SetdecimalAsString(ColumnNames.Unit_price, value);
			}
		}

		public virtual string s_SuggestedPrice
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SuggestedPrice) ? string.Empty : base.GetdecimalAsString(ColumnNames.SuggestedPrice);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SuggestedPrice);
				else
					this.SuggestedPrice = base.SetdecimalAsString(ColumnNames.SuggestedPrice, value);
			}
		}

		public virtual string s_FinalPrice
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.FinalPrice) ? string.Empty : base.GetdecimalAsString(ColumnNames.FinalPrice);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.FinalPrice);
				else
					this.FinalPrice = base.SetdecimalAsString(ColumnNames.FinalPrice, value);
			}
		}

		public virtual string s_IsSync
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsSync) ? string.Empty : base.GetboolAsString(ColumnNames.IsSync);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsSync);
				else
					this.IsSync = base.SetboolAsString(ColumnNames.IsSync, value);
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
				
				
				public WhereParameter PackID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PackID, Parameters.PackID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Trade_Code
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Trade_Code, Parameters.Trade_Code);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PackageDetailsID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PackageDetailsID, Parameters.PackageDetailsID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Unit_key
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Unit_key, Parameters.Unit_key);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Sub_unit
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Sub_unit, Parameters.Sub_unit);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Conver_sub
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Conver_sub, Parameters.Conver_sub);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Unit_price
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Unit_price, Parameters.Unit_price);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter SuggestedPrice
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SuggestedPrice, Parameters.SuggestedPrice);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter FinalPrice
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.FinalPrice, Parameters.FinalPrice);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsSync
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsSync, Parameters.IsSync);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter PackID
		    {
				get
		        {
					if(_PackID_W == null)
	        	    {
						_PackID_W = TearOff.PackID;
					}
					return _PackID_W;
				}
			}

			public WhereParameter Trade_Code
		    {
				get
		        {
					if(_Trade_Code_W == null)
	        	    {
						_Trade_Code_W = TearOff.Trade_Code;
					}
					return _Trade_Code_W;
				}
			}

			public WhereParameter PackageDetailsID
		    {
				get
		        {
					if(_PackageDetailsID_W == null)
	        	    {
						_PackageDetailsID_W = TearOff.PackageDetailsID;
					}
					return _PackageDetailsID_W;
				}
			}

			public WhereParameter Unit_key
		    {
				get
		        {
					if(_Unit_key_W == null)
	        	    {
						_Unit_key_W = TearOff.Unit_key;
					}
					return _Unit_key_W;
				}
			}

			public WhereParameter Sub_unit
		    {
				get
		        {
					if(_Sub_unit_W == null)
	        	    {
						_Sub_unit_W = TearOff.Sub_unit;
					}
					return _Sub_unit_W;
				}
			}

			public WhereParameter Conver_sub
		    {
				get
		        {
					if(_Conver_sub_W == null)
	        	    {
						_Conver_sub_W = TearOff.Conver_sub;
					}
					return _Conver_sub_W;
				}
			}

			public WhereParameter Unit_price
		    {
				get
		        {
					if(_Unit_price_W == null)
	        	    {
						_Unit_price_W = TearOff.Unit_price;
					}
					return _Unit_price_W;
				}
			}

			public WhereParameter SuggestedPrice
		    {
				get
		        {
					if(_SuggestedPrice_W == null)
	        	    {
						_SuggestedPrice_W = TearOff.SuggestedPrice;
					}
					return _SuggestedPrice_W;
				}
			}

			public WhereParameter FinalPrice
		    {
				get
		        {
					if(_FinalPrice_W == null)
	        	    {
						_FinalPrice_W = TearOff.FinalPrice;
					}
					return _FinalPrice_W;
				}
			}

			public WhereParameter IsSync
		    {
				get
		        {
					if(_IsSync_W == null)
	        	    {
						_IsSync_W = TearOff.IsSync;
					}
					return _IsSync_W;
				}
			}

			private WhereParameter _PackID_W = null;
			private WhereParameter _Trade_Code_W = null;
			private WhereParameter _PackageDetailsID_W = null;
			private WhereParameter _Unit_key_W = null;
			private WhereParameter _Sub_unit_W = null;
			private WhereParameter _Conver_sub_W = null;
			private WhereParameter _Unit_price_W = null;
			private WhereParameter _SuggestedPrice_W = null;
			private WhereParameter _FinalPrice_W = null;
			private WhereParameter _IsSync_W = null;

			public void WhereClauseReset()
			{
				_PackID_W = null;
				_Trade_Code_W = null;
				_PackageDetailsID_W = null;
				_Unit_key_W = null;
				_Sub_unit_W = null;
				_Conver_sub_W = null;
				_Unit_price_W = null;
				_SuggestedPrice_W = null;
				_FinalPrice_W = null;
				_IsSync_W = null;

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
				
				
				public AggregateParameter PackID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PackID, Parameters.PackID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Trade_Code
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Trade_Code, Parameters.Trade_Code);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PackageDetailsID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PackageDetailsID, Parameters.PackageDetailsID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Unit_key
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Unit_key, Parameters.Unit_key);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Sub_unit
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Sub_unit, Parameters.Sub_unit);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Conver_sub
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Conver_sub, Parameters.Conver_sub);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Unit_price
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Unit_price, Parameters.Unit_price);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter SuggestedPrice
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SuggestedPrice, Parameters.SuggestedPrice);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter FinalPrice
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.FinalPrice, Parameters.FinalPrice);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsSync
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsSync, Parameters.IsSync);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter PackID
		    {
				get
		        {
					if(_PackID_W == null)
	        	    {
						_PackID_W = TearOff.PackID;
					}
					return _PackID_W;
				}
			}

			public AggregateParameter Trade_Code
		    {
				get
		        {
					if(_Trade_Code_W == null)
	        	    {
						_Trade_Code_W = TearOff.Trade_Code;
					}
					return _Trade_Code_W;
				}
			}

			public AggregateParameter PackageDetailsID
		    {
				get
		        {
					if(_PackageDetailsID_W == null)
	        	    {
						_PackageDetailsID_W = TearOff.PackageDetailsID;
					}
					return _PackageDetailsID_W;
				}
			}

			public AggregateParameter Unit_key
		    {
				get
		        {
					if(_Unit_key_W == null)
	        	    {
						_Unit_key_W = TearOff.Unit_key;
					}
					return _Unit_key_W;
				}
			}

			public AggregateParameter Sub_unit
		    {
				get
		        {
					if(_Sub_unit_W == null)
	        	    {
						_Sub_unit_W = TearOff.Sub_unit;
					}
					return _Sub_unit_W;
				}
			}

			public AggregateParameter Conver_sub
		    {
				get
		        {
					if(_Conver_sub_W == null)
	        	    {
						_Conver_sub_W = TearOff.Conver_sub;
					}
					return _Conver_sub_W;
				}
			}

			public AggregateParameter Unit_price
		    {
				get
		        {
					if(_Unit_price_W == null)
	        	    {
						_Unit_price_W = TearOff.Unit_price;
					}
					return _Unit_price_W;
				}
			}

			public AggregateParameter SuggestedPrice
		    {
				get
		        {
					if(_SuggestedPrice_W == null)
	        	    {
						_SuggestedPrice_W = TearOff.SuggestedPrice;
					}
					return _SuggestedPrice_W;
				}
			}

			public AggregateParameter FinalPrice
		    {
				get
		        {
					if(_FinalPrice_W == null)
	        	    {
						_FinalPrice_W = TearOff.FinalPrice;
					}
					return _FinalPrice_W;
				}
			}

			public AggregateParameter IsSync
		    {
				get
		        {
					if(_IsSync_W == null)
	        	    {
						_IsSync_W = TearOff.IsSync;
					}
					return _IsSync_W;
				}
			}

			private AggregateParameter _PackID_W = null;
			private AggregateParameter _Trade_Code_W = null;
			private AggregateParameter _PackageDetailsID_W = null;
			private AggregateParameter _Unit_key_W = null;
			private AggregateParameter _Sub_unit_W = null;
			private AggregateParameter _Conver_sub_W = null;
			private AggregateParameter _Unit_price_W = null;
			private AggregateParameter _SuggestedPrice_W = null;
			private AggregateParameter _FinalPrice_W = null;
			private AggregateParameter _IsSync_W = null;

			public void AggregateClauseReset()
			{
				_PackID_W = null;
				_Trade_Code_W = null;
				_PackageDetailsID_W = null;
				_Unit_key_W = null;
				_Sub_unit_W = null;
				_Conver_sub_W = null;
				_Unit_price_W = null;
				_SuggestedPrice_W = null;
				_FinalPrice_W = null;
				_IsSync_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PackageDetailsInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.PackageDetailsID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PackageDetailsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PackageDetailsDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.PackageDetailsID);
			p.SourceColumn = ColumnNames.PackageDetailsID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.PackID);
			p.SourceColumn = ColumnNames.PackID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Trade_Code);
			p.SourceColumn = ColumnNames.Trade_Code;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PackageDetailsID);
			p.SourceColumn = ColumnNames.PackageDetailsID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Unit_key);
			p.SourceColumn = ColumnNames.Unit_key;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Sub_unit);
			p.SourceColumn = ColumnNames.Sub_unit;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Conver_sub);
			p.SourceColumn = ColumnNames.Conver_sub;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Unit_price);
			p.SourceColumn = ColumnNames.Unit_price;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SuggestedPrice);
			p.SourceColumn = ColumnNames.SuggestedPrice;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.FinalPrice);
			p.SourceColumn = ColumnNames.FinalPrice;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsSync);
			p.SourceColumn = ColumnNames.IsSync;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
