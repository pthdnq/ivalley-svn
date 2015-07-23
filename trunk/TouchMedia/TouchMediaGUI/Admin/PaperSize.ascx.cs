using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TouchMediaGUI.Admin
{
    public partial class PaperSize : System.Web.UI.UserControl
    {
        public int EditPaperType
        {
            get
            {
                if (Session["EditPaperSize"] != null)
                {
                    return int.Parse(Session["EditPaperSize"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                Session["EditPaperSize"] = value;
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
            GeneralLookup AllPaperSize = new GeneralLookup();
            AllPaperSize.Where.CategoryID.Value = 11;
            AllPaperSize.Where.CategoryID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            AllPaperSize.Query.Load();
            GridViewPaperSize.DataSource = AllPaperSize.DefaultView;
            GridViewPaperSize.DataBind();
        }
        public void ClearFields()
        {
            EditPaperType = 0;
            txtPaperSizeName.Text = "";
        }
        protected void btnNewPaperSize_Click(object sender, EventArgs e)
        {
            ClearFields();
            panelPaperSizeEdit.Visible = true;
            panelPaperSizeGrid.Visible = false;
            Page.ClientScript.RegisterStartupScript(this.GetType(),"OpenPageSizeTab","$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });",true);
        }

        protected void GridViewPaperSize_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editPaperSize")
            {
                GeneralLookup PrintingHouse = new GeneralLookup();
                PrintingHouse.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                txtPaperSizeName.Text = PrintingHouse.Name;

                EditPaperType = int.Parse(e.CommandArgument.ToString());
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });", true);
                panelPaperSizeEdit.Visible = true;
                panelPaperSizeGrid.Visible = false;
            }
            else if (e.CommandName == "deletePaperSize")
            {
                GeneralLookup DelPrint = new GeneralLookup();
                DelPrint.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                DelPrint.MarkAsDeleted();
                DelPrint.Save();
                bindData();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });", true);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            panelPaperSizeEdit.Visible = false;
            panelPaperSizeGrid.Visible = true;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });", true);
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
            PaperType.Name = txtPaperSizeName.Text;

            PaperType.CategoryID = 11;
            PaperType.Save();

            ClearFields();
            bindData();
            panelPaperSizeGrid.Visible = true;
            panelPaperSizeEdit.Visible = false;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });", true);
        }
    }
}