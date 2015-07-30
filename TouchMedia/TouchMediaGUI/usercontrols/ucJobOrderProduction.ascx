<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucJobOrderProduction.ascx.cs" Inherits="TouchMediaGUI.usercontrols.ucJobOrderProduction" %>

<script type="text/javascript">
    function showRemovableDateDiv() {
        if ($('#checkBoxProductionIsRemoved')[0].checked) {
            $('#divRemovableDate').show();
        }
        else {
            $('#divRemovableDate').hide();
        }
    }

    function showClientAddressDiv() {
        if ($("select[name='drpDeliveryTo'] option:selected").index() = "1") {
            $('#divClientAddress').hide();
        }
        else {
            $('#divClientAddress').show();
        }
    }
</script>
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
                <select id="drpDeliveryTo" runat="server" onselect="showClientAddressDiv();">
                    <option value="1">المخزن</option>
                    <option value="2">العميل</option>
                </select>
<%--                <asp:DropDownList ClientIDMode="Static" runat="server" ID="drpDeliveryTof">
                    <asp:ListItem>المخزن</asp:ListItem>
                    <asp:ListItem>العميل</asp:ListItem>
                </asp:DropDownList>--%>
            </div>
            <div id="divClientAddress" style="display:none" class="span6">
                <div class="control-label">عنوان العميل</div>
                <asp:TextBox runat="server" ID="txtDeliveryToClientAddress"></asp:TextBox>
            </div>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <div class="span6">
                <label class="control-label">حالة التثبيت</label>
                <asp:DropDownList runat="server" ID="drpProductionInstallStatus"></asp:DropDownList>
            </div>
            <div class="span6">
                <label class="control-label">تاريخ التثبيت </label>
                <div class="input-append date date-picker" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                    <asp:TextBox runat="server" CssClass="m-ctrl-medium date-picker" Font-Size="16" type="text" ID="txtInstallationDate" Style="direction: ltr" />
                    <span class="add-on">
                        <i class="icon-calendar"></i>
                    </span>
                </div>
            </div>
        </div>
        <div class="block-margin-bottom-5 span12 clearfix" style="margin-right: 0">
            <div class="span6">
                <label class="control-label">سيتم إزالته</label>
                <asp:CheckBox ID="checkBoxProductionIsRemoved" onclick="showRemovableDateDiv();" ClientIDMode="Static" runat="server" />
            </div>
            <div id="divRemovableDate" class="span6" style="display: none">
                <label class="control-label">تاريخ الازالة </label>
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
                <label class="control-label">ملاحظات</label>
                <textarea runat="server" id="txtProductionNotes"></textarea>
            </div>
        </div>
    </div>
</div>

