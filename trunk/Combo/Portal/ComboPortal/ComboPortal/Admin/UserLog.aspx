<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterAr.Master" AutoEventWireup="true" CodeBehind="UserLog.aspx.cs" Inherits="ComboPortal.Admin.UserLog" %>

<%@ MasterType VirtualPath="~/Admin/AdminMasterAr.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .label-def {
            background: rgba(0, 0, 0, 0.03);
            border-radius: 2px;
            padding-right: 10px;
            padding-left: 10px;
            padding-top: 4px;
            padding-bottom: 4px;
        }

        .label-old {
            background: rgba(255, 0, 0, 0.07);
            border-radius: 2px;
            padding-right: 10px;
            padding-left: 10px;
            padding-top: 4px;
            padding-bottom: 4px;
        }

        .label-new {
            background: rgba(34, 255, 0, 0.07);
            border-radius: 2px;
            padding-right: 10px;
            padding-left: 10px;
            padding-top: 4px;
            padding-bottom: 4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="PanelGeneralReports" runat="server">
        <div class="widget">
            <div class="widget-title">
                <h4><i class="icon-list"></i>التقارير </h4>
                <span class="tools">
                    <asp:LinkButton ID="LinkButton1" PostBackUrl="~/Admin/UserManagement.aspx" CssClass="btn btn-mini" runat="server"><i class="icon-arrow-right"></i> رجوع الى المستخدمين </asp:LinkButton>
                    <a href="javascript:;" class="icon-chevron-down"></a>
                </span>
            </div>
            <div class="widget-body clearfix">
                <div class="span12" style="margin-right: 0;">
                    <asp:GridView ID="GridViewReports" CssClass="table table-striped table-bordered" OnRowCommand="GridViewReports_RowCommand" EmptyDataText="لا يوجد بيانات متاحة" HorizontalAlign="Center" AutoGenerateColumns="false" runat="server">
                        <Columns>
                            <asp:BoundField HeaderText="التاريخ" DataField="LogDate" />
                            <asp:TemplateField HeaderText="العمليات">
                                <ItemTemplate>
                                    <asp:LinkButton ID="btnViewReports" CssClass="btn btn-primary" CommandArgument='<%# Eval("ComboUserLogID") %>' CommandName="viewReports" runat="server"><i class="icon-list-alt icon-white"></i> عرض التقرير</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </asp:Panel>

    <asp:Panel ID="PanelViewReport" runat="server">
        <div class="widget">
            <div class="widget-title">
                <h4><i class="icon-list-alt"></i>التقرير </h4>
                <span class="tools">
                    <asp:LinkButton ID="btnBacktoGeneral" OnClick="btnBacktoGeneral_Click" CssClass="btn btn-mini" runat="server"><i class="icon-arrow-right"></i> رجوع الى التقارير </asp:LinkButton>
                    <a href="javascript:;" class="icon-chevron-down"></a>
                </span>
            </div>
            <div class="widget-body clearfix">
                <div class="span12" style="margin-right: 0;">
                    <div class="span7">
                        <table class="table table-borderless">
                            <tbody>
                                <tr>
                                    <td class="span3">اسم المستخدم :</td>
                                    <td>
                                        <asp:Label ID="lblUserNameBefore" CssClass="label-def" Width="95%" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblUserNameAfter" CssClass="label-def" runat="server" Width="95%" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">الاسم الظاهر :</td>
                                    <td>
                                        <asp:Label ID="lblDisplayNameBefore" CssClass="label-def" Width="95%" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblDisplayNameAfter" CssClass="label-def" runat="server" Width="95%" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">البريد :</td>
                                    <td>
                                        <asp:Label ID="lblEmailBefore" CssClass="label-def" Width="95%" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblEmailAfter" CssClass="label-def" runat="server" Width="95%" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">البلد :</td>
                                    <td>
                                        <asp:Label ID="lblCountryBefore" CssClass="label-def" Width="95%" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblCountryAfter" CssClass="label-def" runat="server" Width="95%" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">المستوى :</td>
                                    <td>
                                        <asp:Label ID="lblRankBefore" CssClass="label-def" Width="95%" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblRankAfter" CssClass="label-def" runat="server" Width="95%" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">التليفون :</td>
                                    <td>
                                        <asp:Label ID="lblTelephoneBefore" CssClass="label-def" Width="95%" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblTelephoneAfter" CssClass="label-def" runat="server" Width="95%" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">الموقع الالكترونى :</td>
                                    <td>
                                        <asp:Label ID="lblWebsiteBefore" CssClass="label-def" Width="95%" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblWebsiteAfter" CssClass="label-def" runat="server" Width="95%" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">تاريخ الميلاد :</td>
                                    <td>
                                        <asp:Label ID="lblBirthDateBefore" CssClass="label-def" Width="95%" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblBirthDateAfter" CssClass="label-def" runat="server" Width="95%" Text=""></asp:Label>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
