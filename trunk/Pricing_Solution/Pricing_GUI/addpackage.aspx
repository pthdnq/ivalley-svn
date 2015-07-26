<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addpackage.aspx.cs" Inherits="Pricing_GUI.addpackage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/jquery-1.8.3.min.js"></script>
    <link href="assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
	<link href="assets/bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet" />
	<link href="assets/font-awesome/css/font-awesome.css" rel="stylesheet" />
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
   
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="uiHiddenFieldTradCode" ClientIDMode="Static" runat="server" />
        <asp:Panel ID="uiPanelAdd" runat="server" CssClass="row-fluid">
             <div class="span12 clearfix">
        <div class="span2">
            Pack unit
        </div>
        <div class="span3">
            <asp:DropDownList ID="uiDropDownListPackUnit" runat="server"></asp:DropDownList>
        </div>
        <div class="span2">
            Pack unit name
        </div>
        <div class="span3">
            <asp:DropDownList ID="uiDropDownListPackUnitName" runat="server"></asp:DropDownList>
        </div>
    </div>
        <div class="span12 clearfix">
        <div class="span2">
            conver. sub.
        </div>
        <div class="span3">
            <asp:TextBox ID="uiTextBoxConverSub" runat="server"></asp:TextBox>
        </div>
        <div class="span2">
            unit price
        </div>
        <div class="span3">
            <asp:TextBox ID="uiTextBoxUnitPrice" runat="server"></asp:TextBox>
        </div>
    </div>
        <div class="span12 clearfix">
        <div class="span2">

        </div>
        <div class="span3">
            <asp:LinkButton ID="uiLinkButtonSave" runat="server" CssClass="btn btn-primary" OnClick="uiLinkButtonSave_Click">Save</asp:LinkButton>
        </div>
        
    </div>
        </asp:Panel>
        <asp:Panel ID="uiPanelSuccess" runat="server">
            <div class="alert alert-success">
                Package saved successfully
            </div>
        </asp:Panel>
        <script type="text/javascript">
            function setTradeCode(tradeCode)
            {
                $('#uiHiddenFieldTradCode').val(tradeCode);
            }
            
    </script>
    </form>
</body>
</html>
