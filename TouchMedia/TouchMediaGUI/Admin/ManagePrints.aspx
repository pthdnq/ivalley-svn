<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="ManagePrints.aspx.cs" Inherits="TouchMediaGUI.Admin.ManagePrints" %>

<%@ Register Src="~/Admin/PrintingHouseUC.ascx" TagPrefix="uc1" TagName="PrintingHouseUC" %>
<%@ Register Src="~/Admin/PaperType.ascx" TagPrefix="uc1" TagName="PaperType" %>
<%@ Register Src="~/Admin/PaperSize.ascx" TagPrefix="uc1" TagName="PaperSize" %>
<%@ Register Src="~/Admin/PrintingSuppliers.ascx" TagPrefix="uc1" TagName="PrintingSuppliers" %>
<%@ Register Src="~/Admin/AfterPrinting.ascx" TagPrefix="uc1" TagName="AfterPrinting" %>








<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row-fluid ">
                  <div class="span12">
                     <!-- BEGIN INLINE TABS PORTLET-->
                     <div class="widget">
                        <div class="widget-title">
                           <h4><i class="icon-reorder"></i>أدارة الطباعة</h4>
                           <span class="tools">
                           <a href="javascript:;" class="icon-chevron-down"></a>
                           <a class="icon-remove" href="javascript:;"></a>
                           </span>
                        </div>
                        <div class="widget-body">
                           <div class="row-fluid">
                              <div class="span12">
                                 <!--BEGIN TABS-->
                                 <div class="tabbable tabbable-custom">
                                    <ul class="nav nav-tabs">
                                       <li class="active"><a href="#tab_1_1" data-toggle="tab">مطابع</a></li>
                                       <li><a href="#tab_1_2" data-toggle="tab">أنواع الأوراق</a></li>
                                       <li><a href="#tab_1_3" data-toggle="tab">مقاس الأوراق</a></li>
                                        <li><a href="#tab_1_4" data-toggle="tab">المواردين</a></li>
                                        <li><a href="#tab_1_5" data-toggle="tab">أعمال مابعد الطباعة</a></li>
                                    </ul>
                                    <div class="tab-content">
                                       <div class="tab-pane active" id="tab_1_1">
                                           <uc1:PrintingHouseUC runat="server" ID="PrintingHouseUC" />
                                           </div>
                                        <div class="tab-pane " id="tab_1_2">
                                            <uc1:PaperType runat="server" ID="PaperType" />
                                           </div>
                                        <div class="tab-pane " id="tab_1_3">
                                            <uc1:PaperSize runat="server" ID="PaperSize" />
                                           </div>
                                        <div class="tab-pane " id="tab_1_4">
                                            <uc1:PrintingSuppliers runat="server" ID="PrintingSuppliers" />
                                           </div>
                                        
                                       <div class="tab-pane " id="tab_1_5">
                                           <uc1:AfterPrinting runat="server" id="AfterPrinting" />
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
