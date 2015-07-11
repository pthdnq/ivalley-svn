using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COMBO_BLL;

namespace ComboPortal.Admin
{
    public partial class EditLookup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Master.PageTitle = "تعديل المحتوى";
                if (pageID >0)
                {
                    GeneralLookup objData = new GeneralLookup();
                    objData.LoadByPrimaryKey(pageID);
                    txtData.Value = Server.HtmlDecode(objData.GeneralLookupText);
                }
            }
        }

        public int pageID
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
                    return int.Parse(Request.QueryString["id"].ToString());
                else
                    return 0;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            GeneralLookup objData = new GeneralLookup();
            objData.LoadByPrimaryKey(pageID);
            objData.GeneralLookupText = Server.HtmlEncode(txtData.Value);
            objData.Save();
        }
    }
}