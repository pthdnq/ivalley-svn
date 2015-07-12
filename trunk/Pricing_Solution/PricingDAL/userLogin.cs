
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
	public abstract class _userLogin : SqlClientEntity
	{
		public _userLogin()
		{
			this.QuerySource = "userLogin";
			this.MappingName = "userLogin";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_userLoginLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int AdminID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.AdminID, AdminID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_userLoginLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter AdminID
			{
				get
				{
					return new SqlParameter("@AdminID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter UserName
			{
				get
				{
					return new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Password
			{
				get
				{
					return new SqlParameter("@Password", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Privaledge
			{
				get
				{
					return new SqlParameter("@Privaledge", SqlDbType.NVarChar, 50);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string AdminID = "adminID";
            public const string UserName = "UserName";
            public const string Password = "Password";
            public const string Privaledge = "Privaledge";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AdminID] = _userLogin.PropertyNames.AdminID;
					ht[UserName] = _userLogin.PropertyNames.UserName;
					ht[Password] = _userLogin.PropertyNames.Password;
					ht[Privaledge] = _userLogin.PropertyNames.Privaledge;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string AdminID = "AdminID";
            public const string UserName = "UserName";
            public const string Password = "Password";
            public const string Privaledge = "Privaledge";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[AdminID] = _userLogin.ColumnNames.AdminID;
					ht[UserName] = _userLogin.ColumnNames.UserName;
					ht[Password] = _userLogin.ColumnNames.Password;
					ht[Privaledge] = _userLogin.ColumnNames.Privaledge;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string AdminID = "s_AdminID";
            public const string UserName = "s_UserName";
            public const string Password = "s_Password";
            public const string Privaledge = "s_Privaledge";

		}
		#endregion		
		
		#region Properties
	
		public virtual int AdminID
	    {
			get
	        {
				return base.Getint(ColumnNames.AdminID);
			}
			set
	        {
				base.Setint(ColumnNames.AdminID, value);
			}
		}

		public virtual string UserName
	    {
			get
	        {
				return base.Getstring(ColumnNames.UserName);
			}
			set
	        {
				base.Setstring(ColumnNames.UserName, value);
			}
		}

		public virtual string Password
	    {
			get
	        {
				return base.Getstring(ColumnNames.Password);
			}
			set
	        {
				base.Setstring(ColumnNames.Password, value);
			}
		}

		public virtual string Privaledge
	    {
			get
	        {
				return base.Getstring(ColumnNames.Privaledge);
			}
			set
	        {
				base.Setstring(ColumnNames.Privaledge, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_AdminID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AdminID) ? string.Empty : base.GetintAsString(ColumnNames.AdminID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AdminID);
				else
					this.AdminID = base.SetintAsString(ColumnNames.AdminID, value);
			}
		}

		public virtual string s_UserName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UserName) ? string.Empty : base.GetstringAsString(ColumnNames.UserName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UserName);
				else
					this.UserName = base.SetstringAsString(ColumnNames.UserName, value);
			}
		}

		public virtual string s_Password
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Password) ? string.Empty : base.GetstringAsString(ColumnNames.Password);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Password);
				else
					this.Password = base.SetstringAsString(ColumnNames.Password, value);
			}
		}

		public virtual string s_Privaledge
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Privaledge) ? string.Empty : base.GetstringAsString(ColumnNames.Privaledge);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Privaledge);
				else
					this.Privaledge = base.SetstringAsString(ColumnNames.Privaledge, value);
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
				
				
				public WhereParameter AdminID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AdminID, Parameters.AdminID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter UserName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UserName, Parameters.UserName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Password
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Password, Parameters.Password);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Privaledge
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Privaledge, Parameters.Privaledge);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter AdminID
		    {
				get
		        {
					if(_AdminID_W == null)
	        	    {
						_AdminID_W = TearOff.AdminID;
					}
					return _AdminID_W;
				}
			}

			public WhereParameter UserName
		    {
				get
		        {
					if(_UserName_W == null)
	        	    {
						_UserName_W = TearOff.UserName;
					}
					return _UserName_W;
				}
			}

			public WhereParameter Password
		    {
				get
		        {
					if(_Password_W == null)
	        	    {
						_Password_W = TearOff.Password;
					}
					return _Password_W;
				}
			}

			public WhereParameter Privaledge
		    {
				get
		        {
					if(_Privaledge_W == null)
	        	    {
						_Privaledge_W = TearOff.Privaledge;
					}
					return _Privaledge_W;
				}
			}

			private WhereParameter _AdminID_W = null;
			private WhereParameter _UserName_W = null;
			private WhereParameter _Password_W = null;
			private WhereParameter _Privaledge_W = null;

			public void WhereClauseReset()
			{
				_AdminID_W = null;
				_UserName_W = null;
				_Password_W = null;
				_Privaledge_W = null;

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
				
				
				public AggregateParameter AdminID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AdminID, Parameters.AdminID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter UserName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UserName, Parameters.UserName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Password
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Password, Parameters.Password);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Privaledge
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Privaledge, Parameters.Privaledge);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter AdminID
		    {
				get
		        {
					if(_AdminID_W == null)
	        	    {
						_AdminID_W = TearOff.AdminID;
					}
					return _AdminID_W;
				}
			}

			public AggregateParameter UserName
		    {
				get
		        {
					if(_UserName_W == null)
	        	    {
						_UserName_W = TearOff.UserName;
					}
					return _UserName_W;
				}
			}

			public AggregateParameter Password
		    {
				get
		        {
					if(_Password_W == null)
	        	    {
						_Password_W = TearOff.Password;
					}
					return _Password_W;
				}
			}

			public AggregateParameter Privaledge
		    {
				get
		        {
					if(_Privaledge_W == null)
	        	    {
						_Privaledge_W = TearOff.Privaledge;
					}
					return _Privaledge_W;
				}
			}

			private AggregateParameter _AdminID_W = null;
			private AggregateParameter _UserName_W = null;
			private AggregateParameter _Password_W = null;
			private AggregateParameter _Privaledge_W = null;

			public void AggregateClauseReset()
			{
				_AdminID_W = null;
				_UserName_W = null;
				_Password_W = null;
				_Privaledge_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_userLoginInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.AdminID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_userLoginUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_userLoginDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.AdminID);
			p.SourceColumn = ColumnNames.AdminID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.AdminID);
			p.SourceColumn = ColumnNames.AdminID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UserName);
			p.SourceColumn = ColumnNames.UserName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Password);
			p.SourceColumn = ColumnNames.Password;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Privaledge);
			p.SourceColumn = ColumnNames.Privaledge;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
