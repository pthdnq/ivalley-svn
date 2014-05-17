
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
	public abstract class _ICD10CAT : SqlClientEntity
	{
		public _ICD10CAT()
		{
			this.QuerySource = "ICD10CAT";
			this.MappingName = "ICD10CAT";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ICD10CATLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int CATID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.CATID, CATID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ICD10CATLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter CATID
			{
				get
				{
					return new SqlParameter("@CATID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CATDESCRENG
			{
				get
				{
					return new SqlParameter("@CATDESCRENG", SqlDbType.Char, 150);
				}
			}
			
			public static SqlParameter CATDESCRAR
			{
				get
				{
					return new SqlParameter("@CATDESCRAR", SqlDbType.Char, 150);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string CATID = "CATID";
            public const string CATDESCRENG = "CATDESCRENG";
            public const string CATDESCRAR = "CATDESCRAR";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CATID] = _ICD10CAT.PropertyNames.CATID;
					ht[CATDESCRENG] = _ICD10CAT.PropertyNames.CATDESCRENG;
					ht[CATDESCRAR] = _ICD10CAT.PropertyNames.CATDESCRAR;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string CATID = "CATID";
            public const string CATDESCRENG = "CATDESCRENG";
            public const string CATDESCRAR = "CATDESCRAR";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CATID] = _ICD10CAT.ColumnNames.CATID;
					ht[CATDESCRENG] = _ICD10CAT.ColumnNames.CATDESCRENG;
					ht[CATDESCRAR] = _ICD10CAT.ColumnNames.CATDESCRAR;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string CATID = "s_CATID";
            public const string CATDESCRENG = "s_CATDESCRENG";
            public const string CATDESCRAR = "s_CATDESCRAR";

		}
		#endregion		
		
		#region Properties
	
		public virtual int CATID
	    {
			get
	        {
				return base.Getint(ColumnNames.CATID);
			}
			set
	        {
				base.Setint(ColumnNames.CATID, value);
			}
		}

		public virtual string CATDESCRENG
	    {
			get
	        {
				return base.Getstring(ColumnNames.CATDESCRENG);
			}
			set
	        {
				base.Setstring(ColumnNames.CATDESCRENG, value);
			}
		}

		public virtual string CATDESCRAR
	    {
			get
	        {
				return base.Getstring(ColumnNames.CATDESCRAR);
			}
			set
	        {
				base.Setstring(ColumnNames.CATDESCRAR, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_CATID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CATID) ? string.Empty : base.GetintAsString(ColumnNames.CATID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CATID);
				else
					this.CATID = base.SetintAsString(ColumnNames.CATID, value);
			}
		}

		public virtual string s_CATDESCRENG
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CATDESCRENG) ? string.Empty : base.GetstringAsString(ColumnNames.CATDESCRENG);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CATDESCRENG);
				else
					this.CATDESCRENG = base.SetstringAsString(ColumnNames.CATDESCRENG, value);
			}
		}

		public virtual string s_CATDESCRAR
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CATDESCRAR) ? string.Empty : base.GetstringAsString(ColumnNames.CATDESCRAR);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CATDESCRAR);
				else
					this.CATDESCRAR = base.SetstringAsString(ColumnNames.CATDESCRAR, value);
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
				
				
				public WhereParameter CATID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CATID, Parameters.CATID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CATDESCRENG
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CATDESCRENG, Parameters.CATDESCRENG);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CATDESCRAR
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CATDESCRAR, Parameters.CATDESCRAR);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter CATID
		    {
				get
		        {
					if(_CATID_W == null)
	        	    {
						_CATID_W = TearOff.CATID;
					}
					return _CATID_W;
				}
			}

			public WhereParameter CATDESCRENG
		    {
				get
		        {
					if(_CATDESCRENG_W == null)
	        	    {
						_CATDESCRENG_W = TearOff.CATDESCRENG;
					}
					return _CATDESCRENG_W;
				}
			}

			public WhereParameter CATDESCRAR
		    {
				get
		        {
					if(_CATDESCRAR_W == null)
	        	    {
						_CATDESCRAR_W = TearOff.CATDESCRAR;
					}
					return _CATDESCRAR_W;
				}
			}

			private WhereParameter _CATID_W = null;
			private WhereParameter _CATDESCRENG_W = null;
			private WhereParameter _CATDESCRAR_W = null;

			public void WhereClauseReset()
			{
				_CATID_W = null;
				_CATDESCRENG_W = null;
				_CATDESCRAR_W = null;

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
				
				
				public AggregateParameter CATID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CATID, Parameters.CATID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CATDESCRENG
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CATDESCRENG, Parameters.CATDESCRENG);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CATDESCRAR
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CATDESCRAR, Parameters.CATDESCRAR);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter CATID
		    {
				get
		        {
					if(_CATID_W == null)
	        	    {
						_CATID_W = TearOff.CATID;
					}
					return _CATID_W;
				}
			}

			public AggregateParameter CATDESCRENG
		    {
				get
		        {
					if(_CATDESCRENG_W == null)
	        	    {
						_CATDESCRENG_W = TearOff.CATDESCRENG;
					}
					return _CATDESCRENG_W;
				}
			}

			public AggregateParameter CATDESCRAR
		    {
				get
		        {
					if(_CATDESCRAR_W == null)
	        	    {
						_CATDESCRAR_W = TearOff.CATDESCRAR;
					}
					return _CATDESCRAR_W;
				}
			}

			private AggregateParameter _CATID_W = null;
			private AggregateParameter _CATDESCRENG_W = null;
			private AggregateParameter _CATDESCRAR_W = null;

			public void AggregateClauseReset()
			{
				_CATID_W = null;
				_CATDESCRENG_W = null;
				_CATDESCRAR_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ICD10CATInsert]";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ICD10CATUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ICD10CATDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.CATID);
			p.SourceColumn = ColumnNames.CATID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.CATID);
			p.SourceColumn = ColumnNames.CATID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CATDESCRENG);
			p.SourceColumn = ColumnNames.CATDESCRENG;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CATDESCRAR);
			p.SourceColumn = ColumnNames.CATDESCRAR;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}