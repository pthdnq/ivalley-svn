
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

namespace EGEMech.DAL
{
	public abstract class _Page : SqlClientEntity
	{
		public _Page()
		{
			this.QuerySource = "Page";
			this.MappingName = "Page";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PageLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int PageID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.PageID, PageID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PageLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter PageID
			{
				get
				{
					return new SqlParameter("@PageID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Title
			{
				get
				{
					return new SqlParameter("@Title", SqlDbType.NVarChar, 300);
				}
			}
			
			public static SqlParameter Name
			{
				get
				{
					return new SqlParameter("@Name", SqlDbType.NVarChar, 200);
				}
			}
			
			public static SqlParameter Content
			{
				get
				{
					return new SqlParameter("@Content", SqlDbType.NVarChar, 1073741823);
				}
			}
			
			public static SqlParameter ParentID
			{
				get
				{
					return new SqlParameter("@ParentID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter InMenu
			{
				get
				{
					return new SqlParameter("@InMenu", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string PageID = "PageID";
            public const string Title = "Title";
            public const string Name = "Name";
            public const string Content = "Content";
            public const string ParentID = "ParentID";
            public const string InMenu = "InMenu";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[PageID] = _Page.PropertyNames.PageID;
					ht[Title] = _Page.PropertyNames.Title;
					ht[Name] = _Page.PropertyNames.Name;
					ht[Content] = _Page.PropertyNames.Content;
					ht[ParentID] = _Page.PropertyNames.ParentID;
					ht[InMenu] = _Page.PropertyNames.InMenu;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string PageID = "PageID";
            public const string Title = "Title";
            public const string Name = "Name";
            public const string Content = "Content";
            public const string ParentID = "ParentID";
            public const string InMenu = "InMenu";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[PageID] = _Page.ColumnNames.PageID;
					ht[Title] = _Page.ColumnNames.Title;
					ht[Name] = _Page.ColumnNames.Name;
					ht[Content] = _Page.ColumnNames.Content;
					ht[ParentID] = _Page.ColumnNames.ParentID;
					ht[InMenu] = _Page.ColumnNames.InMenu;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string PageID = "s_PageID";
            public const string Title = "s_Title";
            public const string Name = "s_Name";
            public const string Content = "s_Content";
            public const string ParentID = "s_ParentID";
            public const string InMenu = "s_InMenu";

		}
		#endregion		
		
		#region Properties
	
		public virtual int PageID
	    {
			get
	        {
				return base.Getint(ColumnNames.PageID);
			}
			set
	        {
				base.Setint(ColumnNames.PageID, value);
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

		public virtual string Content
	    {
			get
	        {
				return base.Getstring(ColumnNames.Content);
			}
			set
	        {
				base.Setstring(ColumnNames.Content, value);
			}
		}

		public virtual int ParentID
	    {
			get
	        {
				return base.Getint(ColumnNames.ParentID);
			}
			set
	        {
				base.Setint(ColumnNames.ParentID, value);
			}
		}

		public virtual bool InMenu
	    {
			get
	        {
				return base.Getbool(ColumnNames.InMenu);
			}
			set
	        {
				base.Setbool(ColumnNames.InMenu, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_PageID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PageID) ? string.Empty : base.GetintAsString(ColumnNames.PageID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PageID);
				else
					this.PageID = base.SetintAsString(ColumnNames.PageID, value);
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

		public virtual string s_Content
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Content) ? string.Empty : base.GetstringAsString(ColumnNames.Content);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Content);
				else
					this.Content = base.SetstringAsString(ColumnNames.Content, value);
			}
		}

		public virtual string s_ParentID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ParentID) ? string.Empty : base.GetintAsString(ColumnNames.ParentID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ParentID);
				else
					this.ParentID = base.SetintAsString(ColumnNames.ParentID, value);
			}
		}

		public virtual string s_InMenu
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.InMenu) ? string.Empty : base.GetboolAsString(ColumnNames.InMenu);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.InMenu);
				else
					this.InMenu = base.SetboolAsString(ColumnNames.InMenu, value);
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
				
				
				public WhereParameter PageID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PageID, Parameters.PageID);
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

				public WhereParameter Name
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Name, Parameters.Name);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Content
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Content, Parameters.Content);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ParentID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ParentID, Parameters.ParentID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter InMenu
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.InMenu, Parameters.InMenu);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter PageID
		    {
				get
		        {
					if(_PageID_W == null)
	        	    {
						_PageID_W = TearOff.PageID;
					}
					return _PageID_W;
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

			public WhereParameter Content
		    {
				get
		        {
					if(_Content_W == null)
	        	    {
						_Content_W = TearOff.Content;
					}
					return _Content_W;
				}
			}

			public WhereParameter ParentID
		    {
				get
		        {
					if(_ParentID_W == null)
	        	    {
						_ParentID_W = TearOff.ParentID;
					}
					return _ParentID_W;
				}
			}

			public WhereParameter InMenu
		    {
				get
		        {
					if(_InMenu_W == null)
	        	    {
						_InMenu_W = TearOff.InMenu;
					}
					return _InMenu_W;
				}
			}

			private WhereParameter _PageID_W = null;
			private WhereParameter _Title_W = null;
			private WhereParameter _Name_W = null;
			private WhereParameter _Content_W = null;
			private WhereParameter _ParentID_W = null;
			private WhereParameter _InMenu_W = null;

			public void WhereClauseReset()
			{
				_PageID_W = null;
				_Title_W = null;
				_Name_W = null;
				_Content_W = null;
				_ParentID_W = null;
				_InMenu_W = null;

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
				
				
				public AggregateParameter PageID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PageID, Parameters.PageID);
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

				public AggregateParameter Name
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Name, Parameters.Name);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Content
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Content, Parameters.Content);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ParentID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ParentID, Parameters.ParentID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter InMenu
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.InMenu, Parameters.InMenu);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter PageID
		    {
				get
		        {
					if(_PageID_W == null)
	        	    {
						_PageID_W = TearOff.PageID;
					}
					return _PageID_W;
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

			public AggregateParameter Content
		    {
				get
		        {
					if(_Content_W == null)
	        	    {
						_Content_W = TearOff.Content;
					}
					return _Content_W;
				}
			}

			public AggregateParameter ParentID
		    {
				get
		        {
					if(_ParentID_W == null)
	        	    {
						_ParentID_W = TearOff.ParentID;
					}
					return _ParentID_W;
				}
			}

			public AggregateParameter InMenu
		    {
				get
		        {
					if(_InMenu_W == null)
	        	    {
						_InMenu_W = TearOff.InMenu;
					}
					return _InMenu_W;
				}
			}

			private AggregateParameter _PageID_W = null;
			private AggregateParameter _Title_W = null;
			private AggregateParameter _Name_W = null;
			private AggregateParameter _Content_W = null;
			private AggregateParameter _ParentID_W = null;
			private AggregateParameter _InMenu_W = null;

			public void AggregateClauseReset()
			{
				_PageID_W = null;
				_Title_W = null;
				_Name_W = null;
				_Content_W = null;
				_ParentID_W = null;
				_InMenu_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PageInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.PageID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PageUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PageDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.PageID);
			p.SourceColumn = ColumnNames.PageID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.PageID);
			p.SourceColumn = ColumnNames.PageID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Title);
			p.SourceColumn = ColumnNames.Title;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Name);
			p.SourceColumn = ColumnNames.Name;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Content);
			p.SourceColumn = ColumnNames.Content;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ParentID);
			p.SourceColumn = ColumnNames.ParentID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.InMenu);
			p.SourceColumn = ColumnNames.InMenu;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
