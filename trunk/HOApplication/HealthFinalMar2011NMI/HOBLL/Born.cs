
// Generated by MyGeneration Version # (1.2.0.7)

using System;
using MHO.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Globalization;

namespace MHO.BLL
{
    public class Born : _Born
    {
        public Born()
        {

        }

        public void UpdateNewEventBorn(Guid bornEventIdParameter, string name, int gender, DateTime birthDate, int goveID, int policeID, int areaID,
                                     string fatherNID, string fatherfirstName, string fatherFatherName, string fatherFamilyName,
                                     string fatherJob, int fatherRelegion, int fatherNationality,
                                         string motherNID, string motherfirstName, string motherFatherName, string motherFamilyName,
                                        string motherJob, int motherRelegion, int motherNationality, 
                                        int infRelation, string infFirstName, string infSecondName,
            string infPhone, string infNID,Guid registerId, int registerNo,
            string _fatherProveNo,string _fatherProveType,
            string _motherProveNo, string _motherProveType, string _mothSureName, string _fathSureName
            , string bornDecisionNo, string bornDecisionDirection, string bornDecisionDate, string bornDecisionNotes,bool isFound)
        {
            
            this.LoadByPrimaryKey(bornEventIdParameter);

            this.BornName = name;
            this.BornGender = gender;
            this.BirthDate = birthDate;
            this.BornGovernorate = goveID;
            this.BornSection = policeID;
            this.BornArea = areaID;
            this.FatherNID = fatherNID;
            this.FirstFatherName = fatherfirstName;
            this.SecondFatherName = fatherFatherName;
            this.FamilyFatherName = fatherFamilyName;
            this.FatherNationality = fatherNationality;
            this.FatherReligion = fatherRelegion;
            this.FatherJob = fatherJob;
            FatherProveNo = _fatherProveNo;
            FatherProveType = _fatherProveType;
            FatherSureName = _fathSureName;
            this.MotherNID = motherNID;
            this.FirstMotherName = motherfirstName;
            this.SecondMotherName = motherFatherName;
            this.FamilyMotherName = motherFamilyName;
            this.MotherJob = motherJob;
            this.MotherReligion = motherRelegion;
            this.MotherNationality = motherNationality;
            MotherProveNo = _motherProveNo;
            MotherProveType = _motherProveType;
            MotherSureName = _mothSureName;
            this.InformerNID = infNID;
            this.InformerRelation = infRelation;
            this.InformerFirstName = infFirstName;
            this.InformerSecondName = infSecondName;
            this.InformerPhone = infPhone;
            this.RegisterID = registerId;
            IsFound = isFound;
            if (bornDecisionNo != string.Empty)
            {
                BornDecisionNo = bornDecisionNo;
            }
            if (bornDecisionDirection != string.Empty)
            {
                BornDecisionDirection = bornDecisionDirection;
            }
            if (bornDecisionDate != string.Empty)
            {
                BornDecisionDate = DateTime.Parse(bornDecisionDate);
            }
            if (bornDecisionNotes == string.Empty)
            {
                BornDecisionNotes = bornDecisionNotes;
            }
            //this.RegisterNo = registerNo;
            this.Save();

        }

        public Guid AddNewEventBorn(int _orgID,string name, int gender, DateTime birthDate, int goveID, int policeID, int areaID,
                                     string fatherNID, string fatherfirstName, string fatherFatherName, string fatherFamilyName,
                                     string fatherJob, int fatherRelegion, int fatherNationality,
                                         string motherNID, string motherfirstName, string motherFatherName, string motherFamilyName,
                                        string motherJob, int motherRelegion, int motherNationality,
                                        int infRelation, string infFirstName,
            string infSecondName, string infPhone, string infNID, 
            Guid registerId, int registerNo,string _fatherProveNo,
            string _fatherProveType,string _motherProveNo, string _motherProveType,string _mothSureName,string _fathSureName
            ,string bornDecisionNo,string bornDecisionDirection,string bornDecisionDate,string bornDecisionNotes,bool isFound)
        {
            AddNew();
            BornEventID = Guid.NewGuid();
            OrgID = _orgID;
            BornName = name;
            BornGender = gender;
            BirthDate = birthDate;
            BornGovernorate = goveID;
            BornSection = policeID;
            BornArea = areaID;
            FatherNID = fatherNID;
            FirstFatherName = fatherfirstName;
            SecondFatherName = fatherFatherName;
            FamilyFatherName = fatherFamilyName;
            FatherNationality = fatherNationality;
            FatherReligion = fatherRelegion;
            FatherJob = fatherJob;
            FatherProveNo = _fatherProveNo;
            FatherProveType = _fatherProveType;
            FatherSureName = _fathSureName;
            MotherNID = motherNID;
            FirstMotherName = motherfirstName;
            SecondMotherName = motherFatherName;
            FamilyMotherName = motherFamilyName;
            MotherJob = motherJob;
            MotherReligion = motherRelegion;
            MotherNationality = motherNationality;
            MotherProveNo = _motherProveNo;
            MotherProveType = _motherProveType;
            MotherSureName = _mothSureName;
            InformerNID = infNID;
            InformerRelation = infRelation;
            InformerFirstName = infFirstName;
            InformerSecondName = infSecondName;
            InformerPhone = infPhone;
            RegisterID = registerId;
            RegisterNo = 0;
            RegisterDate = DateTime.Now.Date;
            IsFound = isFound;
            if (bornDecisionNo == string.Empty)
            {
                SetColumnNull("BornDecisionNo");
            }
            else
            {
                BornDecisionNo = bornDecisionNo;
            }
            if (bornDecisionDirection == string.Empty)
            {
                SetColumnNull("BornDecisionDirection");
            }
            else
            {
                BornDecisionDirection = bornDecisionDirection;
            }
            if (bornDecisionDate == string.Empty)
            {
                SetColumnNull("BornDecisionDirection");
            }
            else
            {
                BornDecisionDate = DateTime.Parse(bornDecisionDate);
            }
            if (bornDecisionNotes == string.Empty)
            {
                SetColumnNull("BornDecisionNotes");
            }
            else
            {
                BornDecisionNotes = bornDecisionNotes;
            }
            
            Approved = false;
            Save();

            return BornEventID;
        }

