
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

// Generated by MyGeneration Version # (1.2.0.7)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace MHO.DAL
{
	public abstract class _ICDCODE9000 : SqlClientEntity
	{
		public _ICDCODE9000()
		{
			this.QuerySource = "ICDCODE9000";
			this.MappingName = "ICDCODE9000";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ICDCODE9000LoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(string CODE)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.CODE, CODE);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ICDCODE9000LoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter CODE
			{
				get
				{
					return new SqlParameter("@CODE", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter DESCRENG
			{
				get
				{
					return new SqlParameter("@DESCRENG", SqlDbType.NVarChar, 255);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string CODE = "CODE";
            public const string DESCRENG = "DESCRENG";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CODE] = _ICDCODE9000.PropertyNames.CODE;
					ht[DESCRENG] = _ICDCODE9000.PropertyNames.DESCRENG;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string CODE = "CODE";
            public const string DESCRENG = "DESCRENG";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CODE] = _ICDCODE9000.ColumnNames.CODE;
					ht[DESCRENG] = _ICDCODE9000.ColumnNames.DESCRENG;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string CODE = "s_CODE";
            public const string DESCRENG = "s_DESCRENG";

		}
		#endregion		
		
		#region Properties
	
		public virtual string CODE
	    {
			get
	        {
				return base.Getstring(ColumnNames.CODE);
			}
			set
	        {
				base.Setstring(ColumnNames.CODE, value);
			}
		}

		public virtual string DESCRENG
	    {
			get
	        {
				return base.Getstring(ColumnNames.DESCRENG);
			}
			set
	        {
				base.Setstring(ColumnNames.DESCRENG, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_CODE
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CODE) ? string.Empty : base.GetstringAsString(ColumnNames.CODE);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CODE);
				else
					this.CODE = base.SetstringAsString(ColumnNames.CODE, value);
			}
		}

		public virtual string s_DESCRENG
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.DESCRENG) ? string.Empty : base.GetstringAsString(ColumnNames.DESCRENG);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.DESCRENG);
				else
					this.DESCRENG = base.SetstringAsString(ColumnNames.DESCRENG, value);
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
				
				
				public WhereParameter CODE
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CODE, Parameters.CODE);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter DESCRENG
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.DESCRENG, Parameters.DESCRENG);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter CODE
		    {
				get
		        {
					if(_CODE_W == null)
	        	    {
						_CODE_W = TearOff.CODE;
					}
					return _CODE_W;
				}
			}

			public WhereParameter DESCRENG
		    {
				get
		        {
					if(_DESCRENG_W == null)
	        	    {
						_DESCRENG_W = TearOff.DESCRENG;
					}
					return _DESCRENG_W;
				}
			}

			private WhereParameter _CODE_W = null;
			private WhereParameter _DESCRENG_W = null;

			public void WhereClauseReset()
			{
				_CODE_W = null;
				_DESCRENG_W = null;

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
				
				
				public AggregateParameter CODE
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CODE, Parameters.CODE);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter DESCRENG
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.DESCRENG, Parameters.DESCRENG);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter CODE
		    {
				get
		        {
					if(_CODE_W == null)
	        	    {
						_CODE_W = TearOff.CODE;
					}
					return _CODE_W;
				}
			}

			public AggregateParameter DESCRENG
		    {
				get
		        {
					if(_DESCRENG_W == null)
	        	    {
						_DESCRENG_W = TearOff.DESCRENG;
					}
					return _DESCRENG_W;
				}
			}

			private AggregateParameter _CODE_W = null;
			private AggregateParameter _DESCRENG_W = null;

			public void AggregateClauseReset()
			{
				_CODE_W = null;
				_DESCRENG_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ICDCODE9000Insert]";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ICDCODE9000Update]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ICDCODE9000Delete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.CODE);
			p.SourceColumn = ColumnNames.CODE;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.CODE);
			p.SourceColumn = ColumnNames.CODE;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.DESCRENG);
			p.SourceColumn = ColumnNames.DESCRENG;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
