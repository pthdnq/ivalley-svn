<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAr.Master" AutoEventWireup="true" CodeBehind="Job_Order.aspx.cs" Inherits="TouchMediaGUI.Job_Order" %>
<%@ Register Src="~/usercontrols/ucJobOrderProduction.ascx" TagPrefix="uc1" TagName="ucJobOrderProduction" %>
<%@ Register Src="~/usercontrols/ucJobOrderPrinting.ascx" TagPrefix="uc1" TagName="ucJobOrderPrinting" %>
<%@ Register Src="~/usercontrols/ucPurchaseOrder.ascx" TagPrefix="uc2" TagName="ucPurchaseOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/fancybox/source/jquery.fancybox.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="assets/gritter/css/jquery.gritter.css" />
    <link rel="stylesheet" type="text/css" href="assets/uniform/css/uniform.default.css" />
    <link rel="stylesheet" type="text/css" href="assets/chosen-bootstrap/chosen/chosen.css" />
    <link rel="stylesheet" type="text/css" href="assets/jquery-tags-input/jquery.tagsinput.css" />
    <link rel="stylesheet" type="text/css" href="assets/clockface/css/clockface.css" />
    <link rel="stylesheet" type="text/css" href="assets/bootstrap-wysihtml5/bootstrap-wysihtml5.css" />
    <link rel="stylesheet" type="text/css" href="assets/bootstrap-datepicker/css/datepicker.css" />
    <link rel="stylesheet" type="text/css" href="assets/bootstrap-timepicker/compiled/timepicker.css" />
    <link rel="stylesheet" type="text/css" href="assets/bootstrap-colorpicker/css/colorpicker.css" />
    <link rel="stylesheet" href="assets/bootstrap-toggle-buttons/static/stylesheets/bootstrap-toggle-buttons.css" />
    <link rel="stylesheet" href="assets/data-tables/DT_bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="assets/bootstrap-daterangepicker/daterangepicker.css" />
    <style type="text/css">
        .row-fluid [class*="span"] {
            margin-right: 0 !important;
        }

        .checkSections td label {
            display: inline;
            padding-right: 5px;
            padding-left: 10px;
        }

        .checkSections td label {
            display: inline;
            padding-right: 5px;
            padding-left: 10px;
        }

        .label-def {
            background: rgba(0, 0, 0, 0.05);
            border-radius: 2px;
            padding-right: 10px;
            padding-left: 10px;
            padding-top: 4px;
            padding-bottom: 4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row-fluid ">
        <div class="span12">
            <asp:Panel ID="PanelJobOrdersGrid" runat="server">
                <div class="widget">
                    <div class="widget-title">
                        <h4><i class="icon-reorder"></i>أوامر الشغل</h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down"></a>
                        </span>
                    </div>
                    <div class="widget-body">
                        <div class="row-fluid">
                            <div class="span12">
                                <div style="margin-bottom: 7px;">
                                    <asp:LinkButton ID="btnAddNewJobOrder" CssClass="btn btn-warning" OnClick="btnAddNewJobOrder_Click" runat="server"><i class="icon-plus icon-white"></i> انشاء امر شغل</asp:LinkButton>
                                </div>
                                <asp:GridView ID="GrdViewJobOrders" OnRowCommand="GrdViewJobOrders_RowCommand" CssClass="table table-striped table-bordered" AutoGenerateColumns="false" runat="server">
                                    <Columns>
                                        <asp:BoundField DataField="JobOrderCode" HeaderText="كود امر الشغل" />
                                        <asp:BoundField DataField="ClientName" HeaderText="أسم العميل" DataFormatString="{0:dd/MM/yyyy}" />
                                        <asp:BoundField DataField="JobOrderName" HeaderText="أسم العملية" DataFormatString="{0:dd/MM/yyyy}" />
                                        <asp:TemplateField HeaderText="الحالة">
                                            <ItemTemplate>
                                                <span class='label label-<%# Eval("StatusClass") %>'><%# Eval("StatusNameAr") %></span>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="العمليات">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnEdit" runat="server" CssClass="btn btn-primary" CommandArgument='<%# Eval ("JobOrderID") %>' CommandName="editJobOrder"><i class="icon-pencil"></i> تعديل</asp:LinkButton>
                                                <asp:LinkButton ID="btnPrintPur" CssClass="btn btn-info" runat="server" CommandArgument='<%# Eval ("JobOrderID") %>' CommandName="PrintPurchase"><i class="icon-print"></i> طباعة</asp:LinkButton>
                                                <asp:LinkButton ID="btnDelete" CssClass="btn btn-danger" OnClientClick="return confirm('هل تريد حذف هذا السجل ?')" runat="server" CommandArgument='<%# Eval("JobOrderID") %>' CommandName="deleteJobOrder"><i class="icon-trash"></i> حذف</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <div class="span3 block-margin-bottom-5">
                <asp:LinkButton ID="btnBackToGrid" Visible="false" OnClick="btnBackToGrid_Click" CssClass="btn btn-danger btn-small" runat="server"><i class="icon-arrow-right"></i>  رجوع الى اوامر الشغل</asp:LinkButton>
            </div>
            <asp:Panel ID="PanelJobOrderMasterDetails" runat="server">
                <div class="widget">
                    <div class="widget-title">
                        <h4><i class="icon-reorder"></i>بيانات امر الشغل</h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down"></a>
                        </span>
                    </div>
                    <div class="widget-body">
                        <div class="row-fluid">
                            <div class="span12">
                                <div class="form-horizontal">
                                    <div class="block-margin-bottom-5 span12 clearfix">
                                        <div class="span6">
                                            <label class="control-label">كود أمر الشغل</label>
                                            <asp:TextBox runat="server" ID="txtJobOrderCode"></asp:TextBox>
                                        </div>
                                        <div class="span6">
                                            <label class="control-label">أسم العميل</label>
                                            <asp:DropDownList runat="server" ID="drpClientName"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
                                        <div class="span6">
                                            <label class="control-label">أسم العملية</label>
                                            <asp:TextBox runat="server" ID="txtGeneralOperationName"></asp:TextBox>
                                        </div>
                                        <div class="span6">
                                            <label class="control-label">الحالة</label>
                                            <asp:DropDownList runat="server" ID="drpGeneralStatus"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="clearfix">
                                        <hr />
                                    </div>
                                    <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
                                        <asp:LinkButton runat="server" ID="btnSaveMasterJobOrder" OnClick="btnSaveMasterJobOrder_Click" class="btn btn-success">حفظ <i class="icon-ok icon-white" ></i></asp:LinkButton>
                                        <asp:LinkButton runat="server" ID="btnCancelMasterJobOrder" OnClick="btnCancelMasterJobOrder_Click" class="btn btn-danger">الغاء  <i class="icon-remove icon-white" ></i></asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="PanelJobOrderDetails" runat="server">
                <div class="widget">
                    <div class="widget-title">
                        <h4><i class="icon-reorder"></i>تفاصيل امر الشغل</h4>
                        <span class="tools">
                            <a href="javascript:;" class="icon-chevron-down"></a>
                        </span>
                    </div>
                    <div class="widget-body">
                        <div class="row-fluid">
                            <div class="span12">
                                <div class="tabbable tabbable-custom">
                                    <ul class="nav nav-tabs">
                                        <li class="active"><a href="#tab_1_1" data-toggle="tab">تصنيع</a></li>
                                        <li><a href="#tab_1_2" data-toggle="tab">طباعة</a></li>
                                        <li><a href="#tab_1_3" data-toggle="tab">توريد</a></li>
                                    </ul>
                                    <div class="tab-content">
                                        <div class="tab-pane active" id="tab_1_1">
                                            <uc1:ucJobOrderProduction runat="server" ID="ucJobOrderProduction" />
                                        </div>
                                        <div class="tab-pane " id="tab_1_2">

                                            <uc1:ucJobOrderPrinting runat="server" ID="ucJobOrderPrinting" />
                                        </div>
                                        <div class="tab-pane " id="tab_1_3">
                                            <uc2:ucPurchaseOrder runat="server" id="ucPurchaseOrder" />
                                        </div>
                                    </div>
                                </div>
                                <hr />
                                <asp:LinkButton ID="btnSaveJobOrder" Width="90px" CssClass="btn btn-success" runat="server">حفظ  <i class="icon-ok"></i></asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderScriptsPurchaseOrder" runat="server">
    <script type="text/javascript" src="assets/bootstrap-datepicker/js/bootstrap-datepicker.js"></script>
    <script type="text/javascript" src="assets/bootstrap-daterangepicker/date.js"></script>
    <script type="text/javascript" src="assets/bootstrap-daterangepicker/daterangepicker.js"></script>
    <script type="text/javascript" src="assets/bootstrap-timepicker/js/bootstrap-timepicker.js"></script>
</asp:Content>
