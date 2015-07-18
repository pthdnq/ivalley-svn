<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ComboPortal._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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

<body class="fixed-top ub" style="background:none !important; ">
    <form id="form1" runat="server" style="margin:0 !important;min-height:100%">
        

        <div id="container" class="row-fluid no-margin" style="min-height:100%">
            <div class="span12 clearfix block-margin-bottom-5 no-padding" style="margin:0 auto;float:none;padding:15px;">
                <div class="span12" style="background-color:#48157C !important;">
                    <div class="span4 clearfix block-margin-bottom-5">
                    <img src="img/portal/comboTitle.png" style="max-width:80%;float:left;margin-top:2%;"/>                        
                        </div>
                    <div class="span2">
                        <a href="#" class="btn btn-default pull-left" id="loginBtn" style="margin-top:30px;border-radius:3px;font-size:20px;">Log in</a>
                    </div>
                    <div class="span3 pull-right" style="margin-top:5%">
                        <a href="ar/default.aspx" class="JF" style="font-size:20px;color:#fff;font-weight:bold;text-decoration:none">العربية</a>
                    </div>
                </div>
                <div class="span11">
                <div class="span6">
                    
                    <div class="span12 clearfix block-margin-bottom-5" style="margin-top:40px;" >
                        <div class="span12 clearfix goth" id="splash" style="font-size:25px;color:#48157C;line-height:normal;">
                            <p><b>COMBO</b> Mobile App<br />
                            It's a Social Media App.</p><br />
                            <p>Supports all media types<br />
                            chat, photo, audio & video.</p><br />
                            <p>You can connect with friends<br />
                            and share every thing!</p>
                        </div>
                        <%--<img src="img/portal/comboText.jpg" style="max-width:100%;" />--%>

                        <div class="span12 clearfix no-margin hide" id="login" style="position:relative;">
                            <!-- BEGIN LOGIN FORM --> 
                            <div id="loading" style="height:70%;background:#fff;opacity:0.7;width:100%;position:absolute;padding-top:10%;z-index:15;text-align:center;display:none">
                                Loading ...
                                <div class="progress progress-combo active" style="margin:0 auto;width:40%">                                        
                                        <div style="width: 100%;" class="bar"></div>
                                    </div>
                            </div>                          
                            <i class="icon-2x icon-remove pull-right " style="cursor:pointer" id="loginClose"></i>
                            <div id="loginform" class="form-vertical no-padding no-margin" >
      
                              <div class="span12">
                                    <div class="hide alert alert-danger" id="errorDiv">
                                        Error. username or password aren't correct, please try again.
                                    </div>
                                  
                                  
                                  <div class="control-group block-margin-bottom-5 clearfix span8" style="float:none;margin:5px auto">
                                      <div class="controls text-center" >
                                          <div class="input-prepend">
                                              <span class="add-on"><i class="icon-user"></i></span><input id="input-username" type="text" placeholder="Username" />
                                          </div>
                                      </div>
                                  </div>
                                  <div style="clear:both;height:1px"></div>
                                  <div class="control-group block-margin-bottom-5 clearfix span8" style="float:none;margin:5px auto">
                                      <div class="controls text-center">
                                          <div class="input-prepend">
                                              <span class="add-on"><i class="icon-key"></i></span><input id="input-password" type="password" placeholder="Password" />
                                          </div>
                  
                                          <div class="clearfix space5"></div>
                                      </div>

                                  </div>

                                  <div class="span4" style="float:none;margin:0 auto;padding:0;text-align:center">
                                      <input type="button" id="login-btn" class="btn btn-block login-btn" value="Login" />
                                  </div>

                                  <div class="mtop10 span4" style="float:none;margin:0 auto;padding:0;text-align:center">
                                              <div class="block-hint small">
                                                  <a href="javascript:;" class="" id="forget-password">Forgot Password?</a>
                                              </div>
                                            
                                          </div>
                              </div>

      
                            </div>
                            <!-- END LOGIN FORM -->        
                            <!-- BEGIN FORGOT PASSWORD FORM -->
                            <div id="forgotform" class="form-vertical no-padding hide span12 text-center" style="float:none;margin:0 auto;">
                              <p class="center ub" style="color:#48157C;">Enter your e-mail address below to reset your password.</p>
                              <div class="control-group">
                                <div class="controls">
                                  <div class="input-prepend">
                                    <span class="add-on"><i class="icon-envelope"></i></span><input id="input-email" type="text" placeholder="Email"  />
                                  </div>
                                </div>
                                <div class="space20"></div>
                              </div>
                                 <div  class="span4" style="float:none;margin:0 auto">
                              <input type="button" id="forget-btn" class="btn btn-block login-btn" value="Submit" />
                                     </div>
                            </div>
                            <!-- END FORGOT PASSWORD FORM -->
                        </div>

                        </div>



                  
                </div>
                <div class="span4 pull-right" style="position:relative;min-height:100%;right:0">
                    <div class="span12 no-margin no-padding" style="min-height:100px;">
                    <img src="img/portal/hand.png" style="max-width:105%;"/>
                        <div id="slider" class="span12 no-margin no-padding" style="position:absolute;z-index:-1;left:12%;top:5%;">
                        <img src="img/portal/slider/homeDoo.jpg" style="max-width:50%"/>                     
                        <img src="img/portal/slider/homeDoo2.jpg" style="max-width:50%"/>
                        <img src="img/portal/slider/homeDoo3.jpg" style="max-width:50%"/>
                        <img src="img/portal/slider/homeDoo4.jpg" style="max-width:50%"/>
                        <img src="img/portal/slider/homeDoo5.jpg" style="max-width:50%"/>
                    </div>
                        </div>
                    
                </div>
                    </div>
                

            </div>
        </div>
        <div class="row-fluid">
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
                App.initLogin();
                $('#slider').cycle({ fx: 'fade', timeout: 3000 });               
            });
        </script>



    </form>
</body>

</html>
