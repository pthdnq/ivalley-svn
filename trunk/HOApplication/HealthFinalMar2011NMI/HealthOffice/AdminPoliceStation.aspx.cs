﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using MHO.BLL;

public partial class AdminPoliceStation : System.Web.UI.Page
{

    #region Events

    /// <summary>
    /// Load event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LoadGoves();
            Master.PageHeader = GetLocalResourceObject("lblHeaderPage").ToString();
            Master.MainHeader = GetLocalResourceObject("lblMainPage").ToString();
            Filter();
        }
    }

    /// <summary>
    /// Link Gove code click handler
    /// to allow edit this gov
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkGovCode_Click(object sender, EventArgs e)
    {
        LinkButton lnk = (LinkButton)sender;
        txtPoliceCode.Text = lnk.Text;
        txtPoliceName.Text = lnk.CommandArgument;
        drpGove.SelectedIndex = drpGove.Items.IndexOf(drpGove.Items.FindByValue(lnk.ToolTip));
        btnSave.Text = "تعديل";
        txtPoliceCode.ReadOnly = true;
    }

    /// <summary>
    /// Link Gove code click handler
    /// to allow edit this gov
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkDelete_Click(object sender, EventArgs e)
    {
        LinkButton lnk = (LinkButton)sender;
        POLICE_STATION delpolice = new POLICE_STATION();
        delpolice.LoadByPrimaryKey(int.Parse(lnk.CommandArgument));
        delpolice.MarkAsDeleted();
        delpolice.Save();
        Filter();
    }

    #endregion

    #region "Methods"

    private void Filter()
    {
        V_Police_Gove obj = new V_Police_Gove();
        obj.Where.GoveID.Value = short.Parse(drpGove.SelectedValue);
        obj.Where.GoveID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
        obj.Query.AddOrderBy(V_Police_Gove.ColumnNames.PoliceName, MyGeneration.dOOdads.WhereParameter.Dir.ASC);
        obj.Query.Load();
        grdGovernate.DataSource = obj.DefaultView;
        grdGovernate.DataBind();
    }

    #endregion

    protected void btnSave_Click(object sender, EventArgs e)
    {
        POLICE_STATION objpolice = new POLICE_STATION();
        if (txtPoliceCode.ReadOnly)
        {
            // update case
            objpolice.LoadByPrimaryKey(short.Parse(txtPoliceCode.Text));
            objpolice.DESCR = txtPoliceName.Text;
            objpolice.FK_GOVCD = short.Parse(drpGove.SelectedValue);
            objpolice.Save();
            txtPoliceCode.ReadOnly = false;
            Filter();
            //txtFilter.Text = "";
            txtPoliceCode.Text = "";
            txtPoliceName.Text = "";
            btnSave.Text = "اضافة";
        }
        else
        {
            try
            {
                //Insert case
                objpolice.AddNew();
                objpolice.CD = short.Parse(txtPoliceCode.Text);
                objpolice.DESCR = txtPoliceName.Text;
                objpolice.FK_GOVCD = short.Parse(drpGove.SelectedValue);
                objpolice.Save();
                Filter();
                //txtFilter.Text = "";
                txtPoliceCode.Text = "";
                txtPoliceName.Text = "";
            }
            catch
            {
                MHOCommon.ShowMessage("لقد حاولت ادخال كود موجود اوهناك خطأ فى البيانات", this.Page);
            }
        }
    }

    protected void grdGovernate_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdGovernate.PageIndex = e.NewPageIndex;
        Filter();
    }

    private void LoadGoves()
    {
        GOVERNORATE gov = new GOVERNORATE();
        gov.LoadAll();
        drpGove.DataSource = gov.DefaultView;
        drpGove.DataTextField = GOVERNORATE.ColumnNames.DESCR;
        drpGove.DataValueField = GOVERNORATE.ColumnNames.CD;
        drpGove.DataBind();
        drpGove.SelectedIndex = 0;
    }

    protected void drpGove_SelectedIndexChanged(object sender, EventArgs e)
    {
        Filter();
    }
}
