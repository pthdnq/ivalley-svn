<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="ManageNeeds.aspx.cs" Inherits="TouchMediaGUI.Admin.ManageNeeds" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row-fluid">
        <div class="span12">
            <ul class="breadcrumb">
                <li>
                    <a href="Splash.aspx"><i class="icon-home"></i></a><span class="divider">&nbsp;</span>
                </li>
                <li>
                    <a href="#"><i class="icon-tint"></i>ادارة المستلزمات</a><span class="divider divider-last">&nbsp;</span>
                </li>
            </ul>
        </div>
    </div>
    <div class="row-fluid">
        <div class="span12">
            <div class="widget">
                <div class="widget-title">
                    <h4><i class="icon-reorder"></i>المستلزمات</h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>
                    </span>
                </div>
                <div class="widget-body">
                    <div class="row-fluid">
                        <div class="span12">
                            <asp:Panel ID="panelNeedsGrid" runat="server">
                                <div class="span2 clearfix block-margin-bottom-5">
                                    <asp:LinkButton ID="btnNewNeed" OnClick="btnNewNeed_Click" CssClass="btn btn-warning" runat="server"><i class="icon-plus icon-white"></i> اضافة مستلزم جديد</asp:LinkButton>
                                </div>
                                <asp:GridView ID="GridViewNeeds" OnRowCommand="GridViewNeeds_RowCommand" HorizontalAlign="Center" CssClass="table table-striped table-bordered" AutoGenerateColumns="false" runat="server">
                                    <Columns>
                                        <asp:BoundField HeaderText="اسم المستلزم" DataField="NeedName" />
                                        <asp:BoundField HeaderText="الموارد" DataField="NeedSupplier" />
                                        <asp:BoundField HeaderText="الكمية" DataField="NeedQuantity" />
                                        
                                        <asp:TemplateField HeaderText="العمليات">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnEditNeeds" CssClass="btn btn-primary" CommandName="editNeed" CommandArgument='<%# Eval("NeedID") %>' runat="server"><i class="icon-pencil icon-white"></i> تعديل</asp:LinkButton>
                                                <asp:LinkButton ID="btnDeleteNeeds" CssClass="btn btn-danger" OnClientClick="return confirm('Are you want to delete this Need ?');" CommandName="deleteNeed" CommandArgument='<%# Eval("NeedID") %>' runat="server"><i class="icon-remove icon-white"></i> مسح</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </asp:Panel>

                            <asp:Panel ID="panelPaperTypeEdit" Visible="false" runat="server">
                                <div class="form-horizontal">
                                    <div class="control-group">
                                        <label class="control-label">اسم المستلزم</label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtNeedName" />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtNeedName" ValidationGroup="StatusEdit" runat="server" Font-Bold="true" ErrorMessage="*" />
                                        </div>
                                    </div>
                                     <div class="control-group">
                                        <label class="control-label"> الموارد</label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtNeedSupplier" />
                                       </div>
                                    </div>
                                    <div class="control-group">
                                        <label class="control-label"> الكمية</label>
                                        <div class="controls">
                                            <asp:TextBox runat="server" type="text" class="span3 " ID="txtNeedQuantity" />
                                       </div>
                                    </div>
                                    <div class="control-group">
                                       <asp:CheckBoxList ID="CheckboxNeed" CssClass="checkSections" RepeatDirection="Horizontal" RepeatColumns="3" runat="server">
                                                <asp:ListItem>
                                                        جديد
                                                </asp:ListItem>
                                                <asp:ListItem>
                                                        متوفر من قبل
                                                </asp:ListItem>
                                                <asp:ListItem>
                                                        تحتاج الي صيانة
                                                </asp:ListItem>
                                            </asp:CheckBoxList>
                                    </div>
                                   
                                    <div class="form-actions">
                                        <asp:LinkButton ID="btnCancel" OnClick="btnCancel_Click" CssClass="btn btn-danger" runat="server"><i class="icon-ban-circle icon-white"></i> الغاء و رجوع</asp:LinkButton>
                                        <asp:LinkButton ID="btnSave" OnClick="btnSave_Click" CssClass="btn btn-success" runat="server"><i class="icon-ok icon-white"></i> حفظ</asp:LinkButton>
                                    </div>
                                </div>
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
