
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

namespace EGEMech.DAL
{
	public abstract class _Order : SqlClientEntity
	{
		public _Order()
		{
			this.QuerySource = "Order";
			this.MappingName = "Order";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_OrderLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int OrderID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.OrderID, OrderID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_OrderLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter OrderID
			{
				get
				{
					return new SqlParameter("@OrderID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ProductID
			{
				get
				{
					return new SqlParameter("@ProductID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Quantity
			{
				get
				{
					return new SqlParameter("@Quantity", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ShippingPrice
			{
				get
				{
					return new SqlParameter("@ShippingPrice", SqlDbType.Decimal, 0);
				}
			}
			
			public static SqlParameter UserID
			{
				get
				{
					return new SqlParameter("@UserID", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter OrderStatusID
			{
				get
				{
					return new SqlParameter("@OrderStatusID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string OrderID = "OrderID";
            public const string ProductID = "ProductID";
            public const string Quantity = "Quantity";
            public const string ShippingPrice = "ShippingPrice";
            public const string UserID = "UserID";
            public const string OrderStatusID = "OrderStatusID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[OrderID] = _Order.PropertyNames.OrderID;
					ht[ProductID] = _Order.PropertyNames.ProductID;
					ht[Quantity] = _Order.PropertyNames.Quantity;
					ht[ShippingPrice] = _Order.PropertyNames.ShippingPrice;
					ht[UserID] = _Order.PropertyNames.UserID;
					ht[OrderStatusID] = _Order.PropertyNames.OrderStatusID;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string OrderID = "OrderID";
            public const string ProductID = "ProductID";
            public const string Quantity = "Quantity";
            public const string ShippingPrice = "ShippingPrice";
            public const string UserID = "UserID";
            public const string OrderStatusID = "OrderStatusID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[OrderID] = _Order.ColumnNames.OrderID;
					ht[ProductID] = _Order.ColumnNames.ProductID;
					ht[Quantity] = _Order.ColumnNames.Quantity;
					ht[ShippingPrice] = _Order.ColumnNames.ShippingPrice;
					ht[UserID] = _Order.ColumnNames.UserID;
					ht[OrderStatusID] = _Order.ColumnNames.OrderStatusID;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string OrderID = "s_OrderID";
            public const string ProductID = "s_ProductID";
            public const string Quantity = "s_Quantity";
            public const string ShippingPrice = "s_ShippingPrice";
            public const string UserID = "s_UserID";
            public const string OrderStatusID = "s_OrderStatusID";

		}
		#endregion		
		
		#region Properties
	
		public virtual int OrderID
	    {
			get
	        {
				return base.Getint(ColumnNames.OrderID);
			}
			set
	        {
				base.Setint(ColumnNames.OrderID, value);
			}
		}

		public virtual int ProductID
	    {
			get
	        {
				return base.Getint(ColumnNames.ProductID);
			}
			set
	        {
				base.Setint(ColumnNames.ProductID, value);
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

		public virtual decimal ShippingPrice
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.ShippingPrice);
			}
			set
	        {
				base.Setdecimal(ColumnNames.ShippingPrice, value);
			}
		}

		public virtual Guid UserID
	    {
			get
	        {
				return base.GetGuid(ColumnNames.UserID);
			}
			set
	        {
				base.SetGuid(ColumnNames.UserID, value);
			}
		}

		public virtual int OrderStatusID
	    {
			get
	        {
				return base.Getint(ColumnNames.OrderStatusID);
			}
			set
	        {
				base.Setint(ColumnNames.OrderStatusID, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_OrderID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OrderID) ? string.Empty : base.GetintAsString(ColumnNames.OrderID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OrderID);
				else
					this.OrderID = base.SetintAsString(ColumnNames.OrderID, value);
			}
		}

		public virtual string s_ProductID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ProductID) ? string.Empty : base.GetintAsString(ColumnNames.ProductID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ProductID);
				else
					this.ProductID = base.SetintAsString(ColumnNames.ProductID, value);
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

		public virtual string s_ShippingPrice
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ShippingPrice) ? string.Empty : base.GetdecimalAsString(ColumnNames.ShippingPrice);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ShippingPrice);
				else
					this.ShippingPrice = base.SetdecimalAsString(ColumnNames.ShippingPrice, value);
			}
		}

		public virtual string s_UserID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UserID) ? string.Empty : base.GetGuidAsString(ColumnNames.UserID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UserID);
				else
					this.UserID = base.SetGuidAsString(ColumnNames.UserID, value);
			}
		}

		public virtual string s_OrderStatusID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OrderStatusID) ? string.Empty : base.GetintAsString(ColumnNames.OrderStatusID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OrderStatusID);
				else
					this.OrderStatusID = base.SetintAsString(ColumnNames.OrderStatusID, value);
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
				
				
				public WhereParameter OrderID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OrderID, Parameters.OrderID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ProductID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ProductID, Parameters.ProductID);
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

				public WhereParameter ShippingPrice
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ShippingPrice, Parameters.ShippingPrice);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter UserID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UserID, Parameters.UserID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter OrderStatusID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OrderStatusID, Parameters.OrderStatusID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter OrderID
		    {
				get
		        {
					if(_OrderID_W == null)
	        	    {
						_OrderID_W = TearOff.OrderID;
					}
					return _OrderID_W;
				}
			}

			public WhereParameter ProductID
		    {
				get
		        {
					if(_ProductID_W == null)
	        	    {
						_ProductID_W = TearOff.ProductID;
					}
					return _ProductID_W;
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

			public WhereParameter ShippingPrice
		    {
				get
		        {
					if(_ShippingPrice_W == null)
	        	    {
						_ShippingPrice_W = TearOff.ShippingPrice;
					}
					return _ShippingPrice_W;
				}
			}

			public WhereParameter UserID
		    {
				get
		        {
					if(_UserID_W == null)
	        	    {
						_UserID_W = TearOff.UserID;
					}
					return _UserID_W;
				}
			}

			public WhereParameter OrderStatusID
		    {
				get
		        {
					if(_OrderStatusID_W == null)
	        	    {
						_OrderStatusID_W = TearOff.OrderStatusID;
					}
					return _OrderStatusID_W;
				}
			}

			private WhereParameter _OrderID_W = null;
			private WhereParameter _ProductID_W = null;
			private WhereParameter _Quantity_W = null;
			private WhereParameter _ShippingPrice_W = null;
			private WhereParameter _UserID_W = null;
			private WhereParameter _OrderStatusID_W = null;

			public void WhereClauseReset()
			{
				_OrderID_W = null;
				_ProductID_W = null;
				_Quantity_W = null;
				_ShippingPrice_W = null;
				_UserID_W = null;
				_OrderStatusID_W = null;

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
				
				
				public AggregateParameter OrderID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OrderID, Parameters.OrderID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ProductID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ProductID, Parameters.ProductID);
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

				public AggregateParameter ShippingPrice
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ShippingPrice, Parameters.ShippingPrice);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter UserID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UserID, Parameters.UserID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter OrderStatusID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OrderStatusID, Parameters.OrderStatusID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter OrderID
		    {
				get
		        {
					if(_OrderID_W == null)
	        	    {
						_OrderID_W = TearOff.OrderID;
					}
					return _OrderID_W;
				}
			}

			public AggregateParameter ProductID
		    {
				get
		        {
					if(_ProductID_W == null)
	        	    {
						_ProductID_W = TearOff.ProductID;
					}
					return _ProductID_W;
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

			public AggregateParameter ShippingPrice
		    {
				get
		        {
					if(_ShippingPrice_W == null)
	        	    {
						_ShippingPrice_W = TearOff.ShippingPrice;
					}
					return _ShippingPrice_W;
				}
			}

			public AggregateParameter UserID
		    {
				get
		        {
					if(_UserID_W == null)
	        	    {
						_UserID_W = TearOff.UserID;
					}
					return _UserID_W;
				}
			}

			public AggregateParameter OrderStatusID
		    {
				get
		        {
					if(_OrderStatusID_W == null)
	        	    {
						_OrderStatusID_W = TearOff.OrderStatusID;
					}
					return _OrderStatusID_W;
				}
			}

			private AggregateParameter _OrderID_W = null;
			private AggregateParameter _ProductID_W = null;
			private AggregateParameter _Quantity_W = null;
			private AggregateParameter _ShippingPrice_W = null;
			private AggregateParameter _UserID_W = null;
			private AggregateParameter _OrderStatusID_W = null;

			public void AggregateClauseReset()
			{
				_OrderID_W = null;
				_ProductID_W = null;
				_Quantity_W = null;
				_ShippingPrice_W = null;
				_UserID_W = null;
				_OrderStatusID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_OrderInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.OrderID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_OrderUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_OrderDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.OrderID);
			p.SourceColumn = ColumnNames.OrderID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.OrderID);
			p.SourceColumn = ColumnNames.OrderID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ProductID);
			p.SourceColumn = ColumnNames.ProductID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Quantity);
			p.SourceColumn = ColumnNames.Quantity;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ShippingPrice);
			p.SourceColumn = ColumnNames.ShippingPrice;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UserID);
			p.SourceColumn = ColumnNames.UserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.OrderStatusID);
			p.SourceColumn = ColumnNames.OrderStatusID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
