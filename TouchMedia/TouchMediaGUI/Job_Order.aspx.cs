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
                if (getQueryString_JobOrder > 0)
                {
                    JobOrder J = new JobOrder();
                    J.LoadByPrimaryKey(getQueryString_JobOrder);
                    txtJobOrderCode.Text = J.JobOrderCode;
                    txtGeneralOperationName.Text = J.JobOrderName;
                    drpClientName.SelectedValue = J.ClientID.ToString();
                    drpGeneralStatus.SelectedValue = J.JobOrderStatusID.ToString();
                    grdGeneralBind();
                }
                grdGeneralBind();

                Clients C = new Clients();
                C.LoadAll();
                drpClientName.DataSource = C.DefaultView;
                drpClientName.DataTextField = Clients.ColumnNames.ClientName;
                drpClientName.DataValueField = Clients.ColumnNames.ClientID;
                drpClientName.DataBind();

                JobOrderStatus JS = new JobOrderStatus();
                JS.LoadAll();
                drpGeneralStatus.DataSource = JS.DefaultView;
                drpGeneralStatus.DataTextField = JobOrderStatus.ColumnNames.JobOrderStatusNameAr;
                drpGeneralStatus.DataValueField = JobOrderStatus.ColumnNames.JobOrderStatusID;
                drpGeneralStatus.DataBind();
            }
        }

        protected void btnSaveMasterJobOrder_Click(object sender, EventArgs e)
        {
            JobOrder jo = new JobOrder();
            if (getQueryString_JobOrder > 0)
            {
                jo.LoadByPrimaryKey(getQueryString_JobOrder);
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
            grdGeneralBind();
            ClearFields();
        }

        protected void btnCancelMasterJobOrder_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        protected void btnAddNewJobOrder_Click(object sender, EventArgs e)
        {

        }

        protected void GrdViewJobOrders_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        private int getQueryString_JobOrder
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
        private void grdGeneralBind()
        {
            JobOrder JO = new JobOrder();
            JO.GetAllJos();
            GrdViewJobOrders.DataSource = JO.DefaultView;
            GrdViewJobOrders.DataBind();
        }
        private void ClearFields()
        {
            txtGeneralOperationName.Text = "";
            txtJobOrderCode.Text = "";
            drpClientName.ClearSelection();
            drpGeneralStatus.ClearSelection();
        }
       
    }
}