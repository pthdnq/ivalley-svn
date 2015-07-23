using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TouchMediaGUI.Admin
{
    public partial class PrintingHouseUC : System.Web.UI.UserControl
    {
        public int EditPrintinHouse
        {
            get
            {
                if (Session["EditPrintinHouse"] != null)
                {
                    return int.Parse(Session["EditPrintinHouse"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                Session["EditPrintinHouse"] = value;
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
            GeneralLookup AllPrintingHouse = new GeneralLookup();
            AllPrintingHouse.Where.CategoryID.Value = 5;
            AllPrintingHouse.Where.CategoryID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            AllPrintingHouse.Query.Load();
            GridViewPrintingHouse.DataSource = AllPrintingHouse.DefaultView;
            GridViewPrintingHouse.DataBind();
        }
        public void ClearFields()
        {
            EditPrintinHouse = 0;
            txtPrintingHouseAddress.Text = "";
            txtPrintingHouseEmail.Text = "";
            txtPrintingHouseName.Text = "";
            txtPrintingHouseTelephone.Text = "";
        }

        protected void btnNewPrintingHouse_Click(object sender, EventArgs e)
        {
            ClearFields();
            panelPrintingHouseEdit.Visible = true;
            panelPrintingHouseGrid.Visible = false;
        }

        protected void GridViewPrintingHouse_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editPrintingHouse")
            {
                GeneralLookup PrintingHouse = new GeneralLookup();
                PrintingHouse.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                txtPrintingHouseAddress.Text = PrintingHouse.Address;
                txtPrintingHouseEmail.Text = PrintingHouse.Email;
                txtPrintingHouseName.Text = PrintingHouse.Name;
                txtPrintingHouseTelephone.Text = PrintingHouse.Telephone;
                EditPrintinHouse = int.Parse(e.CommandArgument.ToString());
                panelPrintingHouseEdit.Visible = true;
                panelPrintingHouseGrid.Visible = false;
            }
            else if (e.CommandName == "deletePrintingHouse")
            {
                GeneralLookup DelPrint = new GeneralLookup();
                DelPrint.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                DelPrint.MarkAsDeleted();
                DelPrint.Save();
                bindData();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            panelPrintingHouseEdit.Visible = false;
            panelPrintingHouseGrid.Visible = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            GeneralLookup printer = new GeneralLookup();

            if (EditPrintinHouse > 0)
            {
                printer.LoadByPrimaryKey(EditPrintinHouse);
            }
            else
            {
                printer.AddNew();
            }
            printer.Name = txtPrintingHouseName.Text;
            printer.Address = txtPrintingHouseAddress.Text;
            printer.Email = txtPrintingHouseEmail.Text;
            printer.Telephone = txtPrintingHouseTelephone.Text;
            printer.CategoryID = 5;
            printer.Save();

            ClearFields();
            bindData();
            panelPrintingHouseGrid.Visible = true;
            panelPrintingHouseEdit.Visible = false;
        }
    }
}