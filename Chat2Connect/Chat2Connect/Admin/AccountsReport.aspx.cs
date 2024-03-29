﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chat2Connect.Admin
{
    public partial class AccountsReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var roles = Helper.EnumUtil.GetValues<Helper.Enums.AdminRoles>().Select(r => new
                {
                    RoleName = r.ToString(),
                    RoleDisplayName = Helper.StringEnum.GetStringValue(r),
                }).ToList();
                lstRoles.DataTextField = "RoleDisplayName";
                lstRoles.DataValueField = "RoleName";
                lstRoles.DataSource = roles;
                lstRoles.DataBind();

                var lstStatus = Helper.EnumUtil.GetValues<Helper.Enums.RowStatus>().Select(r => new
                {
                    ID = (int)r,
                    Name = Helper.StringEnum.GetStringValue(r)
                }).ToList();
                lstAccountStatus.DataValueField = "ID";
                lstAccountStatus.DataTextField = "Name";
                lstAccountStatus.DataSource = lstStatus;
                lstAccountStatus.DataBind();
                lstAccountStatus.Items.Insert(0, new ListItem("", ""));
            }
        }

        protected void uiLinkButtonSearch_Click(object sender, EventArgs e)
        {
            BindResult();
        }

        protected void grdMemberResult_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdMemberResult.PageIndex = e.NewPageIndex;
            BindResult();
        }

        private void BindResult()
        {
            BLL.MembershipBLL account = new BLL.MembershipBLL();
            DateTime? dateFrom = null, dateTo = null;
            if (!String.IsNullOrEmpty(txtCreatedFrom.Text))
            {
                dateFrom = Helper.Date.ToDate(txtCreatedFrom.Text);
            }
            if (!String.IsNullOrEmpty(txtCreatedTo.Text))
            {
                dateTo = Helper.Date.ToDate(txtCreatedTo.Text);
            }
            int? status = null;
            if (!String.IsNullOrEmpty(lstAccountStatus.SelectedValue))
                status = Helper.TypeConverter.ToInt32(lstAccountStatus.SelectedValue);
            account.Search(txtEmail.Text, dateFrom, dateTo, lstRoles.SelectedValue,status);
            
            grdMemberResult.DataSource = account.DefaultView;
            grdMemberResult.DataBind();
        }
    }
}