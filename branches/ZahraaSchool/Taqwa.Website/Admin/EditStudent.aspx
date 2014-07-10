﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" EnableEventValidation="false"  CodeBehind="EditStudent.aspx.cs" Inherits="Taqwa.Website.Admin.EditStudent" %>

<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
<%@ Register src="Controls/ucMonthlyReport.ascx" tagname="ucMonthlyReport" tagprefix="uc1" %>
<%@ Register src="Controls/ucAttendanceReport.ascx" tagname="ucAttendanceReport" tagprefix="uc2" %>
<%@ Register src="Controls/ucFees.ascx" tagname="ucFees" tagprefix="uc3" %>
<%@ Register src="Controls/ucInstallment.ascx" tagname="ucInstallment" tagprefix="uc4" %>
<%@ Register src="Controls/ucresults.ascx" tagname="ucresults" tagprefix="uc5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../js/jquery-ui-1.8.20.custom.min.js" type="text/javascript"></script>
    <link href="../css/jquery-ui-1.8.20.custom.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript">
        function PrintGridData() {
            var prtGrid = document.getElementById('<%=uiGridViewExported.ClientID %>');
            prtGrid.border = 0;
            var prtwin = window.open('', 'PrintGridViewData', 'left=100,top=100,width=1000,height=1000,toolbar=0,scrollbars=1,status=0,resizable=1');
            prtwin.document.write(prtGrid.outerHTML);
            prtwin.document.close();
            prtwin.focus();
            prtwin.print();
            prtwin.close();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="BackDiv">
<asp:LinkButton runat="server" ID="lnkBackToAdminCP" PostBackUrl="AdminCP.aspx" 
        Font-Underline="true" Text="عودة إلى لوحة التحكم &gt;&gt;"></asp:LinkButton>
</div>
<div class="clear"></div>
    
<div class="AdminMain" id="Main">
<asp:Panel ID="uiPanelCurrentStudents" runat="server" Visible= "true"  style="direction:rtl;padding-right:20px;">
<div><h3>الطلاب الحاليين</h3></div>

<div>
<div class="AdminLeft">
        <asp:Label ID="Label9" runat="server" CssClass="Label">الصف :</asp:Label>
        </div>
        <div class="AdminMiddle">
            &nbsp;<asp:DropDownList ID="uiDropDownListClasses" runat="server" 
                AutoPostBack="True" 
                onselectedindexchanged="uiDropDownListClasses_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
        <div class="AdminRight">
            &nbsp;</div>
        <div class="clear"></div>
        <div class="AdminLeft">
        <asp:Label ID="Label10" runat="server" CssClass="Label">الفصل :</asp:Label>
        </div>
        <div class="AdminMiddle">
            &nbsp;<asp:DropDownList ID="uiDropDownListClassRooms" runat="server">
            </asp:DropDownList>
        </div>
        <div class="AdminRight">
            &nbsp;</div>
        <div class="clear"></div>
        <div class="AdminLeft">
        <asp:Label ID="Label11" runat="server" CssClass="Label">بحث :</asp:Label>
        </div>
        <div class="AdminMiddle">
            &nbsp;<asp:TextBox ID="uiTextBoxSearchText" runat="server" Width="120px" placeholder="إسم الطالب"></asp:TextBox>
            &nbsp;<asp:TextBox ID="uiTextBoxFatherName" runat="server" Width="120px" placeholder="إسم الأب"></asp:TextBox>                       
        </div>
        <div class="AdminRight">
            &nbsp;<asp:Button ID="uiButtonSearch" runat="server" Text="بحث" 
                onclick="uiButtonSearch_Click" />
                &nbsp;
                <asp:Button ID="uiButtonExport" runat="server" Text="حفظ ملف Excel" 
                onclick="uiButtonExport_Click" />
                <input type="button" onclick="PrintGridData();return false;" value="طباعة">

    </div>
        <div class="clear"></div>
        <div class="AdminLeft"></div>
        <div class="AdminMiddle">
        <asp:LinkButton ID="uiLinkButtonAdd" runat="server" 
        onclick="uiLinkButtonAdd_Click" style="font-size:15px;">إضافة طالب جديد </asp:LinkButton>

        </div>
        <div class="AdminRight">

    
        </div>
        <div class="clear"></div>

        <div class="AdminLeft"></div>
        <div class="AdminMiddle">
            <asp:Label ID="uiLabelError" runat="server" Visible="false" ForeColor="Red" Font-Bold="true"></asp:Label>

        </div>
        <div class="AdminRight">

    
        </div>
        <div class="clear"></div>

    <asp:GridView ID="uiGridViewStudents" runat="server" AutoGenerateColumns="False" 
        CellPadding="1" CellSpacing="3" 
        onrowcommand="uiGridViewStudents_RowCommand" AllowPaging="false" 
        onpageindexchanging="uiGridViewStudents_PageIndexChanging" >
        <AlternatingRowStyle HorizontalAlign="Center" />
    <Columns>
    <asp:TemplateField HeaderText="م" >
    <ItemTemplate>
        <%# Container.DataItemIndex + 1 %>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:BoundField  HeaderText="الصف الدراسى " DataField="ClassName" />
    <asp:BoundField  HeaderText="الفصل " DataField="ClassRoomName" />
    
    <asp:BoundField  HeaderText="إسم الطالب " DataField="ArStudentName" />
    
    <asp:BoundField  HeaderText="إسم الأب " DataField="ArFatherName" />
    <asp:CheckBoxField HeaderText="نشط" DataField="IsActive" />
    <asp:BoundField  HeaderText="إسم المستخدم " DataField="UserName" />
    <asp:BoundField  HeaderText="كلمة المرور " DataField="SecretCode" />
    <asp:TemplateField HeaderText="إجراءات" ItemStyle-HorizontalAlign="Center">
    <ItemTemplate>
    
    <asp:LinkButton ID="uiLinkButtonEdit" runat="server" CommandArgument='<%# Eval("StudentID") %>' CommandName="EditStudent" ToolTip="تعديل"><img style="max-width:30px"  src="../images/icons/edit.gif" /></asp:LinkButton>
    <asp:LinkButton ID="LinkButton6" runat="server" CommandArgument='<%# Eval("StudentID") %>' CommandName="EditPassword" ToolTip="تعديل الرقم السرى"><img style="max-width:30px"  src="../images/icons/edit.gif" /></asp:LinkButton>
    <asp:LinkButton ID="uiLinkButtonMonthlyReport" runat="server" CommandArgument='<%# Eval("StudentID") %>' CommandName="EditMonthlyReport" ToolTip="تقرير السلوك الشهرى"><img style="max-width:30px"  src="../images/icons/reports.gif" /></asp:LinkButton>
    <asp:LinkButton ID="uiLinkButtonAttendanceReport" runat="server" CommandArgument='<%# Eval("StudentID") %>' CommandName="EditAttedanceReport" ToolTip="تقرير الغياب الشهرى"><img style="max-width:30px"  src="../images/icons/reports.gif" /></asp:LinkButton>
    <asp:LinkButton ID="uiLinkButtonFees" runat="server" CommandArgument='<%# Eval("StudentID") %>' CommandName="EditFees" ToolTip="المصروفات الدراسية"><img style="max-width:30px"  src="../images/icons/fees.gif" /></asp:LinkButton>
    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("StudentID") %>' CommandName="EditInstallments" ToolTip="أقساط المصروفات الدراسية"><img style="max-width:30px"  src="../images/icons/installment.gif" /></asp:LinkButton>
    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("StudentID") %>' CommandName="EditResultsFHMT" ToolTip="نتائج نصف الفصل الدراسى الأول "><img style="max-width:30px"  src="../images/icons/natiga.gif" /></asp:LinkButton>
    <asp:LinkButton ID="LinkButton3" runat="server" CommandArgument='<%# Eval("StudentID") %>' CommandName="EditResultsFHF" ToolTip="نتائج نصف العام "><img style="max-width:30px"  src="../images/icons/natiga.gif" /></asp:LinkButton>
    <asp:LinkButton ID="LinkButton4" runat="server" CommandArgument='<%# Eval("StudentID") %>' CommandName="EditResultsSHMT" ToolTip="نتائج نصف الفصل الدراسى الثانى "><img style="max-width:30px"  src="../images/icons/natiga.gif" /></asp:LinkButton>
    <asp:LinkButton ID="LinkButton5" runat="server" CommandArgument='<%# Eval("StudentID") %>' CommandName="EditResultsSHF" ToolTip="نتائج نهاية العام "><img style="max-width:30px"  src="../images/icons/natiga.gif" /></asp:LinkButton>
    <asp:LinkButton ID="uiLinkButtonDelete" runat="server" CommandArgument='<%# Eval("StudentID") %>' CommandName="DeleteStudent"  OnClientClick="return confirm('Are you want to delete this record?');" ToolTip="حذف"><img style="max-width:30px"  src="../images/icons/delete.gif" /></asp:LinkButton>

    </ItemTemplate>
    </asp:TemplateField>
    </Columns>
        <RowStyle HorizontalAlign="Center" />
        <EmptyDataTemplate>
    عفواً ، لا توجد بيانات .
    </EmptyDataTemplate>
    </asp:GridView>
    <div style="display:none">
      <asp:GridView ID="uiGridViewExported" runat="server" AutoGenerateColumns="False" 
        CellPadding="5" CellSpacing="5" 
        onrowcommand="uiGridViewStudents_RowCommand" AllowPaging="false" 
        onpageindexchanging="uiGridViewStudents_PageIndexChanging" 
        HorizontalAlign="Center" >
        <AlternatingRowStyle HorizontalAlign="Center" />
    <Columns>
   
   <asp:BoundField  HeaderText="كلمة المرور " DataField="SecretCode" HeaderStyle-HorizontalAlign="Center"/>
   <asp:BoundField  HeaderText="إسم المستخدم " DataField="UserName" HeaderStyle-HorizontalAlign="Center"/>
   <asp:CheckBoxField HeaderText="نشط" DataField="IsActive" HeaderStyle-HorizontalAlign="Center"/>
   <asp:BoundField  HeaderText="الموبايل " DataField="Mobile" HeaderStyle-HorizontalAlign="Center"/>
    <asp:BoundField  HeaderText="التليفون " DataField="Tele" HeaderStyle-HorizontalAlign="Center"/>
    <asp:BoundField  HeaderText="إسم الأب " DataField="ArFatherName" HeaderStyle-HorizontalAlign="Center"/>
   
    <asp:BoundField  HeaderText="إسم الطالب " DataField="ArStudentName" HeaderStyle-HorizontalAlign="Center"/>
    
   
     
     <asp:BoundField  HeaderText="الفصل " DataField="ClassRoomName" HeaderStyle-HorizontalAlign="Center"/>
     <asp:BoundField  HeaderText="الصف الدراسى " DataField="ClassName" HeaderStyle-HorizontalAlign="Center"/>
     <asp:TemplateField HeaderText="م" HeaderStyle-HorizontalAlign="Center">
    <ItemTemplate>
        <%# Container.DataItemIndex + 1 %>
    </ItemTemplate>
    </asp:TemplateField>
    </Columns>
          <HeaderStyle HorizontalAlign="Center" />
        <RowStyle HorizontalAlign="Center" />
        <EmptyDataTemplate>
    عفواً ، لا توجد بيانات .
    </EmptyDataTemplate>
    </asp:GridView>
    </div>
    <div class="clear"></div>
    </div>
    </asp:Panel>

    <asp:Panel ID="uiPanelCurrent" runat="server"  style="direction:rtl;padding-right:20px;">
    <div><h3>تعديل بيانات الطالب</h3></div>
        <div class="AdminLeft">
        </div>
        <div class="AdminMiddle">
            <asp:Label ID="uiLabelMessage" runat="server"></asp:Label>
        </div>
        <div class="AdminRight">
        </div>
        <div class="clear"></div>
        <div class="AdminLeft" style="width: 195px">
        <asp:Label ID="Label15" runat="server" CssClass="Label">الصف :</asp:Label>
        </div>
        <div class="AdminMiddle">
            &nbsp;<asp:DropDownList ID="uiDropDownListStudentClass" runat="server" 
                AutoPostBack="True" 
                onselectedindexchanged="uiDropDownListStudentClass_SelectedIndexChanged" 
                Width="200px">
            </asp:DropDownList>
        </div>
        <div class="AdminRight">
            &nbsp;</div>
        <div class="clear"></div>
        <div class="AdminLeft" style="width: 195px">
        <asp:Label ID="Label29" runat="server" CssClass="Label">الفصل :</asp:Label>
        </div>
        <div class="AdminMiddle">
            &nbsp;<asp:DropDownList ID="uiDropDownListStudentClassRoom" runat="server" 
                Width="200px">
            </asp:DropDownList>
        </div>
        <div class="AdminRight">
            &nbsp;</div>
        <div class="clear"></div>
        <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="uiLabelEnglishTitle" runat="server" CssClass="Label" 
                Text="إسم الطالب بالإنجليزية :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:TextBox ID="uiTextBoxEnName" runat="server" ValidationGroup="UpdatePage" 
                Width="400px"></asp:TextBox>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="uiTextBoxEnName" ErrorMessage="*" 
                ValidationGroup="UpdatePage"></asp:RequiredFieldValidator>
        </div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="uiLabelArabicTitle" runat="server" CssClass="Label" 
                Text="إسم الطالب بالعربية :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:TextBox ID="uiTextBoxArName" runat="server" ValidationGroup="UpdatePage" 
                Width="400px"></asp:TextBox>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="uiTextBoxArName" ErrorMessage="*" 
                ValidationGroup="UpdatePage"></asp:RequiredFieldValidator>
        </div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label1" runat="server" CssClass="Label" 
                Text="إسم الأب بالإنجليزية :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:TextBox ID="uiTextBoxENFatherName" runat="server" ValidationGroup="UpdatePage" 
                Width="400px"></asp:TextBox>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label2" runat="server" CssClass="Label" 
                Text="إسم الأب بالعربية :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:TextBox ID="uiTextBoxARFatherName" runat="server" ValidationGroup="UpdatePage" 
                Width="400px"></asp:TextBox>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label3" runat="server" CssClass="Label" 
                Text="الرقم القومى للأب :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:TextBox ID="uiTextBoxNationalNo" runat="server" ValidationGroup="UpdatePage" 
                Width="400px"></asp:TextBox>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator4" 
                runat="server" ErrorMessage="أرقام فقط"
                    ValidationGroup="UpdatePage" ValidationExpression="^[-+]?(\d)+$" ControlToValidate="uiTextBoxNationalNo"
                    ForeColor="#ff0000" Display="Dynamic"></asp:RegularExpressionValidator>
            </div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label4" runat="server" CssClass="Label" 
                Text="وظيفة الأب :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:TextBox ID="uiTextBoxJobDesc" runat="server" ValidationGroup="UpdatePage" 
                Width="400px" Height="60px" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label5" runat="server" CssClass="Label" 
                Text="البريد الإلكترونى :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:TextBox ID="uiTextBoxEmail" runat="server" ValidationGroup="UpdatePage" 
                Width="400px"></asp:TextBox>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator6" 
                runat="server" ControlToValidate="uiTextBoxEmail" Display="Dynamic" 
                ErrorMessage="أدخل البريد الإلكترونى بشكل صحيح" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                ValidationGroup="UpdatePage"></asp:RegularExpressionValidator>
        </div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label6" runat="server" CssClass="Label" 
                Text="رقم التليفون :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:TextBox ID="uiTextBoxTele" runat="server" ValidationGroup="UpdatePage" 
                Width="400px"></asp:TextBox>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator5" 
                runat="server" ControlToValidate="uiTextBoxTele" Display="Dynamic" 
                ErrorMessage="أرقام فقط" ForeColor="#ff0000" 
                ValidationExpression="^[-+]?(\d)+$" ValidationGroup="UpdatePage"></asp:RegularExpressionValidator>
        </div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label12" runat="server" CssClass="Label" 
                Text="رقم الموبايل :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:TextBox ID="uiTextBoxMobile" runat="server" ValidationGroup="UpdatePage" 
                Width="400px"></asp:TextBox>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                runat="server" ControlToValidate="uiTextBoxMobile" Display="Dynamic" 
                ErrorMessage="أرقام فقط" ForeColor="#ff0000" 
                ValidationExpression="^[-+]?(\d)+$" ValidationGroup="UpdatePage"></asp:RegularExpressionValidator>
        </div>
        <div class="clear"></div>

        <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label13" runat="server" CssClass="Label" 
                Text="نشط :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:CheckBox ID="uiCheckBoxIsActive" runat="server" Text=" " 
                ValidationGroup="UpdatePage" />
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label7" runat="server" CssClass="Label" 
                Text="عنوان الطالب :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:TextBox ID="uiTextBoxAddress" runat="server" ValidationGroup="UpdatePage" 
                Width="400px" Height="84px" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

        
         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label14" runat="server" CssClass="Label" 
                Text="إسم المستخدم :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:TextBox ID="uiTextBoxUsername" runat="server" ValidationGroup="UpdatePage" 
                Width="400px" ></asp:TextBox>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>


         <div class="AdminLeft" style="width: 195px">

        </div>
        <div class="AdminMiddle">
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>         

        <div class="AdminLeft" style="width: 195px">
        &nbsp;
        </div>
        <div class="AdminMiddle">
            <asp:Button ID="uiButtonUpdate" runat="server" onclick="uiButtonUpdate_Click" 
                Text="إضافة / تعديل" ValidationGroup="UpdatePage" />
            &nbsp;<asp:Button ID="uiButtonCancel" runat="server" onclick="uiButtonCancel_Click" 
                Text="إلغاء" />
        </div>
        <div class="AdminRight">
        </div>
        <div class="clear"></div>
        </asp:Panel>

        <asp:Panel ID="uiPanelPrint" runat="server" >
        <script type="text/javascript">
            function PrintAll() {
                document.getElementById('<%= uiButtonPrint.ClientID %>').style.display = "none";
                document.getElementById('<%= uiButtonCancelPrint.ClientID %>').style.display = "none";
                window.print();
                document.getElementById('<%= uiButtonPrint.ClientID %>').style.display = "block";
                document.getElementById('<%= uiButtonCancelPrint.ClientID %>').style.display = "block";
            }
    </script>
    <div style="direction:rtl; padding-right:20px;"><h3>بيانات الطالب</h3></div>
        <div class="AdminLeft">
        </div>
        <div class="AdminMiddle">
            <asp:Label ID="Label8" runat="server"></asp:Label>
        </div>
        <div class="AdminRight">
        </div>
        <div class="clear"></div>

        <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label16" runat="server" CssClass="Label" 
                Text="إسم الطالب بالإنجليزية :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:Label ID="uiLabelEnName" runat="server"></asp:Label>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label17" runat="server" CssClass="Label" 
                Text="إسم الطالب بالعربية :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:Label ID="uiLabelArName" runat="server"></asp:Label>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label18" runat="server" CssClass="Label" 
                Text="إسم الأب بالإنجليزية :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:Label ID="uiLabelEnFatherName" runat="server"></asp:Label>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label19" runat="server" CssClass="Label" 
                Text="إسم الأب بالعربية :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:Label ID="uiLabelArFatherName" runat="server"></asp:Label>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label20" runat="server" CssClass="Label" 
                Text="الرقم القومى للأب :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:Label ID="uiLabelNationalNumber" runat="server"></asp:Label>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label21" runat="server" CssClass="Label" 
                Text="وظيفة الأب :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:Label ID="uiLabelJobDesc" runat="server"></asp:Label>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label22" runat="server" CssClass="Label" 
                Text="البريد الإلكترونى :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:Label ID="uiLabelMail" runat="server"></asp:Label>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label23" runat="server" CssClass="Label" 
                Text="رقم التليفون :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:Label ID="uiLabelTele" runat="server"></asp:Label>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label24" runat="server" CssClass="Label" 
                Text="رقم الموبايل :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:Label ID="uiLabelMobile" runat="server"></asp:Label>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

        <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label25" runat="server" CssClass="Label" 
                Text="نشط :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:CheckBox ID="uiCheckBoxact" runat="server" Text=" " 
                ValidationGroup="UpdatePage" onClick="javascript: return false;"/>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label26" runat="server" CssClass="Label" 
                Text="عنوان الطالب :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:Label ID="uiLabelAddress" runat="server"></asp:Label>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>

        
         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label27" runat="server" CssClass="Label" 
                Text="إسم المستخدم :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:Label ID="uiLabelUsername" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>


         <div class="AdminLeft" style="width: 195px">
            <asp:Label ID="Label28" runat="server" CssClass="Label" 
                Text="الرقم السرى :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:Label ID="uiLabelSecertCode" runat="server"></asp:Label>
        </div>
        <div class="AdminRight" style="width: 30%">
            &nbsp;</div>
        <div class="clear"></div>         

        <div class="AdminLeft" style="width: 195px">
        &nbsp;
        </div>
        <div class="AdminMiddle">
            <asp:Button ID="uiButtonPrint" runat="server" 
                Text="طباعة" OnClientClick="PrintAll();" />
            &nbsp;<asp:Button ID="uiButtonCancelPrint" runat="server" onclick="uiButtonCancel_Click" 
                Text="إلغاء" />
        </div>
        <div class="AdminRight">
        </div>
        <div class="clear"></div>
        </asp:Panel>
    </div>
   
    
        <asp:Panel ID="uiPanelMonthlyReport" runat="server" Visible="false">
        <div class="dialog-modal" id="monthlyreportdiag" title="تعديل التقرير الشهرى للطالب">            
            <uc1:ucMonthlyReport ID="ucMonthlyReport1" runat="server" />
        </div>

        </asp:Panel>


        <asp:Panel ID="uiPanelAttendanceReport" runat='server' Visible="false" >
        
        <div class="dialog-modal" id="AttendanceReportdiag" title="تعديل أيام الغياب الخاصة بالطالب ">                        
            <uc2:ucAttendanceReport ID="ucAttendanceReport1" runat="server" />
        </div>
        </asp:Panel>


        <asp:Panel ID="uiPanelFees" runat='server' Visible="false"  >
        
        <div class="dialog-modal" id="Feesdiag" title="تعديل مصروفات الطالب ">                        
            <uc3:ucFees ID="ucFees1" runat="server" />
        </div>
        </asp:Panel>

         <asp:Panel ID="uiPanelInstallments" runat='server' Visible="false"  >
        
        <div class="dialog-modal" id="installmentdiag" title="تعديل أقساط المصروفات الدراسية للطالب ">                        
            <uc4:ucInstallment ID="ucInstallment1" runat="server" />            
        </div>
        </asp:Panel>

        <asp:Panel ID="uiPanelResults" runat='server' Visible="false"  >
        
        <div class="dialog-modal" id="resultsdiag" title="تعديل النتائج ">                                    
            <uc5:ucresults ID="ucresults1" runat="server" />
        </div>
        </asp:Panel>

        <asp:Panel ID="uiPanelPassword" runat="server" Visible="false">
        <div class="dialog-modal" id="passdiag" title="تعديل الرقم السرى">            
             <div class="AdminLeft" style="width: 200px">
            <asp:Label ID="Label30" runat="server" CssClass="Label" 
                Text="الرقم السرى الجديد  :"></asp:Label>
        </div>
        <div class="AdminMiddle">
            <asp:TextBox ID="uiTextBoxPassword" runat="server" 
                Width="200px" ></asp:TextBox>
        </div>
        <div class="AdminRight">
           
            &nbsp;</div>
        <div class="clear"></div>
       
        <div class="AdminLeft" style="width: 250px">
        </div>
        <div class="AdminRight">
            &nbsp;<asp:Label ID="uiLabelPassError" Visible="false" runat="server" Text="حدث خطأ. تأكد من كتابة كلمة المرور" ForeColor="Red"></asp:Label></div>
        <div class="clear"></div>
       <div class="AdminLeft" style="width: 150px;">
        &nbsp;
        </div>
        <div class="AdminMiddle">
            <asp:Button ID="uiButtonsavePassword" runat="server" onclick="uiButtonsavePassword_Click" 
                Text=" تعديل" />            
        </div>
        <div class="AdminRight">
            &nbsp;
        </div>
        <div class="clear"></div>
        </div>

        </asp:Panel>
    

     <script type="text/javascript">

        // Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () {
         
             $('.ui-widget-overlay').remove();

             $("#monthlyreportdiag").dialog({             
                 modal: true,
                 width: 650,
                 open: function (type, data) { $(this).parent().appendTo("#Main"); }
                 /*close: function (event, ui) {
                     //this.html('');
                     $(this).dialog('close');
                     $('.ui-widget-overlay').remove();
                 }*/
             });

             $("#AttendanceReportdiag").dialog({
                 modal: true,
                 width: 650,
                 open: function (type, data) { $(this).parent().appendTo("#Main"); }
                /* close: function (event, ui) {
                     //this.html('');
                      $(this).dialog('close');
                     $('.ui-widget-overlay').remove();
                 }*/
             });

              $("#Feesdiag").dialog({
                 modal: true,
                 width: 650,
                 open: function (type, data) { $(this).parent().appendTo("#Main"); }
                /* close: function (event, ui) {
                     //this.html('');
                      $(this).dialog('close');
                     $('.ui-widget-overlay').remove();
                 }*/
             });

              $("#installmentdiag").dialog({
                 modal: true,
                 width: 650,
                 open: function (type, data) { $(this).parent().appendTo("#Main"); }
                /* close: function (event, ui) {
                     //this.html('');
                      $(this).dialog('close');
                     $('.ui-widget-overlay').remove();
                 }*/
             });

             $("#resultsdiag").dialog({
                 modal: true,
                 width: 650,
                 open: function (type, data) { $(this).parent().appendTo("#Main"); }
                 /* close: function (event, ui) {
                 //this.html('');
                 $(this).dialog('close');
                 $('.ui-widget-overlay').remove();
                 }*/
             });

             $("#passdiag").dialog({
                 modal: true,
                 width: 650,
                 open: function (type, data) { $(this).parent().appendTo("#Main"); }
                 /* close: function (event, ui) {
                 //this.html('');
                 $(this).dialog('close');
                 $('.ui-widget-overlay').remove();
                 }*/
             });
         
        // });

    </script>

    <script type="text/javascript">

      /*  $(document).ready(function () {
            $(".dialog-modal").dialog({
                autoOpen: false,
                modal: true,
                open: function (type, data) { $(this).parent().appendTo("form"); }
            });
        });*/
    </script>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
    <ProgressTemplate>
    <div style="min-height: 100%; min-width: 100%; text-align: center; vertical-align: bottom;
                        display: table-cell; color: #fff; font-size: 16px; font-weight: bold; z-index: 9999999;
                        background: url(images/loading.GIF) no-repeat center center rgba(256,256,256,0.65);
                        position: absolute; top: 0; left: 0;">
         <div style="margin: auto; width: 200px; height: 120px; position: absolute; left: 0;
                            right: 0; top: 0; bottom: 0;font-size:30px; font-weight:bold;color:#006600">
                            جارى التحميل
                        </div>
    </ProgressTemplate>
    </asp:UpdateProgress>
</asp:Content>
