<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ExceptionLight.Master" AutoEventWireup="true" CodeBehind="addticket.aspx.cs" Inherits="Flights_GUI.tracker.addticket" %>
<%@ MasterType VirtualPath="~/MasterPages/ExceptionLight.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="default.aspx" class="btn btn-success pull-right" >Back to tickets</a>
    <div class="cell-12">
        <div class="cell-2 ">
            Title
        </div>
        <div class="cell-5 ">
            <asp:TextBox ID="uiTextBoxTitle" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" Font-Bold="true" ValidationGroup="add" ControlToValidate="uiTextBoxTitle"> </asp:RequiredFieldValidator>
        </div>
        <div class="clearfix margin-bottom-10"></div>
        
        <div class="cell-2 ">
            Description
        </div>
        <div class="cell-5 ">
            <asp:TextBox ID="uiTextBoxDesc" runat="server" TextMode="MultiLine" CssClass="form-control" Rows="5"></asp:TextBox>
        </div>
        <div class="clearfix margin-bottom-10"></div>
        <div class="cell-2 ">
            Ticket type
        </div>
        <div class="cell-5 ">
            <asp:DropDownList ID="uiDropDownListIssueType" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="clearfix margin-bottom-10"></div>

        <div class="cell-2 ">
            Attachment
        </div>
        <div class="cell-5 ">
            <asp:FileUpload ID="uiFileUploadAttach" runat="server" />
        </div>
        <div class="clearfix margin-bottom-10"></div>

        <div class="cell-2  "></div>
        <div class="cell-2  ">
            <asp:LinkButton ID="uLinkButtonAdd" runat="server" CssClass="btn btn-primary" ValidationGroup="add" OnClick="uLinkButtonAdd_Click">Save</asp:LinkButton>
        </div>
    </div>
</asp:Content>
