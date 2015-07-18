<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterAr.Master" AutoEventWireup="true" CodeBehind="PostsReports.aspx.cs" Inherits="ComboPortal.Admin.PostsReports" %>

<%@ MasterType VirtualPath="~/Admin/AdminMasterAr.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="widget">
            <div class="widget-title">
                <h4><i class="icon-list"></i>البلاغات   </h4>
                <span class="tools">
                    <a href="javascript:;" class="icon-chevron-down"></a>
                </span>
            </div>
            <div class="widget-body clearfix">
                <div class="span12" style="margin-right: 0;">
                    <asp:Panel ID="PanelGridGeneralReports" runat="server">
                        <div class="tabbable tabbable-custom">
                            <ul class="nav nav-tabs">
                                <li class="active"><a href="#tab_1_1" data-toggle="tab">بلاغات الحسابات</a></li>
                                <li><a href="#tab_1_2" data-toggle="tab">بلاغات البوستات</a></li>
                                <li><a href="#tab_1_3" data-toggle="tab">بلاغات التعليقات</a></li>
                            </ul>
                            <div class="tab-content">
                                <div class="tab-pane active" id="tab_1_1">
                                    <p>
                                        <asp:GridView ID="GridViewAccountReports" CssClass="table table-striped table-bordered" EmptyDataText="لا يوجد بيانات متاحة" HorizontalAlign="Center" AutoGenerateColumns="false" runat="server">
                                            <Columns>
                                                <asp:BoundField HeaderText="قائمة البلاغات (اسم المستخدم)" DataField="UserName" />
                                                <asp:BoundField HeaderText="عدد البلاغات" DataField="ReportsCount" />
                                                <asp:TemplateField HeaderText="العمليات">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="btnViewPost" CssClass="btn btn-primary" PostBackUrl='<%# "PostsReports.aspx?cur=" + Eval("UserID") %>' runat="server"><i class="icon-list-ul icon-white"></i> عرض البلاغات</asp:LinkButton>
                                                        <asp:LinkButton ID="LinkButton3" CssClass="btn btn-info" PostBackUrl='<%# "EditUser.aspx?uid=" + Eval("UserID") %>' runat="server"><i class="icon-eye-open icon-white"></i> عرض البروفايل</asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </p>
                                </div>
                                <div class="tab-pane" id="tab_1_2">
                                    <p>
                                        <asp:GridView ID="GridViewPostReports" CssClass="table table-striped table-bordered" EmptyDataText="لا يوجد بيانات متاحة" HorizontalAlign="Center" AutoGenerateColumns="false" runat="server">
                                            <Columns>
                                                <asp:BoundField HeaderText="قائمة البلاغات (محتوى البوست)" DataField="PostText" />
                                                <asp:BoundField HeaderText="عدد البلاغات" DataField="ReportsCount" />
                                                <asp:TemplateField HeaderText="العمليات">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="btnViewPost" CssClass="btn btn-primary" PostBackUrl='<%# "PostsReports.aspx?cpr=" + Eval("PostID") %>' runat="server"><i class="icon-list-ul icon-white"></i> عرض البلاغات</asp:LinkButton>
                                                        <asp:LinkButton ID="LinkButton3" CssClass="btn btn-info" PostBackUrl='<%# "ViewPost.aspx?pid=" + Eval("PostID") %>' runat="server"><i class="icon-eye-open icon-white"></i> عرض البوست</asp:LinkButton>

                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </p>
                                </div>
                                <div class="tab-pane" id="tab_1_3">
                                    <p>
                                        <asp:GridView ID="GridViewCommentReports" CssClass="table table-striped table-bordered" EmptyDataText="لا يوجد بيانات متاحة" HorizontalAlign="Center" AutoGenerateColumns="false" runat="server">
                                            <Columns>
                                                <asp:BoundField HeaderText="قائمة البلاغات (محتوى التعليق)" DataField="CommentText" />
                                                <asp:BoundField HeaderText="عدد البلاغات" DataField="ReportsCount" />
                                                <asp:TemplateField HeaderText="العمليات">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="btnViewPost" CssClass="btn btn-primary" PostBackUrl='<%# "PostsReports.aspx?ccr=" + Eval("CommentID") %>' runat="server"><i class="icon-list-ul icon-white"></i> عرض البلاغات</asp:LinkButton>
                                                        <asp:LinkButton ID="LinkButton3" CssClass="btn btn-info" PostBackUrl='<%# "ViewPost.aspx?pid=" + Eval("PostID") %>' runat="server"><i class="icon-eye-open icon-white"></i> عرض التعليق</asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="PanelGridUserReports" Visible="false" runat="server">
                        <asp:LinkButton ID="btnBack" PostBackUrl="~/Admin/PostsReports.aspx" CssClass="btn block-margin-bottom-5" runat="server"><i class="icon-forward"></i> رجوع الى البلاغات </asp:LinkButton>
                        <asp:GridView ID="GridViewUserReports" CssClass="table table-striped table-bordered" EmptyDataText="لا يوجد بيانات متاحة" HorizontalAlign="Center" AutoGenerateColumns="false" runat="server">
                            <Columns>
                                <asp:BoundField HeaderText="اسم المبلغ" DataField="UserName" />
                                <asp:BoundField HeaderText="التاريخ" DataField="ReportDate" />
                                <asp:BoundField HeaderText="محتوى البلاغ" DataField="ReportText" />
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                    <asp:Panel ID="PanelGridCommentReports" Visible="false" runat="server">
                        <asp:LinkButton ID="LinkButton1" PostBackUrl="~/Admin/PostsReports.aspx" CssClass="btn block-margin-bottom-5" runat="server"><i class="icon-forward"></i> رجوع الى البلاغات </asp:LinkButton>
                        <asp:GridView ID="GridCommentReports" CssClass="table table-striped table-bordered" EmptyDataText="لا يوجد بيانات متاحة" HorizontalAlign="Center" AutoGenerateColumns="false" runat="server">
                            <Columns>
                                <asp:BoundField HeaderText="اسم المبلغ" DataField="UserName" />
                                <asp:BoundField HeaderText="التاريخ" DataField="ReportDate" />
                                <asp:BoundField HeaderText="محتوى البلاغ" DataField="ReportText" />
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                    <asp:Panel ID="PanelGridPostReports" Visible="false" runat="server">
                        <asp:LinkButton ID="LinkButton2" PostBackUrl="~/Admin/PostsReports.aspx" CssClass="btn block-margin-bottom-5" runat="server"><i class="icon-forward"></i> رجوع الى البلاغات </asp:LinkButton>
                        <asp:GridView ID="GridPostReports" CssClass="table table-striped table-bordered" EmptyDataText="لا يوجد بيانات متاحة" HorizontalAlign="Center" AutoGenerateColumns="false" runat="server">
                            <Columns>
                                <asp:BoundField HeaderText="اسم المبلغ" DataField="UserName" />
                                <asp:BoundField HeaderText="التاريخ" DataField="ReportDate" />
                                <asp:BoundField HeaderText="محتوى البلاغ" DataField="ReportText" />
                            </Columns>
                        </asp:GridView>
                    </asp:Panel>
                </div>
            </div>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
