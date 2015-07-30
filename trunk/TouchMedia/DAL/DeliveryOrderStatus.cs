
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
	public abstract class _DeliveryOrderStatus : SqlClientEntity
	{
		public _DeliveryOrderStatus()
		{
			this.QuerySource = "DeliveryOrderStatus";
			this.MappingName = "DeliveryOrderStatus";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_DeliveryOrderStatusLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int DeliveryOrderStatusID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.DeliveryOrderStatusID, DeliveryOrderStatusID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_DeliveryOrderStatusLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter DeliveryOrderStatusID
			{
				get
				{
					return new SqlParameter("@DeliveryOrderStatusID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter DeliveryOrderStatusName
			{
				get
				{
					return new SqlParameter("@DeliveryOrderStatusName", SqlDbType.NVarChar, 300);
				}
			}
			
			public static SqlParameter DeliveryOrderStatusNameAr
			{
				get
				{
					return new SqlParameter("@DeliveryOrderStatusNameAr", SqlDbType.NVarChar, 300);
				}
			}
			
			public static SqlParameter StatusClass
			{
				get
				{
					return new SqlParameter("@StatusClass", SqlDbType.NVarChar, 100);
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
            public const string DeliveryOrderStatusID = "DeliveryOrderStatusID";
            public const string DeliveryOrderStatusName = "DeliveryOrderStatusName";
            public const string DeliveryOrderStatusNameAr = "DeliveryOrderStatusNameAr";
            public const string StatusClass = "StatusClass";
            public const string IsDeleted = "isDeleted";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[DeliveryOrderStatusID] = _DeliveryOrderStatus.PropertyNames.DeliveryOrderStatusID;
					ht[DeliveryOrderStatusName] = _DeliveryOrderStatus.PropertyNames.DeliveryOrderStatusName;
					ht[DeliveryOrderStatusNameAr] = _DeliveryOrderStatus.PropertyNames.DeliveryOrderStatusNameAr;
					ht[StatusClass] = _DeliveryOrderStatus.PropertyNames.StatusClass;
					ht[IsDeleted] = _DeliveryOrderStatus.PropertyNames.IsDeleted;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string DeliveryOrderStatusID = "DeliveryOrderStatusID";
            public const string DeliveryOrderStatusName = "DeliveryOrderStatusName";
            public const string DeliveryOrderStatusNameAr = "DeliveryOrderStatusNameAr";
            public const string StatusClass = "StatusClass";
            public const string IsDeleted = "IsDeleted";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[DeliveryOrderStatusID] = _DeliveryOrderStatus.ColumnNames.DeliveryOrderStatusID;
					ht[DeliveryOrderStatusName] = _DeliveryOrderStatus.ColumnNames.DeliveryOrderStatusName;
					ht[DeliveryOrderStatusNameAr] = _DeliveryOrderStatus.ColumnNames.DeliveryOrderStatusNameAr;
					ht[StatusClass] = _DeliveryOrderStatus.ColumnNames.StatusClass;
					ht[IsDeleted] = _DeliveryOrderStatus.ColumnNames.IsDeleted;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string DeliveryOrderStatusID = "s_DeliveryOrderStatusID";
            public const string DeliveryOrderStatusName = "s_DeliveryOrderStatusName";
            public const string DeliveryOrderStatusNameAr = "s_DeliveryOrderStatusNameAr";
            public const string StatusClass = "s_StatusClass";
            public const string IsDeleted = "s_IsDeleted";

		}
		#endregion		
		
		#region Properties
	
		public virtual int DeliveryOrderStatusID
	    {
			get
	        {
				return base.Getint(ColumnNames.DeliveryOrderStatusID);
			}
			set
	        {
				base.Setint(ColumnNames.DeliveryOrderStatusID, value);
			}
		}

		public virtual string DeliveryOrderStatusName
	    {
			get
	        {
				return base.Getstring(ColumnNames.DeliveryOrderStatusName);
			}
			set
	        {
				base.Setstring(ColumnNames.DeliveryOrderStatusName, value);
			}
		}

		public virtual string DeliveryOrderStatusNameAr
	    {
			get
	        {
				return base.Getstring(ColumnNames.DeliveryOrderStatusNameAr);
			}
			set
	        {
				base.Setstring(ColumnNames.DeliveryOrderStatusNameAr, value);
			}
		}

		public virtual string StatusClass
	    {
			get
	        {
				return base.Getstring(ColumnNames.StatusClass);
			}
			set
	        {
				base.Setstring(ColumnNames.StatusClass, value);
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
	
		public virtual string s_DeliveryOrderStatusID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.DeliveryOrderStatusID) ? string.Empty : base.GetintAsString(ColumnNames.DeliveryOrderStatusID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.DeliveryOrderStatusID);
				else
					this.DeliveryOrderStatusID = base.SetintAsString(ColumnNames.DeliveryOrderStatusID, value);
			}
		}

		public virtual string s_DeliveryOrderStatusName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.DeliveryOrderStatusName) ? string.Empty : base.GetstringAsString(ColumnNames.DeliveryOrderStatusName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.DeliveryOrderStatusName);
				else
					this.DeliveryOrderStatusName = base.SetstringAsString(ColumnNames.DeliveryOrderStatusName, value);
			}
		}

		public virtual string s_DeliveryOrderStatusNameAr
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.DeliveryOrderStatusNameAr) ? string.Empty : base.GetstringAsString(ColumnNames.DeliveryOrderStatusNameAr);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.DeliveryOrderStatusNameAr);
				else
					this.DeliveryOrderStatusNameAr = base.SetstringAsString(ColumnNames.DeliveryOrderStatusNameAr, value);
			}
		}

		public virtual string s_StatusClass
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.StatusClass) ? string.Empty : base.GetstringAsString(ColumnNames.StatusClass);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.StatusClass);
				else
					this.StatusClass = base.SetstringAsString(ColumnNames.StatusClass, value);
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
				
				
				public WhereParameter DeliveryOrderStatusID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.DeliveryOrderStatusID, Parameters.DeliveryOrderStatusID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter DeliveryOrderStatusName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.DeliveryOrderStatusName, Parameters.DeliveryOrderStatusName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter DeliveryOrderStatusNameAr
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.DeliveryOrderStatusNameAr, Parameters.DeliveryOrderStatusNameAr);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter StatusClass
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.StatusClass, Parameters.StatusClass);
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
		
			public WhereParameter DeliveryOrderStatusID
		    {
				get
		        {
					if(_DeliveryOrderStatusID_W == null)
	        	    {
						_DeliveryOrderStatusID_W = TearOff.DeliveryOrderStatusID;
					}
					return _DeliveryOrderStatusID_W;
				}
			}

			public WhereParameter DeliveryOrderStatusName
		    {
				get
		        {
					if(_DeliveryOrderStatusName_W == null)
	        	    {
						_DeliveryOrderStatusName_W = TearOff.DeliveryOrderStatusName;
					}
					return _DeliveryOrderStatusName_W;
				}
			}

			public WhereParameter DeliveryOrderStatusNameAr
		    {
				get
		        {
					if(_DeliveryOrderStatusNameAr_W == null)
	        	    {
						_DeliveryOrderStatusNameAr_W = TearOff.DeliveryOrderStatusNameAr;
					}
					return _DeliveryOrderStatusNameAr_W;
				}
			}

			public WhereParameter StatusClass
		    {
				get
		        {
					if(_StatusClass_W == null)
	        	    {
						_StatusClass_W = TearOff.StatusClass;
					}
					return _StatusClass_W;
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

			private WhereParameter _DeliveryOrderStatusID_W = null;
			private WhereParameter _DeliveryOrderStatusName_W = null;
			private WhereParameter _DeliveryOrderStatusNameAr_W = null;
			private WhereParameter _StatusClass_W = null;
			private WhereParameter _IsDeleted_W = null;

			public void WhereClauseReset()
			{
				_DeliveryOrderStatusID_W = null;
				_DeliveryOrderStatusName_W = null;
				_DeliveryOrderStatusNameAr_W = null;
				_StatusClass_W = null;
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
				
				
				public AggregateParameter DeliveryOrderStatusID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.DeliveryOrderStatusID, Parameters.DeliveryOrderStatusID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter DeliveryOrderStatusName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.DeliveryOrderStatusName, Parameters.DeliveryOrderStatusName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter DeliveryOrderStatusNameAr
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.DeliveryOrderStatusNameAr, Parameters.DeliveryOrderStatusNameAr);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter StatusClass
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.StatusClass, Parameters.StatusClass);
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
		
			public AggregateParameter DeliveryOrderStatusID
		    {
				get
		        {
					if(_DeliveryOrderStatusID_W == null)
	        	    {
						_DeliveryOrderStatusID_W = TearOff.DeliveryOrderStatusID;
					}
					return _DeliveryOrderStatusID_W;
				}
			}

			public AggregateParameter DeliveryOrderStatusName
		    {
				get
		        {
					if(_DeliveryOrderStatusName_W == null)
	        	    {
						_DeliveryOrderStatusName_W = TearOff.DeliveryOrderStatusName;
					}
					return _DeliveryOrderStatusName_W;
				}
			}

			public AggregateParameter DeliveryOrderStatusNameAr
		    {
				get
		        {
					if(_DeliveryOrderStatusNameAr_W == null)
	        	    {
						_DeliveryOrderStatusNameAr_W = TearOff.DeliveryOrderStatusNameAr;
					}
					return _DeliveryOrderStatusNameAr_W;
				}
			}

			public AggregateParameter StatusClass
		    {
				get
		        {
					if(_StatusClass_W == null)
	        	    {
						_StatusClass_W = TearOff.StatusClass;
					}
					return _StatusClass_W;
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

			private AggregateParameter _DeliveryOrderStatusID_W = null;
			private AggregateParameter _DeliveryOrderStatusName_W = null;
			private AggregateParameter _DeliveryOrderStatusNameAr_W = null;
			private AggregateParameter _StatusClass_W = null;
			private AggregateParameter _IsDeleted_W = null;

			public void AggregateClauseReset()
			{
				_DeliveryOrderStatusID_W = null;
				_DeliveryOrderStatusName_W = null;
				_DeliveryOrderStatusNameAr_W = null;
				_StatusClass_W = null;
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_DeliveryOrderStatusInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.DeliveryOrderStatusID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_DeliveryOrderStatusUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_DeliveryOrderStatusDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.DeliveryOrderStatusID);
			p.SourceColumn = ColumnNames.DeliveryOrderStatusID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.DeliveryOrderStatusID);
			p.SourceColumn = ColumnNames.DeliveryOrderStatusID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.DeliveryOrderStatusName);
			p.SourceColumn = ColumnNames.DeliveryOrderStatusName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.DeliveryOrderStatusNameAr);
			p.SourceColumn = ColumnNames.DeliveryOrderStatusNameAr;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.StatusClass);
			p.SourceColumn = ColumnNames.StatusClass;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsDeleted);
			p.SourceColumn = ColumnNames.IsDeleted;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
