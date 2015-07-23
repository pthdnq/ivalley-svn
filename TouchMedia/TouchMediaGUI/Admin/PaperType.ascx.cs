using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TouchMediaGUI.Admin
{
    public partial class PaperType : System.Web.UI.UserControl
    {
        public int EditPaperType
        {
            get
            {
                if (Session["EditPaperType"] != null)
                {
                    return int.Parse(Session["EditPaperType"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                Session["EditPaperType"] = value;
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
            PrintingPapers AllPaperType = new PrintingPapers();
            AllPaperType.LoadAll();
            GridViewPaperType.DataSource = AllPaperType.DefaultView;
            GridViewPaperType.DataBind();
        }
        public void ClearFields()
        {
            EditPaperType = 0;
            txtPaperTypeName.Text = "";
            txtPaperQuantity.Text = "";
        }

        protected void btnNewPaperType_Click(object sender, EventArgs e)
        {
            ClearFields();
            panelPaperTypeEdit.Visible = true;
            panelPaperTypeGrid.Visible = false;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_2\"]').tab('show'); });", true);
        }

        protected void GridViewPaperType_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editPaperType")
            {
                PrintingPapers pr = new PrintingPapers();
                pr.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                txtPaperTypeName.Text = pr.PrintingPaperName.ToString();
                txtPaperQuantity.Text = pr.PurcahsePaperQuantity.ToString();

                EditPaperType = int.Parse(e.CommandArgument.ToString());
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_2\"]').tab('show'); });", true);
                panelPaperTypeEdit.Visible = true;
                panelPaperTypeGrid.Visible = false;
            }
            else if (e.CommandName == "deletePaperType")
            {
                PrintingPapers DelPrint = new PrintingPapers();
                DelPrint.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                DelPrint.MarkAsDeleted();
                DelPrint.Save();
                bindData();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_2\"]').tab('show'); });", true);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_2\"]').tab('show'); });", true);
            panelPaperTypeEdit.Visible = false;
            panelPaperTypeGrid.Visible = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            PrintingPapers PaperType = new PrintingPapers();

            if (EditPaperType > 0)
            {
                PaperType.LoadByPrimaryKey(EditPaperType);
            }
            else
            {
                PaperType.AddNew();
            }
            PaperType.PrintingPaperName = txtPaperTypeName.Text;
            PaperType.PurcahsePaperQuantity = int.Parse(txtPaperQuantity.Text);
            
            PaperType.Save();

            ClearFields();
            bindData();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_2\"]').tab('show'); });", true);
            panelPaperTypeGrid.Visible = true;
            panelPaperTypeEdit.Visible = false;
        }
    }
}