
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

namespace Pricing.DAL
{
	public abstract class _Dosage_form : SqlClientEntity
	{
		public _Dosage_form()
		{
			this.QuerySource = "Dosage_form";
			this.MappingName = "Dosage_form";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_Dosage_formLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int DosageFormID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.DosageFormID, DosageFormID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_Dosage_formLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter DosageFormID
			{
				get
				{
					return new SqlParameter("@DosageFormID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Dosage_form_code
			{
				get
				{
					return new SqlParameter("@Dosage_form_code", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter Dosage_form
			{
				get
				{
					return new SqlParameter("@Dosage_form", SqlDbType.NVarChar, 255);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string DosageFormID = "DosageFormID";
            public const string Dosage_form_code = "Dosage_form_code";
            public const string Dosage_form = "Dosage_form";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[DosageFormID] = _Dosage_form.PropertyNames.DosageFormID;
					ht[Dosage_form_code] = _Dosage_form.PropertyNames.Dosage_form_code;
					ht[Dosage_form] = _Dosage_form.PropertyNames.Dosage_form;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string DosageFormID = "DosageFormID";
            public const string Dosage_form_code = "Dosage_form_code";
            public const string Dosage_form = "Dosage_form";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[DosageFormID] = _Dosage_form.ColumnNames.DosageFormID;
					ht[Dosage_form_code] = _Dosage_form.ColumnNames.Dosage_form_code;
					ht[Dosage_form] = _Dosage_form.ColumnNames.Dosage_form;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string DosageFormID = "s_DosageFormID";
            public const string Dosage_form_code = "s_Dosage_form_code";
            public const string Dosage_form = "s_Dosage_form";

		}
		#endregion		
		
		#region Properties
	
		public virtual int DosageFormID
	    {
			get
	        {
				return base.Getint(ColumnNames.DosageFormID);
			}
			set
	        {
				base.Setint(ColumnNames.DosageFormID, value);
			}
		}

		public virtual string Dosage_form_code
	    {
			get
	        {
				return base.Getstring(ColumnNames.Dosage_form_code);
			}
			set
	        {
				base.Setstring(ColumnNames.Dosage_form_code, value);
			}
		}

		public virtual string Dosage_form
	    {
			get
	        {
				return base.Getstring(ColumnNames.Dosage_form);
			}
			set
	        {
				base.Setstring(ColumnNames.Dosage_form, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_DosageFormID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.DosageFormID) ? string.Empty : base.GetintAsString(ColumnNames.DosageFormID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.DosageFormID);
				else
					this.DosageFormID = base.SetintAsString(ColumnNames.DosageFormID, value);
			}
		}

		public virtual string s_Dosage_form_code
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Dosage_form_code) ? string.Empty : base.GetstringAsString(ColumnNames.Dosage_form_code);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Dosage_form_code);
				else
					this.Dosage_form_code = base.SetstringAsString(ColumnNames.Dosage_form_code, value);
			}
		}

		public virtual string s_Dosage_form
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Dosage_form) ? string.Empty : base.GetstringAsString(ColumnNames.Dosage_form);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Dosage_form);
				else
					this.Dosage_form = base.SetstringAsString(ColumnNames.Dosage_form, value);
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
				
				
				public WhereParameter DosageFormID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.DosageFormID, Parameters.DosageFormID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Dosage_form_code
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Dosage_form_code, Parameters.Dosage_form_code);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Dosage_form
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Dosage_form, Parameters.Dosage_form);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter DosageFormID
		    {
				get
		        {
					if(_DosageFormID_W == null)
	        	    {
						_DosageFormID_W = TearOff.DosageFormID;
					}
					return _DosageFormID_W;
				}
			}

			public WhereParameter Dosage_form_code
		    {
				get
		        {
					if(_Dosage_form_code_W == null)
	        	    {
						_Dosage_form_code_W = TearOff.Dosage_form_code;
					}
					return _Dosage_form_code_W;
				}
			}

			public WhereParameter Dosage_form
		    {
				get
		        {
					if(_Dosage_form_W == null)
	        	    {
						_Dosage_form_W = TearOff.Dosage_form;
					}
					return _Dosage_form_W;
				}
			}

			private WhereParameter _DosageFormID_W = null;
			private WhereParameter _Dosage_form_code_W = null;
			private WhereParameter _Dosage_form_W = null;

			public void WhereClauseReset()
			{
				_DosageFormID_W = null;
				_Dosage_form_code_W = null;
				_Dosage_form_W = null;

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
				
				
				public AggregateParameter DosageFormID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.DosageFormID, Parameters.DosageFormID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Dosage_form_code
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Dosage_form_code, Parameters.Dosage_form_code);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Dosage_form
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Dosage_form, Parameters.Dosage_form);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter DosageFormID
		    {
				get
		        {
					if(_DosageFormID_W == null)
	        	    {
						_DosageFormID_W = TearOff.DosageFormID;
					}
					return _DosageFormID_W;
				}
			}

			public AggregateParameter Dosage_form_code
		    {
				get
		        {
					if(_Dosage_form_code_W == null)
	        	    {
						_Dosage_form_code_W = TearOff.Dosage_form_code;
					}
					return _Dosage_form_code_W;
				}
			}

			public AggregateParameter Dosage_form
		    {
				get
		        {
					if(_Dosage_form_W == null)
	        	    {
						_Dosage_form_W = TearOff.Dosage_form;
					}
					return _Dosage_form_W;
				}
			}

			private AggregateParameter _DosageFormID_W = null;
			private AggregateParameter _Dosage_form_code_W = null;
			private AggregateParameter _Dosage_form_W = null;

			public void AggregateClauseReset()
			{
				_DosageFormID_W = null;
				_Dosage_form_code_W = null;
				_Dosage_form_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_Dosage_formInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.DosageFormID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_Dosage_formUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_Dosage_formDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.DosageFormID);
			p.SourceColumn = ColumnNames.DosageFormID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.DosageFormID);
			p.SourceColumn = ColumnNames.DosageFormID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Dosage_form_code);
			p.SourceColumn = ColumnNames.Dosage_form_code;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Dosage_form);
			p.SourceColumn = ColumnNames.Dosage_form;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
