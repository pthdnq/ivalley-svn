using Flight_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Data;
using System.Net.Mail;
namespace Flights_GUI.Admin
{
    public class SendingNotifications
    {
        public static void sendNotif(int NotificationType, int? CategoryID, int? ManualID, int? FormID, int? ManualVersionID, int? FormVersionID, int? ScheduleID, int? ScheduleVersionID)
        {
            System.Threading.Thread sendNotif = new System.Threading.Thread(() => SendNotifications(NotificationType, CategoryID, ManualID, FormID, ManualVersionID, FormVersionID, ScheduleID, ScheduleVersionID));
            sendNotif.Start();
        }

        public static void SendNotifications(int NotificationType, int? CategoryID, int? ManualID, int? FormID, int? ManualVersionID, int? FormVersionID, int? ScheduleID, int? ScheduleVersionID)
        {
            MembershipUserCollection users = Membership.GetAllUsers();
            foreach (MembershipUser user in users)
            {
                UsersNofications userNotif = new UsersNofications();
                userNotif.AddNew();
                if (CategoryID != null)
                    userNotif.CategoryID = CategoryID.Value;
                else
                    userNotif.SetColumnNull("CategoryID");

                if (ManualID != null)
                    userNotif.ManualID = ManualID.Value;
                else
                    userNotif.SetColumnNull("ManualID");

                if (FormID != null)
                    userNotif.FormID = FormID.Value;
                else
                    userNotif.SetColumnNull("FormID");

                if (ManualVersionID != null)
                    userNotif.ManualVersionID = ManualVersionID.Value;
                else
                    userNotif.SetColumnNull("ManualVersionID");

                if (FormVersionID != null)
                    userNotif.FromVersionID = FormVersionID.Value;
                else
                    userNotif.SetColumnNull("FromVersionID");

                if (ScheduleID != null)
                    userNotif.ScheduleID = ScheduleID.Value;
                else
                    userNotif.SetColumnNull("ScheduleID");

                if (ScheduleVersionID != null)
                    userNotif.ScheduleVersionID = ScheduleVersionID.Value;
                else
                    userNotif.SetColumnNull("ScheduleVersionID");


                userNotif.UserID = new Guid(user.ProviderUserKey.ToString());
                userNotif.NotificationType = NotificationType;
                userNotif.IsRead = false;
                userNotif.Save();
            }
        }

        public static void NotifyMembersViaMail(int announcementID, int action)
        {
            System.Threading.Thread notify = new System.Threading.Thread(() => SendMails(announcementID, action));
            notify.Start();
        }

        public static void SendMails(int announcementID, int action)
        {
            string useraction = "";
            switch (action)
            {
                case 1:
                    useraction = "has been created";
                    break;
                case 2:
                    useraction = "has been updated";
                    break;
                default:
                    break;
            }

            Announcement announcement = new Announcement();
            announcement.LoadByPrimaryKey(announcementID);

            string type = "";
            string link = "";
            if (!announcement.IsColumnNull(Announcement.ColumnNames.IsBlog))
            {
                if (announcement.IsBlog)
                {
                    type = "blog";
                    link = string.Format(HttpContext.GetLocalResourceObject("~/Admin/NotificationsManagement.aspx", "BlogLink").ToString(), announcementID);
                }
            }
            else if (!announcement.IsColumnNull(Announcement.ColumnNames.IsBulletin))
            {
                if (announcement.IsBulletin)
                {
                    type = "bulletin";
                    link = string.Format(HttpContext.GetLocalResourceObject("~/Admin/NotificationsManagement.aspx", "BulletinLink").ToString(), announcementID);
                }
            }
            else
            {
                type = "circular";
                link = string.Format(HttpContext.GetLocalResourceObject("~/Admin/NotificationsManagement.aspx", "CircularLink").ToString(), announcementID);
            }

            UsersProfiles up = new UsersProfiles();
            AnnouncementGroup groups = new AnnouncementGroup();
            groups.GetGroupsByAnnouncementID(announcementID);
            if(groups.RowCount > 0)
            {
                List<string> GroupIDs = groups.DefaultView.Table.AsEnumerable().Select(row => row.Field<int>("GroupID").ToString())
                .ToList();
                up.getuserEmails(GroupIDs);
            }
            else
            {
                up.LoadAll();
            }
            

            try
            {
                MailMessage msg = new MailMessage();
                string mail = HttpContext.GetLocalResourceObject("~/Admin/NotificationsManagement.aspx", "FromMail").ToString();
                for (int i = 0; i < up.RowCount; i++)
                {
                    if (IsValidEmail(up.Email))
                        msg.To.Add(up.Email);
                    up.MoveNext();
                }
                
                msg.From = new MailAddress(mail);
                msg.Subject = string.Format(HttpContext.GetLocalResourceObject("~/Admin/NotificationsManagement.aspx", "NotificationSubject").ToString(), action == 1 ? "new " : "a ", type + " " + useraction);
                msg.IsBodyHtml = true;
                msg.BodyEncoding = System.Text.Encoding.UTF8;
                msg.Body = string.Format(HttpContext.GetLocalResourceObject("~/Admin/NotificationsManagement.aspx", "NotificationBody").ToString(), action == 1 ? "new " : "a ", type + " " + useraction, link);
                SmtpClient client = new SmtpClient(HttpContext.GetLocalResourceObject("~/Admin/NotificationsManagement.aspx", "Server").ToString(),
                                                    Convert.ToInt32(HttpContext.GetLocalResourceObject("~/Admin/NotificationsManagement.aspx", "Port")));
                //SmtpClient client = new SmtpClient(GetLocalResourceObject("server").ToString(), 25);
                client.EnableSsl = false;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(mail, HttpContext.GetLocalResourceObject("~/Admin/NotificationsManagement.aspx", "Password").ToString());
                client.Send(msg);
                

            }
            catch (Exception ex)
            {
                
            }
            
        }

        static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}