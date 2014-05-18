
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
	public abstract class _SupplyOrdersDetails : SqlClientEntity
	{
		public _SupplyOrdersDetails()
		{
			this.QuerySource = "SupplyOrdersDetails";
			this.MappingName = "SupplyOrdersDetails";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_SupplyOrdersDetailsLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int SupplyOrderDetailID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.SupplyOrderDetailID, SupplyOrderDetailID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_SupplyOrdersDetailsLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter SupplyOrderDetailID
			{
				get
				{
					return new SqlParameter("@SupplyOrderDetailID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter SupplyOrderID
			{
				get
				{
					return new SqlParameter("@SupplyOrderID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ItemID
			{
				get
				{
					return new SqlParameter("@ItemID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter NoOfPackages
			{
				get
				{
					return new SqlParameter("@NoOfPackages", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ItemOnPackages
			{
				get
				{
					return new SqlParameter("@ItemOnPackages", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PackagePrice
			{
				get
				{
					return new SqlParameter("@PackagePrice", SqlDbType.Decimal, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string SupplyOrderDetailID = "SupplyOrderDetailID";
            public const string SupplyOrderID = "SupplyOrderID";
            public const string ItemID = "ItemID";
            public const string NoOfPackages = "NoOfPackages";
            public const string ItemOnPackages = "ItemOnPackages";
            public const string PackagePrice = "PackagePrice";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[SupplyOrderDetailID] = _SupplyOrdersDetails.PropertyNames.SupplyOrderDetailID;
					ht[SupplyOrderID] = _SupplyOrdersDetails.PropertyNames.SupplyOrderID;
					ht[ItemID] = _SupplyOrdersDetails.PropertyNames.ItemID;
					ht[NoOfPackages] = _SupplyOrdersDetails.PropertyNames.NoOfPackages;
					ht[ItemOnPackages] = _SupplyOrdersDetails.PropertyNames.ItemOnPackages;
					ht[PackagePrice] = _SupplyOrdersDetails.PropertyNames.PackagePrice;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string SupplyOrderDetailID = "SupplyOrderDetailID";
            public const string SupplyOrderID = "SupplyOrderID";
            public const string ItemID = "ItemID";
            public const string NoOfPackages = "NoOfPackages";
            public const string ItemOnPackages = "ItemOnPackages";
            public const string PackagePrice = "PackagePrice";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[SupplyOrderDetailID] = _SupplyOrdersDetails.ColumnNames.SupplyOrderDetailID;
					ht[SupplyOrderID] = _SupplyOrdersDetails.ColumnNames.SupplyOrderID;
					ht[ItemID] = _SupplyOrdersDetails.ColumnNames.ItemID;
					ht[NoOfPackages] = _SupplyOrdersDetails.ColumnNames.NoOfPackages;
					ht[ItemOnPackages] = _SupplyOrdersDetails.ColumnNames.ItemOnPackages;
					ht[PackagePrice] = _SupplyOrdersDetails.ColumnNames.PackagePrice;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string SupplyOrderDetailID = "s_SupplyOrderDetailID";
            public const string SupplyOrderID = "s_SupplyOrderID";
            public const string ItemID = "s_ItemID";
            public const string NoOfPackages = "s_NoOfPackages";
            public const string ItemOnPackages = "s_ItemOnPackages";
            public const string PackagePrice = "s_PackagePrice";

		}
		#endregion		
		
		#region Properties
	
		public virtual int SupplyOrderDetailID
	    {
			get
	        {
				return base.Getint(ColumnNames.SupplyOrderDetailID);
			}
			set
	        {
				base.Setint(ColumnNames.SupplyOrderDetailID, value);
			}
		}

		public virtual int SupplyOrderID
	    {
			get
	        {
				return base.Getint(ColumnNames.SupplyOrderID);
			}
			set
	        {
				base.Setint(ColumnNames.SupplyOrderID, value);
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

		public virtual int NoOfPackages
	    {
			get
	        {
				return base.Getint(ColumnNames.NoOfPackages);
			}
			set
	        {
				base.Setint(ColumnNames.NoOfPackages, value);
			}
		}

		public virtual int ItemOnPackages
	    {
			get
	        {
				return base.Getint(ColumnNames.ItemOnPackages);
			}
			set
	        {
				base.Setint(ColumnNames.ItemOnPackages, value);
			}
		}

		public virtual decimal PackagePrice
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.PackagePrice);
			}
			set
	        {
				base.Setdecimal(ColumnNames.PackagePrice, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_SupplyOrderDetailID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SupplyOrderDetailID) ? string.Empty : base.GetintAsString(ColumnNames.SupplyOrderDetailID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SupplyOrderDetailID);
				else
					this.SupplyOrderDetailID = base.SetintAsString(ColumnNames.SupplyOrderDetailID, value);
			}
		}

		public virtual string s_SupplyOrderID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.SupplyOrderID) ? string.Empty : base.GetintAsString(ColumnNames.SupplyOrderID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SupplyOrderID);
				else
					this.SupplyOrderID = base.SetintAsString(ColumnNames.SupplyOrderID, value);
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

		public virtual string s_NoOfPackages
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.NoOfPackages) ? string.Empty : base.GetintAsString(ColumnNames.NoOfPackages);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.NoOfPackages);
				else
					this.NoOfPackages = base.SetintAsString(ColumnNames.NoOfPackages, value);
			}
		}

		public virtual string s_ItemOnPackages
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ItemOnPackages) ? string.Empty : base.GetintAsString(ColumnNames.ItemOnPackages);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ItemOnPackages);
				else
					this.ItemOnPackages = base.SetintAsString(ColumnNames.ItemOnPackages, value);
			}
		}

		public virtual string s_PackagePrice
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PackagePrice) ? string.Empty : base.GetdecimalAsString(ColumnNames.PackagePrice);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PackagePrice);
				else
					this.PackagePrice = base.SetdecimalAsString(ColumnNames.PackagePrice, value);
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
				
				
				public WhereParameter SupplyOrderDetailID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SupplyOrderDetailID, Parameters.SupplyOrderDetailID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter SupplyOrderID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.SupplyOrderID, Parameters.SupplyOrderID);
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

				public WhereParameter NoOfPackages
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.NoOfPackages, Parameters.NoOfPackages);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ItemOnPackages
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ItemOnPackages, Parameters.ItemOnPackages);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PackagePrice
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PackagePrice, Parameters.PackagePrice);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter SupplyOrderDetailID
		    {
				get
		        {
					if(_SupplyOrderDetailID_W == null)
	        	    {
						_SupplyOrderDetailID_W = TearOff.SupplyOrderDetailID;
					}
					return _SupplyOrderDetailID_W;
				}
			}

			public WhereParameter SupplyOrderID
		    {
				get
		        {
					if(_SupplyOrderID_W == null)
	        	    {
						_SupplyOrderID_W = TearOff.SupplyOrderID;
					}
					return _SupplyOrderID_W;
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

			public WhereParameter NoOfPackages
		    {
				get
		        {
					if(_NoOfPackages_W == null)
	        	    {
						_NoOfPackages_W = TearOff.NoOfPackages;
					}
					return _NoOfPackages_W;
				}
			}

			public WhereParameter ItemOnPackages
		    {
				get
		        {
					if(_ItemOnPackages_W == null)
	        	    {
						_ItemOnPackages_W = TearOff.ItemOnPackages;
					}
					return _ItemOnPackages_W;
				}
			}

			public WhereParameter PackagePrice
		    {
				get
		        {
					if(_PackagePrice_W == null)
	        	    {
						_PackagePrice_W = TearOff.PackagePrice;
					}
					return _PackagePrice_W;
				}
			}

			private WhereParameter _SupplyOrderDetailID_W = null;
			private WhereParameter _SupplyOrderID_W = null;
			private WhereParameter _ItemID_W = null;
			private WhereParameter _NoOfPackages_W = null;
			private WhereParameter _ItemOnPackages_W = null;
			private WhereParameter _PackagePrice_W = null;

			public void WhereClauseReset()
			{
				_SupplyOrderDetailID_W = null;
				_SupplyOrderID_W = null;
				_ItemID_W = null;
				_NoOfPackages_W = null;
				_ItemOnPackages_W = null;
				_PackagePrice_W = null;

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
				
				
				public AggregateParameter SupplyOrderDetailID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SupplyOrderDetailID, Parameters.SupplyOrderDetailID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter SupplyOrderID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.SupplyOrderID, Parameters.SupplyOrderID);
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

				public AggregateParameter NoOfPackages
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.NoOfPackages, Parameters.NoOfPackages);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ItemOnPackages
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ItemOnPackages, Parameters.ItemOnPackages);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PackagePrice
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PackagePrice, Parameters.PackagePrice);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter SupplyOrderDetailID
		    {
				get
		        {
					if(_SupplyOrderDetailID_W == null)
	        	    {
						_SupplyOrderDetailID_W = TearOff.SupplyOrderDetailID;
					}
					return _SupplyOrderDetailID_W;
				}
			}

			public AggregateParameter SupplyOrderID
		    {
				get
		        {
					if(_SupplyOrderID_W == null)
	        	    {
						_SupplyOrderID_W = TearOff.SupplyOrderID;
					}
					return _SupplyOrderID_W;
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

			public AggregateParameter NoOfPackages
		    {
				get
		        {
					if(_NoOfPackages_W == null)
	        	    {
						_NoOfPackages_W = TearOff.NoOfPackages;
					}
					return _NoOfPackages_W;
				}
			}

			public AggregateParameter ItemOnPackages
		    {
				get
		        {
					if(_ItemOnPackages_W == null)
	        	    {
						_ItemOnPackages_W = TearOff.ItemOnPackages;
					}
					return _ItemOnPackages_W;
				}
			}

			public AggregateParameter PackagePrice
		    {
				get
		        {
					if(_PackagePrice_W == null)
	        	    {
						_PackagePrice_W = TearOff.PackagePrice;
					}
					return _PackagePrice_W;
				}
			}

			private AggregateParameter _SupplyOrderDetailID_W = null;
			private AggregateParameter _SupplyOrderID_W = null;
			private AggregateParameter _ItemID_W = null;
			private AggregateParameter _NoOfPackages_W = null;
			private AggregateParameter _ItemOnPackages_W = null;
			private AggregateParameter _PackagePrice_W = null;

			public void AggregateClauseReset()
			{
				_SupplyOrderDetailID_W = null;
				_SupplyOrderID_W = null;
				_ItemID_W = null;
				_NoOfPackages_W = null;
				_ItemOnPackages_W = null;
				_PackagePrice_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_SupplyOrdersDetailsInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.SupplyOrderDetailID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_SupplyOrdersDetailsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_SupplyOrdersDetailsDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.SupplyOrderDetailID);
			p.SourceColumn = ColumnNames.SupplyOrderDetailID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.SupplyOrderDetailID);
			p.SourceColumn = ColumnNames.SupplyOrderDetailID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SupplyOrderID);
			p.SourceColumn = ColumnNames.SupplyOrderID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ItemID);
			p.SourceColumn = ColumnNames.ItemID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.NoOfPackages);
			p.SourceColumn = ColumnNames.NoOfPackages;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ItemOnPackages);
			p.SourceColumn = ColumnNames.ItemOnPackages;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PackagePrice);
			p.SourceColumn = ColumnNames.PackagePrice;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}