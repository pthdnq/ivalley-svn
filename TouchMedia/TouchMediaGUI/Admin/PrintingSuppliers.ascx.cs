using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TouchMediaGUI.Admin
{
    public partial class PrintingSuppliers : System.Web.UI.UserControl
    {
        public int EditPaperType
        {
            get
            {
                if (Session["EditPrintingSupplier"] != null)
                {
                    return int.Parse(Session["EditPrintingSupplier"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                Session["EditPrintingSupplier"] = value;
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
            GeneralLookup AllPrintingSuppliers = new GeneralLookup();
            AllPrintingSuppliers.Where.CategoryID.Value = 2;
            AllPrintingSuppliers.Where.CategoryID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            AllPrintingSuppliers.Query.Load();
            GridViewPrintingSuppliers.DataSource = AllPrintingSuppliers.DefaultView;
            GridViewPrintingSuppliers.DataBind();
        }
        public void ClearFields()
        {
            EditPaperType = 0;
            txtPrintingSupplierAddress.Text = "";
            txtPrintingSupplierEmail.Text = "";
            txtPrintingSupplierName.Text = "";
            txtPrintingSupplierTelephone.Text = "";
        }
        protected void btnNewPrintingSuppliers_Click(object sender, EventArgs e)
        {
            ClearFields();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_4\"]').tab('show'); });", true);
            panelPaperTypeEdit.Visible = true;
            panelPrintingSuppliersGrid.Visible = false;
        }

        protected void GridViewPrintingSuppliers_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editPrintingSupplier")
            {
                GeneralLookup PrintingSupplier = new GeneralLookup();
                PrintingSupplier.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                txtPrintingSupplierName.Text = PrintingSupplier.Name;
                txtPrintingSupplierAddress.Text = PrintingSupplier.Address;
                txtPrintingSupplierEmail.Text = PrintingSupplier.Email;
                txtPrintingSupplierTelephone.Text = PrintingSupplier.Telephone;
                EditPaperType = int.Parse(e.CommandArgument.ToString());
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_4\"]').tab('show'); });", true);
                panelPaperTypeEdit.Visible = true;
                panelPrintingSuppliersGrid.Visible = false;
            }
            else if (e.CommandName == "deletePrintingSupplier")
            {
                GeneralLookup DelPrintingSupplier = new GeneralLookup();
                DelPrintingSupplier.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                DelPrintingSupplier.MarkAsDeleted();
                DelPrintingSupplier.Save();
                bindData();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_4\"]').tab('show'); });", true);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_4\"]').tab('show'); });", true);
            panelPaperTypeEdit.Visible = false;
            panelPrintingSuppliersGrid.Visible = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            GeneralLookup PaperType = new GeneralLookup();

            if (EditPaperType > 0)
            {
                PaperType.LoadByPrimaryKey(EditPaperType);
            }
            else
            {
                PaperType.AddNew();
            }
            PaperType.Name = txtPrintingSupplierName.Text;
            PaperType.Address = txtPrintingSupplierAddress.Text;
            PaperType.Email = txtPrintingSupplierEmail.Text;
            PaperType.Telephone = txtPrintingSupplierTelephone.Text;

            PaperType.CategoryID = 2;
            PaperType.Save();

            ClearFields();
            bindData();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_4\"]').tab('show'); });", true);
            panelPrintingSuppliersGrid.Visible = true;
            panelPaperTypeEdit.Visible = false;
        }
    }
}