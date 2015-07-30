using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using MyGeneration.dOOdads;

namespace TouchMediaGUI
{
    public partial class ucPurchaseOrder : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Master.PageTitle = "اوامر الشراء";


                BindGeneralPurchaseOrder();

                if (getQueryString_PurchaseOrder > 0)
                {
                    BLL.PurchaseOrder PoG = new BLL.PurchaseOrder();
                    PoG.LoadByPrimaryKey(getQueryString_PurchaseOrder);
                    txtPurchaseOrderNumber.Text = PoG.PurchaseOrderNumber;
                    txtPurchaseOrderDate.Text = PoG.PurchaseOrderDate.ToString("dd/MM/yyyy");
                    txtManagement.Text = PoG.Management;

                    txtDeliveryDate.Text = PoG.DeliveryDate.ToString("dd/MM/yyyy");
                    txtDeliveryPlace.Text = PoG.DeliveryPlace;
                    txtPaymentRequirement.Text = PoG.PaymentRequierment;
                    TxtManagerName.Text = PoG.ManagerName;
                    uiCheckBoxListType.Items[0].Selected = PoG.ISFinalProduct;
                    uiCheckBoxListType.Items[1].Selected = PoG.ISSample;
                    uiCheckBoxListType.Items[2].Selected = PoG.ISProductUnderManufacturing;
                    BindDetailsPurchaseOrder();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });", true);
                    PanelPurchaseOrdersGrid.Visible = false;
                    PanelPurchaseOrderGeneral.Visible = true;
                    PanelGrdPurcahseOrderDetails.Visible = true;
                    PanelPurchaseOrderDetails.Visible = true;
                    PanelPurSearch.Visible = false;
                }
                if (getQueryString_IsPrint > 0)
                {
                    Microsoft.Reporting.WebForms.ReportDataSource rds = new Microsoft.Reporting.WebForms.ReportDataSource();
                    PurchaseDateSetTableAdapters.PurchasePrintTableAdapter PurTA = new PurchaseDateSetTableAdapters.PurchasePrintTableAdapter();
                    PurTA.ClearBeforeFill = true;

                    try
                    {



                        rds.Name = "PurchasePrint";
                        rds.Value = PurTA.GetData(getQueryString_PurchaseOrder);
                        ReportViewer1.LocalReport.ReportPath = "Reports\\PurchasePrintReport.rdlc";
                        //ReportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter[] { new Microsoft.Reporting.WebForms.ReportParameter("From", txtDateFrom.ToString()) });
                        ReportViewer1.LocalReport.DataSources.Clear();
                        ReportViewer1.LocalReport.DataSources.Add(rds);
                        ReportViewer1.LocalReport.Refresh();

                        PanelReport.Visible = true;
                        //PanelPurchaseOrdersGrid.Visible = false;
                        //PanelPurchaseOrderGeneral.Visible = false;
                        //PanelGrdPurcahseOrderDetails.Visible = false;
                        //PanelPurchaseOrderDetails.Visible = false;
                        PanelPurSearch.Visible = false;
                        PanelPurchaseOrdersGrid.Visible = false;
                        //widPurchaseReport.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }


                }


                if (getQueryString_PurchaseOrderDetails > 0)
                {
                    PurchaseOrderDetails POD = new PurchaseOrderDetails();
                    POD.LoadByPrimaryKey(getQueryString_PurchaseOrderDetails);
                    txtTotalValue.Text = POD.TotalValue.ToString();
                    txtUnitPrice.Text = POD.UnitPrice.ToString();
                    txtQuantityRequired.Text = POD.QuantityRequired.ToString();
                    txtStockOnHands.Text = POD.StockOnHand.ToString();
                    txtUnit.Text = POD.Unit.ToString();
                    txtDescription.Text = POD.Description;
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });", true);
                }

            }
            //BindGeneralPurchaseOrder();
            //BindDetailsPurchaseOrder();

        }
        private void BindGeneralPurchaseOrder()
        {
            //BLL.PurchaseOrder Po = new BLL.PurchaseOrder();
            //Po.LoadAll();
            //GrdViewPurchaseOrders.DataSource = Po.DefaultView;
            //GrdViewPurchaseOrders.DataBind();

            BLL.PurchaseOrder Psearch = new BLL.PurchaseOrder();
            DateTime from, to, DeliveryDateFrom, DeliveryDateTo;
            DateTime.TryParseExact(txtPurDateFromSearch.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out from);
            DateTime.TryParseExact(txtPurDateToSearch.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out to);
            DateTime.TryParseExact(txtPurDeliveryDateFromSearch.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DeliveryDateFrom);
            DateTime.TryParseExact(TxtPurDeliveryDateToSearch.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DeliveryDateTo);
            int no = 0;
            int.TryParse(txtPurOrderNumber.Text, out no);
            if (from == DateTime.MinValue)
                from = new DateTime(1950, 1, 1);
            if (to == DateTime.MinValue)
                to = new DateTime(2600, 1, 1);
            if (DeliveryDateFrom == DateTime.MinValue)
                DeliveryDateFrom = new DateTime(1950, 1, 1);
            if (DeliveryDateTo == DateTime.MinValue)
                DeliveryDateTo = new DateTime(2600, 1, 1);
            Psearch.SearchPurchaseOrder(from,
                                        to,
                                        DeliveryDateFrom,
                                        DeliveryDateTo,
                                        no);


            GrdViewPurchaseOrders.DataSource = Psearch.DefaultView;
            GrdViewPurchaseOrders.DataBind();
        }
        private void BindDetailsPurchaseOrder()
        {
            BLL.PurchaseOrderDetails PoD = new PurchaseOrderDetails();
            PoD.getPurchaseDetails(getQueryString_PurchaseOrder);
            grdPurchaseOrderDetails.DataSource = PoD.DefaultView;
            grdPurchaseOrderDetails.DataBind();
        }



        protected void btnSavePurchaseOrderGeneralGrid_Click(object sender, EventArgs e)
        {
            BLL.PurchaseOrder Pur = new BLL.PurchaseOrder();
            if (getQueryString_PurchaseOrder > 0)
            {
                Pur.LoadByPrimaryKey(getQueryString_PurchaseOrder);
            }
            else
            {
                Pur.AddNew();
                Pur.CreatedBy = new Guid(Membership.GetUser().ProviderUserKey.ToString());
                Pur.CreatedDate = DateTime.Now;
            }
            Pur.PurchaseOrderNumber = txtPurchaseOrderNumber.Text;
            Pur.PurchaseOrderDate = DateTime.ParseExact(txtPurchaseOrderDate.Text, "dd/MM/yyyy", null);
            Pur.Management = txtManagement.Text;
            Pur.DeliveryDate = DateTime.ParseExact(txtDeliveryDate.Text, "dd/MM/yyyy", null);
            Pur.DeliveryPlace = txtDeliveryPlace.Text;
            Pur.PaymentRequierment = txtPaymentRequirement.Text;
            Pur.ManagerName = TxtManagerName.Text;
            Pur.ISFinalProduct = uiCheckBoxListType.Items[0].Selected;
            Pur.ISProductUnderManufacturing = uiCheckBoxListType.Items[2].Selected;
            Pur.ISSample = uiCheckBoxListType.Items[1].Selected;
            Pur.UpdatedBy = new Guid(Membership.GetUser().ProviderUserKey.ToString());
            Pur.LastUpdatedDate = DateTime.Now;
            Pur.Save();

            PanelPurchaseOrdersGrid.Visible = true;
            PanelPurchaseOrderGeneral.Visible = false;
            PanelGrdPurcahseOrderDetails.Visible = true;
            PanelPurchaseOrderDetails.Visible = true;

            Response.Redirect("Job_Order.aspx?PurchaseOrderID=" + Pur.PurchaseOrderID.ToString());
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });", true);

        }

        protected void btnCancelPurchaseOrderGeneralGrid_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Job_Order.aspx");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });", true);
        }

        protected void btnSavePurchaseOrderDetails_Click(object sender, EventArgs e)
        {
            PurchaseOrderDetails Purd = new PurchaseOrderDetails();
            if (getQueryString_PurchaseOrderDetails > 0)
            {
                Purd.LoadByPrimaryKey(getQueryString_PurchaseOrderDetails);

            }
            else
            {
                Purd.AddNew();
                Purd.CreatedBy = new Guid(Membership.GetUser().ProviderUserKey.ToString());
                Purd.CreatedDate = DateTime.Now;
            }
            Purd.TotalValue = double.Parse(txtTotalValue.Text);
            Purd.UnitPrice = double.Parse(txtUnitPrice.Text);
            Purd.QuantityRequired = int.Parse(txtQuantityRequired.Text);
            Purd.StockOnHand = int.Parse(txtStockOnHands.Text);
            Purd.Unit = int.Parse(txtUnit.Text);
            Purd.Description = txtDescription.Text;
            Purd.PurchaseOrderID = getQueryString_PurchaseOrder;
            Purd.LastUpdatedDate = DateTime.Now;
            Purd.UpdatedBy = new Guid(Membership.GetUser().ProviderUserKey.ToString());
            Purd.Save();

            BindDetailsPurchaseOrder();
            cleardetails();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });", true);
        }

        protected void btnCancelPurchaseOrderDetails_Click(object sender, EventArgs e)
        {
            cleardetails();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });", true);
        }
        private int getQueryString_PurchaseOrder
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

        private int getQueryString_IsPrint
        {
            get
            {
                if (!string.IsNullOrEmpty(Request.QueryString["isprint"]))
                {
                    return int.Parse(Request.QueryString["isprint"].ToString());
                }
                else
                {
                    return 0;
                }
            }
        }


        private int getQueryString_PurchaseOrderDetails
        {
            get
            {
                if (!string.IsNullOrEmpty(Request.QueryString["PurchaseOrderDetailsID"]))
                {
                    return int.Parse(Request.QueryString["PurchaseOrderDetailsID"].ToString());
                }
                else
                {
                    return 0;
                }
            }
        }

        protected void GrdViewPurchaseOrders_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "editGeneralOrder")
            {
                int ID = int.Parse(e.CommandArgument.ToString());



                Response.Redirect("Job_Order.aspx?PurchaseOrderID=" + ID.ToString());
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });", true);

            }
            else if (e.CommandName == "PrintPurchase")
            {
                int IDP = int.Parse(e.CommandArgument.ToString());

                Response.Redirect("Job_Order.aspx?isprint=1&PurchaseOrderID=" + IDP.ToString());

            }

            else if (e.CommandName == "deleteGeneralOrder")
            {
                BLL.PurchaseOrder purdel = new BLL.PurchaseOrder();
                PurchaseOrderDetails Purddel = new PurchaseOrderDetails();
                purdel.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                Purddel.getPurchaseDetails(int.Parse(e.CommandArgument.ToString()));
                Purddel.DeleteAll();
                Purddel.Save();
                purdel.MarkAsDeleted();
                purdel.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });", true);
            }
            BindGeneralPurchaseOrder();
        }

        protected void grdPurchaseOrderDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "deleteDetailsOrder")
            {
                BLL.PurchaseOrderDetails Del = new BLL.PurchaseOrderDetails();

                Del.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                Del.MarkAsDeleted();
                Del.Save();
                BindDetailsPurchaseOrder();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });", true);
            }
            else if (e.CommandName == "editDetailsOrder")
            {
                int ID = int.Parse(e.CommandArgument.ToString());
                Response.Redirect(Request.Url.AbsolutePath.ToString() + "?PurchaseOrderID=" + Request.QueryString["PurchaseOrderID"].ToString() + "&PurchaseOrderDetailsID=" + ID.ToString());
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OpenPageSizeTab", "$(document).ready(function (){ $('.nav-tabs a[href=\"#tab_1_3\"]').tab('show'); });", true);

            }

        }
        protected void cleardetails()
        {
            txtTotalValue.Text = "";
            txtUnitPrice.Text = "";
            txtQuantityRequired.Text = "";
            txtStockOnHands.Text = "";
            txtUnit.Text = "";
            txtDescription.Text = "";

        }

        protected void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            PanelPurchaseOrdersGrid.Visible = false;
            PanelPurchaseOrderGeneral.Visible = true;
            PanelGrdPurcahseOrderDetails.Visible = false;
            PanelPurchaseOrderDetails.Visible = false;

        }

        protected void btnPurSearch_Click(object sender, EventArgs e)
        {
            BindGeneralPurchaseOrder();
        }
    }
}