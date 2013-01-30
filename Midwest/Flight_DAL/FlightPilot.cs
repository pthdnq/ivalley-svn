
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
	public abstract class _FlightPilot : SqlClientEntity
	{
		public _FlightPilot()
		{
			this.QuerySource = "FlightPilot";
			this.MappingName = "FlightPilot";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_FlightPilotLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ReportPilotID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ReportPilotID, ReportPilotID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_FlightPilotLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ReportPilotID
			{
				get
				{
					return new SqlParameter("@ReportPilotID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ReportID
			{
				get
				{
					return new SqlParameter("@ReportID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PilotID
			{
				get
				{
					return new SqlParameter("@PilotID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PositionID
			{
				get
				{
					return new SqlParameter("@PositionID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Notes
			{
				get
				{
					return new SqlParameter("@Notes", SqlDbType.NVarChar, 500);
				}
			}
			
			public static SqlParameter CreatedBy
			{
				get
				{
					return new SqlParameter("@CreatedBy", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter ModifiedBy
			{
				get
				{
					return new SqlParameter("@ModifiedBy", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter CreatedDate
			{
				get
				{
					return new SqlParameter("@CreatedDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter LastModifiedDate
			{
				get
				{
					return new SqlParameter("@LastModifiedDate", SqlDbType.DateTime, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ReportPilotID = "ReportPilotID";
            public const string ReportID = "ReportID";
            public const string PilotID = "PilotID";
            public const string PositionID = "PositionID";
            public const string Notes = "Notes";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
            public const string CreatedDate = "CreatedDate";
            public const string LastModifiedDate = "LastModifiedDate";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ReportPilotID] = _FlightPilot.PropertyNames.ReportPilotID;
					ht[ReportID] = _FlightPilot.PropertyNames.ReportID;
					ht[PilotID] = _FlightPilot.PropertyNames.PilotID;
					ht[PositionID] = _FlightPilot.PropertyNames.PositionID;
					ht[Notes] = _FlightPilot.PropertyNames.Notes;
					ht[CreatedBy] = _FlightPilot.PropertyNames.CreatedBy;
					ht[ModifiedBy] = _FlightPilot.PropertyNames.ModifiedBy;
					ht[CreatedDate] = _FlightPilot.PropertyNames.CreatedDate;
					ht[LastModifiedDate] = _FlightPilot.PropertyNames.LastModifiedDate;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ReportPilotID = "ReportPilotID";
            public const string ReportID = "ReportID";
            public const string PilotID = "PilotID";
            public const string PositionID = "PositionID";
            public const string Notes = "Notes";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
            public const string CreatedDate = "CreatedDate";
            public const string LastModifiedDate = "LastModifiedDate";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ReportPilotID] = _FlightPilot.ColumnNames.ReportPilotID;
					ht[ReportID] = _FlightPilot.ColumnNames.ReportID;
					ht[PilotID] = _FlightPilot.ColumnNames.PilotID;
					ht[PositionID] = _FlightPilot.ColumnNames.PositionID;
					ht[Notes] = _FlightPilot.ColumnNames.Notes;
					ht[CreatedBy] = _FlightPilot.ColumnNames.CreatedBy;
					ht[ModifiedBy] = _FlightPilot.ColumnNames.ModifiedBy;
					ht[CreatedDate] = _FlightPilot.ColumnNames.CreatedDate;
					ht[LastModifiedDate] = _FlightPilot.ColumnNames.LastModifiedDate;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ReportPilotID = "s_ReportPilotID";
            public const string ReportID = "s_ReportID";
            public const string PilotID = "s_PilotID";
            public const string PositionID = "s_PositionID";
            public const string Notes = "s_Notes";
            public const string CreatedBy = "s_CreatedBy";
            public const string ModifiedBy = "s_ModifiedBy";
            public const string CreatedDate = "s_CreatedDate";
            public const string LastModifiedDate = "s_LastModifiedDate";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ReportPilotID
	    {
			get
	        {
				return base.Getint(ColumnNames.ReportPilotID);
			}
			set
	        {
				base.Setint(ColumnNames.ReportPilotID, value);
			}
		}

		public virtual int ReportID
	    {
			get
	        {
				return base.Getint(ColumnNames.ReportID);
			}
			set
	        {
				base.Setint(ColumnNames.ReportID, value);
			}
		}

		public virtual int PilotID
	    {
			get
	        {
				return base.Getint(ColumnNames.PilotID);
			}
			set
	        {
				base.Setint(ColumnNames.PilotID, value);
			}
		}

		public virtual int PositionID
	    {
			get
	        {
				return base.Getint(ColumnNames.PositionID);
			}
			set
	        {
				base.Setint(ColumnNames.PositionID, value);
			}
		}

		public virtual string Notes
	    {
			get
	        {
				return base.Getstring(ColumnNames.Notes);
			}
			set
	        {
				base.Setstring(ColumnNames.Notes, value);
			}
		}

		public virtual Guid CreatedBy
	    {
			get
	        {
				return base.GetGuid(ColumnNames.CreatedBy);
			}
			set
	        {
				base.SetGuid(ColumnNames.CreatedBy, value);
			}
		}

		public virtual Guid ModifiedBy
	    {
			get
	        {
				return base.GetGuid(ColumnNames.ModifiedBy);
			}
			set
	        {
				base.SetGuid(ColumnNames.ModifiedBy, value);
			}
		}

		public virtual DateTime CreatedDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.CreatedDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.CreatedDate, value);
			}
		}

		public virtual DateTime LastModifiedDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.LastModifiedDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.LastModifiedDate, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ReportPilotID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReportPilotID) ? string.Empty : base.GetintAsString(ColumnNames.ReportPilotID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReportPilotID);
				else
					this.ReportPilotID = base.SetintAsString(ColumnNames.ReportPilotID, value);
			}
		}

		public virtual string s_ReportID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReportID) ? string.Empty : base.GetintAsString(ColumnNames.ReportID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReportID);
				else
					this.ReportID = base.SetintAsString(ColumnNames.ReportID, value);
			}
		}

		public virtual string s_PilotID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PilotID) ? string.Empty : base.GetintAsString(ColumnNames.PilotID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PilotID);
				else
					this.PilotID = base.SetintAsString(ColumnNames.PilotID, value);
			}
		}

		public virtual string s_PositionID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PositionID) ? string.Empty : base.GetintAsString(ColumnNames.PositionID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PositionID);
				else
					this.PositionID = base.SetintAsString(ColumnNames.PositionID, value);
			}
		}

		public virtual string s_Notes
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Notes) ? string.Empty : base.GetstringAsString(ColumnNames.Notes);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Notes);
				else
					this.Notes = base.SetstringAsString(ColumnNames.Notes, value);
			}
		}

		public virtual string s_CreatedBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreatedBy) ? string.Empty : base.GetGuidAsString(ColumnNames.CreatedBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreatedBy);
				else
					this.CreatedBy = base.SetGuidAsString(ColumnNames.CreatedBy, value);
			}
		}

		public virtual string s_ModifiedBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ModifiedBy) ? string.Empty : base.GetGuidAsString(ColumnNames.ModifiedBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ModifiedBy);
				else
					this.ModifiedBy = base.SetGuidAsString(ColumnNames.ModifiedBy, value);
			}
		}

		public virtual string s_CreatedDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreatedDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.CreatedDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreatedDate);
				else
					this.CreatedDate = base.SetDateTimeAsString(ColumnNames.CreatedDate, value);
			}
		}

		public virtual string s_LastModifiedDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LastModifiedDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.LastModifiedDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LastModifiedDate);
				else
					this.LastModifiedDate = base.SetDateTimeAsString(ColumnNames.LastModifiedDate, value);
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
				
				
				public WhereParameter ReportPilotID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReportPilotID, Parameters.ReportPilotID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ReportID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReportID, Parameters.ReportID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PilotID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PilotID, Parameters.PilotID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PositionID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PositionID, Parameters.PositionID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Notes
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Notes, Parameters.Notes);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CreatedBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreatedBy, Parameters.CreatedBy);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ModifiedBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ModifiedBy, Parameters.ModifiedBy);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CreatedDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreatedDate, Parameters.CreatedDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter LastModifiedDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LastModifiedDate, Parameters.LastModifiedDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ReportPilotID
		    {
				get
		        {
					if(_ReportPilotID_W == null)
	        	    {
						_ReportPilotID_W = TearOff.ReportPilotID;
					}
					return _ReportPilotID_W;
				}
			}

			public WhereParameter ReportID
		    {
				get
		        {
					if(_ReportID_W == null)
	        	    {
						_ReportID_W = TearOff.ReportID;
					}
					return _ReportID_W;
				}
			}

			public WhereParameter PilotID
		    {
				get
		        {
					if(_PilotID_W == null)
	        	    {
						_PilotID_W = TearOff.PilotID;
					}
					return _PilotID_W;
				}
			}

			public WhereParameter PositionID
		    {
				get
		        {
					if(_PositionID_W == null)
	        	    {
						_PositionID_W = TearOff.PositionID;
					}
					return _PositionID_W;
				}
			}

			public WhereParameter Notes
		    {
				get
		        {
					if(_Notes_W == null)
	        	    {
						_Notes_W = TearOff.Notes;
					}
					return _Notes_W;
				}
			}

			public WhereParameter CreatedBy
		    {
				get
		        {
					if(_CreatedBy_W == null)
	        	    {
						_CreatedBy_W = TearOff.CreatedBy;
					}
					return _CreatedBy_W;
				}
			}

			public WhereParameter ModifiedBy
		    {
				get
		        {
					if(_ModifiedBy_W == null)
	        	    {
						_ModifiedBy_W = TearOff.ModifiedBy;
					}
					return _ModifiedBy_W;
				}
			}

			public WhereParameter CreatedDate
		    {
				get
		        {
					if(_CreatedDate_W == null)
	        	    {
						_CreatedDate_W = TearOff.CreatedDate;
					}
					return _CreatedDate_W;
				}
			}

			public WhereParameter LastModifiedDate
		    {
				get
		        {
					if(_LastModifiedDate_W == null)
	        	    {
						_LastModifiedDate_W = TearOff.LastModifiedDate;
					}
					return _LastModifiedDate_W;
				}
			}

			private WhereParameter _ReportPilotID_W = null;
			private WhereParameter _ReportID_W = null;
			private WhereParameter _PilotID_W = null;
			private WhereParameter _PositionID_W = null;
			private WhereParameter _Notes_W = null;
			private WhereParameter _CreatedBy_W = null;
			private WhereParameter _ModifiedBy_W = null;
			private WhereParameter _CreatedDate_W = null;
			private WhereParameter _LastModifiedDate_W = null;

			public void WhereClauseReset()
			{
				_ReportPilotID_W = null;
				_ReportID_W = null;
				_PilotID_W = null;
				_PositionID_W = null;
				_Notes_W = null;
				_CreatedBy_W = null;
				_ModifiedBy_W = null;
				_CreatedDate_W = null;
				_LastModifiedDate_W = null;

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
				
				
				public AggregateParameter ReportPilotID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReportPilotID, Parameters.ReportPilotID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ReportID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReportID, Parameters.ReportID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PilotID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PilotID, Parameters.PilotID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PositionID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PositionID, Parameters.PositionID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Notes
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Notes, Parameters.Notes);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CreatedBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreatedBy, Parameters.CreatedBy);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ModifiedBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ModifiedBy, Parameters.ModifiedBy);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CreatedDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreatedDate, Parameters.CreatedDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter LastModifiedDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LastModifiedDate, Parameters.LastModifiedDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ReportPilotID
		    {
				get
		        {
					if(_ReportPilotID_W == null)
	        	    {
						_ReportPilotID_W = TearOff.ReportPilotID;
					}
					return _ReportPilotID_W;
				}
			}

			public AggregateParameter ReportID
		    {
				get
		        {
					if(_ReportID_W == null)
	        	    {
						_ReportID_W = TearOff.ReportID;
					}
					return _ReportID_W;
				}
			}

			public AggregateParameter PilotID
		    {
				get
		        {
					if(_PilotID_W == null)
	        	    {
						_PilotID_W = TearOff.PilotID;
					}
					return _PilotID_W;
				}
			}

			public AggregateParameter PositionID
		    {
				get
		        {
					if(_PositionID_W == null)
	        	    {
						_PositionID_W = TearOff.PositionID;
					}
					return _PositionID_W;
				}
			}

			public AggregateParameter Notes
		    {
				get
		        {
					if(_Notes_W == null)
	        	    {
						_Notes_W = TearOff.Notes;
					}
					return _Notes_W;
				}
			}

			public AggregateParameter CreatedBy
		    {
				get
		        {
					if(_CreatedBy_W == null)
	        	    {
						_CreatedBy_W = TearOff.CreatedBy;
					}
					return _CreatedBy_W;
				}
			}

			public AggregateParameter ModifiedBy
		    {
				get
		        {
					if(_ModifiedBy_W == null)
	        	    {
						_ModifiedBy_W = TearOff.ModifiedBy;
					}
					return _ModifiedBy_W;
				}
			}

			public AggregateParameter CreatedDate
		    {
				get
		        {
					if(_CreatedDate_W == null)
	        	    {
						_CreatedDate_W = TearOff.CreatedDate;
					}
					return _CreatedDate_W;
				}
			}

			public AggregateParameter LastModifiedDate
		    {
				get
		        {
					if(_LastModifiedDate_W == null)
	        	    {
						_LastModifiedDate_W = TearOff.LastModifiedDate;
					}
					return _LastModifiedDate_W;
				}
			}

			private AggregateParameter _ReportPilotID_W = null;
			private AggregateParameter _ReportID_W = null;
			private AggregateParameter _PilotID_W = null;
			private AggregateParameter _PositionID_W = null;
			private AggregateParameter _Notes_W = null;
			private AggregateParameter _CreatedBy_W = null;
			private AggregateParameter _ModifiedBy_W = null;
			private AggregateParameter _CreatedDate_W = null;
			private AggregateParameter _LastModifiedDate_W = null;

			public void AggregateClauseReset()
			{
				_ReportPilotID_W = null;
				_ReportID_W = null;
				_PilotID_W = null;
				_PositionID_W = null;
				_Notes_W = null;
				_CreatedBy_W = null;
				_ModifiedBy_W = null;
				_CreatedDate_W = null;
				_LastModifiedDate_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_FlightPilotInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ReportPilotID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_FlightPilotUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_FlightPilotDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ReportPilotID);
			p.SourceColumn = ColumnNames.ReportPilotID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ReportPilotID);
			p.SourceColumn = ColumnNames.ReportPilotID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ReportID);
			p.SourceColumn = ColumnNames.ReportID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PilotID);
			p.SourceColumn = ColumnNames.PilotID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PositionID);
			p.SourceColumn = ColumnNames.PositionID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Notes);
			p.SourceColumn = ColumnNames.Notes;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreatedBy);
			p.SourceColumn = ColumnNames.CreatedBy;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ModifiedBy);
			p.SourceColumn = ColumnNames.ModifiedBy;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreatedDate);
			p.SourceColumn = ColumnNames.CreatedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LastModifiedDate);
			p.SourceColumn = ColumnNames.LastModifiedDate;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
