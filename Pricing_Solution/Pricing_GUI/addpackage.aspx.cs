using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pricing.BLL;
namespace Pricing_GUI
{
    public partial class addpackage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDDls();
                uiPanelAdd.Visible = true;
                uiPanelSuccess.Visible = false;
            }
        }

        private void LoadDDls()
        {
            PackageDetails p = new PackageDetails();
            p.GetPackageUnits();
            uiDropDownListPackUnit.DataSource = p.DefaultView;
            uiDropDownListPackUnit.DataTextField = "Pack_unit";
            uiDropDownListPackUnit.DataValueField = "Sys_Key";
            uiDropDownListPackUnit.DataBind();

            uiDropDownListPackUnitName.DataSource = p.DefaultView;
            uiDropDownListPackUnitName.DataTextField = "Pack_unit";
            uiDropDownListPackUnitName.DataValueField = "Sys_Key";
            uiDropDownListPackUnitName.DataBind();

        }

        protected void uiLinkButtonSave_Click(object sender, EventArgs e)
        {
            PackageDetails p = new PackageDetails();
            PackageDetails getid = new PackageDetails();
            p.AddNew();
            decimal price, conv;
            decimal.TryParse(uiTextBoxUnitPrice.Text, out price);
            p.Unit_price = price;
            decimal.TryParse(uiTextBoxConverSub.Text, out conv);
            p.Conver_sub = conv;
            p.Unit_key = Convert.ToInt32(uiDropDownListPackUnit.SelectedValue);
            p.Sub_unit = Convert.ToInt32(uiDropDownListPackUnitName.SelectedValue);
            p.PackID = getid.getMaxID();
            p.Trade_Code = Convert.ToInt32(uiHiddenFieldTradCode.Value);
            p.Save();
            //uiPanelAdd.Visible = false;
            uiPanelSuccess.Visible = true;
        }


    }
}