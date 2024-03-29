﻿ <%@ Page Title="" Language="C#" MasterPageFile="~/MasterAr.Master" AutoEventWireup="true" CodeBehind="PurchaseOrder.aspx.cs" Inherits="TouchMediaGUI.PurchaseOrder" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ MasterType VirtualPath="~/MasterAr.Master" %>
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
    </style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderScriptsPurchaseOrder" runat="server">

    <script type="text/javascript" src="assets/bootstrap-datepicker/js/bootstrap-datepicker.js"></script>
    <script type="text/javascript" src="assets/bootstrap-daterangepicker/date.js"></script>
    <script type="text/javascript" src="assets/bootstrap-daterangepicker/daterangepicker.js"></script>
    <script type="text/javascript" src="assets/bootstrap-timepicker/js/bootstrap-timepicker.js"></script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <ul class="breadcrumb">
        <li>
            <a href="Splash.aspx"><i class="icon-home"></i></a><span class="divider">&nbsp;</span>
        </li>
        <li><a>اوامر الشراء</a><span class="divider-last">&nbsp;</span>
        </li>
    </ul>
    <div class="row-fluid">

        <div class="span12">
            <div class="widget" id="widPurchaseReport" runat="server" aria-expanded="false" visible="false">
                <div class="widget-title">
                    <h4><i class="icon-search"></i>طباعة أوامر الشراء </h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>
                        <a href="javascript:;" class="icon-remove"></a>
                    </span>

                </div>
                <div class="widget-body" >
                    <div class="row-fluid">
                        <div class="span12 clearfix" id="PanelReport" runat ="server">
                        <rsweb:ReportViewer Width="100%" Height="1000px" SizeToReportContent="true" ID="ReportViewer1" runat="server"></rsweb:ReportViewer>
                            </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="span12">
            <div class="widget" id="widPurchaseOrderSearch" runat="server" aria-expanded="false">
                <div class="widget-title">
                    <h4><i class="icon-search"></i>بحث أوامر الشراء </h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>
                        <a href="javascript:;" class="icon-remove"></a>
                    </span>

                </div>
                <div class="widget-body">
                    <div class="row-fluid">
                        <asp:Panel ID="PanelPurSearch" runat="server" DefaultButton="btnPurSearch">
                            <div class="span12">
                                <div class="form-horizontal">
                                    <div class="block-margin-bottom-5 span12 clearfix">
                                        <div class="span6">


                                            <label class="control-label">التاريخ من</label>
                                            <div class="input-append date date-picker" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                                                <asp:TextBox runat="server" CssClass="m-ctrl-medium date-picker" Font-Size="16" type="text" ID="txtPurDateFromSearch" Style="direction: ltr" />
                                                <span class="add-on">
                                                    <i class="icon-calendar"></i>
                                                </span>
                                            </div>


                                        </div>
                                        <div class="span6">
                                            <label class="control-label">التاريخ الي</label>
                                            <div class="input-append date date-picker" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                                                <asp:TextBox runat="server" CssClass="m-ctrl-medium date-picker" Font-Size="16" type="text" ID="txtPurDateToSearch" Style="direction: ltr" />
                                                <span class="add-on">
                                                    <i class="icon-calendar"></i>
                                                </span>
                                            </div>


                                        </div>

                                    </div>
                                    <div class="block-margin-bottom-5 span12 clearfix">
                                        <div class="span6">


                                            <label class="control-label">ميعاد التسليم من</label>
                                            <div class="input-append date date-picker" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                                                <asp:TextBox runat="server" CssClass="m-ctrl-medium date-picker" Font-Size="16" type="text" ID="txtPurDeliveryDateFromSearch" Style="direction: ltr" />
                                                <span class="add-on">
                                                    <i class="icon-calendar"></i>
                                                </span>
                                            </div>


                                        </div>
                                        <div class="span6">
                                            <label class="control-label">ميعاد التسليم الي</label>
                                            <div class="input-append date date-picker" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                                                <asp:TextBox runat="server" CssClass="m-ctrl-medium date-picker" Font-Size="16" type="text" ID="TxtPurDeliveryDateToSearch" Style="direction: ltr" />
                                                <span class="add-on">
                                                    <i class="icon-calendar"></i>
                                                </span>
                                            </div>


                                        </div>

                                    </div>
                                    <div class="block-margin-bottom-5 span12 clearfix">
                                        <div class="span6">
                                            <label class="control-label">رقم أمر الشراء</label>
                                            <asp:TextBox runat="server" type="text" ID="txtPurOrderNumber" />
                                        </div>
                                        <div class="span6">
                                            <asp:LinkButton runat="server" ID="btnPurSearch" OnClick="btnPurSearch_Click" class="btn btn-success"><i class="icon-search icon-white" ></i>بحث</asp:LinkButton>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </asp:Panel>

                    </div>
                </div>
            </div>
            <div class="widget" id="WidPurchaseGeneral" runat ="server">
                <div class="widget-title">
                    <h4><i class="icon-shopping-cart"></i>اوامر الشراء </h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>
                    </span>
                </div>
                <div class="widget-body">
                    <div class="row-fluid">
                        <div class="span12">
                            <asp:Panel ID="PanelPurchaseOrdersGrid" runat="server">
                                <div style="margin-bottom: 7px;">
                                    <asp:LinkButton ID="btnAddNewOrder" CssClass="btn btn-warning" OnClick="btnAddNewOrder_Click" runat="server"><i class="icon-plus icon-white"></i> انشاء امر شراء</asp:LinkButton>
                                </div>
                                <asp:GridView ID="GrdViewPurchaseOrders" OnRowCommand="GrdViewPurchaseOrders_RowCommand" CssClass="table table-striped table-bordered" AutoGenerateColumns="false" runat="server">
                                    <Columns>
                                        <asp:BoundField DataField="PurchaseOrderNumber" HeaderText="رقم امر الشراء" />
                                        <asp:BoundField DataField="PurchaseOrderDate" HeaderText="تاريخ امر الشراء" DataFormatString="{0:dd/MM/yyyy}" />
                                        <asp:BoundField DataField="DeliveryDate" HeaderText="ميعاد التسليم" DataFormatString="{0:dd/MM/yyyy}" />
                                        <asp:BoundField DataField="DeliveryPlace" HeaderText="مكان التسليم" />
                                        <asp:TemplateField HeaderText="العمليات">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnDelete" OnClientClick="return confirm('هل تريد حذف هذا السجل ?')" runat="server" CommandArgument='<%# Eval("PurchaseOrderID") %>' CommandName="deleteGeneralOrder">حذف</asp:LinkButton>
                                                <asp:LinkButton ID="btnEdit" runat="server" CommandArgument='<%# Eval ("PurchaseOrderID") %>' CommandName="editGeneralOrder">تعديل</asp:LinkButton>
                                                <asp:LinkButton ID="btnPrintPur" runat="server" CommandArgument='<%# Eval ("PurchaseOrderID") %>' CommandName="PrintPurchase">طباعة</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </asp:Panel>
                            <asp:Panel Visible="false" ID="PanelPurchaseOrderGeneral" runat="server">
                                <div class="form-horizontal">
                                    <div class="block-margin-bottom-5 span12 clearfix">
                                        <div class="span6">
                                            <label class="control-label">رقم أمر الشراء</label>
                                            <asp:TextBox runat="server" type="text" ID="txtPurchaseOrderNumber" />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtPurchaseOrderNumber"
                                                ValidationExpression="^\d+$"
                                                Display="Static"
                                                ErrorMessage="أرقام فقط"
                                                ValidationGroup="dlr"
                                                runat="server"></asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtPurchaseOrderNumber" ValidationGroup="dlr" runat="server" ForeColor="Red" Font-Bold="true" ErrorMessage="*" />
                                        </div>
                                        <div class="span6">
                                            <label class="control-label">التاريخ</label>
                                            <div class="input-append date date-picker" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                                                <asp:TextBox runat="server" CssClass="m-ctrl-medium date-picker" Font-Size="16" type="text" ID="txtPurchaseOrderDate" Style="direction: ltr" />
                                                <span class="add-on">
                                                    <i class="icon-calendar"></i>
                                                </span>
                                            </div>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtPurchaseOrderDate" ValidationGroup="dlr" runat="server" ForeColor="Red" Font-Bold="true" ErrorMessage="*" />
                                        </div>
                                    </div>
                                    <div class="block-margin-bottom-5 span12 clearfix">
                                        <div class="span6">
                                            <label class="control-label">الادارة</label>
                                            <asp:TextBox runat="server" type="text" ID="txtManagement" />
                                        </div>

                                        <div class="span6">

                                            <label class="control-label">نوع المنتج</label>

                                            <asp:CheckBoxList ID="uiCheckBoxListType" CssClass="checkSections" RepeatDirection="Horizontal" RepeatColumns="3" runat="server">
                                                <asp:ListItem>
                                                        منتج نهائي
                                                </asp:ListItem>
                                                <asp:ListItem>
                                                        عينة
                                                </asp:ListItem>
                                                <asp:ListItem>
                                                        منتج تحت التصنيع
                                                </asp:ListItem>
                                            </asp:CheckBoxList>

                                        </div>
                                    </div>
                                    <div class="block-margin-bottom-5 span12 clearfix">
                                        <div class="span6">
                                            <label class="control-label">ميعاد التسليم</label>
                                            <div class="input-append date date-picker" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                                                <asp:TextBox runat="server" CssClass="m-ctrl-medium date-picker" Font-Size="16" type="text" ID="txtDeliveryDate" Style="direction: ltr" />
                                                <span class="add-on">
                                                    <i class="icon-calendar"></i>
                                                </span>
                                            </div>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtDeliveryDate" ValidationGroup="dlr" runat="server" ForeColor="Red" Font-Bold="true" ErrorMessage="*" />
                                        </div>
                                        <div class="span6">
                                            <label class="control-label">مكان التسليم</label>
                                            <asp:TextBox runat="server" type="text" ID="txtDeliveryPlace" />
                                        </div>
                                    </div>
                                    <div class="block-margin-bottom-5 span12 clearfix">
                                        <div class="span6">
                                            <label class="control-label">شروط الدفع</label>
                                            <asp:TextBox runat="server" type="text" ID="txtPaymentRequirement" />
                                        </div>
                                        <div class="span6">
                                            <label class="control-label">المدير المسئول</label>
                                            <asp:TextBox runat="server" type="text" ID="TxtManagerName" />
                                        </div>
                                    </div>
                                    <div class="span12 ">
                                        <div>

                                            <div style="margin-bottom: 10px">
                                                <asp:LinkButton runat="server" ID="btnSavePurchaseOrderGeneralGrid" OnClick="btnSavePurchaseOrderGeneralGrid_Click" ValidationGroup="dlr" class="btn btn-success"><i class="icon-ok icon-white" ></i>حفظ</asp:LinkButton>
                                                <asp:LinkButton runat="server" ID="btnCancelPurchaseOrderGeneralGrid" OnClick="btnCancelPurchaseOrderGeneralGrid_Click" class="btn btn-danger"><i class="icon-remove icon-white" ></i>الغاء</asp:LinkButton>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </asp:Panel>

                            <asp:Panel runat="server" Visible="false" ID="PanelPurchaseOrderDetails" GroupingText="تفاصيل طلب الشراء">
                                <div class="form-horizontal">
                                    <div class="block-margin-bottom-5 span12 clearfix">
                                        <div class="span6">
                                            <label class="control-label">اجمالي القيمة</label>
                                            <asp:TextBox runat="server" type="text" ID="txtTotalValue" />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="txtTotalValue"
                                                ValidationExpression="^[0-9]*(?:\.[0-9]*)?$"
                                                Display="Static"
                                                ErrorMessage="أرقام فقط"
                                                ValidationGroup="dlr"
                                                runat="server"></asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtTotalValue" ValidationGroup="dlrg" runat="server" ForeColor="Red" Font-Bold="true" ErrorMessage="*" />
                                        </div>
                                        <div class="span6">
                                            <label class="control-label">سعر الوحدة</label>
                                            <asp:TextBox runat="server" type="text" ID="txtUnitPrice" />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txtUnitPrice"
                                                ValidationExpression="^[0-9]*(?:\.[0-9]*)?$"
                                                Display="Static"
                                                ErrorMessage="أرقام فقط"
                                                ValidationGroup="dlr"
                                                runat="server"></asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtUnitPrice" ValidationGroup="dlrg" runat="server" ForeColor="Red" Font-Bold="true" ErrorMessage="*" />
                                        </div>
                                    </div>
                                    <div class="block-margin-bottom-5 span12 clearfix">
                                        <div class="span6">
                                            <label class="control-label">الكمية المطلوبة</label>
                                            <asp:TextBox runat="server" type="text" ID="txtQuantityRequired" />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" ControlToValidate="txtQuantityRequired"
                                                ValidationExpression="^\d+$"
                                                Display="Static"
                                                ErrorMessage="أرقام فقط"
                                                ValidationGroup="dlr"
                                                runat="server"></asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txtQuantityRequired" ValidationGroup="dlrg" runat="server" ForeColor="Red" Font-Bold="true" ErrorMessage="*" />
                                        </div>
                                        <div class="span6">
                                            <label class="control-label">المخزون</label>
                                            <asp:TextBox runat="server" type="text" ID="txtStockOnHands" />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" ControlToValidate="txtStockOnHands"
                                                ValidationExpression="^\d+$"
                                                Display="Static"
                                                ErrorMessage="أرقام فقط"
                                                ValidationGroup="dlr"
                                                runat="server"></asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="txtStockOnHands" ValidationGroup="dlrg" runat="server" ForeColor="Red" Font-Bold="true" ErrorMessage="*" />
                                        </div>
                                    </div>
                                    <div class="block-margin-bottom-5 span12 clearfix">
                                        <div class="span6">
                                            <label class="control-label">الوحدة</label>
                                            <asp:TextBox runat="server" type="text" ID="txtUnit" />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" ControlToValidate="txtUnit"
                                                ValidationExpression="^\d+$"
                                                Display="Static"
                                                ErrorMessage="أرقام فقط"
                                                ValidationGroup="dlr"
                                                runat="server"></asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="txtUnit" ValidationGroup="dlrg" runat="server" ForeColor="Red" Font-Bold="true" ErrorMessage="*" />
                                        </div>
                                        <div class="span6">
                                            <label class="control-label">البيانات</label>
                                            <asp:TextBox runat="server" type="text" ID="txtDescription" />
                                        </div>
                                    </div>
                                    <div class="span12 ">
                                        <div>

                                            <div style="margin-bottom: 10px">
                                                <asp:LinkButton runat="server" ID="btnSavePurchaseOrderDetails" ValidationGroup="dlrg" OnClick="btnSavePurchaseOrderDetails_Click" class="btn btn-success"><i class="icon-ok icon-white" ></i>حفظ</asp:LinkButton>
                                                <asp:LinkButton runat="server" ID="btnCancelPurchaseOrderDetails" OnClick="btnCancelPurchaseOrderDetails_Click" class="btn btn-danger"><i class="icon-remove icon-white" ></i>الغاء</asp:LinkButton>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </asp:Panel>
                            <asp:Panel ID="PanelGrdPurcahseOrderDetails" runat="server">

                                <asp:GridView ID="grdPurchaseOrderDetails" OnRowCommand="grdPurchaseOrderDetails_RowCommand" CssClass="table table-striped table-bordered" AutoGenerateColumns="false" runat="server">
                                    <Columns>
                                        <asp:BoundField DataField="TotalValue" HeaderText="اجمالي القيمة" />
                                        <asp:BoundField DataField="UnitPrice" HeaderText="سعر الوحدة" />
                                        <asp:BoundField DataField="QuantityRequired" HeaderText="الكمية المطلوبة" />
                                        <asp:BoundField DataField="StockOnHand" HeaderText="المخزون" />
                                        <asp:BoundField DataField="Unit" HeaderText="الوحدة" />
                                        <asp:BoundField DataField="Description" HeaderText="البيانات" />
                                        <asp:TemplateField HeaderText="العمليات">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnDelete" OnClientClick="return confirm('هل تريد حذف هذا السجل ?')" runat="server" CommandArgument='<%# Eval("PurchaseOrderDetailsID") %>' CommandName="deleteDetailsOrder">حذف</asp:LinkButton>
                                                <asp:LinkButton ID="btnEdit" runat="server" CommandArgument='<%# Eval ("PurchaseOrderDetailsID") %>' CommandName="editDetailsOrder">تعديل</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </asp:Panel>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>