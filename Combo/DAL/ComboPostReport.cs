
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
	public abstract class _ComboPostReport : SqlClientEntity
	{
		public _ComboPostReport()
		{
			this.QuerySource = "ComboPostReport";
			this.MappingName = "ComboPostReport";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ComboPostReportLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ComboPostReportID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ComboPostReportID, ComboPostReportID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ComboPostReportLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ComboPostReportID
			{
				get
				{
					return new SqlParameter("@ComboPostReportID", SqlDbType.Int, 0);
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
			
			public static SqlParameter ReportText
			{
				get
				{
					return new SqlParameter("@ReportText", SqlDbType.NVarChar, 1073741823);
				}
			}
			
			public static SqlParameter ReportDate
			{
				get
				{
					return new SqlParameter("@ReportDate", SqlDbType.DateTime, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ComboPostReportID = "ComboPostReportID";
            public const string ComboUserID = "ComboUserID";
            public const string ComboPostID = "ComboPostID";
            public const string ReportText = "ReportText";
            public const string ReportDate = "ReportDate";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ComboPostReportID] = _ComboPostReport.PropertyNames.ComboPostReportID;
					ht[ComboUserID] = _ComboPostReport.PropertyNames.ComboUserID;
					ht[ComboPostID] = _ComboPostReport.PropertyNames.ComboPostID;
					ht[ReportText] = _ComboPostReport.PropertyNames.ReportText;
					ht[ReportDate] = _ComboPostReport.PropertyNames.ReportDate;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ComboPostReportID = "ComboPostReportID";
            public const string ComboUserID = "ComboUserID";
            public const string ComboPostID = "ComboPostID";
            public const string ReportText = "ReportText";
            public const string ReportDate = "ReportDate";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ComboPostReportID] = _ComboPostReport.ColumnNames.ComboPostReportID;
					ht[ComboUserID] = _ComboPostReport.ColumnNames.ComboUserID;
					ht[ComboPostID] = _ComboPostReport.ColumnNames.ComboPostID;
					ht[ReportText] = _ComboPostReport.ColumnNames.ReportText;
					ht[ReportDate] = _ComboPostReport.ColumnNames.ReportDate;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ComboPostReportID = "s_ComboPostReportID";
            public const string ComboUserID = "s_ComboUserID";
            public const string ComboPostID = "s_ComboPostID";
            public const string ReportText = "s_ReportText";
            public const string ReportDate = "s_ReportDate";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ComboPostReportID
	    {
			get
	        {
				return base.Getint(ColumnNames.ComboPostReportID);
			}
			set
	        {
				base.Setint(ColumnNames.ComboPostReportID, value);
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

		public virtual string ReportText
	    {
			get
	        {
				return base.Getstring(ColumnNames.ReportText);
			}
			set
	        {
				base.Setstring(ColumnNames.ReportText, value);
			}
		}

		public virtual DateTime ReportDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.ReportDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.ReportDate, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ComboPostReportID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ComboPostReportID) ? string.Empty : base.GetintAsString(ColumnNames.ComboPostReportID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ComboPostReportID);
				else
					this.ComboPostReportID = base.SetintAsString(ColumnNames.ComboPostReportID, value);
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

		public virtual string s_ReportText
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReportText) ? string.Empty : base.GetstringAsString(ColumnNames.ReportText);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReportText);
				else
					this.ReportText = base.SetstringAsString(ColumnNames.ReportText, value);
			}
		}

		public virtual string s_ReportDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReportDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.ReportDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReportDate);
				else
					this.ReportDate = base.SetDateTimeAsString(ColumnNames.ReportDate, value);
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
				
				
				public WhereParameter ComboPostReportID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ComboPostReportID, Parameters.ComboPostReportID);
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

				public WhereParameter ReportText
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReportText, Parameters.ReportText);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ReportDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReportDate, Parameters.ReportDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ComboPostReportID
		    {
				get
		        {
					if(_ComboPostReportID_W == null)
	        	    {
						_ComboPostReportID_W = TearOff.ComboPostReportID;
					}
					return _ComboPostReportID_W;
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

			public WhereParameter ReportText
		    {
				get
		        {
					if(_ReportText_W == null)
	        	    {
						_ReportText_W = TearOff.ReportText;
					}
					return _ReportText_W;
				}
			}

			public WhereParameter ReportDate
		    {
				get
		        {
					if(_ReportDate_W == null)
	        	    {
						_ReportDate_W = TearOff.ReportDate;
					}
					return _ReportDate_W;
				}
			}

			private WhereParameter _ComboPostReportID_W = null;
			private WhereParameter _ComboUserID_W = null;
			private WhereParameter _ComboPostID_W = null;
			private WhereParameter _ReportText_W = null;
			private WhereParameter _ReportDate_W = null;

			public void WhereClauseReset()
			{
				_ComboPostReportID_W = null;
				_ComboUserID_W = null;
				_ComboPostID_W = null;
				_ReportText_W = null;
				_ReportDate_W = null;

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
				
				
				public AggregateParameter ComboPostReportID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ComboPostReportID, Parameters.ComboPostReportID);
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

				public AggregateParameter ReportText
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReportText, Parameters.ReportText);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ReportDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReportDate, Parameters.ReportDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ComboPostReportID
		    {
				get
		        {
					if(_ComboPostReportID_W == null)
	        	    {
						_ComboPostReportID_W = TearOff.ComboPostReportID;
					}
					return _ComboPostReportID_W;
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

			public AggregateParameter ReportText
		    {
				get
		        {
					if(_ReportText_W == null)
	        	    {
						_ReportText_W = TearOff.ReportText;
					}
					return _ReportText_W;
				}
			}

			public AggregateParameter ReportDate
		    {
				get
		        {
					if(_ReportDate_W == null)
	        	    {
						_ReportDate_W = TearOff.ReportDate;
					}
					return _ReportDate_W;
				}
			}

			private AggregateParameter _ComboPostReportID_W = null;
			private AggregateParameter _ComboUserID_W = null;
			private AggregateParameter _ComboPostID_W = null;
			private AggregateParameter _ReportText_W = null;
			private AggregateParameter _ReportDate_W = null;

			public void AggregateClauseReset()
			{
				_ComboPostReportID_W = null;
				_ComboUserID_W = null;
				_ComboPostID_W = null;
				_ReportText_W = null;
				_ReportDate_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ComboPostReportInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ComboPostReportID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ComboPostReportUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ComboPostReportDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ComboPostReportID);
			p.SourceColumn = ColumnNames.ComboPostReportID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ComboPostReportID);
			p.SourceColumn = ColumnNames.ComboPostReportID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ComboUserID);
			p.SourceColumn = ColumnNames.ComboUserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ComboPostID);
			p.SourceColumn = ColumnNames.ComboPostID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ReportText);
			p.SourceColumn = ColumnNames.ReportText;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ReportDate);
			p.SourceColumn = ColumnNames.ReportDate;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
