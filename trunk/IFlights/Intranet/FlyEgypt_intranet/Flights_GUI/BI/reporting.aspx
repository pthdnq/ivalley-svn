<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ExceptionLight.Master" AutoEventWireup="true" CodeBehind="reporting.aspx.cs" Inherits="Flights_GUI.BI.reporting" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ MasterType VirtualPath="~/MasterPages/ExceptionLight.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">   
    <script src="../js/bootstrap.js"></script>    
    <script src="../js/purl.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            
            $("#uitextuser").typeahead({
                source: function (query, process) {
                    $.ajax({
                        url: '../Common/IntranetService.asmx/GetAvalName',
                        type: 'POST',
                        dataType: 'JSON',
                        data: 'term=' + query,
                        success: function (data) {
                            var resultList = data.map(function (item) {
                                var aItem = { id: item.UserID, name: item.label };
                                return JSON.stringify(aItem);
                            });

                            return process(resultList);
                        }
                    });
                },
                matcher: function (obj) {
                    var item = JSON.parse(obj);
                    return ~item.name.toLowerCase().indexOf(this.query.toLowerCase())
                },
                sorter: function (items) {
                    var beginswith = [], caseSensitive = [], caseInsensitive = [], item;
                    while (aItem = items.shift()) {
                        var item = JSON.parse(aItem);
                        if (!item.name.toLowerCase().indexOf(this.query.toLowerCase())) beginswith.push(JSON.stringify(item));
                        else if (~item.name.indexOf(this.query)) caseSensitive.push(JSON.stringify(item));
                        else caseInsensitive.push(JSON.stringify(item));
                    }

                    return beginswith.concat(caseSensitive, caseInsensitive)

                },
                highlighter: function (obj) {
                    var item = JSON.parse(obj);
                    var query = this.query.replace(/[\-\[\]{}()*+?.,\\\^$|#\s]/g, '\\$&')
                    return item.name.replace(new RegExp('(' + query + ')', 'ig'), function ($1, match) {
                        return '<strong>' + match + '</strong>'
                    })
                },
                updater: function (obj) {
                    var item = JSON.parse(obj);
                    $('#uiHiddenFieldUserID').attr('value', item.id);
                    return item.name;
                }
            });

            var pid = $.url().param('t');
            if (pid != "undefined") {
                switch (pid) {
                    case 'a':
                    case 's':
                    case 'm':
                    case 'f':
                    case 'c':
                        $('#selectUser').hide();
                        $('#daterange').hide();
                        $('#NoOfDays').hide();
                        $('#reportsdiv').hide();
                        $('#<%= uiLinkButtonViewReport.ClientID %>').hide();
                        break;
                    default:
                        $('#selectUser').show();
                        $('#daterange').show();
                        $('#NoOfDays').show();
                        $('#reportsdiv').show();
                        $('#<%= uiLinkButtonViewReport.ClientID %>').show();
                        break;

                }
            }
            else {
                viewsections();
            }

            $('#<%= Reports.ClientID %>').change(function () {
                viewsections();
            });

            
        });

        function viewsections()
        {
            switch ($('#<%= Reports.ClientID %>').val()) {
                case '0':
                    $('#selectUser').hide();
                    $('#daterange').hide();
                    $('#NoOfDays').hide();
                    break;
                case '1':
                    $('#selectUser').show();
                    $('#daterange').show();
                    $('#NoOfDays').hide();
                    break;
                case '2':
                    $('#selectUser').hide();
                    $('#daterange').hide();
                    $('#NoOfDays').show();
                    break;
                default:
                    $('#selectUser').hide();
                    $('#daterange').hide();
                    $('#NoOfDays').hide();

            } 
        }

        function doValidation()
        {
            switch ($('#<%= Reports.ClientID %>').val()) {
                case '0':
                    alert("No report selected.");
                    return false;
                    break;
                case '1':
                    if ($('#uiHiddenFieldUserID').val() == "")
                    {
                        alert("No user selected.");
                        return false;
                    }
                    break;
                case '2':
                    if ($('#<%= uiTextBoxNoOfDays.ClientID %>').val() == "") {
                        alert("No period specified.");
                        return false;
                    }
                    break;
                default:
                    return true;

            }
        }
    </script>
    <link href="../assets/custombootstrap/css/typeahead.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cell-12 clearfix margin-bottom-10" id="reportsdiv">
        <div class="cell-2">
            Select report
        </div>
        <div class="cell-4">
            <asp:DropDownList ID="Reports" runat="server">
                <asp:ListItem value="0">select a report ....</asp:ListItem>
                <asp:ListItem value="1">A User login history</asp:ListItem>
                <asp:ListItem value="2">All Users didn't login from a period</asp:ListItem>                
            </asp:DropDownList>
         </div>
    </div>
    <div class="cell-12 clearfix margin-bottom-10" id="selectUser">
        <div class="cell-2">
            Select user
        </div>
        <div class="cell-4">
            <input type="text" id="uitextuser" autocomplete="off" />
            <asp:HiddenField ID="uiHiddenFieldUserID" runat="server" ClientIDMode="Static"  />
         </div>
    </div>
    <div class="cell-12 clearfix margin-bottom-10" id="daterange">
        <div class="cell-2">
            From
        </div>
        <div class="cell-3">
            <telerik:RadDatePicker ID="uiRadDatePickerFrom" DateInput-DateFormat="dd/MM/yyyy" runat="server"></telerik:RadDatePicker>
         </div>
        <div class="cell-2">
            To
        </div>
        <div class="cell-3">
            <telerik:RadDatePicker ID="uiRadDatePickerTo" DateInput-DateFormat="dd/MM/yyyy" runat="server"></telerik:RadDatePicker>
         </div>
    </div>
    <div class="cell-12 clearfix margin-bottom-10" id="NoOfDays">
        <div class="cell-2">
            No. of days
        </div>
        <div class="cell-3">
            <asp:TextBox ID="uiTextBoxNoOfDays" runat="server"></asp:TextBox>
         </div>
       
    </div>
    <div class="cell-12 clearfix margin-bottom-10" >
        <div class="cell-2"></div>
        <div class="cell-2">
            <asp:LinkButton ID="uiLinkButtonViewReport" CssClass="btn main-bg" runat="server" OnClick="uiLinkButtonViewReport_Click" OnClientClick="return doValidation();">View Report</asp:LinkButton></div>
        </div>
    <div class="cell-12 clearfix margin-bottom-10" >
        <rsweb:ReportViewer ID="uiReportViewer" runat="server"  Width="100%" CssClass="reportViewer"  BackColor="White" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" SizeToReportContent="True">
            <LocalReport EnableExternalImages="true"></LocalReport>
            
        </rsweb:ReportViewer>
        </div>
</asp:Content>
