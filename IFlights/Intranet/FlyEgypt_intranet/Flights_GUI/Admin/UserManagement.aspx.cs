using Flight_BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Flights_GUI.Admin
{
    public partial class UserManagement : System.Web.UI.Page
    {

        #region Properties
        public bool IsSearch
        {
            get
            {
                if (Session["IsSearch"] != null)
                    return (bool)Session["IsSearch"];
                else
                    return false;
            }
            set
            {
                Session["IsSearch"] = value;
            }

        }

        public MembershipUser CurrentUser
        {
            get
            {
                if (Session["_CurrentUser"] != null)
                    return (MembershipUser)Session["_CurrentUser"];
                else
                    return null;
            }
            set
            {
                Session["_CurrentUser"] = value;
            }

        }
        #endregion

        #region Events
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRoles();
                BindData();
                loadGroups();
                uiPanelAll.Visible = true;
                uiPanelEdit.Visible = false;
                Master.PageTitle = "User Management";
            }
        }


        protected void uiButtonSearch_Click(object sender, EventArgs e)
        {
            SearchByText();
        }


        protected void uiRadGridUsers_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            if (e.CommandName == "EditUser")
            {
                MembershipUser ObjData = Membership.GetUser(e.CommandArgument.ToString());
                uiTextBoxUserName.Text = ObjData.UserName;
                uiTextBoxUserName.Enabled = false;
                if(!ObjData.IsLockedOut)
                    uiTextBoxPass.Text = ObjData.GetPassword();
                //uiTextBoxPass.Enabled = false;
               // uiCheckBoxIsLocked.Checked = ObjData.IsLockedOut;
                RequiredFieldValidator2.Enabled = false;
                RequiredFieldValidator6.Enabled = false;
                CompareValidator1.Enabled = false;
                uiTextBoxConfirm.Enabled = false;
                //uiLinkButtonEditPassword.Enabled = true;
                //uiTextBoxMail.Text = ObjData.Email;
                foreach (string role in Roles.GetRolesForUser(ObjData.UserName))
                {
                    foreach (ListItem item in uiCheckBoxListRoles.Items)
                    {
                        if (role == item.Text)
                        {
                            item.Selected = true;
                            break;
                        }
                    }
                }
                uiPanelEdit.Visible = true;
                uiPanelAll.Visible = false;

                UsersProfiles usPr = new UsersProfiles();
                usPr.getUserByGUID(new Guid(ObjData.ProviderUserKey.ToString()));
                txtFullName.Text = usPr.FullName;
                txtEmail.Text = usPr.Email;
                txtTelephone.Text = usPr.Telephone;
                if (!usPr.IsColumnNull(UsersProfiles.ColumnNames.Photo))
                    userImg.Src = usPr.Photo;

                UserGroup groups = new UserGroup();
                groups.GetUserGroups(new Guid(ObjData.ProviderUserKey.ToString()));

                /*if (!usPr.IsColumnNull(UsersProfiles.ColumnNames.GroupID))
                    DropDownListGroups.SelectedValue = usPr.GroupID.ToString();*/
                if (groups.RowCount > 0)
                {
                    for (int i = 0; i < groups.RowCount; i++)
                    {
                        foreach (ListItem item in uiCheckBoxListGroups.Items)
                        {
                            if (groups.GroupId.ToString() == item.Value)
                            {
                                item.Selected = true;
                                break;
                            }
                            
                        }
                        groups.MoveNext();
                    }
                }

                CurrentUser = ObjData;

            }
            else if (e.CommandName == "DeleteUser")
            {
                MembershipUser ObjData = Membership.GetUser(e.CommandArgument.ToString());
                if (ObjData != null)
                {
                    UsersProfiles usPr = new UsersProfiles();
                    usPr.getUserByGUID(new Guid(ObjData.ProviderUserKey.ToString()));

                    UserGroup groups = new UserGroup();
                    groups.GetUserGroups(new Guid(ObjData.ProviderUserKey.ToString()));
                    groups.DeleteAll();
                    groups.Save();

                    usPr.MarkAsDeleted();
                    usPr.Save();

                    Membership.DeleteUser(ObjData.UserName, true);
                }
                BindData();
            }
            else if (e.CommandName == "UnlockUser")
            {
                MembershipUser ObjData = Membership.GetUser(e.CommandArgument.ToString());
                if (ObjData != null)
                {
                    ObjData.UnlockUser();
                }
                BindData();
            }
        }

       

        protected void uiButtonUpdate_Click(object sender, EventArgs e)
        {
            if (CurrentUser != null)
            {
                //CurrentUser.Email = uiTextBoxMail.Text;
                List<string> stringListToAdd = new List<string>();
                List<string> stringListToRemove = new List<string>();
                
                if (!CurrentUser.IsLockedOut)
                {
                    if (CurrentUser.GetPassword() != uiTextBoxPass.Text && !string.IsNullOrEmpty(uiTextBoxPass.Text))
                    {
                        CurrentUser.ChangePassword(CurrentUser.GetPassword(), uiTextBoxPass.Text);
                    }
                }

                foreach (ListItem item in uiCheckBoxListRoles.Items)
                {
                    if (item.Selected)
                    {
                        if (!Roles.IsUserInRole(CurrentUser.UserName, item.Text))
                        {
                            stringListToAdd.Add(item.Text);
                        }
                    }
                    else
                    {
                        if (Roles.IsUserInRole(CurrentUser.UserName, item.Text))
                        {
                            stringListToRemove.Add(item.Text);
                        }
                    }
                }

                string[] stringArrayToAdd = stringListToAdd.ToArray();
                string[] stringArrayToRemove = stringListToRemove.ToArray();
                if (stringArrayToAdd.Length > 0)
                    Roles.AddUserToRoles(CurrentUser.UserName, stringArrayToAdd);
                if (stringArrayToRemove.Length > 0)
                    Roles.RemoveUserFromRoles(CurrentUser.UserName, stringArrayToRemove);

                // 
                UsersProfiles usPr = new UsersProfiles();
                usPr.getUserByGUID(new Guid(CurrentUser.ProviderUserKey.ToString()));

                usPr.FullName = txtFullName.Text;
                usPr.Email = txtEmail.Text;
                usPr.Telephone = txtTelephone.Text;
                //usPr.GroupID = int.Parse(DropDownListGroups.SelectedValue);

                UserGroup oldGroups = new UserGroup();
                oldGroups.GetUserGroups(new Guid(CurrentUser.ProviderUserKey.ToString()));
                oldGroups.DeleteAll();
                oldGroups.Save();

                UserGroup newAnnGroup = new UserGroup();
                foreach (ListItem item in uiCheckBoxListGroups.Items)
                {
                    
                    if (item.Selected)
                    {
                       
                        newAnnGroup.AddNew();
                        newAnnGroup.UserId = new Guid(CurrentUser.ProviderUserKey.ToString());
                        newAnnGroup.GroupId = int.Parse(item.Value);
                        
                    }
                }
                newAnnGroup.Save();

                if (fileUploadPhoto.HasFile)
                {
                    Bitmap UpImg = (Bitmap)Bitmap.FromStream(fileUploadPhoto.PostedFile.InputStream);
                    string path = "/FileUploads/ProfilePics/" + DateTime.Now.ToString("ddMMyyyyhhmmss") + fileUploadPhoto.FileName;
                    UpImg.Save(MapPath(path), System.Drawing.Imaging.ImageFormat.Png);
                    usPr.Photo= path;
                }
                usPr.Save();
            }
            else
            {
                List<string> stringListToAdd = new List<string>();
                MembershipCreateStatus obj;
                MembershipUser objUser = Membership.CreateUser(uiTextBoxUserName.Text, uiTextBoxPass.Text, "dummy@example.com", null, null, true, out obj);
                bool success = true;
                switch (obj)
                {
                    case MembershipCreateStatus.DuplicateUserName:
                        uiLabelError.Text = "duplicate username";
                        uiLabelError.Visible = true;
                        success = false;
                        break;
                    case MembershipCreateStatus.InvalidPassword:
                        uiLabelError.Text = "invalid password. password must be (6) characters or more.";
                        uiLabelError.Visible = true;
                        success = false;
                        break;
                    case MembershipCreateStatus.ProviderError:
                    case MembershipCreateStatus.UserRejected:
                        uiLabelError.Text = "an error occurred. please try again.";
                        uiLabelError.Visible = true;
                        success = false;
                        break;
                    default:
                        break;
                }
                if (success)
                {
                    foreach (ListItem item in uiCheckBoxListRoles.Items)
                    {
                        if (item.Selected)
                        {
                            if (!Roles.IsUserInRole(objUser.UserName, item.Text))
                            {
                                stringListToAdd.Add(item.Text);
                            }
                        }
                    }
                    string[] stringArrayToAdd = stringListToAdd.ToArray();
                    if (stringArrayToAdd.Length > 0)
                        Roles.AddUserToRoles(objUser.UserName, stringArrayToAdd);

                    // 

                    UsersProfiles usPr = new UsersProfiles();
                    usPr.AddNew();
                    usPr.UserID = new Guid(objUser.ProviderUserKey.ToString());
                    usPr.FullName = txtFullName.Text;
                    usPr.Email = txtEmail.Text;
                    usPr.Telephone = txtTelephone.Text;
                    //usPr.GroupID = int.Parse(DropDownListGroups.SelectedValue);

                    UserGroup newAnnGroup = new UserGroup();
                    foreach (ListItem item in uiCheckBoxListGroups.Items)
                    {

                        if (item.Selected)
                        {

                            newAnnGroup.AddNew();
                            newAnnGroup.UserId = new Guid(objUser.ProviderUserKey.ToString());
                            newAnnGroup.GroupId = int.Parse(item.Value);

                        }
                    }
                    newAnnGroup.Save();

                    if (fileUploadPhoto.HasFile)
                    {
                        Bitmap UpImg = (Bitmap)Bitmap.FromStream(fileUploadPhoto.PostedFile.InputStream);
                        string path = "/FileUploads/ProfilePics/" + DateTime.Now.ToString("ddMMyyyyhhmmss") + fileUploadPhoto.FileName;
                        UpImg.Save(MapPath(path), System.Drawing.Imaging.ImageFormat.Png);
                        usPr.Photo = path;
                    }
                    usPr.Save();
                }
            }
            uiPanelEdit.Visible = false;
            
            uiPanelAll.Visible = true;
            ClearFields();
            CurrentUser = null;
            BindData();

        }

        protected void uiButtonCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            uiPanelEdit.Visible = false;
            uiPanelAll.Visible = true;            
            CurrentUser = null;
        }



        protected void uiLinkButtonAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            uiPanelAll.Visible = false;
            uiPanelEdit.Visible = true;
            RequiredFieldValidator6.Enabled = false;
            RequiredFieldValidator2.Enabled = true;
            CompareValidator1.Enabled = true;
            CurrentUser = null;
        }


        protected void uiRadGridUsers_PageIndexChanged(object sender, Telerik.Web.UI.GridPageChangedEventArgs e)
        {
            uiRadGridUsers.CurrentPageIndex = e.NewPageIndex;
            SearchByText();
        }

        protected void uiRadGridUsers_PageSizeChanged(object sender, Telerik.Web.UI.GridPageSizeChangedEventArgs e)
        {
            uiRadGridUsers.PageSize = e.NewPageSize;
            SearchByText();
        }

        #endregion

        #region Methods

        private void BindData()
        {
            SearchByText();
        }

        private void LoadRoles()
        {
            uiCheckBoxListRoles.DataSource = Roles.GetAllRoles();
            uiCheckBoxListRoles.DataBind();

        }

        private void SearchByText()
        {
            UsersProfiles up = new UsersProfiles();
            up.SearchByText(uiTextBoxSearch.Text);
            uiRadGridUsers.DataSource = up.DefaultView;
            uiRadGridUsers.DataBind();
        }

        private void ClearFields()
        {
            uiTextBoxUserName.Text = "";
            uiTextBoxPass.Text = "";
            uiTextBoxConfirm.Text = "";            
            RequiredFieldValidator2.Enabled = true;
            CompareValidator1.Enabled = true;
            uiTextBoxUserName.Enabled = true;
            uiTextBoxPass.Enabled = true;
            uiTextBoxConfirm.Enabled = true;
            //uiLinkButtonEditPassword.Enabled = false;
            uiCheckBoxListRoles.ClearSelection();
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtTelephone.Text = "";
            //DropDownListGroups.SelectedIndex = 0;
            uiCheckBoxListGroups.ClearSelection();
            userImg.Src = "../img/noImg.gif";
        }

        private void loadGroups()
        {
            /*Groups grps = new Groups();
            grps.LoadAll();
            DropDownListGroups.DataSource = grps.DefaultView;
            DropDownListGroups.DataTextField = Groups.ColumnNames.GroupName.ToString();
            DropDownListGroups.DataValueField = Groups.ColumnNames.GroupID.ToString();
            DropDownListGroups.DataBind();*/


            Groups groups = new Groups();
            groups.LoadAll();
            uiCheckBoxListGroups.DataSource = groups.DefaultView;
            uiCheckBoxListGroups.DataTextField = Groups.ColumnNames.GroupName;
            uiCheckBoxListGroups.DataValueField = Groups.ColumnNames.GroupID;
            uiCheckBoxListGroups.DataBind();
        }
        #endregion

        

       
    }
}