﻿using Combo.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Net.Mail;
using System.Web.Script.Services;

namespace Combo.ComboAPI
{
    /// <summary>
    /// Summary description for combo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class combo : System.Web.Services.WebService
    {
        [WebMethod]
        /// <summary>
        /// Get All combo Users
        /// </summary>
        /// <returns>ComboResponse object with List of all Combo Users </returns>
        public void GetUsers()
        {
            Models.ComboResponse _response = new Models.ComboResponse();
            _response.bool_result = true;
            _response.ErrorCode = 0;
            _response.ErrorMsg = "";

            ComboUser user = new ComboUser();
            user.LoadAll();
            List<Models.ComboUser> Users = user.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.ComboUser
                {
                    ComboUserID = Convert.ToInt32(row["ComboUserID"]),
                    UserName = row["UserName"].ToString(),
                    DisplayName = row["DisplayName"].ToString(),
                    Password = row["Password"].ToString(),
                    Email = row["Email"].ToString(),
                    Bio = row["Bio"].ToString(),
                    ProfileImgID = row.IsNull("ProfileImgID") ? 0 : Convert.ToInt32(row["ProfileImgID"]),
                    CoverImgID = row.IsNull("CoverImgID") ? 0 : Convert.ToInt32(row["CoverImgID"]),
                    GenderID = row.IsNull("GenderID") ? 0 : Convert.ToInt32(row["GenderID"]),
                    IsActivated = row.IsNull("IsActivated") ? false : Convert.ToBoolean(row["IsActivated"]),
                    ExternalIDType = row.IsNull("ExternalIDType") ? 0 : Convert.ToInt32(row["ExternalIDType"]),
                    ExternalID = row["ExternalID"].ToString(),
                    DeviceID = row["DeviceID"].ToString(),
                    ActivationCode = row.IsNull("ActivationCode") ? Guid.Empty : new Guid(row["ActivationCode"].ToString()),
                    PassResetCode = row.IsNull("PassResetCode") ? Guid.Empty : new Guid(row["PassResetCode"].ToString())
                };
            }).ToList();


