<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PrintingSuppliers.ascx.cs" Inherits="TouchMediaGUI.Admin.PrintingSuppliers" %>
<%--<div class="row-fluid">
        <div class="span12">
            <ul class="breadcrumb">
                <li>
                    <a href="Splash.aspx"><i class="icon-home"></i></a><span class="divider">&nbsp;</span>
                </li>
                <li>
                    <a href="#"><i class="icon-tint"></i>ادارة الطباعة</a><span class="divider divider-last">&nbsp;</span>
                </li>
            </ul>
        </div>
    </div>--%>
    <%--<div class="row-fluid">
        <div class="span12">
            <div class="widget">
                <div class="widget-title">
                    <h4><i class="icon-reorder"></i>المواردين</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>
                    </span>
                </div>
                <div class="widget-body">
                    <div class="row-fluid">
                        <div class="span12">--%>
                            <asp:Panel ID="panelPrintingSuppliersGrid" runat="server">
                                <div class="span2 clearfix block-margin-bottom-5">
                                    <asp:LinkButton ID="btnNewPrintingSuppliers" OnClick="btnNewPrintingSuppliers_Click" CssClass="btn btn-warning" runat="server"><i class="icon-plus icon-white"></i> اضافة موارد جديد</asp:LinkButton>
                                </div>
                                <asp:GridView ID="GridViewPrintingSuppliers" OnRowCommand="GridViewPrintingSuppliers_RowCommand" HorizontalAlign="Center" CssClass="table table-striped table-bordered" AutoGenerateColumns="false" runat="server">
                                    <Columns>
                                        <asp:BoundField HeaderText="اسم الموارد" DataField="Name" />
                                        <asp:BoundField HeaderText="عنوان الموارد" DataField="Address" />
                                        <asp:BoundField HeaderText="رقم الموارد" DataField="Telephone" />
                                        <asp:BoundField HeaderText="البريد الالكتروني" DataField="Email" />
                                        <asp:TemplateField HeaderText="العمليات">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnEditPrintingSupplier" CssClass="btn btn-primary" CommandName="editPrintingSupplier" CommandArgument='<%# Eval("GeneralLookupID") %>' runat="server"><i class="icon-pencil icon-white"></i> تعديل</asp:LinkButton>
                                                <asp:LinkButton ID="btnDeletePrintingSupplier" CssClass="btn btn-danger" OnClientClick="return confirm('Are you want to delete this Printing Supplier?');" CommandName="deletePrintingSupplier" CommandArgument='<%# Eval("GeneralLookupID") %>' runat="server"><i class="icon-remove icon-white"></i> مسح</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </asp:Panel>

                            <asp:Panel ID="panelPaperTypeEdit" Visible="false" runat="server">
                                <div class="form-horizontal">
                                    <div class="control-group">
                                        <label class="control-label"> اسم الموارد</label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtPrintingSupplierName" />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtPrintingSupplierName" ValidationGroup="StatusEdit" runat="server" Font-Bold="true" ErrorMessage="*" />
                                        </div>
                                    </div>
                                     <div class="control-group">
                                        <label class="control-label"> رقم الموارد</label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtPrintingSupplierTelephone" />
                                       </div>
                                    </div>
                                    <div class="control-group">
                                        <label class="control-label"> عنوان الموارد</label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtPrintingSupplierAddress" />
                                       </div>
                                    </div>
                                    <div class="control-group">
                                        <label class="control-label"> البريد الالكتروني </label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtPrintingSupplierEmail" />
                                       </div>
                                    </div>
                                   
                                    <div class="form-actions">
                                        <asp:LinkButton ID="btnCancel" OnClick="btnCancel_Click" CssClass="btn btn-danger" runat="server"><i class="icon-ban-circle icon-white"></i> الغاء و رجوع</asp:LinkButton>
                                        <asp:LinkButton ID="btnSave" OnClick="btnSave_Click" CssClass="btn btn-success" runat="server"><i class="icon-ok icon-white"></i> حفظ</asp:LinkButton>
                                    </div>
                                </div>
                            </asp:Panel>
                        <%--</div>
                    </div>
                </div>
            </div>
        </div>
    </div>--%>