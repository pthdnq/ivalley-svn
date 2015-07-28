using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Flight_BLL;
using System.Data;
using System.Web.Script.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Web.Security;
namespace Flights_GUI.Common
{
    /// <summary>
    /// Summary description for IntranetService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class IntranetService : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public void GetAvalName(string term)
        {
            UsersProfiles upro = new UsersProfiles();
            upro.getNamesList(term);
            
            List<NameListDetails> Nms = upro.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new NameListDetails
                {
                    label = row["FullName"].ToString(),
                    value = row["Email"].ToString(),
                    UserID = new Guid (row["UserID"].ToString())
                };

            }).ToList();

            SetContentResult(Nms);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public void GetManualVersions(int ID)
        {
            ManualVersion versions = new ManualVersion();
            versions.GetVersionsByManualID(ID, "");

            List<Version> AllVersions = versions.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Version
                {
                    Title = row["Title"].ToString(),
                    IssueNumber = row["IssueNumber"].ToString(),
                    IssueDate = (!row.IsNull("IssueDate")) ? DateTime.Parse(row["IssueDate"].ToString()) : (DateTime?)null,
                    RevisionNumber = row["RevisionNumber"].ToString(),
                    RevisionDate = (!row.IsNull("RevisionDate")) ? DateTime.Parse(row["RevisionDate"].ToString()) : (DateTime?)null,
                    UpdatedByName = row["UpdatedByName"].ToString(),
                    LastUpdatedDate = DateTime.Parse(row["LastUpdatedDate"].ToString()),
                    Path = row["Path"].ToString()
                };

            }).ToList();

            LogManualsVersionsRead(ID);

            UsersNofications usNot = new UsersNofications();
            Manual man = new Manual();
            man.LoadByPrimaryKey(ID);

            ManualCategory currentManualCat = new ManualCategory();
            currentManualCat.GetTopMostParent(man.ManualCategoryID);

            if (!currentManualCat.IsColumnNull(ManualCategory.ColumnNames.ParentCategoryID))
            {
                if (currentManualCat.ParentCategoryID == 12)
                    usNot.MarkNotificationsReadByAirCraftManualVersionID(new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString()), ID);
                else
                    usNot.MarkNotificationsReadByManualVersionID(new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString()), ID);
            }
            else
            {
                if (currentManualCat.ManualCategoryID == 12)
                    usNot.MarkNotificationsReadByAirCraftManualVersionID(new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString()), ID);
                else
                    usNot.MarkNotificationsReadByManualVersionID(new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString()), ID);
                
            }
            SetContentResult(AllVersions);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public void GetScheduleVersions(int ID)
        {
            LogScheduleVersionsView();

            ScheduleVersion versions = new ScheduleVersion();
            versions.GetVersionsByScheduleID(ID);

            List<Version> AllVersions = versions.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Version
                {
                    Title = row["Title"].ToString(),
                    IssueNumber = row["IssueNumber"].ToString(),
                    IssueDate = (!row.IsNull("IssueDate")) ? DateTime.Parse(row["IssueDate"].ToString()) : (DateTime?)null,
                    RevisionNumber = row["RevisionNumber"].ToString(),
                    RevisionDate = (!row.IsNull("RevisionDate")) ? DateTime.Parse(row["RevisionDate"].ToString()) : (DateTime?)null,
                    UpdatedByName = row["UpdatedByName"].ToString(),
                    LastUpdatedDate = DateTime.Parse(row["LastUpdatedDate"].ToString()),
                    Path = row["Path"].ToString()
                };
            }).ToList();
            UsersNofications usNot = new UsersNofications();

            usNot.MarkNotificationsReadByScheduleVersionID(new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString()), ID);
            SetContentResult(AllVersions);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void LogCertificateDownload(int CertificateID)
        {
            AppConfig config = new AppConfig();
            config.LoadByPrimaryKey(1);
            CertificateLog objData = new CertificateLog();
            objData.AddNew();
            objData.CertificateID = int.Parse(CertificateID.ToString());
            objData.UserID = new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString());
            objData.ActionID = 5;
            objData.LogDate = config.GetDateTimeUsingLocalZone();
            objData.Save();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void LogScheduleVersionDownload(int ScheduleVersionID)
        {
            AppConfig config = new AppConfig();
            config.LoadByPrimaryKey(1);
            ScheduleLog objData = new ScheduleLog();
            objData.AddNew();
            objData.ScheduleVersionID = int.Parse(ScheduleVersionID.ToString());
            objData.UserID = new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString());
            objData.ActionID = 5;
            objData.LogDate = config.GetDateTimeUsingLocalZone();
            objData.Save();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void LogManualVersionDownload(int ManualVersionID)
        {
            AppConfig config = new AppConfig();
            config.LoadByPrimaryKey(1);
            ManualLog objData = new ManualLog();
            objData.AddNew();
            objData.ManualVersionID = int.Parse(ManualVersionID.ToString());
            objData.UserID = new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString());
            objData.ActionID = 5;
            objData.LogDate = config.GetDateTimeUsingLocalZone();
            objData.Save();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void LogFormVersionDownload(int FormVersionID)
        {
            AppConfig config = new AppConfig();
            config.LoadByPrimaryKey(1);
            ManualLog objData = new ManualLog();
            objData.AddNew();
            objData.FromVersionID = int.Parse(FormVersionID.ToString());
            objData.UserID = new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString());
            objData.ActionID = 5;
            objData.LogDate = config.GetDateTimeUsingLocalZone();
            objData.Save();
        }
        
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public void GetFormVersions(int ID)
        {
            FromVersion versions = new FromVersion();
            versions.GetVersionsByFormID(ID, "");

            List<Version> AllVersions = versions.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Version
                {
                    Title = row["Title"].ToString(),
                    IssueNumber = row["IssueNumber"].ToString(),
                    IssueDate = (!row.IsNull("IssueDate")) ? DateTime.Parse(row["IssueDate"].ToString()) : (DateTime?)null,
                    RevisionNumber = row["RevisionNumber"].ToString(),
                    RevisionDate = (!row.IsNull("RevisionDate")) ? DateTime.Parse(row["RevisionDate"].ToString()) : (DateTime?)null,
                    UpdatedByName = row["UpdatedByName"].ToString(),
                    LastUpdatedDate = DateTime.Parse(row["LastUpdatedDate"].ToString()),
                    Path = row["Path"].ToString()
                };

            }).ToList();

            LogFormsVersionsRead(ID);

            UsersNofications usNot = new UsersNofications();
            usNot.MarkNotificationReadByFormVersionID(new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString()), ID);
            SetContentResult(AllVersions);
        }

        private void SetContentResult(dynamic data)
        {
            string result = Newtonsoft.Json.JsonConvert.SerializeObject(data, Formatting.None, new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });
            HttpContext.Current.Response.ContentType = "application/json; charset=utf-8";
            HttpContext.Current.Response.Write(result);
            HttpContext.Current.Response.Flush(); // Sends all currently buffered output to the client.
            HttpContext.Current.Response.SuppressContent = true;  // Gets or sets a value indicating whether to send HTTP content to the client.
            HttpContext.Current.ApplicationInstance.CompleteRequest(); // Causes ASP.NET to bypass all events and filtering in the HTTP pipeline chain of execution and directly execute the EndRequest event.
        }

        private void LogScheduleVersionsView()
        {
            AppConfig config = new AppConfig();
            config.LoadByPrimaryKey(1);
            UsersNofications objData = new UsersNofications();
            objData.getUnreadSchedulesVersionsByUserID(new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString()));
            if (objData.RowCount > 0)
            {
                objData.Rewind();
                for (int i = 0; i < objData.RowCount; i++)
                {
                    ScheduleVersion sversion = new ScheduleVersion();
                    if (sversion.LoadByPrimaryKey(objData.ScheduleVersionID))
                    {
                        ScheduleLog objDataSchedule = new ScheduleLog();
                        objDataSchedule.AddNew();
                        objDataSchedule.UserID = new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString());
                        objDataSchedule.ScheduleVersionID = objData.ScheduleVersionID;
                        objDataSchedule.ActionID = 4;
                        objDataSchedule.LogDate = config.GetDateTimeUsingLocalZone();
                        objDataSchedule.Save();
                    }

                    objData.MoveNext();
                }
            }
        }

        public void LogManualsVersionsRead(int ManualID)
        {
            AppConfig config = new AppConfig();
            config.LoadByPrimaryKey(1);
            UsersNofications objData = new UsersNofications();
            objData.getUnreadManualsVersionsByUserIDAndManualID(new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString()), ManualID);
            if (objData.RowCount > 0)
            {
                objData.Rewind();
                for (int i = 0; i < objData.RowCount; i++)
                {
                    ManualVersion manualversion = new ManualVersion();
                    if (manualversion.LoadByPrimaryKey(objData.ManualVersionID))
                    {
                        ManualLog objDataManual = new ManualLog();
                        objDataManual.AddNew();
                        objDataManual.UserID = new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString());
                        objDataManual.ManualVersionID = objData.ManualVersionID;
                        objDataManual.ActionID = 4;
                        objDataManual.LogDate = config.GetDateTimeUsingLocalZone();
                        objDataManual.Save();
                    }

                    objData.MoveNext();
                }
            }
        }

        public void LogFormsVersionsRead(int FormID)
        {
            AppConfig config = new AppConfig();
            config.LoadByPrimaryKey(1);
            UsersNofications objData = new UsersNofications();
            objData.getUnreadFormsVersionsByUserIDAndFormID(new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString()), FormID);
            if (objData.RowCount > 0)
            {
                objData.Rewind();
                for (int i = 0; i < objData.RowCount; i++)
                {
                    FromVersion formversion = new FromVersion();
                    if (formversion.LoadByPrimaryKey(objData.FromVersionID))
                    {
                        ManualLog objDataManual = new ManualLog();
                        objDataManual.AddNew();
                        objDataManual.UserID = new Guid(Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString());
                        objDataManual.FromVersionID = objData.FromVersionID;
                        objDataManual.ActionID = 4;
                        objDataManual.LogDate = config.GetDateTimeUsingLocalZone();
                        objDataManual.Save();
                    }
                    objData.MoveNext();
                }
            }
        }

    }

    public class NameListDetails
    {
        public string label { get; set; }
        public string value  { get; set; }
        public Guid UserID { get; set; }
    }

    public class Version 
    {
        public string Title { get; set; }
        public string IssueNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string RevisionNumber { get; set; }
        public DateTime? RevisionDate { get; set; }
        public string UpdatedByName { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string Path { get; set; }

    }
}