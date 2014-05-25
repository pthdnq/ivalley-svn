
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
	public abstract class _Companies : SqlClientEntity
	{
		public _Companies()
		{
			this.QuerySource = "Companies";
			this.MappingName = "Companies";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CompaniesLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int CompanyID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.CompanyID, CompanyID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CompaniesLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter CompanyID
			{
				get
				{
					return new SqlParameter("@CompanyID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Login_Code
			{
				get
				{
					return new SqlParameter("@Login_Code", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter Login_Password
			{
				get
				{
					return new SqlParameter("@Login_Password", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter CompNameEng
			{
				get
				{
					return new SqlParameter("@CompNameEng", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter CompNameAr
			{
				get
				{
					return new SqlParameter("@CompNameAr", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter Comp_Code
			{
				get
				{
					return new SqlParameter("@Comp_Code", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter OLD_EMAIL
			{
				get
				{
					return new SqlParameter("@OLD_EMAIL", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter Doctor_Name
			{
				get
				{
					return new SqlParameter("@Doctor_Name", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter New_Email
			{
				get
				{
					return new SqlParameter("@New_Email", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter Phone_Number
			{
				get
				{
					return new SqlParameter("@Phone_Number", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter Doctor_Name_2
			{
				get
				{
					return new SqlParameter("@Doctor_Name_2", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter New_Email_2
			{
				get
				{
					return new SqlParameter("@New_Email_2", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter Phone_Number2
			{
				get
				{
					return new SqlParameter("@Phone_Number2", SqlDbType.NVarChar, 255);
				}
			}
			
			public static SqlParameter Checked
			{
				get
				{
					return new SqlParameter("@Checked", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string CompanyID = "CompanyID";
            public const string Login_Code = "Login_Code";
            public const string Login_Password = "Login_Password";
            public const string CompNameEng = "CompNameEng";
            public const string CompNameAr = "CompNameAr";
            public const string Comp_Code = "Comp_Code";
            public const string OLD_EMAIL = "OLD_EMAIL";
            public const string Doctor_Name = "Doctor_Name";
            public const string New_Email = "New_Email";
            public const string Phone_Number = "Phone_Number";
            public const string Doctor_Name_2 = "Doctor_Name_2";
            public const string New_Email_2 = "New_Email_2";
            public const string Phone_Number2 = "Phone_Number2";
            public const string Checked = "checked";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CompanyID] = _Companies.PropertyNames.CompanyID;
					ht[Login_Code] = _Companies.PropertyNames.Login_Code;
					ht[Login_Password] = _Companies.PropertyNames.Login_Password;
					ht[CompNameEng] = _Companies.PropertyNames.CompNameEng;
					ht[CompNameAr] = _Companies.PropertyNames.CompNameAr;
					ht[Comp_Code] = _Companies.PropertyNames.Comp_Code;
					ht[OLD_EMAIL] = _Companies.PropertyNames.OLD_EMAIL;
					ht[Doctor_Name] = _Companies.PropertyNames.Doctor_Name;
					ht[New_Email] = _Companies.PropertyNames.New_Email;
					ht[Phone_Number] = _Companies.PropertyNames.Phone_Number;
					ht[Doctor_Name_2] = _Companies.PropertyNames.Doctor_Name_2;
					ht[New_Email_2] = _Companies.PropertyNames.New_Email_2;
					ht[Phone_Number2] = _Companies.PropertyNames.Phone_Number2;
					ht[Checked] = _Companies.PropertyNames.Checked;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string CompanyID = "CompanyID";
            public const string Login_Code = "Login_Code";
            public const string Login_Password = "Login_Password";
            public const string CompNameEng = "CompNameEng";
            public const string CompNameAr = "CompNameAr";
            public const string Comp_Code = "Comp_Code";
            public const string OLD_EMAIL = "OLD_EMAIL";
            public const string Doctor_Name = "Doctor_Name";
            public const string New_Email = "New_Email";
            public const string Phone_Number = "Phone_Number";
            public const string Doctor_Name_2 = "Doctor_Name_2";
            public const string New_Email_2 = "New_Email_2";
            public const string Phone_Number2 = "Phone_Number2";
            public const string Checked = "Checked";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CompanyID] = _Companies.ColumnNames.CompanyID;
					ht[Login_Code] = _Companies.ColumnNames.Login_Code;
					ht[Login_Password] = _Companies.ColumnNames.Login_Password;
					ht[CompNameEng] = _Companies.ColumnNames.CompNameEng;
					ht[CompNameAr] = _Companies.ColumnNames.CompNameAr;
					ht[Comp_Code] = _Companies.ColumnNames.Comp_Code;
					ht[OLD_EMAIL] = _Companies.ColumnNames.OLD_EMAIL;
					ht[Doctor_Name] = _Companies.ColumnNames.Doctor_Name;
					ht[New_Email] = _Companies.ColumnNames.New_Email;
					ht[Phone_Number] = _Companies.ColumnNames.Phone_Number;
					ht[Doctor_Name_2] = _Companies.ColumnNames.Doctor_Name_2;
					ht[New_Email_2] = _Companies.ColumnNames.New_Email_2;
					ht[Phone_Number2] = _Companies.ColumnNames.Phone_Number2;
					ht[Checked] = _Companies.ColumnNames.Checked;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string CompanyID = "s_CompanyID";
            public const string Login_Code = "s_Login_Code";
            public const string Login_Password = "s_Login_Password";
            public const string CompNameEng = "s_CompNameEng";
            public const string CompNameAr = "s_CompNameAr";
            public const string Comp_Code = "s_Comp_Code";
            public const string OLD_EMAIL = "s_OLD_EMAIL";
            public const string Doctor_Name = "s_Doctor_Name";
            public const string New_Email = "s_New_Email";
            public const string Phone_Number = "s_Phone_Number";
            public const string Doctor_Name_2 = "s_Doctor_Name_2";
            public const string New_Email_2 = "s_New_Email_2";
            public const string Phone_Number2 = "s_Phone_Number2";
            public const string Checked = "s_Checked";

		}
		#endregion		
		
		#region Properties
	
		public virtual int CompanyID
	    {
			get
	        {
				return base.Getint(ColumnNames.CompanyID);
			}
			set
	        {
				base.Setint(ColumnNames.CompanyID, value);
			}
		}

		public virtual string Login_Code
	    {
			get
	        {
				return base.Getstring(ColumnNames.Login_Code);
			}
			set
	        {
				base.Setstring(ColumnNames.Login_Code, value);
			}
		}

		public virtual string Login_Password
	    {
			get
	        {
				return base.Getstring(ColumnNames.Login_Password);
			}
			set
	        {
				base.Setstring(ColumnNames.Login_Password, value);
			}
		}

		public virtual string CompNameEng
	    {
			get
	        {
				return base.Getstring(ColumnNames.CompNameEng);
			}
			set
	        {
				base.Setstring(ColumnNames.CompNameEng, value);
			}
		}

		public virtual string CompNameAr
	    {
			get
	        {
				return base.Getstring(ColumnNames.CompNameAr);
			}
			set
	        {
				base.Setstring(ColumnNames.CompNameAr, value);
			}
		}

		public virtual string Comp_Code
	    {
			get
	        {
				return base.Getstring(ColumnNames.Comp_Code);
			}
			set
	        {
				base.Setstring(ColumnNames.Comp_Code, value);
			}
		}

		public virtual string OLD_EMAIL
	    {
			get
	        {
				return base.Getstring(ColumnNames.OLD_EMAIL);
			}
			set
	        {
				base.Setstring(ColumnNames.OLD_EMAIL, value);
			}
		}

		public virtual string Doctor_Name
	    {
			get
	        {
				return base.Getstring(ColumnNames.Doctor_Name);
			}
			set
	        {
				base.Setstring(ColumnNames.Doctor_Name, value);
			}
		}

		public virtual string New_Email
	    {
			get
	        {
				return base.Getstring(ColumnNames.New_Email);
			}
			set
	        {
				base.Setstring(ColumnNames.New_Email, value);
			}
		}

		public virtual string Phone_Number
	    {
			get
	        {
				return base.Getstring(ColumnNames.Phone_Number);
			}
			set
	        {
				base.Setstring(ColumnNames.Phone_Number, value);
			}
		}

		public virtual string Doctor_Name_2
	    {
			get
	        {
				return base.Getstring(ColumnNames.Doctor_Name_2);
			}
			set
	        {
				base.Setstring(ColumnNames.Doctor_Name_2, value);
			}
		}

		public virtual string New_Email_2
	    {
			get
	        {
				return base.Getstring(ColumnNames.New_Email_2);
			}
			set
	        {
				base.Setstring(ColumnNames.New_Email_2, value);
			}
		}

		public virtual string Phone_Number2
	    {
			get
	        {
				return base.Getstring(ColumnNames.Phone_Number2);
			}
			set
	        {
				base.Setstring(ColumnNames.Phone_Number2, value);
			}
		}

		public virtual bool Checked
	    {
			get
	        {
				return base.Getbool(ColumnNames.Checked);
			}
			set
	        {
				base.Setbool(ColumnNames.Checked, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_CompanyID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CompanyID) ? string.Empty : base.GetintAsString(ColumnNames.CompanyID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CompanyID);
				else
					this.CompanyID = base.SetintAsString(ColumnNames.CompanyID, value);
			}
		}

		public virtual string s_Login_Code
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Login_Code) ? string.Empty : base.GetstringAsString(ColumnNames.Login_Code);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Login_Code);
				else
					this.Login_Code = base.SetstringAsString(ColumnNames.Login_Code, value);
			}
		}

		public virtual string s_Login_Password
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Login_Password) ? string.Empty : base.GetstringAsString(ColumnNames.Login_Password);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Login_Password);
				else
					this.Login_Password = base.SetstringAsString(ColumnNames.Login_Password, value);
			}
		}

		public virtual string s_CompNameEng
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CompNameEng) ? string.Empty : base.GetstringAsString(ColumnNames.CompNameEng);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CompNameEng);
				else
					this.CompNameEng = base.SetstringAsString(ColumnNames.CompNameEng, value);
			}
		}

		public virtual string s_CompNameAr
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CompNameAr) ? string.Empty : base.GetstringAsString(ColumnNames.CompNameAr);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CompNameAr);
				else
					this.CompNameAr = base.SetstringAsString(ColumnNames.CompNameAr, value);
			}
		}

		public virtual string s_Comp_Code
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Comp_Code) ? string.Empty : base.GetstringAsString(ColumnNames.Comp_Code);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Comp_Code);
				else
					this.Comp_Code = base.SetstringAsString(ColumnNames.Comp_Code, value);
			}
		}

		public virtual string s_OLD_EMAIL
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OLD_EMAIL) ? string.Empty : base.GetstringAsString(ColumnNames.OLD_EMAIL);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OLD_EMAIL);
				else
					this.OLD_EMAIL = base.SetstringAsString(ColumnNames.OLD_EMAIL, value);
			}
		}

		public virtual string s_Doctor_Name
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Doctor_Name) ? string.Empty : base.GetstringAsString(ColumnNames.Doctor_Name);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Doctor_Name);
				else
					this.Doctor_Name = base.SetstringAsString(ColumnNames.Doctor_Name, value);
			}
		}

		public virtual string s_New_Email
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.New_Email) ? string.Empty : base.GetstringAsString(ColumnNames.New_Email);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.New_Email);
				else
					this.New_Email = base.SetstringAsString(ColumnNames.New_Email, value);
			}
		}

		public virtual string s_Phone_Number
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Phone_Number) ? string.Empty : base.GetstringAsString(ColumnNames.Phone_Number);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Phone_Number);
				else
					this.Phone_Number = base.SetstringAsString(ColumnNames.Phone_Number, value);
			}
		}

		public virtual string s_Doctor_Name_2
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Doctor_Name_2) ? string.Empty : base.GetstringAsString(ColumnNames.Doctor_Name_2);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Doctor_Name_2);
				else
					this.Doctor_Name_2 = base.SetstringAsString(ColumnNames.Doctor_Name_2, value);
			}
		}

		public virtual string s_New_Email_2
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.New_Email_2) ? string.Empty : base.GetstringAsString(ColumnNames.New_Email_2);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.New_Email_2);
				else
					this.New_Email_2 = base.SetstringAsString(ColumnNames.New_Email_2, value);
			}
		}

		public virtual string s_Phone_Number2
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Phone_Number2) ? string.Empty : base.GetstringAsString(ColumnNames.Phone_Number2);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Phone_Number2);
				else
					this.Phone_Number2 = base.SetstringAsString(ColumnNames.Phone_Number2, value);
			}
		}

		public virtual string s_Checked
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Checked) ? string.Empty : base.GetboolAsString(ColumnNames.Checked);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Checked);
				else
					this.Checked = base.SetboolAsString(ColumnNames.Checked, value);
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
				
				
				public WhereParameter CompanyID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CompanyID, Parameters.CompanyID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Login_Code
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Login_Code, Parameters.Login_Code);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Login_Password
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Login_Password, Parameters.Login_Password);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CompNameEng
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CompNameEng, Parameters.CompNameEng);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CompNameAr
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CompNameAr, Parameters.CompNameAr);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Comp_Code
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Comp_Code, Parameters.Comp_Code);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter OLD_EMAIL
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OLD_EMAIL, Parameters.OLD_EMAIL);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Doctor_Name
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Doctor_Name, Parameters.Doctor_Name);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter New_Email
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.New_Email, Parameters.New_Email);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Phone_Number
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Phone_Number, Parameters.Phone_Number);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Doctor_Name_2
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Doctor_Name_2, Parameters.Doctor_Name_2);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter New_Email_2
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.New_Email_2, Parameters.New_Email_2);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Phone_Number2
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Phone_Number2, Parameters.Phone_Number2);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Checked
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Checked, Parameters.Checked);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter CompanyID
		    {
				get
		        {
					if(_CompanyID_W == null)
	        	    {
						_CompanyID_W = TearOff.CompanyID;
					}
					return _CompanyID_W;
				}
			}

			public WhereParameter Login_Code
		    {
				get
		        {
					if(_Login_Code_W == null)
	        	    {
						_Login_Code_W = TearOff.Login_Code;
					}
					return _Login_Code_W;
				}
			}

			public WhereParameter Login_Password
		    {
				get
		        {
					if(_Login_Password_W == null)
	        	    {
						_Login_Password_W = TearOff.Login_Password;
					}
					return _Login_Password_W;
				}
			}

			public WhereParameter CompNameEng
		    {
				get
		        {
					if(_CompNameEng_W == null)
	        	    {
						_CompNameEng_W = TearOff.CompNameEng;
					}
					return _CompNameEng_W;
				}
			}

			public WhereParameter CompNameAr
		    {
				get
		        {
					if(_CompNameAr_W == null)
	        	    {
						_CompNameAr_W = TearOff.CompNameAr;
					}
					return _CompNameAr_W;
				}
			}

			public WhereParameter Comp_Code
		    {
				get
		        {
					if(_Comp_Code_W == null)
	        	    {
						_Comp_Code_W = TearOff.Comp_Code;
					}
					return _Comp_Code_W;
				}
			}

			public WhereParameter OLD_EMAIL
		    {
				get
		        {
					if(_OLD_EMAIL_W == null)
	        	    {
						_OLD_EMAIL_W = TearOff.OLD_EMAIL;
					}
					return _OLD_EMAIL_W;
				}
			}

			public WhereParameter Doctor_Name
		    {
				get
		        {
					if(_Doctor_Name_W == null)
	        	    {
						_Doctor_Name_W = TearOff.Doctor_Name;
					}
					return _Doctor_Name_W;
				}
			}

			public WhereParameter New_Email
		    {
				get
		        {
					if(_New_Email_W == null)
	        	    {
						_New_Email_W = TearOff.New_Email;
					}
					return _New_Email_W;
				}
			}

			public WhereParameter Phone_Number
		    {
				get
		        {
					if(_Phone_Number_W == null)
	        	    {
						_Phone_Number_W = TearOff.Phone_Number;
					}
					return _Phone_Number_W;
				}
			}

			public WhereParameter Doctor_Name_2
		    {
				get
		        {
					if(_Doctor_Name_2_W == null)
	        	    {
						_Doctor_Name_2_W = TearOff.Doctor_Name_2;
					}
					return _Doctor_Name_2_W;
				}
			}

			public WhereParameter New_Email_2
		    {
				get
		        {
					if(_New_Email_2_W == null)
	        	    {
						_New_Email_2_W = TearOff.New_Email_2;
					}
					return _New_Email_2_W;
				}
			}

			public WhereParameter Phone_Number2
		    {
				get
		        {
					if(_Phone_Number2_W == null)
	        	    {
						_Phone_Number2_W = TearOff.Phone_Number2;
					}
					return _Phone_Number2_W;
				}
			}

			public WhereParameter Checked
		    {
				get
		        {
					if(_Checked_W == null)
	        	    {
						_Checked_W = TearOff.Checked;
					}
					return _Checked_W;
				}
			}

			private WhereParameter _CompanyID_W = null;
			private WhereParameter _Login_Code_W = null;
			private WhereParameter _Login_Password_W = null;
			private WhereParameter _CompNameEng_W = null;
			private WhereParameter _CompNameAr_W = null;
			private WhereParameter _Comp_Code_W = null;
			private WhereParameter _OLD_EMAIL_W = null;
			private WhereParameter _Doctor_Name_W = null;
			private WhereParameter _New_Email_W = null;
			private WhereParameter _Phone_Number_W = null;
			private WhereParameter _Doctor_Name_2_W = null;
			private WhereParameter _New_Email_2_W = null;
			private WhereParameter _Phone_Number2_W = null;
			private WhereParameter _Checked_W = null;

			public void WhereClauseReset()
			{
				_CompanyID_W = null;
				_Login_Code_W = null;
				_Login_Password_W = null;
				_CompNameEng_W = null;
				_CompNameAr_W = null;
				_Comp_Code_W = null;
				_OLD_EMAIL_W = null;
				_Doctor_Name_W = null;
				_New_Email_W = null;
				_Phone_Number_W = null;
				_Doctor_Name_2_W = null;
				_New_Email_2_W = null;
				_Phone_Number2_W = null;
				_Checked_W = null;

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
				
				
				public AggregateParameter CompanyID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CompanyID, Parameters.CompanyID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Login_Code
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Login_Code, Parameters.Login_Code);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Login_Password
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Login_Password, Parameters.Login_Password);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CompNameEng
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CompNameEng, Parameters.CompNameEng);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CompNameAr
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CompNameAr, Parameters.CompNameAr);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Comp_Code
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Comp_Code, Parameters.Comp_Code);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter OLD_EMAIL
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OLD_EMAIL, Parameters.OLD_EMAIL);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Doctor_Name
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Doctor_Name, Parameters.Doctor_Name);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter New_Email
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.New_Email, Parameters.New_Email);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Phone_Number
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Phone_Number, Parameters.Phone_Number);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Doctor_Name_2
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Doctor_Name_2, Parameters.Doctor_Name_2);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter New_Email_2
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.New_Email_2, Parameters.New_Email_2);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Phone_Number2
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Phone_Number2, Parameters.Phone_Number2);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Checked
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Checked, Parameters.Checked);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter CompanyID
		    {
				get
		        {
					if(_CompanyID_W == null)
	        	    {
						_CompanyID_W = TearOff.CompanyID;
					}
					return _CompanyID_W;
				}
			}

			public AggregateParameter Login_Code
		    {
				get
		        {
					if(_Login_Code_W == null)
	        	    {
						_Login_Code_W = TearOff.Login_Code;
					}
					return _Login_Code_W;
				}
			}

			public AggregateParameter Login_Password
		    {
				get
		        {
					if(_Login_Password_W == null)
	        	    {
						_Login_Password_W = TearOff.Login_Password;
					}
					return _Login_Password_W;
				}
			}

			public AggregateParameter CompNameEng
		    {
				get
		        {
					if(_CompNameEng_W == null)
	        	    {
						_CompNameEng_W = TearOff.CompNameEng;
					}
					return _CompNameEng_W;
				}
			}

			public AggregateParameter CompNameAr
		    {
				get
		        {
					if(_CompNameAr_W == null)
	        	    {
						_CompNameAr_W = TearOff.CompNameAr;
					}
					return _CompNameAr_W;
				}
			}

			public AggregateParameter Comp_Code
		    {
				get
		        {
					if(_Comp_Code_W == null)
	        	    {
						_Comp_Code_W = TearOff.Comp_Code;
					}
					return _Comp_Code_W;
				}
			}

			public AggregateParameter OLD_EMAIL
		    {
				get
		        {
					if(_OLD_EMAIL_W == null)
	        	    {
						_OLD_EMAIL_W = TearOff.OLD_EMAIL;
					}
					return _OLD_EMAIL_W;
				}
			}

			public AggregateParameter Doctor_Name
		    {
				get
		        {
					if(_Doctor_Name_W == null)
	        	    {
						_Doctor_Name_W = TearOff.Doctor_Name;
					}
					return _Doctor_Name_W;
				}
			}

			public AggregateParameter New_Email
		    {
				get
		        {
					if(_New_Email_W == null)
	        	    {
						_New_Email_W = TearOff.New_Email;
					}
					return _New_Email_W;
				}
			}

			public AggregateParameter Phone_Number
		    {
				get
		        {
					if(_Phone_Number_W == null)
	        	    {
						_Phone_Number_W = TearOff.Phone_Number;
					}
					return _Phone_Number_W;
				}
			}

			public AggregateParameter Doctor_Name_2
		    {
				get
		        {
					if(_Doctor_Name_2_W == null)
	        	    {
						_Doctor_Name_2_W = TearOff.Doctor_Name_2;
					}
					return _Doctor_Name_2_W;
				}
			}

			public AggregateParameter New_Email_2
		    {
				get
		        {
					if(_New_Email_2_W == null)
	        	    {
						_New_Email_2_W = TearOff.New_Email_2;
					}
					return _New_Email_2_W;
				}
			}

			public AggregateParameter Phone_Number2
		    {
				get
		        {
					if(_Phone_Number2_W == null)
	        	    {
						_Phone_Number2_W = TearOff.Phone_Number2;
					}
					return _Phone_Number2_W;
				}
			}

			public AggregateParameter Checked
		    {
				get
		        {
					if(_Checked_W == null)
	        	    {
						_Checked_W = TearOff.Checked;
					}
					return _Checked_W;
				}
			}

			private AggregateParameter _CompanyID_W = null;
			private AggregateParameter _Login_Code_W = null;
			private AggregateParameter _Login_Password_W = null;
			private AggregateParameter _CompNameEng_W = null;
			private AggregateParameter _CompNameAr_W = null;
			private AggregateParameter _Comp_Code_W = null;
			private AggregateParameter _OLD_EMAIL_W = null;
			private AggregateParameter _Doctor_Name_W = null;
			private AggregateParameter _New_Email_W = null;
			private AggregateParameter _Phone_Number_W = null;
			private AggregateParameter _Doctor_Name_2_W = null;
			private AggregateParameter _New_Email_2_W = null;
			private AggregateParameter _Phone_Number2_W = null;
			private AggregateParameter _Checked_W = null;

			public void AggregateClauseReset()
			{
				_CompanyID_W = null;
				_Login_Code_W = null;
				_Login_Password_W = null;
				_CompNameEng_W = null;
				_CompNameAr_W = null;
				_Comp_Code_W = null;
				_OLD_EMAIL_W = null;
				_Doctor_Name_W = null;
				_New_Email_W = null;
				_Phone_Number_W = null;
				_Doctor_Name_2_W = null;
				_New_Email_2_W = null;
				_Phone_Number2_W = null;
				_Checked_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CompaniesInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.CompanyID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CompaniesUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CompaniesDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.CompanyID);
			p.SourceColumn = ColumnNames.CompanyID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.CompanyID);
			p.SourceColumn = ColumnNames.CompanyID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Login_Code);
			p.SourceColumn = ColumnNames.Login_Code;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Login_Password);
			p.SourceColumn = ColumnNames.Login_Password;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CompNameEng);
			p.SourceColumn = ColumnNames.CompNameEng;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CompNameAr);
			p.SourceColumn = ColumnNames.CompNameAr;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Comp_Code);
			p.SourceColumn = ColumnNames.Comp_Code;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.OLD_EMAIL);
			p.SourceColumn = ColumnNames.OLD_EMAIL;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Doctor_Name);
			p.SourceColumn = ColumnNames.Doctor_Name;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.New_Email);
			p.SourceColumn = ColumnNames.New_Email;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Phone_Number);
			p.SourceColumn = ColumnNames.Phone_Number;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Doctor_Name_2);
			p.SourceColumn = ColumnNames.Doctor_Name_2;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.New_Email_2);
			p.SourceColumn = ColumnNames.New_Email_2;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Phone_Number2);
			p.SourceColumn = ColumnNames.Phone_Number2;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Checked);
			p.SourceColumn = ColumnNames.Checked;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}