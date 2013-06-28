
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

namespace Flight_DAL
{
	public abstract class _Course : SqlClientEntity
	{
		public _Course()
		{
			this.QuerySource = "Course";
			this.MappingName = "Course";
            this.SchemaTableView = "Training.";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CourseLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int CourseID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.CourseID, CourseID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CourseLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter CourseID
			{
				get
				{
					return new SqlParameter("@CourseID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Name
			{
				get
				{
					return new SqlParameter("@Name", SqlDbType.NVarChar, 2000);
				}
			}
			
			public static SqlParameter Code
			{
				get
				{
					return new SqlParameter("@Code", SqlDbType.NVarChar, 100);
				}
			}
			
			public static SqlParameter Description
			{
				get
				{
					return new SqlParameter("@Description", SqlDbType.NVarChar, 2000);
				}
			}
			
			public static SqlParameter AlertDatePeriod
			{
				get
				{
					return new SqlParameter("@AlertDatePeriod", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ExpiryDate_Period
			{
				get
				{
					return new SqlParameter("@ExpiryDate_Period", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string CourseID = "CourseID";
            public const string Name = "Name";
            public const string Code = "Code";
            public const string Description = "Description";
            public const string AlertDatePeriod = "AlertDatePeriod";
            public const string ExpiryDate_Period = "ExpiryDate_Period";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CourseID] = _Course.PropertyNames.CourseID;
					ht[Name] = _Course.PropertyNames.Name;
					ht[Code] = _Course.PropertyNames.Code;
					ht[Description] = _Course.PropertyNames.Description;
					ht[AlertDatePeriod] = _Course.PropertyNames.AlertDatePeriod;
					ht[ExpiryDate_Period] = _Course.PropertyNames.ExpiryDate_Period;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string CourseID = "CourseID";
            public const string Name = "Name";
            public const string Code = "Code";
            public const string Description = "Description";
            public const string AlertDatePeriod = "AlertDatePeriod";
            public const string ExpiryDate_Period = "ExpiryDate_Period";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CourseID] = _Course.ColumnNames.CourseID;
					ht[Name] = _Course.ColumnNames.Name;
					ht[Code] = _Course.ColumnNames.Code;
					ht[Description] = _Course.ColumnNames.Description;
					ht[AlertDatePeriod] = _Course.ColumnNames.AlertDatePeriod;
					ht[ExpiryDate_Period] = _Course.ColumnNames.ExpiryDate_Period;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string CourseID = "s_CourseID";
            public const string Name = "s_Name";
            public const string Code = "s_Code";
            public const string Description = "s_Description";
            public const string AlertDatePeriod = "s_AlertDatePeriod";
            public const string ExpiryDate_Period = "s_ExpiryDate_Period";

		}
		#endregion		
		
		#region Properties
	
		public virtual int CourseID
	    {
			get
	        {
				return base.Getint(ColumnNames.CourseID);
			}
			set
	        {
				base.Setint(ColumnNames.CourseID, value);
			}
		}

		public virtual string Name
	    {
			get
	        {
				return base.Getstring(ColumnNames.Name);
			}
			set
	        {
				base.Setstring(ColumnNames.Name, value);
			}
		}

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

		public virtual string Description
	    {
			get
	        {
				return base.Getstring(ColumnNames.Description);
			}
			set
	        {
				base.Setstring(ColumnNames.Description, value);
			}
		}

		public virtual int AlertDatePeriod
	    {
			get
	        {
				return base.Getint(ColumnNames.AlertDatePeriod);
			}
			set
	        {
				base.Setint(ColumnNames.AlertDatePeriod, value);
			}
		}

		public virtual int ExpiryDate_Period
	    {
			get
	        {
				return base.Getint(ColumnNames.ExpiryDate_Period);
			}
			set
	        {
				base.Setint(ColumnNames.ExpiryDate_Period, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_CourseID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CourseID) ? string.Empty : base.GetintAsString(ColumnNames.CourseID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CourseID);
				else
					this.CourseID = base.SetintAsString(ColumnNames.CourseID, value);
			}
		}

		public virtual string s_Name
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Name) ? string.Empty : base.GetstringAsString(ColumnNames.Name);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Name);
				else
					this.Name = base.SetstringAsString(ColumnNames.Name, value);
			}
		}

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

		public virtual string s_Description
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Description) ? string.Empty : base.GetstringAsString(ColumnNames.Description);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Description);
				else
					this.Description = base.SetstringAsString(ColumnNames.Description, value);
			}
		}

