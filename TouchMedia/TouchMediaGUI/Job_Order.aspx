<%@ Page Title="" Language="C#" MasterPageFile="~/MasterAr.Master" AutoEventWireup="true" CodeBehind="Job_Order.aspx.cs" Inherits="TouchMediaGUI.Job_Order" %>


<%@ Register Src="~/usercontrols/ucJobOrderProduction.ascx" TagPrefix="uc1" TagName="ucJobOrderProduction" %>
<%@ Register Src="~/usercontrols/ucJobOrderPrinting.ascx" TagPrefix="uc1" TagName="ucJobOrderPrinting" %>
<%@ Register Src="~/usercontrols/ucPurchaseOrder.ascx" TagPrefix="uc2" TagName="ucPurchaseOrder" %>








<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .checkSections td label {
            display: inline;
            padding-right: 5px;
            padding-left: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row-fluid ">
        <div class="span12">
            <!-- BEGIN INLINE TABS PORTLET-->
            <div class="widget">
                <div class="widget-title">
                    <h4><i class="icon-reorder"></i>أوامر الشغل</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>
                        <a class="icon-remove" href="javascript:;"></a>
                    </span>
                </div>
                <div class="widget-body">
                    <div class="row-fluid">
                        <div class="span12">
                             <asp:Panel ID="PanelPurchaseOrdersGrid" runat="server">
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
                                                <asp:LinkButton ID="btnDelete" OnClientClick="return confirm('هل تريد حذف هذا السجل ?')" runat="server" CommandArgument='<%# Eval("JobOrderID") %>' CommandName="deleteGeneralOrder">حذف</asp:LinkButton>
                                                <asp:LinkButton ID="btnEdit" runat="server" CommandArgument='<%# Eval ("JobOrderID") %>' CommandName="editGeneralOrder">تعديل</asp:LinkButton>
                                                <asp:LinkButton ID="btnPrintPur" runat="server" CommandArgument='<%# Eval ("JobOrderID") %>' CommandName="PrintPurchase">طباعة</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </asp:Panel>
                            <div class="form-horizontal">
                                <div class="block-margin-bottom-5 span12 clearfix" ">
                                    <div class="span6">
                                        <label class="control-label">كود أمر الشغل</label>
                                        <asp:TextBox runat="server" ID="txtJobOrderCode"></asp:TextBox>
                                    </div>
                                    <div class="span6">
                                        <label class="control-label">أسم العميل</label>
                                        <asp:DropDownList runat="server" ID="drpClientName"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="block-margin-bottom-5 span12 clearfix" style="margin-right:0">
                                    <div class="span6">
                                        <label class="control-label">أسم العملية</label>
                                        <asp:TextBox runat="server" ID="txtGeneralOperationName"></asp:TextBox>
                                    </div>
                                    <div class="span6">
                                        <label class="control-label">الحالة</label>
                                        <asp:DropDownList runat="server" ID="drpGeneralStatus"></asp:DropDownList>
                                    </div>
                                </div>
                                 <div class="block-margin-bottom-5 span12 clearfix" style="margin-right:0">
                                       
                                                <asp:LinkButton runat="server" ID="btnSaveMasterJobOrder"  OnClick="btnSaveMasterJobOrder_Click" class="btn btn-success"><i class="icon-ok icon-white" ></i>حفظ</asp:LinkButton>
                                                <asp:LinkButton runat="server" ID="btnCancelMasterJobOrder" OnClick="btnCancelMasterJobOrder_Click" class="btn btn-danger"><i class="icon-remove icon-white" ></i>الغاء</asp:LinkButton>
                                            </div>
                                       
                            </div>
                            <!--BEGIN TABS-->
                            <div class="tabbable tabbable-custom">
                                <ul class="nav nav-tabs">
                                    <li class="active"><a href="#tab_1_1" data-toggle="tab">تصنيع</a></li>
                                    <li><a href="#tab_1_2" data-toggle="tab">طباعة</a></li>
                                    <li><a href="#tab_1_3" data-toggle="tab">توريد</a></li>

                                </ul>
                                <div class="tab-content">
                                    <div class="tab-pane active" id="tab_1_1">
                                        <uc1:ucJobOrderProduction runat="server" id="ucJobOrderProduction" />
                                    </div>
                                    <div class="tab-pane " id="tab_1_2">
                                        
                                        <uc1:ucJobOrderPrinting runat="server" id="ucJobOrderPrinting" />
                                    </div>
                                    <div class="tab-pane " id="tab_1_3">
                                        <uc2:ucPurchaseOrder runat="server" id="ucPurchaseOrder" />
                                    </div>



                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderScriptsPurchaseOrder" runat="server">
</asp:Content>
