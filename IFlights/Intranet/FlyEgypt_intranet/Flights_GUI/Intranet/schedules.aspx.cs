using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Flight_BLL;
using System.Web.Security;

namespace Flights_GUI.Intranet
{
    public partial class schedules : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Master.PageTitle = "Schedules";
                BindData();
                LogScheduleView();
                MarkNotificationsAsRead();
            }
        }

        private void LogScheduleView()
        {
            AppConfig config = new AppConfig();
            config.LoadByPrimaryKey(1);
            UsersNofications objData = new UsersNofications();
            objData.getUnreadSchedulesByUserID(new Guid(Membership.GetUser(Page.User.Identity.Name).ProviderUserKey.ToString()));
            if (objData.RowCount >0)
            {
                objData.Rewind();
                for (int i = 0; i < objData.RowCount; i++)
                {
                    ScheduleLog objDataSchedule = new ScheduleLog();
                    objDataSchedule.AddNew();
                    objDataSchedule.UserID = new Guid(Membership.GetUser(Page.User.Identity.Name).ProviderUserKey.ToString());
                    objDataSchedule.ScheduleID = objData.ScheduleID;
                    objDataSchedule.ActionID = 4;
                    objDataSchedule.LogDate = config.GetDateTimeUsingLocalZone();
                    objDataSchedule.Save();

                    objData.MoveNext();
                }
            }
        }

        protected void uiRadGridmanuals_PageIndexChanged(object sender, Telerik.Web.UI.GridPageChangedEventArgs e)
        {
            uiRadGridmanuals.CurrentPageIndex = e.NewPageIndex;
            BindData();
        }
        private void BindData()
        {
            DateTime DateFrom, DateTo;
            if (!DateTime.TryParseExact(txtDateFrom.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateFrom))
                DateFrom = Convert.ToDateTime("01/01/1900");
            if (!DateTime.TryParseExact(txtDateTo.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTo))
                DateTo = Convert.ToDateTime("01/01/2500");

            Schedule objdata = new Schedule();
            objdata.GetSchedulesByUserID(new Guid(Membership.GetUser().ProviderUserKey.ToString()),txtSearch.Text,DateFrom,DateTo);
            uiRadGridmanuals.DataSource = objdata.DefaultView;
            uiRadGridmanuals.DataBind();
        }

        protected void MarkNotificationsAsRead()
        {
            UsersNofications userNotif = new UsersNofications();
            //userNotif.MarkNotificationsReadByNotificationType((new Guid(Membership.GetUser(Page.User.Identity.Name).ProviderUserKey.ToString())), 8);
            userNotif.MarkSchedulesNotificationsRead((new Guid(Membership.GetUser(Page.User.Identity.Name).ProviderUserKey.ToString())), 8);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}