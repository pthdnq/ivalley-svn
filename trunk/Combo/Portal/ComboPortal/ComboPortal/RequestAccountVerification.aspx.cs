using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using COMBO_BLL;
using System.Collections;

namespace ComboPortal
{
    public partial class RequestAccountVerification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ComboUser"] != null)
                {
                    ComboUser user = (ComboUser)Session["ComboUser"];
                    VerificationRequest request = new VerificationRequest();
                    if (request.GetRequestByUserID(user.ComboUserID))
                    {
                        uiPanelAdd.Visible = false;
                        uiPanelResult.Visible = true;
                        // load result
                    }
                    else
                    {
                        uiPanelAdd.Visible = true;
                        uiPanelResult.Visible = false;
                    }

                    
                }
            }
        }

        protected void uiLinkButtonSave_Click(object sender, EventArgs e)
        {
            ComboUser user = (ComboUser)Session["ComboUser"];
            VerificationRequest request = new VerificationRequest();
            request.AddNew();
            request.RequestTypeID = Convert.ToInt32(AccountType.Value);
            request.CountryID = Convert.ToInt32(uiDropDownListCountry.SelectedValue);
            switch (AccountType.Value)
            {
                case "1":
                case "2":
                    request.Name = uiTextBoxName.Text;
                    request.PassportNo = uiTextBoxPassNo.Text;
                    request.DateOfBirth = DateTime.ParseExact(uiTextBoxDOB.Text, "dd/MM/yyyy", null);
                    request.GenderID = Convert.ToInt32(uiDropDownListGender.SelectedValue);
                    
                    break;
                case "3":
                    request.Name = uiTextBoxOrgName.Text;
                    request.City = uiTextBoxCity.Text;
                    break;
                default:
                    break;
            }
            request.MobileNo = uiTextBoxMobileNo.Text;
            request.MobileNo2 = uiTextBoxMobileNo2.Text;
            request.AccountName = uiTextBoxAccountName.Text;
            request.Email = uiTextBoxEmail.Text;

            if (Session["CurrentUploadedFiles"] != null)
            {
                Hashtable Files;
                Files = (Hashtable)Session["CurrentUploadedFiles"];

                if (Files.Count > 0)
                {
                    foreach (DictionaryEntry item in Files)
                    {
                        if (item.Key.ToString() == "passport")
                        {
                            request.PassportPicPath = item.Value.ToString();
                        }
                        if (item.Key.ToString() == "pic")
                        {
                            request.PersonalPicPath = item.Value.ToString();
                        }
                    }

                    Session["CurrentUploadedFiles"] = null;
                }
            }

            request.Save();
            Response.Redirect("myaccount.aspx");
        }

      
    }
}