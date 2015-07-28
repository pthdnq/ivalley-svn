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
    public partial class Circulars : System.Web.UI.Page
    {

        public int CurrentAnnouncement
        {
            get
            {
                if (Request.QueryString["cid"] != null)
                {
                    try
                    {
                        return Convert.ToInt32(Request.QueryString["cid"].ToString());
                    }
                    catch (Exception ex)
                    {
                        return 0;
                    }
                }
                return 0;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Master.PageTitle = "Circulars";
                LoadUserGroups();
                if (CurrentAnnouncement == 0)
                {
                    LoadCircularsPublic();
                    //LoadCircularsGroup();
                    uiPanelViewAll.Visible = true;
                    uiPanelCurrent.Visible = false;
                }
                else
                {
                    LoadCurrent();
                    uiPanelViewAll.Visible = false;
                    uiPanelCurrent.Visible = true;
                    LogCircularRead(CurrentAnnouncement);
                }
                MarkNotificationsAsRead();
            }

            UsersProfiles userProf = new UsersProfiles();
            userProf.getUserByGUID(new Guid(Membership.GetUser(Page.User.Identity.Name).ProviderUserKey.ToString()));

           /* Groups grps = new Groups();
            grps.LoadByPrimaryKey(userProf.GroupID);
            lblTabGroup.Text = grps.GroupName + " Circulars";*/
        }

        private void LoadUserGroups()
        {
            UserGroup groups = new UserGroup();
            groups.GetUserGroups(new Guid(Membership.GetUser(Page.User.Identity.Name).ProviderUserKey.ToString()));
            uiDropDownListUserGroups.DataSource = groups.DefaultView;
            uiDropDownListUserGroups.DataTextField = Groups.ColumnNames.GroupName;
            uiDropDownListUserGroups.DataValueField = Groups.ColumnNames.GroupID;
            uiDropDownListUserGroups.DataBind();
            uiDropDownListUserGroups.Items.Insert(0, new ListItem("Public", "0"));
            uiDropDownListUserGroups.Items.Insert(0, new ListItem("Select group...", "-1"));
            
        }
        private void LogCircularRead(int ID)
        {
            AppConfig config = new AppConfig();
            config.LoadByPrimaryKey(1);
            AnnouncementLog objData = new AnnouncementLog();
            objData.AddNew();
            objData.AnnouncementID = ID;
            objData.UserID = new Guid(Membership.GetUser(Page.User.Identity.Name).ProviderUserKey.ToString());
            objData.ActionID = 4;
            objData.LogDate = config.GetDateTimeUsingLocalZone();
            objData.Save();
        }
        private void LoadCurrent()
        {
            Announcement current = new Announcement();

            if (current.LoadByPrimaryKey(CurrentAnnouncement))
            {
                uiLabelTitle.Text = current.Code + " " + current.Title;
                uiLabelDate.Text = current.CreatedDate.ToString("dd MMM yyyy");
                if(!current.IsColumnNull(Announcement.ColumnNames.CreatedBy))
                    uiLabelCreator.Text = Membership.GetUser(new Guid(current.CreatedBy.ToString())).UserName;
                uiLiteralContent.Text = Server.HtmlDecode(current.Content);
                uiImageMain.ImageUrl = string.IsNullOrEmpty(current.MainPic) ? "../img/announcement-icon.png" : current.MainPic;
                if (string.IsNullOrWhiteSpace(current.UploadedFile))
                {
                    btnDownloadAttachment.Visible = false;
                }
                else
                {
                    btnDownloadAttachment.HRef = current.UploadedFile;
                    btnDownloadAttachment.Attributes.Add("download", current.UploadedFile.Substring(current.UploadedFile.LastIndexOf('/') + 1));
                }
            }
        }
        private void LoadCircularsPublic()
        {
            DateTime DateFrom,DateTo;
            if (txtDateFrom.SelectedDate == null)
                DateFrom = Convert.ToDateTime("01/01/1950");
            else
                DateFrom = txtDateFrom.SelectedDate.Value;
            if (txtDateTo.SelectedDate == null)
                DateTo = Convert.ToDateTime("01/01/2500");
            else
                DateTo = txtDateTo.SelectedDate.Value;


            Announcement all = new Announcement();
            if (uiDropDownListUserGroups.SelectedValue == "-1")
                all.GetAllCircularsPublicAndGroups(new Guid(Membership.GetUser(Page.User.Identity.Name).ProviderUserKey.ToString()), txtSearch.Text, DateFrom,DateTo);
            else if (uiDropDownListUserGroups.SelectedValue == "0")
                all.GetAllCircularsPublic(txtSearch.Text,DateFrom,DateTo);
            else
                all.GetAllCircularsGroups(Convert.ToInt32(uiDropDownListUserGroups.SelectedValue), txtSearch.Text,DateFrom,DateTo);
           
            uiRadListViewCircularsPublic.DataSource = all.DefaultView;
            uiRadListViewCircularsPublic.DataBind();
        }
        /*private void LoadCircularsGroup()
        {
            UsersProfiles userProf = new UsersProfiles();
            userProf.getUserByGUID(new Guid(Membership.GetUser(Page.User.Identity.Name).ProviderUserKey.ToString()));

            Announcement all = new Announcement();
            all.GetAllCircularsGroups(userProf.GroupID);
            uiRadListViewCircularsGroup.DataSource = all.DefaultView;
            uiRadListViewCircularsGroup.DataBind();
        }*/
        protected void MarkNotificationsAsRead()
        {
            UsersNofications userNotif = new UsersNofications();
            userNotif.MarkNotificationsReadByNotificationType((new Guid(Membership.GetUser(Page.User.Identity.Name).ProviderUserKey.ToString())),1);
        }
        protected void uiRadListViewCircularsPublic_PageIndexChanged(object sender, Telerik.Web.UI.RadListViewPageChangedEventArgs e)
        {
            uiRadListViewCircularsPublic.CurrentPageIndex = e.NewPageIndex;
            LoadCircularsPublic();
        }

        protected void uiDropDownListUserGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCircularsPublic();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCircularsPublic();
        }


       /* protected void uiRadListViewCircularsGroup_PageIndexChanged(object sender, Telerik.Web.UI.RadListViewPageChangedEventArgs e)
        {
            uiRadListViewCircularsGroup.CurrentPageIndex = e.NewPageIndex;
            LoadCircularsGroup();
        }*/
    }
}