<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resetpassword.aspx.cs" Inherits="ComboPortal.resetpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="height:100% ">
<head runat="server">
     <link href="admin/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="admin/assets/bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet" />
    <link href="admin/css/style_ltr.css" rel="stylesheet" />
    <link href="admin/css/style_purple.css" rel="stylesheet" />
    <link href="admin/css/style_responsive.css" rel="stylesheet" />
    <link href="admin/assets/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <link href="admin/assets/fancybox/source/jquery.fancybox.css" rel="stylesheet" />
    <link href="admin/assets/uniform/css/uniform.default.css" rel="stylesheet" />
    <title>COMBO</title>    
</head>
<body class="fixed-top ub" style="background:none !important;height:100% ">
    <form id="form1" runat="server" style="margin:0 !important;min-height:100%">
        

        <div id="container" class="row-fluid no-margin" style="min-height:100%">
            <div class="span12 clearfix block-margin-bottom-5 no-padding" style="margin:0 auto;float:none;padding:15px;">
                <div class="span12" style="background-color:#48157C !important;margin-bottom:10px;">
                    <div class="span4 clearfix block-margin-bottom-5">
                    <img src="img/portal/comboTitle.png" style="max-width:65%;float:left;margin-top:2%;"/>                        
                        </div>
                   
                </div>
                    </div>

            <div class="span6" style="padding:10px;margin:20px auto;float:none">
                <asp:Panel ID="uiPanelReset" runat="server">
             <div class="span12">
                <div class="span3">New password : </div>
                <div class="span4">
                    <asp:TextBox ID="uiTextBoxPass" TextMode="Password" runat="server"></asp:TextBox>                    
                </div>
                 <div class="span2">
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="uiTextBoxPass" runat="server" ErrorMessage="*" Font-Bold="true" ForeColor="Red" ValidationGroup="resetpass"></asp:RequiredFieldValidator>
                 </div>
            </div>
            <div class="span12 no-margin">
                <div class="span3">confirm password : </div>
                <div class="span4">
                    <asp:TextBox ID="uiTextBoxcpass" TextMode="Password" runat="server"></asp:TextBox>                    
                </div>
                <div class="span4">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="uiTextBoxcpass" ControlToCompare="uiTextBoxPass" ErrorMessage="passwords don't match" Font-Bold="true" ForeColor="Red" ValidationGroup="resetpass"></asp:CompareValidator>
                </div>
            </div>
            <div class="span12 no-margin">
                <div class="span3"></div>
                <div class="span4">
                    <asp:Button ID="uiButtonSave" runat="server" Text="Reset password" ValidationGroup="resetpass" OnClick="uiButtonSave_Click" CssClass="btn " /></div>
            </div>
        </asp:Panel>
        <asp:Panel ID="uiPanelError" runat="server" CssClass="span12 no-margin" style="padding:20px;">
            <div class="span12 alert alert-danger" >
            Error , please ask to reset your password again.
                </div>
        </asp:Panel>

         <asp:Panel ID="uiPanelsuccess" runat="server" CssClass="span12 no-margin" style="padding:20px;">
             <div class="span12 alert alert-success">
            Password has been changed successfully.
                 </div>
        </asp:Panel>
   
            </div>
        </div>
        <div class="row-fluid" style="position:fixed;bottom:0;">
        <div id="footer" class="span12 no-margin" style="position:relative">
              <div class="span4 clearfix">
                        <div class="span2" >
                            <div style="border:2px solid #fff;border-radius:10px;-moz-border-radius:10px;-webkit-border-radius:10px;-ms-border-radius:10px;padding:10px;">
                            <img src="img/portal/logo.png" style="max-width:100%;margin:0 auto;display:block;" />
                                </div>
                        </div>
                        <div class="span1"></div>
                        <div class="span7">
                            <img src="img/portal/play-store.png" style="border:2px solid #48157C;border-radius:10px;-moz-border-radius:10px;-webkit-border-radius:10px;-ms-border-radius:10px;"/>
                        </div>
                        </div>
            <span class="ub center span4" style="margin:0 auto;float:none;padding-top:2%;">2015 &copy; I-Valley. All rights reserved.</span>
            <div class="span4 pull-right no-margin no-padding" style="font-size:30px;font-weight:bold;color:#fff;">
                        combomobile.com
                    </div>
            
        </div>
            </div>
        <script src="admin/js/jquery-1.8.3.min.js"></script>
        <script src="js/jquery.cycle.all.js"></script>
        <script src="admin/assets/bootstrap-rtl/js/bootstrap.min.js"></script>
        <script src="admin/js/jquery.blockui.js"></script>
        <!--[if lt IE 9]>
   <script src="admin/js/excanvas.js"></script>
   <script src="admin/js/respond.js"></script>
   <![endif]-->
        <script src="admin/assets/chosen-bootstrap/chosen/chosen.jquery.min.js"></script>
        <script src="admin/assets/uniform/jquery.uniform.min.js"></script>
        
        <script src="admin/js/scripts.js"></script>
        <script>

            jQuery(document).ready(function () {
                // initiate layout and plugins
                App.init();
                //App.initLogin();
                //$('#slider').cycle({ fx: 'fade', timeout: 3000 });
            });
        </script>



    </form>
</body>
</html>
