using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COMBO_BLL;

namespace ComboPortal.Admin
{
    public partial class UserManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Master.PageTitle = "ادارة المستخدمين";
                bindRanks();

                ComboUser objData = new ComboUser();
                objData.getAllUsers();
                GridViewUsers.DataSource = objData.DefaultView;
                GridViewUsers.DataBind();
            }
        }
        protected void btnSearchUser_Click(object sender, EventArgs e)
        {
            ComboUser objData = new ComboUser();
            if (string.IsNullOrWhiteSpace(txtSearch.Text) && DropDownUserRank.SelectedValue == "0")
                objData.getAllUsers();
            else
                objData.getUsersSearch(txtSearch.Text, int.Parse(DropDownUserRank.SelectedValue));

            GridViewUsers.DataSource = objData.DefaultView;
            GridViewUsers.DataBind();
        }
        protected void bindRanks()
        {
            UserRank objData = new UserRank();
            objData.LoadAll();
            DropDownUserRank.DataTextField = UserRank.ColumnNames.Name;
            DropDownUserRank.DataValueField = UserRank.ColumnNames.UserRankID;

            DropDownUserRank.DataSource = objData.DefaultView;
            DropDownUserRank.DataBind();

            DropDownUserRank.Items.Insert(0, new ListItem("All Ranks", "0"));
        }
        protected void GridViewUsers_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                //case "viewPosts":
                //    CurrentUser = int.Parse(e.CommandArgument.ToString());
                //    bindPosts();
                //    PanelSearch.Visible = false;
                //    PanelResetPass.Visible = false;
                //    PanelPosts.Visible = true;
                //    break;

                //case "resetPass":
                //    CurrentUser = int.Parse(e.CommandArgument.ToString());
                //    PanelSearch.Visible = false;
                //    PanelResetPass.Visible = true;
                //    PanelPosts.Visible = false;
                //    break;

                //case "banAccount":
                //    ComboUser objData = new ComboUser();
                //    objData.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                //    //objData.IsActivated = false;
                //    //objData.IsDeactivated = true;
                //    objData.Save();
                //    btnSearchUser_Click(sender, e);
                //    break;

                case "deleteAccount":
                    ComboUser objData2 = new ComboUser();
                    objData2.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                    //objData.IsActivated = false;
                    //objData.IsDeactivated = true;
                    objData2.Save();
                    btnSearchUser_Click(sender, e);
                    break;

                default:
                    break;
            }
        }
    }
}