
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
	public abstract class _Chemises : SqlClientEntity
	{
		public _Chemises()
		{
			this.QuerySource = "Chemises";
			this.MappingName = "Chemises";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ChemisesLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey()
		{
			ListDictionary parameters = new ListDictionary();
					
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ChemisesLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ChemisesID
			{
				get
				{
					return new SqlParameter("@ChemisesID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ChemisesID = "ChemisesID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ChemisesID] = _Chemises.PropertyNames.ChemisesID;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ChemisesID = "ChemisesID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ChemisesID] = _Chemises.ColumnNames.ChemisesID;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ChemisesID = "s_ChemisesID";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ChemisesID
	    {
			get
	        {
				return base.Getint(ColumnNames.ChemisesID);
			}
			set
	        {
				base.Setint(ColumnNames.ChemisesID, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ChemisesID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ChemisesID) ? string.Empty : base.GetintAsString(ColumnNames.ChemisesID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ChemisesID);
				else
					this.ChemisesID = base.SetintAsString(ColumnNames.ChemisesID, value);
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
				
				
				public WhereParameter ChemisesID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ChemisesID, Parameters.ChemisesID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ChemisesID
		    {
				get
		        {
					if(_ChemisesID_W == null)
	        	    {
						_ChemisesID_W = TearOff.ChemisesID;
					}
					return _ChemisesID_W;
				}
			}

			private WhereParameter _ChemisesID_W = null;

			public void WhereClauseReset()
			{
				_ChemisesID_W = null;

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
				
				
				public AggregateParameter ChemisesID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ChemisesID, Parameters.ChemisesID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ChemisesID
		    {
				get
		        {
					if(_ChemisesID_W == null)
	        	    {
						_ChemisesID_W = TearOff.ChemisesID;
					}
					return _ChemisesID_W;
				}
			}

			private AggregateParameter _ChemisesID_W = null;

			public void AggregateClauseReset()
			{
				_ChemisesID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ChemisesInsert]";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ChemisesUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ChemisesDelete]";
	
			SqlParameter p;
  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ChemisesID);
			p.SourceColumn = ColumnNames.ChemisesID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
