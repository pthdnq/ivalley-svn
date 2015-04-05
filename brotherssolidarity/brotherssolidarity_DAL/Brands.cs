
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
	public abstract class _Brands : SqlClientEntity
	{
		public _Brands()
		{
			this.QuerySource = "Brands";
			this.MappingName = "Brands";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_BrandsLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int BrandID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.BrandID, BrandID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_BrandsLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter BrandID
			{
				get
				{
					return new SqlParameter("@BrandID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter BrandNameAr
			{
				get
				{
					return new SqlParameter("@BrandNameAr", SqlDbType.NVarChar, 250);
				}
			}
			
			public static SqlParameter BrandNameEn
			{
				get
				{
					return new SqlParameter("@BrandNameEn", SqlDbType.NVarChar, 250);
				}
			}
			
			public static SqlParameter BrandDescAr
			{
				get
				{
					return new SqlParameter("@BrandDescAr", SqlDbType.NVarChar, 500);
				}
			}
			
			public static SqlParameter BrandDescEn
			{
				get
				{
					return new SqlParameter("@BrandDescEn", SqlDbType.NVarChar, 500);
				}
			}
			
			public static SqlParameter BrandImagePath
			{
				get
				{
					return new SqlParameter("@BrandImagePath", SqlDbType.NVarChar, 250);
				}
			}
			
			public static SqlParameter BrandURL
			{
				get
				{
					return new SqlParameter("@BrandURL", SqlDbType.NVarChar, 350);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string BrandID = "BrandID";
            public const string BrandNameAr = "BrandNameAr";
            public const string BrandNameEn = "BrandNameEn";
            public const string BrandDescAr = "BrandDescAr";
            public const string BrandDescEn = "BrandDescEn";
            public const string BrandImagePath = "BrandImagePath";
            public const string BrandURL = "BrandURL";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[BrandID] = _Brands.PropertyNames.BrandID;
					ht[BrandNameAr] = _Brands.PropertyNames.BrandNameAr;
					ht[BrandNameEn] = _Brands.PropertyNames.BrandNameEn;
					ht[BrandDescAr] = _Brands.PropertyNames.BrandDescAr;
					ht[BrandDescEn] = _Brands.PropertyNames.BrandDescEn;
					ht[BrandImagePath] = _Brands.PropertyNames.BrandImagePath;
					ht[BrandURL] = _Brands.PropertyNames.BrandURL;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string BrandID = "BrandID";
            public const string BrandNameAr = "BrandNameAr";
            public const string BrandNameEn = "BrandNameEn";
            public const string BrandDescAr = "BrandDescAr";
            public const string BrandDescEn = "BrandDescEn";
            public const string BrandImagePath = "BrandImagePath";
            public const string BrandURL = "BrandURL";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[BrandID] = _Brands.ColumnNames.BrandID;
					ht[BrandNameAr] = _Brands.ColumnNames.BrandNameAr;
					ht[BrandNameEn] = _Brands.ColumnNames.BrandNameEn;
					ht[BrandDescAr] = _Brands.ColumnNames.BrandDescAr;
					ht[BrandDescEn] = _Brands.ColumnNames.BrandDescEn;
					ht[BrandImagePath] = _Brands.ColumnNames.BrandImagePath;
					ht[BrandURL] = _Brands.ColumnNames.BrandURL;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string BrandID = "s_BrandID";
            public const string BrandNameAr = "s_BrandNameAr";
            public const string BrandNameEn = "s_BrandNameEn";
            public const string BrandDescAr = "s_BrandDescAr";
            public const string BrandDescEn = "s_BrandDescEn";
            public const string BrandImagePath = "s_BrandImagePath";
            public const string BrandURL = "s_BrandURL";

		}
		#endregion		
		
		#region Properties
	
		public virtual int BrandID
	    {
			get
	        {
				return base.Getint(ColumnNames.BrandID);
			}
			set
	        {
				base.Setint(ColumnNames.BrandID, value);
			}
		}

		public virtual string BrandNameAr
	    {
			get
	        {
				return base.Getstring(ColumnNames.BrandNameAr);
			}
			set
	        {
				base.Setstring(ColumnNames.BrandNameAr, value);
			}
		}

		public virtual string BrandNameEn
	    {
			get
	        {
				return base.Getstring(ColumnNames.BrandNameEn);
			}
			set
	        {
				base.Setstring(ColumnNames.BrandNameEn, value);
			}
		}

		public virtual string BrandDescAr
	    {
			get
	        {
				return base.Getstring(ColumnNames.BrandDescAr);
			}
			set
	        {
				base.Setstring(ColumnNames.BrandDescAr, value);
			}
		}

		public virtual string BrandDescEn
	    {
			get
	        {
				return base.Getstring(ColumnNames.BrandDescEn);
			}
			set
	        {
				base.Setstring(ColumnNames.BrandDescEn, value);
			}
		}

		public virtual string BrandImagePath
	    {
			get
	        {
				return base.Getstring(ColumnNames.BrandImagePath);
			}
			set
	        {
				base.Setstring(ColumnNames.BrandImagePath, value);
			}
		}

		public virtual string BrandURL
	    {
			get
	        {
				return base.Getstring(ColumnNames.BrandURL);
			}
			set
	        {
				base.Setstring(ColumnNames.BrandURL, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_BrandID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BrandID) ? string.Empty : base.GetintAsString(ColumnNames.BrandID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BrandID);
				else
					this.BrandID = base.SetintAsString(ColumnNames.BrandID, value);
			}
		}

		public virtual string s_BrandNameAr
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BrandNameAr) ? string.Empty : base.GetstringAsString(ColumnNames.BrandNameAr);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BrandNameAr);
				else
					this.BrandNameAr = base.SetstringAsString(ColumnNames.BrandNameAr, value);
			}
		}

		public virtual string s_BrandNameEn
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BrandNameEn) ? string.Empty : base.GetstringAsString(ColumnNames.BrandNameEn);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BrandNameEn);
				else
					this.BrandNameEn = base.SetstringAsString(ColumnNames.BrandNameEn, value);
			}
		}

		public virtual string s_BrandDescAr
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BrandDescAr) ? string.Empty : base.GetstringAsString(ColumnNames.BrandDescAr);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BrandDescAr);
				else
					this.BrandDescAr = base.SetstringAsString(ColumnNames.BrandDescAr, value);
			}
		}

		public virtual string s_BrandDescEn
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BrandDescEn) ? string.Empty : base.GetstringAsString(ColumnNames.BrandDescEn);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BrandDescEn);
				else
					this.BrandDescEn = base.SetstringAsString(ColumnNames.BrandDescEn, value);
			}
		}

		public virtual string s_BrandImagePath
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BrandImagePath) ? string.Empty : base.GetstringAsString(ColumnNames.BrandImagePath);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BrandImagePath);
				else
					this.BrandImagePath = base.SetstringAsString(ColumnNames.BrandImagePath, value);
			}
		}

		public virtual string s_BrandURL
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BrandURL) ? string.Empty : base.GetstringAsString(ColumnNames.BrandURL);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BrandURL);
				else
					this.BrandURL = base.SetstringAsString(ColumnNames.BrandURL, value);
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
				
				
				public WhereParameter BrandID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BrandID, Parameters.BrandID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BrandNameAr
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BrandNameAr, Parameters.BrandNameAr);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BrandNameEn
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BrandNameEn, Parameters.BrandNameEn);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BrandDescAr
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BrandDescAr, Parameters.BrandDescAr);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BrandDescEn
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BrandDescEn, Parameters.BrandDescEn);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BrandImagePath
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BrandImagePath, Parameters.BrandImagePath);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BrandURL
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BrandURL, Parameters.BrandURL);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter BrandID
		    {
				get
		        {
					if(_BrandID_W == null)
	        	    {
						_BrandID_W = TearOff.BrandID;
					}
					return _BrandID_W;
				}
			}

			public WhereParameter BrandNameAr
		    {
				get
		        {
					if(_BrandNameAr_W == null)
	        	    {
						_BrandNameAr_W = TearOff.BrandNameAr;
					}
					return _BrandNameAr_W;
				}
			}

			public WhereParameter BrandNameEn
		    {
				get
		        {
					if(_BrandNameEn_W == null)
	        	    {
						_BrandNameEn_W = TearOff.BrandNameEn;
					}
					return _BrandNameEn_W;
				}
			}

			public WhereParameter BrandDescAr
		    {
				get
		        {
					if(_BrandDescAr_W == null)
	        	    {
						_BrandDescAr_W = TearOff.BrandDescAr;
					}
					return _BrandDescAr_W;
				}
			}

			public WhereParameter BrandDescEn
		    {
				get
		        {
					if(_BrandDescEn_W == null)
	        	    {
						_BrandDescEn_W = TearOff.BrandDescEn;
					}
					return _BrandDescEn_W;
				}
			}

			public WhereParameter BrandImagePath
		    {
				get
		        {
					if(_BrandImagePath_W == null)
	        	    {
						_BrandImagePath_W = TearOff.BrandImagePath;
					}
					return _BrandImagePath_W;
				}
			}

			public WhereParameter BrandURL
		    {
				get
		        {
					if(_BrandURL_W == null)
	        	    {
						_BrandURL_W = TearOff.BrandURL;
					}
					return _BrandURL_W;
				}
			}

			private WhereParameter _BrandID_W = null;
			private WhereParameter _BrandNameAr_W = null;
			private WhereParameter _BrandNameEn_W = null;
			private WhereParameter _BrandDescAr_W = null;
			private WhereParameter _BrandDescEn_W = null;
			private WhereParameter _BrandImagePath_W = null;
			private WhereParameter _BrandURL_W = null;

			public void WhereClauseReset()
			{
				_BrandID_W = null;
				_BrandNameAr_W = null;
				_BrandNameEn_W = null;
				_BrandDescAr_W = null;
				_BrandDescEn_W = null;
				_BrandImagePath_W = null;
				_BrandURL_W = null;

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
				
				
				public AggregateParameter BrandID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BrandID, Parameters.BrandID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BrandNameAr
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BrandNameAr, Parameters.BrandNameAr);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BrandNameEn
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BrandNameEn, Parameters.BrandNameEn);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BrandDescAr
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BrandDescAr, Parameters.BrandDescAr);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BrandDescEn
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BrandDescEn, Parameters.BrandDescEn);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BrandImagePath
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BrandImagePath, Parameters.BrandImagePath);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BrandURL
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BrandURL, Parameters.BrandURL);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter BrandID
		    {
				get
		        {
					if(_BrandID_W == null)
	        	    {
						_BrandID_W = TearOff.BrandID;
					}
					return _BrandID_W;
				}
			}

			public AggregateParameter BrandNameAr
		    {
				get
		        {
					if(_BrandNameAr_W == null)
	        	    {
						_BrandNameAr_W = TearOff.BrandNameAr;
					}
					return _BrandNameAr_W;
				}
			}

			public AggregateParameter BrandNameEn
		    {
				get
		        {
					if(_BrandNameEn_W == null)
	        	    {
						_BrandNameEn_W = TearOff.BrandNameEn;
					}
					return _BrandNameEn_W;
				}
			}

			public AggregateParameter BrandDescAr
		    {
				get
		        {
					if(_BrandDescAr_W == null)
	        	    {
						_BrandDescAr_W = TearOff.BrandDescAr;
					}
					return _BrandDescAr_W;
				}
			}

			public AggregateParameter BrandDescEn
		    {
				get
		        {
					if(_BrandDescEn_W == null)
	        	    {
						_BrandDescEn_W = TearOff.BrandDescEn;
					}
					return _BrandDescEn_W;
				}
			}

			public AggregateParameter BrandImagePath
		    {
				get
		        {
					if(_BrandImagePath_W == null)
	        	    {
						_BrandImagePath_W = TearOff.BrandImagePath;
					}
					return _BrandImagePath_W;
				}
			}

			public AggregateParameter BrandURL
		    {
				get
		        {
					if(_BrandURL_W == null)
	        	    {
						_BrandURL_W = TearOff.BrandURL;
					}
					return _BrandURL_W;
				}
			}

			private AggregateParameter _BrandID_W = null;
			private AggregateParameter _BrandNameAr_W = null;
			private AggregateParameter _BrandNameEn_W = null;
			private AggregateParameter _BrandDescAr_W = null;
			private AggregateParameter _BrandDescEn_W = null;
			private AggregateParameter _BrandImagePath_W = null;
			private AggregateParameter _BrandURL_W = null;

			public void AggregateClauseReset()
			{
				_BrandID_W = null;
				_BrandNameAr_W = null;
				_BrandNameEn_W = null;
				_BrandDescAr_W = null;
				_BrandDescEn_W = null;
				_BrandImagePath_W = null;
				_BrandURL_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_BrandsInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.BrandID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_BrandsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_BrandsDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.BrandID);
			p.SourceColumn = ColumnNames.BrandID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.BrandID);
			p.SourceColumn = ColumnNames.BrandID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BrandNameAr);
			p.SourceColumn = ColumnNames.BrandNameAr;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BrandNameEn);
			p.SourceColumn = ColumnNames.BrandNameEn;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BrandDescAr);
			p.SourceColumn = ColumnNames.BrandDescAr;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BrandDescEn);
			p.SourceColumn = ColumnNames.BrandDescEn;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BrandImagePath);
			p.SourceColumn = ColumnNames.BrandImagePath;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BrandURL);
			p.SourceColumn = ColumnNames.BrandURL;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
