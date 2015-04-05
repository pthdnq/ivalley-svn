
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
	public abstract class _Career : SqlClientEntity
	{
		public _Career()
		{
			this.QuerySource = "Career";
			this.MappingName = "Career";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CareerLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int CareerID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.CareerID, CareerID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CareerLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter CareerID
			{
				get
				{
					return new SqlParameter("@CareerID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PositionAr
			{
				get
				{
					return new SqlParameter("@PositionAr", SqlDbType.NVarChar, 250);
				}
			}
			
			public static SqlParameter PositionEn
			{
				get
				{
					return new SqlParameter("@PositionEn", SqlDbType.NVarChar, 250);
				}
			}
			
			public static SqlParameter DescriptionAr
			{
				get
				{
					return new SqlParameter("@DescriptionAr", SqlDbType.NVarChar, 500);
				}
			}
			
			public static SqlParameter DescriptionEn
			{
				get
				{
					return new SqlParameter("@DescriptionEn", SqlDbType.NVarChar, 500);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string CareerID = "CareerID";
            public const string PositionAr = "PositionAr";
            public const string PositionEn = "PositionEn";
            public const string DescriptionAr = "DescriptionAr";
            public const string DescriptionEn = "DescriptionEn";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CareerID] = _Career.PropertyNames.CareerID;
					ht[PositionAr] = _Career.PropertyNames.PositionAr;
					ht[PositionEn] = _Career.PropertyNames.PositionEn;
					ht[DescriptionAr] = _Career.PropertyNames.DescriptionAr;
					ht[DescriptionEn] = _Career.PropertyNames.DescriptionEn;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string CareerID = "CareerID";
            public const string PositionAr = "PositionAr";
            public const string PositionEn = "PositionEn";
            public const string DescriptionAr = "DescriptionAr";
            public const string DescriptionEn = "DescriptionEn";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CareerID] = _Career.ColumnNames.CareerID;
					ht[PositionAr] = _Career.ColumnNames.PositionAr;
					ht[PositionEn] = _Career.ColumnNames.PositionEn;
					ht[DescriptionAr] = _Career.ColumnNames.DescriptionAr;
					ht[DescriptionEn] = _Career.ColumnNames.DescriptionEn;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string CareerID = "s_CareerID";
            public const string PositionAr = "s_PositionAr";
            public const string PositionEn = "s_PositionEn";
            public const string DescriptionAr = "s_DescriptionAr";
            public const string DescriptionEn = "s_DescriptionEn";

		}
		#endregion		
		
		#region Properties
	
		public virtual int CareerID
	    {
			get
	        {
				return base.Getint(ColumnNames.CareerID);
			}
			set
	        {
				base.Setint(ColumnNames.CareerID, value);
			}
		}

		public virtual string PositionAr
	    {
			get
	        {
				return base.Getstring(ColumnNames.PositionAr);
			}
			set
	        {
				base.Setstring(ColumnNames.PositionAr, value);
			}
		}

		public virtual string PositionEn
	    {
			get
	        {
				return base.Getstring(ColumnNames.PositionEn);
			}
			set
	        {
				base.Setstring(ColumnNames.PositionEn, value);
			}
		}

		public virtual string DescriptionAr
	    {
			get
	        {
				return base.Getstring(ColumnNames.DescriptionAr);
			}
			set
	        {
				base.Setstring(ColumnNames.DescriptionAr, value);
			}
		}

		public virtual string DescriptionEn
	    {
			get
	        {
				return base.Getstring(ColumnNames.DescriptionEn);
			}
			set
	        {
				base.Setstring(ColumnNames.DescriptionEn, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_CareerID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CareerID) ? string.Empty : base.GetintAsString(ColumnNames.CareerID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CareerID);
				else
					this.CareerID = base.SetintAsString(ColumnNames.CareerID, value);
			}
		}

		public virtual string s_PositionAr
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PositionAr) ? string.Empty : base.GetstringAsString(ColumnNames.PositionAr);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PositionAr);
				else
					this.PositionAr = base.SetstringAsString(ColumnNames.PositionAr, value);
			}
		}

		public virtual string s_PositionEn
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PositionEn) ? string.Empty : base.GetstringAsString(ColumnNames.PositionEn);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PositionEn);
				else
					this.PositionEn = base.SetstringAsString(ColumnNames.PositionEn, value);
			}
		}

		public virtual string s_DescriptionAr
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.DescriptionAr) ? string.Empty : base.GetstringAsString(ColumnNames.DescriptionAr);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.DescriptionAr);
				else
					this.DescriptionAr = base.SetstringAsString(ColumnNames.DescriptionAr, value);
			}
		}

		public virtual string s_DescriptionEn
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.DescriptionEn) ? string.Empty : base.GetstringAsString(ColumnNames.DescriptionEn);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.DescriptionEn);
				else
					this.DescriptionEn = base.SetstringAsString(ColumnNames.DescriptionEn, value);
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
				
				
				public WhereParameter CareerID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CareerID, Parameters.CareerID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PositionAr
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PositionAr, Parameters.PositionAr);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PositionEn
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PositionEn, Parameters.PositionEn);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter DescriptionAr
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.DescriptionAr, Parameters.DescriptionAr);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter DescriptionEn
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.DescriptionEn, Parameters.DescriptionEn);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter CareerID
		    {
				get
		        {
					if(_CareerID_W == null)
	        	    {
						_CareerID_W = TearOff.CareerID;
					}
					return _CareerID_W;
				}
			}

			public WhereParameter PositionAr
		    {
				get
		        {
					if(_PositionAr_W == null)
	        	    {
						_PositionAr_W = TearOff.PositionAr;
					}
					return _PositionAr_W;
				}
			}

			public WhereParameter PositionEn
		    {
				get
		        {
					if(_PositionEn_W == null)
	        	    {
						_PositionEn_W = TearOff.PositionEn;
					}
					return _PositionEn_W;
				}
			}

			public WhereParameter DescriptionAr
		    {
				get
		        {
					if(_DescriptionAr_W == null)
	        	    {
						_DescriptionAr_W = TearOff.DescriptionAr;
					}
					return _DescriptionAr_W;
				}
			}

			public WhereParameter DescriptionEn
		    {
				get
		        {
					if(_DescriptionEn_W == null)
	        	    {
						_DescriptionEn_W = TearOff.DescriptionEn;
					}
					return _DescriptionEn_W;
				}
			}

			private WhereParameter _CareerID_W = null;
			private WhereParameter _PositionAr_W = null;
			private WhereParameter _PositionEn_W = null;
			private WhereParameter _DescriptionAr_W = null;
			private WhereParameter _DescriptionEn_W = null;

			public void WhereClauseReset()
			{
				_CareerID_W = null;
				_PositionAr_W = null;
				_PositionEn_W = null;
				_DescriptionAr_W = null;
				_DescriptionEn_W = null;

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
				
				
				public AggregateParameter CareerID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CareerID, Parameters.CareerID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PositionAr
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PositionAr, Parameters.PositionAr);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PositionEn
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PositionEn, Parameters.PositionEn);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter DescriptionAr
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.DescriptionAr, Parameters.DescriptionAr);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter DescriptionEn
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.DescriptionEn, Parameters.DescriptionEn);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter CareerID
		    {
				get
		        {
					if(_CareerID_W == null)
	        	    {
						_CareerID_W = TearOff.CareerID;
					}
					return _CareerID_W;
				}
			}

			public AggregateParameter PositionAr
		    {
				get
		        {
					if(_PositionAr_W == null)
	        	    {
						_PositionAr_W = TearOff.PositionAr;
					}
					return _PositionAr_W;
				}
			}

			public AggregateParameter PositionEn
		    {
				get
		        {
					if(_PositionEn_W == null)
	        	    {
						_PositionEn_W = TearOff.PositionEn;
					}
					return _PositionEn_W;
				}
			}

			public AggregateParameter DescriptionAr
		    {
				get
		        {
					if(_DescriptionAr_W == null)
	        	    {
						_DescriptionAr_W = TearOff.DescriptionAr;
					}
					return _DescriptionAr_W;
				}
			}

			public AggregateParameter DescriptionEn
		    {
				get
		        {
					if(_DescriptionEn_W == null)
	        	    {
						_DescriptionEn_W = TearOff.DescriptionEn;
					}
					return _DescriptionEn_W;
				}
			}

			private AggregateParameter _CareerID_W = null;
			private AggregateParameter _PositionAr_W = null;
			private AggregateParameter _PositionEn_W = null;
			private AggregateParameter _DescriptionAr_W = null;
			private AggregateParameter _DescriptionEn_W = null;

			public void AggregateClauseReset()
			{
				_CareerID_W = null;
				_PositionAr_W = null;
				_PositionEn_W = null;
				_DescriptionAr_W = null;
				_DescriptionEn_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CareerInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.CareerID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CareerUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CareerDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.CareerID);
			p.SourceColumn = ColumnNames.CareerID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.CareerID);
			p.SourceColumn = ColumnNames.CareerID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PositionAr);
			p.SourceColumn = ColumnNames.PositionAr;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PositionEn);
			p.SourceColumn = ColumnNames.PositionEn;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.DescriptionAr);
			p.SourceColumn = ColumnNames.DescriptionAr;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.DescriptionEn);
			p.SourceColumn = ColumnNames.DescriptionEn;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
