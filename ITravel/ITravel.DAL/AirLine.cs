
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

namespace ITravel.DAL
{
	public abstract class _AirLine : SqlClientEntity
	{
		public _AirLine()
		{
			this.QuerySource = "AirLine";
			this.MappingName = "AirLine";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_AirLineLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int AirLineID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.AirLineID, AirLineID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_AirLineLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter AirLineID
			{
				get
				{
					return new SqlParameter("@AirLineID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Name
			{
				get
				{
					return new SqlParameter("@Name", SqlDbType.NVarChar, 100);
				}
			}
			
			public static SqlParameter Description
			{
				get
				{
					return new SqlParameter("@Description", SqlDbType.NVarChar, 2000);
				}
			}
			
			public static SqlParameter Notes
			{
				get
				{
					return new SqlParameter("@Notes", SqlDbType.NVarChar, 1073741823);
				}
			}
			
			public static SqlParameter CreatedBy
			{
				get
				{
					return new SqlParameter("@CreatedBy", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter UpdatedBy
			{
				get
				{
					return new SqlParameter("@UpdatedBy", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter CreatedDate
			{
				get
				{
					return new SqlParameter("@CreatedDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter LastUpdatedDate
			{
				get
				{
					return new SqlParameter("@LastUpdatedDate", SqlDbType.DateTime, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string AirLineID = "AirLineID";
            public const string Name = "Name";
            public const string Description = "Description";
            public const string Notes = "Notes";
            public const string CreatedBy = "CreatedBy";
            public const string UpdatedBy = "UpdatedBy";
            public const string CreatedDate = "CreatedDate";
            public const string LastUpdatedDate = "LastUpdatedDate";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AirLineID] = _AirLine.PropertyNames.AirLineID;
					ht[Name] = _AirLine.PropertyNames.Name;
					ht[Description] = _AirLine.PropertyNames.Description;
					ht[Notes] = _AirLine.PropertyNames.Notes;
					ht[CreatedBy] = _AirLine.PropertyNames.CreatedBy;
					ht[UpdatedBy] = _AirLine.PropertyNames.UpdatedBy;
					ht[CreatedDate] = _AirLine.PropertyNames.CreatedDate;
					ht[LastUpdatedDate] = _AirLine.PropertyNames.LastUpdatedDate;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string AirLineID = "AirLineID";
            public const string Name = "Name";
            public const string Description = "Description";
            public const string Notes = "Notes";
            public const string CreatedBy = "CreatedBy";
            public const string UpdatedBy = "UpdatedBy";
            public const string CreatedDate = "CreatedDate";
            public const string LastUpdatedDate = "LastUpdatedDate";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AirLineID] = _AirLine.ColumnNames.AirLineID;
					ht[Name] = _AirLine.ColumnNames.Name;
					ht[Description] = _AirLine.ColumnNames.Description;
					ht[Notes] = _AirLine.ColumnNames.Notes;
					ht[CreatedBy] = _AirLine.ColumnNames.CreatedBy;
					ht[UpdatedBy] = _AirLine.ColumnNames.UpdatedBy;
					ht[CreatedDate] = _AirLine.ColumnNames.CreatedDate;
					ht[LastUpdatedDate] = _AirLine.ColumnNames.LastUpdatedDate;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string AirLineID = "s_AirLineID";
            public const string Name = "s_Name";
            public const string Description = "s_Description";
            public const string Notes = "s_Notes";
            public const string CreatedBy = "s_CreatedBy";
            public const string UpdatedBy = "s_UpdatedBy";
            public const string CreatedDate = "s_CreatedDate";
            public const string LastUpdatedDate = "s_LastUpdatedDate";

		}
		#endregion		
		
		#region Properties
	
		public virtual int AirLineID
	    {
			get
	        {
				return base.Getint(ColumnNames.AirLineID);
			}
			set
	        {
				base.Setint(ColumnNames.AirLineID, value);
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

		public virtual Guid UpdatedBy
	    {
			get
	        {
				return base.GetGuid(ColumnNames.UpdatedBy);
			}
			set
	        {
				base.SetGuid(ColumnNames.UpdatedBy, value);
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

		public virtual DateTime LastUpdatedDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.LastUpdatedDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.LastUpdatedDate, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_AirLineID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AirLineID) ? string.Empty : base.GetintAsString(ColumnNames.AirLineID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AirLineID);
				else
					this.AirLineID = base.SetintAsString(ColumnNames.AirLineID, value);
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

		public virtual string s_UpdatedBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UpdatedBy) ? string.Empty : base.GetGuidAsString(ColumnNames.UpdatedBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UpdatedBy);
				else
					this.UpdatedBy = base.SetGuidAsString(ColumnNames.UpdatedBy, value);
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

		public virtual string s_LastUpdatedDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LastUpdatedDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.LastUpdatedDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LastUpdatedDate);
				else
					this.LastUpdatedDate = base.SetDateTimeAsString(ColumnNames.LastUpdatedDate, value);
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
				
				
				public WhereParameter AirLineID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AirLineID, Parameters.AirLineID);
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

				public WhereParameter Description
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Description, Parameters.Description);
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

				public WhereParameter UpdatedBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UpdatedBy, Parameters.UpdatedBy);
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

				public WhereParameter LastUpdatedDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LastUpdatedDate, Parameters.LastUpdatedDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter AirLineID
		    {
				get
		        {
					if(_AirLineID_W == null)
	        	    {
						_AirLineID_W = TearOff.AirLineID;
					}
					return _AirLineID_W;
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

			public WhereParameter UpdatedBy
		    {
				get
		        {
					if(_UpdatedBy_W == null)
	        	    {
						_UpdatedBy_W = TearOff.UpdatedBy;
					}
					return _UpdatedBy_W;
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

			public WhereParameter LastUpdatedDate
		    {
				get
		        {
					if(_LastUpdatedDate_W == null)
	        	    {
						_LastUpdatedDate_W = TearOff.LastUpdatedDate;
					}
					return _LastUpdatedDate_W;
				}
			}

			private WhereParameter _AirLineID_W = null;
			private WhereParameter _Name_W = null;
			private WhereParameter _Description_W = null;
			private WhereParameter _Notes_W = null;
			private WhereParameter _CreatedBy_W = null;
			private WhereParameter _UpdatedBy_W = null;
			private WhereParameter _CreatedDate_W = null;
			private WhereParameter _LastUpdatedDate_W = null;

			public void WhereClauseReset()
			{
				_AirLineID_W = null;
				_Name_W = null;
				_Description_W = null;
				_Notes_W = null;
				_CreatedBy_W = null;
				_UpdatedBy_W = null;
				_CreatedDate_W = null;
				_LastUpdatedDate_W = null;

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
				
				
				public AggregateParameter AirLineID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AirLineID, Parameters.AirLineID);
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

				public AggregateParameter Description
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Description, Parameters.Description);
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

				public AggregateParameter UpdatedBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UpdatedBy, Parameters.UpdatedBy);
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

				public AggregateParameter LastUpdatedDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LastUpdatedDate, Parameters.LastUpdatedDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter AirLineID
		    {
				get
		        {
					if(_AirLineID_W == null)
	        	    {
						_AirLineID_W = TearOff.AirLineID;
					}
					return _AirLineID_W;
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

			public AggregateParameter UpdatedBy
		    {
				get
		        {
					if(_UpdatedBy_W == null)
	        	    {
						_UpdatedBy_W = TearOff.UpdatedBy;
					}
					return _UpdatedBy_W;
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

			public AggregateParameter LastUpdatedDate
		    {
				get
		        {
					if(_LastUpdatedDate_W == null)
	        	    {
						_LastUpdatedDate_W = TearOff.LastUpdatedDate;
					}
					return _LastUpdatedDate_W;
				}
			}

			private AggregateParameter _AirLineID_W = null;
			private AggregateParameter _Name_W = null;
			private AggregateParameter _Description_W = null;
			private AggregateParameter _Notes_W = null;
			private AggregateParameter _CreatedBy_W = null;
			private AggregateParameter _UpdatedBy_W = null;
			private AggregateParameter _CreatedDate_W = null;
			private AggregateParameter _LastUpdatedDate_W = null;

			public void AggregateClauseReset()
			{
				_AirLineID_W = null;
				_Name_W = null;
				_Description_W = null;
				_Notes_W = null;
				_CreatedBy_W = null;
				_UpdatedBy_W = null;
				_CreatedDate_W = null;
				_LastUpdatedDate_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_AirLineInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.AirLineID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_AirLineUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_AirLineDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.AirLineID);
			p.SourceColumn = ColumnNames.AirLineID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.AirLineID);
			p.SourceColumn = ColumnNames.AirLineID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Name);
			p.SourceColumn = ColumnNames.Name;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Description);
			p.SourceColumn = ColumnNames.Description;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Notes);
			p.SourceColumn = ColumnNames.Notes;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreatedBy);
			p.SourceColumn = ColumnNames.CreatedBy;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UpdatedBy);
			p.SourceColumn = ColumnNames.UpdatedBy;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreatedDate);
			p.SourceColumn = ColumnNames.CreatedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LastUpdatedDate);
			p.SourceColumn = ColumnNames.LastUpdatedDate;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
