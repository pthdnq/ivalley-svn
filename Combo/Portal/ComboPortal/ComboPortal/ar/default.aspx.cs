using COMBO_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = false)]
        public static bool ForgetPass(string email)
        {

            ComboUser user = new ComboUser();
            if (user.GetUserByUserName(email))
            {
                user.PassResetCode = Guid.NewGuid();
                user.Save();

                try
                {
                    MailMessage msg = new MailMessage();
                    string body = HttpContext.GetLocalResourceObject("~/default.aspx", "body").ToString();
                    string mail = HttpContext.GetLocalResourceObject("~/default.aspx", "mail").ToString();

                    string mailto = user.Email;
                    msg.To.Add(mailto);
                    msg.From = new MailAddress(mail);
                    msg.Subject = HttpContext.GetLocalResourceObject("~/default.aspx", "subject").ToString();
                    msg.IsBodyHtml = true;
                    msg.BodyEncoding = System.Text.Encoding.UTF8;

                    msg.Body = string.Format(body, user.UserName, user.PassResetCode.ToString());

                    SmtpClient client = new SmtpClient(HttpContext.GetLocalResourceObject("~/default.aspx", "mailserver").ToString(), Convert.ToInt32(HttpContext.GetLocalResourceObject("~/default.aspx", "port").ToString()));

                    client.UseDefaultCredentials = false;
                    //client.EnableSsl = true;
                    client.Credentials = new System.Net.NetworkCredential(mail, HttpContext.GetLocalResourceObject("~/default.aspx", "mailpass").ToString());
                    client.Send(msg);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }
    }
}