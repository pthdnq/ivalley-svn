
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

// Generated by MyGeneration Version # (1.2.0.7)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace MHO.DAL
{
	public abstract class _health_admins : SqlClientEntity
	{
		public _health_admins()
		{
			this.QuerySource = "health_admins";
			this.MappingName = "health_admins";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_health_adminsLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int Adcode)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.Adcode, Adcode);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_health_adminsLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter Adcode
			{
				get
				{
					return new SqlParameter("@Adcode", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Addescr
			{
				get
				{
					return new SqlParameter("@Addescr", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Govcd
			{
				get
				{
					return new SqlParameter("@Govcd", SqlDbType.SmallInt, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string Adcode = "adcode";
            public const string Addescr = "addescr";
            public const string Govcd = "govcd";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Adcode] = _health_admins.PropertyNames.Adcode;
					ht[Addescr] = _health_admins.PropertyNames.Addescr;
					ht[Govcd] = _health_admins.PropertyNames.Govcd;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string Adcode = "Adcode";
            public const string Addescr = "Addescr";
            public const string Govcd = "Govcd";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[Adcode] = _health_admins.ColumnNames.Adcode;
					ht[Addescr] = _health_admins.ColumnNames.Addescr;
					ht[Govcd] = _health_admins.ColumnNames.Govcd;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string Adcode = "s_Adcode";
            public const string Addescr = "s_Addescr";
            public const string Govcd = "s_Govcd";

		}
		#endregion		
		
		#region Properties
	
		public virtual int Adcode
	    {
			get
	        {
				return base.Getint(ColumnNames.Adcode);
			}
			set
	        {
				base.Setint(ColumnNames.Adcode, value);
			}
		}

		public virtual string Addescr
	    {
			get
	        {
				return base.Getstring(ColumnNames.Addescr);
			}
			set
	        {
				base.Setstring(ColumnNames.Addescr, value);
			}
		}

		public virtual short Govcd
	    {
			get
	        {
				return base.Getshort(ColumnNames.Govcd);
			}
			set
	        {
				base.Setshort(ColumnNames.Govcd, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_Adcode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Adcode) ? string.Empty : base.GetintAsString(ColumnNames.Adcode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Adcode);
				else
					this.Adcode = base.SetintAsString(ColumnNames.Adcode, value);
			}
		}

		public virtual string s_Addescr
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Addescr) ? string.Empty : base.GetstringAsString(ColumnNames.Addescr);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Addescr);
				else
					this.Addescr = base.SetstringAsString(ColumnNames.Addescr, value);
			}
		}

		public virtual string s_Govcd
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Govcd) ? string.Empty : base.GetshortAsString(ColumnNames.Govcd);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Govcd);
				else
					this.Govcd = base.SetshortAsString(ColumnNames.Govcd, value);
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
				
				
				public WhereParameter Adcode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Adcode, Parameters.Adcode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Addescr
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Addescr, Parameters.Addescr);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Govcd
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Govcd, Parameters.Govcd);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter Adcode
		    {
				get
		        {
					if(_Adcode_W == null)
	        	    {
						_Adcode_W = TearOff.Adcode;
					}
					return _Adcode_W;
				}
			}

			public WhereParameter Addescr
		    {
				get
		        {
					if(_Addescr_W == null)
	        	    {
						_Addescr_W = TearOff.Addescr;
					}
					return _Addescr_W;
				}
			}

			public WhereParameter Govcd
		    {
				get
		        {
					if(_Govcd_W == null)
	        	    {
						_Govcd_W = TearOff.Govcd;
					}
					return _Govcd_W;
				}
			}

			private WhereParameter _Adcode_W = null;
			private WhereParameter _Addescr_W = null;
			private WhereParameter _Govcd_W = null;

			public void WhereClauseReset()
			{
				_Adcode_W = null;
				_Addescr_W = null;
				_Govcd_W = null;

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
				
				
				public AggregateParameter Adcode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Adcode, Parameters.Adcode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Addescr
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Addescr, Parameters.Addescr);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Govcd
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Govcd, Parameters.Govcd);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter Adcode
		    {
				get
		        {
					if(_Adcode_W == null)
	        	    {
						_Adcode_W = TearOff.Adcode;
					}
					return _Adcode_W;
				}
			}

			public AggregateParameter Addescr
		    {
				get
		        {
					if(_Addescr_W == null)
	        	    {
						_Addescr_W = TearOff.Addescr;
					}
					return _Addescr_W;
				}
			}

			public AggregateParameter Govcd
		    {
				get
		        {
					if(_Govcd_W == null)
	        	    {
						_Govcd_W = TearOff.Govcd;
					}
					return _Govcd_W;
				}
			}

			private AggregateParameter _Adcode_W = null;
			private AggregateParameter _Addescr_W = null;
			private AggregateParameter _Govcd_W = null;

			public void AggregateClauseReset()
			{
				_Adcode_W = null;
				_Addescr_W = null;
				_Govcd_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_health_adminsInsert]";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_health_adminsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_health_adminsDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.Adcode);
			p.SourceColumn = ColumnNames.Adcode;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.Adcode);
			p.SourceColumn = ColumnNames.Adcode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Addescr);
			p.SourceColumn = ColumnNames.Addescr;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Govcd);
			p.SourceColumn = ColumnNames.Govcd;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
