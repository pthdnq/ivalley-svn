
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

namespace GlobalLogistics.DAL
{
	public abstract class _Exchange : SqlClientEntity
	{
		public _Exchange()
		{
			this.QuerySource = "Exchange";
			this.MappingName = "Exchange";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ExchangeLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ExchangeID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ExchangeID, ExchangeID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ExchangeLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ExchangeID
			{
				get
				{
					return new SqlParameter("@ExchangeID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CurrencyID
			{
				get
				{
					return new SqlParameter("@CurrencyID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CellPrice
			{
				get
				{
					return new SqlParameter("@CellPrice", SqlDbType.Decimal, 0);
				}
			}
			
			public static SqlParameter BuyPrice
			{
				get
				{
					return new SqlParameter("@BuyPrice", SqlDbType.Decimal, 0);
				}
			}
			
			public static SqlParameter LastCellPrice
			{
				get
				{
					return new SqlParameter("@LastCellPrice", SqlDbType.Decimal, 0);
				}
			}
			
			public static SqlParameter CreatedDate
			{
				get
				{
					return new SqlParameter("@CreatedDate", SqlDbType.DateTime, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ExchangeID = "ExchangeID";
            public const string CurrencyID = "CurrencyID";
            public const string CellPrice = "CellPrice";
            public const string BuyPrice = "BuyPrice";
            public const string LastCellPrice = "LastCellPrice";
            public const string CreatedDate = "CreatedDate";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ExchangeID] = _Exchange.PropertyNames.ExchangeID;
					ht[CurrencyID] = _Exchange.PropertyNames.CurrencyID;
					ht[CellPrice] = _Exchange.PropertyNames.CellPrice;
					ht[BuyPrice] = _Exchange.PropertyNames.BuyPrice;
					ht[LastCellPrice] = _Exchange.PropertyNames.LastCellPrice;
					ht[CreatedDate] = _Exchange.PropertyNames.CreatedDate;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ExchangeID = "ExchangeID";
            public const string CurrencyID = "CurrencyID";
            public const string CellPrice = "CellPrice";
            public const string BuyPrice = "BuyPrice";
            public const string LastCellPrice = "LastCellPrice";
            public const string CreatedDate = "CreatedDate";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ExchangeID] = _Exchange.ColumnNames.ExchangeID;
					ht[CurrencyID] = _Exchange.ColumnNames.CurrencyID;
					ht[CellPrice] = _Exchange.ColumnNames.CellPrice;
					ht[BuyPrice] = _Exchange.ColumnNames.BuyPrice;
					ht[LastCellPrice] = _Exchange.ColumnNames.LastCellPrice;
					ht[CreatedDate] = _Exchange.ColumnNames.CreatedDate;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ExchangeID = "s_ExchangeID";
            public const string CurrencyID = "s_CurrencyID";
            public const string CellPrice = "s_CellPrice";
            public const string BuyPrice = "s_BuyPrice";
            public const string LastCellPrice = "s_LastCellPrice";
            public const string CreatedDate = "s_CreatedDate";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ExchangeID
	    {
			get
	        {
				return base.Getint(ColumnNames.ExchangeID);
			}
			set
	        {
				base.Setint(ColumnNames.ExchangeID, value);
			}
		}

		public virtual int CurrencyID
	    {
			get
	        {
				return base.Getint(ColumnNames.CurrencyID);
			}
			set
	        {
				base.Setint(ColumnNames.CurrencyID, value);
			}
		}

		public virtual decimal CellPrice
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.CellPrice);
			}
			set
	        {
				base.Setdecimal(ColumnNames.CellPrice, value);
			}
		}

		public virtual decimal BuyPrice
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.BuyPrice);
			}
			set
	        {
				base.Setdecimal(ColumnNames.BuyPrice, value);
			}
		}

		public virtual decimal LastCellPrice
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.LastCellPrice);
			}
			set
	        {
				base.Setdecimal(ColumnNames.LastCellPrice, value);
			}
		}

