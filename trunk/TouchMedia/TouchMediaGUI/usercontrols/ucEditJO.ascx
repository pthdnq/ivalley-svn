<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucEditJO.ascx.cs" Inherits="TouchMediaGUI.usercontrols.ucEditJO" %>

<script type="text/javascript">
    function ChangeRemoveDateView()
    {
        if ($('#checkBoxProductionIsRemoved')[0].checked) {
            $('#divProductionIsRemoved').show();
        }
        else {
            $('#divProductionIsRemoved').hide();
        }
    }
</script>

<div class="span12 clearfix">
    <div class="span2">
        كود أمر الشغل
    </div>

    <div class="span4">
        <asp:TextBox ID="uiTextBoxJOCode" ClientIDMode="Static" runat="server"></asp:TextBox>
    </div>


    <div class="span2">
        الإسم
    </div>

    <div class="span4">
        <asp:TextBox ID="uiTextBoxName" ClientIDMode="Static" runat="server"></asp:TextBox>
    </div>
</div>
<div class="span12 clearfix">
    <div class="span2">
        الوصف
    </div>

    <div class="span4">
        <asp:TextBox ID="uiTextBoxDesc" ClientIDMode="Static" runat="server" TextMode="MultiLine" Rows="4" Columns="20"></asp:TextBox>
    </div>

    <div class="span2">
        العميل
    </div>

    <div class="span4">
        <asp:DropDownList ID="uiDropDownListClient" ClientIDMode="Static" runat="server"></asp:DropDownList>
    </div>
</div>
<div class="span12 clearfix">
    <div class="span2">
        الحالة
    </div>

    <div class="span4">
        <asp:DropDownList ID="uiDropDownListJOStatus" ClientIDMode="Static" runat="server"></asp:DropDownList>
    </div>
</div>
<div class="span12 clearfix">
    <div class="span2">
        إختر بيان أو أكثر
    </div>

    <div class="span6" id="DivSections">
        <asp:CheckBoxList ID="uiCheckBoxListSections" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" CssClass="checkSections">
            <asp:ListItem Value="1">تصميم</asp:ListItem>
            <asp:ListItem Value="2">طباعة ديجيتال</asp:ListItem>
            <asp:ListItem Value="3">طباعة أوفست</asp:ListItem>
            <asp:ListItem Value="4">طباعة ( خارجى / داخلى )</asp:ListItem>
            <asp:ListItem Value="5">إنتاج</asp:ListItem>
            <asp:ListItem Value="6">هدايا</asp:ListItem>
        </asp:CheckBoxList>
    </div>
</div>

