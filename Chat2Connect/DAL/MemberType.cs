
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

namespace DAL
{
	public abstract class _MemberType : SqlClientEntity
	{
		public _MemberType()
		{
			this.QuerySource = "MemberType";
			this.MappingName = "MemberType";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_MemberTypeLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_MemberTypeLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ID
			{
				get
				{
					return new SqlParameter("@ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter MemberID
			{
				get
				{
					return new SqlParameter("@MemberID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter MemberTypeSpecDurationID
			{
				get
				{
					return new SqlParameter("@MemberTypeSpecDurationID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter StartDate
			{
				get
				{
					return new SqlParameter("@StartDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter EndDate
			{
				get
				{
					return new SqlParameter("@EndDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter CreateBy
			{
				get
				{
					return new SqlParameter("@CreateBy", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string MemberID = "MemberID";
            public const string MemberTypeSpecDurationID = "MemberTypeSpecDurationID";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
            public const string CreateBy = "CreateBy";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _MemberType.PropertyNames.ID;
					ht[MemberID] = _MemberType.PropertyNames.MemberID;
					ht[MemberTypeSpecDurationID] = _MemberType.PropertyNames.MemberTypeSpecDurationID;
					ht[StartDate] = _MemberType.PropertyNames.StartDate;
					ht[EndDate] = _MemberType.PropertyNames.EndDate;
					ht[CreateBy] = _MemberType.PropertyNames.CreateBy;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ID = "ID";
            public const string MemberID = "MemberID";
            public const string MemberTypeSpecDurationID = "MemberTypeSpecDurationID";
            public const string StartDate = "StartDate";
            public const string EndDate = "EndDate";
            public const string CreateBy = "CreateBy";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _MemberType.ColumnNames.ID;
					ht[MemberID] = _MemberType.ColumnNames.MemberID;
					ht[MemberTypeSpecDurationID] = _MemberType.ColumnNames.MemberTypeSpecDurationID;
					ht[StartDate] = _MemberType.ColumnNames.StartDate;
					ht[EndDate] = _MemberType.ColumnNames.EndDate;
					ht[CreateBy] = _MemberType.ColumnNames.CreateBy;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ID = "s_ID";
            public const string MemberID = "s_MemberID";
            public const string MemberTypeSpecDurationID = "s_MemberTypeSpecDurationID";
            public const string StartDate = "s_StartDate";
            public const string EndDate = "s_EndDate";
            public const string CreateBy = "s_CreateBy";

		}
		#endregion		
		
		#region Properties
	
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

		public virtual int MemberID
	    {
			get
	        {
				return base.Getint(ColumnNames.MemberID);
			}
			set
	        {
				base.Setint(ColumnNames.MemberID, value);
			}
		}

		public virtual int MemberTypeSpecDurationID
	    {
			get
	        {
				return base.Getint(ColumnNames.MemberTypeSpecDurationID);
			}
			set
	        {
				base.Setint(ColumnNames.MemberTypeSpecDurationID, value);
			}
		}

		public virtual DateTime StartDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.StartDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.StartDate, value);
			}
		}

		public virtual DateTime EndDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.EndDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.EndDate, value);
			}
		}

		public virtual int CreateBy
	    {
			get
	        {
				return base.Getint(ColumnNames.CreateBy);
			}
			set
	        {
				base.Setint(ColumnNames.CreateBy, value);
			}
		}


		#endregion
		
		#region String Properties
	
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

		public virtual string s_MemberID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.MemberID) ? string.Empty : base.GetintAsString(ColumnNames.MemberID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.MemberID);
				else
					this.MemberID = base.SetintAsString(ColumnNames.MemberID, value);
			}
		}

		public virtual string s_MemberTypeSpecDurationID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.MemberTypeSpecDurationID) ? string.Empty : base.GetintAsString(ColumnNames.MemberTypeSpecDurationID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.MemberTypeSpecDurationID);
				else
					this.MemberTypeSpecDurationID = base.SetintAsString(ColumnNames.MemberTypeSpecDurationID, value);
			}
		}

		public virtual string s_StartDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.StartDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.StartDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.StartDate);
				else
					this.StartDate = base.SetDateTimeAsString(ColumnNames.StartDate, value);
			}
		}

		public virtual string s_EndDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.EndDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.EndDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.EndDate);
				else
					this.EndDate = base.SetDateTimeAsString(ColumnNames.EndDate, value);
			}
		}

