using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TouchMediaGUI.Admin
{
    public partial class ManageClients : System.Web.UI.Page
    {
        public int EditClients
        {
            get
            {
                if (Session["EditClients"] != null)
                {
                    return int.Parse(Session["EditClients"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                Session["EditClients"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                bindData();
            }
        }
        public void bindData()
        {
            Clients AllClients = new Clients();
            AllClients.LoadAll();
            GridViewClients.DataSource = AllClients.DefaultView;
            GridViewClients.DataBind();
        }
        public void ClearFields()
        {

            txtClientCode.Text = "";
            txtClientEmail.Text = "";
            txtClientName.Text = "";
            txtClientTelephone.Text = "";
        }

        protected void btnNewClients_Click(object sender, EventArgs e)
        {
            ClearFields();
            panelClientsGrid.Visible = false;
            panelClientEdit.Visible = true;
        }

        protected void GridViewClients_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editClient")
            {
                Clients EdCli = new Clients();
                EdCli.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                txtClientCode.Text = EdCli.ClientCode;
                txtClientEmail.Text = EdCli.ClientEmail;
                txtClientName.Text = EdCli.ClientName;
                txtClientTelephone.Text = EdCli.ClientPhone;
                EditClients = int.Parse(e.CommandArgument.ToString());
                panelClientEdit.Visible = true;
                panelClientsGrid.Visible = false;
            }
            else if (e.CommandName == "deleteClient")
            {
                Clients DelClients = new Clients();
                DelClients.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                DelClients.MarkAsDeleted();
                DelClients.Save();
                bindData();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            panelClientEdit.Visible = false;
            panelClientsGrid.Visible = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Clients SaveClient = new Clients();

            if (EditClients > 0)
            {
                SaveClient.LoadByPrimaryKey(EditClients);
            }
            else
            {
                SaveClient.AddNew();
            }
            SaveClient.ClientName = txtClientName.Text;
            SaveClient.ClientCode = txtClientCode.Text;
            SaveClient.ClientEmail = txtClientEmail.Text;
            SaveClient.ClientPhone = txtClientTelephone.Text;
            
            SaveClient.Save();

            ClearFields();
            bindData();
            panelClientsGrid.Visible = true;
            panelClientEdit.Visible = false;
        }
    }
}