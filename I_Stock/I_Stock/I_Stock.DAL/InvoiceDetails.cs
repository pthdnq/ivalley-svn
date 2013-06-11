
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

namespace IStock.DAL
{
	public abstract class _InvoiceDetails : SqlClientEntity
	{
		public _InvoiceDetails()
		{
			this.QuerySource = "InvoiceDetails";
			this.MappingName = "InvoiceDetails";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_InvoiceDetailsLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int InvoiceDetailID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.InvoiceDetailID, InvoiceDetailID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_InvoiceDetailsLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter InvoiceDetailID
			{
				get
				{
					return new SqlParameter("@InvoiceDetailID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter InvoiceID
			{
				get
				{
					return new SqlParameter("@InvoiceID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ItemID
			{
				get
				{
					return new SqlParameter("@ItemID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Quantity
			{
				get
				{
					return new SqlParameter("@Quantity", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Discount
			{
				get
				{
					return new SqlParameter("@Discount", SqlDbType.Decimal, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string InvoiceDetailID = "InvoiceDetailID";
            public const string InvoiceID = "InvoiceID";
            public const string ItemID = "ItemID";
            public const string Quantity = "Quantity";
            public const string Discount = "Discount";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[InvoiceDetailID] = _InvoiceDetails.PropertyNames.InvoiceDetailID;
					ht[InvoiceID] = _InvoiceDetails.PropertyNames.InvoiceID;
					ht[ItemID] = _InvoiceDetails.PropertyNames.ItemID;
					ht[Quantity] = _InvoiceDetails.PropertyNames.Quantity;
					ht[Discount] = _InvoiceDetails.PropertyNames.Discount;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string InvoiceDetailID = "InvoiceDetailID";
            public const string InvoiceID = "InvoiceID";
            public const string ItemID = "ItemID";
            public const string Quantity = "Quantity";
            public const string Discount = "Discount";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[InvoiceDetailID] = _InvoiceDetails.ColumnNames.InvoiceDetailID;
					ht[InvoiceID] = _InvoiceDetails.ColumnNames.InvoiceID;
					ht[ItemID] = _InvoiceDetails.ColumnNames.ItemID;
					ht[Quantity] = _InvoiceDetails.ColumnNames.Quantity;
					ht[Discount] = _InvoiceDetails.ColumnNames.Discount;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string InvoiceDetailID = "s_InvoiceDetailID";
            public const string InvoiceID = "s_InvoiceID";
            public const string ItemID = "s_ItemID";
            public const string Quantity = "s_Quantity";
            public const string Discount = "s_Discount";

		}
		#endregion		
		
		#region Properties
	
		public virtual int InvoiceDetailID
	    {
			get
	        {
				return base.Getint(ColumnNames.InvoiceDetailID);
			}
			set
	        {
				base.Setint(ColumnNames.InvoiceDetailID, value);
			}
		}

		public virtual int InvoiceID
	    {
			get
	        {
				return base.Getint(ColumnNames.InvoiceID);
			}
			set
	        {
				base.Setint(ColumnNames.InvoiceID, value);
			}
		}

		public virtual int ItemID
	    {
			get
	        {
				return base.Getint(ColumnNames.ItemID);
			}
			set
	        {
				base.Setint(ColumnNames.ItemID, value);
			}
		}

		public virtual int Quantity
	    {
			get
	        {
				return base.Getint(ColumnNames.Quantity);
			}
			set
	        {
				base.Setint(ColumnNames.Quantity, value);
			}
		}

		public virtual decimal Discount
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.Discount);
			}
			set
	        {
				base.Setdecimal(ColumnNames.Discount, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_InvoiceDetailID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.InvoiceDetailID) ? string.Empty : base.GetintAsString(ColumnNames.InvoiceDetailID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.InvoiceDetailID);
				else
					this.InvoiceDetailID = base.SetintAsString(ColumnNames.InvoiceDetailID, value);
			}
		}

		public virtual string s_InvoiceID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.InvoiceID) ? string.Empty : base.GetintAsString(ColumnNames.InvoiceID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.InvoiceID);
				else
					this.InvoiceID = base.SetintAsString(ColumnNames.InvoiceID, value);
			}
		}

		public virtual string s_ItemID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ItemID) ? string.Empty : base.GetintAsString(ColumnNames.ItemID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ItemID);
				else
					this.ItemID = base.SetintAsString(ColumnNames.ItemID, value);
			}
		}

		public virtual string s_Quantity
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Quantity) ? string.Empty : base.GetintAsString(ColumnNames.Quantity);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Quantity);
				else
					this.Quantity = base.SetintAsString(ColumnNames.Quantity, value);
			}
		}

		public virtual string s_Discount
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Discount) ? string.Empty : base.GetdecimalAsString(ColumnNames.Discount);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Discount);
				else
					this.Discount = base.SetdecimalAsString(ColumnNames.Discount, value);
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
				
				
				public WhereParameter InvoiceDetailID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.InvoiceDetailID, Parameters.InvoiceDetailID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter InvoiceID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.InvoiceID, Parameters.InvoiceID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ItemID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ItemID, Parameters.ItemID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Quantity
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Quantity, Parameters.Quantity);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Discount
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Discount, Parameters.Discount);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter InvoiceDetailID
		    {
				get
		        {
					if(_InvoiceDetailID_W == null)
	        	    {
						_InvoiceDetailID_W = TearOff.InvoiceDetailID;
					}
					return _InvoiceDetailID_W;
				}
			}

			public WhereParameter InvoiceID
		    {
				get
		        {
					if(_InvoiceID_W == null)
	        	    {
						_InvoiceID_W = TearOff.InvoiceID;
					}
					return _InvoiceID_W;
				}
			}

			public WhereParameter ItemID
		    {
				get
		        {
					if(_ItemID_W == null)
	        	    {
						_ItemID_W = TearOff.ItemID;
					}
					return _ItemID_W;
				}
			}

			public WhereParameter Quantity
		    {
				get
		        {
					if(_Quantity_W == null)
	        	    {
						_Quantity_W = TearOff.Quantity;
					}
					return _Quantity_W;
				}
			}

			public WhereParameter Discount
		    {
				get
		        {
					if(_Discount_W == null)
	        	    {
						_Discount_W = TearOff.Discount;
					}
					return _Discount_W;
				}
			}

			private WhereParameter _InvoiceDetailID_W = null;
			private WhereParameter _InvoiceID_W = null;
			private WhereParameter _ItemID_W = null;
			private WhereParameter _Quantity_W = null;
			private WhereParameter _Discount_W = null;

			public void WhereClauseReset()
			{
				_InvoiceDetailID_W = null;
				_InvoiceID_W = null;
				_ItemID_W = null;
				_Quantity_W = null;
				_Discount_W = null;

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
				
				
				public AggregateParameter InvoiceDetailID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.InvoiceDetailID, Parameters.InvoiceDetailID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter InvoiceID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.InvoiceID, Parameters.InvoiceID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ItemID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ItemID, Parameters.ItemID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Quantity
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Quantity, Parameters.Quantity);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Discount
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Discount, Parameters.Discount);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter InvoiceDetailID
		    {
				get
		        {
					if(_InvoiceDetailID_W == null)
	        	    {
						_InvoiceDetailID_W = TearOff.InvoiceDetailID;
					}
					return _InvoiceDetailID_W;
				}
			}

			public AggregateParameter InvoiceID
		    {
				get
		        {
					if(_InvoiceID_W == null)
	        	    {
						_InvoiceID_W = TearOff.InvoiceID;
					}
					return _InvoiceID_W;
				}
			}

			public AggregateParameter ItemID
		    {
				get
		        {
					if(_ItemID_W == null)
	        	    {
						_ItemID_W = TearOff.ItemID;
					}
					return _ItemID_W;
				}
			}

			public AggregateParameter Quantity
		    {
				get
		        {
					if(_Quantity_W == null)
	        	    {
						_Quantity_W = TearOff.Quantity;
					}
					return _Quantity_W;
				}
			}

			public AggregateParameter Discount
		    {
				get
		        {
					if(_Discount_W == null)
	        	    {
						_Discount_W = TearOff.Discount;
					}
					return _Discount_W;
				}
			}

			private AggregateParameter _InvoiceDetailID_W = null;
			private AggregateParameter _InvoiceID_W = null;
			private AggregateParameter _ItemID_W = null;
			private AggregateParameter _Quantity_W = null;
			private AggregateParameter _Discount_W = null;

			public void AggregateClauseReset()
			{
				_InvoiceDetailID_W = null;
				_InvoiceID_W = null;
				_ItemID_W = null;
				_Quantity_W = null;
				_Discount_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_InvoiceDetailsInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.InvoiceDetailID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_InvoiceDetailsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_InvoiceDetailsDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.InvoiceDetailID);
			p.SourceColumn = ColumnNames.InvoiceDetailID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.InvoiceDetailID);
			p.SourceColumn = ColumnNames.InvoiceDetailID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.InvoiceID);
			p.SourceColumn = ColumnNames.InvoiceID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ItemID);
			p.SourceColumn = ColumnNames.ItemID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Quantity);
			p.SourceColumn = ColumnNames.Quantity;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Discount);
			p.SourceColumn = ColumnNames.Discount;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
