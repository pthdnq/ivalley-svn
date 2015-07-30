<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucJobOrderPrinting.ascx.cs" Inherits="TouchMediaGUI.usercontrols.ucJobOrderPrinting" %>
<div class="span12">
    <div class="form-horizontal">
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <div class="span6">
                <label class="control-label">أسم المطبعة</label>
                <asp:DropDownList runat="server" ID="drpPrintingHouseName"></asp:DropDownList>
            </div>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <label class="control-label">وصف العملية</label>
            <textarea rows="5" runat="server" id="txtPrintingDescription"></textarea>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <div class="span6">
                <label class="control-label">مقاس الطباعة</label>
                <asp:DropDownList runat="server" ID="drpPrintingSize"></asp:DropDownList>
            </div>
            <div class="span6">
                <asp:RadioButtonList runat="server" CssClass="checkSections" CellPadding="2" RepeatDirection="Horizontal" ID="RadioRRV">
                    <asp:ListItem>وجه واحد</asp:ListItem>
                    <asp:ListItem>وجهين</asp:ListItem>
                </asp:RadioButtonList>
            </div>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <div class="span6">
                <label class="control-label">مقاس الورق للطباعة</label>
                <asp:TextBox runat="server" ID="txtPrintingPaperSize"></asp:TextBox>
            </div>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <div class="span6">
                <label class="control-label">نوع الورق</label>
                <asp:DropDownList runat="server" ID="drpPrintingPaperType"></asp:DropDownList>
            </div>
            <div class="span6">
                <label class="control-label">كمية الورق</label>
                <asp:TextBox runat="server" ID="txtPrintingPaperQuantity"></asp:TextBox>
            </div>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix " style="margin-right: 0">
            <div class="span6">
                <label class="control-label">رصيد</label>
                <asp:Label runat="server" CssClass="label-def span4" Text="fadfdafadf" ID="txtTotalQuantity"></asp:Label>
            </div>
            <div class="span6">
                <label class="control-label">الباقي</label>
                <asp:Label runat="server" CssClass="label-def span4" Text="fadfdafadf" ID="lblOnHandQuantity"></asp:Label>
            </div>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <div class="span6">
                <label class="control-label">ملاحظات</label>
                <textarea rows="5" runat="server" id="txtNotes"></textarea>
            </div>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <div class="span6">
                <label class="control-label">أعمال ما بعد الطباعة</label>
                <asp:DropDownList runat="server" ID="drpAfterPrinting"></asp:DropDownList>
            </div>
            <div class="span6">
                <label class="control-label">المورد</label>
                <asp:TextBox runat="server" ID="txtAfterSupplier"></asp:TextBox>
            </div>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <div class="span6">
                <label class="control-label">الكمية</label>
                <asp:TextBox runat="server" ID="txtAfterPrintingQuantity"></asp:TextBox>
            </div>
        </div>
    </div>
</div>
