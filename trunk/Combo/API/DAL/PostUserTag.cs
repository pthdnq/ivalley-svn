
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

namespace Combo.DAL
{
	public abstract class _PostUserTag : SqlClientEntity
	{
		public _PostUserTag()
		{
			this.QuerySource = "PostUserTag";
			this.MappingName = "PostUserTag";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PostUserTagLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int PostUserTagID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.PostUserTagID, PostUserTagID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PostUserTagLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter PostUserTagID
			{
				get
				{
					return new SqlParameter("@PostUserTagID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ComboUserID
			{
				get
				{
					return new SqlParameter("@ComboUserID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ComboPostID
			{
				get
				{
					return new SqlParameter("@ComboPostID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Offset
			{
				get
				{
					return new SqlParameter("@Offset", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string PostUserTagID = "PostUserTagID";
            public const string ComboUserID = "ComboUserID";
            public const string ComboPostID = "ComboPostID";
            public const string Offset = "Offset";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[PostUserTagID] = _PostUserTag.PropertyNames.PostUserTagID;
					ht[ComboUserID] = _PostUserTag.PropertyNames.ComboUserID;
					ht[ComboPostID] = _PostUserTag.PropertyNames.ComboPostID;
					ht[Offset] = _PostUserTag.PropertyNames.Offset;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string PostUserTagID = "PostUserTagID";
            public const string ComboUserID = "ComboUserID";
            public const string ComboPostID = "ComboPostID";
            public const string Offset = "Offset";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[PostUserTagID] = _PostUserTag.ColumnNames.PostUserTagID;
					ht[ComboUserID] = _PostUserTag.ColumnNames.ComboUserID;
					ht[ComboPostID] = _PostUserTag.ColumnNames.ComboPostID;
					ht[Offset] = _PostUserTag.ColumnNames.Offset;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string PostUserTagID = "s_PostUserTagID";
            public const string ComboUserID = "s_ComboUserID";
            public const string ComboPostID = "s_ComboPostID";
            public const string Offset = "s_Offset";

		}
		#endregion		
		
		#region Properties
	
		public virtual int PostUserTagID
	    {
			get
	        {
				return base.Getint(ColumnNames.PostUserTagID);
			}
			set
	        {
				base.Setint(ColumnNames.PostUserTagID, value);
			}
		}

		public virtual int ComboUserID
	    {
			get
	        {
				return base.Getint(ColumnNames.ComboUserID);
			}
			set
	        {
				base.Setint(ColumnNames.ComboUserID, value);
			}
		}

		public virtual int ComboPostID
	    {
			get
	        {
				return base.Getint(ColumnNames.ComboPostID);
			}
			set
	        {
				base.Setint(ColumnNames.ComboPostID, value);
			}
		}

		public virtual int Offset
	    {
			get
	        {
				return base.Getint(ColumnNames.Offset);
			}
			set
	        {
				base.Setint(ColumnNames.Offset, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_PostUserTagID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PostUserTagID) ? string.Empty : base.GetintAsString(ColumnNames.PostUserTagID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PostUserTagID);
				else
					this.PostUserTagID = base.SetintAsString(ColumnNames.PostUserTagID, value);
			}
		}

		public virtual string s_ComboUserID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ComboUserID) ? string.Empty : base.GetintAsString(ColumnNames.ComboUserID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ComboUserID);
				else
					this.ComboUserID = base.SetintAsString(ColumnNames.ComboUserID, value);
			}
		}

		public virtual string s_ComboPostID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ComboPostID) ? string.Empty : base.GetintAsString(ColumnNames.ComboPostID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ComboPostID);
				else
					this.ComboPostID = base.SetintAsString(ColumnNames.ComboPostID, value);
			}
		}

		public virtual string s_Offset
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Offset) ? string.Empty : base.GetintAsString(ColumnNames.Offset);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Offset);
				else
					this.Offset = base.SetintAsString(ColumnNames.Offset, value);
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
				
				
				public WhereParameter PostUserTagID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PostUserTagID, Parameters.PostUserTagID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ComboUserID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ComboUserID, Parameters.ComboUserID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ComboPostID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ComboPostID, Parameters.ComboPostID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Offset
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Offset, Parameters.Offset);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter PostUserTagID
		    {
				get
		        {
					if(_PostUserTagID_W == null)
	        	    {
						_PostUserTagID_W = TearOff.PostUserTagID;
					}
					return _PostUserTagID_W;
				}
			}

			public WhereParameter ComboUserID
		    {
				get
		        {
					if(_ComboUserID_W == null)
	        	    {
						_ComboUserID_W = TearOff.ComboUserID;
					}
					return _ComboUserID_W;
				}
			}

			public WhereParameter ComboPostID
		    {
				get
		        {
					if(_ComboPostID_W == null)
	        	    {
						_ComboPostID_W = TearOff.ComboPostID;
					}
					return _ComboPostID_W;
				}
			}

			public WhereParameter Offset
		    {
				get
		        {
					if(_Offset_W == null)
	        	    {
						_Offset_W = TearOff.Offset;
					}
					return _Offset_W;
				}
			}

			private WhereParameter _PostUserTagID_W = null;
			private WhereParameter _ComboUserID_W = null;
			private WhereParameter _ComboPostID_W = null;
			private WhereParameter _Offset_W = null;

			public void WhereClauseReset()
			{
				_PostUserTagID_W = null;
				_ComboUserID_W = null;
				_ComboPostID_W = null;
				_Offset_W = null;

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
				
				
				public AggregateParameter PostUserTagID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PostUserTagID, Parameters.PostUserTagID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ComboUserID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ComboUserID, Parameters.ComboUserID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ComboPostID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ComboPostID, Parameters.ComboPostID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Offset
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Offset, Parameters.Offset);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter PostUserTagID
		    {
				get
		        {
					if(_PostUserTagID_W == null)
	        	    {
						_PostUserTagID_W = TearOff.PostUserTagID;
					}
					return _PostUserTagID_W;
				}
			}

			public AggregateParameter ComboUserID
		    {
				get
		        {
					if(_ComboUserID_W == null)
	        	    {
						_ComboUserID_W = TearOff.ComboUserID;
					}
					return _ComboUserID_W;
				}
			}

			public AggregateParameter ComboPostID
		    {
				get
		        {
					if(_ComboPostID_W == null)
	        	    {
						_ComboPostID_W = TearOff.ComboPostID;
					}
					return _ComboPostID_W;
				}
			}

			public AggregateParameter Offset
		    {
				get
		        {
					if(_Offset_W == null)
	        	    {
						_Offset_W = TearOff.Offset;
					}
					return _Offset_W;
				}
			}

			private AggregateParameter _PostUserTagID_W = null;
			private AggregateParameter _ComboUserID_W = null;
			private AggregateParameter _ComboPostID_W = null;
			private AggregateParameter _Offset_W = null;

			public void AggregateClauseReset()
			{
				_PostUserTagID_W = null;
				_ComboUserID_W = null;
				_ComboPostID_W = null;
				_Offset_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PostUserTagInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.PostUserTagID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PostUserTagUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PostUserTagDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.PostUserTagID);
			p.SourceColumn = ColumnNames.PostUserTagID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.PostUserTagID);
			p.SourceColumn = ColumnNames.PostUserTagID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ComboUserID);
			p.SourceColumn = ColumnNames.ComboUserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ComboPostID);
			p.SourceColumn = ColumnNames.ComboPostID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Offset);
			p.SourceColumn = ColumnNames.Offset;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
