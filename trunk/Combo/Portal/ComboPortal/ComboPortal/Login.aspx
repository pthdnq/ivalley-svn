<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ComboPortal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
  <title>Login page</title>
  <meta content="width=device-width, initial-scale=1.0" name="viewport" />
  <meta content="" name="description" />
  <meta content="" name="author" />
  <link href="admin/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
  <link href="admin/assets/font-awesome/css/font-awesome.css" rel="stylesheet" />
  <link href="admin/css/style_ltr.css" rel="stylesheet" />
  <link href="admin/css/style_responsive.css" rel="stylesheet" />
  <link href="admin/css/style_purple.css" rel="stylesheet" id="style_color" />
</head>
<body id="login-body" class="row-fluid">
    <form id="form1" runat="server">
     

  <!-- BEGIN LOGIN -->
  <div id="login">
    <!-- BEGIN LOGIN FORM -->
      <div class="span12 clearfix block-margin-bottom-5">
          <div class="span4" style="float:none;margin:0 auto">
              <img src="img/portal/logo.png" style="max-width:40%;margin:0 auto;display:block;"/>
          </div>
      </div>

      <div style="clear:both;height:20px"></div>
    <div id="loginform" class="form-vertical no-padding no-margin" >
      
      <div class="span12">
          
          <div class="control-group block-margin-bottom-5 clearfix span6" style="float:none;margin:5px auto">
              <div class="controls text-center" >
                  <div class="input-prepend">
                      <span class="add-on"><i class="icon-user"></i></span><input id="input-username" type="text" placeholder="Username" />
                  </div>
              </div>
          </div>
          <div style="clear:both;height:1px"></div>
          <div class="control-group block-margin-bottom-5 clearfix span6" style="float:none;margin:5px auto">
              <div class="controls text-center">
                  <div class="input-prepend">
                      <span class="add-on"><i class="icon-key"></i></span><input id="input-password" type="password" placeholder="Password" />
                  </div>
                  
                  <div class="clearfix space5"></div>
              </div>

          </div>

          <div class="span2" style="float:none;margin:0 auto;padding:0;text-align:center">
              <input type="submit" id="login-btn" class="btn btn-block login-btn" value="Login" />
          </div>

          <div class="mtop10 span4" style="float:none;margin:20px auto">
                      <div class="block-hint pull-left small">
                          <a href="javascript:;" class="" id="forget-password">Forgot Password?</a>
                      </div>
                      <div class="block-hint pull-right">
                          <a href="javascript:;" class="" id="not_member">Not a member?</a>
                      </div>
                  </div>
      </div>

      
    </div>
    <!-- END LOGIN FORM -->        
    <!-- BEGIN FORGOT PASSWORD FORM -->
    <div id="forgotform" class="form-vertical no-padding hide span12 text-center" style="float:none;margin:0 auto;">
      <p class="center ub" style="color:#fff;">Enter your e-mail address below to reset your password.</p>
      <div class="control-group">
        <div class="controls">
          <div class="input-prepend">
            <span class="add-on"><i class="icon-envelope"></i></span><input id="input-email" type="text" placeholder="Email"  />
          </div>
        </div>
        <div class="space20"></div>
      </div>
         <div  class="span2" style="float:none;margin:0 auto">
      <input type="button" id="forget-btn" class="btn btn-block login-btn" value="Submit" />
             </div>
    </div>
    <!-- END FORGOT PASSWORD FORM -->
  </div>
  <!-- END LOGIN -->
  <!-- BEGIN COPYRIGHT -->
        <div class="clearfix space5"></div>
  <div id="login-copyright" style="position:absolute;bottom:auto;bottom:initial;left:40%;padding-bottom:10px;">
      <span class="ub">2015 &copy; I-Valley. All rights reserved.</span>
  </div>
  <!-- END COPYRIGHT -->
  <!-- BEGIN JAVASCRIPTS -->
  <script src="admin/js/jquery-1.8.3.min.js"></script>
  <script src="admin/assets/bootstrap/js/bootstrap.min.js"></script>
  <script src="admin/js/jquery.blockui.js"></script>
  <script src="admin/js/scripts.js"></script>
  <script>
      jQuery(document).ready(function () {
          App.initLogin();
      });
  </script>
  <!-- END JAVASCRIPTS -->


    </form>
</body>
</html>