            _response.Entity = Users;
            SetContentResult(_response);

        }

        [WebMethod]
        /// <summary>
        /// Get Combo User By ID
        /// </summary>
        /// <param name="ID">ID of Combo User</param>
        /// <returns>ComboResponse object with requested User object </returns>
        public void GetUserByID(int id)
        {
            Models.ComboResponse _response = new Models.ComboResponse();
            _response.bool_result = true;
            _response.ErrorCode = 0;
            _response.ErrorMsg = "";

            ComboUser user = new ComboUser();
            user.LoadByPrimaryKey(id);
            List<Models.ComboUser> Users = user.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.ComboUser
                {
                    ComboUserID = Convert.ToInt32(row["ComboUserID"]),
                    UserName = row["UserName"].ToString(),
                    DisplayName = row["DisplayName"].ToString(),
                    Password = row["Password"].ToString(),
                    Email = row["Email"].ToString(),
                    Bio = row["Bio"].ToString(),
                    ProfileImgID = row.IsNull("ProfileImgID") ? 0 : Convert.ToInt32(row["ProfileImgID"]),
                    CoverImgID = row.IsNull("CoverImgID") ? 0 : Convert.ToInt32(row["CoverImgID"]),
                    GenderID = row.IsNull("GenderID") ? 0 : Convert.ToInt32(row["GenderID"]),
                    IsActivated = row.IsNull("IsActivated") ? false : Convert.ToBoolean(row["IsActivated"]),
                    ExternalIDType = row.IsNull("ExternalIDType") ? 0 : Convert.ToInt32(row["ExternalIDType"]),
                    ExternalID = row["ExternalID"].ToString(),
                    DeviceID = row["DeviceID"].ToString(),
                    ActivationCode = row.IsNull("ActivationCode") ? Guid.Empty : new Guid(row["ActivationCode"].ToString()),
                    PassResetCode = row.IsNull("PassResetCode") ? Guid.Empty : new Guid(row["PassResetCode"].ToString())
                };
            }).ToList();


            _response.Entity = Users;
            SetContentResult(_response);

        }

        [WebMethod]
        /// <summary>
        /// Get Combo User By Username/Email & Password
        /// </summary>
        /// <param name="UserName">Username / email</param>
        /// <param name="Password">password</param>
        /// <returns>ComboResponse object with requested User object</returns>
        public void GetUser(string username, string password)
        {
            Models.ComboResponse _response = new Models.ComboResponse();
            _response.bool_result = true;
            _response.ErrorCode = 0;
            _response.ErrorMsg = "";

            ComboUser user = new ComboUser();
            if (!user.GetUserByUserNameAndPassword(username, password))
            {
                _response.ErrorCode = 11;
                _response.ErrorMsg = "User doesn't exist";
                _response.bool_result = false;
                if (user.GetUserByUserName(username))
                {
                    _response.ErrorCode = 10;
                    _response.ErrorMsg = "Password not correct";
                }
            }
            else
            {
                List<Models.ComboUser> Users = user.DefaultView.Table.AsEnumerable().Select(row =>
                {
                    return new Models.ComboUser
                    {
                        ComboUserID = Convert.ToInt32(row["ComboUserID"]),
                        UserName = row["UserName"].ToString(),
                        DisplayName = row["DisplayName"].ToString(),
                        Password = row["Password"].ToString(),
                        Email = row["Email"].ToString(),
                        Bio = row["Bio"].ToString(),
                        ProfileImgID = row.IsNull("ProfileImgID") ? 0 : Convert.ToInt32(row["ProfileImgID"]),
                        CoverImgID = row.IsNull("CoverImgID") ? 0 : Convert.ToInt32(row["CoverImgID"]),
                        GenderID = row.IsNull("GenderID") ? 0 : Convert.ToInt32(row["GenderID"]),
                        IsActivated = row.IsNull("IsActivated") ? false : Convert.ToBoolean(row["IsActivated"]),
                        ExternalIDType = row.IsNull("ExternalIDType") ? 0 : Convert.ToInt32(row["ExternalIDType"]),
                        ExternalID = row["ExternalID"].ToString(),
                        DeviceID = row["DeviceID"].ToString(),
                        ActivationCode = row.IsNull("ActivationCode") ? Guid.Empty : new Guid(row["ActivationCode"].ToString()),
                        PassResetCode = row.IsNull("PassResetCode") ? Guid.Empty : new Guid(row["PassResetCode"].ToString())
                    };
                }).ToList();


                _response.Entity = Users;
            }
            SetContentResult(_response);

        }

        [WebMethod]        
        /// <summary>
        /// Add Combo user to db
        /// </summary>
        /// <param name="user">Combo user object to be added</param>
        /// <returns>ComboResponse object with Added User object</returns>
        public void AddUser(int id)
        {
            Models.ComboResponse _response = new Models.ComboResponse();
            _response.bool_result = true;
            _response.ErrorCode = 0;
            _response.ErrorMsg = "";

            BLL.ComboUser newUser = new ComboUser();
            BLL.ComboUser _user = new ComboUser();
           /* if (_user.GetUserByUserName(user.UserName))
            {
                _response.ErrorCode = 12;
                _response.ErrorMsg = "Username exists before";
                _response.bool_result = false;
                SetContentResult(_response);
                return;
            }
            newUser.AddNew();
            newUser.UserName = user.UserName;
            if (!string.IsNullOrEmpty(user.DisplayName))
                newUser.DisplayName = user.DisplayName;
            newUser.Password = user.Password;
            newUser.Email = user.Email;
            if (!string.IsNullOrEmpty(user.Bio))
                newUser.Bio = user.Bio;
            if (user.ProfileImgID != 0)
                newUser.ProfileImgID = user.ProfileImgID;
            if (user.CoverImgID != 0)
                newUser.CoverImgID = user.CoverImgID;
            if (user.GenderID != 0)
                newUser.GenderID = user.GenderID;
            newUser.IsActivated = user.IsActivated;
            if (user.ExternalIDType != 0)
            {
                newUser.ExternalIDType = user.ExternalIDType;
                newUser.ExternalID = user.ExternalID;
            }
            if (!string.IsNullOrEmpty(user.DeviceID))
                newUser.DeviceID = user.DeviceID;
            newUser.Save();

            user.ComboUserID = newUser.ComboUserID;
            _response.Entity = user;
            */
            SetContentResult(_response);
            return;
        }

        [WebMethod]
        /// <summary>
        /// Delete Combo User from db
        /// </summary>
        /// <param name="ID">Combo User ID</param>
        /// <returns>ComboResponse object with Delete Result</returns>
        public void DeleteUser(int ID)
        {
            Models.ComboResponse _response = new Models.ComboResponse();
            _response.bool_result = true;
            _response.ErrorCode = 0;
            _response.ErrorMsg = "";

            ComboUser user = new ComboUser();
            if (!user.LoadByPrimaryKey(ID))
            {
                _response.ErrorCode = 11;
                _response.ErrorMsg = "User doesn't exist";
                _response.bool_result = false;

            }
            else
            {
                user.MarkAsDeleted();
                user.Save();
            }

            _response.Entity = null;
            SetContentResult(_response);
            return;
        }

        [WebMethod]
        /// <summary>
        /// send forget pasword code by username
        /// </summary>
        /// <param name="ID">username of Combo User</param>
        /// <returns>ComboResponse object </returns>
        public void ForgetPassword(string Username)
        {
            Models.ComboResponse _response = new Models.ComboResponse();
            _response.bool_result = true;
            _response.ErrorCode = 0;
            _response.ErrorMsg = "";

            ComboUser user = new ComboUser();
            if (!user.GetUserByUserName(Username))
            {
                _response.ErrorCode = 11;
                _response.ErrorMsg = "User doesn't exist";
                _response.bool_result = false;

            }
            else
            {
                user.PassResetCode = Guid.NewGuid();
                user.Save();


                try
                {
                    MailMessage msg = new MailMessage();
                    string body = Combo.Properties.Resources.body;
                    string mail = Combo.Properties.Resources.mail;

                    string mailto = user.Email;
                    msg.To.Add(mailto);
                    msg.From = new MailAddress(mail);
                    msg.Subject = Combo.Properties.Resources.subject;
                    msg.IsBodyHtml = true;
                    msg.BodyEncoding = System.Text.Encoding.UTF8;

                    msg.Body = string.Format(body, user.UserName, user.PassResetCode.ToString());

                    SmtpClient client = new SmtpClient(Combo.Properties.Resources.mailserver, Convert.ToInt32(Combo.Properties.Resources.port));

                    client.UseDefaultCredentials = false;
                    client.EnableSsl = true;
                    client.Credentials = new System.Net.NetworkCredential(mail, Combo.Properties.Resources.mailpass);
                    client.Send(msg);
                }
                catch (Exception ex)
                {
                    _response.ErrorCode = 9999;
                    _response.ErrorMsg = "An Error Occured.Please try again.<br />" + ex.Message;
                    _response.bool_result = false;
                }
            }

            _response.Entity = null;
            SetContentResult(_response);
            return;
        }

        private void SetContentResult(dynamic data)
        {
            string result = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            HttpContext.Current.Response.ContentType = "application/json; charset=utf-8";
            HttpContext.Current.Response.Write(result);
        }
    }
}
