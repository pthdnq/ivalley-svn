
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
	public abstract class _CertificateLog : SqlClientEntity
	{
		public _CertificateLog()
		{
			this.QuerySource = "CertificateLog";
			this.MappingName = "CertificateLog";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CertificateLogLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int CertificateLogID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.CertificateLogID, CertificateLogID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CertificateLogLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter CertificateLogID
			{
				get
				{
					return new SqlParameter("@CertificateLogID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CertificateID
			{
				get
				{
					return new SqlParameter("@CertificateID", SqlDbType.Int, 0);
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
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string CertificateLogID = "CertificateLogID";
            public const string CertificateID = "CertificateID";
            public const string UserID = "UserID";
            public const string ActionID = "ActionID";
            public const string LogDate = "LogDate";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CertificateLogID] = _CertificateLog.PropertyNames.CertificateLogID;
					ht[CertificateID] = _CertificateLog.PropertyNames.CertificateID;
					ht[UserID] = _CertificateLog.PropertyNames.UserID;
					ht[ActionID] = _CertificateLog.PropertyNames.ActionID;
					ht[LogDate] = _CertificateLog.PropertyNames.LogDate;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string CertificateLogID = "CertificateLogID";
            public const string CertificateID = "CertificateID";
            public const string UserID = "UserID";
            public const string ActionID = "ActionID";
            public const string LogDate = "LogDate";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CertificateLogID] = _CertificateLog.ColumnNames.CertificateLogID;
					ht[CertificateID] = _CertificateLog.ColumnNames.CertificateID;
					ht[UserID] = _CertificateLog.ColumnNames.UserID;
					ht[ActionID] = _CertificateLog.ColumnNames.ActionID;
					ht[LogDate] = _CertificateLog.ColumnNames.LogDate;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string CertificateLogID = "s_CertificateLogID";
            public const string CertificateID = "s_CertificateID";
            public const string UserID = "s_UserID";
            public const string ActionID = "s_ActionID";
            public const string LogDate = "s_LogDate";

		}
		#endregion		
		
		#region Properties
	
		public virtual int CertificateLogID
	    {
			get
	        {
				return base.Getint(ColumnNames.CertificateLogID);
			}
			set
	        {
				base.Setint(ColumnNames.CertificateLogID, value);
			}
		}

		public virtual int CertificateID
	    {
			get
	        {
				return base.Getint(ColumnNames.CertificateID);
			}
			set
	        {
				base.Setint(ColumnNames.CertificateID, value);
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


		#endregion
		
		#region String Properties
	
		public virtual string s_CertificateLogID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CertificateLogID) ? string.Empty : base.GetintAsString(ColumnNames.CertificateLogID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CertificateLogID);
				else
					this.CertificateLogID = base.SetintAsString(ColumnNames.CertificateLogID, value);
			}
		}

		public virtual string s_CertificateID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CertificateID) ? string.Empty : base.GetintAsString(ColumnNames.CertificateID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CertificateID);
				else
					this.CertificateID = base.SetintAsString(ColumnNames.CertificateID, value);
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
				
				
				public WhereParameter CertificateLogID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CertificateLogID, Parameters.CertificateLogID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CertificateID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CertificateID, Parameters.CertificateID);
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


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter CertificateLogID
		    {
				get
		        {
					if(_CertificateLogID_W == null)
	        	    {
						_CertificateLogID_W = TearOff.CertificateLogID;
					}
					return _CertificateLogID_W;
				}
			}

			public WhereParameter CertificateID
		    {
				get
		        {
					if(_CertificateID_W == null)
	        	    {
						_CertificateID_W = TearOff.CertificateID;
					}
					return _CertificateID_W;
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

			private WhereParameter _CertificateLogID_W = null;
			private WhereParameter _CertificateID_W = null;
			private WhereParameter _UserID_W = null;
			private WhereParameter _ActionID_W = null;
			private WhereParameter _LogDate_W = null;

			public void WhereClauseReset()
			{
				_CertificateLogID_W = null;
				_CertificateID_W = null;
				_UserID_W = null;
				_ActionID_W = null;
				_LogDate_W = null;

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
				
				
				public AggregateParameter CertificateLogID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CertificateLogID, Parameters.CertificateLogID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CertificateID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CertificateID, Parameters.CertificateID);
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


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter CertificateLogID
		    {
				get
		        {
					if(_CertificateLogID_W == null)
	        	    {
						_CertificateLogID_W = TearOff.CertificateLogID;
					}
					return _CertificateLogID_W;
				}
			}

			public AggregateParameter CertificateID
		    {
				get
		        {
					if(_CertificateID_W == null)
	        	    {
						_CertificateID_W = TearOff.CertificateID;
					}
					return _CertificateID_W;
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

			private AggregateParameter _CertificateLogID_W = null;
			private AggregateParameter _CertificateID_W = null;
			private AggregateParameter _UserID_W = null;
			private AggregateParameter _ActionID_W = null;
			private AggregateParameter _LogDate_W = null;

			public void AggregateClauseReset()
			{
				_CertificateLogID_W = null;
				_CertificateID_W = null;
				_UserID_W = null;
				_ActionID_W = null;
				_LogDate_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CertificateLogInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.CertificateLogID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CertificateLogUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CertificateLogDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.CertificateLogID);
			p.SourceColumn = ColumnNames.CertificateLogID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.CertificateLogID);
			p.SourceColumn = ColumnNames.CertificateLogID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CertificateID);
			p.SourceColumn = ColumnNames.CertificateID;
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


			return cmd;
		}
	}
}
