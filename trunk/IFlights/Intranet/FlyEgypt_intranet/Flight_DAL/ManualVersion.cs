
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
	public abstract class _ManualVersion : SqlClientEntity
	{
		public _ManualVersion()
		{
			this.QuerySource = "ManualVersion";
			this.MappingName = "ManualVersion";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ManualVersionLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ManualVersionID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ManualVersionID, ManualVersionID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ManualVersionLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ManualVersionID
			{
				get
				{
					return new SqlParameter("@ManualVersionID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ManualID
			{
				get
				{
					return new SqlParameter("@ManualID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Title
			{
				get
				{
					return new SqlParameter("@Title", SqlDbType.NVarChar, 300);
				}
			}
			
			public static SqlParameter Path
			{
				get
				{
					return new SqlParameter("@Path", SqlDbType.NVarChar, 300);
				}
			}
			
			public static SqlParameter CreatedBy
			{
				get
				{
					return new SqlParameter("@CreatedBy", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter CreatedDate
			{
				get
				{
					return new SqlParameter("@CreatedDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter UpdatedBy
			{
				get
				{
					return new SqlParameter("@UpdatedBy", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter LastUpdatedDate
			{
				get
				{
					return new SqlParameter("@LastUpdatedDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter IssueNumber
			{
				get
				{
					return new SqlParameter("@IssueNumber", SqlDbType.NVarChar, 10);
				}
			}
			
			public static SqlParameter IssueDate
			{
				get
				{
					return new SqlParameter("@IssueDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter RevisionNumber
			{
				get
				{
					return new SqlParameter("@RevisionNumber", SqlDbType.NVarChar, 10);
				}
			}
			
			public static SqlParameter RevisionDate
			{
				get
				{
					return new SqlParameter("@RevisionDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter Notes
			{
				get
				{
					return new SqlParameter("@Notes", SqlDbType.NVarChar, 1073741823);
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
            public const string ManualVersionID = "ManualVersionID";
            public const string ManualID = "ManualID";
            public const string Title = "Title";
            public const string Path = "Path";
            public const string CreatedBy = "CreatedBy";
            public const string CreatedDate = "CreatedDate";
            public const string UpdatedBy = "UpdatedBy";
            public const string LastUpdatedDate = "LastUpdatedDate";
            public const string IssueNumber = "IssueNumber";
            public const string IssueDate = "IssueDate";
            public const string RevisionNumber = "RevisionNumber";
            public const string RevisionDate = "RevisionDate";
            public const string Notes = "Notes";
            public const string IsDeleted = "isDeleted";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ManualVersionID] = _ManualVersion.PropertyNames.ManualVersionID;
					ht[ManualID] = _ManualVersion.PropertyNames.ManualID;
					ht[Title] = _ManualVersion.PropertyNames.Title;
					ht[Path] = _ManualVersion.PropertyNames.Path;
					ht[CreatedBy] = _ManualVersion.PropertyNames.CreatedBy;
					ht[CreatedDate] = _ManualVersion.PropertyNames.CreatedDate;
					ht[UpdatedBy] = _ManualVersion.PropertyNames.UpdatedBy;
					ht[LastUpdatedDate] = _ManualVersion.PropertyNames.LastUpdatedDate;
					ht[IssueNumber] = _ManualVersion.PropertyNames.IssueNumber;
					ht[IssueDate] = _ManualVersion.PropertyNames.IssueDate;
					ht[RevisionNumber] = _ManualVersion.PropertyNames.RevisionNumber;
					ht[RevisionDate] = _ManualVersion.PropertyNames.RevisionDate;
					ht[Notes] = _ManualVersion.PropertyNames.Notes;
					ht[IsDeleted] = _ManualVersion.PropertyNames.IsDeleted;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ManualVersionID = "ManualVersionID";
            public const string ManualID = "ManualID";
            public const string Title = "Title";
            public const string Path = "Path";
            public const string CreatedBy = "CreatedBy";
            public const string CreatedDate = "CreatedDate";
            public const string UpdatedBy = "UpdatedBy";
            public const string LastUpdatedDate = "LastUpdatedDate";
            public const string IssueNumber = "IssueNumber";
            public const string IssueDate = "IssueDate";
            public const string RevisionNumber = "RevisionNumber";
            public const string RevisionDate = "RevisionDate";
            public const string Notes = "Notes";
            public const string IsDeleted = "IsDeleted";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ManualVersionID] = _ManualVersion.ColumnNames.ManualVersionID;
					ht[ManualID] = _ManualVersion.ColumnNames.ManualID;
					ht[Title] = _ManualVersion.ColumnNames.Title;
					ht[Path] = _ManualVersion.ColumnNames.Path;
					ht[CreatedBy] = _ManualVersion.ColumnNames.CreatedBy;
					ht[CreatedDate] = _ManualVersion.ColumnNames.CreatedDate;
					ht[UpdatedBy] = _ManualVersion.ColumnNames.UpdatedBy;
					ht[LastUpdatedDate] = _ManualVersion.ColumnNames.LastUpdatedDate;
					ht[IssueNumber] = _ManualVersion.ColumnNames.IssueNumber;
					ht[IssueDate] = _ManualVersion.ColumnNames.IssueDate;
					ht[RevisionNumber] = _ManualVersion.ColumnNames.RevisionNumber;
					ht[RevisionDate] = _ManualVersion.ColumnNames.RevisionDate;
					ht[Notes] = _ManualVersion.ColumnNames.Notes;
					ht[IsDeleted] = _ManualVersion.ColumnNames.IsDeleted;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ManualVersionID = "s_ManualVersionID";
            public const string ManualID = "s_ManualID";
            public const string Title = "s_Title";
            public const string Path = "s_Path";
            public const string CreatedBy = "s_CreatedBy";
            public const string CreatedDate = "s_CreatedDate";
            public const string UpdatedBy = "s_UpdatedBy";
            public const string LastUpdatedDate = "s_LastUpdatedDate";
            public const string IssueNumber = "s_IssueNumber";
            public const string IssueDate = "s_IssueDate";
            public const string RevisionNumber = "s_RevisionNumber";
            public const string RevisionDate = "s_RevisionDate";
            public const string Notes = "s_Notes";
            public const string IsDeleted = "s_IsDeleted";

		}
		#endregion		
		
		#region Properties
	
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

		public virtual string Title
	    {
			get
	        {
				return base.Getstring(ColumnNames.Title);
			}
			set
	        {
				base.Setstring(ColumnNames.Title, value);
			}
		}

		public virtual string Path
	    {
			get
	        {
				return base.Getstring(ColumnNames.Path);
			}
			set
	        {
				base.Setstring(ColumnNames.Path, value);
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

		public virtual string IssueNumber
	    {
			get
	        {
				return base.Getstring(ColumnNames.IssueNumber);
			}
			set
	        {
				base.Setstring(ColumnNames.IssueNumber, value);
			}
		}

		public virtual DateTime IssueDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.IssueDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.IssueDate, value);
			}
		}

		public virtual string RevisionNumber
	    {
			get
	        {
				return base.Getstring(ColumnNames.RevisionNumber);
			}
			set
	        {
				base.Setstring(ColumnNames.RevisionNumber, value);
			}
		}

		public virtual DateTime RevisionDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.RevisionDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.RevisionDate, value);
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

		public virtual string s_Title
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Title) ? string.Empty : base.GetstringAsString(ColumnNames.Title);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Title);
				else
					this.Title = base.SetstringAsString(ColumnNames.Title, value);
			}
		}

		public virtual string s_Path
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Path) ? string.Empty : base.GetstringAsString(ColumnNames.Path);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Path);
				else
					this.Path = base.SetstringAsString(ColumnNames.Path, value);
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

		public virtual string s_IssueNumber
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IssueNumber) ? string.Empty : base.GetstringAsString(ColumnNames.IssueNumber);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IssueNumber);
				else
					this.IssueNumber = base.SetstringAsString(ColumnNames.IssueNumber, value);
			}
		}

		public virtual string s_IssueDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IssueDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.IssueDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IssueDate);
				else
					this.IssueDate = base.SetDateTimeAsString(ColumnNames.IssueDate, value);
			}
		}

		public virtual string s_RevisionNumber
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.RevisionNumber) ? string.Empty : base.GetstringAsString(ColumnNames.RevisionNumber);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.RevisionNumber);
				else
					this.RevisionNumber = base.SetstringAsString(ColumnNames.RevisionNumber, value);
			}
		}

		public virtual string s_RevisionDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.RevisionDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.RevisionDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.RevisionDate);
				else
					this.RevisionDate = base.SetDateTimeAsString(ColumnNames.RevisionDate, value);
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
				
				
				public WhereParameter ManualVersionID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ManualVersionID, Parameters.ManualVersionID);
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

				public WhereParameter Title
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Title, Parameters.Title);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Path
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Path, Parameters.Path);
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

				public WhereParameter CreatedDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreatedDate, Parameters.CreatedDate);
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

				public WhereParameter LastUpdatedDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LastUpdatedDate, Parameters.LastUpdatedDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IssueNumber
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IssueNumber, Parameters.IssueNumber);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IssueDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IssueDate, Parameters.IssueDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter RevisionNumber
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.RevisionNumber, Parameters.RevisionNumber);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter RevisionDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.RevisionDate, Parameters.RevisionDate);
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

			public WhereParameter Title
		    {
				get
		        {
					if(_Title_W == null)
	        	    {
						_Title_W = TearOff.Title;
					}
					return _Title_W;
				}
			}

			public WhereParameter Path
		    {
				get
		        {
					if(_Path_W == null)
	        	    {
						_Path_W = TearOff.Path;
					}
					return _Path_W;
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

			public WhereParameter IssueNumber
		    {
				get
		        {
					if(_IssueNumber_W == null)
	        	    {
						_IssueNumber_W = TearOff.IssueNumber;
					}
					return _IssueNumber_W;
				}
			}

			public WhereParameter IssueDate
		    {
				get
		        {
					if(_IssueDate_W == null)
	        	    {
						_IssueDate_W = TearOff.IssueDate;
					}
					return _IssueDate_W;
				}
			}

			public WhereParameter RevisionNumber
		    {
				get
		        {
					if(_RevisionNumber_W == null)
	        	    {
						_RevisionNumber_W = TearOff.RevisionNumber;
					}
					return _RevisionNumber_W;
				}
			}

			public WhereParameter RevisionDate
		    {
				get
		        {
					if(_RevisionDate_W == null)
	        	    {
						_RevisionDate_W = TearOff.RevisionDate;
					}
					return _RevisionDate_W;
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

			private WhereParameter _ManualVersionID_W = null;
			private WhereParameter _ManualID_W = null;
			private WhereParameter _Title_W = null;
			private WhereParameter _Path_W = null;
			private WhereParameter _CreatedBy_W = null;
			private WhereParameter _CreatedDate_W = null;
			private WhereParameter _UpdatedBy_W = null;
			private WhereParameter _LastUpdatedDate_W = null;
			private WhereParameter _IssueNumber_W = null;
			private WhereParameter _IssueDate_W = null;
			private WhereParameter _RevisionNumber_W = null;
			private WhereParameter _RevisionDate_W = null;
			private WhereParameter _Notes_W = null;
			private WhereParameter _IsDeleted_W = null;

			public void WhereClauseReset()
			{
				_ManualVersionID_W = null;
				_ManualID_W = null;
				_Title_W = null;
				_Path_W = null;
				_CreatedBy_W = null;
				_CreatedDate_W = null;
				_UpdatedBy_W = null;
				_LastUpdatedDate_W = null;
				_IssueNumber_W = null;
				_IssueDate_W = null;
				_RevisionNumber_W = null;
				_RevisionDate_W = null;
				_Notes_W = null;
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
				
				
				public AggregateParameter ManualVersionID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ManualVersionID, Parameters.ManualVersionID);
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

				public AggregateParameter Title
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Title, Parameters.Title);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Path
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Path, Parameters.Path);
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

				public AggregateParameter CreatedDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreatedDate, Parameters.CreatedDate);
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

				public AggregateParameter LastUpdatedDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LastUpdatedDate, Parameters.LastUpdatedDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IssueNumber
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IssueNumber, Parameters.IssueNumber);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IssueDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IssueDate, Parameters.IssueDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter RevisionNumber
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.RevisionNumber, Parameters.RevisionNumber);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter RevisionDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.RevisionDate, Parameters.RevisionDate);
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

			public AggregateParameter Title
		    {
				get
		        {
					if(_Title_W == null)
	        	    {
						_Title_W = TearOff.Title;
					}
					return _Title_W;
				}
			}

			public AggregateParameter Path
		    {
				get
		        {
					if(_Path_W == null)
	        	    {
						_Path_W = TearOff.Path;
					}
					return _Path_W;
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

			public AggregateParameter IssueNumber
		    {
				get
		        {
					if(_IssueNumber_W == null)
	        	    {
						_IssueNumber_W = TearOff.IssueNumber;
					}
					return _IssueNumber_W;
				}
			}

			public AggregateParameter IssueDate
		    {
				get
		        {
					if(_IssueDate_W == null)
	        	    {
						_IssueDate_W = TearOff.IssueDate;
					}
					return _IssueDate_W;
				}
			}

			public AggregateParameter RevisionNumber
		    {
				get
		        {
					if(_RevisionNumber_W == null)
	        	    {
						_RevisionNumber_W = TearOff.RevisionNumber;
					}
					return _RevisionNumber_W;
				}
			}

			public AggregateParameter RevisionDate
		    {
				get
		        {
					if(_RevisionDate_W == null)
	        	    {
						_RevisionDate_W = TearOff.RevisionDate;
					}
					return _RevisionDate_W;
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

			private AggregateParameter _ManualVersionID_W = null;
			private AggregateParameter _ManualID_W = null;
			private AggregateParameter _Title_W = null;
			private AggregateParameter _Path_W = null;
			private AggregateParameter _CreatedBy_W = null;
			private AggregateParameter _CreatedDate_W = null;
			private AggregateParameter _UpdatedBy_W = null;
			private AggregateParameter _LastUpdatedDate_W = null;
			private AggregateParameter _IssueNumber_W = null;
			private AggregateParameter _IssueDate_W = null;
			private AggregateParameter _RevisionNumber_W = null;
			private AggregateParameter _RevisionDate_W = null;
			private AggregateParameter _Notes_W = null;
			private AggregateParameter _IsDeleted_W = null;

			public void AggregateClauseReset()
			{
				_ManualVersionID_W = null;
				_ManualID_W = null;
				_Title_W = null;
				_Path_W = null;
				_CreatedBy_W = null;
				_CreatedDate_W = null;
				_UpdatedBy_W = null;
				_LastUpdatedDate_W = null;
				_IssueNumber_W = null;
				_IssueDate_W = null;
				_RevisionNumber_W = null;
				_RevisionDate_W = null;
				_Notes_W = null;
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ManualVersionInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ManualVersionID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ManualVersionUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ManualVersionDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ManualVersionID);
			p.SourceColumn = ColumnNames.ManualVersionID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ManualVersionID);
			p.SourceColumn = ColumnNames.ManualVersionID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ManualID);
			p.SourceColumn = ColumnNames.ManualID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Title);
			p.SourceColumn = ColumnNames.Title;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Path);
			p.SourceColumn = ColumnNames.Path;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreatedBy);
			p.SourceColumn = ColumnNames.CreatedBy;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreatedDate);
			p.SourceColumn = ColumnNames.CreatedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UpdatedBy);
			p.SourceColumn = ColumnNames.UpdatedBy;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LastUpdatedDate);
			p.SourceColumn = ColumnNames.LastUpdatedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IssueNumber);
			p.SourceColumn = ColumnNames.IssueNumber;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IssueDate);
			p.SourceColumn = ColumnNames.IssueDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.RevisionNumber);
			p.SourceColumn = ColumnNames.RevisionNumber;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.RevisionDate);
			p.SourceColumn = ColumnNames.RevisionDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Notes);
			p.SourceColumn = ColumnNames.Notes;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsDeleted);
			p.SourceColumn = ColumnNames.IsDeleted;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
