<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PrintingHouseUC.ascx.cs" Inherits="TouchMediaGUI.Admin.PrintingHouseUC" %>
<%-- <div class="row-fluid">
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
    </div>
    <div class="row-fluid">
        <div class="span12">
            <div class="widget">
                <div class="widget-title">
                    <h4><i class="icon-reorder"></i>المطابع</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>
                    </span>
                </div>
                <div class="widget-body">
                    <div class="row-fluid">
                        <div class="span12">--%>
                            <asp:Panel ID="panelPrintingHouseGrid" runat="server">
                                <div class="span3 clearfix block-margin-bottom-5">
                                    <asp:LinkButton ID="btnNewPrintingHouse" OnClick="btnNewPrintingHouse_Click" CssClass="btn btn-warning" runat="server"><i class="icon-plus icon-white"></i> اضافة مطبعة جديدة</asp:LinkButton>
                                </div>
                                <asp:GridView ID="GridViewPrintingHouse" OnRowCommand="GridViewPrintingHouse_RowCommand" HorizontalAlign="Center" CssClass="table table-striped table-bordered" AutoGenerateColumns="false" runat="server">
                                    <Columns>
                                        <asp:BoundField HeaderText="اسم المطبعة" DataField="Name" />
                                        <asp:BoundField HeaderText="تليفون المطبعة" DataField="Telephone" />
                                        <asp:BoundField HeaderText="البريد الالكترونى" DataField="Email" />
                                        <asp:BoundField HeaderText="العنوان" DataField="Address" />
                                        <asp:TemplateField HeaderText="العمليات">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnEditPrintingHouse" CssClass="btn btn-primary" CommandName="editPrintingHouse" CommandArgument='<%# Eval("GeneralLookupID") %>' runat="server"><i class="icon-pencil icon-white"></i> تعديل</asp:LinkButton>
                                                <asp:LinkButton ID="btnDeletePrintingHouse" CssClass="btn btn-danger" OnClientClick="return confirm('Are you want to delete this Printing House?');" CommandName="deletePrintingHouse" CommandArgument='<%# Eval("GeneralLookupID") %>' runat="server"><i class="icon-remove icon-white"></i> مسح</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </asp:Panel>

                            <asp:Panel ID="panelPrintingHouseEdit" Visible="false" runat="server">
                                <div class="form-horizontal">
                                    <div class="control-group">
                                        <label class="control-label">اسم المطبعة</label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtPrintingHouseName" />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtPrintingHouseName" ValidationGroup="StatusEdit" runat="server" Font-Bold="true" ErrorMessage="*" />
                                        </div>
                                    </div>
                                    <div class="control-group">
                                        <label class="control-label">عنوان المطبعة</label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtPrintingHouseAddress" />
                                        </div>
                                    </div>
                                    <div class="control-group">
                                        <label class="control-label">تليفون المطبعة</label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtPrintingHouseTelephone" />
                                        </div>
                                    </div>
                                    <div class="control-group">
                                        <label class="control-label">البريد الالكترونى</label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtPrintingHouseEmail" />
                                        </div>
                                    </div>
                                    <div class="form-actions">
                                        <asp:LinkButton ID="btnCancel" OnClick="btnCancel_Click" CssClass="btn btn-danger" runat="server"><i class="icon-ban-circle icon-white"></i> الغاء و رجوع</asp:LinkButton>
                                        <asp:LinkButton ID="btnSave" OnClick="btnSave_Click" CssClass="btn btn-success" runat="server"><i class="icon-ok icon-white"></i> حفظ</asp:LinkButton>
                                    </div>
                                </div>
                            </asp:Panel>
<%--                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>--%>