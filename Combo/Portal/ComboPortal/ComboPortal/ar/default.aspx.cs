using COMBO_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComboPortal.ar
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = false)]
        public static bool LoginComboUser(string username, string password)
        {
            
            ComboUser user = new ComboUser();
            if (user.GetUserByUserNameAndPassword(username, password))
            {
                HttpContext.Current.Session["ComboUser"] = user;
                return true;
            }
            return false;
        }
    }
}