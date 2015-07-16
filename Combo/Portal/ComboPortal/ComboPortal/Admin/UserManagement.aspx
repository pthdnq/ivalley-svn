<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterAr.Master" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="ComboPortal.Admin.UserManagement" %>

<%@ MasterType VirtualPath="~/Admin/AdminMasterAr.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row-fluid">
        <div class="span12">
            <asp:Panel ID="PanelSearch" runat="server">
                <div class="widget">
                    <div class="widget-title">
                        <h4><i class="icon-search"></i>بحث عن المستخدمين  </h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down"></a>
                        </span>
                    </div>
                    <div class="widget-body clearfix">
                        <div class="span12">
                            <div class="span1 clearfix">
                                بحث
                            </div>
                            <div class="span2 clearfix">
                                <asp:TextBox ID="txtSearch" CssClass="form" runat="server"></asp:TextBox>
                            </div>
                            <div class="span2 clearfix">
                                <asp:LinkButton ID="btnSearchUser" OnClick="btnSearchUser_Click" CssClass="btn btn-primary" runat="server">بحث <i class="icon-search"></i></asp:LinkButton>
                            </div>
                        </div>
                        <div class="span12" style="margin-right: 0;">
                            <div class="span1 clearfix">
                                المستوى
                            </div>
                            <div class="span2 clearfix">
                                <asp:DropDownList ID="DropDownUserRank" runat="server"></asp:DropDownList>
                            </div>
                        </div>

                        <div class="span12" style="margin-right: 0;">
                            <asp:GridView ID="GridViewUsers" CssClass="table table-striped table-bordered" OnRowCommand="GridViewUsers_RowCommand" EmptyDataText="لا يوجد بيانات متاحة" HorizontalAlign="Center" AutoGenerateColumns="false" runat="server">
                                <Columns>
                                    <asp:BoundField HeaderText="اسم المستخدم" DataField="UserName" />
                                    <asp:BoundField HeaderText="الاسم الظاهر" DataField="DisplayName" />
                                    <asp:BoundField HeaderText="البريد الالكترونى" DataField="Email" />
                                    <asp:BoundField HeaderText="المستوى" DataField="Name" />
                                    <asp:TemplateField HeaderText="العمليات">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="btnViewPosts" CssClass="btn btn-primary" CommandName="viewProfile" PostBackUrl='<%# "~/Admin/EditUser.aspx?uid=" + Eval("ComboUserID")  %>' runat="server"><i class="icon-eye-open icon-white"></i> عرض البروفايل</asp:LinkButton>
                                            <%--<asp:LinkButton ID="btnDelete" CssClass="btn btn-danger" OnClientClick="return confirm('هل تريد حذف هذا المستخدم؟');" CommandName="deleteAccount" CommandArgument='<%# Eval("ComboUserID") %>' runat="server"><i class="icon-remove icon-white"></i> مسح</asp:LinkButton>--%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
