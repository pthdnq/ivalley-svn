
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
	public abstract class _TicketHistory : SqlClientEntity
	{
		public _TicketHistory()
		{
			this.QuerySource = "TicketHistory";
			this.MappingName = "TicketHistory";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TicketHistoryLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int TicketHistoryID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.TicketHistoryID, TicketHistoryID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_TicketHistoryLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter TicketHistoryID
			{
				get
				{
					return new SqlParameter("@TicketHistoryID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter TicketID
			{
				get
				{
					return new SqlParameter("@TicketID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ResponseText
			{
				get
				{
					return new SqlParameter("@ResponseText", SqlDbType.NVarChar, 500);
				}
			}
			
			public static SqlParameter ResponseDate
			{
				get
				{
					return new SqlParameter("@ResponseDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter CAPA_ResponderID
			{
				get
				{
					return new SqlParameter("@CAPA_ResponderID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter TicketStatusID
			{
				get
				{
					return new SqlParameter("@TicketStatusID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string TicketHistoryID = "TicketHistoryID";
            public const string TicketID = "TicketID";
            public const string ResponseText = "ResponseText";
            public const string ResponseDate = "ResponseDate";
            public const string CAPA_ResponderID = "CAPA_ResponderID";
            public const string TicketStatusID = "TicketStatusID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[TicketHistoryID] = _TicketHistory.PropertyNames.TicketHistoryID;
					ht[TicketID] = _TicketHistory.PropertyNames.TicketID;
					ht[ResponseText] = _TicketHistory.PropertyNames.ResponseText;
					ht[ResponseDate] = _TicketHistory.PropertyNames.ResponseDate;
					ht[CAPA_ResponderID] = _TicketHistory.PropertyNames.CAPA_ResponderID;
					ht[TicketStatusID] = _TicketHistory.PropertyNames.TicketStatusID;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string TicketHistoryID = "TicketHistoryID";
            public const string TicketID = "TicketID";
            public const string ResponseText = "ResponseText";
            public const string ResponseDate = "ResponseDate";
            public const string CAPA_ResponderID = "CAPA_ResponderID";
            public const string TicketStatusID = "TicketStatusID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[TicketHistoryID] = _TicketHistory.ColumnNames.TicketHistoryID;
					ht[TicketID] = _TicketHistory.ColumnNames.TicketID;
					ht[ResponseText] = _TicketHistory.ColumnNames.ResponseText;
					ht[ResponseDate] = _TicketHistory.ColumnNames.ResponseDate;
					ht[CAPA_ResponderID] = _TicketHistory.ColumnNames.CAPA_ResponderID;
					ht[TicketStatusID] = _TicketHistory.ColumnNames.TicketStatusID;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string TicketHistoryID = "s_TicketHistoryID";
            public const string TicketID = "s_TicketID";
            public const string ResponseText = "s_ResponseText";
            public const string ResponseDate = "s_ResponseDate";
            public const string CAPA_ResponderID = "s_CAPA_ResponderID";
            public const string TicketStatusID = "s_TicketStatusID";

		}
		#endregion		
		
		#region Properties
	
		public virtual int TicketHistoryID
	    {
			get
	        {
				return base.Getint(ColumnNames.TicketHistoryID);
			}
			set
	        {
				base.Setint(ColumnNames.TicketHistoryID, value);
			}
		}

		public virtual int TicketID
	    {
			get
	        {
				return base.Getint(ColumnNames.TicketID);
			}
			set
	        {
				base.Setint(ColumnNames.TicketID, value);
			}
		}

		public virtual string ResponseText
	    {
			get
	        {
				return base.Getstring(ColumnNames.ResponseText);
			}
			set
	        {
				base.Setstring(ColumnNames.ResponseText, value);
			}
		}

		public virtual DateTime ResponseDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.ResponseDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.ResponseDate, value);
			}
		}

		public virtual int CAPA_ResponderID
	    {
			get
	        {
				return base.Getint(ColumnNames.CAPA_ResponderID);
			}
			set
	        {
				base.Setint(ColumnNames.CAPA_ResponderID, value);
			}
		}

		public virtual int TicketStatusID
	    {
			get
	        {
				return base.Getint(ColumnNames.TicketStatusID);
			}
			set
	        {
				base.Setint(ColumnNames.TicketStatusID, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_TicketHistoryID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.TicketHistoryID) ? string.Empty : base.GetintAsString(ColumnNames.TicketHistoryID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.TicketHistoryID);
				else
					this.TicketHistoryID = base.SetintAsString(ColumnNames.TicketHistoryID, value);
			}
		}

		public virtual string s_TicketID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.TicketID) ? string.Empty : base.GetintAsString(ColumnNames.TicketID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.TicketID);
				else
					this.TicketID = base.SetintAsString(ColumnNames.TicketID, value);
			}
		}

		public virtual string s_ResponseText
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ResponseText) ? string.Empty : base.GetstringAsString(ColumnNames.ResponseText);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ResponseText);
				else
					this.ResponseText = base.SetstringAsString(ColumnNames.ResponseText, value);
			}
		}

		public virtual string s_ResponseDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ResponseDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.ResponseDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ResponseDate);
				else
					this.ResponseDate = base.SetDateTimeAsString(ColumnNames.ResponseDate, value);
			}
		}

		public virtual string s_CAPA_ResponderID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CAPA_ResponderID) ? string.Empty : base.GetintAsString(ColumnNames.CAPA_ResponderID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CAPA_ResponderID);
				else
					this.CAPA_ResponderID = base.SetintAsString(ColumnNames.CAPA_ResponderID, value);
			}
		}

		public virtual string s_TicketStatusID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.TicketStatusID) ? string.Empty : base.GetintAsString(ColumnNames.TicketStatusID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.TicketStatusID);
				else
					this.TicketStatusID = base.SetintAsString(ColumnNames.TicketStatusID, value);
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
				
				
				public WhereParameter TicketHistoryID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TicketHistoryID, Parameters.TicketHistoryID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter TicketID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TicketID, Parameters.TicketID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ResponseText
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ResponseText, Parameters.ResponseText);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ResponseDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ResponseDate, Parameters.ResponseDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CAPA_ResponderID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CAPA_ResponderID, Parameters.CAPA_ResponderID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter TicketStatusID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TicketStatusID, Parameters.TicketStatusID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter TicketHistoryID
		    {
				get
		        {
					if(_TicketHistoryID_W == null)
	        	    {
						_TicketHistoryID_W = TearOff.TicketHistoryID;
					}
					return _TicketHistoryID_W;
				}
			}

			public WhereParameter TicketID
		    {
				get
		        {
					if(_TicketID_W == null)
	        	    {
						_TicketID_W = TearOff.TicketID;
					}
					return _TicketID_W;
				}
			}

			public WhereParameter ResponseText
		    {
				get
		        {
					if(_ResponseText_W == null)
	        	    {
						_ResponseText_W = TearOff.ResponseText;
					}
					return _ResponseText_W;
				}
			}

			public WhereParameter ResponseDate
		    {
				get
		        {
					if(_ResponseDate_W == null)
	        	    {
						_ResponseDate_W = TearOff.ResponseDate;
					}
					return _ResponseDate_W;
				}
			}

			public WhereParameter CAPA_ResponderID
		    {
				get
		        {
					if(_CAPA_ResponderID_W == null)
	        	    {
						_CAPA_ResponderID_W = TearOff.CAPA_ResponderID;
					}
					return _CAPA_ResponderID_W;
				}
			}

			public WhereParameter TicketStatusID
		    {
				get
		        {
					if(_TicketStatusID_W == null)
	        	    {
						_TicketStatusID_W = TearOff.TicketStatusID;
					}
					return _TicketStatusID_W;
				}
			}

			private WhereParameter _TicketHistoryID_W = null;
			private WhereParameter _TicketID_W = null;
			private WhereParameter _ResponseText_W = null;
			private WhereParameter _ResponseDate_W = null;
			private WhereParameter _CAPA_ResponderID_W = null;
			private WhereParameter _TicketStatusID_W = null;

			public void WhereClauseReset()
			{
				_TicketHistoryID_W = null;
				_TicketID_W = null;
				_ResponseText_W = null;
				_ResponseDate_W = null;
				_CAPA_ResponderID_W = null;
				_TicketStatusID_W = null;

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
				
				
				public AggregateParameter TicketHistoryID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TicketHistoryID, Parameters.TicketHistoryID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter TicketID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TicketID, Parameters.TicketID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ResponseText
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ResponseText, Parameters.ResponseText);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ResponseDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ResponseDate, Parameters.ResponseDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CAPA_ResponderID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CAPA_ResponderID, Parameters.CAPA_ResponderID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter TicketStatusID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TicketStatusID, Parameters.TicketStatusID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter TicketHistoryID
		    {
				get
		        {
					if(_TicketHistoryID_W == null)
	        	    {
						_TicketHistoryID_W = TearOff.TicketHistoryID;
					}
					return _TicketHistoryID_W;
				}
			}

			public AggregateParameter TicketID
		    {
				get
		        {
					if(_TicketID_W == null)
	        	    {
						_TicketID_W = TearOff.TicketID;
					}
					return _TicketID_W;
				}
			}

			public AggregateParameter ResponseText
		    {
				get
		        {
					if(_ResponseText_W == null)
	        	    {
						_ResponseText_W = TearOff.ResponseText;
					}
					return _ResponseText_W;
				}
			}

			public AggregateParameter ResponseDate
		    {
				get
		        {
					if(_ResponseDate_W == null)
	        	    {
						_ResponseDate_W = TearOff.ResponseDate;
					}
					return _ResponseDate_W;
				}
			}

			public AggregateParameter CAPA_ResponderID
		    {
				get
		        {
					if(_CAPA_ResponderID_W == null)
	        	    {
						_CAPA_ResponderID_W = TearOff.CAPA_ResponderID;
					}
					return _CAPA_ResponderID_W;
				}
			}

			public AggregateParameter TicketStatusID
		    {
				get
		        {
					if(_TicketStatusID_W == null)
	        	    {
						_TicketStatusID_W = TearOff.TicketStatusID;
					}
					return _TicketStatusID_W;
				}
			}

			private AggregateParameter _TicketHistoryID_W = null;
			private AggregateParameter _TicketID_W = null;
			private AggregateParameter _ResponseText_W = null;
			private AggregateParameter _ResponseDate_W = null;
			private AggregateParameter _CAPA_ResponderID_W = null;
			private AggregateParameter _TicketStatusID_W = null;

			public void AggregateClauseReset()
			{
				_TicketHistoryID_W = null;
				_TicketID_W = null;
				_ResponseText_W = null;
				_ResponseDate_W = null;
				_CAPA_ResponderID_W = null;
				_TicketStatusID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TicketHistoryInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.TicketHistoryID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TicketHistoryUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_TicketHistoryDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.TicketHistoryID);
			p.SourceColumn = ColumnNames.TicketHistoryID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.TicketHistoryID);
			p.SourceColumn = ColumnNames.TicketHistoryID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.TicketID);
			p.SourceColumn = ColumnNames.TicketID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ResponseText);
			p.SourceColumn = ColumnNames.ResponseText;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ResponseDate);
			p.SourceColumn = ColumnNames.ResponseDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CAPA_ResponderID);
			p.SourceColumn = ColumnNames.CAPA_ResponderID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.TicketStatusID);
			p.SourceColumn = ColumnNames.TicketStatusID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}