		public virtual DateTime CreatedDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.CreatedDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.CreatedDate, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ExchangeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ExchangeID) ? string.Empty : base.GetintAsString(ColumnNames.ExchangeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ExchangeID);
				else
					this.ExchangeID = base.SetintAsString(ColumnNames.ExchangeID, value);
			}
		}

		public virtual string s_CurrencyID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CurrencyID) ? string.Empty : base.GetintAsString(ColumnNames.CurrencyID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CurrencyID);
				else
					this.CurrencyID = base.SetintAsString(ColumnNames.CurrencyID, value);
			}
		}

		public virtual string s_CellPrice
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CellPrice) ? string.Empty : base.GetdecimalAsString(ColumnNames.CellPrice);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CellPrice);
				else
					this.CellPrice = base.SetdecimalAsString(ColumnNames.CellPrice, value);
			}
		}

		public virtual string s_BuyPrice
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BuyPrice) ? string.Empty : base.GetdecimalAsString(ColumnNames.BuyPrice);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BuyPrice);
				else
					this.BuyPrice = base.SetdecimalAsString(ColumnNames.BuyPrice, value);
			}
		}

		public virtual string s_LastCellPrice
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LastCellPrice) ? string.Empty : base.GetdecimalAsString(ColumnNames.LastCellPrice);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LastCellPrice);
				else
					this.LastCellPrice = base.SetdecimalAsString(ColumnNames.LastCellPrice, value);
			}
		}

		public virtual string s_CreatedDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreatedDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.CreatedDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreatedDate);
				else
					this.CreatedDate = base.SetDateTimeAsString(ColumnNames.CreatedDate, value);
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
				
				
				public WhereParameter ExchangeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ExchangeID, Parameters.ExchangeID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CurrencyID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CurrencyID, Parameters.CurrencyID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CellPrice
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CellPrice, Parameters.CellPrice);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BuyPrice
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BuyPrice, Parameters.BuyPrice);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter LastCellPrice
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LastCellPrice, Parameters.LastCellPrice);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CreatedDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreatedDate, Parameters.CreatedDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ExchangeID
		    {
				get
		        {
					if(_ExchangeID_W == null)
	        	    {
						_ExchangeID_W = TearOff.ExchangeID;
					}
					return _ExchangeID_W;
				}
			}

			public WhereParameter CurrencyID
		    {
				get
		        {
					if(_CurrencyID_W == null)
	        	    {
						_CurrencyID_W = TearOff.CurrencyID;
					}
					return _CurrencyID_W;
				}
			}

			public WhereParameter CellPrice
		    {
				get
		        {
					if(_CellPrice_W == null)
	        	    {
						_CellPrice_W = TearOff.CellPrice;
					}
					return _CellPrice_W;
				}
			}

			public WhereParameter BuyPrice
		    {
				get
		        {
					if(_BuyPrice_W == null)
	        	    {
						_BuyPrice_W = TearOff.BuyPrice;
					}
					return _BuyPrice_W;
				}
			}

			public WhereParameter LastCellPrice
		    {
				get
		        {
					if(_LastCellPrice_W == null)
	        	    {
						_LastCellPrice_W = TearOff.LastCellPrice;
					}
					return _LastCellPrice_W;
				}
			}

			public WhereParameter CreatedDate
		    {
				get
		        {
					if(_CreatedDate_W == null)
	        	    {
						_CreatedDate_W = TearOff.CreatedDate;
					}
					return _CreatedDate_W;
				}
			}

			private WhereParameter _ExchangeID_W = null;
			private WhereParameter _CurrencyID_W = null;
			private WhereParameter _CellPrice_W = null;
			private WhereParameter _BuyPrice_W = null;
			private WhereParameter _LastCellPrice_W = null;
			private WhereParameter _CreatedDate_W = null;

			public void WhereClauseReset()
			{
				_ExchangeID_W = null;
				_CurrencyID_W = null;
				_CellPrice_W = null;
				_BuyPrice_W = null;
				_LastCellPrice_W = null;
				_CreatedDate_W = null;

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
				
				
				public AggregateParameter ExchangeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ExchangeID, Parameters.ExchangeID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CurrencyID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CurrencyID, Parameters.CurrencyID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CellPrice
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CellPrice, Parameters.CellPrice);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BuyPrice
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BuyPrice, Parameters.BuyPrice);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter LastCellPrice
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LastCellPrice, Parameters.LastCellPrice);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CreatedDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreatedDate, Parameters.CreatedDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ExchangeID
		    {
				get
		        {
					if(_ExchangeID_W == null)
	        	    {
						_ExchangeID_W = TearOff.ExchangeID;
					}
					return _ExchangeID_W;
				}
			}

			public AggregateParameter CurrencyID
		    {
				get
		        {
					if(_CurrencyID_W == null)
	        	    {
						_CurrencyID_W = TearOff.CurrencyID;
					}
					return _CurrencyID_W;
				}
			}

			public AggregateParameter CellPrice
		    {
				get
		        {
					if(_CellPrice_W == null)
	        	    {
						_CellPrice_W = TearOff.CellPrice;
					}
					return _CellPrice_W;
				}
			}

			public AggregateParameter BuyPrice
		    {
				get
		        {
					if(_BuyPrice_W == null)
	        	    {
						_BuyPrice_W = TearOff.BuyPrice;
					}
					return _BuyPrice_W;
				}
			}

			public AggregateParameter LastCellPrice
		    {
				get
		        {
					if(_LastCellPrice_W == null)
	        	    {
						_LastCellPrice_W = TearOff.LastCellPrice;
					}
					return _LastCellPrice_W;
				}
			}

			public AggregateParameter CreatedDate
		    {
				get
		        {
					if(_CreatedDate_W == null)
	        	    {
						_CreatedDate_W = TearOff.CreatedDate;
					}
					return _CreatedDate_W;
				}
			}

			private AggregateParameter _ExchangeID_W = null;
			private AggregateParameter _CurrencyID_W = null;
			private AggregateParameter _CellPrice_W = null;
			private AggregateParameter _BuyPrice_W = null;
			private AggregateParameter _LastCellPrice_W = null;
			private AggregateParameter _CreatedDate_W = null;

			public void AggregateClauseReset()
			{
				_ExchangeID_W = null;
				_CurrencyID_W = null;
				_CellPrice_W = null;
				_BuyPrice_W = null;
				_LastCellPrice_W = null;
				_CreatedDate_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ExchangeInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ExchangeID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ExchangeUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ExchangeDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ExchangeID);
			p.SourceColumn = ColumnNames.ExchangeID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ExchangeID);
			p.SourceColumn = ColumnNames.ExchangeID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CurrencyID);
			p.SourceColumn = ColumnNames.CurrencyID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CellPrice);
			p.SourceColumn = ColumnNames.CellPrice;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BuyPrice);
			p.SourceColumn = ColumnNames.BuyPrice;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LastCellPrice);
			p.SourceColumn = ColumnNames.LastCellPrice;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreatedDate);
			p.SourceColumn = ColumnNames.CreatedDate;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}