
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
	public abstract class _StatusHierarchy : SqlClientEntity
	{
		public _StatusHierarchy()
		{
			this.QuerySource = "StatusHierarchy";
			this.MappingName = "StatusHierarchy";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_StatusHierarchyLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int StatusHierarchyID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.StatusHierarchyID, StatusHierarchyID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_StatusHierarchyLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter StatusHierarchyID
			{
				get
				{
					return new SqlParameter("@StatusHierarchyID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter StatusID
			{
				get
				{
					return new SqlParameter("@StatusID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ParentStatusID
			{
				get
				{
					return new SqlParameter("@ParentStatusID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string StatusHierarchyID = "StatusHierarchyID";
            public const string StatusID = "StatusID";
            public const string ParentStatusID = "ParentStatusID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[StatusHierarchyID] = _StatusHierarchy.PropertyNames.StatusHierarchyID;
					ht[StatusID] = _StatusHierarchy.PropertyNames.StatusID;
					ht[ParentStatusID] = _StatusHierarchy.PropertyNames.ParentStatusID;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string StatusHierarchyID = "StatusHierarchyID";
            public const string StatusID = "StatusID";
            public const string ParentStatusID = "ParentStatusID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[StatusHierarchyID] = _StatusHierarchy.ColumnNames.StatusHierarchyID;
					ht[StatusID] = _StatusHierarchy.ColumnNames.StatusID;
					ht[ParentStatusID] = _StatusHierarchy.ColumnNames.ParentStatusID;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string StatusHierarchyID = "s_StatusHierarchyID";
            public const string StatusID = "s_StatusID";
            public const string ParentStatusID = "s_ParentStatusID";

		}
		#endregion		
		
		#region Properties
	
		public virtual int StatusHierarchyID
	    {
			get
	        {
				return base.Getint(ColumnNames.StatusHierarchyID);
			}
			set
	        {
				base.Setint(ColumnNames.StatusHierarchyID, value);
			}
		}

		public virtual int StatusID
	    {
			get
	        {
				return base.Getint(ColumnNames.StatusID);
			}
			set
	        {
				base.Setint(ColumnNames.StatusID, value);
			}
		}

		public virtual int ParentStatusID
	    {
			get
	        {
				return base.Getint(ColumnNames.ParentStatusID);
			}
			set
	        {
				base.Setint(ColumnNames.ParentStatusID, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_StatusHierarchyID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.StatusHierarchyID) ? string.Empty : base.GetintAsString(ColumnNames.StatusHierarchyID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.StatusHierarchyID);
				else
					this.StatusHierarchyID = base.SetintAsString(ColumnNames.StatusHierarchyID, value);
			}
		}

		public virtual string s_StatusID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.StatusID) ? string.Empty : base.GetintAsString(ColumnNames.StatusID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.StatusID);
				else
					this.StatusID = base.SetintAsString(ColumnNames.StatusID, value);
			}
		}

		public virtual string s_ParentStatusID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ParentStatusID) ? string.Empty : base.GetintAsString(ColumnNames.ParentStatusID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ParentStatusID);
				else
					this.ParentStatusID = base.SetintAsString(ColumnNames.ParentStatusID, value);
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
				
				
				public WhereParameter StatusHierarchyID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.StatusHierarchyID, Parameters.StatusHierarchyID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter StatusID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.StatusID, Parameters.StatusID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ParentStatusID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ParentStatusID, Parameters.ParentStatusID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter StatusHierarchyID
		    {
				get
		        {
					if(_StatusHierarchyID_W == null)
	        	    {
						_StatusHierarchyID_W = TearOff.StatusHierarchyID;
					}
					return _StatusHierarchyID_W;
				}
			}

			public WhereParameter StatusID
		    {
				get
		        {
					if(_StatusID_W == null)
	        	    {
						_StatusID_W = TearOff.StatusID;
					}
					return _StatusID_W;
				}
			}

			public WhereParameter ParentStatusID
		    {
				get
		        {
					if(_ParentStatusID_W == null)
	        	    {
						_ParentStatusID_W = TearOff.ParentStatusID;
					}
					return _ParentStatusID_W;
				}
			}

			private WhereParameter _StatusHierarchyID_W = null;
			private WhereParameter _StatusID_W = null;
			private WhereParameter _ParentStatusID_W = null;

			public void WhereClauseReset()
			{
				_StatusHierarchyID_W = null;
				_StatusID_W = null;
				_ParentStatusID_W = null;

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
				
				
				public AggregateParameter StatusHierarchyID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.StatusHierarchyID, Parameters.StatusHierarchyID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter StatusID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.StatusID, Parameters.StatusID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ParentStatusID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ParentStatusID, Parameters.ParentStatusID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter StatusHierarchyID
		    {
				get
		        {
					if(_StatusHierarchyID_W == null)
	        	    {
						_StatusHierarchyID_W = TearOff.StatusHierarchyID;
					}
					return _StatusHierarchyID_W;
				}
			}

			public AggregateParameter StatusID
		    {
				get
		        {
					if(_StatusID_W == null)
	        	    {
						_StatusID_W = TearOff.StatusID;
					}
					return _StatusID_W;
				}
			}

			public AggregateParameter ParentStatusID
		    {
				get
		        {
					if(_ParentStatusID_W == null)
	        	    {
						_ParentStatusID_W = TearOff.ParentStatusID;
					}
					return _ParentStatusID_W;
				}
			}

			private AggregateParameter _StatusHierarchyID_W = null;
			private AggregateParameter _StatusID_W = null;
			private AggregateParameter _ParentStatusID_W = null;

			public void AggregateClauseReset()
			{
				_StatusHierarchyID_W = null;
				_StatusID_W = null;
				_ParentStatusID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_StatusHierarchyInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.StatusHierarchyID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_StatusHierarchyUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_StatusHierarchyDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.StatusHierarchyID);
			p.SourceColumn = ColumnNames.StatusHierarchyID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.StatusHierarchyID);
			p.SourceColumn = ColumnNames.StatusHierarchyID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.StatusID);
			p.SourceColumn = ColumnNames.StatusID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ParentStatusID);
			p.SourceColumn = ColumnNames.ParentStatusID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
