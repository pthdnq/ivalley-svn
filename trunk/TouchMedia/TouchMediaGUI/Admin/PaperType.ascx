<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PaperType.ascx.cs" Inherits="TouchMediaGUI.Admin.PaperType" %>
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
            <div class="widget" >
                <div class="widget-title">
                    <h4><i class="icon-reorder"></i>أنواع الأوراق</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>
                    </span>
                </div>
                <div class="widget-body" >
                    <div class="row-fluid">
                        <div class="span12">--%>
                            <asp:Panel ID="panelPaperTypeGrid" runat="server">
                                <div class="span3 clearfix block-margin-bottom-5">
                                    <asp:LinkButton ID="btnNewPaperType" OnClick="btnNewPaperType_Click" CssClass="btn btn-warning" runat="server"><i class="icon-plus icon-white"></i> اضافة نوع ورق جديد</asp:LinkButton>
                                </div>
                                <asp:GridView ID="GridViewPaperType" OnRowCommand="GridViewPaperType_RowCommand" HorizontalAlign="Center" CssClass="table table-striped table-bordered" AutoGenerateColumns="false" runat="server">
                                    <Columns>
                                        <asp:BoundField HeaderText="نوع الورق" ItemStyle-Width ="33.3%" HeaderStyle-Width="33.3%" DataField="PrintingPaperName" />
                                        <asp:BoundField HeaderText="كمية الورق" ItemStyle-Width ="33.3%" HeaderStyle-Width="33.3%" DataField="PurcahsePaperQuantity" />
                                        <asp:TemplateField HeaderText="العمليات" ItemStyle-Width ="33.3%" HeaderStyle-Width="33.3%">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnEditPaperType" CssClass="btn btn-primary" CommandName="editPaperType" CommandArgument='<%# Eval("PrintingPapersID") %>' runat="server"><i class="icon-pencil icon-white"></i> تعديل</asp:LinkButton>
                                                <asp:LinkButton ID="btnDeletePaperType" CssClass="btn btn-danger" OnClientClick="return confirm('Are you want to delete this Paper Type?');" CommandName="deletePaperType" CommandArgument='<%# Eval("PrintingPapersID") %>' runat="server"><i class="icon-remove icon-white"></i> مسح</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </asp:Panel>

                            <asp:Panel ID="panelPaperTypeEdit" Visible="false" runat="server">
                                <div class="form-horizontal">
                                    <div class="control-group">
                                        <label class="control-label"> نوع الورق</label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtPaperTypeName" />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtPaperTypeName" ValidationGroup="StatusEdit" runat="server" Font-Bold="true" ErrorMessage="*" />
                                        </div>
                                    </div>
                                    <div class="control-group">
                                        <label class="control-label"> كمية الورق</label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtPaperQuantity" />
                                           
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