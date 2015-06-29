﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ExceptionLight.Master" AutoEventWireup="true" CodeBehind="Manuals.aspx.cs" Inherits="Flights_GUI.Intranet.Manuals" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ MasterType VirtualPath="~/MasterPages/ExceptionLight.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../assets/custombootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="../Scripts/jqwidgets/styles/jqx.base.css" rel="stylesheet" />
    <script type="text/javascript" src="../scripts/jqwidgets/jqxcore.js"></script>
    <script type="text/javascript" src="../scripts/jqwidgets/jqxdata.js"></script>
    <script type="text/javascript" src="../scripts/jqwidgets/jqxbuttons.js"></script>
    <script type="text/javascript" src="../scripts/jqwidgets/jqxscrollbar.js"></script>
    <script type="text/javascript" src="../scripts/jqwidgets/jqxlistbox.js"></script>
    <script type="text/javascript" src="../scripts/jqwidgets/jqxdropdownlist.js"></script>
    <script type="text/javascript" src="../scripts/jqwidgets/jqxmenu.js"></script>
    <script type="text/javascript" src="../scripts/jqwidgets/jqxgrid.js"></script>
    <script type="text/javascript" src="../scripts/jqwidgets/jqxgrid.filter.js"></script>
    <script type="text/javascript" src="../scripts/jqwidgets/jqxgrid.sort.js"></script>
    <script type="text/javascript" src="../scripts/jqwidgets/jqxgrid.selection.js"></script>
    <script type="text/javascript" src="../scripts/jqwidgets/jqxgrid.edit.js"></script>
    <script type="text/javascript" src="../scripts/jqwidgets/jqxgrid.columnsresize.js"></script>
    <script src="../Scripts/jqwidgets/jqxgrid.pager.js"></script>
    <script type="text/javascript" src="../scripts/jqwidgets/jqxpanel.js"></script>
    <script src="../assets/bootstrap/js/bootstrap.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('.notify-row .btn-inverse').removeClass("active");
            $('#mi_top_Manuals').addClass("active");

            $('.viewVersion').click(function () {
                try {
                    $('#jqxgrid').jqxGrid('destroy');
                } catch (e) {

                }
                
                $('#modalbody').append("<div id='jqxgrid'></div>");
                mID = $(this).attr("data-manualid");
                $('#manualName').html($(this).attr("data-manualName"));
                getVersions(mID);
            });
        });

        
        var linkrenderer = function (row, column, value) {
            if (value.indexOf('#') != -1) {
                value = value.substring(0, value.indexOf('#'));
            }
            //var format = { target: '"_blank"' };
            var html = '<a href="' + value + '" target="_blank">Download</a>';
            // $.jqx.dataFormat.formatlink(value, format);
            return html;
        }

        function getVersions(manualid)
        {
            var source =
            {
                datatype: "json",
                datafields: [
                    { name: 'Title', type: 'string' },
                    { name: 'IssueNumber', type: 'string' },
                    { name: 'IssueDate', type: 'date' },
                    { name: 'RevisionNumber', type: 'string' },
                    { name: 'RevisionDate', type: 'date' },
                    { name: 'UpdatedByName', type: 'string' },
                    { name: 'LastUpdatedDate', type: 'date' },
                    { name: 'Path' , type: 'string'}
                ],
                url: "../common/IntranetService.asmx/GetManualVersions?ID=" + manualid
            };
            var dataAdapter = new $.jqx.dataAdapter(source);
            $("#jqxgrid").jqxGrid(
           {
               width: "100%",
               source: dataAdapter,
               enablehover:false,
               pageable: true,
               autoheight: true,
               selectionmode: 'none',
               columns: [
                 { text: 'Title', datafield: 'Title', width: 180 },
                 { text: 'Issue No.', datafield: 'IssueNumber', width: 70, },
                 { text: 'Issue Date', datafield: 'IssueDate', width: 100, cellsformat:'dd/MM/yyyy' },
                 { text: 'Rev. No.', datafield: 'RevisionNumber', width: 70 },
                 { text: 'Rev. Date', datafield: 'RevisionDate', width: 100, cellsformat: 'dd/MM/yyyy' },
                 { text: 'Updated By', datafield: 'UpdatedByName', width: 100 },
                 { text: 'Last Updated Date', datafield: 'LastUpdatedDate', width: 140, cellsformat: 'dd/MM/yyyy' },
                 { text: 'Download', datafield: 'Path', width: 100, cellsrenderer: linkrenderer, hidden: <%= (Roles.IsUserInRole("admin") || Roles.IsUserInRole("writer ")) ? "false" : "true" %> }
               ]
           });
        }
    </script>
    <style type="text/css">
        .RadTreeView .rtIn {
            width:100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <aside class="cell-3 left-shop" style="padding:0px 0px;">
        <div class="widget" data-animate="fadeInLeft">
            <h3 class="widget-head">categories</h3>
            <div class="widget-content">

                <telerik:RadTreeView ID="uiRadTreeViewCats" runat="server" OnNodeClick="uiRadTreeViewCats_NodeClick">
                    <NodeTemplate>
                        <div class="cell-12" style="padding-left:0px;padding-right:0px;">
                            <div class="cell-11" style="padding-left:0px;">                                 
                                <%# Eval("NotifCount").ToString() != "0" ? "<b>" + Eval("Title") + "</b>" : Eval("Title") %>
                            </div>
                            <div class="cell-1" style="padding-left:0px;">
                                <%# Eval("NotifCount").ToString() != "0" ? "<b>(" + Eval("NotifCount").ToString() + ")</b>" : "" %>
                            </div>
                        </div>
                        
                    </NodeTemplate>
                </telerik:RadTreeView>
            </div>
        </div>

    </aside>

    <div class="cell-9 clearfix">

        <small>Please, select a category to see its manuals.</small>
        <h5>Current category :
            <asp:Label ID="uiLabelCat" runat="server"></asp:Label></h5>
        <telerik:RadGrid ID="uiRadGridmanuals" runat="server" AllowPaging="True"
            AutoGenerateColumns="False" CellSpacing="0"
            HorizontalAlign="Center" Width="100%"
            OnPageIndexChanged="uiRadGridmanuals_PageIndexChanged" EnableEmbeddedSkins="False">
            <AlternatingItemStyle HorizontalAlign="Center" />
            <MasterTableView>
                <Columns>
                                        
                    <telerik:GridTemplateColumn HeaderText="Title">
                        <ItemTemplate>
                           <%# Eval("ManualUpdates").ToString() != "0" ? "<div style='position:relative;display:block;width:100%;height:1px'><label class='badge' style='top:-12px !important;left:-10px;'>"+ Eval("ManualUpdates") +"</label></div>" : "" %>
                            <%# Eval("Title") %>                            
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    <%--<telerik:GridBoundColumn DataField="IssueNumber" HeaderText="Issue No."></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="IssueDate" HeaderText="Issue Date" DataFormatString="{0:dd/MM/yyyy}"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="RevisionNumber" HeaderText="Revision No."></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="RevisionDate" HeaderText="Revision Date" DataFormatString="{0:dd/MM/yyyy}"></telerik:GridBoundColumn>--%>
                    <telerik:GridBoundColumn DataField="CreatedByName" HeaderText="Created By"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="createdDate" HeaderText="Created Date" DataFormatString="{0:dd/MM/yyyy}"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="UpdatedByName" HeaderText="Updated By"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="LastUpdatedDate" HeaderText="Last Updated Date" DataFormatString="{0:dd/MM/yyyy}"></telerik:GridBoundColumn>
                    <telerik:GridHyperLinkColumn DataTextField="Title" DataNavigateUrlFields="VersionPath" DataTextFormatString="Download" DataNavigateUrlFormatString="{0}" HeaderText="Last version">
                    </telerik:GridHyperLinkColumn>
                    <telerik:GridTemplateColumn HeaderText="Other versions">
                        <ItemTemplate>
                            <!-- Button trigger modal -->
                            <div style='position:relative;'>
                            <button type="button" class="btn btn-primary btn-lg viewVersion" data-toggle="modal" data-target="#myModal" data-manualid="<%# Eval("ManualID") %>" data-manualName="<%# Eval("Title") %>">
                             View versions
                            </button>
                            <!-- Modal -->
                             <%# Eval("ManualVersionUpdates").ToString() != "0" ? "<label class='badge' style='top:-20% !important;left:0% !important'>"+ Eval("ManualVersionUpdates") +"</label>" : "" %>
                            </div>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridTemplateColumn HeaderText="Forms">
                        <ItemTemplate>
                            <!-- Button trigger modal -->
                            <div style='position:relative;'>
                            <a class="btn empty main-border" href="forms.aspx?mid=<%# Eval("ManualID") %>">
                             View Forms
                            </a>
                            <!-- Modal -->
                             <%# Convert.ToInt32(Eval("ManualFormUpdates").ToString()) + Convert.ToInt32(Eval("ManualFormVersionUpdates").ToString()) > 0 ? "<label class='badge' style='top:-20% !important;left:0% !important'>"+ (Convert.ToInt32(Eval("ManualFormUpdates").ToString()) + Convert.ToInt32(Eval("ManualFormVersionUpdates").ToString())) +"</label>" : "" %>
                            </div>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    
                </Columns>
                
            </MasterTableView>
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center"  />

<FilterMenu EnableImageSprites="False"></FilterMenu>

        </telerik:RadGrid>

    </div>

    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                              <div class="modal-dialog modal-lg">
                                <div class="modal-content">
                                  <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                    <h4 class="modal-title" id="myModalLabel">Manual Versions - <span id="manualName"></span></h4>
                                  </div>
                                  <div class="modal-body" id="modalbody">
                                    
                                  </div>
                                  <div class="modal-footer">
                                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>                                    
                                  </div>
                                </div>
                              </div>
                            </div>
</asp:Content>
