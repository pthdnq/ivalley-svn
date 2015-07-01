
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
	public abstract class _ManualLog : SqlClientEntity
	{
		public _ManualLog()
		{
			this.QuerySource = "ManualLog";
			this.MappingName = "ManualLog";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ManualLogLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ManualLogID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ManualLogID, ManualLogID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ManualLogLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ManualLogID
			{
				get
				{
					return new SqlParameter("@ManualLogID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ManualID
			{
				get
				{
					return new SqlParameter("@ManualID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ManualVersionID
			{
				get
				{
					return new SqlParameter("@ManualVersionID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ManualFormID
			{
				get
				{
					return new SqlParameter("@ManualFormID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter FromVersionID
			{
				get
				{
					return new SqlParameter("@FromVersionID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter UserID
			{
				get
				{
					return new SqlParameter("@UserID", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter ActionID
			{
				get
				{
					return new SqlParameter("@ActionID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter LogDate
			{
				get
				{
					return new SqlParameter("@LogDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter ManualCategoryID
			{
				get
				{
					return new SqlParameter("@ManualCategoryID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ManualLogID = "ManualLogID";
            public const string ManualID = "ManualID";
            public const string ManualVersionID = "ManualVersionID";
            public const string ManualFormID = "ManualFormID";
            public const string FromVersionID = "FromVersionID";
            public const string UserID = "UserID";
            public const string ActionID = "ActionID";
            public const string LogDate = "LogDate";
            public const string ManualCategoryID = "ManualCategoryID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ManualLogID] = _ManualLog.PropertyNames.ManualLogID;
					ht[ManualID] = _ManualLog.PropertyNames.ManualID;
					ht[ManualVersionID] = _ManualLog.PropertyNames.ManualVersionID;
					ht[ManualFormID] = _ManualLog.PropertyNames.ManualFormID;
					ht[FromVersionID] = _ManualLog.PropertyNames.FromVersionID;
					ht[UserID] = _ManualLog.PropertyNames.UserID;
					ht[ActionID] = _ManualLog.PropertyNames.ActionID;
					ht[LogDate] = _ManualLog.PropertyNames.LogDate;
					ht[ManualCategoryID] = _ManualLog.PropertyNames.ManualCategoryID;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ManualLogID = "ManualLogID";
            public const string ManualID = "ManualID";
            public const string ManualVersionID = "ManualVersionID";
            public const string ManualFormID = "ManualFormID";
            public const string FromVersionID = "FromVersionID";
            public const string UserID = "UserID";
            public const string ActionID = "ActionID";
            public const string LogDate = "LogDate";
            public const string ManualCategoryID = "ManualCategoryID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ManualLogID] = _ManualLog.ColumnNames.ManualLogID;
					ht[ManualID] = _ManualLog.ColumnNames.ManualID;
					ht[ManualVersionID] = _ManualLog.ColumnNames.ManualVersionID;
					ht[ManualFormID] = _ManualLog.ColumnNames.ManualFormID;
					ht[FromVersionID] = _ManualLog.ColumnNames.FromVersionID;
					ht[UserID] = _ManualLog.ColumnNames.UserID;
					ht[ActionID] = _ManualLog.ColumnNames.ActionID;
					ht[LogDate] = _ManualLog.ColumnNames.LogDate;
					ht[ManualCategoryID] = _ManualLog.ColumnNames.ManualCategoryID;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ManualLogID = "s_ManualLogID";
            public const string ManualID = "s_ManualID";
            public const string ManualVersionID = "s_ManualVersionID";
            public const string ManualFormID = "s_ManualFormID";
            public const string FromVersionID = "s_FromVersionID";
            public const string UserID = "s_UserID";
            public const string ActionID = "s_ActionID";
            public const string LogDate = "s_LogDate";
            public const string ManualCategoryID = "s_ManualCategoryID";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ManualLogID
	    {
			get
	        {
				return base.Getint(ColumnNames.ManualLogID);
			}
			set
	        {
				base.Setint(ColumnNames.ManualLogID, value);
			}
		}

		public virtual int ManualID
	    {
			get
	        {
				return base.Getint(ColumnNames.ManualID);
			}
			set
	        {
				base.Setint(ColumnNames.ManualID, value);
			}
		}

		public virtual int ManualVersionID
	    {
			get
	        {
				return base.Getint(ColumnNames.ManualVersionID);
			}
			set
	        {
				base.Setint(ColumnNames.ManualVersionID, value);
			}
		}

		public virtual int ManualFormID
	    {
			get
	        {
				return base.Getint(ColumnNames.ManualFormID);
			}
			set
	        {
				base.Setint(ColumnNames.ManualFormID, value);
			}
		}

		public virtual int FromVersionID
	    {
			get
	        {
				return base.Getint(ColumnNames.FromVersionID);
			}
			set
	        {
				base.Setint(ColumnNames.FromVersionID, value);
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

		public virtual int ActionID
	    {
			get
	        {
				return base.Getint(ColumnNames.ActionID);
			}
			set
	        {
				base.Setint(ColumnNames.ActionID, value);
			}
		}

		public virtual DateTime LogDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.LogDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.LogDate, value);
			}
		}

		public virtual int ManualCategoryID
	    {
			get
	        {
				return base.Getint(ColumnNames.ManualCategoryID);
			}
			set
	        {
				base.Setint(ColumnNames.ManualCategoryID, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ManualLogID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ManualLogID) ? string.Empty : base.GetintAsString(ColumnNames.ManualLogID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ManualLogID);
				else
					this.ManualLogID = base.SetintAsString(ColumnNames.ManualLogID, value);
			}
		}

		public virtual string s_ManualID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ManualID) ? string.Empty : base.GetintAsString(ColumnNames.ManualID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ManualID);
				else
					this.ManualID = base.SetintAsString(ColumnNames.ManualID, value);
			}
		}

		public virtual string s_ManualVersionID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ManualVersionID) ? string.Empty : base.GetintAsString(ColumnNames.ManualVersionID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ManualVersionID);
				else
					this.ManualVersionID = base.SetintAsString(ColumnNames.ManualVersionID, value);
			}
		}

		public virtual string s_ManualFormID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ManualFormID) ? string.Empty : base.GetintAsString(ColumnNames.ManualFormID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ManualFormID);
				else
					this.ManualFormID = base.SetintAsString(ColumnNames.ManualFormID, value);
			}
		}

		public virtual string s_FromVersionID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.FromVersionID) ? string.Empty : base.GetintAsString(ColumnNames.FromVersionID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.FromVersionID);
				else
					this.FromVersionID = base.SetintAsString(ColumnNames.FromVersionID, value);
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

		public virtual string s_ActionID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ActionID) ? string.Empty : base.GetintAsString(ColumnNames.ActionID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ActionID);
				else
					this.ActionID = base.SetintAsString(ColumnNames.ActionID, value);
			}
		}

		public virtual string s_LogDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LogDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.LogDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LogDate);
				else
					this.LogDate = base.SetDateTimeAsString(ColumnNames.LogDate, value);
			}
		}

		public virtual string s_ManualCategoryID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ManualCategoryID) ? string.Empty : base.GetintAsString(ColumnNames.ManualCategoryID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ManualCategoryID);
				else
					this.ManualCategoryID = base.SetintAsString(ColumnNames.ManualCategoryID, value);
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
				
				
				public WhereParameter ManualLogID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ManualLogID, Parameters.ManualLogID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ManualID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ManualID, Parameters.ManualID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ManualVersionID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ManualVersionID, Parameters.ManualVersionID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ManualFormID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ManualFormID, Parameters.ManualFormID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter FromVersionID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.FromVersionID, Parameters.FromVersionID);
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

				public WhereParameter ActionID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ActionID, Parameters.ActionID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter LogDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LogDate, Parameters.LogDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ManualCategoryID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ManualCategoryID, Parameters.ManualCategoryID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ManualLogID
		    {
				get
		        {
					if(_ManualLogID_W == null)
	        	    {
						_ManualLogID_W = TearOff.ManualLogID;
					}
					return _ManualLogID_W;
				}
			}

			public WhereParameter ManualID
		    {
				get
		        {
					if(_ManualID_W == null)
	        	    {
						_ManualID_W = TearOff.ManualID;
					}
					return _ManualID_W;
				}
			}

			public WhereParameter ManualVersionID
		    {
				get
		        {
					if(_ManualVersionID_W == null)
	        	    {
						_ManualVersionID_W = TearOff.ManualVersionID;
					}
					return _ManualVersionID_W;
				}
			}

			public WhereParameter ManualFormID
		    {
				get
		        {
					if(_ManualFormID_W == null)
	        	    {
						_ManualFormID_W = TearOff.ManualFormID;
					}
					return _ManualFormID_W;
				}
			}

			public WhereParameter FromVersionID
		    {
				get
		        {
					if(_FromVersionID_W == null)
	        	    {
						_FromVersionID_W = TearOff.FromVersionID;
					}
					return _FromVersionID_W;
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

			public WhereParameter ActionID
		    {
				get
		        {
					if(_ActionID_W == null)
	        	    {
						_ActionID_W = TearOff.ActionID;
					}
					return _ActionID_W;
				}
			}

			public WhereParameter LogDate
		    {
				get
		        {
					if(_LogDate_W == null)
	        	    {
						_LogDate_W = TearOff.LogDate;
					}
					return _LogDate_W;
				}
			}

			public WhereParameter ManualCategoryID
		    {
				get
		        {
					if(_ManualCategoryID_W == null)
	        	    {
						_ManualCategoryID_W = TearOff.ManualCategoryID;
					}
					return _ManualCategoryID_W;
				}
			}

			private WhereParameter _ManualLogID_W = null;
			private WhereParameter _ManualID_W = null;
			private WhereParameter _ManualVersionID_W = null;
			private WhereParameter _ManualFormID_W = null;
			private WhereParameter _FromVersionID_W = null;
			private WhereParameter _UserID_W = null;
			private WhereParameter _ActionID_W = null;
			private WhereParameter _LogDate_W = null;
			private WhereParameter _ManualCategoryID_W = null;

			public void WhereClauseReset()
			{
				_ManualLogID_W = null;
				_ManualID_W = null;
				_ManualVersionID_W = null;
				_ManualFormID_W = null;
				_FromVersionID_W = null;
				_UserID_W = null;
				_ActionID_W = null;
				_LogDate_W = null;
				_ManualCategoryID_W = null;

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
				
				
				public AggregateParameter ManualLogID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ManualLogID, Parameters.ManualLogID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ManualID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ManualID, Parameters.ManualID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ManualVersionID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ManualVersionID, Parameters.ManualVersionID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ManualFormID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ManualFormID, Parameters.ManualFormID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter FromVersionID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.FromVersionID, Parameters.FromVersionID);
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

				public AggregateParameter ActionID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ActionID, Parameters.ActionID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter LogDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LogDate, Parameters.LogDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ManualCategoryID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ManualCategoryID, Parameters.ManualCategoryID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ManualLogID
		    {
				get
		        {
					if(_ManualLogID_W == null)
	        	    {
						_ManualLogID_W = TearOff.ManualLogID;
					}
					return _ManualLogID_W;
				}
			}

			public AggregateParameter ManualID
		    {
				get
		        {
					if(_ManualID_W == null)
	        	    {
						_ManualID_W = TearOff.ManualID;
					}
					return _ManualID_W;
				}
			}

			public AggregateParameter ManualVersionID
		    {
				get
		        {
					if(_ManualVersionID_W == null)
	        	    {
						_ManualVersionID_W = TearOff.ManualVersionID;
					}
					return _ManualVersionID_W;
				}
			}

			public AggregateParameter ManualFormID
		    {
				get
		        {
					if(_ManualFormID_W == null)
	        	    {
						_ManualFormID_W = TearOff.ManualFormID;
					}
					return _ManualFormID_W;
				}
			}

			public AggregateParameter FromVersionID
		    {
				get
		        {
					if(_FromVersionID_W == null)
	        	    {
						_FromVersionID_W = TearOff.FromVersionID;
					}
					return _FromVersionID_W;
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

			public AggregateParameter ActionID
		    {
				get
		        {
					if(_ActionID_W == null)
	        	    {
						_ActionID_W = TearOff.ActionID;
					}
					return _ActionID_W;
				}
			}

			public AggregateParameter LogDate
		    {
				get
		        {
					if(_LogDate_W == null)
	        	    {
						_LogDate_W = TearOff.LogDate;
					}
					return _LogDate_W;
				}
			}

			public AggregateParameter ManualCategoryID
		    {
				get
		        {
					if(_ManualCategoryID_W == null)
	        	    {
						_ManualCategoryID_W = TearOff.ManualCategoryID;
					}
					return _ManualCategoryID_W;
				}
			}

			private AggregateParameter _ManualLogID_W = null;
			private AggregateParameter _ManualID_W = null;
			private AggregateParameter _ManualVersionID_W = null;
			private AggregateParameter _ManualFormID_W = null;
			private AggregateParameter _FromVersionID_W = null;
			private AggregateParameter _UserID_W = null;
			private AggregateParameter _ActionID_W = null;
			private AggregateParameter _LogDate_W = null;
			private AggregateParameter _ManualCategoryID_W = null;

			public void AggregateClauseReset()
			{
				_ManualLogID_W = null;
				_ManualID_W = null;
				_ManualVersionID_W = null;
				_ManualFormID_W = null;
				_FromVersionID_W = null;
				_UserID_W = null;
				_ActionID_W = null;
				_LogDate_W = null;
				_ManualCategoryID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ManualLogInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ManualLogID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ManualLogUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ManualLogDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ManualLogID);
			p.SourceColumn = ColumnNames.ManualLogID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ManualLogID);
			p.SourceColumn = ColumnNames.ManualLogID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ManualID);
			p.SourceColumn = ColumnNames.ManualID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ManualVersionID);
			p.SourceColumn = ColumnNames.ManualVersionID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ManualFormID);
			p.SourceColumn = ColumnNames.ManualFormID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.FromVersionID);
			p.SourceColumn = ColumnNames.FromVersionID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UserID);
			p.SourceColumn = ColumnNames.UserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ActionID);
			p.SourceColumn = ColumnNames.ActionID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LogDate);
			p.SourceColumn = ColumnNames.LogDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ManualCategoryID);
			p.SourceColumn = ColumnNames.ManualCategoryID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