        public DataTable FilterBorns(string conn,int _orgID, string _fNID, string mNID, string iNID, 
                                    Guid regID, int regNo,string _dateFrom,string _dateTo)
        {
            try
            {

                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dtRes = new DataTable();
                SqlConnection conection = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Mho_Gui_Filter_Born";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conection;
                SqlParameter parm1 = new SqlParameter("fatherNid", _fNID);
                SqlParameter parm2 = new SqlParameter("motherNid", mNID);
                SqlParameter parm3 = new SqlParameter("informerNid", iNID);
                SqlParameter parm4 = new SqlParameter("registerID", regID);
                SqlParameter parm5 = new SqlParameter("registerNo", regNo);
                SqlParameter parm6 = new SqlParameter("orgID", _orgID);
                
                if (!string.IsNullOrEmpty(_dateFrom) && !string.IsNullOrEmpty(_dateTo))
                {

                    System.Globalization.DateTimeFormatInfo dateInfo = new System.Globalization.DateTimeFormatInfo();
                    dateInfo.ShortDatePattern = "dd/MM/yyyy";

                    DateTime strdateFrom = Convert.ToDateTime(_dateFrom, dateInfo);
                    DateTime strdateTo = Convert.ToDateTime(_dateTo, dateInfo);
                    SqlParameter parm7 = new SqlParameter("dateFrom", strdateFrom.Month.ToString().PadLeft(2, '0') + "/" + strdateFrom.Day.ToString().PadLeft(2, '0') + "/" + strdateFrom.Year);
                    SqlParameter parm8 = new SqlParameter("dateto", strdateTo.Month.ToString().PadLeft(2, '0') + "/" + strdateTo.Day.ToString().PadLeft(2, '0') + "/" + strdateTo.Year);
                    cmd.Parameters.Add(parm7);
                    cmd.Parameters.Add(parm8);
                }
                cmd.Parameters.Add(parm1);
                cmd.Parameters.Add(parm2);
                cmd.Parameters.Add(parm3);
                cmd.Parameters.Add(parm4);
                cmd.Parameters.Add(parm5);
                cmd.Parameters.Add(parm6);

                adp.SelectCommand = cmd;
                adp.Fill(dtRes);
                return dtRes;
            }
            catch
            {
                return new DataTable();
            }
            
        }

