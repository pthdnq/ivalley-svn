<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterEn.Master" AutoEventWireup="true" CodeBehind="RequestAccountVerification.aspx.cs" Inherits="ComboPortal.RequestAccountVerification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="span12 clearfix no-margin">
        <div class="span2">
            Account Type 
        </div>
        <div class="span6">
            <select id="AccountType">
                <option value="0">Select type...</option>
                <option value="1">Personal account</option>
                <option value="2">Organization account</option>
                <option value="3">Shop account</option>
            </select>
        </div>
    </div>
    <div class="span12 clearfix no-margin" id="MainInfo">
        <div class="span6">
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span2">Name</div>
                <div class="span6">
                    <asp:TextBox ID="uiTextBoxName" runat="server"></asp:TextBox></div>
                <div class="span2"></div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span2">Passport No.</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxPassNo" runat="server"></asp:TextBox></div>
                <div class="span2"></div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span2">Date of birth</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxDOB" runat="server"></asp:TextBox></div>
                <div class="span2"></div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span2">Gender</div>
                <div class="span6">
                    <asp:DropDownList ID="uiDropDownListGender" runat="server"></asp:DropDownList></div>
                <div class="span2"></div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span2">Country</div>
                <div class="span6"><asp:DropDownList ID="uiDropDownListCountry" runat="server"></asp:DropDownList></div>
                <div class="span2"></div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span2">Mobile No.</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxMobileNo" runat="server"></asp:TextBox></div>
                <div class="span2"></div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span2">Mobile No.(2)</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxMobileNo2" runat="server"></asp:TextBox></div>
                <div class="span2"></div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span2">Account name</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxAccountName" runat="server"></asp:TextBox></div>
                <div class="span2"></div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span2">Security word</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxSecurityWord" runat="server"></asp:TextBox></div>
                <div class="span2"></div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span2">Email</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxEmail" runat="server"></asp:TextBox></div>
                <div class="span2"></div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span2">Password</div>
                <div class="span6"><asp:TextBox ID="uiTextBoxPassword" TextMode="Password" runat="server"></asp:TextBox></div>
                <div class="span2"></div>
            </div>
        </div>
        <div class="span6">
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span2">Passport copy</div>
                <div class="span8">
                     <iframe src="uiUpload.html" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                </div>
                <div class="span2"></div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                <div class="span2">Personal picture</div>
                <div class="span8">
                     <iframe src="uiUpload.html" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                </div>
                <div class="span2"></div>
            </div>
            <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">

                <p>
                    asdbajsdajskhdkahdjhasdhasdkdh
                </p>
            </div>
        </div>
    </div>
</asp:Content>
