using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TouchMediaGUI
{
    public partial class Job_Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                grdGeneralBind();
                loadClients();
                loadJobOrderStatus();

                if (NewJobOrder == 1)
                {
                    PanelJobOrdersGrid.Visible = false;
                    PanelJobOrderDetails.Visible = false;
                    PanelJobOrderMasterDetails.Visible = true;
                }
                else if (CurrentJobOrder > 0)
                {
                    editJobOrder();
                    btnCancelMasterJobOrder.Visible = false;
                    btnBackToGrid.Visible = true;
                    PanelJobOrdersGrid.Visible = false;
                    PanelJobOrderDetails.Visible = true;
                    PanelJobOrderMasterDetails.Visible = true;
                }
                else if (CurrentPurchaseOrder>0)
                {
                    PanelJobOrderDetails.Visible = true;
                    btnBackToGrid.Visible = false;
                    btnCancelMasterJobOrder.Visible = true;                    
                }
                else
                {
                    PanelJobOrdersGrid.Visible = true;
                    PanelJobOrderDetails.Visible = false;
                    PanelJobOrderMasterDetails.Visible = false;
                }
            }
        }
        public void loadClients()
        {
            Clients C = new Clients();
            C.LoadAll();
            drpClientName.DataSource = C.DefaultView;
            drpClientName.DataTextField = Clients.ColumnNames.ClientName;
            drpClientName.DataValueField = Clients.ColumnNames.ClientID;
            drpClientName.DataBind();
        }
        public void editJobOrder()
        {
            JobOrder objDataJobOrder = new JobOrder();
            objDataJobOrder.LoadByPrimaryKey(CurrentJobOrder);
            txtJobOrderCode.Text = objDataJobOrder.JobOrderCode;
            txtGeneralOperationName.Text = objDataJobOrder.JobOrderName;
            drpClientName.SelectedValue = objDataJobOrder.ClientID.ToString();
            drpGeneralStatus.SelectedValue = objDataJobOrder.JobOrderStatusID.ToString();

            //Load remaining details..
        }
        public void loadJobOrderStatus()
        {
            JobOrderStatus JS = new JobOrderStatus();
            JS.LoadAll();
            drpGeneralStatus.DataSource = JS.DefaultView;
            drpGeneralStatus.DataTextField = JobOrderStatus.ColumnNames.JobOrderStatusNameAr;
            drpGeneralStatus.DataValueField = JobOrderStatus.ColumnNames.JobOrderStatusID;
            drpGeneralStatus.DataBind();
        }
        protected void btnSaveMasterJobOrder_Click(object sender, EventArgs e)
        {
            JobOrder jo = new JobOrder();
            if (CurrentJobOrder > 0)
            {
                jo.LoadByPrimaryKey(CurrentJobOrder);
            }
            else
            {
                jo.AddNew();
            }
            jo.ClientID = int.Parse(drpClientName.SelectedValue);
            jo.JobOrderStatusID = int.Parse(drpGeneralStatus.SelectedValue);
            jo.JobOrderCode = txtJobOrderCode.Text;
            jo.JobOrderName = txtGeneralOperationName.Text;
            jo.Save();

            Response.Redirect("Job_Order.aspx?JobOrderID=" + jo.JobOrderID);
        }
        protected void btnCancelMasterJobOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("Job_Order.aspx");
        }
        protected void btnAddNewJobOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("Job_Order.aspx?NewJO=1");
        }
        protected void GrdViewJobOrders_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "editJobOrder":
                    Response.Redirect("Job_Order.aspx?JobOrderID=" + e.CommandArgument);
                    break;
                case "deleteJobOrder":
                    // isDeleted !!
                    break;
                case "PrintPurchase":
                    //report
                    break;
                default:
                    break;
            }
        }
        private int CurrentJobOrder
        {
            get
            {
                if (!string.IsNullOrEmpty(Request.QueryString["JobOrderID"]))
                {
                    return int.Parse(Request.QueryString["JobOrderID"].ToString());
                }
                else
                {
                    return 0;
                }
            }
        }
        private int NewJobOrder
        {
            get
            {
                if (!string.IsNullOrEmpty(Request.QueryString["NewJO"]))
                    return 1;
                else
                    return 0;
            }
        }
        private void grdGeneralBind()
        {
            JobOrder JO = new JobOrder();
            JO.GetAllJos();
            GrdViewJobOrders.DataSource = JO.DefaultView;
            GrdViewJobOrders.DataBind();
        }
        private int CurrentPurchaseOrder
        {
            get
            {
                if (!string.IsNullOrEmpty(Request.QueryString["PurchaseOrderID"]))
                {
                    return int.Parse(Request.QueryString["PurchaseOrderID"].ToString());
                }
                else
                {
                    return 0;
                }
            }
        }
        private void ClearFields()
        {
            txtGeneralOperationName.Text = "";
            txtJobOrderCode.Text = "";
            drpClientName.ClearSelection();
            drpGeneralStatus.ClearSelection();
        }
        protected void btnBackToGrid_Click(object sender, EventArgs e)
        {
            Response.Redirect("Job_Order.aspx");
        }
    }
}