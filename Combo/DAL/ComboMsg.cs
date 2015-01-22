
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

namespace Combo.DAL
{
	public abstract class _ComboMsg : SqlClientEntity
	{
		public _ComboMsg()
		{
			this.QuerySource = "ComboMsg";
			this.MappingName = "ComboMsg";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ComboMsgLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ComboMsgID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ComboMsgID, ComboMsgID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ComboMsgLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ComboMsgID
			{
				get
				{
					return new SqlParameter("@ComboMsgID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ComboUserID
			{
				get
				{
					return new SqlParameter("@ComboUserID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter MsgText
			{
				get
				{
					return new SqlParameter("@MsgText", SqlDbType.NVarChar, 1073741823);
				}
			}
			
			public static SqlParameter MsgDate
			{
				get
				{
					return new SqlParameter("@MsgDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter IsDeleted
			{
				get
				{
					return new SqlParameter("@IsDeleted", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter IsRead
			{
				get
				{
					return new SqlParameter("@IsRead", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ComboMsgID = "ComboMsgID";
            public const string ComboUserID = "ComboUserID";
            public const string MsgText = "MsgText";
            public const string MsgDate = "MsgDate";
            public const string IsDeleted = "IsDeleted";
            public const string IsRead = "IsRead";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ComboMsgID] = _ComboMsg.PropertyNames.ComboMsgID;
					ht[ComboUserID] = _ComboMsg.PropertyNames.ComboUserID;
					ht[MsgText] = _ComboMsg.PropertyNames.MsgText;
					ht[MsgDate] = _ComboMsg.PropertyNames.MsgDate;
					ht[IsDeleted] = _ComboMsg.PropertyNames.IsDeleted;
					ht[IsRead] = _ComboMsg.PropertyNames.IsRead;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ComboMsgID = "ComboMsgID";
            public const string ComboUserID = "ComboUserID";
            public const string MsgText = "MsgText";
            public const string MsgDate = "MsgDate";
            public const string IsDeleted = "IsDeleted";
            public const string IsRead = "IsRead";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ComboMsgID] = _ComboMsg.ColumnNames.ComboMsgID;
					ht[ComboUserID] = _ComboMsg.ColumnNames.ComboUserID;
					ht[MsgText] = _ComboMsg.ColumnNames.MsgText;
					ht[MsgDate] = _ComboMsg.ColumnNames.MsgDate;
					ht[IsDeleted] = _ComboMsg.ColumnNames.IsDeleted;
					ht[IsRead] = _ComboMsg.ColumnNames.IsRead;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ComboMsgID = "s_ComboMsgID";
            public const string ComboUserID = "s_ComboUserID";
            public const string MsgText = "s_MsgText";
            public const string MsgDate = "s_MsgDate";
            public const string IsDeleted = "s_IsDeleted";
            public const string IsRead = "s_IsRead";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ComboMsgID
	    {
			get
	        {
				return base.Getint(ColumnNames.ComboMsgID);
			}
			set
	        {
				base.Setint(ColumnNames.ComboMsgID, value);
			}
		}

		public virtual int ComboUserID
	    {
			get
	        {
				return base.Getint(ColumnNames.ComboUserID);
			}
			set
	        {
				base.Setint(ColumnNames.ComboUserID, value);
			}
		}

		public virtual string MsgText
	    {
			get
	        {
				return base.Getstring(ColumnNames.MsgText);
			}
			set
	        {
				base.Setstring(ColumnNames.MsgText, value);
			}
		}

		public virtual DateTime MsgDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.MsgDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.MsgDate, value);
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

		public virtual bool IsRead
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsRead);
			}
			set
	        {
				base.Setbool(ColumnNames.IsRead, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ComboMsgID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ComboMsgID) ? string.Empty : base.GetintAsString(ColumnNames.ComboMsgID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ComboMsgID);
				else
					this.ComboMsgID = base.SetintAsString(ColumnNames.ComboMsgID, value);
			}
		}

		public virtual string s_ComboUserID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ComboUserID) ? string.Empty : base.GetintAsString(ColumnNames.ComboUserID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ComboUserID);
				else
					this.ComboUserID = base.SetintAsString(ColumnNames.ComboUserID, value);
			}
		}

		public virtual string s_MsgText
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.MsgText) ? string.Empty : base.GetstringAsString(ColumnNames.MsgText);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.MsgText);
				else
					this.MsgText = base.SetstringAsString(ColumnNames.MsgText, value);
			}
		}

		public virtual string s_MsgDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.MsgDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.MsgDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.MsgDate);
				else
					this.MsgDate = base.SetDateTimeAsString(ColumnNames.MsgDate, value);
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

		public virtual string s_IsRead
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsRead) ? string.Empty : base.GetboolAsString(ColumnNames.IsRead);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsRead);
				else
					this.IsRead = base.SetboolAsString(ColumnNames.IsRead, value);
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
				
				
				public WhereParameter ComboMsgID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ComboMsgID, Parameters.ComboMsgID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ComboUserID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ComboUserID, Parameters.ComboUserID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter MsgText
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.MsgText, Parameters.MsgText);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter MsgDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.MsgDate, Parameters.MsgDate);
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

				public WhereParameter IsRead
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsRead, Parameters.IsRead);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ComboMsgID
		    {
				get
		        {
					if(_ComboMsgID_W == null)
	        	    {
						_ComboMsgID_W = TearOff.ComboMsgID;
					}
					return _ComboMsgID_W;
				}
			}

			public WhereParameter ComboUserID
		    {
				get
		        {
					if(_ComboUserID_W == null)
	        	    {
						_ComboUserID_W = TearOff.ComboUserID;
					}
					return _ComboUserID_W;
				}
			}

			public WhereParameter MsgText
		    {
				get
		        {
					if(_MsgText_W == null)
	        	    {
						_MsgText_W = TearOff.MsgText;
					}
					return _MsgText_W;
				}
			}

			public WhereParameter MsgDate
		    {
				get
		        {
					if(_MsgDate_W == null)
	        	    {
						_MsgDate_W = TearOff.MsgDate;
					}
					return _MsgDate_W;
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

			public WhereParameter IsRead
		    {
				get
		        {
					if(_IsRead_W == null)
	        	    {
						_IsRead_W = TearOff.IsRead;
					}
					return _IsRead_W;
				}
			}

			private WhereParameter _ComboMsgID_W = null;
			private WhereParameter _ComboUserID_W = null;
			private WhereParameter _MsgText_W = null;
			private WhereParameter _MsgDate_W = null;
			private WhereParameter _IsDeleted_W = null;
			private WhereParameter _IsRead_W = null;

			public void WhereClauseReset()
			{
				_ComboMsgID_W = null;
				_ComboUserID_W = null;
				_MsgText_W = null;
				_MsgDate_W = null;
				_IsDeleted_W = null;
				_IsRead_W = null;

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
				
				
				public AggregateParameter ComboMsgID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ComboMsgID, Parameters.ComboMsgID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ComboUserID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ComboUserID, Parameters.ComboUserID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter MsgText
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.MsgText, Parameters.MsgText);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter MsgDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.MsgDate, Parameters.MsgDate);
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

				public AggregateParameter IsRead
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsRead, Parameters.IsRead);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ComboMsgID
		    {
				get
		        {
					if(_ComboMsgID_W == null)
	        	    {
						_ComboMsgID_W = TearOff.ComboMsgID;
					}
					return _ComboMsgID_W;
				}
			}

			public AggregateParameter ComboUserID
		    {
				get
		        {
					if(_ComboUserID_W == null)
	        	    {
						_ComboUserID_W = TearOff.ComboUserID;
					}
					return _ComboUserID_W;
				}
			}

			public AggregateParameter MsgText
		    {
				get
		        {
					if(_MsgText_W == null)
	        	    {
						_MsgText_W = TearOff.MsgText;
					}
					return _MsgText_W;
				}
			}

			public AggregateParameter MsgDate
		    {
				get
		        {
					if(_MsgDate_W == null)
	        	    {
						_MsgDate_W = TearOff.MsgDate;
					}
					return _MsgDate_W;
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

			public AggregateParameter IsRead
		    {
				get
		        {
					if(_IsRead_W == null)
	        	    {
						_IsRead_W = TearOff.IsRead;
					}
					return _IsRead_W;
				}
			}

			private AggregateParameter _ComboMsgID_W = null;
			private AggregateParameter _ComboUserID_W = null;
			private AggregateParameter _MsgText_W = null;
			private AggregateParameter _MsgDate_W = null;
			private AggregateParameter _IsDeleted_W = null;
			private AggregateParameter _IsRead_W = null;

			public void AggregateClauseReset()
			{
				_ComboMsgID_W = null;
				_ComboUserID_W = null;
				_MsgText_W = null;
				_MsgDate_W = null;
				_IsDeleted_W = null;
				_IsRead_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ComboMsgInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ComboMsgID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ComboMsgUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ComboMsgDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ComboMsgID);
			p.SourceColumn = ColumnNames.ComboMsgID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ComboMsgID);
			p.SourceColumn = ColumnNames.ComboMsgID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ComboUserID);
			p.SourceColumn = ColumnNames.ComboUserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.MsgText);
			p.SourceColumn = ColumnNames.MsgText;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.MsgDate);
			p.SourceColumn = ColumnNames.MsgDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsDeleted);
			p.SourceColumn = ColumnNames.IsDeleted;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsRead);
			p.SourceColumn = ColumnNames.IsRead;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
