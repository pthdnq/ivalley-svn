
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
	public abstract class _CardLayouts : SqlClientEntity
	{
		public _CardLayouts()
		{
			this.QuerySource = "CardLayouts";
			this.MappingName = "CardLayouts";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CardLayoutsLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int CardLayoutID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.CardLayoutID, CardLayoutID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CardLayoutsLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter CardLayoutID
			{
				get
				{
					return new SqlParameter("@CardLayoutID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CardID
			{
				get
				{
					return new SqlParameter("@CardID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter LayoutImage
			{
				get
				{
					return new SqlParameter("@LayoutImage", SqlDbType.NVarChar, 250);
				}
			}
			
			public static SqlParameter LayeoutBackImage
			{
				get
				{
					return new SqlParameter("@LayeoutBackImage", SqlDbType.NVarChar, 250);
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
            public const string CardLayoutID = "CardLayoutID";
            public const string CardID = "CardID";
            public const string LayoutImage = "LayoutImage";
            public const string LayeoutBackImage = "LayeoutBackImage";
            public const string ColorID = "ColorID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CardLayoutID] = _CardLayouts.PropertyNames.CardLayoutID;
					ht[CardID] = _CardLayouts.PropertyNames.CardID;
					ht[LayoutImage] = _CardLayouts.PropertyNames.LayoutImage;
					ht[LayeoutBackImage] = _CardLayouts.PropertyNames.LayeoutBackImage;
					ht[ColorID] = _CardLayouts.PropertyNames.ColorID;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string CardLayoutID = "CardLayoutID";
            public const string CardID = "CardID";
            public const string LayoutImage = "LayoutImage";
            public const string LayeoutBackImage = "LayeoutBackImage";
            public const string ColorID = "ColorID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CardLayoutID] = _CardLayouts.ColumnNames.CardLayoutID;
					ht[CardID] = _CardLayouts.ColumnNames.CardID;
					ht[LayoutImage] = _CardLayouts.ColumnNames.LayoutImage;
					ht[LayeoutBackImage] = _CardLayouts.ColumnNames.LayeoutBackImage;
					ht[ColorID] = _CardLayouts.ColumnNames.ColorID;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string CardLayoutID = "s_CardLayoutID";
            public const string CardID = "s_CardID";
            public const string LayoutImage = "s_LayoutImage";
            public const string LayeoutBackImage = "s_LayeoutBackImage";
            public const string ColorID = "s_ColorID";

		}
		#endregion		
		
		#region Properties
	
		public virtual int CardLayoutID
	    {
			get
	        {
				return base.Getint(ColumnNames.CardLayoutID);
			}
			set
	        {
				base.Setint(ColumnNames.CardLayoutID, value);
			}
		}

		public virtual int CardID
	    {
			get
	        {
				return base.Getint(ColumnNames.CardID);
			}
			set
	        {
				base.Setint(ColumnNames.CardID, value);
			}
		}

		public virtual string LayoutImage
	    {
			get
	        {
				return base.Getstring(ColumnNames.LayoutImage);
			}
			set
	        {
				base.Setstring(ColumnNames.LayoutImage, value);
			}
		}

		public virtual string LayeoutBackImage
	    {
			get
	        {
				return base.Getstring(ColumnNames.LayeoutBackImage);
			}
			set
	        {
				base.Setstring(ColumnNames.LayeoutBackImage, value);
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
	
		public virtual string s_CardLayoutID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CardLayoutID) ? string.Empty : base.GetintAsString(ColumnNames.CardLayoutID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CardLayoutID);
				else
					this.CardLayoutID = base.SetintAsString(ColumnNames.CardLayoutID, value);
			}
		}

		public virtual string s_CardID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CardID) ? string.Empty : base.GetintAsString(ColumnNames.CardID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CardID);
				else
					this.CardID = base.SetintAsString(ColumnNames.CardID, value);
			}
		}

		public virtual string s_LayoutImage
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LayoutImage) ? string.Empty : base.GetstringAsString(ColumnNames.LayoutImage);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LayoutImage);
				else
					this.LayoutImage = base.SetstringAsString(ColumnNames.LayoutImage, value);
			}
		}

		public virtual string s_LayeoutBackImage
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.LayeoutBackImage) ? string.Empty : base.GetstringAsString(ColumnNames.LayeoutBackImage);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.LayeoutBackImage);
				else
					this.LayeoutBackImage = base.SetstringAsString(ColumnNames.LayeoutBackImage, value);
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
				
				
				public WhereParameter CardLayoutID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CardLayoutID, Parameters.CardLayoutID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CardID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CardID, Parameters.CardID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter LayoutImage
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LayoutImage, Parameters.LayoutImage);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter LayeoutBackImage
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.LayeoutBackImage, Parameters.LayeoutBackImage);
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
		
			public WhereParameter CardLayoutID
		    {
				get
		        {
					if(_CardLayoutID_W == null)
	        	    {
						_CardLayoutID_W = TearOff.CardLayoutID;
					}
					return _CardLayoutID_W;
				}
			}

			public WhereParameter CardID
		    {
				get
		        {
					if(_CardID_W == null)
	        	    {
						_CardID_W = TearOff.CardID;
					}
					return _CardID_W;
				}
			}

			public WhereParameter LayoutImage
		    {
				get
		        {
					if(_LayoutImage_W == null)
	        	    {
						_LayoutImage_W = TearOff.LayoutImage;
					}
					return _LayoutImage_W;
				}
			}

			public WhereParameter LayeoutBackImage
		    {
				get
		        {
					if(_LayeoutBackImage_W == null)
	        	    {
						_LayeoutBackImage_W = TearOff.LayeoutBackImage;
					}
					return _LayeoutBackImage_W;
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

			private WhereParameter _CardLayoutID_W = null;
			private WhereParameter _CardID_W = null;
			private WhereParameter _LayoutImage_W = null;
			private WhereParameter _LayeoutBackImage_W = null;
			private WhereParameter _ColorID_W = null;

			public void WhereClauseReset()
			{
				_CardLayoutID_W = null;
				_CardID_W = null;
				_LayoutImage_W = null;
				_LayeoutBackImage_W = null;
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
				
				
				public AggregateParameter CardLayoutID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CardLayoutID, Parameters.CardLayoutID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CardID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CardID, Parameters.CardID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter LayoutImage
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LayoutImage, Parameters.LayoutImage);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter LayeoutBackImage
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.LayeoutBackImage, Parameters.LayeoutBackImage);
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
		
			public AggregateParameter CardLayoutID
		    {
				get
		        {
					if(_CardLayoutID_W == null)
	        	    {
						_CardLayoutID_W = TearOff.CardLayoutID;
					}
					return _CardLayoutID_W;
				}
			}

			public AggregateParameter CardID
		    {
				get
		        {
					if(_CardID_W == null)
	        	    {
						_CardID_W = TearOff.CardID;
					}
					return _CardID_W;
				}
			}

			public AggregateParameter LayoutImage
		    {
				get
		        {
					if(_LayoutImage_W == null)
	        	    {
						_LayoutImage_W = TearOff.LayoutImage;
					}
					return _LayoutImage_W;
				}
			}

			public AggregateParameter LayeoutBackImage
		    {
				get
		        {
					if(_LayeoutBackImage_W == null)
	        	    {
						_LayeoutBackImage_W = TearOff.LayeoutBackImage;
					}
					return _LayeoutBackImage_W;
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

			private AggregateParameter _CardLayoutID_W = null;
			private AggregateParameter _CardID_W = null;
			private AggregateParameter _LayoutImage_W = null;
			private AggregateParameter _LayeoutBackImage_W = null;
			private AggregateParameter _ColorID_W = null;

			public void AggregateClauseReset()
			{
				_CardLayoutID_W = null;
				_CardID_W = null;
				_LayoutImage_W = null;
				_LayeoutBackImage_W = null;
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CardLayoutsInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.CardLayoutID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CardLayoutsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CardLayoutsDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.CardLayoutID);
			p.SourceColumn = ColumnNames.CardLayoutID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.CardLayoutID);
			p.SourceColumn = ColumnNames.CardLayoutID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CardID);
			p.SourceColumn = ColumnNames.CardID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LayoutImage);
			p.SourceColumn = ColumnNames.LayoutImage;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.LayeoutBackImage);
			p.SourceColumn = ColumnNames.LayeoutBackImage;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ColorID);
			p.SourceColumn = ColumnNames.ColorID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}