<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterAr.Master" AutoEventWireup="true" CodeBehind="changepassword.aspx.cs" Inherits="ComboPortal.ar.changepassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="span12 no-margin rounded" >
        <h3>تغيير كلمة المرور</h3>
    
       <asp:Panel ID="uiPanelReset" runat="server" CssClass="span12 no-margin no-padding">
           <asp:Panel ID="uiPanelError" runat="server" CssClass="span12 alert alert-danger no-margin">
جواب الأمان غير متطابق مع المسجل لدينا. من فضلك أعد المحاولة        </asp:Panel>
           <div class="space5"></div>
             <div class="span12 clearfix no-margin no-padding">
                <div class="span2">كلمة المرور الجديدة : </div>
                <div class="span5">
                    <asp:TextBox ID="uiTextBoxPass" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="uiTextBoxPass" runat="server" ErrorMessage="*" Font-Bold="true" ForeColor="Red" ValidationGroup="resetpass" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix no-margin no-padding">
                <div class="span2">تأكيد كلمة المرور : </div>
                <div class="span5">
                    <asp:TextBox ID="uiTextBoxcpass" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="uiTextBoxcpass" ControlToCompare="uiTextBoxPass" ErrorMessage="كلمة المرور غير متطابقة" Font-Bold="true" ForeColor="Red" ValidationGroup="resetpass" Display="Dynamic"></asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="uiTextBoxcpass" runat="server" ErrorMessage="*" Font-Bold="true" ForeColor="Red" ValidationGroup="resetpass" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
           <div class="span12 clearfix no-margin no-padding">
                <div class="span2">جواب الأمان : </div>
                <div class="span5">
                    <asp:TextBox ID="uiTextBoxSecurityWord" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="uiTextBoxSecurityWord" runat="server" ErrorMessage="*" Font-Bold="true" ForeColor="Red" ValidationGroup="resetpass" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix no-margin no-padding">
                <div class="span2"></div>
                <div class="span2">
                    <asp:Button ID="uiButtonSave" runat="server" Text="حفظ" ValidationGroup="resetpass" OnClick="uiButtonSave_Click" CssClass="btn btn-primary" /></div>
            </div>
        </asp:Panel>
        

         <asp:Panel ID="uiPanelsuccess" runat="server" CssClass="span12 alert alert-success no-margin">
            تم تغيير كلمة المرور بنجاح
        </asp:Panel>
         
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
