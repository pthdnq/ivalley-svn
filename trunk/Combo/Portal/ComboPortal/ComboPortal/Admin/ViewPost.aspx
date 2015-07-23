<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterAr.Master" AutoEventWireup="true" CodeBehind="ViewPost.aspx.cs" Inherits="ComboPortal.Admin.ViewPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="widget">
            <div class="widget-title">
                <h4><i class="icon-list-ul"></i>عرض البوست و التعليقات</h4>
                <span class="tools">
                    <asp:LinkButton ID="LinkButton1" CssClass="btn btn-mini" OnClientClick="JavaScript:window.history.back(1);return false;" runat="server"><i class="icon-arrow-right"></i> رجوع  </asp:LinkButton>
                    <a href="javascript:;" class="icon-chevron-down"></a>
                </span>
            </div>
            <div class="widget-body clearfix">
                <div class="row-fluid">
                    <div class="span12" style="margin-right: 0;">
                        <ul class="chats normal-chat">
                            <li class="in">
                                <img class="avatar" id="imgUserProfile" runat="server" alt="" src='img/profile-pic2.png' />
                                <div class="message">
                                    <span class="arrow"></span>
                                    <a class="name">
                                        <asp:Label ID="lblUserName" runat="server" Text="" /></a>
                                    <span class="datetime">
                                        <asp:Label ID="lblPostDate" runat="server" Text="" /></span>
                                    <span class="body">
                                        <asp:Label ID="lblPostText" runat="server" Text="" /></span>
                                    <asp:Panel ID="PanelAttachment" Visible="false" runat="server">
                                        <hr />
                                        <img id="imgAttachment" runat="server" style="max-height: 200px" visible="false" src="#" />
                                        <audio id="audioAttachment" runat="server" visible="false" src="#" />
                                        <video id="videoAttachment" runat="server" style="max-height:200px" visible="false" src="#" />
                                    </asp:Panel>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class="row-fluid">
                    <div class="span1"></div>
                    <div class="span10">
                        <asp:Repeater ID="RepeaterComments" OnItemCommand="RepeaterComments_ItemCommand" OnItemDataBound="RepeaterComments_ItemDataBound" runat="server">
                            <ItemTemplate>
                                <div class="span12" style="margin-right: 0px">
                                    <ul class="chats normal-chat">
                                        <li class="in">
                                            <img class="avatar" id="imgUserProfile" runat="server" alt="" src='<%# string.IsNullOrWhiteSpace(Eval("ProfilePic").ToString())? "img/profile-pic2.png" : "api.combomobile.com" +  Eval("ProfilePic") %>' />
                                            <div class="message">
                                                <span class="arrow"></span>
                                                <a class="name"><%# Eval("UserName") %></a>
                                                <span class="datetime"><%# Eval("CommentDate") %></span>
                                                <span style="float: left">
                                                    <asp:LinkButton ID="btnDeleteComment" CommandName="deleteComment" CommandArgument='<%# Eval("ComboCommentID") %>' OnClientClick="return confirm('هل تريد حذف هذا التعليق ؟');" CssClass="btn btn-danger btn-mini" runat="server"><i class="icon-remove icon-white"></i> مسح</asp:LinkButton>
                                                </span>
                                                <span class="body">
                                                    <%# Eval("CommentText") %>
                                                    <asp:Panel ID="PanelAttachment" Visible="false" runat="server">
                                                        <hr />
                                                        <asp:HiddenField ID="hfCommentID" runat="server" Value='<%# Eval("ComboCommentID") %>' />
                                                        <%--<img id="imgAttachment" runat="server" style="max-height: 200px" visible="false" src="#" />--%>
                                                        <audio id="audioAttachment" runat="server" visible="false" src="#" />
                                                        <%--<video id="videoAttachment" runat="server" visible="false" src="#" />--%>
                                                    </asp:Panel>
                                                </span>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>

                </div>
            </div>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
