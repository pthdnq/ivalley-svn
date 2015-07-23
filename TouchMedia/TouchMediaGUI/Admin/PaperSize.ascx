<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PaperSize.ascx.cs" Inherits="TouchMediaGUI.Admin.PaperSize" %>
  <%--<div class="row-fluid">
        <div class="span12">
            <div class="widget">
                <div class="widget-title">
                    <h4><i class="icon-reorder"></i>مقاس الورق</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>
                    </span>
                </div>
                <div class="widget-body">
                    <div class="row-fluid">
                        <div class="span12">--%>
                            <asp:Panel ID="panelPaperSizeGrid" runat="server">
                                <div class="span3 clearfix block-margin-bottom-5">
                                    <asp:LinkButton ID="btnNewPaperSize" OnClick="btnNewPaperSize_Click" CssClass="btn btn-warning" runat="server"><i class="icon-plus icon-white"></i> اضافة مقاس ورق جديد</asp:LinkButton>
                                </div>
                                <asp:GridView ID="GridViewPaperSize" OnRowCommand="GridViewPaperSize_RowCommand" HorizontalAlign="Center" CssClass="table table-striped table-bordered" AutoGenerateColumns="false" runat="server">
                                    <Columns>
                                        <asp:BoundField HeaderText="مقاس الورق" DataField="Name" ItemStyle-Width ="50%" HeaderStyle-Width="50%"/>
                                        
                                        <asp:TemplateField HeaderText="العمليات" ItemStyle-Width ="50%" HeaderStyle-Width="50%">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnEditPaperSize" CssClass="btn btn-primary" CommandName="editPaperSize" CommandArgument='<%# Eval("GeneralLookupID") %>' runat="server"><i class="icon-pencil icon-white"></i> تعديل</asp:LinkButton>
                                                <asp:LinkButton ID="btnDeletePaperSize" CssClass="btn btn-danger" OnClientClick="return confirm('Are you want to delete this Paper Size?');" CommandName="deletePaperSize" CommandArgument='<%# Eval("GeneralLookupID") %>' runat="server"><i class="icon-remove icon-white"></i> مسح</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </asp:Panel>

                            <asp:Panel ID="panelPaperSizeEdit" Visible="false" runat="server">
                                <div class="form-horizontal">
                                    <div class="control-group">
                                        <label class="control-label"> مقاس الورق</label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtPaperSizeName" />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtPaperSizeName" ValidationGroup="StatusEdit" runat="server" Font-Bold="true" ErrorMessage="*" />
                                        </div>
                                    </div>
                                   
                                    <div class="form-actions">
                                        <asp:LinkButton ID="btnCancel" OnClick="btnCancel_Click" CssClass="btn btn-danger" runat="server"><i class="icon-ban-circle icon-white"></i> الغاء و رجوع</asp:LinkButton>
                                        <asp:LinkButton ID="btnSave" OnClick="btnSave_Click" CssClass="btn btn-success" runat="server"><i class="icon-ok icon-white"></i> حفظ</asp:LinkButton>
                                    </div>
                                </div>
                            </asp:Panel>
                       <%-- </div>
                    </div>
                </div>
            </div>
        </div>
    </div>--%>