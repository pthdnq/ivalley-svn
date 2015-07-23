using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TouchMediaGUI.Admin
{
    public partial class AfterPrinting : System.Web.UI.UserControl
    {
        public int Edit
        {
            get
            {
                if (Session["Edit"] != null)
                {
                    return int.Parse(Session["Edit"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                Session["Edit"] = value;
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
            GeneralLookup AfterPurchase = new GeneralLookup();
            AfterPurchase.Where.CategoryID.Value = 12;
            AfterPurchase.Where.CategoryID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            AfterPurchase.Query.Load();
            GridViewAfterPrinting.DataSource = AfterPurchase.DefaultView;
            GridViewAfterPrinting.DataBind();
        }
        public void ClearFields()
        {
            Edit = 0;
            txtAfterPrintingName.Text = "";
        }
        protected void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            panelAfterPurchaseEdit.Visible = true;
            panelAfterPrintingGrid.Visible = false;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_5\"]').tab('show'); });", true);
        }

        protected void GridViewAfterPrinting_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editAfter")
            {
                GeneralLookup AfterPurchase = new GeneralLookup();
                AfterPurchase.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                txtAfterPrintingName.Text = AfterPurchase.Name;

                Edit = int.Parse(e.CommandArgument.ToString());
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_5\"]').tab('show'); });", true);
                panelAfterPurchaseEdit.Visible = true;
                panelAfterPrintingGrid.Visible = false;
            }
            else if (e.CommandName == "deleteAfter")
            {
                GeneralLookup DelAfter = new GeneralLookup();
                DelAfter.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                DelAfter.MarkAsDeleted();
                DelAfter.Save();
                bindData();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_5\"]').tab('show'); });", true);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_5\"]').tab('show'); });", true);
            panelAfterPurchaseEdit.Visible = false;
            panelAfterPrintingGrid.Visible = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            GeneralLookup After = new GeneralLookup();

            if (Edit > 0)
            {
                After.LoadByPrimaryKey(Edit);
            }
            else
            {
                After.AddNew();
            }
            After.Name = txtAfterPrintingName.Text;

            After.CategoryID = 12;
            After.Save();

            ClearFields();
            bindData();
            panelAfterPrintingGrid.Visible = true;
            panelAfterPurchaseEdit.Visible = false;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_5\"]').tab('show'); });", true);
        }
    }
}