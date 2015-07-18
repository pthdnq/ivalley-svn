<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterAr.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="ComboPortal.Admin.EditUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/bootstrap-datepicker/css/datepicker.css" rel="stylesheet" />
    <link href="assets/bootstrap-timepicker/compiled/timepicker.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="PanelProfile" runat="server">
        <div class="widget">
            <div class="widget-title">
                <h4><i class="icon-user"></i>بيانات المستخدم  </h4>
                <span class="tools">
                    <asp:LinkButton ID="LinkButton1" PostBackUrl="~/Admin/UserManagement.aspx" OnClick="btnBack_Click" CssClass="btn btn-mini" runat="server"><i class="icon-arrow-right"></i> رجوع الى المستخدمين </asp:LinkButton>
                    <a href="javascript:;" class="icon-chevron-down"></a>
                </span>
            </div>
            <div class="widget-body">
                <div class="row-fluid">
                    <div class="span3">
                        <div class="text-center profile-pic">
                            <img id="ImgUser" runat="server" src="img/profile-pic2.png" alt="" />
                        </div>
                        <ul class="nav nav-tabs nav-stacked">
                            <li style="margin-bottom: 15px">
                                <table style="">
                                    <tr>
                                        <td>تاريخ انشاء الحساب : 
                                        </td>
                                        <td colspan="2">
                                            <asp:Label ID="lblCreatedDate" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>عدد البوستات :
                                        </td>
                                        <td>
                                            <asp:Label ID="lblPostsCounter" CssClass="badge badge-info" runat="server" Text="" />
                                            -
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="btnDeletePosts" OnClientClick="return confirm('هل تريد مسح كل المنشورات ؟')" OnClick="btnDeletePosts_Click" CssClass="btn btn-danger btn-small" runat="server"><i class="icon-trash mini"></i></asp:LinkButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>عدد الفلورز :
                                        </td>
                                        <td>
                                            <asp:Label ID="lblFollowersCounter" CssClass="badge badge-info" runat="server" Text="" />
                                            -
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="btnDeleteFollowers" OnClientClick="return confirm('هل تريد مسح كل الفلورز ؟')" OnClick="btnDeleteFollowers_Click" CssClass="btn btn-danger btn-small" runat="server"><i class="icon-trash"></i></asp:LinkButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>عدد الفلوينج :
                                        </td>
                                        <td>
                                            <asp:Label ID="lblFollowingCounter" CssClass="badge badge-info" runat="server" Text="" />
                                            -
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="btnDeleteFollowing" OnClientClick="return confirm('هل تريد مسح كل الفلوينج ؟')" OnClick="btnDeleteFollowing_Click" CssClass="btn btn-danger btn-small" runat="server"><i class="icon-trash"></i></asp:LinkButton>
                                        </td>
                                    </tr>
                                </table>
                            </li>
                            <li>
                                <asp:LinkButton ID="btnViewPosts" OnClick="btnViewPosts_Click" runat="server"><i class="icon-list-ul"></i>  عرض البوستات  </asp:LinkButton></li>
                            <li class="">
                                <asp:LinkButton ID="btnResetPass" OnClick="btnResetPass_Click" runat="server"><i class="icon-refresh"></i>  استرجاع كلمة المرور </asp:LinkButton></li>
                            <li>
                                <asp:LinkButton ID="btnResetSecureWord" OnClick="btnResetSecureWord_Click" runat="server"><i class="icon-refresh"></i>  استرجاع الكلمة السرية  </asp:LinkButton></li>
                            <li class="disabled">
                                <asp:LinkButton ID="btnBan" Enabled="false" runat="server"><i class="icon-ban-circle"></i> حظر </asp:LinkButton>
                            </li>

                            <%--                            <li>
                                <asp:LinkButton ID="btnDelete" runat="server"><i class="icon-remove"></i>  مسح  </asp:LinkButton></li>--%>
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
                                        <asp:TextBox ID="txtUserName" runat="server" Text=""></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">الاسم الظاهر :</td>
                                    <td>
                                        <asp:TextBox ID="txtDisplayName" runat="server" Text=""></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">البريد :</td>
                                    <td>
                                        <asp:TextBox ID="txtEmail" runat="server" Text=""></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">النوع :</td>
                                    <td>
                                        <asp:DropDownList ID="drpDwnGender" runat="server"></asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">البلد :</td>
                                    <td>
                                        <asp:DropDownList ID="drpDwnCountry" runat="server"></asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">المستوى :</td>
                                    <td>
                                        <asp:DropDownList ID="drpDwnRank" runat="server"></asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">التليفون :</td>
                                    <td>
                                        <asp:TextBox ID="txtTelephone" runat="server" Text=""></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">الموقع الالكترونى :</td>
                                    <td>
                                        <asp:TextBox ID="txtWebsite" runat="server" Text=""></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">تاريخ الميلاد :</td>
                                    <td>
                                        <div class="controls">
                                            <div class="input-append date date-picker" data-date="12-02-2012" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                                                <asp:TextBox ID="txtBirthday" CssClass="" runat="server" Style="direction: ltr" Text=""></asp:TextBox>
                                                <span class="add-on"><i class="icon-calendar"></i></span>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">السيرة الذاتية</td>
                                    <td>
                                        <asp:TextBox ID="literalBio" Rows="5" TextMode="MultiLine" Width="100%" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>توثيق الحساب</td>
                                    <td>
                                        <div id="DivAccountVerified" runat="server" visible="false" class="alert alert-success">
                                            <i class="icon-ok-sign"></i>هذا الحساب موثق
                                    <asp:LinkButton ID="btnDisableVerification" OnClick="btnDisableVerification_Click" OnClientClick="return confirm('هل تريد الغاء توثيق الحساب ؟')" CssClass="btn btn-danger btn-mini pull-left" runat="server">  الغاء التوثيق  <i class="icon-remove"></i></asp:LinkButton>
                                        </div>
                                        <div id="DivAccountNotVerified" runat="server" visible="false" class="alert alert-block">
                                            <i class="icon-info-sign"></i>هذا الحساب غير موثق
                                    <asp:LinkButton ID="btnVerify" OnClick="btnVerify_Click" OnClientClick="return confirm('هل تريد توثيق الحساب ؟')" CssClass="btn btn-success btn-mini pull-left" runat="server">  توثيق الحساب   <i class="icon-ok"></i></asp:LinkButton>
                                        </div>
                                    </td>
                                </tr>

                            </tbody>
                        </table>
                        <hr />
                        <asp:LinkButton ID="btnSaveProfile" CssClass="btn btn-success" OnClick="btnSaveProfile_Click" runat="server">حفظ <i class="icon-ok"></i></asp:LinkButton>
                    </div>
                </div>
                <%--                <hr />
                <div class="row-fluid">
                    <h4 class="">بيانات اخرى</h4>
                    <div class="span12">
                        <div class="span2">تاريخ انشاء الحساب :</div>
                        <div class="span3">
                            <asp:TextBox ID="TextBox1" runat="server" Text=""></asp:TextBox>
                        </div>
                        <div style="margin-right: 0" class="span2">المستوى :</div>
                        <div class="span3">
                            <asp:TextBox ID="TextBox2" runat="server" Text=""></asp:TextBox>
                        </div>
                    </div>
                </div>--%>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="PanelPosts" Visible="false" runat="server">
        <div class="widget">
            <div class="widget-title">
                <h4><i class="icon-list-ul"></i>بوستات المستخدم  </h4>
                <span class="tools">
                    <asp:LinkButton ID="btnBack" OnClick="btnBack_Click" CssClass="btn btn-mini" runat="server"><i class="icon-arrow-right"></i> رجوع الى البيانات </asp:LinkButton>
                    <a href="javascript:;" class="icon-chevron-down"></a>
                </span>
            </div>
            <div class="widget-body clearfix">
                <div class="span12" style="margin-right: 0;">
                    <asp:Repeater ID="RepeaterUserPosts" OnItemCommand="RepeaterUserPosts_ItemCommand" OnItemDataBound="RepeaterUserPosts_ItemDataBound" runat="server">
                        <ItemTemplate>
                            <div class="span10" style="margin-right: 0px">
                                <ul class="chats normal-chat">
                                    <li class="in">
                                        <img class="avatar" alt="" src='<%# string.IsNullOrWhiteSpace(Eval("ProfilePic").ToString())? "img/profile-pic2.png" : Eval("ProfilePic") %>' />
                                        <div class="message ">
                                            <span class="arrow"></span>
                                            <a class="name"><%# Eval("UserName") %></a>
                                            <span class="datetime"><%# Eval("PostDate") %></span>
                                            <span style="float: left">
                                                <asp:HiddenField ID="hfPostID" runat="server" Value='<%# Eval("ComboPostID") %>' />
                                                <asp:LinkButton ID="btnViewPost" PostBackUrl='<%# "ViewPost.aspx?pid=" + Eval("ComboPostID") %>' CssClass="btn btn-primary btn-mini" runat="server"><i class="icon-eye-open icon-white"></i></asp:LinkButton>
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
    <asp:Panel ID="PanelResetSecretWord" Visible="false" runat="server">
        <div class="widget">
            <div class="widget-title">
                <h4><i class="icon-refresh"></i>استرجاع الكلمة السرية</h4>
                <span class="tools">
                    <asp:LinkButton ID="btnBack3" OnClick="btnBack_Click" CssClass="btn btn-mini" runat="server"><i class="icon-arrow-right"></i> رجوع الى البيانات </asp:LinkButton>
                    <a href="javascript:;" class="icon-chevron-down"></a>
                </span>
            </div>
            <div class="widget-body clearfix">
                <div class="span12">
                    <div class="span2 clearfix">
                        الكلمة السرية
                    </div>
                    <div class="span5 clearfix">
                        <asp:TextBox ID="txtSecretWord" CssClass="form" TextMode="Password" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="resetSecretWord" Font-Bold="true" ControlToValidate="txtUserPassword" runat="server" ForeColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="span12" style="margin-right: 0px">
                    <div class="span2 clearfix">
                        تأكيد الكلمة السرية
                    </div>
                    <div class="span5 clearfix">
                        <asp:TextBox ID="txtConfirmSecretWord" TextMode="Password" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="resetSecretWord" Font-Bold="true" ControlToValidate="txtConfirmSecretWord" runat="server" ForeColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ValidationGroup="resetSecretWord" ForeColor="Red" ControlToValidate="txtConfirmSecretWord" ControlToCompare="txtSecretWord" ErrorMessage="الكلمة السرية غير متوافقة"></asp:CompareValidator>
                    </div>
                </div>
                <div class="span12" style="margin-right: 0px">
                    <div class="span1 clearfix">
                        <asp:LinkButton ID="btnChangeSecretWord" ValidationGroup="resetSecretWord" CssClass="btn btn-success" OnClick="btnChangeSecretWord_Click" runat="server">حفظ<i class="icon-ok"></i></asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
    <script src="assets/bootstrap-datepicker/js/bootstrap-datepicker.js"></script>
    <script src="assets/bootstrap-daterangepicker/date.js"></script>
    <script src="assets/bootstrap-daterangepicker/daterangepicker.js"></script>
    <script src="assets/bootstrap-timepicker/js/bootstrap-timepicker.js"></script>
</asp:Content>
