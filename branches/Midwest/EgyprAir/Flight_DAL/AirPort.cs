
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
	public abstract class _AirPort : SqlClientEntity
	{
		public _AirPort()
		{
			this.QuerySource = "AirPort";
			this.MappingName = "AirPort";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_AirPortLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int AirPortID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.AirPortID, AirPortID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_AirPortLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter AirPortID
			{
				get
				{
					return new SqlParameter("@AirPortID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Name
			{
				get
				{
					return new SqlParameter("@Name", SqlDbType.NVarChar, 100);
				}
			}
			
			public static SqlParameter IATACode
			{
				get
				{
					return new SqlParameter("@IATACode", SqlDbType.NVarChar, 5);
				}
			}
			
			public static SqlParameter ACAICode
			{
				get
				{
					return new SqlParameter("@ACAICode", SqlDbType.NVarChar, 10);
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
			
			public static SqlParameter Class
			{
				get
				{
					return new SqlParameter("@Class", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string AirPortID = "AirPortID";
            public const string Name = "Name";
            public const string IATACode = "IATACode";
            public const string ACAICode = "ACAICode";
            public const string Description = "Description";
            public const string Notes = "Notes";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
            public const string CreatedDate = "CreatedDate";
            public const string LastModifiedDate = "LastModifiedDate";
            public const string Class = "Class";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AirPortID] = _AirPort.PropertyNames.AirPortID;
					ht[Name] = _AirPort.PropertyNames.Name;
					ht[IATACode] = _AirPort.PropertyNames.IATACode;
					ht[ACAICode] = _AirPort.PropertyNames.ACAICode;
					ht[Description] = _AirPort.PropertyNames.Description;
					ht[Notes] = _AirPort.PropertyNames.Notes;
					ht[CreatedBy] = _AirPort.PropertyNames.CreatedBy;
					ht[ModifiedBy] = _AirPort.PropertyNames.ModifiedBy;
					ht[CreatedDate] = _AirPort.PropertyNames.CreatedDate;
					ht[LastModifiedDate] = _AirPort.PropertyNames.LastModifiedDate;
					ht[Class] = _AirPort.PropertyNames.Class;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string AirPortID = "AirPortID";
            public const string Name = "Name";
            public const string IATACode = "IATACode";
            public const string ACAICode = "ACAICode";
            public const string Description = "Description";
            public const string Notes = "Notes";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedBy = "ModifiedBy";
            public const string CreatedDate = "CreatedDate";
            public const string LastModifiedDate = "LastModifiedDate";
            public const string Class = "Class";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AirPortID] = _AirPort.ColumnNames.AirPortID;
					ht[Name] = _AirPort.ColumnNames.Name;
					ht[IATACode] = _AirPort.ColumnNames.IATACode;
					ht[ACAICode] = _AirPort.ColumnNames.ACAICode;
					ht[Description] = _AirPort.ColumnNames.Description;
					ht[Notes] = _AirPort.ColumnNames.Notes;
					ht[CreatedBy] = _AirPort.ColumnNames.CreatedBy;
					ht[ModifiedBy] = _AirPort.ColumnNames.ModifiedBy;
					ht[CreatedDate] = _AirPort.ColumnNames.CreatedDate;
					ht[LastModifiedDate] = _AirPort.ColumnNames.LastModifiedDate;
					ht[Class] = _AirPort.ColumnNames.Class;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string AirPortID = "s_AirPortID";
            public const string Name = "s_Name";
            public const string IATACode = "s_IATACode";
            public const string ACAICode = "s_ACAICode";
            public const string Description = "s_Description";
            public const string Notes = "s_Notes";
            public const string CreatedBy = "s_CreatedBy";
            public const string ModifiedBy = "s_ModifiedBy";
            public const string CreatedDate = "s_CreatedDate";
            public const string LastModifiedDate = "s_LastModifiedDate";
            public const string Class = "s_Class";

		}
		#endregion		
		
		#region Properties
	
		public virtual int AirPortID
	    {
			get
	        {
				return base.Getint(ColumnNames.AirPortID);
			}
			set
	        {
				base.Setint(ColumnNames.AirPortID, value);
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

		public virtual string IATACode
	    {
			get
	        {
				return base.Getstring(ColumnNames.IATACode);
			}
			set
	        {
				base.Setstring(ColumnNames.IATACode, value);
			}
		}

		public virtual string ACAICode
	    {
			get
	        {
				return base.Getstring(ColumnNames.ACAICode);
			}
			set
	        {
				base.Setstring(ColumnNames.ACAICode, value);
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

		public virtual int Class
	    {
			get
	        {
				return base.Getint(ColumnNames.Class);
			}
			set
	        {
				base.Setint(ColumnNames.Class, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_AirPortID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AirPortID) ? string.Empty : base.GetintAsString(ColumnNames.AirPortID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AirPortID);
				else
					this.AirPortID = base.SetintAsString(ColumnNames.AirPortID, value);
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

		public virtual string s_IATACode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IATACode) ? string.Empty : base.GetstringAsString(ColumnNames.IATACode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IATACode);
				else
					this.IATACode = base.SetstringAsString(ColumnNames.IATACode, value);
			}
		}

		public virtual string s_ACAICode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ACAICode) ? string.Empty : base.GetstringAsString(ColumnNames.ACAICode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ACAICode);
				else
					this.ACAICode = base.SetstringAsString(ColumnNames.ACAICode, value);
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

		public virtual string s_Class
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Class) ? string.Empty : base.GetintAsString(ColumnNames.Class);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Class);
				else
					this.Class = base.SetintAsString(ColumnNames.Class, value);
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
				
				
				public WhereParameter AirPortID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AirPortID, Parameters.AirPortID);
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

				public WhereParameter IATACode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IATACode, Parameters.IATACode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ACAICode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ACAICode, Parameters.ACAICode);
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

				public WhereParameter Class
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Class, Parameters.Class);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter AirPortID
		    {
				get
		        {
					if(_AirPortID_W == null)
	        	    {
						_AirPortID_W = TearOff.AirPortID;
					}
					return _AirPortID_W;
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

			public WhereParameter IATACode
		    {
				get
		        {
					if(_IATACode_W == null)
	        	    {
						_IATACode_W = TearOff.IATACode;
					}
					return _IATACode_W;
				}
			}

			public WhereParameter ACAICode
		    {
				get
		        {
					if(_ACAICode_W == null)
	        	    {
						_ACAICode_W = TearOff.ACAICode;
					}
					return _ACAICode_W;
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

			public WhereParameter Class
		    {
				get
		        {
					if(_Class_W == null)
	        	    {
						_Class_W = TearOff.Class;
					}
					return _Class_W;
				}
			}

			private WhereParameter _AirPortID_W = null;
			private WhereParameter _Name_W = null;
			private WhereParameter _IATACode_W = null;
			private WhereParameter _ACAICode_W = null;
			private WhereParameter _Description_W = null;
			private WhereParameter _Notes_W = null;
			private WhereParameter _CreatedBy_W = null;
			private WhereParameter _ModifiedBy_W = null;
			private WhereParameter _CreatedDate_W = null;
			private WhereParameter _LastModifiedDate_W = null;
			private WhereParameter _Class_W = null;

			public void WhereClauseReset()
			{
				_AirPortID_W = null;
				_Name_W = null;
				_IATACode_W = null;
				_ACAICode_W = null;
				_Description_W = null;
				_Notes_W = null;
				_CreatedBy_W = null;
				_ModifiedBy_W = null;
				_CreatedDate_W = null;
				_LastModifiedDate_W = null;
				_Class_W = null;

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
				
				
				public AggregateParameter AirPortID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AirPortID, Parameters.AirPortID);
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

				public AggregateParameter IATACode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IATACode, Parameters.IATACode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ACAICode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ACAICode, Parameters.ACAICode);
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

				public AggregateParameter Class
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Class, Parameters.Class);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter AirPortID
		    {
				get
		        {
					if(_AirPortID_W == null)
	        	    {
						_AirPortID_W = TearOff.AirPortID;
					}
					return _AirPortID_W;
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

			public AggregateParameter IATACode
		    {
				get
		        {
					if(_IATACode_W == null)
	        	    {
						_IATACode_W = TearOff.IATACode;
					}
					return _IATACode_W;
				}
			}

			public AggregateParameter ACAICode
		    {
				get
		        {
					if(_ACAICode_W == null)
	        	    {
						_ACAICode_W = TearOff.ACAICode;
					}
					return _ACAICode_W;
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

			public AggregateParameter Class
		    {
				get
		        {
					if(_Class_W == null)
	        	    {
						_Class_W = TearOff.Class;
					}
					return _Class_W;
				}
			}

			private AggregateParameter _AirPortID_W = null;
			private AggregateParameter _Name_W = null;
			private AggregateParameter _IATACode_W = null;
			private AggregateParameter _ACAICode_W = null;
			private AggregateParameter _Description_W = null;
			private AggregateParameter _Notes_W = null;
			private AggregateParameter _CreatedBy_W = null;
			private AggregateParameter _ModifiedBy_W = null;
			private AggregateParameter _CreatedDate_W = null;
			private AggregateParameter _LastModifiedDate_W = null;
			private AggregateParameter _Class_W = null;

			public void AggregateClauseReset()
			{
				_AirPortID_W = null;
				_Name_W = null;
				_IATACode_W = null;
				_ACAICode_W = null;
				_Description_W = null;
				_Notes_W = null;
				_CreatedBy_W = null;
				_ModifiedBy_W = null;
				_CreatedDate_W = null;
				_LastModifiedDate_W = null;
				_Class_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_AirPortInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.AirPortID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_AirPortUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_AirPortDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.AirPortID);
			p.SourceColumn = ColumnNames.AirPortID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.AirPortID);
			p.SourceColumn = ColumnNames.AirPortID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Name);
			p.SourceColumn = ColumnNames.Name;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IATACode);
			p.SourceColumn = ColumnNames.IATACode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ACAICode);
			p.SourceColumn = ColumnNames.ACAICode;
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

			p = cmd.Parameters.Add(Parameters.ModifiedBy);
			p.SourceColumn = ColumnNames.ModifiedBy;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreatedDate);
			p.SourceColumn = ColumnNames.CreatedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LastModifiedDate);
			p.SourceColumn = ColumnNames.LastModifiedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Class);
			p.SourceColumn = ColumnNames.Class;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
