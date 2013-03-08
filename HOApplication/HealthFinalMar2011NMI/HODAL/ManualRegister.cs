
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
	public abstract class _ManualRegister : SqlClientEntity
	{
		public _ManualRegister()
		{
			this.QuerySource = "ManualRegister";
			this.MappingName = "ManualRegister";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ManualRegisterLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(Guid RegisterID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.RegisterID, RegisterID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ManualRegisterLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter RegisterID
			{
				get
				{
					return new SqlParameter("@RegisterID", SqlDbType.UniqueIdentifier, 0);
				}
			}
			
			public static SqlParameter RegisterCode
			{
				get
				{
					return new SqlParameter("@RegisterCode", SqlDbType.Char, 8);
				}
			}
			
			public static SqlParameter CurrentRegister
			{
				get
				{
					return new SqlParameter("@CurrentRegister", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter OrgID
			{
				get
				{
					return new SqlParameter("@OrgID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CreationDate
			{
				get
				{
					return new SqlParameter("@CreationDate", SqlDbType.SmallDateTime, 0);
				}
			}
			
			public static SqlParameter StartSerial
			{
				get
				{
					return new SqlParameter("@StartSerial", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter RegisterYear
			{
				get
				{
					return new SqlParameter("@RegisterYear", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter RegisterType
			{
				get
				{
					return new SqlParameter("@RegisterType", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string RegisterID = "RegisterID";
            public const string RegisterCode = "RegisterCode";
            public const string CurrentRegister = "CurrentRegister";
            public const string OrgID = "OrgID";
            public const string CreationDate = "CreationDate";
            public const string StartSerial = "StartSerial";
            public const string RegisterYear = "RegisterYear";
            public const string RegisterType = "RegisterType";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RegisterID] = _ManualRegister.PropertyNames.RegisterID;
					ht[RegisterCode] = _ManualRegister.PropertyNames.RegisterCode;
					ht[CurrentRegister] = _ManualRegister.PropertyNames.CurrentRegister;
					ht[OrgID] = _ManualRegister.PropertyNames.OrgID;
					ht[CreationDate] = _ManualRegister.PropertyNames.CreationDate;
					ht[StartSerial] = _ManualRegister.PropertyNames.StartSerial;
					ht[RegisterYear] = _ManualRegister.PropertyNames.RegisterYear;
					ht[RegisterType] = _ManualRegister.PropertyNames.RegisterType;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string RegisterID = "RegisterID";
            public const string RegisterCode = "RegisterCode";
            public const string CurrentRegister = "CurrentRegister";
            public const string OrgID = "OrgID";
            public const string CreationDate = "CreationDate";
            public const string StartSerial = "StartSerial";
            public const string RegisterYear = "RegisterYear";
            public const string RegisterType = "RegisterType";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[RegisterID] = _ManualRegister.ColumnNames.RegisterID;
					ht[RegisterCode] = _ManualRegister.ColumnNames.RegisterCode;
					ht[CurrentRegister] = _ManualRegister.ColumnNames.CurrentRegister;
					ht[OrgID] = _ManualRegister.ColumnNames.OrgID;
					ht[CreationDate] = _ManualRegister.ColumnNames.CreationDate;
					ht[StartSerial] = _ManualRegister.ColumnNames.StartSerial;
					ht[RegisterYear] = _ManualRegister.ColumnNames.RegisterYear;
					ht[RegisterType] = _ManualRegister.ColumnNames.RegisterType;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string RegisterID = "s_RegisterID";
            public const string RegisterCode = "s_RegisterCode";
            public const string CurrentRegister = "s_CurrentRegister";
            public const string OrgID = "s_OrgID";
            public const string CreationDate = "s_CreationDate";
            public const string StartSerial = "s_StartSerial";
            public const string RegisterYear = "s_RegisterYear";
            public const string RegisterType = "s_RegisterType";

		}
		#endregion		
		
		#region Properties
	
		public virtual Guid RegisterID
	    {
			get
	        {
				return base.GetGuid(ColumnNames.RegisterID);
			}
			set
	        {
				base.SetGuid(ColumnNames.RegisterID, value);
			}
		}

		public virtual string RegisterCode
	    {
			get
	        {
				return base.Getstring(ColumnNames.RegisterCode);
			}
			set
	        {
				base.Setstring(ColumnNames.RegisterCode, value);
			}
		}

		public virtual bool CurrentRegister
	    {
			get
	        {
				return base.Getbool(ColumnNames.CurrentRegister);
			}
			set
	        {
				base.Setbool(ColumnNames.CurrentRegister, value);
			}
		}

		public virtual int OrgID
	    {
			get
	        {
				return base.Getint(ColumnNames.OrgID);
			}
			set
	        {
				base.Setint(ColumnNames.OrgID, value);
			}
		}

		public virtual DateTime CreationDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.CreationDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.CreationDate, value);
			}
		}

		public virtual int StartSerial
	    {
			get
	        {
				return base.Getint(ColumnNames.StartSerial);
			}
			set
	        {
				base.Setint(ColumnNames.StartSerial, value);
			}
		}

		public virtual int RegisterYear
	    {
			get
	        {
				return base.Getint(ColumnNames.RegisterYear);
			}
			set
	        {
				base.Setint(ColumnNames.RegisterYear, value);
			}
		}

		public virtual int RegisterType
	    {
			get
	        {
				return base.Getint(ColumnNames.RegisterType);
			}
			set
	        {
				base.Setint(ColumnNames.RegisterType, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_RegisterID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.RegisterID) ? string.Empty : base.GetGuidAsString(ColumnNames.RegisterID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.RegisterID);
				else
					this.RegisterID = base.SetGuidAsString(ColumnNames.RegisterID, value);
			}
		}

		public virtual string s_RegisterCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.RegisterCode) ? string.Empty : base.GetstringAsString(ColumnNames.RegisterCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.RegisterCode);
				else
					this.RegisterCode = base.SetstringAsString(ColumnNames.RegisterCode, value);
			}
		}

		public virtual string s_CurrentRegister
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CurrentRegister) ? string.Empty : base.GetboolAsString(ColumnNames.CurrentRegister);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CurrentRegister);
				else
					this.CurrentRegister = base.SetboolAsString(ColumnNames.CurrentRegister, value);
			}
		}

		public virtual string s_OrgID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OrgID) ? string.Empty : base.GetintAsString(ColumnNames.OrgID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OrgID);
				else
					this.OrgID = base.SetintAsString(ColumnNames.OrgID, value);
			}
		}

		public virtual string s_CreationDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreationDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.CreationDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreationDate);
				else
					this.CreationDate = base.SetDateTimeAsString(ColumnNames.CreationDate, value);
			}
		}

		public virtual string s_StartSerial
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.StartSerial) ? string.Empty : base.GetintAsString(ColumnNames.StartSerial);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.StartSerial);
				else
					this.StartSerial = base.SetintAsString(ColumnNames.StartSerial, value);
			}
		}

		public virtual string s_RegisterYear
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.RegisterYear) ? string.Empty : base.GetintAsString(ColumnNames.RegisterYear);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.RegisterYear);
				else
					this.RegisterYear = base.SetintAsString(ColumnNames.RegisterYear, value);
			}
		}

		public virtual string s_RegisterType
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.RegisterType) ? string.Empty : base.GetintAsString(ColumnNames.RegisterType);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.RegisterType);
				else
					this.RegisterType = base.SetintAsString(ColumnNames.RegisterType, value);
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
				
				
				public WhereParameter RegisterID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.RegisterID, Parameters.RegisterID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter RegisterCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.RegisterCode, Parameters.RegisterCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CurrentRegister
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CurrentRegister, Parameters.CurrentRegister);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter OrgID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OrgID, Parameters.OrgID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CreationDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreationDate, Parameters.CreationDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter StartSerial
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.StartSerial, Parameters.StartSerial);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter RegisterYear
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.RegisterYear, Parameters.RegisterYear);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter RegisterType
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.RegisterType, Parameters.RegisterType);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter RegisterID
		    {
				get
		        {
					if(_RegisterID_W == null)
	        	    {
						_RegisterID_W = TearOff.RegisterID;
					}
					return _RegisterID_W;
				}
			}

			public WhereParameter RegisterCode
		    {
				get
		        {
					if(_RegisterCode_W == null)
	        	    {
						_RegisterCode_W = TearOff.RegisterCode;
					}
					return _RegisterCode_W;
				}
			}

			public WhereParameter CurrentRegister
		    {
				get
		        {
					if(_CurrentRegister_W == null)
	        	    {
						_CurrentRegister_W = TearOff.CurrentRegister;
					}
					return _CurrentRegister_W;
				}
			}

			public WhereParameter OrgID
		    {
				get
		        {
					if(_OrgID_W == null)
	        	    {
						_OrgID_W = TearOff.OrgID;
					}
					return _OrgID_W;
				}
			}

			public WhereParameter CreationDate
		    {
				get
		        {
					if(_CreationDate_W == null)
	        	    {
						_CreationDate_W = TearOff.CreationDate;
					}
					return _CreationDate_W;
				}
			}

			public WhereParameter StartSerial
		    {
				get
		        {
					if(_StartSerial_W == null)
	        	    {
						_StartSerial_W = TearOff.StartSerial;
					}
					return _StartSerial_W;
				}
			}

			public WhereParameter RegisterYear
		    {
				get
		        {
					if(_RegisterYear_W == null)
	        	    {
						_RegisterYear_W = TearOff.RegisterYear;
					}
					return _RegisterYear_W;
				}
			}

			public WhereParameter RegisterType
		    {
				get
		        {
					if(_RegisterType_W == null)
	        	    {
						_RegisterType_W = TearOff.RegisterType;
					}
					return _RegisterType_W;
				}
			}

			private WhereParameter _RegisterID_W = null;
			private WhereParameter _RegisterCode_W = null;
			private WhereParameter _CurrentRegister_W = null;
			private WhereParameter _OrgID_W = null;
			private WhereParameter _CreationDate_W = null;
			private WhereParameter _StartSerial_W = null;
			private WhereParameter _RegisterYear_W = null;
			private WhereParameter _RegisterType_W = null;

			public void WhereClauseReset()
			{
				_RegisterID_W = null;
				_RegisterCode_W = null;
				_CurrentRegister_W = null;
				_OrgID_W = null;
				_CreationDate_W = null;
				_StartSerial_W = null;
				_RegisterYear_W = null;
				_RegisterType_W = null;

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
				
				
				public AggregateParameter RegisterID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.RegisterID, Parameters.RegisterID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter RegisterCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.RegisterCode, Parameters.RegisterCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CurrentRegister
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CurrentRegister, Parameters.CurrentRegister);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter OrgID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OrgID, Parameters.OrgID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CreationDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreationDate, Parameters.CreationDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter StartSerial
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.StartSerial, Parameters.StartSerial);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter RegisterYear
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.RegisterYear, Parameters.RegisterYear);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter RegisterType
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.RegisterType, Parameters.RegisterType);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter RegisterID
		    {
				get
		        {
					if(_RegisterID_W == null)
	        	    {
						_RegisterID_W = TearOff.RegisterID;
					}
					return _RegisterID_W;
				}
			}

			public AggregateParameter RegisterCode
		    {
				get
		        {
					if(_RegisterCode_W == null)
	        	    {
						_RegisterCode_W = TearOff.RegisterCode;
					}
					return _RegisterCode_W;
				}
			}

			public AggregateParameter CurrentRegister
		    {
				get
		        {
					if(_CurrentRegister_W == null)
	        	    {
						_CurrentRegister_W = TearOff.CurrentRegister;
					}
					return _CurrentRegister_W;
				}
			}

			public AggregateParameter OrgID
		    {
				get
		        {
					if(_OrgID_W == null)
	        	    {
						_OrgID_W = TearOff.OrgID;
					}
					return _OrgID_W;
				}
			}

			public AggregateParameter CreationDate
		    {
				get
		        {
					if(_CreationDate_W == null)
	        	    {
						_CreationDate_W = TearOff.CreationDate;
					}
					return _CreationDate_W;
				}
			}

			public AggregateParameter StartSerial
		    {
				get
		        {
					if(_StartSerial_W == null)
	        	    {
						_StartSerial_W = TearOff.StartSerial;
					}
					return _StartSerial_W;
				}
			}

			public AggregateParameter RegisterYear
		    {
				get
		        {
					if(_RegisterYear_W == null)
	        	    {
						_RegisterYear_W = TearOff.RegisterYear;
					}
					return _RegisterYear_W;
				}
			}

			public AggregateParameter RegisterType
		    {
				get
		        {
					if(_RegisterType_W == null)
	        	    {
						_RegisterType_W = TearOff.RegisterType;
					}
					return _RegisterType_W;
				}
			}

			private AggregateParameter _RegisterID_W = null;
			private AggregateParameter _RegisterCode_W = null;
			private AggregateParameter _CurrentRegister_W = null;
			private AggregateParameter _OrgID_W = null;
			private AggregateParameter _CreationDate_W = null;
			private AggregateParameter _StartSerial_W = null;
			private AggregateParameter _RegisterYear_W = null;
			private AggregateParameter _RegisterType_W = null;

			public void AggregateClauseReset()
			{
				_RegisterID_W = null;
				_RegisterCode_W = null;
				_CurrentRegister_W = null;
				_OrgID_W = null;
				_CreationDate_W = null;
				_StartSerial_W = null;
				_RegisterYear_W = null;
				_RegisterType_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ManualRegisterInsert]";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ManualRegisterUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[ManualRegisterDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.RegisterID);
			p.SourceColumn = ColumnNames.RegisterID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.RegisterID);
			p.SourceColumn = ColumnNames.RegisterID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.RegisterCode);
			p.SourceColumn = ColumnNames.RegisterCode;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CurrentRegister);
			p.SourceColumn = ColumnNames.CurrentRegister;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.OrgID);
			p.SourceColumn = ColumnNames.OrgID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreationDate);
			p.SourceColumn = ColumnNames.CreationDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.StartSerial);
			p.SourceColumn = ColumnNames.StartSerial;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.RegisterYear);
			p.SourceColumn = ColumnNames.RegisterYear;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.RegisterType);
			p.SourceColumn = ColumnNames.RegisterType;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
