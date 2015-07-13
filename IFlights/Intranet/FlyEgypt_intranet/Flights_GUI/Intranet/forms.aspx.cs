using Flight_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Flights_GUI.Intranet
{
    public partial class forms : System.Web.UI.Page
    {
        public int currentManualCat
        {
            get
            {
                object o = this.ViewState["_currentManualCat"];
                if (o == null)
                    return 0;
                else
                    return (int)o;
            }
            set
            {
                this.ViewState["_currentManualCat"] = value;
            }
        }

        public int CurrentManual
        {
            get 
            {
                int d = 0;
                if (Request.QueryString["mid"] != null)
                {
                    
                    int.TryParse(Request.QueryString["mid"].ToString(), out d);
                }
                return d;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {                
                Master.PageTitle = "Forms";
                if (CurrentManual != 0)
                {
                    Manual m = new Manual();
                    if (m.LoadByPrimaryKey(CurrentManual))
                        uiLabelModule.Text = m.Title;
                    else
                        Response.Redirect("Manuals.aspx");

                    //LogFormsRead(CurrentManual);
                }
                else
                    Response.Redirect("Manuals.aspx");

                BindData();
            }
            LogForms();
            MarkNotificationsAsRead();
        }

        //private void LogFormsRead(int ID)
        //{
        //    ManualLog objData = new ManualLog();
        //    objData.AddNew();
        //    objData.ManualID = ID;
        //    objData.UserID = new Guid(Membership.GetUser(Page.User.Identity.Name).ProviderUserKey.ToString());
        //    objData.ActionID = 4;
        //    objData.LogDate = DateTime.Now;
        //    objData.Save();
        //}

        protected void uiRadGridmanuals_PageIndexChanged(object sender, Telerik.Web.UI.GridPageChangedEventArgs e)
        {
            uiRadGridmanuals.CurrentPageIndex = e.NewPageIndex;
            BindData();
        }

        private void LogForms()
        {
            AppConfig config = new AppConfig();
            config.LoadByPrimaryKey(1);
            UsersNofications objData = new UsersNofications();
            objData.getUnreadFormsByUserIDAndManualID(new Guid(Membership.GetUser(Page.User.Identity.Name).ProviderUserKey.ToString()),CurrentManual);
            if (objData.RowCount > 0)
            {
                objData.Rewind();
                for (int i = 0; i < objData.RowCount; i++)
                {
                    ManualLog objDataSchedule = new ManualLog();
                    objDataSchedule.AddNew();
                    objDataSchedule.UserID = new Guid(Membership.GetUser(Page.User.Identity.Name).ProviderUserKey.ToString());
                    objDataSchedule.ManualFormID = objData.FormID;
                    objDataSchedule.ActionID = 4;
                    objDataSchedule.LogDate = config.GetDateTimeUsingLocalZone();
                    objDataSchedule.Save();

                    objData.MoveNext();
                }
            }
        }

        private void BindData()
        {
            ManualForm objdata = new ManualForm();
            objdata.GetFormsByManualID(CurrentManual, new Guid(Membership.GetUser().ProviderUserKey.ToString()));
            uiRadGridmanuals.DataSource = objdata.DefaultView;
            uiRadGridmanuals.DataBind();

        }

        protected void MarkNotificationsAsRead()
        {
            UsersNofications userNotif = new UsersNofications();
            userNotif.MarkNotificationReadByFormID((new Guid(Membership.GetUser(Page.User.Identity.Name).ProviderUserKey.ToString())),CurrentManual);
        }
    }
}