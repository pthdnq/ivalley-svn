<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterAr.Master" AutoEventWireup="true" CodeBehind="VerifyAccount.aspx.cs" Inherits="ComboPortal.Admin.VerifyAccount" %>

<%@ MasterType VirtualPath="~/Admin/AdminMasterAr.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .label-custom {
            background: rgba(0, 0, 0, 0.03);
            border-radius: 2px;
            padding-right: 10px;
            padding-left: 10px;
            padding-top: 4px;
            padding-bottom: 4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="PanelGeneralRequests" runat="server">
        <div class="widget">
            <div class="widget-title">
                <h4><i class="icon-ok"></i>طلبات توثيق الحسابات</h4>
                <span class="tools">
                    <a href="javascript:;" class="icon-chevron-down"></a>
                </span>
            </div>
            <div class="widget-body clearfix">
                <div class="row-fluid">
                    <div class="span12">
                        <div class="tabbable tabbable-custom">
                            <ul class="nav nav-tabs">
                                <li class="active"><a href="#tab_1_1" data-toggle="tab">طلبات جديدة</a></li>
                                <li><a href="#tab_1_2" data-toggle="tab">طلبات تم توثيقها</a></li>
                                <li><a href="#tab_1_3" data-toggle="tab">طلبات تم رفضها</a></li>
                            </ul>
                            <div class="tab-content">
                                <div class="tab-pane active" id="tab_1_1">
                                    <p>
                                        <asp:GridView ID="GridViewNewRequests" AllowPaging="true" PageSize="10" OnPageIndexChanging="GridViewNewRequests_PageIndexChanging" OnRowDataBound="GridViewNewRequests_RowDataBound" CssClass="table table-striped table-bordered" EmptyDataText="لا يوجد بيانات متاحة" HorizontalAlign="Center" AutoGenerateColumns="false" runat="server">
                                            <Columns>
                                                <asp:BoundField HeaderText="اسم المستخدم" DataField="UserName" />
                                                <asp:BoundField HeaderText="الاسم الظاهر" DataField="DisplayName" />
                                                <asp:BoundField HeaderText="البريد الالكترونى" DataField="Email" />
                                                <asp:TemplateField HeaderText="نوع التوثيق">
                                                    <ItemTemplate>
                                                        <asp:HiddenField ID="hfRequestTypeID" runat="server" Value='<%# Eval("RequestTypeID") %>' />
                                                        <asp:Label ID="lblRequestType" runat="server" Text=""></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="العمليات">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="btnViewRequest" CssClass="btn btn-primary" PostBackUrl='<%# "~/Admin/VerifyAccount.aspx?vid=" + Eval("VerificationRequestID")  + "&uid=" + Eval("ComboUserID") %>' runat="server"><i class="icon-eye-open icon-white"></i> عرض الطلب</asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </p>
                                </div>
                                <div class="tab-pane" id="tab_1_2">
                                    <p>
                                        <asp:GridView ID="GridViewAcceptedRequests" AllowPaging="true" PageSize="10" OnPageIndexChanging="GridViewAcceptedRequests_PageIndexChanging" OnRowDataBound="GridViewAcceptedRequests_RowDataBound" CssClass="table table-striped table-bordered" EmptyDataText="لا يوجد بيانات متاحة" HorizontalAlign="Center" AutoGenerateColumns="false" runat="server">
                                            <Columns>
                                                <asp:BoundField HeaderText="اسم المستخدم" DataField="UserName" />
                                                <asp:BoundField HeaderText="الاسم الظاهر" DataField="DisplayName" />
                                                <asp:BoundField HeaderText="البريد الالكترونى" DataField="Email" />
                                                <asp:TemplateField HeaderText="نوع التوثيق">
                                                    <ItemTemplate>
                                                        <asp:HiddenField ID="hfRequestTypeID" runat="server" Value='<%# Eval("RequestTypeID") %>' />
                                                        <asp:Label ID="lblRequestType" runat="server" Text=""></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="العمليات">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="btnViewRequest" CssClass="btn btn-primary" PostBackUrl='<%# "~/Admin/VerifyAccount.aspx?vid=" + Eval("VerificationRequestID") + "&uid=" + Eval("ComboUserID")  %>' runat="server"><i class="icon-eye-open icon-white"></i> عرض الطلب</asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </p>
                                </div>
                                <div class="tab-pane" id="tab_1_3">
                                    <p>
                                        <asp:GridView ID="GridViewRefusedRequests" AllowPaging="true" PageSize="10" OnPageIndexChanging="GridViewRefusedRequests_PageIndexChanging" OnRowDataBound="GridViewRefusedRequests_RowDataBound" CssClass="table table-striped table-bordered" EmptyDataText="لا يوجد بيانات متاحة" HorizontalAlign="Center" AutoGenerateColumns="false" runat="server">
                                            <Columns>
                                                <asp:BoundField HeaderText="اسم المستخدم" DataField="UserName" />
                                                <asp:BoundField HeaderText="الاسم الظاهر" DataField="DisplayName" />
                                                <asp:BoundField HeaderText="البريد الالكترونى" DataField="Email" />
                                                <asp:TemplateField HeaderText="نوع التوثيق">
                                                    <ItemTemplate>
                                                        <asp:HiddenField ID="hfRequestTypeID" runat="server" Value='<%# Eval("RequestTypeID") %>' />
                                                        <asp:Label ID="lblRequestType" runat="server" Text=""></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="العمليات">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="btnViewRequest" CssClass="btn btn-primary" PostBackUrl='<%# "~/Admin/VerifyAccount.aspx?vid=" + Eval("VerificationRequestID")  + "&uid=" + Eval("ComboUserID")  %>' runat="server"><i class="icon-eye-open icon-white"></i> عرض الطلب</asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </asp:Panel>

    <asp:Panel ID="PanelRequestDetails" runat="server">
        <div class="widget">
            <div class="widget-title">
                <h4><i class="icon-ok"></i>بيانات الطلب</h4>
                <span class="tools">
                    <asp:LinkButton ID="LinkButton1" PostBackUrl="~/Admin/VerifyAccount.aspx" CssClass="btn btn-mini" runat="server"><i class="icon-arrow-right"></i> رجوع الى الطلبات </asp:LinkButton>
                    <a href="javascript:;" class="icon-chevron-down"></a>
                </span>
            </div>
            <div class="widget-body clearfix">
                <div class="row-fluid">
                    <div class="span12" style="margin-bottom: 15px; margin-right: 30px">
                        <div class="span2 text-center">
                            <img id="imgPic1" class="block-margin-bottom-5" runat="server" src="img/profile-pic2.png" />
                            <asp:Label ID="lblImgPic1" runat="server" Text="-"></asp:Label>
                        </div>
                        <div class="span1"></div>
                        <div class="span2 text-center">
                            <img id="imgPic2" class="block-margin-bottom-5" runat="server" src="img/profile-pic2.png" />
                            <asp:Label ID="lblImgPic2" runat="server" Text="-"></asp:Label>
                        </div>
                    </div>
                    <div class="span6">
                        <table class="table table-borderless">
                            <tbody>
                                <asp:Panel ID="PanelDetailsPersonalStore" Visible="false" runat="server">
                                    <tr>
                                        <td class="span3">الاسم فى الجواز/الهوية :</td>
                                        <td>
                                            <asp:Label ID="lblNameInPassport" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="span3">رقم الجواز/الهوية :</td>
                                        <td>
                                            <asp:Label ID="lblPassportNumber" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="span3">تاريج الميلاد :</td>
                                        <td>
                                            <asp:Label ID="lblBirthDate" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="span3">النوع :</td>
                                        <td>
                                            <asp:Label ID="lblGender" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="span3">الدولة :</td>
                                        <td>
                                            <asp:Label ID="lblCountry" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                </asp:Panel>
                                <asp:Panel ID="PanelDetailsOfficial" Visible="false" runat="server">
                                    <tr>
                                        <td class="span3">الاسم :</td>
                                        <td>
                                            <asp:Label ID="lblOfficialName" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="span3">الدولة :</td>
                                        <td>
                                            <asp:Label ID="lblOfficialCountry" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="span3">المدينة :</td>
                                        <td>
                                            <asp:Label ID="lblCity" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="span3">معلومات اكثر :</td>
                                        <td>
                                            <asp:Label ID="lblExtraInfo" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="span3">نشاط الشركة :</td>
                                        <td>
                                            <asp:Label ID="lblActivity" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                </asp:Panel>
                                <tr>
                                    <td class="span3">رقم الجوال :</td>
                                    <td>
                                        <asp:Label ID="lblPhone" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">رقم اخر للجوال :</td>
                                    <td>
                                        <asp:Label ID="lblPhone2" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">اسم الحساب :</td>
                                    <td>
                                        <asp:Label ID="lblAccountName" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">البريد الالكترونى :</td>
                                    <td>
                                        <asp:Label ID="lblEmail" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="span3">تاريخ ارسال الطلب :</td>
                                    <td>
                                        <asp:Label ID="lblRequestDate" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <asp:Panel ID="PanelResult" Visible="false" runat="server">
                                    <tr>
                                        <td colspan="2">
                                            <h4 style="color: black">نتيجة طلب التوثيق</h4>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="span3">اسم المراجع :</td>
                                        <td>
                                            <asp:Label ID="lblReviewerName" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="span3">تاريخ نتيجة الطلب :</td>
                                        <td>
                                            <asp:Label ID="lblStatusDate" CssClass="label-custom" Width="95%" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="span3">نتيجة منفذ الطلب :</td>
                                        <td>
                                            <asp:TextBox ID="txtResult" Enabled="false" TextMode="MultiLine" Rows="3" Width="95%" runat="server" Text=""></asp:TextBox>
                                        </td>
                                    </tr>
                                </asp:Panel>
                            </tbody>
                        </table>
                        <hr />

                        <asp:LinkButton ID="btnRefuseVerify" OnClick="btnRefuseVerify_Click" CssClass="btn btn-danger" runat="server"> رفض طلب التوثيق <i class="icon-remove"></i></asp:LinkButton>
                        <asp:LinkButton ID="btnAcceptVerify" OnClick="btnAcceptVerify_Click" CssClass="btn btn-success" runat="server">قبول طلب التوثيق <i class="icon-ok"></i></asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
