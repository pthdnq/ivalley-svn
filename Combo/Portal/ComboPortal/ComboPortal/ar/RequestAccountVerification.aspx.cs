using COMBO_BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComboPortal.ar
{
    public partial class RequestAccountVerification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ComboUser"] != null)
                {
                    LoadDDLs();
                    ComboUser user = (ComboUser)Session["ComboUser"];
                    VerificationRequest request = new VerificationRequest();
                    if (request.GetRequestByUserID(user.ComboUserID))
                    {
                        uiPanelAdd.Visible = false;
                        uiPanelResult.Visible = true;
                        // load result
                        if (!request.IsColumnNull(VerificationRequest.ColumnNames.IsAccepted))
                        {
                            noresult.Visible = false;
                            if (request.IsAccepted)
                            {
                                accepted.Visible = true;
                                rejected.Visible = false;
                            }
                            else
                            {
                                accepted.Visible = false;
                                rejected.Visible = true;
                                uiLiteralReason.Text = request.Description;
                            }
                        }
                        else
                        {
                            accepted.Visible = false;
                            rejected.Visible = false;
                            noresult.Visible = true;
                        }
                    }
                    else
                    {
                        uiPanelAdd.Visible = true;
                        uiPanelResult.Visible = false;

                    }


                }
            }
        }

        private void LoadDDLs()
        {
            Gender gender = new Gender();
            gender.LoadAll();
            uiDropDownListGender.DataSource = gender.DefaultView;
            uiDropDownListGender.DataTextField = Gender.ColumnNames.Name;
            uiDropDownListGender.DataValueField = Gender.ColumnNames.GenderID;
            uiDropDownListGender.DataBind();

            Country country = new Country();
            country.LoadAll();
            uiDropDownListCountry.DataSource = country.DefaultView;
            uiDropDownListCountry.DataTextField = Country.ColumnNames.Name;
            uiDropDownListCountry.DataValueField = Country.ColumnNames.CountryID;
            uiDropDownListCountry.DataBind();
        }

        protected void uiLinkButtonSave_Click(object sender, EventArgs e)
        {
            ComboUser user = (ComboUser)Session["ComboUser"];
            VerificationRequest request = new VerificationRequest();
            request.AddNew();
            request.ComboUserID = user.ComboUserID;
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
            request.RequestDate = DateTime.Now;

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