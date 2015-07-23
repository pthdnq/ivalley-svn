using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace TouchMediaGUI.Admin
{
    public partial class ManageAfterPurchase : System.Web.UI.Page
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
            AfterPurchase.Where.CategoryID.Value = 10;
            AfterPurchase.Where.CategoryID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            AfterPurchase.Query.Load();
            GridViewAfterPurchase.DataSource = AfterPurchase.DefaultView;
            GridViewAfterPurchase.DataBind();
        }
        public void ClearFields()
        {

            txtAfterPurchaseName.Text = "";
        }
        protected void btnNewNeed_Click(object sender, EventArgs e)
        {
            ClearFields();
            panelAfterPurchaseEdit.Visible = true;
            panelAfterPurchaseGrid.Visible = false;
        }

      

        protected void GridViewAfterPurchase_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editAfter")
            {
                GeneralLookup AfterPurchase = new GeneralLookup();
                AfterPurchase.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                txtAfterPurchaseName.Text = AfterPurchase.Name;

                Edit = int.Parse(e.CommandArgument.ToString());
                panelAfterPurchaseEdit.Visible = true;
                panelAfterPurchaseGrid.Visible = false;
            }
            else if (e.CommandName == "deleteAfter")
            {
                GeneralLookup DelAfter = new GeneralLookup();
                DelAfter.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                DelAfter.MarkAsDeleted();
                DelAfter.Save();
                bindData();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            panelAfterPurchaseEdit.Visible = false;
            panelAfterPurchaseGrid.Visible = true;
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
            After.Name = txtAfterPurchaseName.Text;

            After.CategoryID = 10;
            After.Save();

            ClearFields();
            bindData();
            panelAfterPurchaseGrid.Visible = true;
            panelAfterPurchaseEdit.Visible = false;
        }
    }
}