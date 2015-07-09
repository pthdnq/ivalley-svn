using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Flights_GUI.BI
{
    public partial class reporting : System.Web.UI.Page
    {
        public string Type
        {
            get 
            {
                if (Request.QueryString["t"] != null)
                {
                    return Request.QueryString["t"].ToString();
                }
                else
                    return null;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Master.PageTitle = "Reports";
                if(!string.IsNullOrEmpty(Type))
                    viewReport();
            }
        }

        private void viewReport()
        {
            IntranetDSTableAdapters.GetAppConfigTableAdapter appsettings = new IntranetDSTableAdapters.GetAppConfigTableAdapter();
            Microsoft.Reporting.WebForms.ReportDataSource settingsrds = new Microsoft.Reporting.WebForms.ReportDataSource();
            appsettings.ClearBeforeFill = true;
            settingsrds.Name = "AppConfigDataSet";
            settingsrds.Value = appsettings.GetData();

            switch (Type)
            {
                case "a": // announcement
                    Microsoft.Reporting.WebForms.ReportDataSource AnnouncementLogDetails = new Microsoft.Reporting.WebForms.ReportDataSource();
                    Microsoft.Reporting.WebForms.ReportDataSource announcement = new Microsoft.Reporting.WebForms.ReportDataSource();

                    IntranetDSTableAdapters.GetAnnouncementByIDTableAdapter ann = new IntranetDSTableAdapters.GetAnnouncementByIDTableAdapter();
                    IntranetDSTableAdapters.GetAnnouncementLogReportTableAdapter log = new IntranetDSTableAdapters.GetAnnouncementLogReportTableAdapter();
                    IntranetDSTableAdapters.GetAnnouncementLogReportForGroupTableAdapter logforgroup = new IntranetDSTableAdapters.GetAnnouncementLogReportForGroupTableAdapter();

                    Flight_BLL.AnnouncementGroup objdata = new Flight_BLL.AnnouncementGroup();
                    objdata.GetGroupsByAnnouncementID(int.Parse(Request.QueryString["aid"].ToString()));
                    

                    log.ClearBeforeFill = true;
                    ann.ClearBeforeFill = true;
                    AnnouncementLogDetails.Name = "LogDetailsDataSet";
                    if (objdata.RowCount > 0)
                        AnnouncementLogDetails.Value = logforgroup.GetData(int.Parse(Request.QueryString["aid"].ToString()));
                    else
                        AnnouncementLogDetails.Value = log.GetData(int.Parse(Request.QueryString["aid"].ToString()));
                    announcement.Name = "AnnouncementDataSet";
                    announcement.Value = ann.GetData(int.Parse(Request.QueryString["aid"].ToString()));

                    uiReportViewer.LocalReport.DataSources.Clear();
                    uiReportViewer.LocalReport.DataSources.Add(settingsrds);
                    uiReportViewer.LocalReport.DataSources.Add(AnnouncementLogDetails);
                    uiReportViewer.LocalReport.DataSources.Add(announcement);

                    uiReportViewer.LocalReport.ReportPath = @"Reports\intranet\announcementreport.rdlc";
                    uiReportViewer.LocalReport.Refresh();
                    break;
                case "m": // manuals
                    Microsoft.Reporting.WebForms.ReportDataSource ManualLogDetails = new Microsoft.Reporting.WebForms.ReportDataSource();
                    Microsoft.Reporting.WebForms.ReportDataSource ManualDS = new Microsoft.Reporting.WebForms.ReportDataSource();

                    if (Request.QueryString["mvid"] == null)
                    {

                        IntranetDSTableAdapters.GetManualByIDTableAdapter manual = new IntranetDSTableAdapters.GetManualByIDTableAdapter();
                        IntranetDSTableAdapters.GetManualLogReportTableAdapter manuallog = new IntranetDSTableAdapters.GetManualLogReportTableAdapter();

                        manual.ClearBeforeFill = true;
                        manuallog.ClearBeforeFill = true;
                        ManualLogDetails.Name = "LogDetailsDataSet";
                        ManualLogDetails.Value = manuallog.GetData(int.Parse(Request.QueryString["mid"].ToString()));
                        ManualDS.Name = "ManualDataSet";
                        ManualDS.Value = manual.GetData(int.Parse(Request.QueryString["mid"].ToString()));

                        uiReportViewer.LocalReport.DataSources.Clear();
                        uiReportViewer.LocalReport.DataSources.Add(settingsrds);
                        uiReportViewer.LocalReport.DataSources.Add(ManualLogDetails);
                        uiReportViewer.LocalReport.DataSources.Add(ManualDS);

                        uiReportViewer.LocalReport.ReportPath = @"Reports\intranet\manualreport.rdlc";
                    }
                    else
                    {
                        IntranetDSTableAdapters.GetManualVersionByIDTableAdapter manual = new IntranetDSTableAdapters.GetManualVersionByIDTableAdapter();
                        IntranetDSTableAdapters.GetManualVersionLogReportTableAdapter manuallog = new IntranetDSTableAdapters.GetManualVersionLogReportTableAdapter();

                        manual.ClearBeforeFill = true;
                        manuallog.ClearBeforeFill = true;
                        ManualLogDetails.Name = "LogDetailsDataSet";
                        ManualLogDetails.Value = manuallog.GetData(int.Parse(Request.QueryString["mvid"].ToString()));
                        ManualDS.Name = "ManualVersionDataSet";
                        ManualDS.Value = manual.GetData(int.Parse(Request.QueryString["mvid"].ToString()));

                        uiReportViewer.LocalReport.DataSources.Clear();
                        uiReportViewer.LocalReport.DataSources.Add(settingsrds);
                        uiReportViewer.LocalReport.DataSources.Add(ManualLogDetails);
                        uiReportViewer.LocalReport.DataSources.Add(ManualDS);

                        uiReportViewer.LocalReport.ReportPath = @"Reports\intranet\manualversionreport.rdlc";
                    }
                    uiReportViewer.LocalReport.Refresh();
                    break;
                case "f": // forms
                    Microsoft.Reporting.WebForms.ReportDataSource FormLogDetails = new Microsoft.Reporting.WebForms.ReportDataSource();
                    Microsoft.Reporting.WebForms.ReportDataSource FormDS = new Microsoft.Reporting.WebForms.ReportDataSource();

                    if (Request.QueryString["fvid"] == null)
                    {

                        IntranetDSTableAdapters.GetFormByIDTableAdapter form = new IntranetDSTableAdapters.GetFormByIDTableAdapter();
                        IntranetDSTableAdapters.GetFormLogReportTableAdapter formlog = new IntranetDSTableAdapters.GetFormLogReportTableAdapter();

                        form.ClearBeforeFill = true;
                        formlog.ClearBeforeFill = true;
                        FormLogDetails.Name = "LogDetailsDataSet";
                        FormLogDetails.Value = formlog.GetData(int.Parse(Request.QueryString["fid"].ToString()));
                        FormDS.Name = "FormDataSet";
                        FormDS.Value = form.GetData(int.Parse(Request.QueryString["fid"].ToString()));

                        uiReportViewer.LocalReport.DataSources.Clear();
                        uiReportViewer.LocalReport.DataSources.Add(settingsrds);
                        uiReportViewer.LocalReport.DataSources.Add(FormLogDetails);
                        uiReportViewer.LocalReport.DataSources.Add(FormDS);

                        uiReportViewer.LocalReport.ReportPath = @"Reports\intranet\formreport.rdlc";
                    }
                    else
                    {
                        IntranetDSTableAdapters.GetFormVersionByIDTableAdapter form = new IntranetDSTableAdapters.GetFormVersionByIDTableAdapter();
                        IntranetDSTableAdapters.GetFormVersionLogReportTableAdapter formlog = new IntranetDSTableAdapters.GetFormVersionLogReportTableAdapter();

                        form.ClearBeforeFill = true;
                        formlog.ClearBeforeFill = true;
                        FormLogDetails.Name = "LogDetailsDataSet";
                        FormLogDetails.Value = formlog.GetData(int.Parse(Request.QueryString["fvid"].ToString()));
                        FormDS.Name = "FormVersionDataSet";
                        FormDS.Value = form.GetData(int.Parse(Request.QueryString["fvid"].ToString()));

                        uiReportViewer.LocalReport.DataSources.Clear();
                        uiReportViewer.LocalReport.DataSources.Add(settingsrds);
                        uiReportViewer.LocalReport.DataSources.Add(FormLogDetails);
                        uiReportViewer.LocalReport.DataSources.Add(FormDS);

                        uiReportViewer.LocalReport.ReportPath = @"Reports\intranet\FormVersionreport.rdlc";
                    }
                    uiReportViewer.LocalReport.Refresh();
                    break;
                case "s": // schedules
                    Microsoft.Reporting.WebForms.ReportDataSource ScheduleLogDetails = new Microsoft.Reporting.WebForms.ReportDataSource();
                    Microsoft.Reporting.WebForms.ReportDataSource ScheduleDS = new Microsoft.Reporting.WebForms.ReportDataSource();

                    if (Request.QueryString["svid"] == null)
                    {

                        IntranetDSTableAdapters.GetScheduleByIDTableAdapter schedule = new IntranetDSTableAdapters.GetScheduleByIDTableAdapter();
                        IntranetDSTableAdapters.GetScheduleLogReportTableAdapter schedulelog = new IntranetDSTableAdapters.GetScheduleLogReportTableAdapter();

                        schedule.ClearBeforeFill = true;
                        schedulelog.ClearBeforeFill = true;
                        ScheduleLogDetails.Name = "LogDetailsDataSet";
                        ScheduleLogDetails.Value = schedulelog.GetData(int.Parse(Request.QueryString["sid"].ToString()));
                        ScheduleDS.Name = "ScheduleDataSet";
                        ScheduleDS.Value = schedule.GetData(int.Parse(Request.QueryString["sid"].ToString()));

                        uiReportViewer.LocalReport.DataSources.Clear();
                        uiReportViewer.LocalReport.DataSources.Add(settingsrds);
                        uiReportViewer.LocalReport.DataSources.Add(ScheduleLogDetails);
                        uiReportViewer.LocalReport.DataSources.Add(ScheduleDS);

                        uiReportViewer.LocalReport.ReportPath = @"Reports\intranet\schedulereport.rdlc";
                    }
                    else
                    {
                        IntranetDSTableAdapters.GetScheduleVersionByIDTableAdapter schedule = new IntranetDSTableAdapters.GetScheduleVersionByIDTableAdapter();
                        IntranetDSTableAdapters.GetScheduleVersionLogReportTableAdapter schedulelog = new IntranetDSTableAdapters.GetScheduleVersionLogReportTableAdapter();

                        schedule.ClearBeforeFill = true;                        
                        schedulelog.ClearBeforeFill = true;
                        ScheduleLogDetails.Name = "LogDetailsDataSet";
                        ScheduleLogDetails.Value = schedulelog.GetData(int.Parse(Request.QueryString["svid"].ToString()));
                        ScheduleDS.Name = "ScheduleVersionDataSet";
                        ScheduleDS.Value = schedule.GetData(int.Parse(Request.QueryString["svid"].ToString()));

                        uiReportViewer.LocalReport.DataSources.Clear();
                        uiReportViewer.LocalReport.DataSources.Add(settingsrds);
                        uiReportViewer.LocalReport.DataSources.Add(ScheduleLogDetails);
                        uiReportViewer.LocalReport.DataSources.Add(ScheduleDS);

                        uiReportViewer.LocalReport.ReportPath = @"Reports\intranet\ScheduleVersionreport.rdlc";
                    }
                    uiReportViewer.LocalReport.Refresh();
                    break;
                case "c": // certificates
                    Microsoft.Reporting.WebForms.ReportDataSource CertificateLogDetails = new Microsoft.Reporting.WebForms.ReportDataSource();
                    Microsoft.Reporting.WebForms.ReportDataSource CertificateDS = new Microsoft.Reporting.WebForms.ReportDataSource();

                    IntranetDSTableAdapters.GetCertificateByIDTableAdapter certificate = new IntranetDSTableAdapters.GetCertificateByIDTableAdapter();
                    IntranetDSTableAdapters.GetCertificateLogReportTableAdapter certificatelog = new IntranetDSTableAdapters.GetCertificateLogReportTableAdapter();

                    certificate.ClearBeforeFill = true;
                    certificatelog.ClearBeforeFill = true;
                    CertificateLogDetails.Name = "LogDetailsDataSet";
                    CertificateLogDetails.Value = certificatelog.GetData(int.Parse(Request.QueryString["cid"].ToString()));
                    CertificateDS.Name = "CertificateDataSet";
                    CertificateDS.Value = certificate.GetData(int.Parse(Request.QueryString["cid"].ToString()));

                    uiReportViewer.LocalReport.DataSources.Clear();
                    uiReportViewer.LocalReport.DataSources.Add(settingsrds);
                    uiReportViewer.LocalReport.DataSources.Add(CertificateLogDetails);
                    uiReportViewer.LocalReport.DataSources.Add(CertificateDS);

                    uiReportViewer.LocalReport.ReportPath = @"Reports\intranet\certificatereport.rdlc";
                    uiReportViewer.LocalReport.Refresh();
                    break;
                default:
                    break;
            }
        }

        protected void uiLinkButtonViewReport_Click(object sender, EventArgs e)
        {
            IntranetDSTableAdapters.GetAppConfigTableAdapter appsettings = new IntranetDSTableAdapters.GetAppConfigTableAdapter();
            Microsoft.Reporting.WebForms.ReportDataSource settingsrds = new Microsoft.Reporting.WebForms.ReportDataSource ();            
            appsettings.ClearBeforeFill = true;
            settingsrds.Name = "AppConfigDataSet";
            settingsrds.Value = appsettings.GetData();

            switch (Reports.SelectedValue)
            {
                case "1":
                    Microsoft.Reporting.WebForms.ReportDataSource Loginrds = new Microsoft.Reporting.WebForms.ReportDataSource();
                    IntranetDSTableAdapters.GetUserLoginReportTableAdapter loginta = new IntranetDSTableAdapters.GetUserLoginReportTableAdapter();
                    loginta.ClearBeforeFill = true;

                    Loginrds.Name = "LoginDataSet";
                    Loginrds.Value = loginta.GetData(new Guid(uiHiddenFieldUserID.Value), uiRadDatePickerFrom.SelectedDate, uiRadDatePickerTo.SelectedDate);
                    uiReportViewer.LocalReport.DataSources.Clear();
                    uiReportViewer.LocalReport.DataSources.Add(settingsrds);
                    uiReportViewer.LocalReport.DataSources.Add(Loginrds);
                    uiReportViewer.LocalReport.ReportPath = @"Reports\intranet\userlogin.rdlc";
                    uiReportViewer.LocalReport.Refresh();
                    break;
                case "2":
                    Microsoft.Reporting.WebForms.ReportDataSource NotLoginrds = new Microsoft.Reporting.WebForms.ReportDataSource();
                    IntranetDSTableAdapters.GetUsersNotLoginReportTableAdapter notloginta = new IntranetDSTableAdapters.GetUsersNotLoginReportTableAdapter();
                    notloginta.ClearBeforeFill = true;
                    int days = 0;
                    int.TryParse(uiTextBoxNoOfDays.Text, out days);
                    NotLoginrds.Name = "UsersNotLoginDataSet";
                    NotLoginrds.Value = notloginta.GetData(days);
                    uiReportViewer.LocalReport.DataSources.Clear();
                    uiReportViewer.LocalReport.DataSources.Add(settingsrds);
                    uiReportViewer.LocalReport.DataSources.Add(NotLoginrds);
                    uiReportViewer.LocalReport.ReportPath = @"Reports\intranet\notloggedusers.rdlc";
                    uiReportViewer.LocalReport.Refresh();
                    break;

                default:
                    break;
            }
            
        }
    }
}