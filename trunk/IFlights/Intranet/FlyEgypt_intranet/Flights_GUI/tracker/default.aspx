<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ExceptionLight.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Flights_GUI.tracker._default" %>
<%@ MasterType VirtualPath="~/MasterPages/ExceptionLight.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <a href="addticket.aspx" class="btn btn-primary">Add new ticket</a>
    <div style="clear:both;height:10px;"></div>
    <asp:Panel runat="server" DefaultButton="btnSearch">
         <div class="toolsBar">
                    <div class="products-filter-top">                                
                        <div class="left">
                            <span>Search : </span>
                            <asp:TextBox ID="txtSearch" runat="server" style="vertical-align:middle;padding:3px;"></asp:TextBox> &nbsp;&nbsp;
                            ticket Type:
                            <asp:DropDownList ID="uiDropDownListType" runat="server"></asp:DropDownList> &nbsp;&nbsp;
                            <asp:LinkButton ID="btnSearch" OnClick="btnSearch_Click" CssClass="btn" runat="server" style="height:28px;line-height:normal;line-height:initial;padding-top:8px;">Search <i class="fa fa-search"></i></asp:LinkButton>
                        </div>
                    </div>
                </div>
            </asp:Panel>
    <asp:GridView ID="uiGridViewIssues" PageSize="20" CssClass="table table-bordered table-condensed" runat="server" AllowPaging="True" EmptyDataText="No record found."
         AutoGenerateColumns="False" OnPageIndexChanging="uiGridViewIssues_PageIndexChanging" OnRowCommand="uiGridViewIssues_RowCommand" 
        OnRowDataBound="uiGridViewIssues_RowDataBound">
        <Columns>
            <asp:BoundField DataField="IssueTitle" HeaderText="Title" />
            <asp:BoundField DataField="IssueDate" HeaderText="Date" DataFormatString="{0:dd/MM/yyyy}"/>
            <asp:TemplateField HeaderText="Type">
                <ItemTemplate>
                    <%# Eval("TypeName") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                    <%# Eval("StatusName") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Added by">
                <ItemTemplate>
                    <%# Eval("UserName") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
                    <asp:LinkButton ID="uiLinkButtonEdit" runat="server" CommandArgument='<%# Eval("IssueID") %>' CommandName="EditIssue" Text="Edit" ></asp:LinkButton>    
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <RowStyle HorizontalAlign="Center" />
    </asp:GridView>
</asp:Content>