		public virtual string s_CreateBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreateBy) ? string.Empty : base.GetintAsString(ColumnNames.CreateBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreateBy);
				else
					this.CreateBy = base.SetintAsString(ColumnNames.CreateBy, value);
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
				
				
				public WhereParameter ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter MemberID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.MemberID, Parameters.MemberID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter MemberTypeSpecDurationID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.MemberTypeSpecDurationID, Parameters.MemberTypeSpecDurationID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter StartDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.StartDate, Parameters.StartDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter EndDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.EndDate, Parameters.EndDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CreateBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreateBy, Parameters.CreateBy);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
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

			public WhereParameter MemberID
		    {
				get
		        {
					if(_MemberID_W == null)
	        	    {
						_MemberID_W = TearOff.MemberID;
					}
					return _MemberID_W;
				}
			}

			public WhereParameter MemberTypeSpecDurationID
		    {
				get
		        {
					if(_MemberTypeSpecDurationID_W == null)
	        	    {
						_MemberTypeSpecDurationID_W = TearOff.MemberTypeSpecDurationID;
					}
					return _MemberTypeSpecDurationID_W;
				}
			}

			public WhereParameter StartDate
		    {
				get
		        {
					if(_StartDate_W == null)
	        	    {
						_StartDate_W = TearOff.StartDate;
					}
					return _StartDate_W;
				}
			}

			public WhereParameter EndDate
		    {
				get
		        {
					if(_EndDate_W == null)
	        	    {
						_EndDate_W = TearOff.EndDate;
					}
					return _EndDate_W;
				}
			}

			public WhereParameter CreateBy
		    {
				get
		        {
					if(_CreateBy_W == null)
	        	    {
						_CreateBy_W = TearOff.CreateBy;
					}
					return _CreateBy_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _MemberID_W = null;
			private WhereParameter _MemberTypeSpecDurationID_W = null;
			private WhereParameter _StartDate_W = null;
			private WhereParameter _EndDate_W = null;
			private WhereParameter _CreateBy_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_MemberID_W = null;
				_MemberTypeSpecDurationID_W = null;
				_StartDate_W = null;
				_EndDate_W = null;
				_CreateBy_W = null;

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
				
				
				public AggregateParameter ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter MemberID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.MemberID, Parameters.MemberID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter MemberTypeSpecDurationID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.MemberTypeSpecDurationID, Parameters.MemberTypeSpecDurationID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter StartDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.StartDate, Parameters.StartDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter EndDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.EndDate, Parameters.EndDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CreateBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreateBy, Parameters.CreateBy);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
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

			public AggregateParameter MemberID
		    {
				get
		        {
					if(_MemberID_W == null)
	        	    {
						_MemberID_W = TearOff.MemberID;
					}
					return _MemberID_W;
				}
			}

			public AggregateParameter MemberTypeSpecDurationID
		    {
				get
		        {
					if(_MemberTypeSpecDurationID_W == null)
	        	    {
						_MemberTypeSpecDurationID_W = TearOff.MemberTypeSpecDurationID;
					}
					return _MemberTypeSpecDurationID_W;
				}
			}

			public AggregateParameter StartDate
		    {
				get
		        {
					if(_StartDate_W == null)
	        	    {
						_StartDate_W = TearOff.StartDate;
					}
					return _StartDate_W;
				}
			}

			public AggregateParameter EndDate
		    {
				get
		        {
					if(_EndDate_W == null)
	        	    {
						_EndDate_W = TearOff.EndDate;
					}
					return _EndDate_W;
				}
			}

			public AggregateParameter CreateBy
		    {
				get
		        {
					if(_CreateBy_W == null)
	        	    {
						_CreateBy_W = TearOff.CreateBy;
					}
					return _CreateBy_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _MemberID_W = null;
			private AggregateParameter _MemberTypeSpecDurationID_W = null;
			private AggregateParameter _StartDate_W = null;
			private AggregateParameter _EndDate_W = null;
			private AggregateParameter _CreateBy_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_MemberID_W = null;
				_MemberTypeSpecDurationID_W = null;
				_StartDate_W = null;
				_EndDate_W = null;
				_CreateBy_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_MemberTypeInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_MemberTypeUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_MemberTypeDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.MemberID);
			p.SourceColumn = ColumnNames.MemberID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.MemberTypeSpecDurationID);
			p.SourceColumn = ColumnNames.MemberTypeSpecDurationID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.StartDate);
			p.SourceColumn = ColumnNames.StartDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.EndDate);
			p.SourceColumn = ColumnNames.EndDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreateBy);
			p.SourceColumn = ColumnNames.CreateBy;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}