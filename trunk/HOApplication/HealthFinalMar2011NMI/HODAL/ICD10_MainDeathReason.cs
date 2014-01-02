
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

namespace MHO.DAL
{
	public abstract class _ICD10_MainDeathReason : SqlClientEntity
	{
		public _ICD10_MainDeathReason()
		{
			this.QuerySource = "ICD10_MainDeathReason";
			this.MappingName = "ICD10_MainDeathReason";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ICD10_MainDeathReasonLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ID, ID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ICD10_MainDeathReasonLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter Code
			{
				get
				{
					return new SqlParameter("@Code", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter Causename
			{
				get
				{
					return new SqlParameter("@Causename", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter ID
			{
				get
				{
					return new SqlParameter("@ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Gender
			{
				get
				{
					return new SqlParameter("@Gender", SqlDbType.SmallInt, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Code = "code";
            public const string Causename = "causename";
            public const string ID = "ID";
            public const string Gender = "Gender";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Code] = _ICD10_MainDeathReason.PropertyNames.Code;
					ht[Causename] = _ICD10_MainDeathReason.PropertyNames.Causename;
					ht[ID] = _ICD10_MainDeathReason.PropertyNames.ID;
					ht[Gender] = _ICD10_MainDeathReason.PropertyNames.Gender;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Code = "Code";
            public const string Causename = "Causename";
            public const string ID = "ID";
            public const string Gender = "Gender";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Code] = _ICD10_MainDeathReason.ColumnNames.Code;
					ht[Causename] = _ICD10_MainDeathReason.ColumnNames.Causename;
					ht[ID] = _ICD10_MainDeathReason.ColumnNames.ID;
					ht[Gender] = _ICD10_MainDeathReason.ColumnNames.Gender;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Code = "s_Code";
            public const string Causename = "s_Causename";
            public const string ID = "s_ID";
            public const string Gender = "s_Gender";

		}
		#endregion		
		
		#region Properties
	
		public virtual string Code
	    {
			get
	        {
				return base.Getstring(ColumnNames.Code);
			}
			set
	        {
				base.Setstring(ColumnNames.Code, value);
			}
		}

		public virtual string Causename
	    {
			get
	        {
				return base.Getstring(ColumnNames.Causename);
			}
			set
	        {
				base.Setstring(ColumnNames.Causename, value);
			}
		}

		public virtual int ID
	    {
			get
	        {
				return base.Getint(ColumnNames.ID);
			}
			set
	        {
				base.Setint(ColumnNames.ID, value);
			}
		}

		public virtual short Gender
	    {
			get
	        {
				return base.Getshort(ColumnNames.Gender);
			}
			set
	        {
				base.Setshort(ColumnNames.Gender, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Code
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Code) ? string.Empty : base.GetstringAsString(ColumnNames.Code);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Code);
				else
					this.Code = base.SetstringAsString(ColumnNames.Code, value);
			}
		}

		public virtual string s_Causename
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Causename) ? string.Empty : base.GetstringAsString(ColumnNames.Causename);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Causename);
				else
					this.Causename = base.SetstringAsString(ColumnNames.Causename, value);
			}
		}

		public virtual string s_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ID) ? string.Empty : base.GetintAsString(ColumnNames.ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ID);
				else
					this.ID = base.SetintAsString(ColumnNames.ID, value);
			}
		}

		public virtual string s_Gender
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Gender) ? string.Empty : base.GetshortAsString(ColumnNames.Gender);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Gender);
				else
					this.Gender = base.SetshortAsString(ColumnNames.Gender, value);
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
				
				
				public WhereParameter Code
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Code, Parameters.Code);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Causename
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Causename, Parameters.Causename);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Gender
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Gender, Parameters.Gender);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Code
		    {
				get
		        {
					if(_Code_W == null)
	        	    {
						_Code_W = TearOff.Code;
					}
					return _Code_W;
				}
			}

			public WhereParameter Causename
		    {
				get
		        {
					if(_Causename_W == null)
	        	    {
						_Causename_W = TearOff.Causename;
					}
					return _Causename_W;
				}
			}

			public WhereParameter ID
		    {
				get
		        {
					if(_ID_W == null)
	        	    {
						_ID_W = TearOff.ID;
					}
					return _ID_W;
				}
			}

			public WhereParameter Gender
		    {
				get
		        {
					if(_Gender_W == null)
	        	    {
						_Gender_W = TearOff.Gender;
					}
					return _Gender_W;
				}
			}

			private WhereParameter _Code_W = null;
			private WhereParameter _Causename_W = null;
			private WhereParameter _ID_W = null;
			private WhereParameter _Gender_W = null;

			public void WhereClauseReset()
			{
				_Code_W = null;
				_Causename_W = null;
				_ID_W = null;
				_Gender_W = null;

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
				
				
				public AggregateParameter Code
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Code, Parameters.Code);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Causename
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Causename, Parameters.Causename);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Gender
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Gender, Parameters.Gender);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Code
		    {
				get
		        {
					if(_Code_W == null)
	        	    {
						_Code_W = TearOff.Code;
					}
					return _Code_W;
				}
			}

			public AggregateParameter Causename
		    {
				get
		        {
					if(_Causename_W == null)
	        	    {
						_Causename_W = TearOff.Causename;
					}
					return _Causename_W;
				}
			}

			public AggregateParameter ID
		    {
				get
		        {
					if(_ID_W == null)
	        	    {
						_ID_W = TearOff.ID;
					}
					return _ID_W;
				}
			}

			public AggregateParameter Gender
		    {
				get
		        {
					if(_Gender_W == null)
	        	    {
						_Gender_W = TearOff.Gender;
					}
					return _Gender_W;
				}
			}

			private AggregateParameter _Code_W = null;
			private AggregateParameter _Causename_W = null;
			private AggregateParameter _ID_W = null;
			private AggregateParameter _Gender_W = null;

			public void AggregateClauseReset()
			{
				_Code_W = null;
				_Causename_W = null;
				_ID_W = null;
				_Gender_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ICD10_MainDeathReasonInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ICD10_MainDeathReasonUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ICD10_MainDeathReasonDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Code);
			p.SourceColumn = ColumnNames.Code;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Causename);
			p.SourceColumn = ColumnNames.Causename;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Gender);
			p.SourceColumn = ColumnNames.Gender;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
