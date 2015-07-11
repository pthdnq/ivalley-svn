
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

namespace COMBO_DAL
{
	public abstract class _ComboComment : SqlClientEntity
	{
		public _ComboComment()
		{
			this.QuerySource = "ComboComment";
			this.MappingName = "ComboComment";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ComboCommentLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ComboCommentID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ComboCommentID, ComboCommentID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ComboCommentLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ComboCommentID
			{
				get
				{
					return new SqlParameter("@ComboCommentID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ComboUserID
			{
				get
				{
					return new SqlParameter("@ComboUserID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ComboPostID
			{
				get
				{
					return new SqlParameter("@ComboPostID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CommentText
			{
				get
				{
					return new SqlParameter("@CommentText", SqlDbType.NVarChar, 1073741823);
				}
			}
			
			public static SqlParameter CommentDate
			{
				get
				{
					return new SqlParameter("@CommentDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter ComboMsgID
			{
				get
				{
					return new SqlParameter("@ComboMsgID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter IsRead
			{
				get
				{
					return new SqlParameter("@IsRead", SqlDbType.Bit, 0);
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
            public const string ComboCommentID = "ComboCommentID";
            public const string ComboUserID = "ComboUserID";
            public const string ComboPostID = "ComboPostID";
            public const string CommentText = "CommentText";
            public const string CommentDate = "CommentDate";
            public const string ComboMsgID = "ComboMsgID";
            public const string IsRead = "IsRead";
            public const string IsDeleted = "IsDeleted";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ComboCommentID] = _ComboComment.PropertyNames.ComboCommentID;
					ht[ComboUserID] = _ComboComment.PropertyNames.ComboUserID;
					ht[ComboPostID] = _ComboComment.PropertyNames.ComboPostID;
					ht[CommentText] = _ComboComment.PropertyNames.CommentText;
					ht[CommentDate] = _ComboComment.PropertyNames.CommentDate;
					ht[ComboMsgID] = _ComboComment.PropertyNames.ComboMsgID;
					ht[IsRead] = _ComboComment.PropertyNames.IsRead;
					ht[IsDeleted] = _ComboComment.PropertyNames.IsDeleted;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ComboCommentID = "ComboCommentID";
            public const string ComboUserID = "ComboUserID";
            public const string ComboPostID = "ComboPostID";
            public const string CommentText = "CommentText";
            public const string CommentDate = "CommentDate";
            public const string ComboMsgID = "ComboMsgID";
            public const string IsRead = "IsRead";
            public const string IsDeleted = "IsDeleted";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ComboCommentID] = _ComboComment.ColumnNames.ComboCommentID;
					ht[ComboUserID] = _ComboComment.ColumnNames.ComboUserID;
					ht[ComboPostID] = _ComboComment.ColumnNames.ComboPostID;
					ht[CommentText] = _ComboComment.ColumnNames.CommentText;
					ht[CommentDate] = _ComboComment.ColumnNames.CommentDate;
					ht[ComboMsgID] = _ComboComment.ColumnNames.ComboMsgID;
					ht[IsRead] = _ComboComment.ColumnNames.IsRead;
					ht[IsDeleted] = _ComboComment.ColumnNames.IsDeleted;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ComboCommentID = "s_ComboCommentID";
            public const string ComboUserID = "s_ComboUserID";
            public const string ComboPostID = "s_ComboPostID";
            public const string CommentText = "s_CommentText";
            public const string CommentDate = "s_CommentDate";
            public const string ComboMsgID = "s_ComboMsgID";
            public const string IsRead = "s_IsRead";
            public const string IsDeleted = "s_IsDeleted";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ComboCommentID
	    {
			get
	        {
				return base.Getint(ColumnNames.ComboCommentID);
			}
			set
	        {
				base.Setint(ColumnNames.ComboCommentID, value);
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

		public virtual int ComboPostID
	    {
			get
	        {
				return base.Getint(ColumnNames.ComboPostID);
			}
			set
	        {
				base.Setint(ColumnNames.ComboPostID, value);
			}
		}

		public virtual string CommentText
	    {
			get
	        {
				return base.Getstring(ColumnNames.CommentText);
			}
			set
	        {
				base.Setstring(ColumnNames.CommentText, value);
			}
		}

		public virtual DateTime CommentDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.CommentDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.CommentDate, value);
			}
		}

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
	
		public virtual string s_ComboCommentID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ComboCommentID) ? string.Empty : base.GetintAsString(ColumnNames.ComboCommentID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ComboCommentID);
				else
					this.ComboCommentID = base.SetintAsString(ColumnNames.ComboCommentID, value);
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

		public virtual string s_ComboPostID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ComboPostID) ? string.Empty : base.GetintAsString(ColumnNames.ComboPostID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ComboPostID);
				else
					this.ComboPostID = base.SetintAsString(ColumnNames.ComboPostID, value);
			}
		}

		public virtual string s_CommentText
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CommentText) ? string.Empty : base.GetstringAsString(ColumnNames.CommentText);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CommentText);
				else
					this.CommentText = base.SetstringAsString(ColumnNames.CommentText, value);
			}
		}

		public virtual string s_CommentDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CommentDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.CommentDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CommentDate);
				else
					this.CommentDate = base.SetDateTimeAsString(ColumnNames.CommentDate, value);
			}
		}

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
				
				
				public WhereParameter ComboCommentID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ComboCommentID, Parameters.ComboCommentID);
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

				public WhereParameter ComboPostID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ComboPostID, Parameters.ComboPostID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CommentText
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CommentText, Parameters.CommentText);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CommentDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CommentDate, Parameters.CommentDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
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

				public WhereParameter IsRead
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsRead, Parameters.IsRead);
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
		
			public WhereParameter ComboCommentID
		    {
				get
		        {
					if(_ComboCommentID_W == null)
	        	    {
						_ComboCommentID_W = TearOff.ComboCommentID;
					}
					return _ComboCommentID_W;
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

			public WhereParameter ComboPostID
		    {
				get
		        {
					if(_ComboPostID_W == null)
	        	    {
						_ComboPostID_W = TearOff.ComboPostID;
					}
					return _ComboPostID_W;
				}
			}

			public WhereParameter CommentText
		    {
				get
		        {
					if(_CommentText_W == null)
	        	    {
						_CommentText_W = TearOff.CommentText;
					}
					return _CommentText_W;
				}
			}

			public WhereParameter CommentDate
		    {
				get
		        {
					if(_CommentDate_W == null)
	        	    {
						_CommentDate_W = TearOff.CommentDate;
					}
					return _CommentDate_W;
				}
			}

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

			private WhereParameter _ComboCommentID_W = null;
			private WhereParameter _ComboUserID_W = null;
			private WhereParameter _ComboPostID_W = null;
			private WhereParameter _CommentText_W = null;
			private WhereParameter _CommentDate_W = null;
			private WhereParameter _ComboMsgID_W = null;
			private WhereParameter _IsRead_W = null;
			private WhereParameter _IsDeleted_W = null;

			public void WhereClauseReset()
			{
				_ComboCommentID_W = null;
				_ComboUserID_W = null;
				_ComboPostID_W = null;
				_CommentText_W = null;
				_CommentDate_W = null;
				_ComboMsgID_W = null;
				_IsRead_W = null;
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
				
				
				public AggregateParameter ComboCommentID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ComboCommentID, Parameters.ComboCommentID);
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

				public AggregateParameter ComboPostID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ComboPostID, Parameters.ComboPostID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CommentText
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CommentText, Parameters.CommentText);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CommentDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CommentDate, Parameters.CommentDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
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

				public AggregateParameter IsRead
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsRead, Parameters.IsRead);
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
		
			public AggregateParameter ComboCommentID
		    {
				get
		        {
					if(_ComboCommentID_W == null)
	        	    {
						_ComboCommentID_W = TearOff.ComboCommentID;
					}
					return _ComboCommentID_W;
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

			public AggregateParameter ComboPostID
		    {
				get
		        {
					if(_ComboPostID_W == null)
	        	    {
						_ComboPostID_W = TearOff.ComboPostID;
					}
					return _ComboPostID_W;
				}
			}

			public AggregateParameter CommentText
		    {
				get
		        {
					if(_CommentText_W == null)
	        	    {
						_CommentText_W = TearOff.CommentText;
					}
					return _CommentText_W;
				}
			}

			public AggregateParameter CommentDate
		    {
				get
		        {
					if(_CommentDate_W == null)
	        	    {
						_CommentDate_W = TearOff.CommentDate;
					}
					return _CommentDate_W;
				}
			}

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

			private AggregateParameter _ComboCommentID_W = null;
			private AggregateParameter _ComboUserID_W = null;
			private AggregateParameter _ComboPostID_W = null;
			private AggregateParameter _CommentText_W = null;
			private AggregateParameter _CommentDate_W = null;
			private AggregateParameter _ComboMsgID_W = null;
			private AggregateParameter _IsRead_W = null;
			private AggregateParameter _IsDeleted_W = null;

			public void AggregateClauseReset()
			{
				_ComboCommentID_W = null;
				_ComboUserID_W = null;
				_ComboPostID_W = null;
				_CommentText_W = null;
				_CommentDate_W = null;
				_ComboMsgID_W = null;
				_IsRead_W = null;
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ComboCommentInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ComboCommentID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ComboCommentUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ComboCommentDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ComboCommentID);
			p.SourceColumn = ColumnNames.ComboCommentID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ComboCommentID);
			p.SourceColumn = ColumnNames.ComboCommentID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ComboUserID);
			p.SourceColumn = ColumnNames.ComboUserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ComboPostID);
			p.SourceColumn = ColumnNames.ComboPostID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CommentText);
			p.SourceColumn = ColumnNames.CommentText;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CommentDate);
			p.SourceColumn = ColumnNames.CommentDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ComboMsgID);
			p.SourceColumn = ColumnNames.ComboMsgID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsRead);
			p.SourceColumn = ColumnNames.IsRead;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsDeleted);
			p.SourceColumn = ColumnNames.IsDeleted;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
