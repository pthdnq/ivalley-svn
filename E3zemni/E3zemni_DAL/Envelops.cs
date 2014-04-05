
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

namespace E3zmni.DAL
{
	public abstract class _Envelops : SqlClientEntity
	{
		public _Envelops()
		{
			this.QuerySource = "Envelops";
			this.MappingName = "Envelops";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_EnvelopsLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int EnvelopID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.EnvelopID, EnvelopID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_EnvelopsLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter EnvelopID
			{
				get
				{
					return new SqlParameter("@EnvelopID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ImagePath
			{
				get
				{
					return new SqlParameter("@ImagePath", SqlDbType.NVarChar, 150);
				}
			}
			
			public static SqlParameter Price
			{
				get
				{
					return new SqlParameter("@Price", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter UploadDate
			{
				get
				{
					return new SqlParameter("@UploadDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter DimensionID
			{
				get
				{
					return new SqlParameter("@DimensionID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ColorID
			{
				get
				{
					return new SqlParameter("@ColorID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string EnvelopID = "EnvelopID";
            public const string ImagePath = "ImagePath";
            public const string Price = "Price";
            public const string UploadDate = "UploadDate";
            public const string DimensionID = "DimensionID";
            public const string ColorID = "ColorID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[EnvelopID] = _Envelops.PropertyNames.EnvelopID;
					ht[ImagePath] = _Envelops.PropertyNames.ImagePath;
					ht[Price] = _Envelops.PropertyNames.Price;
					ht[UploadDate] = _Envelops.PropertyNames.UploadDate;
					ht[DimensionID] = _Envelops.PropertyNames.DimensionID;
					ht[ColorID] = _Envelops.PropertyNames.ColorID;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string EnvelopID = "EnvelopID";
            public const string ImagePath = "ImagePath";
            public const string Price = "Price";
            public const string UploadDate = "UploadDate";
            public const string DimensionID = "DimensionID";
            public const string ColorID = "ColorID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[EnvelopID] = _Envelops.ColumnNames.EnvelopID;
					ht[ImagePath] = _Envelops.ColumnNames.ImagePath;
					ht[Price] = _Envelops.ColumnNames.Price;
					ht[UploadDate] = _Envelops.ColumnNames.UploadDate;
					ht[DimensionID] = _Envelops.ColumnNames.DimensionID;
					ht[ColorID] = _Envelops.ColumnNames.ColorID;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string EnvelopID = "s_EnvelopID";
            public const string ImagePath = "s_ImagePath";
            public const string Price = "s_Price";
            public const string UploadDate = "s_UploadDate";
            public const string DimensionID = "s_DimensionID";
            public const string ColorID = "s_ColorID";

		}
		#endregion		
		
		#region Properties
	
		public virtual int EnvelopID
	    {
			get
	        {
				return base.Getint(ColumnNames.EnvelopID);
			}
			set
	        {
				base.Setint(ColumnNames.EnvelopID, value);
			}
		}

		public virtual string ImagePath
	    {
			get
	        {
				return base.Getstring(ColumnNames.ImagePath);
			}
			set
	        {
				base.Setstring(ColumnNames.ImagePath, value);
			}
		}

		public virtual double Price
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Price);
			}
			set
	        {
				base.Setdouble(ColumnNames.Price, value);
			}
		}

		public virtual DateTime UploadDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.UploadDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.UploadDate, value);
			}
		}

		public virtual int DimensionID
	    {
			get
	        {
				return base.Getint(ColumnNames.DimensionID);
			}
			set
	        {
				base.Setint(ColumnNames.DimensionID, value);
			}
		}

		public virtual int ColorID
	    {
			get
	        {
				return base.Getint(ColumnNames.ColorID);
			}
			set
	        {
				base.Setint(ColumnNames.ColorID, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_EnvelopID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.EnvelopID) ? string.Empty : base.GetintAsString(ColumnNames.EnvelopID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.EnvelopID);
				else
					this.EnvelopID = base.SetintAsString(ColumnNames.EnvelopID, value);
			}
		}

		public virtual string s_ImagePath
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ImagePath) ? string.Empty : base.GetstringAsString(ColumnNames.ImagePath);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ImagePath);
				else
					this.ImagePath = base.SetstringAsString(ColumnNames.ImagePath, value);
			}
		}

		public virtual string s_Price
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Price) ? string.Empty : base.GetdoubleAsString(ColumnNames.Price);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Price);
				else
					this.Price = base.SetdoubleAsString(ColumnNames.Price, value);
			}
		}

		public virtual string s_UploadDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UploadDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.UploadDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UploadDate);
				else
					this.UploadDate = base.SetDateTimeAsString(ColumnNames.UploadDate, value);
			}
		}

		public virtual string s_DimensionID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.DimensionID) ? string.Empty : base.GetintAsString(ColumnNames.DimensionID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.DimensionID);
				else
					this.DimensionID = base.SetintAsString(ColumnNames.DimensionID, value);
			}
		}

		public virtual string s_ColorID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ColorID) ? string.Empty : base.GetintAsString(ColumnNames.ColorID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ColorID);
				else
					this.ColorID = base.SetintAsString(ColumnNames.ColorID, value);
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
				
				
				public WhereParameter EnvelopID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.EnvelopID, Parameters.EnvelopID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ImagePath
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ImagePath, Parameters.ImagePath);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Price
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Price, Parameters.Price);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter UploadDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UploadDate, Parameters.UploadDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter DimensionID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.DimensionID, Parameters.DimensionID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ColorID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ColorID, Parameters.ColorID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter EnvelopID
		    {
				get
		        {
					if(_EnvelopID_W == null)
	        	    {
						_EnvelopID_W = TearOff.EnvelopID;
					}
					return _EnvelopID_W;
				}
			}

			public WhereParameter ImagePath
		    {
				get
		        {
					if(_ImagePath_W == null)
	        	    {
						_ImagePath_W = TearOff.ImagePath;
					}
					return _ImagePath_W;
				}
			}

			public WhereParameter Price
		    {
				get
		        {
					if(_Price_W == null)
	        	    {
						_Price_W = TearOff.Price;
					}
					return _Price_W;
				}
			}

			public WhereParameter UploadDate
		    {
				get
		        {
					if(_UploadDate_W == null)
	        	    {
						_UploadDate_W = TearOff.UploadDate;
					}
					return _UploadDate_W;
				}
			}

			public WhereParameter DimensionID
		    {
				get
		        {
					if(_DimensionID_W == null)
	        	    {
						_DimensionID_W = TearOff.DimensionID;
					}
					return _DimensionID_W;
				}
			}

			public WhereParameter ColorID
		    {
				get
		        {
					if(_ColorID_W == null)
	        	    {
						_ColorID_W = TearOff.ColorID;
					}
					return _ColorID_W;
				}
			}

			private WhereParameter _EnvelopID_W = null;
			private WhereParameter _ImagePath_W = null;
			private WhereParameter _Price_W = null;
			private WhereParameter _UploadDate_W = null;
			private WhereParameter _DimensionID_W = null;
			private WhereParameter _ColorID_W = null;

			public void WhereClauseReset()
			{
				_EnvelopID_W = null;
				_ImagePath_W = null;
				_Price_W = null;
				_UploadDate_W = null;
				_DimensionID_W = null;
				_ColorID_W = null;

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
				
				
				public AggregateParameter EnvelopID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.EnvelopID, Parameters.EnvelopID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ImagePath
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ImagePath, Parameters.ImagePath);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Price
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Price, Parameters.Price);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter UploadDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UploadDate, Parameters.UploadDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter DimensionID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.DimensionID, Parameters.DimensionID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ColorID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ColorID, Parameters.ColorID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter EnvelopID
		    {
				get
		        {
					if(_EnvelopID_W == null)
	        	    {
						_EnvelopID_W = TearOff.EnvelopID;
					}
					return _EnvelopID_W;
				}
			}

			public AggregateParameter ImagePath
		    {
				get
		        {
					if(_ImagePath_W == null)
	        	    {
						_ImagePath_W = TearOff.ImagePath;
					}
					return _ImagePath_W;
				}
			}

			public AggregateParameter Price
		    {
				get
		        {
					if(_Price_W == null)
	        	    {
						_Price_W = TearOff.Price;
					}
					return _Price_W;
				}
			}

			public AggregateParameter UploadDate
		    {
				get
		        {
					if(_UploadDate_W == null)
	        	    {
						_UploadDate_W = TearOff.UploadDate;
					}
					return _UploadDate_W;
				}
			}

			public AggregateParameter DimensionID
		    {
				get
		        {
					if(_DimensionID_W == null)
	        	    {
						_DimensionID_W = TearOff.DimensionID;
					}
					return _DimensionID_W;
				}
			}

			public AggregateParameter ColorID
		    {
				get
		        {
					if(_ColorID_W == null)
	        	    {
						_ColorID_W = TearOff.ColorID;
					}
					return _ColorID_W;
				}
			}

			private AggregateParameter _EnvelopID_W = null;
			private AggregateParameter _ImagePath_W = null;
			private AggregateParameter _Price_W = null;
			private AggregateParameter _UploadDate_W = null;
			private AggregateParameter _DimensionID_W = null;
			private AggregateParameter _ColorID_W = null;

			public void AggregateClauseReset()
			{
				_EnvelopID_W = null;
				_ImagePath_W = null;
				_Price_W = null;
				_UploadDate_W = null;
				_DimensionID_W = null;
				_ColorID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_EnvelopsInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.EnvelopID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_EnvelopsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_EnvelopsDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.EnvelopID);
			p.SourceColumn = ColumnNames.EnvelopID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.EnvelopID);
			p.SourceColumn = ColumnNames.EnvelopID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ImagePath);
			p.SourceColumn = ColumnNames.ImagePath;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Price);
			p.SourceColumn = ColumnNames.Price;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UploadDate);
			p.SourceColumn = ColumnNames.UploadDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.DimensionID);
			p.SourceColumn = ColumnNames.DimensionID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ColorID);
			p.SourceColumn = ColumnNames.ColorID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}