using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TouchMediaGUI.Admin
{
    public partial class ManageNeeds : System.Web.UI.Page
    {
        public int EditNeed
        {
            get
            {
                if (Session["EditNeed"] != null)
                {
                    return int.Parse(Session["EditNeed"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                Session["EditNeed"] = value;
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
            needs ne= new needs();
            ne.LoadAll();
            GridViewNeeds.DataSource = ne.DefaultView;
            GridViewNeeds.DataBind();
        }
        public void ClearFields()
        {
            txtNeedName.Text = "";
            txtNeedQuantity.Text = "";
            txtNeedSupplier.Text = "";
            CheckboxNeed.ClearSelection();
        }
        protected void btnNewNeed_Click(object sender, EventArgs e)
        {
            ClearFields();
            panelPaperTypeEdit.Visible = true;
            panelNeedsGrid.Visible = false;
        }

        protected void GridViewNeeds_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editNeed")
            {
                needs editne = new needs();
                editne.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                txtNeedName.Text = editne.NeedName;
                txtNeedQuantity.Text = editne.NeedQuantity;
                txtNeedSupplier.Text = editne.NeedSupplier;
                CheckboxNeed.Items[0].Selected = editne.IsNew;
                CheckboxNeed.Items[1].Selected = editne.IsAvalible;
                CheckboxNeed.Items[2].Selected = editne.IsMaintenance;
                EditNeed = int.Parse(e.CommandArgument.ToString());
                panelPaperTypeEdit.Visible = true;
                panelNeedsGrid.Visible = false;
            }
            else if (e.CommandName == "deleteNeed")
            {
                needs delNeed = new needs();
                delNeed.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                delNeed.MarkAsDeleted();
                delNeed.Save();
                bindData();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            panelPaperTypeEdit.Visible = false;
            panelNeedsGrid.Visible = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            needs SaveNeed = new needs();

            if (EditNeed > 0)
            {
                SaveNeed.LoadByPrimaryKey(EditNeed);
            }
            else
            {
                SaveNeed.AddNew();
            }
            SaveNeed.NeedName = txtNeedName.Text;
            SaveNeed.NeedQuantity = txtNeedQuantity.Text;
            SaveNeed.NeedSupplier = txtNeedSupplier.Text;
            SaveNeed.IsNew = CheckboxNeed.Items[0].Selected;
            SaveNeed.IsAvalible = CheckboxNeed.Items[1].Selected;
            SaveNeed.IsMaintenance = CheckboxNeed.Items[2].Selected;

            SaveNeed.Save();

            ClearFields();
            bindData();
            panelNeedsGrid.Visible = true;
            panelPaperTypeEdit.Visible = false;
        }
    }
}