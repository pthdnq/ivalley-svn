<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterEn.Master" AutoEventWireup="true" CodeBehind="RequestAccountVerification.aspx.cs" Inherits="ComboPortal.RequestAccountVerification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="ContentPlaceHolderScripts">
    <script type="text/javascript">
        $(document).ready(function () {
            $('#AccountType').change(function () {
                var end = this.value;
                viewSection(end);
            });

            viewSection($('#AccountType').val());
        });

        function viewSection(end)
        {
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="uiPanelAdd"> 

    
    <div class="span12 clearfix no-margin">
        <div class="span2">
            Account Type 
        </div>
        <div class="span6">
            <select id="AccountType" runat="server" >
                <option value="0">Select type...</option>
                <option value="1">Personal account</option>
                <option value="2">Organization account</option>
                <option value="3">Shop account</option>
            </select>
        </div>
    </div>
    <div class="span12 clearfix no-margin" id="MainInfo">
        <div class="span5">
            <div id="noOrg">
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0" >
                <div class="span3">Name</div>
                <div class="span6">
                    <asp:TextBox ID="uiTextBoxName" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxName"></asp:RequiredFieldValidator>
                </div>
            </div>             
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span3">Passport No.</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxPassNo" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxPassNo"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span3">Date of birth</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxDOB" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxDOB"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span3">Gender</div>
                <div class="span6">
                    <asp:DropDownList ID="uiDropDownListGender" runat="server"></asp:DropDownList></div>
                <div class="span1"></div>
            </div>

            </div>

            <div id="Org1">
                <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0" >
                <div class="span3">Name 
                    
                </div>
                <div class="span8">
                    <asp:TextBox ID="uiTextBoxOrgName" runat="server"></asp:TextBox>
                    <br /><sub>
                      Company / Factory / Team / Organization / Association / Governmental organizaton / Charity 
                    </sub>
                </div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxOrgName"></asp:RequiredFieldValidator>
                </div>
                </div>
                
            </div>

            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span3">Country</div>
                <div class="span6"><asp:DropDownList ID="uiDropDownListCountry" runat="server"></asp:DropDownList></div>
                <div class="span1"></div>
            </div>

            <div id="Org2">
                <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0" >
                <div class="span3">City 
                    
                </div>
                <div class="span8">
                    <asp:TextBox ID="uiTextBoxCity" runat="server"></asp:TextBox>                    
                </div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxCity"></asp:RequiredFieldValidator>
                </div>
                </div>
                <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0" >
                <div class="span3">Address Info 
                    
                </div>
                <div class="span8">
                    <asp:TextBox ID="uiTextBoxAddressInfo" runat="server"></asp:TextBox>                    
                </div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxAddressInfo"></asp:RequiredFieldValidator>
                </div>
                </div>

                <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0" >
                <div class="span3">Company field 
                    
                </div>
                <div class="span8">
                    <asp:TextBox ID="uiTextBoxCompanyField" runat="server"></asp:TextBox>                    
                </div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxCompanyField"></asp:RequiredFieldValidator>
                </div>
                </div>
            </div>

            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span3">Mobile No.</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxMobileNo" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator8" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxMobileNo"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span3">Mobile No.(2)</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxMobileNo2" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator9" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxMobileNo2"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span3">Account name</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxAccountName" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator10" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxAccountName"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span3">Security word</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxSecurityWord" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator11" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxSecurityWord"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span3">Email</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxEmail" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator12" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxEmail"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span3">Password</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxPassword" TextMode="Password" runat="server"></asp:TextBox></div>
                <div class="span1">
                    <asp:RequiredFieldValidator Font-Bold="true" ForeColor="Red"  ID="RequiredFieldValidator13" runat="server" ErrorMessage="*" ValidationGroup="add" ControlToValidate="uiTextBoxPassword"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
        <div class="span7">
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span3">Passport copy</div>
                <div class="span9">
                     <iframe src="uiUpload.html?key=passport" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                </div>
                
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span3">Personal picture</div>
                <div class="span9">
                     <iframe src="uiUpload.html?key=pic" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                </div>
                
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">

                <p>
                   Yes I am the owner of this account and all personal data, account data and Passport/ID holder and profile picture is correct. 
                    not plagiarize any personality and be legally responsible . And I'm culpable in any place in the world and in any State. 
                    I promise to keep my account information for this application and Combo of any legal responsibility with raised from personal information and Passport/ID photo and profile as well as what is published from my account and agree to the result of the authentication request,
                     approval or rejection, as well as providing for all who working inside Combo in all departments and the supporting company and marketing firms and ISP for combo</p>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span2"><asp:LinkButton ID="uiLinkButtonSave" runat="server" CssClass="btn btn-primary" ValidationGroup="add" OnClick="uiLinkButtonSave_Click">Save</asp:LinkButton></div>
                <div class="span6">
                    </div>
                <div class="span2"></div>
            </div>
        </div>
    </div>

        </asp:Panel>
    <asp:Panel runat="server" ID="uiPanelResult"> 

    </asp:Panel>
</asp:Content>