        public bool ApproveBornInfo(Guid bornID)
        {
            try
            {
                SqlDataReader searchResult = null;
                ListDictionary parm = new ListDictionary();
                parm.Add("@bornID", bornID);
                searchResult = LoadFromSqlReader("Mho_Gui_Approve_Born", parm) as SqlDataReader;
                DataTable ResultTable = new DataTable();
                newAdapter da = new newAdapter();
                if (searchResult != null && searchResult.HasRows)
                {
                    da.FillFromReader(ResultTable, searchResult);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable LoadNonApprovedBorns(int _currentOfficeID)
        {
            try
            {
                SqlDataReader searchResult = null;
                ListDictionary parm = new ListDictionary();
                parm.Add("@org", _currentOfficeID);
                searchResult = LoadFromSqlReader("gui_GetNotApprovedBorns", parm) as SqlDataReader;
                DataTable ResultTable = new DataTable();
                newAdapter da = new newAdapter();
                if (searchResult != null && searchResult.HasRows)
                {
                    da.FillFromReader(ResultTable, searchResult);
                }
                return ResultTable;
            }
            catch
            {
                return new DataTable();
            }
        }
        public DataTable ListBornAprrovedCount(string _dateFrom,string _dateTo)
        {
            try
            {
                SqlDataReader searchResult = null;
                ListDictionary parm = new ListDictionary();
                parm.Add("@StartDate", DateTime.Parse(_dateFrom).ToString("MM/yyyy/dd"));
                parm.Add("@EndDate", DateTime.Parse(_dateTo).ToString("MM/yyyy/dd"));
                searchResult = LoadFromSqlReader("Rpt_ListBornAprrovedCount", parm) as SqlDataReader;
                DataTable ResultTable = new DataTable();
                newAdapter da = new newAdapter();
                if (searchResult != null && searchResult.HasRows)
                {
                    da.FillFromReader(ResultTable, searchResult);
                }
                return ResultTable;
            }
            catch
            {
                return new DataTable();
            }
        }
        public DataTable ListBornMailFemaleLostCount(string _dateFrom, string _dateTo)
        {
            try
            {
                SqlDataReader searchResult = null;
                ListDictionary parm = new ListDictionary();
                parm.Add("@StartDate", DateTime.Parse(_dateFrom).ToString("MM/yyyy/dd"));
                parm.Add("@EndDate", DateTime.Parse(_dateTo).ToString("MM/yyyy/dd"));
                searchResult = LoadFromSqlReader("Rpt_ListBornMailFemaleLostCount", parm) as SqlDataReader;
                DataTable ResultTable = new DataTable();
                newAdapter da = new newAdapter();
                if (searchResult != null && searchResult.HasRows)
                {
                    da.FillFromReader(ResultTable, searchResult);
                }
                return ResultTable;
            }
            catch
            {
                return new DataTable();
            }
        }
        public DataTable ListBornDead(string _dateFrom, string _dateTo)
        {
            try
            {
                SqlDataReader searchResult = null;
                ListDictionary parm = new ListDictionary();
                parm.Add("@StartDate", DateTime.Parse(_dateFrom).ToString("MM/yyyy/dd"));
                parm.Add("@EndDate", DateTime.Parse(_dateTo).ToString("MM/yyyy/dd"));
                searchResult = LoadFromSqlReader("Rpt_ListBornDead", parm) as SqlDataReader;
                DataTable ResultTable = new DataTable();
                newAdapter da = new newAdapter();
                if (searchResult != null && searchResult.HasRows)
                {
                    da.FillFromReader(ResultTable, searchResult);
                }
                return ResultTable;
            }
            catch
            {
                return new DataTable();
            }
        }
        public DataTable ListBornCityVillage(string _dateFrom, string _dateTo)
        {
            try
            {
                SqlDataReader searchResult = null;
                ListDictionary parm = new ListDictionary();
                parm.Add("@StartDate", DateTime.Parse(_dateFrom).ToString("MM/yyyy/dd"));
                parm.Add("@EndDate", DateTime.Parse(_dateTo).ToString("MM/yyyy/dd"));
                searchResult = LoadFromSqlReader("Rpt_ListBornCityVillage", parm) as SqlDataReader;
                DataTable ResultTable = new DataTable();
                newAdapter da = new newAdapter();
                if (searchResult != null && searchResult.HasRows)
                {
                    da.FillFromReader(ResultTable, searchResult);
                }
                return ResultTable;
            }
            catch
            {
                return new DataTable();
            }
        }
        public bool IsBornCaseExist(string _fatherNid, string _motherNid, string _bornName, string _birthDate, string _chkDate)
        {
            try
            {
                SqlDataReader searchResult = null;
                ListDictionary parm = new ListDictionary();
                parm.Add("@FatherNid", _fatherNid);
                parm.Add("@MotherNid", _motherNid);
                parm.Add("@BornName", _bornName);
                parm.Add("@BornBirthDate", _birthDate);
                parm.Add("@checkDate", _chkDate);

                searchResult = LoadFromSqlReader("CheckBornCaseExist", parm) as SqlDataReader;
                DataTable ResultTable = new DataTable();
                newAdapter da = new newAdapter();
                if (searchResult != null && searchResult.HasRows)
                {
                    da.FillFromReader(ResultTable, searchResult);
                }
                return ResultTable.Rows.Count > 0;
            }
            catch
            {
                return false;
            }
        }
       
        public bool UpdateBornWriter(Guid _currentuserID,Guid _bornID)
        {
            try
            {
                SqlDataReader searchResult = null;
                ListDictionary parm = new ListDictionary();
                parm.Add("@bornCaseID", _bornID);
                parm.Add("@writerID", _currentuserID);
                searchResult = LoadFromSqlReader("GUI_UpdateBornWriter", parm) as SqlDataReader;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateBornDoctor(Guid _currentuserID, Guid _bornID)
        {
            try
            {
                SqlDataReader searchResult = null;
                ListDictionary parm = new ListDictionary();
                parm.Add("@bornCaseID", _bornID);
                parm.Add("@doctorID", _currentuserID);
                searchResult = LoadFromSqlReader("GUI_UpdateBornDoctor", parm) as SqlDataReader;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
