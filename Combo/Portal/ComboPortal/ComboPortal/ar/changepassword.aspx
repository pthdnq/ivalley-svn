<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterAr.Master" AutoEventWireup="true" CodeBehind="changepassword.aspx.cs" Inherits="ComboPortal.ar.changepassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <asp:Panel ID="uiPanelReset" runat="server" CssClass="span12">
             <div class="span12 clearfix">
                <div class="span2">كلمة المرور الجديدة : </div>
                <div class="span5">
                    <asp:TextBox ID="uiTextBoxPass" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="uiTextBoxPass" runat="server" ErrorMessage="*" Font-Bold="true" ForeColor="Red" ValidationGroup="resetpass"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="span12 clearfix no-margin">
                <div class="span2">تأكيد كلمة المرور : </div>
                <div class="span5">
                    <asp:TextBox ID="uiTextBoxcpass" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="uiTextBoxcpass" ControlToCompare="uiTextBoxPass" ErrorMessage="*" Font-Bold="true" ForeColor="Red" ValidationGroup="resetpass"></asp:CompareValidator>
                </div>
            </div>
            <div class="span12 clearfix no-margin">
                <div class="span2"></div>
                <div class="span2">
                    <asp:Button ID="uiButtonSave" runat="server" Text="حفظ" ValidationGroup="resetpass" OnClick="uiButtonSave_Click" CssClass="btn btn-primary" /></div>
            </div>
        </asp:Panel>
        

         <asp:Panel ID="uiPanelsuccess" runat="server" CssClass="span12 alert alert-success no-margin">
            تم تغيير كلمة المرور بنجاح
        </asp:Panel>
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
