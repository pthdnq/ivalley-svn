
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
	public abstract class _CardColor : SqlClientEntity
	{
		public _CardColor()
		{
			this.QuerySource = "CardColor";
			this.MappingName = "CardColor";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CardColorLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ColorID, int CardID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ColorID, ColorID);

parameters.Add(Parameters.CardID, CardID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CardColorLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ColorID
			{
				get
				{
					return new SqlParameter("@ColorID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CardID
			{
				get
				{
					return new SqlParameter("@CardID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ColorID = "ColorID";
            public const string CardID = "CardID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ColorID] = _CardColor.PropertyNames.ColorID;
					ht[CardID] = _CardColor.PropertyNames.CardID;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ColorID = "ColorID";
            public const string CardID = "CardID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ColorID] = _CardColor.ColumnNames.ColorID;
					ht[CardID] = _CardColor.ColumnNames.CardID;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ColorID = "s_ColorID";
            public const string CardID = "s_CardID";

		}
		#endregion		
		
		#region Properties
	
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


		#endregion
		
		#region String Properties
	
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
				
				
				public WhereParameter ColorID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ColorID, Parameters.ColorID);
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


				private WhereClause _clause;
			}
			#endregion
		
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

			private WhereParameter _ColorID_W = null;
			private WhereParameter _CardID_W = null;

			public void WhereClauseReset()
			{
				_ColorID_W = null;
				_CardID_W = null;

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
				
				
				public AggregateParameter ColorID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ColorID, Parameters.ColorID);
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


				private AggregateClause _clause;
			}
			#endregion
		
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

			private AggregateParameter _ColorID_W = null;
			private AggregateParameter _CardID_W = null;

			public void AggregateClauseReset()
			{
				_ColorID_W = null;
				_CardID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CardColorInsert]";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CardColorUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CardColorDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ColorID);
			p.SourceColumn = ColumnNames.ColorID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CardID);
			p.SourceColumn = ColumnNames.CardID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ColorID);
			p.SourceColumn = ColumnNames.ColorID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CardID);
			p.SourceColumn = ColumnNames.CardID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
