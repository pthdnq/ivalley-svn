﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ExceptionLight.Master" AutoEventWireup="true" CodeBehind="ManualManagment.aspx.cs" Inherits="Flights_GUI.Admin.ManualManagment" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ MasterType VirtualPath="~/MasterPages/ExceptionLight.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script type="text/javascript">
         $(document).ready(function () {
             $('.notify-row .btn-inverse').removeClass("active");
             $('#mi_top_Manage_Manuals').addClass("active");
         });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="uiPanelViewAll" runat="server">
        <div class="cell-2 clearfix pull-right">
            <asp:LinkButton ID="uiLinkButtonAdd" runat="server" CssClass="btn btn-primary" OnClick="uiLinkButtonAdd_Click">Add new manual</asp:LinkButton>
            <div class="clearfix">&nbsp;  </div>
        </div>
        <div class="cell-12 clearfix">
            <div class="cell-4">
                <h4>All categories
                </h4>
                <telerik:RadTreeView ID="uiRadTreeViewCats" runat="server" OnNodeClick="uiRadTreeViewCats_NodeClick"></telerik:RadTreeView>
            </div>
            <div class="cell-8">
                <telerik:RadGrid ID="uiRadGridmanuals" runat="server" AllowPaging="True"
                    AutoGenerateColumns="False" CellSpacing="0"
                    HorizontalAlign="Center" EnableEmbeddedSkins="False" Width="100%"
                    OnPageIndexChanged="uiRadGridmanuals_PageIndexChanged"
                    OnItemCommand="uiRadGridmanuals_ItemCommand">
                    <AlternatingItemStyle HorizontalAlign="Center" />
                    <MasterTableView>

                        <Columns>
                            <telerik:GridBoundColumn DataField="Title" HeaderText="Title"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="CreatedByName" HeaderText="Created By"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="createdDate" HeaderText="Date" DataFormatString="{0:dd/MM/yyyy}"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="UpdatedByName" HeaderText="Updated By"></telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="LastUpdatedDate" HeaderText="Date" DataFormatString="{0:dd/MM/yyyy}"></telerik:GridBoundColumn>
                            <telerik:GridTemplateColumn HeaderText="Actions">
                                <ItemTemplate>
                                    <asp:LinkButton ID="uiLinkButtonEdit" runat="server" CommandArgument='<%# Eval("ManualID") %>'
                                        CommandName="EditManual"><img src="../images/edit.png" alt="Edit" title="Edit" style="border:0;float:none;" /></asp:LinkButton>
                                    &nbsp;
                                    <asp:LinkButton ID="uiLinkButtonDelete" runat="server" CommandArgument='<%# Eval("ManualID") %>'
                                        CommandName="DeleteManual" OnClientClick="return confirm('Are you want to delete this record? ');"><img src="../images/delete.png" alt="Delete" title="Delete" style="border:0;float:none;" /></asp:LinkButton>

                                </ItemTemplate>
                            </telerik:GridTemplateColumn>
                        </Columns>
                    </MasterTableView>
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />

                </telerik:RadGrid>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="uiPanelEdit" runat="server" GroupingText="Add /Edit Manual">
        <div class="cell-12 clearfix">
            <div class="cell-2">Title</div>
            <div class="cell-4">
                <asp:TextBox ID="uiTextBoxTitle" runat="server"></asp:TextBox>
            </div>
        </div>
        <%--<div style="clear:both;height:5px;"></div>
         <div class="cell-12 clearfix" style="margin-left:0">
             <div class="cell-2">Issue Number</div>
             <div class="cell-4">
                 <asp:TextBox ID="uiTextBoxIssueNo" runat="server"></asp:TextBox></div>
         </div>
         <div style="clear:both;height:5px;"></div>
         <div class="cell-12 clearfix" style="margin-left:0">
             <div class="cell-2">Issue Date</div>
             <div class="cell-4">
                 <telerik:RadDatePicker ID="uiRadDatePickerIssueDate" runat="server" Height="25px" Width="185px"></telerik:RadDatePicker>
             </div>
         </div>
         <div style="clear:both;height:5px;"></div>
         <div class="cell-12 clearfix" style="margin-left:0">
             <div class="cell-2">Revision Number</div>
             <div class="cell-4">
                 <asp:TextBox ID="uiTextBoxRevisionNo" runat="server"></asp:TextBox></div>
         </div>
         <div style="clear:both;height:5px;"></div>
         <div class="cell-12 clearfix" style="margin-left:0">
             <div class="cell-2">Revision Date</div>
             <div class="cell-4">
                 <telerik:RadDatePicker ID="uiRadDatePickerRevisionDate" runat="server" Height="25px" Width="185px"></telerik:RadDatePicker>
             </div>
         </div>
         <div style="clear:both;height:5px;"></div>
         <div class="cell-12 clearfix" style="margin-left:0">
             <div class="cell-2">Created By</div>
             <div class="cell-4"><asp:TextBox ID="uiTextBoxCreatedBy" runat="server"></asp:TextBox></div>
         </div>
         <div style="clear:both;height:5px;"></div>
          <div class="cell-12 clearfix" style="margin-left:0">
             <div class="cell-2">Manual</div>
             <div class="cell-4">
                 <asp:FileUpload ID="uiFileUploadManual" runat="server" />
             </div>
         </div>--%>
        <div class="cell-12 clearfix" style="margin-left: 0; margin-top: 10px;">
            <div class="cell-2"></div>
            <div class="cell-1">
                <asp:LinkButton ID="uiLinkButtonSave" runat="server" CssClass="btn btn-primary" OnClick="uiButtonSave_Click">Save</asp:LinkButton>
            </div>
            <div class="cell-2">
                <asp:LinkButton ID="uiLinkButtonCancel" runat="server" CssClass="btn main-bg" OnClick="uiLinkButtonCancel_Click">Cancel & Back</asp:LinkButton>
            </div>
            <div class="cell-2">
                <asp:LinkButton ID="uiLinkButtonEditForms" runat="server" CssClass="btn empty main-border" OnClick="uiLinkButtonEditForms_Click">Edit Manual Forms</asp:LinkButton>
            </div>

        </div>


    </asp:Panel>
    <asp:Panel ID="uiPanelVersions" runat="server" GroupingText="Manual versions">

        <div class="cell-2 clearfix pull-right">
            <asp:LinkButton ID="uiLinkButtonAddVersion" runat="server" CssClass="btn btn-primary" OnClick="uiLinkButtonAddVersion_Click">Add new version</asp:LinkButton>
            <div class="clearfix">&nbsp;  </div>
        </div>
        <div class="cell-12 clearfix">
            <telerik:RadGrid ID="uiRadGridVersions" runat="server" AllowPaging="True"
                AutoGenerateColumns="False" CellSpacing="0"
                HorizontalAlign="Center" EnableEmbeddedSkins="False" Width="100%"
                OnPageIndexChanged="uiRadGridVersions_PageIndexChanged"
                OnItemCommand="uiRadGridVersions_ItemCommand">
                <AlternatingItemStyle HorizontalAlign="Center" />
                <MasterTableView>

                    <Columns>
                        <telerik:GridBoundColumn DataField="Title" HeaderText="Title"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="IssueNumber" HeaderText="Issue No."></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="IssueDate" HeaderText="Issue Date" DataFormatString="{0:dd/MM/yyyy}"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="RevisionNumber" HeaderText="Revision No."></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="RevisionDate" HeaderText="Revision Date" DataFormatString="{0:dd/MM/yyyy}"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="UpdatedByName" HeaderText="Updated By"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="LastUpdatedDate" HeaderText="Last Updated Date" DataFormatString="{0:dd/MM/yyyy}"></telerik:GridBoundColumn>
                        <telerik:GridTemplateColumn HeaderText="Actions">
                            <ItemTemplate>
                                <asp:LinkButton ID="uiLinkButtonEdit" runat="server" CommandArgument='<%# Eval("ManualVersionID") %>'
                                    CommandName="EditManualVersion"><img src="../images/edit.png" alt="Edit" title="Edit" style="border:0;float:none;" /></asp:LinkButton>
                                &nbsp;
                                    <asp:LinkButton ID="uiLinkButtonDelete" runat="server" CommandArgument='<%# Eval("ManualVersionID") %>'
                                        CommandName="DeleteManualVersion" OnClientClick="return confirm('Are you want to delete this record? ');"><img src="../images/delete.png" alt="Delete" title="Delete" style="border:0;float:none;" /></asp:LinkButton>

                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                    </Columns>
                </MasterTableView>
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />

            </telerik:RadGrid>
        </div>
    </asp:Panel>
    <asp:Panel ID="uiPanelEditVersions" runat="server" GroupingText="Add / Edit Manual Version">
        <div class="cell-12 clearfix">
            <div class="cell-2">Title</div>
            <div class="cell-4">
                <asp:TextBox ID="uiTextBoxVersionTitle" runat="server"></asp:TextBox>
            </div>
        </div>
        <div style="clear: both; height: 5px;"></div>
        <div class="cell-12 clearfix" style="margin-left: 0">
            <div class="cell-2">Issue Number</div>
            <div class="cell-4">
                <asp:TextBox ID="uiTextBoxIssueNo" runat="server"></asp:TextBox>
            </div>
        </div>
        <div style="clear: both; height: 5px;"></div>
        <div class="cell-12 clearfix" style="margin-left: 0">
            <div class="cell-2">Issue Date</div>
            <div class="cell-4">
                <telerik:RadDatePicker ID="uiRadDatePickerIssueDate" runat="server" Height="25px" Width="185px"></telerik:RadDatePicker>
            </div>
        </div>
        <div style="clear: both; height: 5px;"></div>
        <div class="cell-12 clearfix" style="margin-left: 0">
            <div class="cell-2">Revision Number</div>
            <div class="cell-4">
                <asp:TextBox ID="uiTextBoxRevisionNo" runat="server"></asp:TextBox>
            </div>
        </div>
        <div style="clear: both; height: 5px;"></div>
        <div class="cell-12 clearfix" style="margin-left: 0">
            <div class="cell-2">Revision Date</div>
            <div class="cell-4">
                <telerik:RadDatePicker ID="uiRadDatePickerRevisionDate" runat="server" Height="25px" Width="185px"></telerik:RadDatePicker>
            </div>
        </div>

        <div style="clear: both; height: 5px;"></div>
        <div class="cell-12 clearfix" style="margin-left: 0">
            <div class="cell-2">Upload</div>
            <div class="cell-10">
                <iframe src="../uiUpload.html" style="border: 0; width: 80%; overflow: hidden; height: 100px;"></iframe>
            </div>
        </div>
        <div class="cell-12 clearfix" style="margin-left: 0;">
            <div class="cell-2"></div>
            <div class="cell-2">
                <asp:LinkButton ID="uiLinkButtonSaveVersion" runat="server" CssClass="btn btn-primary" OnClick="uiButtonSaveVersion_Click">Save</asp:LinkButton>
            </div>
            <div class="cell-4">
                <asp:LinkButton ID="uiLinkButtonCancelVersion" runat="server" CssClass="btn main-bg" OnClick="uiLinkButtonCancelVersion_Click">Cancel & Back</asp:LinkButton>
            </div>
        </div>


    </asp:Panel>
</asp:Content>
