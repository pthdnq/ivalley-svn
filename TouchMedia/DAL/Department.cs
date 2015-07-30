
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

namespace DAL
{
	public abstract class _Department : SqlClientEntity
	{
		public _Department()
		{
			this.QuerySource = "Department";
			this.MappingName = "Department";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_DepartmentLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int DepartmentID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.DepartmentID, DepartmentID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_DepartmentLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter DepartmentID
			{
				get
				{
					return new SqlParameter("@DepartmentID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter DepartmentName
			{
				get
				{
					return new SqlParameter("@DepartmentName", SqlDbType.NVarChar, 300);
				}
			}
			
			public static SqlParameter IsDeleted
			{
				get
				{
					return new SqlParameter("@IsDeleted", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string DepartmentID = "DepartmentID";
            public const string DepartmentName = "DepartmentName";
            public const string IsDeleted = "isDeleted";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[DepartmentID] = _Department.PropertyNames.DepartmentID;
					ht[DepartmentName] = _Department.PropertyNames.DepartmentName;
					ht[IsDeleted] = _Department.PropertyNames.IsDeleted;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string DepartmentID = "DepartmentID";
            public const string DepartmentName = "DepartmentName";
            public const string IsDeleted = "IsDeleted";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[DepartmentID] = _Department.ColumnNames.DepartmentID;
					ht[DepartmentName] = _Department.ColumnNames.DepartmentName;
					ht[IsDeleted] = _Department.ColumnNames.IsDeleted;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string DepartmentID = "s_DepartmentID";
            public const string DepartmentName = "s_DepartmentName";
            public const string IsDeleted = "s_IsDeleted";

		}
		#endregion		
		
		#region Properties
	
		public virtual int DepartmentID
	    {
			get
	        {
				return base.Getint(ColumnNames.DepartmentID);
			}
			set
	        {
				base.Setint(ColumnNames.DepartmentID, value);
			}
		}

		public virtual string DepartmentName
	    {
			get
	        {
				return base.Getstring(ColumnNames.DepartmentName);
			}
			set
	        {
				base.Setstring(ColumnNames.DepartmentName, value);
			}
		}

		public virtual bool IsDeleted
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsDeleted);
			}
			set
	        {
				base.Setbool(ColumnNames.IsDeleted, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_DepartmentID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.DepartmentID) ? string.Empty : base.GetintAsString(ColumnNames.DepartmentID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.DepartmentID);
				else
					this.DepartmentID = base.SetintAsString(ColumnNames.DepartmentID, value);
			}
		}

		public virtual string s_DepartmentName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.DepartmentName) ? string.Empty : base.GetstringAsString(ColumnNames.DepartmentName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.DepartmentName);
				else
					this.DepartmentName = base.SetstringAsString(ColumnNames.DepartmentName, value);
			}
		}

		public virtual string s_IsDeleted
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsDeleted) ? string.Empty : base.GetboolAsString(ColumnNames.IsDeleted);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsDeleted);
				else
					this.IsDeleted = base.SetboolAsString(ColumnNames.IsDeleted, value);
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
				
				
				public WhereParameter DepartmentID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.DepartmentID, Parameters.DepartmentID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter DepartmentName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.DepartmentName, Parameters.DepartmentName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsDeleted
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsDeleted, Parameters.IsDeleted);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter DepartmentID
		    {
				get
		        {
					if(_DepartmentID_W == null)
	        	    {
						_DepartmentID_W = TearOff.DepartmentID;
					}
					return _DepartmentID_W;
				}
			}

			public WhereParameter DepartmentName
		    {
				get
		        {
					if(_DepartmentName_W == null)
	        	    {
						_DepartmentName_W = TearOff.DepartmentName;
					}
					return _DepartmentName_W;
				}
			}

			public WhereParameter IsDeleted
		    {
				get
		        {
					if(_IsDeleted_W == null)
	        	    {
						_IsDeleted_W = TearOff.IsDeleted;
					}
					return _IsDeleted_W;
				}
			}

			private WhereParameter _DepartmentID_W = null;
			private WhereParameter _DepartmentName_W = null;
			private WhereParameter _IsDeleted_W = null;

			public void WhereClauseReset()
			{
				_DepartmentID_W = null;
				_DepartmentName_W = null;
				_IsDeleted_W = null;

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
				
				
				public AggregateParameter DepartmentID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.DepartmentID, Parameters.DepartmentID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter DepartmentName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.DepartmentName, Parameters.DepartmentName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsDeleted
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsDeleted, Parameters.IsDeleted);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter DepartmentID
		    {
				get
		        {
					if(_DepartmentID_W == null)
	        	    {
						_DepartmentID_W = TearOff.DepartmentID;
					}
					return _DepartmentID_W;
				}
			}

			public AggregateParameter DepartmentName
		    {
				get
		        {
					if(_DepartmentName_W == null)
	        	    {
						_DepartmentName_W = TearOff.DepartmentName;
					}
					return _DepartmentName_W;
				}
			}

			public AggregateParameter IsDeleted
		    {
				get
		        {
					if(_IsDeleted_W == null)
	        	    {
						_IsDeleted_W = TearOff.IsDeleted;
					}
					return _IsDeleted_W;
				}
			}

			private AggregateParameter _DepartmentID_W = null;
			private AggregateParameter _DepartmentName_W = null;
			private AggregateParameter _IsDeleted_W = null;

			public void AggregateClauseReset()
			{
				_DepartmentID_W = null;
				_DepartmentName_W = null;
				_IsDeleted_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_DepartmentInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.DepartmentID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_DepartmentUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_DepartmentDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.DepartmentID);
			p.SourceColumn = ColumnNames.DepartmentID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.DepartmentID);
			p.SourceColumn = ColumnNames.DepartmentID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.DepartmentName);
			p.SourceColumn = ColumnNames.DepartmentName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsDeleted);
			p.SourceColumn = ColumnNames.IsDeleted;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