		public virtual string s_AlertDatePeriod
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AlertDatePeriod) ? string.Empty : base.GetintAsString(ColumnNames.AlertDatePeriod);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AlertDatePeriod);
				else
					this.AlertDatePeriod = base.SetintAsString(ColumnNames.AlertDatePeriod, value);
			}
		}

		public virtual string s_ExpiryDate_Period
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ExpiryDate_Period) ? string.Empty : base.GetintAsString(ColumnNames.ExpiryDate_Period);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ExpiryDate_Period);
				else
					this.ExpiryDate_Period = base.SetintAsString(ColumnNames.ExpiryDate_Period, value);
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
				
				
				public WhereParameter CourseID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CourseID, Parameters.CourseID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Name
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Name, Parameters.Name);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
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

				public WhereParameter Description
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Description, Parameters.Description);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AlertDatePeriod
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AlertDatePeriod, Parameters.AlertDatePeriod);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ExpiryDate_Period
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ExpiryDate_Period, Parameters.ExpiryDate_Period);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter CourseID
		    {
				get
		        {
					if(_CourseID_W == null)
	        	    {
						_CourseID_W = TearOff.CourseID;
					}
					return _CourseID_W;
				}
			}

			public WhereParameter Name
		    {
				get
		        {
					if(_Name_W == null)
	        	    {
						_Name_W = TearOff.Name;
					}
					return _Name_W;
				}
			}

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

			public WhereParameter Description
		    {
				get
		        {
					if(_Description_W == null)
	        	    {
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public WhereParameter AlertDatePeriod
		    {
				get
		        {
					if(_AlertDatePeriod_W == null)
	        	    {
						_AlertDatePeriod_W = TearOff.AlertDatePeriod;
					}
					return _AlertDatePeriod_W;
				}
			}

			public WhereParameter ExpiryDate_Period
		    {
				get
		        {
					if(_ExpiryDate_Period_W == null)
	        	    {
						_ExpiryDate_Period_W = TearOff.ExpiryDate_Period;
					}
					return _ExpiryDate_Period_W;
				}
			}

			private WhereParameter _CourseID_W = null;
			private WhereParameter _Name_W = null;
			private WhereParameter _Code_W = null;
			private WhereParameter _Description_W = null;
			private WhereParameter _AlertDatePeriod_W = null;
			private WhereParameter _ExpiryDate_Period_W = null;

			public void WhereClauseReset()
			{
				_CourseID_W = null;
				_Name_W = null;
				_Code_W = null;
				_Description_W = null;
				_AlertDatePeriod_W = null;
				_ExpiryDate_Period_W = null;

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
				
				
				public AggregateParameter CourseID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CourseID, Parameters.CourseID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Name
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Name, Parameters.Name);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
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

				public AggregateParameter Description
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Description, Parameters.Description);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AlertDatePeriod
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AlertDatePeriod, Parameters.AlertDatePeriod);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ExpiryDate_Period
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ExpiryDate_Period, Parameters.ExpiryDate_Period);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter CourseID
		    {
				get
		        {
					if(_CourseID_W == null)
	        	    {
						_CourseID_W = TearOff.CourseID;
					}
					return _CourseID_W;
				}
			}

			public AggregateParameter Name
		    {
				get
		        {
					if(_Name_W == null)
	        	    {
						_Name_W = TearOff.Name;
					}
					return _Name_W;
				}
			}

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

			public AggregateParameter Description
		    {
				get
		        {
					if(_Description_W == null)
	        	    {
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public AggregateParameter AlertDatePeriod
		    {
				get
		        {
					if(_AlertDatePeriod_W == null)
	        	    {
						_AlertDatePeriod_W = TearOff.AlertDatePeriod;
					}
					return _AlertDatePeriod_W;
				}
			}

			public AggregateParameter ExpiryDate_Period
		    {
				get
		        {
					if(_ExpiryDate_Period_W == null)
	        	    {
						_ExpiryDate_Period_W = TearOff.ExpiryDate_Period;
					}
					return _ExpiryDate_Period_W;
				}
			}

			private AggregateParameter _CourseID_W = null;
			private AggregateParameter _Name_W = null;
			private AggregateParameter _Code_W = null;
			private AggregateParameter _Description_W = null;
			private AggregateParameter _AlertDatePeriod_W = null;
			private AggregateParameter _ExpiryDate_Period_W = null;

			public void AggregateClauseReset()
			{
				_CourseID_W = null;
				_Name_W = null;
				_Code_W = null;
				_Description_W = null;
				_AlertDatePeriod_W = null;
				_ExpiryDate_Period_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CourseInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.CourseID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CourseUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CourseDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.CourseID);
			p.SourceColumn = ColumnNames.CourseID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.CourseID);
			p.SourceColumn = ColumnNames.CourseID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Name);
			p.SourceColumn = ColumnNames.Name;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Code);
			p.SourceColumn = ColumnNames.Code;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Description);
			p.SourceColumn = ColumnNames.Description;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AlertDatePeriod);
			p.SourceColumn = ColumnNames.AlertDatePeriod;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ExpiryDate_Period);
			p.SourceColumn = ColumnNames.ExpiryDate_Period;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
