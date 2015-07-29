<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucJobOrderProduction.ascx.cs" Inherits="TouchMediaGUI.usercontrols.ucJobOrderProduction" %>
<div class="span12">
    <div class="form-horizontal">
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <div class="span6">
                <label class="control-label">نوع المنتج</label>
                <asp:DropDownList runat="server" type="text" ID="drpProductionItemList" />
            </div>
            <div class="span6">
                <label class="control-label">المقاس</label>
                <asp:TextBox runat="server" ID="txtProductionSize"></asp:TextBox>
            </div>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">

            <label class="control-label">الخامات</label>
            <asp:CheckBoxList CssClass="checkSections" runat="server" type="text" CellPadding="2" ID="chkProductionMaterials" RepeatDirection="Horizontal">
                <asp:ListItem Text="Item1"></asp:ListItem>
                <asp:ListItem Text="Item1"></asp:ListItem>
                <asp:ListItem Text="Item1"></asp:ListItem>
                <asp:ListItem Text="Item1"></asp:ListItem>
            </asp:CheckBoxList>


        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <div class="span6">
                <label class="control-label">تاريخ الأستلام</label>
                <div class="input-append date date-picker" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                    <asp:TextBox runat="server" CssClass="m-ctrl-medium date-picker" Font-Size="16" type="text" ID="txtJobOrderDate" Style="direction: ltr" />
                    <span class="add-on">
                        <i class="icon-calendar"></i>
                    </span>
                </div>
            </div>
            <div class="span6">
                <label class="control-label">المورد</label>
                <asp:DropDownList runat="server" ID="drpProductionSupplier"></asp:DropDownList>
            </div>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <div class="span6">
                <label class="control-label">يتم التوصيل الي</label>
                <asp:DropDownList runat="server" ID="drpDeliveryTo">
                    <asp:ListItem>المخزن</asp:ListItem>
                    <asp:ListItem>العميل</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="span6">
                <div class="control-label">عنوان العميل</div>
                <asp:TextBox runat="server" ID="txtDeliveryToClientAddress"></asp:TextBox>
            </div>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <div class="span6">
                <label class="control-label">سيتم إزالته</label>
                <asp:CheckBox runat="server" ID="ChkIsRemoval" />
            </div>
            <div class="span6">
                <label class="control-label">التاريخ </label>
                <div class="input-append date date-picker" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                    <asp:TextBox runat="server" CssClass="m-ctrl-medium date-picker" Font-Size="16" type="text" ID="TextBox1" Style="direction: ltr" />
                    <span class="add-on">
                        <i class="icon-calendar"></i>
                    </span>
                </div>
            </div>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <div class="span6">
                <label class="control-label">حالة الأنتاج</label>
                <asp:DropDownList runat="server" ID="drpProductionStatus"></asp:DropDownList>
            </div>
            <div class="span6">
                <label class="control-label">حالة التثبيت</label>
                <asp:DropDownList runat="server" ID="drpProductionInstallStatus"></asp:DropDownList>
            </div>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <label class="control-label">ملاحظات</label>
            <textarea runat="server" id="txtProductionNotes"></textarea>
        </div>
    </div>
</div>
