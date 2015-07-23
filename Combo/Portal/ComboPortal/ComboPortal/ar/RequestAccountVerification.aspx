<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterAr.Master" AutoEventWireup="true" CodeBehind="RequestAccountVerification.aspx.cs" Inherits="ComboPortal.ar.RequestAccountVerification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="span12 no-margin rounded" >
        <h3>طلب توثيق حساب</h3>
    
      <asp:Panel runat="server" ID="uiPanelAdd"> 

    
   
    <div class="span12 clearfix no-margin" id="MainInfo">
        <div class="span5">
             <div class="span12 clearfix no-margin">
                <div class="span4">
                    نوع الحساب
                </div>
                <div class="span6">
                    <select id="AccountType" runat="server" >
                        <option value="0">إختر نوع الحساب ...</option>
                        <option value="1">حساب شخصى</option>
                        <option value="2">حساب رسمى </option>
                        <option value="3">حساب متاجر</option>
                    </select>
                </div>
                 <div class="span2">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator14" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="AccountType" InitialValue="0"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="noOrg">
            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0" >
                <div class="span4">الإسم</div>
                <div class="span6">
                    <asp:TextBox ID="uiTextBoxName" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxName"></asp:RequiredFieldValidator>
                </div>
            </div>             
            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0">
                <div class="span4">رقم الجواز/الهوية</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxPassNo" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxPassNo"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0">
                <div class="span4">تاريخ الميلاد</div>
                <div class="span6">
                    <div class="controls">
                                            <div class="input-append date date-picker" data-date="12-02-2012" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                                                <asp:TextBox ID="uiTextBoxDOB" runat="server" Style="direction:ltr"></asp:TextBox>                                                
                                                <span class="add-on"><i class="icon-calendar"></i></span>
                                            </div>
                                        </div>
                    </div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxDOB"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0">
                <div class="span4">النوع</div>
                <div class="span6">
                    <asp:DropDownList ID="uiDropDownListGender" runat="server"></asp:DropDownList></div>
                <div class="span1"></div>
            </div>

            </div>

            <div id="Org1">
                <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0" >
                <div class="span4">الإسم 
                    
                </div>
                <div class="span8">
                    <asp:TextBox ID="uiTextBoxOrgName" runat="server"></asp:TextBox>
                    <br /><sub>
                      الشركة / المصنع / الفرقة / المؤسسة / حمعية / هيئة حكومية / هيئة خيرية 
                    </sub>
                </div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxOrgName"></asp:RequiredFieldValidator>
                </div>
                </div>
                
            </div>

            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0">
                <div class="span4">البلد</div>
                <div class="span6"><asp:DropDownList ID="uiDropDownListCountry" runat="server"></asp:DropDownList></div>
                <div class="span1"></div>
            </div>

            <div id="Org2">
                <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0" >
                <div class="span4">المدينة 
                    
                </div>
                <div class="span8">
                    <asp:TextBox ID="uiTextBoxCity" runat="server"></asp:TextBox>                    
                </div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxCity"></asp:RequiredFieldValidator>
                </div>
                </div>
                <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0" >
                <div class="span4">معلومات أكثر عن العنوان 
                    
                </div>
                <div class="span8">
                    <asp:TextBox ID="uiTextBoxAddressInfo" runat="server"></asp:TextBox>                    
                </div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxAddressInfo"></asp:RequiredFieldValidator>
                </div>
                </div>

                <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0" >
                <div class="span4">نشاط الشركة
                    
                </div>
                <div class="span8">
                    <asp:TextBox ID="uiTextBoxCompanyField" runat="server"></asp:TextBox>                    
                </div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxCompanyField"></asp:RequiredFieldValidator>
                </div>
                </div>
            </div>

            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0">
                <div class="span4">رقم الجوال</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxMobileNo" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator8" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxMobileNo"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0">
                <div class="span4">رقم الجوال (2)</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxMobileNo2" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator9" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxMobileNo2"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0">
                <div class="span4">إسم الحساب</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxAccountName" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator10" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxAccountName"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0">
                <div class="span4">جواب الأمان</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxSecurityWord" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator11" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxSecurityWord"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0">
                <div class="span4">البريد الإلكترونى</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxEmail" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator12" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxEmail"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0">
                <div class="span4">كلمة المرور</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxPassword" TextMode="Password" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator13" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxPassword"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="span7">
            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0">
                <div class="span3">صورة الجواز/ الهوية</div>
                <div class="span8">
                     <iframe src="../uiUpload_ar.html?key=passport" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                </div>
                
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0">
                <div class="span3">صورة شخصية</div>
                <div class="span8">
                     <iframe src="../uiUpload_ar.html?key=pic" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                </div>
                
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0">

                <p>
                  نعم أنا مالك هذا الحساب وجميع البيانات الشخصية وبيانات الحساب وصورة الجواز/الهوية وصاحب الصورة الشخصية صحيحة. 
                    ولم أنتحل أى شخصية وأكون المسؤول الأول قانونياً عند مخالفتى لما ذكرت . وأكون تحت طائلة المسؤولية فى أى مكان فى العالم وفى أى دولة .
                     وأتعهد بأن أحافظ على معلومات حسابى هذا وأسقط حقى لتطبيق Combo من أى مسؤولية قانونية فيما تم رفعه من معلومات شخصية وصورة الجواز/الهوية والصورة الشخصية 
                    وكذلك ما يتم نشره من حسابى وأوافق على نتيجة طلب التوثيق الموافقة أو الرفض 
                    وكذلك ينص كلامى على من يعملون داخلCombo فى جميع الأقسام والشركة الداعمة
                     لها وشركات التسويق ومزود خدمة الإنترنت لـ combo
                </p>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-right: 0">
                <div class="span2"><asp:LinkButton ID="uiLinkButtonSave" runat="server" CssClass="btn btn-primary" ValidationGroup="add" OnClick="uiLinkButtonSave_Click">حفظ</asp:LinkButton></div>
                <div class="span6">
                    </div>
                <div class="span2"></div>
            </div>
        </div>
    </div>

        </asp:Panel>
    <asp:Panel runat="server" ID="uiPanelResult"> 
        <div class="span12 clearfix">
            <h3>
                نتيجة الطلب
            </h3>
            <div class="span12 no-margin no-padding alert alert-success" id="accepted" runat="server">
               تم توثيق حسابك
            </div>
            <div class="span12 no-margin no-padding alert alert-success" id="rejected" runat="server">
                تم رفض طلبك لتوثيق الحساب
                <p>
                    <asp:Literal ID="uiLiteralReason" runat="server"></asp:Literal>
                </p>
            </div>
            <div class="span12 no-margin no-padding alert alert-info" id="noresult" runat="server">
               طلبك تحت المراجعة
            </div>
        </div>
    </asp:Panel>
        </div>
    <div class="space10"></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
      <link href="../Admin/assets/bootstrap-datepicker/css/datepicker.css" rel="stylesheet" />
     <script src="../admin/assets/bootstrap-datepicker/js/bootstrap-datepicker.js"></script>
    <script src="../admin/assets/bootstrap-daterangepicker/date.js"></script>
    <script src="../admin/assets/bootstrap-daterangepicker/daterangepicker.js"></script>
    <script src="../admin/assets/bootstrap-timepicker/js/bootstrap-timepicker.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#<%=AccountType.ClientID%>').change(function () {
                var end = this.value;
                viewSection(end);
            });

            viewSection($('#<%=AccountType.ClientID%>').val());
        });

        function viewSection(end) {
            switch (end) {
                case '0':
                case '1':
                case '2':
                    $('#noOrg').slideDown(200);
                    $('#Org1').slideUp(200);
                    $('#Org2').slideUp(200);
                    ///////////////
                    document.getElementById("<%=RequiredFieldValidator1.ClientID %>").enabled = true;
                    document.getElementById("<%=RequiredFieldValidator2.ClientID %>").enabled = true;
                    document.getElementById("<%=RequiredFieldValidator3.ClientID %>").enabled = true;
                    document.getElementById("<%=RequiredFieldValidator4.ClientID %>").enabled = false;
                    document.getElementById("<%=RequiredFieldValidator5.ClientID %>").enabled = false;
                    document.getElementById("<%=RequiredFieldValidator6.ClientID %>").enabled = false;
                    document.getElementById("<%=RequiredFieldValidator7.ClientID %>").enabled = false;
                    break;
                case '3':
                    $('#noOrg').slideUp(200);
                    $('#Org1').slideDown(200);
                    $('#Org2').slideDown(200);
                    ///////////////
                    document.getElementById("<%=RequiredFieldValidator1.ClientID %>").enabled = false;
                    document.getElementById("<%=RequiredFieldValidator2.ClientID %>").enabled = false;
                    document.getElementById("<%=RequiredFieldValidator3.ClientID %>").enabled = false;
                    document.getElementById("<%=RequiredFieldValidator4.ClientID %>").enabled = true;
                    document.getElementById("<%=RequiredFieldValidator5.ClientID %>").enabled = true;
                    document.getElementById("<%=RequiredFieldValidator6.ClientID %>").enabled = true;
                    document.getElementById("<%=RequiredFieldValidator7.ClientID %>").enabled = true;
                    break;
            }
        }
    </script>
</asp:Content>
