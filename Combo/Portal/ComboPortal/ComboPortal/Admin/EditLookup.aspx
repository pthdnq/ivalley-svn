<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterAr.Master" AutoEventWireup="true" CodeBehind="EditLookup.aspx.cs" Inherits="ComboPortal.Admin.EditLookup" ValidateRequest="false" EnableEventValidation="false" %>
<%@ MasterType VirtualPath="~/Admin/AdminMasterAr.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<link href="assets/ckeditor/contents.css" rel="stylesheet" />--%>
    <script src="assets/ckeditor/ckeditor.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="widget">
        <div class="widget-title">
            <h4><i class="icon-list-alt"></i>تعديل المحتوى  </h4>
            <span class="tools">
                <a href="javascript:;" class="icon-chevron-down"></a>
            </span>
        </div>
        <div class="widget-body clearfix">
            <textarea id="txtData" runat="server" rows="10" class="ckeditor"></textarea>
            <hr />
            <asp:LinkButton ID="btnSave" OnClick="btnSave_Click" CssClass="btn btn-success" runat="server">حفظ <i class="icon-ok"></i></asp:LinkButton>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
