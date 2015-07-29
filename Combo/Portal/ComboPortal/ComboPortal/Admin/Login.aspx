<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ComboPortal.Admin.Login" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="assets/bootstrap-rtl/css/bootstrap-rtl.min.css" rel="stylesheet" />
    <link href="assets/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/style_gray.css" rel="stylesheet" />
    <link href="css/style_responsive.css" rel="stylesheet" />
    <title>COMBO Admin Login</title>
    <style type="text/css">
        #login {
            background: #e3e3e3;
            box-shadow: 1px 0 1px #FFFFFF, 0 0 3px rgba(0, 0, 0, 0.2) inset;
            -moz-box-shadow: 1px 0 1px #FFFFFF, 0 0 3px rgba(0, 0, 0, 0.2) inset;
            -webkit-box-shadow: 1px 0 1px #FFFFFF, 0 0 3px rgba(0, 0, 0, 0.2) inset;
            width: 370px;
            margin: 50px auto 0;
            padding: 20px;
        }

        .login-btn {
            background-color: #8c57c3;
            border: none;
            box-shadow: 1px 0 1px #FFFFFF, 0 0 3px rgba(0, 0, 0, 0.2) inset;
            -moz-box-shadow: 1px 0 1px #FFFFFF, 0 0 3px rgba(0, 0, 0, 0.2) inset;
            -webkit-box-shadow: 1px 0 1px #FFFFFF, 0 0 3px rgba(0, 0, 0, 0.2) inset;
            border-radius: 0;
            -moz-border-radius: 0;
            -webkit-border-radius: 0;
            font-size: 16px;
            color: #fff;
            text-shadow: none;
            padding: 10px 0;
        }
    </style>
</head>
<body id="login-body">
    <form id="form1" runat="server">
        <div class="login-header">
            <!-- BEGIN LOGO -->
            <div id="logo" class="center ub">
                COMBO
            </div>
            <!-- END LOGO -->
        </div>

        <!-- BEGIN LOGIN -->
        <div id="login">
            <!-- BEGIN LOGIN FORM -->
            <div id="loginform" class="form-vertical no-padding no-margin">
                <div class="lock">
                    <i class="icon-lock"></i>
                </div>
           <asp:Login ID="Login1" runat="server" OnLoggedIn="Login1_LoggedIn">
                    <LayoutTemplate>
                        <div class="control-wrap">
                    <h4>تسجيل الدخول</h4>

                    <div class="control-group">
                        <div class="controls">
                            <div class="input-prepend">
                                <span class="add-on"><i class="icon-user"></i></span>
                                <asp:TextBox ID="UserName" runat="server" placeholder="اسم المستخدم"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                        ControlToValidate="UserName" ErrorMessage="User Name is required." 
                                        ToolTip="User Name is required." ValidationGroup="Login1" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                    <div class="control-group">
                        <div class="controls">
                            <div class="input-prepend">
                                <span class="add-on"><i class="icon-key"></i></span>
                                <asp:TextBox ID="Password" runat="server" TextMode="Password" placeholder="كلمة المرور"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server"
                                    ControlToValidate="Password" ErrorMessage="Password is required."
                                    ToolTip="Password is required." ValidationGroup="Login1" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </div>
                            <div class="clearfix space5"></div>
                        </div>
                    </div>
                </div>
                        <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="دخول" ValidationGroup="Login1" CssClass="btn btn-block login-btn"/>
                    </LayoutTemplate>
                </asp:Login>
                </div>
        </div>
        <div id="login-copyright">
            2015 &copy; COMBO. All rights reserved
        </div>
    </form>
    <script src="js/jquery-1.8.3.min.js"></script>
    <script src="assets/bootstrap-rtl/js/bootstrap.min.js"></script>
    <script src="js/jquery.blockui.js"></script>
    <script src="js/scripts.js"></script>
    <script>
        jQuery(document).ready(function () {
            App.initLogin();
        });
    </script>

</body>
</html>
