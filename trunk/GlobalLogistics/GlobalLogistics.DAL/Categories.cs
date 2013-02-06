
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
	public abstract class _Categories : SqlClientEntity
	{
		public _Categories()
		{
			this.QuerySource = "Categories";
			this.MappingName = "Categories";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CategoriesLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int CategoryID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.CategoryID, CategoryID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CategoriesLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter CategoryID
			{
				get
				{
					return new SqlParameter("@CategoryID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter EnName
			{
				get
				{
					return new SqlParameter("@EnName", SqlDbType.NVarChar, 200);
				}
			}
			
			public static SqlParameter ArName
			{
				get
				{
					return new SqlParameter("@ArName", SqlDbType.NVarChar, 200);
				}
			}
			
			public static SqlParameter EnDescription
			{
				get
				{
					return new SqlParameter("@EnDescription", SqlDbType.NVarChar, 500);
				}
			}
			
			public static SqlParameter ArDescription
			{
				get
				{
					return new SqlParameter("@ArDescription", SqlDbType.NVarChar, 500);
				}
			}
			
			public static SqlParameter IconPath
			{
				get
				{
					return new SqlParameter("@IconPath", SqlDbType.NVarChar, 250);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string CategoryID = "CategoryID";
            public const string EnName = "EnName";
            public const string ArName = "ArName";
            public const string EnDescription = "EnDescription";
            public const string ArDescription = "ArDescription";
            public const string IconPath = "IconPath";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CategoryID] = _Categories.PropertyNames.CategoryID;
					ht[EnName] = _Categories.PropertyNames.EnName;
					ht[ArName] = _Categories.PropertyNames.ArName;
					ht[EnDescription] = _Categories.PropertyNames.EnDescription;
					ht[ArDescription] = _Categories.PropertyNames.ArDescription;
					ht[IconPath] = _Categories.PropertyNames.IconPath;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string CategoryID = "CategoryID";
            public const string EnName = "EnName";
            public const string ArName = "ArName";
            public const string EnDescription = "EnDescription";
            public const string ArDescription = "ArDescription";
            public const string IconPath = "IconPath";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CategoryID] = _Categories.ColumnNames.CategoryID;
					ht[EnName] = _Categories.ColumnNames.EnName;
					ht[ArName] = _Categories.ColumnNames.ArName;
					ht[EnDescription] = _Categories.ColumnNames.EnDescription;
					ht[ArDescription] = _Categories.ColumnNames.ArDescription;
					ht[IconPath] = _Categories.ColumnNames.IconPath;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string CategoryID = "s_CategoryID";
            public const string EnName = "s_EnName";
            public const string ArName = "s_ArName";
            public const string EnDescription = "s_EnDescription";
            public const string ArDescription = "s_ArDescription";
            public const string IconPath = "s_IconPath";

		}
		#endregion		
		
		#region Properties
	
		public virtual int CategoryID
	    {
			get
	        {
				return base.Getint(ColumnNames.CategoryID);
			}
			set
	        {
				base.Setint(ColumnNames.CategoryID, value);
			}
		}

		public virtual string EnName
	    {
			get
	        {
				return base.Getstring(ColumnNames.EnName);
			}
			set
	        {
				base.Setstring(ColumnNames.EnName, value);
			}
		}

		public virtual string ArName
	    {
			get
	        {
				return base.Getstring(ColumnNames.ArName);
			}
			set
	        {
				base.Setstring(ColumnNames.ArName, value);
			}
		}

		public virtual string EnDescription
	    {
			get
	        {
				return base.Getstring(ColumnNames.EnDescription);
			}
			set
	        {
				base.Setstring(ColumnNames.EnDescription, value);
			}
		}

		public virtual string ArDescription
	    {
			get
	        {
				return base.Getstring(ColumnNames.ArDescription);
			}
			set
	        {
				base.Setstring(ColumnNames.ArDescription, value);
			}
		}

		public virtual string IconPath
	    {
			get
	        {
				return base.Getstring(ColumnNames.IconPath);
			}
			set
	        {
				base.Setstring(ColumnNames.IconPath, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_CategoryID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CategoryID) ? string.Empty : base.GetintAsString(ColumnNames.CategoryID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CategoryID);
				else
					this.CategoryID = base.SetintAsString(ColumnNames.CategoryID, value);
			}
		}

		public virtual string s_EnName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.EnName) ? string.Empty : base.GetstringAsString(ColumnNames.EnName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.EnName);
				else
					this.EnName = base.SetstringAsString(ColumnNames.EnName, value);
			}
		}

		public virtual string s_ArName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ArName) ? string.Empty : base.GetstringAsString(ColumnNames.ArName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ArName);
				else
					this.ArName = base.SetstringAsString(ColumnNames.ArName, value);
			}
		}

		public virtual string s_EnDescription
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.EnDescription) ? string.Empty : base.GetstringAsString(ColumnNames.EnDescription);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.EnDescription);
				else
					this.EnDescription = base.SetstringAsString(ColumnNames.EnDescription, value);
			}
		}

		public virtual string s_ArDescription
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ArDescription) ? string.Empty : base.GetstringAsString(ColumnNames.ArDescription);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ArDescription);
				else
					this.ArDescription = base.SetstringAsString(ColumnNames.ArDescription, value);
			}
		}

		public virtual string s_IconPath
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IconPath) ? string.Empty : base.GetstringAsString(ColumnNames.IconPath);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IconPath);
				else
					this.IconPath = base.SetstringAsString(ColumnNames.IconPath, value);
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
				
				
				public WhereParameter CategoryID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CategoryID, Parameters.CategoryID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter EnName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.EnName, Parameters.EnName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ArName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ArName, Parameters.ArName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter EnDescription
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.EnDescription, Parameters.EnDescription);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ArDescription
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ArDescription, Parameters.ArDescription);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IconPath
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IconPath, Parameters.IconPath);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter CategoryID
		    {
				get
		        {
					if(_CategoryID_W == null)
	        	    {
						_CategoryID_W = TearOff.CategoryID;
					}
					return _CategoryID_W;
				}
			}

			public WhereParameter EnName
		    {
				get
		        {
					if(_EnName_W == null)
	        	    {
						_EnName_W = TearOff.EnName;
					}
					return _EnName_W;
				}
			}

			public WhereParameter ArName
		    {
				get
		        {
					if(_ArName_W == null)
	        	    {
						_ArName_W = TearOff.ArName;
					}
					return _ArName_W;
				}
			}

			public WhereParameter EnDescription
		    {
				get
		        {
					if(_EnDescription_W == null)
	        	    {
						_EnDescription_W = TearOff.EnDescription;
					}
					return _EnDescription_W;
				}
			}

			public WhereParameter ArDescription
		    {
				get
		        {
					if(_ArDescription_W == null)
	        	    {
						_ArDescription_W = TearOff.ArDescription;
					}
					return _ArDescription_W;
				}
			}

			public WhereParameter IconPath
		    {
				get
		        {
					if(_IconPath_W == null)
	        	    {
						_IconPath_W = TearOff.IconPath;
					}
					return _IconPath_W;
				}
			}

			private WhereParameter _CategoryID_W = null;
			private WhereParameter _EnName_W = null;
			private WhereParameter _ArName_W = null;
			private WhereParameter _EnDescription_W = null;
			private WhereParameter _ArDescription_W = null;
			private WhereParameter _IconPath_W = null;

			public void WhereClauseReset()
			{
				_CategoryID_W = null;
				_EnName_W = null;
				_ArName_W = null;
				_EnDescription_W = null;
				_ArDescription_W = null;
				_IconPath_W = null;

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
				
				
				public AggregateParameter CategoryID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CategoryID, Parameters.CategoryID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter EnName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.EnName, Parameters.EnName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ArName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ArName, Parameters.ArName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter EnDescription
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.EnDescription, Parameters.EnDescription);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ArDescription
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ArDescription, Parameters.ArDescription);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IconPath
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IconPath, Parameters.IconPath);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter CategoryID
		    {
				get
		        {
					if(_CategoryID_W == null)
	        	    {
						_CategoryID_W = TearOff.CategoryID;
					}
					return _CategoryID_W;
				}
			}

			public AggregateParameter EnName
		    {
				get
		        {
					if(_EnName_W == null)
	        	    {
						_EnName_W = TearOff.EnName;
					}
					return _EnName_W;
				}
			}

			public AggregateParameter ArName
		    {
				get
		        {
					if(_ArName_W == null)
	        	    {
						_ArName_W = TearOff.ArName;
					}
					return _ArName_W;
				}
			}

			public AggregateParameter EnDescription
		    {
				get
		        {
					if(_EnDescription_W == null)
	        	    {
						_EnDescription_W = TearOff.EnDescription;
					}
					return _EnDescription_W;
				}
			}

			public AggregateParameter ArDescription
		    {
				get
		        {
					if(_ArDescription_W == null)
	        	    {
						_ArDescription_W = TearOff.ArDescription;
					}
					return _ArDescription_W;
				}
			}

			public AggregateParameter IconPath
		    {
				get
		        {
					if(_IconPath_W == null)
	        	    {
						_IconPath_W = TearOff.IconPath;
					}
					return _IconPath_W;
				}
			}

			private AggregateParameter _CategoryID_W = null;
			private AggregateParameter _EnName_W = null;
			private AggregateParameter _ArName_W = null;
			private AggregateParameter _EnDescription_W = null;
			private AggregateParameter _ArDescription_W = null;
			private AggregateParameter _IconPath_W = null;

			public void AggregateClauseReset()
			{
				_CategoryID_W = null;
				_EnName_W = null;
				_ArName_W = null;
				_EnDescription_W = null;
				_ArDescription_W = null;
				_IconPath_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CategoriesInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.CategoryID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CategoriesUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CategoriesDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.CategoryID);
			p.SourceColumn = ColumnNames.CategoryID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.CategoryID);
			p.SourceColumn = ColumnNames.CategoryID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.EnName);
			p.SourceColumn = ColumnNames.EnName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ArName);
			p.SourceColumn = ColumnNames.ArName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.EnDescription);
			p.SourceColumn = ColumnNames.EnDescription;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ArDescription);
			p.SourceColumn = ColumnNames.ArDescription;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IconPath);
			p.SourceColumn = ColumnNames.IconPath;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
