
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
	public abstract class _CommentHashTag : SqlClientEntity
	{
		public _CommentHashTag()
		{
			this.QuerySource = "CommentHashTag";
			this.MappingName = "CommentHashTag";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CommentHashTagLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int HashTagID, int ComboCommentID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.HashTagID, HashTagID);

parameters.Add(Parameters.ComboCommentID, ComboCommentID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CommentHashTagLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter HashTagID
			{
				get
				{
					return new SqlParameter("@HashTagID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ComboCommentID
			{
				get
				{
					return new SqlParameter("@ComboCommentID", SqlDbType.Int, 0);
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
            public const string HashTagID = "HashTagID";
            public const string ComboCommentID = "ComboCommentID";
            public const string Offset = "Offset";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[HashTagID] = _CommentHashTag.PropertyNames.HashTagID;
					ht[ComboCommentID] = _CommentHashTag.PropertyNames.ComboCommentID;
					ht[Offset] = _CommentHashTag.PropertyNames.Offset;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string HashTagID = "HashTagID";
            public const string ComboCommentID = "ComboCommentID";
            public const string Offset = "Offset";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[HashTagID] = _CommentHashTag.ColumnNames.HashTagID;
					ht[ComboCommentID] = _CommentHashTag.ColumnNames.ComboCommentID;
					ht[Offset] = _CommentHashTag.ColumnNames.Offset;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string HashTagID = "s_HashTagID";
            public const string ComboCommentID = "s_ComboCommentID";
            public const string Offset = "s_Offset";

		}
		#endregion		
		
		#region Properties
	
		public virtual int HashTagID
	    {
			get
	        {
				return base.Getint(ColumnNames.HashTagID);
			}
			set
	        {
				base.Setint(ColumnNames.HashTagID, value);
			}
		}

		public virtual int ComboCommentID
	    {
			get
	        {
				return base.Getint(ColumnNames.ComboCommentID);
			}
			set
	        {
				base.Setint(ColumnNames.ComboCommentID, value);
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
	
		public virtual string s_HashTagID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.HashTagID) ? string.Empty : base.GetintAsString(ColumnNames.HashTagID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.HashTagID);
				else
					this.HashTagID = base.SetintAsString(ColumnNames.HashTagID, value);
			}
		}

		public virtual string s_ComboCommentID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ComboCommentID) ? string.Empty : base.GetintAsString(ColumnNames.ComboCommentID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ComboCommentID);
				else
					this.ComboCommentID = base.SetintAsString(ColumnNames.ComboCommentID, value);
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
				
				
				public WhereParameter HashTagID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.HashTagID, Parameters.HashTagID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ComboCommentID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ComboCommentID, Parameters.ComboCommentID);
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
		
			public WhereParameter HashTagID
		    {
				get
		        {
					if(_HashTagID_W == null)
	        	    {
						_HashTagID_W = TearOff.HashTagID;
					}
					return _HashTagID_W;
				}
			}

			public WhereParameter ComboCommentID
		    {
				get
		        {
					if(_ComboCommentID_W == null)
	        	    {
						_ComboCommentID_W = TearOff.ComboCommentID;
					}
					return _ComboCommentID_W;
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

			private WhereParameter _HashTagID_W = null;
			private WhereParameter _ComboCommentID_W = null;
			private WhereParameter _Offset_W = null;

			public void WhereClauseReset()
			{
				_HashTagID_W = null;
				_ComboCommentID_W = null;
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
				
				
				public AggregateParameter HashTagID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.HashTagID, Parameters.HashTagID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ComboCommentID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ComboCommentID, Parameters.ComboCommentID);
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
		
			public AggregateParameter HashTagID
		    {
				get
		        {
					if(_HashTagID_W == null)
	        	    {
						_HashTagID_W = TearOff.HashTagID;
					}
					return _HashTagID_W;
				}
			}

			public AggregateParameter ComboCommentID
		    {
				get
		        {
					if(_ComboCommentID_W == null)
	        	    {
						_ComboCommentID_W = TearOff.ComboCommentID;
					}
					return _ComboCommentID_W;
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

			private AggregateParameter _HashTagID_W = null;
			private AggregateParameter _ComboCommentID_W = null;
			private AggregateParameter _Offset_W = null;

			public void AggregateClauseReset()
			{
				_HashTagID_W = null;
				_ComboCommentID_W = null;
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CommentHashTagInsert]";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CommentHashTagUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CommentHashTagDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.HashTagID);
			p.SourceColumn = ColumnNames.HashTagID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ComboCommentID);
			p.SourceColumn = ColumnNames.ComboCommentID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.HashTagID);
			p.SourceColumn = ColumnNames.HashTagID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ComboCommentID);
			p.SourceColumn = ColumnNames.ComboCommentID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Offset);
			p.SourceColumn = ColumnNames.Offset;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
