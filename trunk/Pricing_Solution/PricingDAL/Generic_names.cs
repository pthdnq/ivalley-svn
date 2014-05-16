
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
	public abstract class _Generic_names : SqlClientEntity
	{
		public _Generic_names()
		{
			this.QuerySource = "Generic_names";
			this.MappingName = "Generic_names";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_Generic_namesLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int GenericID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.GenericID, GenericID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_Generic_namesLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter GenericID
			{
				get
				{
					return new SqlParameter("@GenericID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Generic_name
			{
				get
				{
					return new SqlParameter("@Generic_name", SqlDbType.NVarChar, 255);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string GenericID = "GenericID";
            public const string Generic_name = "Generic_name";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[GenericID] = _Generic_names.PropertyNames.GenericID;
					ht[Generic_name] = _Generic_names.PropertyNames.Generic_name;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string GenericID = "GenericID";
            public const string Generic_name = "Generic_name";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[GenericID] = _Generic_names.ColumnNames.GenericID;
					ht[Generic_name] = _Generic_names.ColumnNames.Generic_name;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string GenericID = "s_GenericID";
            public const string Generic_name = "s_Generic_name";

		}
		#endregion		
		
		#region Properties
	
		public virtual int GenericID
	    {
			get
	        {
				return base.Getint(ColumnNames.GenericID);
			}
			set
	        {
				base.Setint(ColumnNames.GenericID, value);
			}
		}

		public virtual string Generic_name
	    {
			get
	        {
				return base.Getstring(ColumnNames.Generic_name);
			}
			set
	        {
				base.Setstring(ColumnNames.Generic_name, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_GenericID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.GenericID) ? string.Empty : base.GetintAsString(ColumnNames.GenericID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.GenericID);
				else
					this.GenericID = base.SetintAsString(ColumnNames.GenericID, value);
			}
		}

		public virtual string s_Generic_name
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Generic_name) ? string.Empty : base.GetstringAsString(ColumnNames.Generic_name);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Generic_name);
				else
					this.Generic_name = base.SetstringAsString(ColumnNames.Generic_name, value);
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
				
				
				public WhereParameter GenericID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.GenericID, Parameters.GenericID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Generic_name
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Generic_name, Parameters.Generic_name);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter GenericID
		    {
				get
		        {
					if(_GenericID_W == null)
	        	    {
						_GenericID_W = TearOff.GenericID;
					}
					return _GenericID_W;
				}
			}

			public WhereParameter Generic_name
		    {
				get
		        {
					if(_Generic_name_W == null)
	        	    {
						_Generic_name_W = TearOff.Generic_name;
					}
					return _Generic_name_W;
				}
			}

			private WhereParameter _GenericID_W = null;
			private WhereParameter _Generic_name_W = null;

			public void WhereClauseReset()
			{
				_GenericID_W = null;
				_Generic_name_W = null;

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
				
				
				public AggregateParameter GenericID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.GenericID, Parameters.GenericID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Generic_name
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Generic_name, Parameters.Generic_name);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter GenericID
		    {
				get
		        {
					if(_GenericID_W == null)
	        	    {
						_GenericID_W = TearOff.GenericID;
					}
					return _GenericID_W;
				}
			}

			public AggregateParameter Generic_name
		    {
				get
		        {
					if(_Generic_name_W == null)
	        	    {
						_Generic_name_W = TearOff.Generic_name;
					}
					return _Generic_name_W;
				}
			}

			private AggregateParameter _GenericID_W = null;
			private AggregateParameter _Generic_name_W = null;

			public void AggregateClauseReset()
			{
				_GenericID_W = null;
				_Generic_name_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_Generic_namesInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.GenericID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_Generic_namesUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_Generic_namesDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.GenericID);
			p.SourceColumn = ColumnNames.GenericID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.GenericID);
			p.SourceColumn = ColumnNames.GenericID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Generic_name);
			p.SourceColumn = ColumnNames.Generic_name;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
