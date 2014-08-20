﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Chat2Connect._default" %>

<!DOCTYPE html>

<html lang="ar" class="tr-coretext tr-aa-subpixel">
<head runat="server">
    <title></title>
    <meta name="keywords" content="" />
    <meta name="description" content="" />
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta content="I-VALLEY" name="author" />
    <!-- stylesheets -->
    <%--<link href="css/jquery-ui-1.10.3.custom.min.css" rel="stylesheet" type="text/css" />--%>
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <%--<link href="css/bootstrap-theme.min.css" rel="stylesheet" type="text/css" />--%>
    <link href="css/base.css" rel="stylesheet" />    
    <link href="css/skeleton_subject.css" rel="stylesheet" />
    <link href="css/validationEngine.jquery.css" rel="stylesheet" />
    <link href="css/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />        
    <link href="css/main.css" rel="stylesheet" />
   
</head>
<body >
    <form id="form1" runat="server">
    <section class="row">
        <div class="header">
            <div>
                <asp:Login ID="Login1" runat="server" style="float:left;margin-top:40px;margin-left:40px;" OnLoggedIn="Login1_LoggedIn">
                    <LayoutTemplate>
                        
                        <div class="form-horizontal blockBoxBlack validationGroup" id="Login">
                            <div style="position:absolute;padding:10px;">
                                <img src="images/home/Login.png" />
                            </div>
                            <div class="form-group">
                                <div class="col-sm-3 control-label pull-right">
                                    
                                </div>
                                <div class="col-sm-9 pull-right">
                                    <asp:TextBox ID="UserName" runat="server" placeholder="إسم المستخدم" CssClass="form-control" ></asp:TextBox> 
                                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="*" ToolTip="من فضلك أدخل إسم المستخدم ." ValidationGroup="Login1" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>                                   
                                </div>
                             </div>
                            <div class="form-group">
                                <div class="col-sm-3 control-label pull-right">
                                    
                                </div>
                                <div class="col-sm-9 pull-right">
                                    <asp:TextBox ID="Password" runat="server" TextMode="Password" placeholder="كلمة المرور" CssClass="form-control" ></asp:TextBox> 
                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="*" ToolTip="من فضلك أدخل كلمة المرور ." ValidationGroup="Login1" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>                                                                      
                                </div>
                             </div>
                            <div class="form-group">
                                
                                <div class="col-sm-9">                
                                    <a style="color:#fff;text-decoration:none;font-size:12px;" class="pull-right" href="#resetPassModal" data-toggle="modal">نسيت كلمة السر ؟</a><span class="pull-right">&nbsp;&nbsp;</span>    
                                <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="دخول" ValidationGroup="Login1" CssClass="pull-left btn"  />
                                            
                                </div>
                            </div>
                            <div class="form-group">                                
                                <asp:CheckBox ID="uiCheckBoxInvisible" runat="server"  CssClass="remember pull-left" Text="مخفى"  style="margin-top:10px;"  />
                                <asp:CheckBox ID="RememberMe" runat="server" Text="تذكرنى" CssClass="remember pull-left" style="margin-top:10px;"/>                                    
                                <a href="#registerModal" data-toggle="modal" class="pull-right" style="margin-right:10px;margin-top:20px;">مشترك جديد؟ إضغط هنا
                                    </a>
                            </div>

                        </div>
                    </LayoutTemplate>
                </asp:Login>                
            </div>
        </div>
    </section>
    <section class="row ">
        <div style="padding:20px;">
            <div class="col-lg-5" style="margin-top:5px;">
                <a href="#registerModal" data-toggle="modal">
                <img src="images/home/join.png" />
                    </a>
                <div class="clearfix"></div>
                <div style="margin-right:-20px;margin-top:10px;">
                    <img src="images/home/txt.png" />

                </div>
               <%-- <h3 style="color:#323232;">
                    ادخل عالما جديدا من الأصدقاء
                </h3>
                <h4 style="color:#323232;">
                    تمتع فى موقعنا فى الدخول <br />
                    لأكثر من عشرين قسم من اقسام الغرف

                </h4>--%>
                <div style="margin-top:90px;width:100%;text-align:left;">

                    <img src="images/home/appstore.png" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <img src="images/home/googleplay.png" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <img src="images/home/appworld.png" />
                </div>
            </div>
            <div class="col-lg-7">
                <img src="images/home/imaciphone.png" style="margin-top:-150px;" />
            </div>
            <div class="clearfix"></div>
        </div>
    </section>
        <div id="registerModal"  class="modal fade" role="modal" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <a class="close pull-left" data-dismiss="modal" aria-hidden="true" style="text-decoration:none;" >
                            ×</a>
                        <i class="icon-4x" style="float:left;font-family:'entypo';margin-left:10px;">-</i>
                        <h3 id="myModalLabel1">
                            مشترك جديد</h3>
                    </div>
                    <div class="modal-body">
                            <div class="form-horizontal blockBox validationGroup">                               
                                <h4>ادخل عالما جديدا من الأصدقاء</h4>
                                <div class="form-group">
                                    <div class="col-sm-12 control-label pull-right">
                                        <asp:Label ID="ErrorMessage" runat="server" EnableViewState="False" Visible="false" ForeColor="red"></asp:Label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-4 control-label pull-right">
                                        <label>إسم المستخدم</label>
                                    </div>
                                    <div class="col-sm-8 pull-right">
                                        <asp:TextBox ID="UserName" runat="server" onkeypress="return validChars(event);" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="من فضلك أدخل إسم المستخدم ." ToolTip="من فضلك أدخل إسم المستخدم ." ValidationGroup="CreateUserWizard1" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="valPassword" runat="server" ControlToValidate="UserName" ErrorMessage="يجب أن يكون اسم المستخدم مكون من 4 إلى 17 حرف." ValidationExpression=".{4,17}.*" Display="Dynamic" ForeColor="Red" />
                                        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="إسم المستخدم غير مطابق للشروط" ClientValidationFunction="isValid" ControlToValidate="UserName" Display="Dynamic" ForeColor="Red"></asp:CustomValidator>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <div class="col-sm-4 control-label pull-right">
                                        <label>كلمة المرور</label>
                                    </div>
                                    <div class="col-sm-8 pull-right">
                                        <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="من فضلك أدخل كلمة المرور." ToolTip="من فضلك أدخل كلمة المرور." ValidationGroup="CreateUserWizard1" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Password" ErrorMessage="يجب أن تكون كلمة المرور مكونة من 4 إلى 17 حرف." ValidationExpression=".{4,17}.*" Display="Dynamic" ForeColor="Red" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-4 control-label pull-right">
                                        <label>تأكيد كلمة المرور</label>
                                    </div>
                                    <div class="col-sm-8 pull-right">
                                        <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="من فضلك قم بإعادة كلمة المرور." ToolTip="من فضلك قم بإعادة كلمة المرور." ValidationGroup="CreateUserWizard1" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                                        <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" ErrorMessage="كلمة المرور غير متطابقة." ValidationGroup="CreateUserWizard1" Display="Dynamic" ForeColor="Red"></asp:CompareValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-4 control-label pull-right">
                                        <label>البريد الإلكترونى</label>
                                    </div>
                                    <div class="col-sm-8 pull-right">
                                        <asp:TextBox ID="Email" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" ErrorMessage="من فضلك أدخل البريد الإلكترونى." ToolTip="من فضلك أدخل البريد الإلكترونى." ValidationGroup="CreateUserWizard1" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-4 control-label pull-right">
                                        <label>السؤال السرى</label>
                                    </div>
                                    <div class="col-sm-8 pull-right">                                        
                                        <asp:DropDownList ID="Question" runat="server" CssClass="form-control" >                     
            	                            <asp:ListItem Value="0">اختر السؤال السرى</asp:ListItem>
            	                            <asp:ListItem> اين ولدت</asp:ListItem>
            	                            <asp:ListItem>اقرب صديق اليك</asp:ListItem>
            	                            <asp:ListItem>اين تسكن</asp:ListItem>
            	                            <asp:ListItem>افضل مدينه زرتها</asp:ListItem>
            	                            <asp:ListItem>سيارة تتمنى اقتنائها</asp:ListItem>			
                                        </asp:DropDownList>                                        
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-4 control-label pull-right">
                                        <label>إجابة السوال السرى</label>
                                    </div>
                                    <div class="col-sm-8 pull-right">
                                        <asp:TextBox ID="Answer" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" ControlToValidate="Answer" ErrorMessage="من فضلك أدخل إجابة السؤال السرى." ToolTip="من فضلك أدخل إجابة السؤال السرى." ValidationGroup="CreateUserWizard1" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-12 control-label pull-right">

                                        <asp:CheckBox ID="uiCheckBoxAgree" runat="server" CssClass="AcceptedAgreement" Text="أوافق على شروط إستخدام الموقع" />
                                        <br />
                                        <asp:CustomValidator runat="server" ID="CheckBoxRequired" EnableClientScript="true" ValidationGroup="CreateUserWizard1"
                                            ClientValidationFunction="CheckBoxRequired_ClientValidate" Display="Dynamic" ForeColor="Red">يجب إختيار 'أوافق على شروط إستخدام الموقع'</asp:CustomValidator>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-offset-2 col-sm-6 pull-left">
                                        <asp:Button ID="uiButtonRegister" runat="server" Text="إشترك" CssClass="btn btn-warning " ValidationGroup="CreateUserWizard1" Style="width: 100px;" OnClick="uiButtonRegister_Click" />
                                    </div>
                                </div>

                            </div>
                        </div>
                    
                </div>
            </div>
        </div>

        <div id="resetPassModal"  class="modal fade" role="modal" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <a class="close pull-left" data-dismiss="modal" aria-hidden="true" style="text-decoration:none;" >
                            ×</a>
                        <i class="icon-4x" style="float:left;font-family:'entypo';margin-left:10px;">-</i>
                        <h3 >
                            إستعادة كلمة المرور</h3>
                    </div>
                    <div class="modal-body">
                            <div class="form-horizontal blockBox validationGroup">                                                              
                                <div class="form-group">
                                    <div class="col-sm-4 control-label pull-right">
                                        <label>البريد الإلكترونى</label>
                                    </div>
                                    <div class="col-sm-8 pull-right">
                                        <asp:TextBox ID="uiTextBoxReset_Mail" runat="server" CssClass="form-control" data-bind="value:email"></asp:TextBox>                                        
                                    </div>
                                </div>
                                
                                <div class="form-group">
                            <div id="loadingResetPass" class="col-lg-11" style="text-align:center;display:none;text-align:center;position:fixed;z-index:2000;background:#fff;width:100%;height:100%;top:0;left:0; opacity:.7;" >
                                <img src="images/addfriend_loadinf.gif" style="margin:0 auto;padding-top:20px;"/>
                                
                            </div>
                            <div id="error" class="col-lg-12" style="text-align:center;display:none;text-align:center;" >
                                حدث خطأ من فضلك أعد المحاولة
                            </div>
                            <div id="noAccounts" class="col-lg-12" style="text-align:center;display:none;text-align:center;" >
                                لا يوجد حسابات مرتبطة بهذا البريد الإلكترونى

                            </div>
                            <ul class="findFriends">
                            <!-- ko foreach:accounts -->
                            <li >
                                <div style="width:27%;float:left;margin-right:3px;">
                                    <img style="width:50px;" data-bind="attr: { src: ProfileImg }" />
                                </div>
                                <div style="width:70%;float:left;text-align:left;">
                                    <span data-bind="text: MemberName"></span>
                                    <div class="clear" style="height:2px;"></div>
                                    <a href="#" data-bind="click: $parent.Resetpass.bind($data, $data.MemberID)" class="btn btn-main smallbtn">إستعادة كلمة المرور</a>                                   
                                    
                                </div>
                                <div class="clear" style="height:2px;"></div>
                            </li>

                            <!-- /ko -->
                                </ul>
                            <div class="clear" style="height:2px;"></div>
                        </div>
                                
                            </div>
                        </div>
                    
                </div>
            </div>
        </div>
    <footer class="row" >
        &copy; <script type="text/javascript">document.write(new Date().getFullYear());</script> Dardashet Tawasol. All rights reserved.
        <div style="float:right;padding-right:10px;width:15%;padding:0px;margin-top:-5px;">
            Powered by &nbsp; <a href="http://I-valley.com">
                <img src="images/IValley.png" title="I-VALLEY software solutions" style="vertical-align: middle;"
                    alt="I-VALLEY software solutions" /></a>

        </div>
    </footer>
    
    <!-- All js -->
    <script src="js/trmix.js"></script>
    <script src="js/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script src="js/jquery.slimscroll.min.js"></script>
    <script src="js/bootstrap.min.js" type="text/javascript"></script>
    <script src="js/bootstrap-datepicker/js/bootstrap-datepicker.js"></script>
   <%-- <script src="js/Mainjs.js" type="text/javascript"></script>--%>
    <script src="js/jquery.validationEngine-en.js"></script>        
    <script src="js/jquery.validationEngine.js"></script>
    <script src="js/group_validation.js"></script>
    <script src="Scripts/knockout-3.1.0.js"></script>
    <script src="Scripts/knockout.mapping-latest.js"></script>
        <script src="js/resetpass.js"></script>
         <script type="text/javascript">
             $(document).ready(function () {
                 initaccount();
             });

    </script>
    </form>
</body>
</html>
