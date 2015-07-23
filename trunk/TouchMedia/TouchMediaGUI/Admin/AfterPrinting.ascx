<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AfterPrinting.ascx.cs" Inherits="TouchMediaGUI.Admin.AfterPrinting" %>
  <div class="span12">
                            <asp:Panel ID="panelAfterPrintingGrid" runat="server">
                                <div class="span2 clearfix block-margin-bottom-5">
                                    <asp:LinkButton ID="btnNew" OnClick="btnNew_Click" CssClass="btn btn-warning" runat="server"><i class="icon-plus icon-white"></i> اضافة جديد</asp:LinkButton>
                                </div>
                                <asp:GridView ID="GridViewAfterPrinting"  OnRowCommand="GridViewAfterPrinting_RowCommand" HorizontalAlign="Center" CssClass="table table-striped table-bordered" AutoGenerateColumns="false" runat="server">
                                    <Columns>
                                        <asp:BoundField HeaderText="الأسم" DataField="Name" ItemStyle-Width ="50%" HeaderStyle-Width="50%" />


                                        <asp:TemplateField HeaderText="العمليات" ItemStyle-Width ="50%" HeaderStyle-Width="50%" >
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnEditAfterPrinting" CssClass="btn btn-primary" CommandName="editAfter" CommandArgument='<%# Eval("GeneralLookUpID") %>' runat="server"><i class="icon-pencil icon-white"></i> تعديل</asp:LinkButton>
                                                <asp:LinkButton ID="btnDeleteAfterPrinting" CssClass="btn btn-danger" OnClientClick="return confirm('Are you want to delete this Work ?');" CommandName="deleteAfter" CommandArgument='<%# Eval("GeneralLookUpID") %>' runat="server"><i class="icon-remove icon-white"></i> مسح</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </asp:Panel>

                            <asp:Panel ID="panelAfterPurchaseEdit" Visible="false" runat="server">
                                <div class="form-horizontal">
                                    <div class="control-group" >
                                        <label class="control-label">الأسم</label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtAfterPrintingName" />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtAfterPrintingName" ValidationGroup="StatusEdit" runat="server" Font-Bold="true" ErrorMessage="*" />
                                        </div>
                                    </div>


                                    <div class="form-actions">
                                        <asp:LinkButton ID="btnCancel" OnClick="btnCancel_Click" CssClass="btn btn-danger" runat="server"><i class="icon-ban-circle icon-white"></i> الغاء و رجوع</asp:LinkButton>
                                        <asp:LinkButton ID="btnSave" OnClick="btnSave_Click" CssClass="btn btn-success" runat="server"><i class="icon-ok icon-white"></i> حفظ</asp:LinkButton>
                                    </div>
                                </div>
                            </asp:Panel>
                        </div>