<div class="span12 clearfix">
    <div class="tabbable tabbable-custom tabs-right">
        <ul class="nav nav-tabs tabs-right">
            <li class="active"><a href="#tab1" data-toggle="tab"><span class="current"></span>تصميم</a></li>
            <li><a href="#tab2" data-toggle="tab"><span class="current"></span>طباعة ديجيتال</a></li>
            <li><a href="#tab3" data-toggle="tab"><span class="current"></span>طباعة أوفست</a></li>
            <li><a href="#tab4" data-toggle="tab"><span class="current"></span>طباعة (داخلى / خارجى)</a></li>
            <li><a href="#tab5" data-toggle="tab"><span class="current"></span>إنتاج</a></li>
            <li><a href="#tab6" data-toggle="tab"><span class="current"></span>هدايا</a></li>
        </ul>
        <div class="tab-content">
            <div class="tab-pane active" id="tab1">
                <div id="DesignGrid">
                </div>
            </div>
            <div class="tab-pane" id="tab2">
                <div class="span12 clearfix">
                    <div class="span2">
                        نوع الطباعة
                    </div>
                    <div class="span6">
                        <asp:CheckBoxList CssClass="checkSections" ID="uiCheckBoxListDigitalItem" runat="server" RepeatDirection="Horizontal" RepeatColumns="4"></asp:CheckBoxList>
                    </div>

                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        R / R&V
                    </div>
                    <div class="span2">
                        <asp:RadioButtonList ClientIDMode="Static" CssClass="checkSections" ID="uiRadioButtonListRRV" runat="server" RepeatDirection="Horizontal" RepeatColumns="2">
                            <asp:ListItem Text="R" Value="False" />
                            <asp:ListItem Text="R & V" Value="True" />
                        </asp:RadioButtonList>
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        خدمات 
                    </div>
                    <div class="span5">
                        <asp:CheckBoxList CssClass="checkSections" ID="uiCheckBoxListServiceType" runat="server" RepeatColumns="4" RepeatDirection="Horizontal"></asp:CheckBoxList>
                    </div>

                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        R / R&V
                    </div>
                    <div class="span2">
                        <asp:RadioButtonList CssClass="checkSections" ID="uiRadioButtonListRRV2" runat="server" RepeatDirection="Horizontal" RepeatColumns="2">
                            <asp:ListItem Text="R" Value="False" />
                            <asp:ListItem Text="R & V" Value="True" />
                        </asp:RadioButtonList>
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        المطبعة 
                    </div>
                    <div class="span5">
                        <asp:DropDownList ID="uiDropDownListDigitalPrintingSupplier" runat="server"></asp:DropDownList>
                    </div>
                    <div class="span2">
                        التسليم إلى
                    </div>
                    <div class="span2">
                        <asp:DropDownList ClientIDMode="Static" ID="uiDropDownListDPDeliveryTo" runat="server">
                            <asp:ListItem Value="1" Text="المكتب" />
                            <asp:ListItem Value="2" Text="العميل" />
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        الملف 
                    </div>
                    <div class="span5">
                        <asp:FileUpload ID="uiFileUploadDigitalFile" runat="server" />
                    </div>
                    <div class="span2">
                        الكمية
                    </div>
                    <div class="span2">
                        <asp:TextBox ID="uiTextBoxDigitalQty" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="tab-pane" id="tab3">
                <div class="span12 clearfix">
                    <div class="span2">
                        نوع الورق
                    </div>
                    <div class="span5">
                        <asp:RadioButtonList CssClass="checkSections" ID="uiRadioButtonListPaperType" runat="server" RepeatDirection="Horizontal" RepeatColumns="3"></asp:RadioButtonList>
                    </div>

                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        GSM
                    </div>
                    <div class="span6">
                        <asp:RadioButtonList CssClass="checkSections" ID="uiRadioButtonListGSM" runat="server" RepeatDirection="Horizontal" RepeatColumns="4"></asp:RadioButtonList>
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        المطبعة 
                    </div>
                    <div class="span5">
                        <asp:DropDownList ID="uiDropDownListOffsetPrintHouse" runat="server"></asp:DropDownList>
                    </div>

                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        إنهاء بواسطة 
                    </div>
                    <div class="span5">
                        <asp:DropDownList ID="uiDropDownListOffsetPrintingFinishingBy" runat="server"></asp:DropDownList>
                    </div>

                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        نوع الخدمة
                    </div>
                    <div class="span6">
                        <asp:CheckBoxList CssClass="checkSections" ID="uiCheckBoxListOffsetFinishType" runat="server" RepeatDirection="Horizontal" RepeatColumns="3"></asp:CheckBoxList>
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        الملف 
                    </div>
                    <div class="span5">
                        <asp:FileUpload ID="uiFileUploadOffsetFile" runat="server" />
                    </div>
                    <div class="span2">
                        الكمية
                    </div>
                    <div class="span2">
                        <asp:TextBox ID="uiTextBoxOffsetQty" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="tab-pane" id="tab4">
                <%--<div id="InOutDoorGrid"></div>--%>
                <div class="span12 clearfix">
                    <div class="span2">
                        صنف
                    </div>
                    <div class="span5">
                        <asp:TextBox ID="txtInOutDoorItem" runat="server"></asp:TextBox>
                    </div>
                    <div class="span2">
                        الخامة
                    </div>
                    <div class="span2">
                        <asp:DropDownList ID="DropDownListInOutDoorMaterials" runat="server"></asp:DropDownList>
                    </div>

                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        تصفيح
                    </div>
                    <div class="span5">
                        <asp:DropDownList ID="DropDownListInOutDoorLamination" runat="server"></asp:DropDownList>
                    </div>

                    <div class="span2">
                        خدمة
                    </div>
                    <div class="span2">
                        <asp:DropDownList ID="DropDownListInOutDoorService" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        الصورة
                    </div>
                    <div class="span5">
                        <asp:FileUpload ID="FileUploadInOutDoorPicture" runat="server" />
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        تاريخ التسليم
                    </div>
                    <div class="span5">
                        <div class="input-append date date-picker" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                            <asp:TextBox runat="server" CssClass="m-ctrl-medium date-picker" Font-Size="16" type="text" ID="txtLaminationDeliveryDate" Style="direction: ltr" />
                            <span class="add-on">
                                <i class="icon-calendar"></i>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                       الحجم (العرض)
                    </div>
                    <div class="span5">
                        <asp:TextBox ID="txtInOutDoorWidth" placeholder="العرض" runat="server"></asp:TextBox>
                    </div>
                    <div class="span2">
                        (الطول)
                    </div>
                    <div class="span2">
                        <asp:TextBox ID="txtInOutDoorHeight" placeholder="الطول" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        يسلم الى
                    </div>
                    <div class="span5">
                        <asp:TextBox ID="txtInOutDoorDeliveryTo" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="span12 clearfix">
                    <asp:Button ID="btnInOutDoorAddItem" CssClass="btn btn-default" runat="server" Text="اضافة" />
                </div>
                <div class="span12 clearfix">
                    <asp:GridView ID="GridViewInOutDoor" OnRowCommand="GridViewInOutDoor_RowCommand" runat="server">
                        <Columns>
                            <asp:BoundField HeaderText="صنف" DataField="Item" />
                            <asp:BoundField HeaderText="الخامة" DataField="Material" />
                            <asp:BoundField HeaderText="تصفيح" DataField="Lamination" />
                            <asp:BoundField HeaderText="خدمة" DataField="Service" />
                            <asp:BoundField HeaderText="الخامة" DataField="Material" />
                            <asp:TemplateField HeaderText="عمليات">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton4" CommandArgument='<%# Eval("InAndOutDoorDetailsID") %>' CommandName="EditDetail" runat="server">تعديل</asp:LinkButton>
                                    <asp:LinkButton ID="LinkButton3" CommandArgument='<%# Eval("InAndOutDoorDetailsID") %>' CommandName="DeleteDetail" runat="server">مسح</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
            <div class="tab-pane" id="tab5">
                <div class="span12 clearfix">
                    <div class="span2">
                        صنف
                    </div>
                    <div class="span5">
                        <asp:TextBox ID="txtProductionItem" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </div>
                    <div class="span2">
                        المقاس
                    </div>
                    <div class="span2">
                        <asp:TextBox ID="txtProductionSize" ClientIDMode="Static" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        الخامة
                    </div>
                    <div class="span5" id="divProductionChkBoxMaterial">
                        <asp:CheckBoxList ID="CheckBoxListProductionMaterial" RepeatColumns="4" RepeatDirection="Horizontal" runat="server"></asp:CheckBoxList>
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        ميعاد الوصول
                    </div>
                    <div class="span5">
                        <div class="input-append date date-picker" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                            <asp:TextBox runat="server" ClientIDMode="Static" CssClass="m-ctrl-medium date-picker" Font-Size="16" type="text" ID="txtProductionDeliveryDate" Style="direction: ltr" />
                            <span class="add-on">
                                <i class="icon-calendar"></i>
                            </span>
                        </div>
                    </div>
                    <div class="span2">
                        المورد
                    </div>
                    <div class="span2">
                        <asp:DropDownList ID="DrpDwnProductionSupplier" ClientIDMode="Static" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        تاريخ التركيب
                    </div>
                    <div class="span5">
                        <div class="input-append date date-picker" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                            <asp:TextBox runat="server" ClientIDMode="Static" CssClass="m-ctrl-medium date-picker" Font-Size="16" type="text" ID="txtProductionInstallationDate" Style="direction: ltr" />
                            <span class="add-on">
                                <i class="icon-calendar"></i>
                            </span>
                        </div>
                    </div>
                    <div class="span2">
                        حالة التركيب
                    </div>
                    <div class="span2">
                        <asp:DropDownList ClientIDMode="Static" ID="DrpDwnProductionInstallationStatus" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        سيتم إزالته
                    </div>
                    <div class="span5">
                        <asp:CheckBox ID="checkBoxProductionIsRemoved" onclick="ChangeRemoveDateView();" ClientIDMode="Static" runat="server"  />
                    </div>
                    <div id="divProductionIsRemoved" style="display:none;">
                        <div class="span2">
                            تاريخ الازالة
                        </div>
                        <div class="span2">
                            <div class="input-append date date-picker" data-date-format="dd/mm/yyyy" data-date-viewmode="years">
                                <asp:TextBox runat="server" ClientIDMode="Static" CssClass="m-ctrl-medium date-picker" Font-Size="16" type="text" ID="txtProductionRemoveDate" Style="direction: ltr" />
                                <span class="add-on">
                                    <i class="icon-calendar"></i>
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span2">
                        حالة الانتاج
                    </div>
                    <div class="span5">
                        <asp:DropDownList ClientIDMode="Static" ID="DrpDwnProductionStatus" runat="server"></asp:DropDownList>
                    </div>
                    <div class="span4">
                    </div>
                </div>
                <div class="span12 clearfix">
                    <div class="span4">
                        <asp:LinkButton ID="BtnProductionSendDetailsToSupplier" CssClass="btn btn-default" runat="server">ارسال البيانات للمورد</asp:LinkButton>
                    </div>
                </div>
            </div>
            <div class="tab-pane" id="tab6">
                <div id="GiveawaysGrid"></div>
            </div>
        </div>
    </div>
</div>
<div class="span12 clearfix">
    <div class="span2">
    </div>
    <div class="span2">
        <a class="btn btn-primaty" onclick="SaveJobOrder();">حفظ</a>
    </div>
    <div class="span2">
        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-default">إلغاء</asp:LinkButton>
    </div>
</div>
