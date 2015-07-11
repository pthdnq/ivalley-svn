<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterAr.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="ComboPortal.Admin.EditUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="PanelProfile" runat="server">
        <div class="widget">
            <div class="widget-title">
                <h4><i class="icon-user"></i>بيانات المستخدم  </h4>
                <span class="tools">
                    <a href="javascript:;" class="icon-chevron-down"></a>
                </span>
            </div>
            <div class="widget-body">
                <div class="row-fluid">
                    <div class="span3">
                        <div class="text-center profile-pic">
                            <img id="ImgUser" runat="server" src="img/profile-pic.jpg" alt="" />
                        </div>
                        <ul class="nav nav-tabs nav-stacked">
                            <li>
                                <asp:LinkButton ID="btnViewPosts" OnClick="btnViewPosts_Click" runat="server"><i class="icon-list-ul"></i>  عرض البوستات  </asp:LinkButton></li>
                            <li class="">
                                <asp:LinkButton ID="btnResetPass" OnClick="btnResetPass_Click" runat="server"><i class="icon-refresh"></i>  استرجاع كلمة المرور </asp:LinkButton></li>
                            <li>
                                <asp:LinkButton ID="btnResetSecureWord" runat="server"><i class="icon-refresh"></i>  استرجاع الكلمة السرية  </asp:LinkButton></li>
                            <li>
                                <asp:LinkButton ID="btnBan" runat="server"><i class="icon-ban-circle"></i>  حظر  </asp:LinkButton></li>

                            <li>
                                <asp:LinkButton ID="btnDelete" runat="server"><i class="icon-remove"></i>  مسح  </asp:LinkButton></li>
                        </ul>
                    </div>
                    <div class="span6">
                        <h4>بيانات الحساب
                    <br />
                            <small>البيانات العامة</small></h4>
                        <table class="table table-borderless">
                            <tbody>
                                <tr>
                                    <td class="span3">اسم المستخدم :</td>
                                    <td>
                                        <asp:TextBox ID="lblUserName" runat="server" Text=""></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">الاسم الظاهر :</td>
                                    <td>
                                        <asp:TextBox ID="lblDisplayName" runat="server" Text=""></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">البريد :</td>
                                    <td>
                                        <asp:TextBox ID="lblEmail" runat="server" Text=""></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">النوع :</td>
                                    <td>
                                        <asp:TextBox ID="lblGender" runat="server" Text=""></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">البلد :</td>
                                    <td>
                                        <asp:TextBox ID="lblCountry" runat="server" Text=""></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">التليفون :</td>
                                    <td>
                                        <asp:TextBox ID="lblTelephone" runat="server" Text=""></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">الموقع الالكترونى :</td>
                                    <td>
                                        <asp:TextBox ID="lblWebsite" runat="server" Text=""></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">تاريخ الميلاد :</td>
                                    <td>
                                        <asp:TextBox ID="lblBirthday" runat="server" Text=""></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>توثيق الحساب</td>
                                    <td>
                                        <div class="alert alert-success">
                                            <i class="icon-ok-sign"></i>هذا الحساب موثق
                                    <asp:LinkButton ID="btnDisableVerification" CssClass="btn btn-danger btn-mini pull-left" runat="server">  الغاء التوثيق  <i class="icon-remove"></i></asp:LinkButton>
                                        </div>
                                        <div class="alert alert-block">
                                            <i class="icon-info-sign"></i>هذا الحساب غير موثق
                                    <asp:LinkButton ID="btnVerify" CssClass="btn btn-success btn-mini pull-left" runat="server">  توثيق الحساب   <i class="icon-ok"></i></asp:LinkButton>
                                        </div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                        <hr />
                        <h4>السيرة الذاتية</h4>
                        <p class="push">
                            <asp:TextBox ID="literalBio" Rows="5" TextMode="MultiLine" Width="500px" runat="server"></asp:TextBox>
                        </p>
                        <%-- <hr />
                    <asp:LinkButton ID="btnSaveProfile" CssClass="btn btn-success" runat="server">حفظ <i class="icon-ok"></i></asp:LinkButton>--%>
                    </div>
                </div>
                <hr />
                <div class="row-fluid">
                    <h4 class="">بيانات اخرى</h4>
                    <div class="span12">
                        <div class="span2">تاريخ انشاء الحساب :</div>
                        <div class="span3">
                            <asp:TextBox ID="TextBox1" runat="server" Text=""></asp:TextBox>
                        </div>
                        <div style="margin-right:0" class="span2">المستوى :</div>
                        <div class="span3">
                            <asp:TextBox ID="TextBox2" runat="server" Text=""></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="PanelPosts" Visible="false" runat="server">
        <div class="widget">
            <div class="widget-title">
                <h4><i class="icon-list-ul"></i>بوستات المسخدم  </h4>
                <span class="tools">
                    <asp:LinkButton ID="btnBack" OnClick="btnBack_Click" CssClass="btn btn-mini" runat="server"><i class="icon-arrow-right"></i> رجوع الى البيانات </asp:LinkButton>
                    <a href="javascript:;" class="icon-chevron-down"></a>
                </span>
            </div>
            <div class="widget-body clearfix">
                <div class="span12" style="margin-right: 0;">
                    <asp:Repeater ID="RepeaterUserPosts" OnItemCommand="RepeaterUserPosts_ItemCommand" runat="server">
                        <ItemTemplate>
                            <div class="span10" style="margin-right: 0px">
                                <ul class="chats normal-chat">
                                    <li class="in">
                                        <img class="avatar" alt="" src='<%# Eval("ProfilePic") %>' />
                                        <div class="message ">
                                            <span class="arrow"></span>
                                            <a href="#" class="name"><%# Eval("UserName") %></a>
                                            <span class="datetime"><%# Eval("PostDate") %></span>
                                            <span style="float: left">
                                                <asp:LinkButton ID="btnDeletePost" CommandName="deletePost" CommandArgument='<%# Eval("ComboPostID") %>' OnClientClick="return confirm('هل تريد حذف هذا البوست ؟');" CssClass="btn btn-danger btn-mini" runat="server"><i class="icon-remove icon-white"></i> مسح</asp:LinkButton>
                                            </span>
                                            <span class="body">
                                                <%# Eval("PostText") %>
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
    </asp:Panel>

    <asp:Panel ID="PanelResetPass" Visible="false" runat="server">
        <div class="widget">
            <div class="widget-title">
                <h4><i class="icon-refresh"></i>استرجاع كلمة السر</h4>
                <span class="tools">
                    <asp:LinkButton ID="btnBack2" OnClick="btnBack_Click" CssClass="btn btn-mini" runat="server"><i class="icon-arrow-right"></i> رجوع الى البيانات </asp:LinkButton>
                    <a href="javascript:;" class="icon-chevron-down"></a>
                </span>
            </div>
            <div class="widget-body clearfix">
                <div class="span12">
                    <div class="span2 clearfix">
                        كلمة المرور
                    </div>
                    <div class="span5 clearfix">
                        <asp:TextBox ID="txtUserPassword" CssClass="form" TextMode="Password" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="resetPass" Font-Bold="true" ControlToValidate="txtUserPassword" runat="server" ForeColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="span12" style="margin-right: 0px">
                    <div class="span2 clearfix">
                        تأكيد كلمة المرور
                    </div>
                    <div class="span5 clearfix">
                        <asp:TextBox ID="txtUserConfirmPass" TextMode="Password" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="resetPass" Font-Bold="true" ControlToValidate="txtUserConfirmPass" runat="server" ForeColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ValidationGroup="resetPass" ForeColor="Red" ControlToValidate="txtUserConfirmPass" ControlToCompare="txtUserPassword" ErrorMessage="كلمة المرور غير متوافقة"></asp:CompareValidator>
                    </div>
                </div>
                <div class="span12" style="margin-right: 0px">
                    <div class="span1 clearfix">
                        <asp:LinkButton ID="btnSavePass" ValidationGroup="resetPass" CssClass="btn btn-success" OnClick="btnSavePass_Click" runat="server">حفظ<i class="icon-ok"></i></asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
