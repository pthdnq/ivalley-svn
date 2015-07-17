<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ComboPortal._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="admin/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="admin/assets/bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet" />
    <link href="admin/css/style.css" rel="stylesheet" />
    <link href="admin/css/style_purple.css" rel="stylesheet" />
    <link href="admin/css/style_responsive.css" rel="stylesheet" />
    <link href="admin/assets/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <link href="admin/assets/fancybox/source/jquery.fancybox.css" rel="stylesheet" />
    <link href="admin/assets/uniform/css/uniform.default.css" rel="stylesheet" />
    <title>COMBO</title>
</head>

<body class="fixed-top JF" style="background:none !important; background-color:#48157C !important">
    <form id="form1" runat="server" style="margin:0 !important;">
        

        <div id="container" class="row-fluid" style="margin-top:0px;">
            <div class="span12 clearfix block-margin-bottom-5" style="margin:0 auto;float:none;">
                <div class="span4" style="padding-left:2%;">
                    <div class="span12 clearfix block-margin-bottom-5">
                    <img src="img/portal/comboTitle.png" style="max-width:80%;float:left;margin-top:2%;"/>
                        
                        </div>
                    <div class="span12 clearfix block-margin-bottom-5" style="margin-top:80px;">
                        <img src="img/portal/comboText.jpg" style="max-width:100%"/>
                        </div>

                    <div class="span12 clearfix block-margin-bottom-5" style="margin-top:40px;">
                        <div class="span3">
                            <div style="border:2px solid #fff;border-radius:10px;-moz-border-radius:10px;-webkit-border-radius:10px;-ms-border-radius:10px;padding:10px;">
                            <img src="img/portal/logo.png" style="max-width:80%;margin:0 auto;display:block;" />
                                </div>
                        </div>
                        <div class="span1"></div>
                        <div class="span7" style="padding-top:4%;">
                            <img src="img/portal/play-store.png" />
                        </div>
                        </div>
                </div>
                <div class="span8" style="position:absolute;z-index:15;">
                    <a href="Login.aspx" class="btn btn-default pull-left" style="margin-top:30px;border-radius:3px;font-size:20px;">Log in</a>
                    <img src="img/portal/hand.png" style="max-width:69.85%"/>
                    <div class="span3" style="position:absolute;font-size:30px;font-weight:bold;color:#48157C;bottom:2%;z-index:16;right:2%;">
                        combomobile.com
                    </div>
                   
                </div>
                 <div id="slider" class="span4" style="position:absolute;z-index:14;
                    transform:rotateX(12deg) rotateY(32deg) rotateZ(-12deg);
                    -webkit-transform:rotateX(12deg) rotateY(32deg) rotateZ(-12deg);
                    -ms-transform:rotateX(12deg) rotateY(32deg) rotateZ(-12deg);
                    -o-transform:rotateX(12deg) rotateY(32deg) rotateZ(-12deg);
                    -moz-transform:rotateX(12deg) rotateY(32deg) rotateZ(-12deg);
                     padding-right:44%;margin-top:6%;">
                    <img src="img/portal/slider/homeDoo.jpg" style="max-width:36.5%"/>                     
                    <img src="img/portal/slider/homeDoo2.jpg" style="max-width:36.5%"/>
                    <img src="img/portal/slider/homeDoo3.jpg" style="max-width:36.5%"/>
                    <img src="img/portal/slider/homeDoo4.jpg" style="max-width:36.5%"/>
                    <img src="img/portal/slider/homeDoo5.jpg" style="max-width:36.5%"/>
                </div>

            </div>
        </div>

       <%-- <div id="footer">
            <span class="ub">2015 &copy; I-Valley. All rights reserved.</span>
            
        </div>--%>

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
                $('#slider').cycle({ fx: 'fade', timeout: 3000 });
            });
        </script>



    </form>
</body>

</html>
