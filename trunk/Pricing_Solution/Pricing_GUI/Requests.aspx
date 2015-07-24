<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Requests.aspx.cs" Inherits="Pricing_GUI.Requests" %>
<%@ MasterType VirtualPath="~/General.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="js/jqwidgets/styles/jqx.base.css" rel="stylesheet" />    
    <script type="text/javascript" src="js/jqwidgets/jqxcore.js"></script>
    <script type="text/javascript" src="js/jqwidgets/jqxdata.js"></script>
    <script type="text/javascript" src="js/jqwidgets/jqxbuttons.js"></script>
    <script type="text/javascript" src="js/jqwidgets/jqxscrollbar.js"></script>
    <script type="text/javascript" src="js/jqwidgets/jqxlistbox.js"></script>
    <script type="text/javascript" src="js/jqwidgets/jqxdropdownlist.js"></script>
    <script type="text/javascript" src="js/jqwidgets/jqxmenu.js"></script>
    <script type="text/javascript" src="js/jqwidgets/jqxgrid.js"></script>
    <script type="text/javascript" src="js/jqwidgets/jqxgrid.filter.js"></script>
    <script type="text/javascript" src="js/jqwidgets/jqxgrid.sort.js"></script>
    <script type="text/javascript" src="js/jqwidgets/jqxgrid.selection.js"></script>
    <script type="text/javascript" src="js/jqwidgets/jqxgrid.edit.js"></script>
    <script type="text/javascript" src="js/jqwidgets/jqxgrid.columnsresize.js"></script>
    <script src="js/jqwidgets/jqxgrid.pager.js"></script>
    <script type="text/javascript" src="js/jqwidgets/jqxpanel.js"></script>

    <script src="js/tempo.min.js"></script>

     <link href="assets/bootstrap-datepicker/css/datepicker.css" rel="stylesheet" />
     <script src="assets/bootstrap-datepicker/js/bootstrap-datepicker.js"></script>
    <script src="assets/bootstrap-daterangepicker/date.js"></script>
    <script src="assets/bootstrap-daterangepicker/daterangepicker.js"></script>
    <script src="assets/bootstrap-timepicker/js/bootstrap-timepicker.js"></script>

    <script type="text/javascript">

        function getParameterByName(name) {
            name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
            var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
                results = regex.exec(location.search);
            return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
        }


        $(document).ready(function () {
            $('#<%= uiTextBoxDrugs.ClientID %>').typeahead( {                
                 source: function (query, process) {
                    $.ajax({
                      url: 'services/PricingService.asmx/SearchDrugs',
                      type: 'POST',
                      dataType: 'JSON',
                      data: 'name=' + query,
                      success: function (data) {
                          var resultList = data.map(function (item) {
                              var aItem = { id: item.TradeCode, name: item.Trade_name };
                              return JSON.stringify(aItem);
                          });

                          return process(resultList);
                      }
                    });
                 },
                 matcher: function (obj) {
                     var item = JSON.parse(obj);
                     return ~item.name.toLowerCase().indexOf(this.query.toLowerCase())
                 },
                 sorter: function (items) {
                     var beginswith = [], caseSensitive = [], caseInsensitive = [], item;
                     while (aItem = items.shift()) {
                         var item = JSON.parse(aItem);
                         if (!item.name.toLowerCase().indexOf(this.query.toLowerCase())) beginswith.push(JSON.stringify(item));
                         else if (~item.name.indexOf(this.query)) caseSensitive.push(JSON.stringify(item));
                         else caseInsensitive.push(JSON.stringify(item));
                     }

                     return beginswith.concat(caseSensitive, caseInsensitive)

                 },
                 highlighter: function (obj) {
                     var item = JSON.parse(obj);
                     var query = this.query.replace(/[\-\[\]{}()*+?.,\\\^$|#\s]/g, '\\$&')
                     return item.name.replace(new RegExp('(' + query + ')', 'ig'), function ($1, match) {
                         return '<strong>' + match + '</strong>'
                     })
                 },
                 updater: function (obj) {
                     var item = JSON.parse(obj);
                     $('#uiHiddenFieldSearchDrugID').attr('value', item.id);
                     $('#selectDrug').show();
                     return item.name;
                 }
            });

            if (getParameterByName('did') != '' && getParameterByName('pid') != '')
            {
                $('#uiHiddenFieldCurrentDrugID').val(getParameterByName('did'));
                getDrugInfo(getParameterByName('pid'), false);
            }

            $('#bts').click(function () {
                $('#searchPanel').show();
                $('#backToSearch').hide();
                $('#druginfotabs').hide();
            });

            $('#PackageModal').on('hidden', function () {
                $('#packagejqxgrid').jqxGrid('updatebounddata', 'data');
            });

            $('#AddNewPack').click(function () {
                SetTradeCodeForPackages();
            });

        });

        function SearchDrugs()
        {
            $('#druginfotabs').fadeOut(200);
            $('#gridHolder').fadeIn(300).delay(500);


            try {
                $('#jqxgrid').jqxGrid('destroy');
            } catch (e) {

            }

            $('#gridHolder').append("<div id='jqxgrid'></div>");

            var source =
            {
                datatype: "json",
                datafields: [
                    { name: 'Trade_name', type: 'string' },
                    { name: 'Generics', type: 'string' },
                    { name: 'Applicant', type: 'string' },
                    { name: 'Drug_license_number', type: 'string' },
                    { name: 'Dosage_Form', type: 'string' },
                    { name: 'TradeCode', type: 'number' },
                ],
                url: "services/PricingService.asmx/GetTradeDrugs",
                data: {
                    name: $('#<%= uiTextBoxDrugs.ClientID %>').val(),
                    generics: $('#<%= uiTextBoxGenerics.ClientID %>').val(),
                    strength: $('#<%= uiTextBoxStrength.ClientID %>').val() == "" ? 0 : $('#<%= uiTextBoxStrength.ClientID %>').val(),
                    company: $('#<%= uiTextBoxCompany.ClientID %>').val(),
                    regNo: $('#<%= uiTextBoxRegNo.ClientID %>').val()
                }
            };
            var dataAdapter = new $.jqx.dataAdapter(source);
            $("#jqxgrid").jqxGrid(
           {
               width: "100%",
               source: dataAdapter,
               enablehover: false,
               pageable: true,
               autoheight: true,
               selectionmode: 'none',
               columns: [
                 { text: 'Trade Name', datafield: 'Trade_name', width: '30%', cellsalign: 'left', align: 'left' },
                 { text: 'Generics', datafield: 'Generics', width: '30%', cellsalign: 'center', align: 'center' },
                 { text: 'Applicant', datafield: 'Applicant', width: '20%', cellsalign: 'center', align: 'center' },
                 { text: 'Reg. No.', datafield: 'Drug_license_number', width: '10%', cellsalign: 'center', align: 'center' },
                 { text: '', datafield: 'TradeCode', width: '10%', cellsrenderer: linkrenderer, cellsalign: 'center', align: 'center' }
               ]
           });

        }

        var linkrenderer = function (row, column, value) {            
            var html = '<a style="display:block;margin:0 auto;" target="_blank" onclick="getPackInfo('+row+')" class="btn btn-default">Select</a>';
            return html;
        }        var renderPackLink = function (row, column, value) {
            var html = '<a style="display:block;margin:0 auto;" target="_blank" onclick="getDrugInfo(' + row + ', true)" class="btn btn-default">Select</a>';
            return html;
        }

        function getPackInfo(row) {
            $('#PackInfoGrid').show();
            $('#loadingMsg').html("Loading package details info ...");
            var datarow = $("#jqxgrid").jqxGrid('getrowdata', row);
            // set selected drug id from drugs grid
            $('#uiHiddenFieldCurrentDrugID').val(datarow.TradeCode);
            try {
                $('#packagejqxgrid').jqxGrid('destroy');
            } catch (e) {

            }

            $('#PackInfoGrid').append("<div id='packagejqxgrid'></div>");

            var source =
            {
                datatype: "json",
                datafields: [
                    { name: 'PackID', type: 'number' },
                    { name: 'Pack_unit', type: 'string' },
                    { name: 'Pack_Unit_Name', type: 'string' },
                    { name: 'conver_sub', type: 'number' },
                    { name: 'unit_price', type: 'number' },
                ],
                url: "services/PricingService.asmx/GetTradePackgesById",
                data: {
                    id: datarow.TradeCode,
                }
            };
            var dataAdapter = new $.jqx.dataAdapter(source);
            $("#packagejqxgrid").jqxGrid(
            {
                width: "100%",
                source: dataAdapter,
                enablehover: false,
                pageable: true,
                autoheight: true,
                selectionmode: 'none',
                columns: [
                    { text: 'Main unit', datafield: 'Pack_unit', width: '25%', cellsalign: 'left', align: 'left' },
                    { text: 'Sub Unit', datafield: 'Pack_Unit_Name', width: '25%', cellsalign: 'left', align: 'left' },
                    { text: 'Conv. To Sub', datafield: 'conver_sub', width: '20%', cellsalign: 'center', align: 'center' },
                    { text: 'Price', datafield: 'unit_price', width: '20%', cellsalign: 'center', align: 'center' },
                    { text: '', datafield: 'PackID', width: '10%', cellsrenderer: renderPackLink, cellsalign: 'center', align: 'center' }
                ]
            });

            $('#drugloading').hide();
            $('#loadingMsg').html("");

        }

        function getDrugInfo(row, fromGrid) {
            
            $('#gridHolder').fadeOut(200);
            $('#PackInfoGrid').fadeOut(200);
            var packid;

            if (fromGrid) {
                var datarow = $("#packagejqxgrid").jqxGrid('getrowdata', row);
                // set selected pack id from packs grid
                $('#uiHiddenFieldCurrentPackID').val(datarow.PackID);
                packid = datarow.PackID;
            }
            else {
                packid = row;
                // set selected pack id from packs grid
                $('#uiHiddenFieldCurrentPackID').val(packid);
            }
            

            $('#druginfotabs').fadeIn(300).delay(500);
            $('#loadingMsg').html("Loading drug info ...");
            $('#drugloading').show();

            $.ajax({
                url: 'services/PricingService.asmx/GetTradeDrugById',
                type: 'POST',
                dataType: 'JSON',
                data: 'id=' + $('#uiHiddenFieldCurrentDrugID').val(),
                success: function (data) {
                    $('#<%= ui_txtTradeName.ClientID%>').val(data.Trade_name);
                    $('#<%= ui_txtDosageForm.ClientID%>').val(data.Dosage_form);
                    $('#<%= ui_txtCompanies.ClientID%>').val(data.Applicant);
                    $('#<%= txt_strength.ClientID%>').val(data.Strength_value);
                    $('#<%= txt_prodType.ClientID%>').val(data.Type);
                    $('#<%= TextBox1_comp.ClientID%>').html(data.LicHold);
                    $('#<%= TextBox2_comp.ClientID%>').html(data.Manufacturer);
                    $('#<%= TextBox3_comp.ClientID%>').html(data.Packager);
                    $('#<%= TextBox4_comp.ClientID%>').html(data.BatchReleaser);
                    $('#<%= TextBox5_comp.ClientID%>').html(data.StorageSite);
                    $('#<%= txt_regNo.ClientID%>').val(data.Drug_license_number);
                    $('#<%= txt_regType.ClientID%>').val(data.Type_of_license);
                    $('#<%= uiDropDownListLicenseType.ClientID%>').val($.trim(data.Type_of_license));

                    $('#searchPanel').hide();
                    $('#backToSearch').show();

                    // view current drug name - current package
                    $('#CurrentTradeName').html(data.Trade_name);
                    $.ajax({
                        url: 'services/PricingService.asmx/GetTradePackgesByPackId',
                        type: 'POST',
                        dataType: 'JSON',
                        data: 'id=' + packid,
                        success: function (data) {
                            $('#currentMainUnit').html(data.Pack_unit);
                            $('#currentSubUnit').html(data.Pack_Unit_Name);
                            $('#currentCTSUnit').html(data.conver_sub);
                            $('#currentPrice').html(data.unit_price);
                        }
                    });


                    getGenerics();
                    getPackagePricing(packid);
                    getStatusHistory(packid);

                    // scroll to top after loading new info
                    $(document).scrollTop(0);
                }
            });
        }

        

        function getGenerics() {
            $('#loadingMsg').html("Loading generics info ...");
            

            try {
                $('#genericsjqxgrid').jqxGrid('destroy');
            } catch (e) {

            }

            $('#genericsGrid').append("<div id='genericsjqxgrid'></div>");

            var source =
            {
                datatype: "json",
                datafields: [
                    { name: 'GenericName', type: 'string' },
                    { name: 'strengthunitstr', type: 'string' },
                    { name: 'StrengthValue', type: 'number' },
                ],
                url: "services/PricingService.asmx/GetTradeGenericsById",
                data: {
                    id: $('#uiHiddenFieldCurrentDrugID').val(),
                }
            };
            var dataAdapter = new $.jqx.dataAdapter(source);
            $("#genericsjqxgrid").jqxGrid(
            {
                width: "100%",
                source: dataAdapter,
                enablehover: false,
                pageable: true,
                autoheight: true,
                selectionmode: 'none',
                columns: [
                    { text: 'Generic Name', datafield: 'GenericName', width: '40%', cellsalign: 'left', align: 'left' },
                    { text: 'Strength Value', datafield: 'StrengthValue', width: '30%', cellsalign: 'center', align: 'center' },
                    { text: 'strength unit', datafield: 'strengthunitstr', width: '30%', cellsalign: 'center', align: 'center' },
                ]
            });
            $('#drugloading').hide();
            $('#loadingMsg').html("");
        }

        function getPackagePricing(packId)
        {
            $('#loadingMsg').html("Loading Pricing info ...");
            $('#drugloading').show();

            $.ajax({
                url: 'services/PricingService.asmx/GetPricingInfoByPackageId',
                type: 'POST',
                dataType: 'JSON',
                data: 'id=' + packId,
                success: function (data) {
                    $('#<%= uiDropDownListCommitteType.ClientID%>').val(data.RegistrationCommitteTypeID);
                    $('#<%= uiTextBoxNotes.ClientID%>').val(data.Trade_Notes);
                    $('#<%= hf1.ClientID%>').val(data.File_CoverLetter);
                    $('#<%= hf2.ClientID%>').val(data.File_BoxApproval);
                    $('#<%= hf3.ClientID%>').val(data.File_TradeNameApproval);
                    $('#<%= hf4.ClientID%>').val(data.File_CostSheet);
                    $('#<%= hf5.ClientID%>').val(data.File_ProformaInvoice);
                    $('#<%= hf6.ClientID%>').val(data.File_CifPriceToEgypt);
                    $('#<%= hf7.ClientID%>').val(data.File_PriceOriginCountry);
                    $('#<%= hf8.ClientID%>').val(data.File_CountryPrices);
                    $('#<%= hf9.ClientID%>').val(data.File_PackArtworkLeaflet);
                    $('#<%= hf10.ClientID%>').val(data.File_ministerapproval);
                    $('#<%= hf11.ClientID%>').val(data.ApprovalLetters);
                    $('#<%= uiDropDownListSectorType_Before.ClientID%>').val(data.SectorTypeID);
                    $('#<%= uiDropDownListStatusType.ClientID%>').val(data.TradePricingStatusID);
                    $('#<%= uiTextBoxReference.ClientID%>').html(data.Reference);
                    $('#<%= uiTextBoxIndication.ClientID%>').html(data.Indication);
                    $('#<%= uiTextBoxDose.ClientID%>').html(data.Dose);
                    $('#<%= uiTextBoxCommittePrice.ClientID%>').html(data.CommittePrice);
                    $('#<%= uiTextBoxCommitteDate.ClientID%>').html(data.CommiteeDate);
                    $('#<%= uiTextBoxRationalForPricing.ClientID%>').val(data.RationalForPricing);
                    $('#<%= uiTextBoxNoInBox.ClientID%>').val(data.NoInBox);
                    $('#<%= uiTextBoxBrandPriceInEgy.ClientID%>').html(data.PriceInEgy);
                    $('#<%= uiTextBoxPriceAfter30.ClientID%>').html(data.PriceAfter30);
                    $('#<%= uiTextBoxPriceAfter35.ClientID%>').html(data.PriceAfter35HighTech);
                    $('#<%= uiTextBoxPriceAfter35FirstGeneric.ClientID%>').html(data.PriceAfter35FirstGeneric);
                    $('#<%= uiTextBoxPriceAfter40ndGeneric.ClientID%>').html(data.PriceAfter40SecondGeneric);
                    $('#<%= uiTextBoxLowestPriceGeneric.ClientID%>').val(data.LowestPriceGeneric);
                    $('#<%= uiTextBoxNotes_After.ClientID%>').val(data.Notes);
                    $('#<%= uiTextBoxMainGroup.ClientID%>').html(data.MainGroup);
                    $('#<%= uiTextBoxPreviouspack.ClientID%>').html(data.PreviousPack);
                    $('#<%= uiTextBoxPreviousPrice.ClientID%>').html(data.PreviousPrice);
                    $('#<%= uiTextBoxApprovedPrice.ClientID%>').html(data.ApprovedPrice);
                    $('#<%= uiTextBoxPriceCategory.ClientID%>').html(data.PriceCategory);
                    $('#<%= uiTextBoxApprovalDate.ClientID%>').val(data.Approvaldate);
                    $('#<%= uiTextBoxIssueDate.ClientID%>').val(data.Issuedate);

                    $('#<%= uiCheckBoxSubmittedToSpecialized.ClientID%>').attr('checked', data.SubmittedToSpecialized);
                    $('#<%= uiCheckBoxSalesTaxes.ClientID%>').attr('checked', data.SalesTaxes);
                    $('#<%= uiCheckBoxEssentialDrugList.ClientID%>').attr('checked', data.EssentialDrugList);
                    $('#<%= uiCheckBoxIsPricedTo499.ClientID%>').attr('checked', data.IsPricedTo499);
                    $('#<%= uiCheckBoxSimilar.ClientID%>').attr('checked', data.Similar);

                    $('#uiHiddenFieldCurrentPPID').val(data.PackagePricingID);

                    LoadNextStatus(data.PricingStatusID);
                    $('#loadingMsg').html("");
                    $('#drugloading').hide();
                }
            });
        }

        var template = null;
        function getStatusHistory(packId) {
            
            $.ajax({
                url: 'services/PricingService.asmx/GetStatusHistoryByPackageId',
                type: 'POST',
                dataType: 'JSON',
                data: 'id=' + packId,
                success: function (data) {
                    if (template == null)
                        template = Tempo.prepare('StatusHistory');
                    template.clear();
                    template.prepend(data);
                    
                    //Tempo.prepare('StatusHistory').render(data);
                }
            });
        }
        function LoadNextStatus(currentStatus)
        {
            // enable / disable committe controls 
            $('#tr_committee_1').hide();
            $('#tr_committee_2').hide();

            if (currentStatus == 2 || currentStatus == 10 || currentStatus == 13)
            {
                $('#tr_committee_1').show();
                $('#tr_committee_2').show();
            }
            $.ajax({
                url: 'services/PricingService.asmx/GetNextStatuses',
                type: 'POST',
                dataType: 'JSON',
                data: 'currentStatusID=' + currentStatus,
                success: function (data) {
                    $('#PricingStatus').children().remove();
                    var html;
                    html += "<option value='-1'>Select status ...</option>";
                    $.each(data, function (i, item) {
                        html += "<option value='" + item.PricingStatusID + "' >" + item.Status + "</option>";
                    });
                    $('#PricingStatus').html(html);
                }
            });
        }

        function AddStatus()
        {
            $('#loadingMsg').html("Adding status ...");
            $('#drugloading').show();

            var _status = new Object();
            _status.TradePricingID = $('#uiHiddenFieldCurrentDrugID').val();
            _status.Comment=$('#Comment').val() ;
            _status.PackID=  $('#uiHiddenFieldCurrentPackID').val();
            _status.PricingStatusID=  $('#PricingStatus').val();
            var str = { status: _status };
            var readyData = JSON.stringify(str);
            $.ajax({
                url: 'services/PricingService.asmx/AddNewStatusHistory',
                type: 'POST',
                dataType: 'JSON',
                contentType: 'application/json; charset=utf-8',
                data: readyData,
                success: function (data) {
                    $('#StatusModal').modal('hide');
                    LoadNextStatus($('#PricingStatus').val());
                    getStatusHistory($('#uiHiddenFieldCurrentPackID').val());
                    $('#loadingMsg').html("");
                    $('#drugloading').hide();
                }
            });
        }


        function SetAttachment(id, value)
        {            
            $('#hf' + id).val(value);            
        }

        function ValidatePricingRequest(sender, e)
        {
            isValid = true;
            message = "";

            if ($('#<%= uiDropDownListCommitteType.ClientID%>').val() == '0') { isValid = false; message += "You must choose a committe type." + "<br />";}

            if ($('#<%= hf1.ClientID%>').val() == '0' || $('#<%= hf1.ClientID%>').val() == "") { isValid = false; message += "You must add a Covering Letter." + "<br />"; }
            if ($('#<%= hf2.ClientID%>').val() == '0' || $('#<%= hf2.ClientID%>').val() == "") { isValid = false; message += "You must add Box Approval Letter." + "<br />"; }
            if ($('#<%= hf3.ClientID%>').val() == '0' || $('#<%= hf3.ClientID%>').val() == "") { isValid = false; message += "You must add a Trade Name Approval Letter." + "<br />"; }
            if ($('#<%= hf4.ClientID%>').val() == '0' || $('#<%= hf4.ClientID%>').val() == "") { isValid = false; message += "You must add a Cost Sheet." + "<br />"; }
            if ($('#<%= hf5.ClientID%>').val() == '0' || $('#<%= hf5.ClientID%>').val() == "") { isValid = false; message += "You must add a Proforma invoice." + "<br />"; }
            if ($('#<%= hf6.ClientID%>').val() == '0' || $('#<%= hf6.ClientID%>').val() == "") { isValid = false; message += "You must add a CIF Price To Egypt." + "<br />"; }
            if ($('#<%= hf7.ClientID%>').val() == '0' || $('#<%= hf7.ClientID%>').val() == "") { isValid = false; message += "You must add a Price of Product in the country of origin." + "<br />"; }
            if ($('#<%= hf8.ClientID%>').val() == '0' || $('#<%= hf8.ClientID%>').val() == "") { isValid = false; message += "You must add a Country Prices of the Product." + "<br />"; }
            if ($('#<%= hf9.ClientID%>').val() == '0' || $('#<%= hf9.ClientID%>').val() == "") { isValid = false; message += "You must add Product Pack or Artwork and leaflet." + "<br />"; }
            if (!isValid)
            {
                $('#errorDiv').html(message);
                $('#ErrorModal').modal('show');                
            }
            e.IsValid = isValid;
            
        }

        function SetTradeCodeForPackages()
        {
            document.getElementById('pFrame').contentWindow.setTradeCode($('#uiHiddenFieldCurrentDrugID').val());
        }

    </script>
    <style type="text/css">
        #drugloading {
            padding-top:15%;
            display:none;
            position:absolute;
            z-index:9999;
            top:0;
            left:0;
            width:100%;
            height:100%;
            background-color:rgba(255,255,255,0.7);
            color:#4a4086;
            font-weight:bold;
            font-size:20px;
            font-family:Verdana;
        }        
            .nav-tabs > li > a {
                background-color:#b14c4c;
                color:#fff;
            }
        
            .nav-tabs > .active > a, .nav-tabs > .active > a:hover, .nav-tabs > .active > a:focus {
            border-bottom-color:white;
            }
            .nav-tabs > li > a:hover, .nav-tabs > li > a:focus {
                color:#6e879f;
            }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row-fluid ">
        <div class="span12">
            <!-- BEGIN INLINE TABS PORTLET-->
            <div class="widget">
                <div class="widget-title">
                    <h4>
                        <i class="icon-reorder"></i>
                        <asp:Label runat="server" ID="lblPageTitle" ForeColor="#003366" Text="Submit New Pricing Request"></asp:Label></h4>
                    <span class="tools"><a href="javascript:;" class="icon-chevron-down"></a></span>
                </div>
                <div class="widget-body">
                    <div class="row-fluid">
                        <div class="span12" id="searchPanel">
                        <div class="span12 clearfix">
                            <div class="span2">Drug trade name</div>
                            <div class="span4">
                                <asp:TextBox ID="uiTextBoxDrugs" runat="server" ></asp:TextBox>
                                <input type="hidden" id="uiHiddenFieldSearchDrugID" />
                            </div>
                            <div class="span2">Generics</div>
                            <div class="span4">
                                <asp:TextBox ID="uiTextBoxGenerics" runat="server" ></asp:TextBox>                                
                            </div>
                        </div>
                        <div class="span12 clearfix" style="margin-left:0px">
                            <div class="span2">Strength </div>
                            <div class="span4">
                                <asp:TextBox ID="uiTextBoxStrength" runat="server" ></asp:TextBox>                                
                            </div>
                            <div class="span2">Company</div>
                            <div class="span4">
                                <asp:TextBox ID="uiTextBoxCompany" runat="server" ></asp:TextBox>                                
                            </div>
                        </div>

                        <div class="span12 clearfix" style="margin-left:0px">
                            <div class="span2">Reg No. </div>
                            <div class="span4">
                                <asp:TextBox ID="uiTextBoxRegNo" runat="server" ></asp:TextBox>                                
                            </div>
                            <div class="span2"><a href="#" class="btn btn-primary" onclick="SearchDrugs()">Search</a> </div>
                            <div class="span4">
                                                               
                            </div>
                            
                        </div>
                            </div>
                        <div class="span12 hide no-margin" id="backToSearch">
                            <div class="span10 block-margin-bottom-5" style="border:1px solid #4a4086;padding:5px;">
                                <b>Trade Name : </b><span id="CurrentTradeName"></span><br />
                                <b>Package Main unit: </b> <span id="currentMainUnit"></span> &nbsp;&nbsp;
                                <b>Sub unit: </b> <span id="currentSubUnit"></span> &nbsp;&nbsp;
                                <b>Conver. to sub: </b> <span id="currentCTSUnit"></span> &nbsp;&nbsp;
                                <b>Price: </b> <span id="currentPrice"></span> &nbsp;&nbsp;
                                
                            </div>
                            <div class="span2 pull-right">
                            <a href="#" class="btn btn-info" id="bts">Back to search</a>
                                </div>
                            </div>
                        <div class="span12 clearfix block-margin-bottom-5" id="gridHolder" style="margin-left:0px;display:none;margin-bottom:15px;">
                        <h4>Available drugs</h4>    
                        </div>

                        <div id="PackInfoGrid" class="span12 clearfix block-margin-bottom-5" style="margin-left:0px;display:none;">
                            <div class="span12 clearfix">
                                <h4 class="span4">Available packages</h4>    
                                <div class=" pull-right center">
                                    <a href="#" class="btn btn-info" data-toggle="modal" data-target="#PackageModal" id="AddNewPack">Add new package</a>
                                </div>
                            </div>  
                        </div>

                        <div class="span12 clearfix" id="druginfotabs" style="margin-left:0px;display:none" >
                            <asp:HiddenField ID="uiHiddenFieldCurrentDrugID" runat="server" ClientIDMode="Static" />
                            <asp:HiddenField ID="uiHiddenFieldCurrentPackID" runat="server" ClientIDMode="Static"/>
                            <asp:HiddenField ID="uiHiddenFieldCurrentPPID" runat="server" ClientIDMode="Static"/>
                            <asp:CustomValidator ID="uiCustomValidator" runat="server" ErrorMessage="*" Display="None" ControlToValidate="uiDropDownListCommitteType" ClientValidationFunction="ValidatePricingRequest" ValidationGroup="add"></asp:CustomValidator>
                            <div class="tabbable tabbable-custom" style="position:relative;">
                                <ul class="nav nav-tabs">
                                    <li class="active"><a href="#tab_1_1" data-toggle="tab">Drug info</a></li>
                                    <li><a href="#tab_1_2" data-toggle="tab">Request Info</a></li>
                                    <li><a href="#tab_1_3" data-toggle="tab">Attachments</a></li>                                       
                                    <li><a href="#tab_1_5" data-toggle="tab">Before committe</a></li>
                                    <li><a href="#tab_1_6" data-toggle="tab">After committe</a></li>
                                    <li><a href="#tab_1_7" data-toggle="tab">After approval</a></li>
                                    <li><a href="#tab_1_4" data-toggle="tab">Status history</a></li>
                                </ul>
                                <div class="tab-content">
                                    <div class="tab-pane active" id="tab_1_1">
                                        <table>
                                            <tbody>
                                                <tr>
                                                    <td style="width: 16%; height: 24px;">
                                                        <asp:Label ID="Label1" runat="server" Text="Trade Name"></asp:Label>
                                                    </td>
                                                    <td style="width: 19%; height: 24px;">
                                                        <asp:TextBox ID="ui_txtTradeName" runat="server" Width="220px" Enabled="false"></asp:TextBox>
                                                    </td>
                                                    <td style="width: 9%; height: 24px;"></td>
                                                    <td style="width: 15%; height: 24px;">
                                                        <asp:Label ID="Label5" runat="server" Text="Dosage Form"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="ui_txtDosageForm" runat="server" Width="220px" Enabled="false"></asp:TextBox>
                                                    </td>
                                                    <td></td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label2" runat="server" Text="Applicant"></asp:Label>
                                                    </td>
                                                    <td>

                                                        <asp:TextBox ID="ui_txtCompanies" runat="server" Width="220px" Enabled="false"></asp:TextBox>
                                                    </td>
                                                    <td></td>
                                                    <td>
                                                        <asp:Label ID="Label6" runat="server" Text="Strength"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txt_strength" runat="server" Width="220px" Enabled="false"></asp:TextBox>
                                                    </td>
                                                    <td></td>
                                                </tr>
                                                <tr>
                                                    <td>Product Type :	
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txt_prodType" runat="server" Width="220px" Enabled="false"></asp:TextBox>
                                                    </td>
                                                    <td></td>
                                                      <td>
                                                        <asp:Label ID="Label16" runat="server" Text="License Type"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="uiDropDownListLicenseType" runat="server" Width="225px" Enabled="false">
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>

                                            </tbody>
                                        </table>
                                        <hr style="width: 100%" />
                                        <h4>Registration Details </h4>
                                        <div class="span8 clearfix block-margin-bottom-5" style="margin-left: 0px;">
                                            <table class="table table-condensed table-bordered table-advance ">
                                                <thead>
                                                    <tr>
                                                        <th>Company Name</th>

                                                        <th>Type</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr>

                                                        <td>
                                                            <asp:Label ID="TextBox1_comp" runat="server"></asp:Label>
                                                        </td>
                                                        <td>Licensor Holder
                                                        </td>
                                                    </tr>
                                                    <tr>

                                                        <td>
                                                            <asp:Label ID="TextBox2_comp" runat="server"></asp:Label>
                                                        </td>
                                                        <td>Manufacturer
                                                        </td>
                                                    </tr>
                                                    <tr>

                                                        <td>
                                                            <asp:Label ID="TextBox3_comp" runat="server"></asp:Label>
                                                        </td>
                                                        <td>Packager
                                                        </td>
                                                    </tr>
                                                    <tr>

                                                        <td>
                                                            <asp:Label ID="TextBox4_comp" runat="server"></asp:Label>
                                                        </td>
                                                        <td>Batch Releaser
                                                        </td>
                                                    </tr>
                                                    <tr>

                                                        <td>
                                                            <asp:Label ID="TextBox5_comp" runat="server"></asp:Label>
                                                        </td>
                                                        <td>Storage Site
                                                        </td>
                                                    </tr>

                                                </tbody>
                                            </table>
                                        </div>

                                        <div class="span12 clearfix " style="margin-left: 0px;">
                                            <div class="span2 " style="margin-left: 0px;">
                                                <asp:Label ID="Label3" runat="server" Text="Registration No :"></asp:Label>
                                            </div>
                                            <div class="span4" style="margin-left: 0px;">
                                                <asp:TextBox ID="txt_regNo" runat="server" Width="220px" Enabled="false"></asp:TextBox>
                                            </div>
                                            <div class="span2" style="margin-left: 0px;">
                                                <asp:Label ID="Label4" runat="server" Text="Registration Type :"></asp:Label>
                                            </div>
                                            <div class="span4" style="margin-left: 0px;">
                                                <asp:TextBox ID="txt_regType" runat="server" Width="220px" Enabled="false"></asp:TextBox>
                                            </div>
                                        </div>
                                        <hr style="width: 100%" />
                                        <h4>Generics </h4>
                                        <div class="span12 clearfix" style="margin-left: 0px;">
                                            <div id="genericsGrid"></div>
                                        </div>
                                    </div>
                                    <div class="tab-pane" id="tab_1_2">
                                        <div class="span12 clearfix">
                                            <div class="span2">Committe type</div>
                                            <div class="span6">
                                                <asp:DropDownList ID="uiDropDownListCommitteType" runat="server"></asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="span12 clearfix no-margin">
                                            <div class="span2">Notes</div>
                                            <div class="span6">
                                                <asp:TextBox ID="uiTextBoxNotes" TextMode="MultiLine" Rows="4" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="tab-pane" id="tab_1_3">
                                        <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                                            <div class="span2">Covering Letter</div>
                                            <div class="span4">
                                                <iframe src="uiUpload.html?id=1" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                                                <asp:HiddenField ID="hf1" runat="server" ClientIDMode="Static"/>                                                
                                            </div>
                                            <div class="span2">Box Approval Letter</div>
                                            <div class="span4">
                                                <iframe src="uiUpload.html?id=2" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                                                <asp:HiddenField ID="hf2" runat="server" ClientIDMode="Static"/>
                                            </div>
                                        </div>

                                        <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                                            
                                           <div class="span2">Trade Name Approval Letter</div>
                                            <div class="span4">
                                                <iframe src="uiUpload.html?id=3" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                                                <asp:HiddenField ID="hf3" runat="server" ClientIDMode="Static"/>
                                            </div>
                                             <div class="span2">Cost Sheet</div>
                                            <div class="span4">
                                                <iframe src="uiUpload.html?id=4" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                                                <asp:HiddenField ID="hf4" runat="server" ClientIDMode="Static"/>
                                            </div>
                                        </div>
                                       <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                                            <div class="span2">Proforma invoice</div>
                                            <div class="span4">
                                                <iframe src="uiUpload.html?id=5" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                                                <asp:HiddenField ID="hf5" runat="server" ClientIDMode="Static"/>
                                            </div>
                                            <div class="span2">CIF Price To Egypt </div>
                                            <div class="span4">
                                                <iframe src="uiUpload.html?id=6" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                                                <asp:HiddenField ID="hf6" runat="server" ClientIDMode="Static"/>
                                            </div>
                                        </div>
                                        
                                        <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                                            <div class="span2">Price of Product in the country of origin</div>
                                            <div class="span4">
                                                <iframe src="uiUpload.html?id=7" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                                                <asp:HiddenField ID="hf7" runat="server" ClientIDMode="Static"/>
                                            </div>
                                            <div class="span2">Country Prices of the Product </div>
                                            <div class="span4">
                                                <iframe src="uiUpload.html?id=8" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                                                <asp:HiddenField ID="hf8" runat="server" ClientIDMode="Static"/>
                                            </div>
                                        </div>
                                       
                                        <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0">
                                            <div class="span2">Product Pack or Artwork and leaflet</div>
                                            <div class="span4">
                                                <iframe src="uiUpload.html?id=9" style="border: 0; width: 100%; overflow: hidden; height: 100px;"></iframe>
                                                <asp:HiddenField ID="hf9" runat="server" ClientIDMode="Static"/>
                                            </div>
                                        </div>

                                    </div>
                                    <div class="tab-pane" id="tab_1_5">
                                        <table style="width: 81%;">
                                            <tbody>
                                                <tr>
                                                   <%-- <td style="width: 16%; height: 24px;">
                                                        <asp:Label ID="Label7" runat="server" Text="Reg. No."></asp:Label>
                                                    </td>
                                                    <td style="width: 19%; height: 24px;">
                                                        <asp:TextBox ID="uiTextBoxBeforeRegNo" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td style="width: 9%; height: 24px;">&nbsp;</td>--%>
                                                    <td style="width: 15%; height: 24px;">
                                                        <asp:Label ID="Label9" runat="server" Text="Sector type"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="uiDropDownListSectorType_Before" runat="server"
                                                            Width="225px">
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>&nbsp;</td><td>&nbsp;</td>
                                                    <td>&nbsp;</td><td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                  
                                                    <td>
                                                        <asp:Label ID="Label19" runat="server" Text="Status"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="uiDropDownListStatusType" runat="server" Width="225px">
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>Reference</td>
                                                    <td>

                                                        <asp:TextBox ID="uiTextBoxReference" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                    <td>
                                                        <asp:Label ID="Label22" runat="server" Text="Indication"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxIndication" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>Submitted to specialized</td>
                                                    <td>
                                                        <asp:CheckBox ID="uiCheckBoxSubmittedToSpecialized" runat="server" />


                                                    </td>
                                                    <td>&nbsp;</td>
                                                    <td>
                                                        <asp:Label ID="Label23" runat="server" Text="Dose"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxDose" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label24" runat="server" Text="Sales taxes"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:CheckBox ID="uiCheckBoxSalesTaxes" runat="server" />
                                                    </td>
                                                    <td>&nbsp;</td>
                                                    <td>
                                                        <asp:Label ID="Label25" runat="server" Text="Essential drug list"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:CheckBox ID="uiCheckBoxEssentialDrugList" runat="server" />
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>

                                                <tr>
                                                    <td colspan="4" style="text-align: left">&nbsp;</td>
                                                    <td colspan="1" style="text-align: right"></td>

                                                    <td style="text-align: right">&nbsp;</td>

                                                </tr>

                                            </tbody>
                                        </table>
                                    </div>
                                    <div class="tab-pane" id="tab_1_6">
                                        <table style="width: 81%;">
                                            <tbody>
                                                <tr>
                                                    
                                                    <td style="width: 15%; height: 24px;">
                                                        <asp:Label ID="Label27" runat="server" Text="Sector type"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="uiDropDownListSectorType" runat="server"
                                                            Width="225px">
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                    <td></td><td></td><td></td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label28" runat="server" Text="Committe price"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxCommittePrice" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                    <td>
                                                        <asp:Label ID="Label29" runat="server" Text="Committe date"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <div class="controls">
                                                        <div class="input-append date date-picker" data-date="12-02-2012" data-date-format="dd/mm/yyyy" >
                                                            <asp:TextBox ID="uiTextBoxCommitteDate" runat="server" Width="220px"></asp:TextBox>
                                                            <span class="add-on"><i class="icon-calendar"></i></span>
                                                        </div>
                                                    </div>
                                                        

                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>Rational for pricing</td>
                                                    <td>

                                                        <asp:TextBox ID="uiTextBoxRationalForPricing" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                    <td>
                                                        <asp:Label ID="Label30" runat="server" Text="No. of it in the box"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxNoInBox" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>Lowest international Price of brand</td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxLowestIntPriceBrand" runat="server" Width="220px"></asp:TextBox>


                                                    </td>
                                                    <td>&nbsp;</td>
                                                    <td>
                                                        <asp:Label ID="Label31" runat="server" Text="Brand Price in Egypt"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxBrandPriceInEgy" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td colspan="4">
                                                        <asp:Label ID="Label32" runat="server" Text="Price after 30% reduction for referenced high tech imported generic"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxPriceAfter30" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td colspan="4">
                                                        <asp:Label ID="Label33" runat="server" Text="Price after 35% reduction for non referenced high tech imported generic"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxPriceAfter35" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td colspan="4">
                                                        <asp:Label ID="Label34" runat="server" Text="Price after 35% reduction for imported generic & 1st 5 generic"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxPriceAfter35FirstGeneric" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td colspan="4">
                                                        <asp:Label ID="Label35" runat="server" Text="Price after 40% reduction for imported generic & 2nd 5 generic"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxPriceAfter40ndGeneric" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>Lowest Price of the generic </td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxLowestPriceGeneric" runat="server" Width="220px"></asp:TextBox>


                                                    </td>
                                                    <td>&nbsp;</td>
                                                   <td></td><td></td><td></td>
                                                </tr>

                                                <tr>
                                                    <td colspan="4">Is the product priced according to 499 desicion</td>
                                                    <td>
                                                        <asp:CheckBox ID="uiCheckBoxIsPricedTo499" runat="server" />
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>

                                                <tr>
                                                    <td>Notes</td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxNotes_After" runat="server" Width="220px"></asp:TextBox>


                                                    </td>
                                                    <td>&nbsp;</td>
                                                    <td>
                                                        <asp:Label ID="Label38" runat="server" Text="Main group"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxMainGroup" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                   
                                                    <td>
                                                        <asp:Label ID="Label37" runat="server" Text="similar or not"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:CheckBox ID="uiCheckBoxSimilar" runat="server" />
                                                    </td>
                                                    <td>&nbsp;</td>
                                                    <td></td><td></td><td></td>
                                                </tr>
                                                <tr>
                                                    <td>Previous pack</td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxPreviouspack" runat="server" Width="220px"></asp:TextBox>


                                                    </td>
                                                    <td>&nbsp;</td>
                                                    <td>
                                                        <asp:Label ID="Label39" runat="server" Text="Previous price"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxPreviousPrice" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td colspan="4" style="text-align: left">&nbsp;</td>
                                                    <td colspan="1" style="text-align: right"></td>

                                                    <td style="text-align: right">&nbsp;</td>

                                                </tr>

                                            </tbody>
                                        </table>
                                    </div>
                                    <div class="tab-pane" id="tab_1_7">
                                        <table style="width: 81%;">
                                            <tbody>
                                                <tr>
                                                    <td style="width: 16%; height: 24px;">
                                                        <asp:Label ID="Label8" runat="server" Text="Approved price"></asp:Label>
                                                    </td>
                                                    <td style="width: 19%; height: 24px;">
                                                        <asp:TextBox ID="uiTextBoxApprovedPrice" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td style="width: 9%; height: 24px;">&nbsp;</td>
                                                    <td style="width: 15%; height: 24px;">
                                                        <asp:Label ID="Label10" runat="server" Text="Price category"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="uiTextBoxPriceCategory" runat="server" Width="220px"></asp:TextBox>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label11" runat="server" Text="Approval date"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <div class="controls">
                                                        <div class="input-append date date-picker" data-date="12-02-2012" data-date-format="dd/mm/yyyy" >
                                                            <asp:TextBox ID="uiTextBoxApprovalDate" runat="server" Width="220px"></asp:TextBox>
                                                            <span class="add-on"><i class="icon-calendar"></i></span>
                                                        </div>
                                                    </div>
                                                        
                                                    </td>
                                                    <td>&nbsp;</td>
                                                    <td>
                                                        <asp:Label ID="Label12" runat="server" Text="Issue date"></asp:Label>
                                                    </td>
                                                    <td>
                                                        <div class="controls">
                                                        <div class="input-append date date-picker" data-date="12-02-2012" data-date-format="dd/mm/yyyy" >
                                                            <asp:TextBox ID="uiTextBoxIssueDate" runat="server" Width="220px"></asp:TextBox>
                                                            <span class="add-on"><i class="icon-calendar"></i></span>
                                                        </div>
                                                    </div>
                                                        
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td>Scanned Sheet after minister approval </td>
                                                    <td colspan="5">


                                                        <iframe src="uiUpload.html?id=10" style="border: 0; width: 80%; overflow: hidden; height: 100px;"></iframe>                                                        
                                                        <asp:HiddenField ID="hf10" runat="server" ClientIDMode="Static" />

                                                    </td>

                                                </tr>

                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label15" runat="server" Text="Scanned Approval Letters "></asp:Label>
                                                    </td>
                                                    <td colspan="5">

                                                        <iframe src="uiUpload.html?id=11" style="border: 0; width: 80%; overflow: hidden; height: 100px;"></iframe>
                                                        <asp:HiddenField ID="hf11" runat="server" ClientIDMode="Static" />

                                                    </td>

                                                </tr>



                                            </tbody>
                                        </table>
                                    </div>
                                    <div class="tab-pane" id="tab_1_4">
                                        <div class="span10 block-margin-bottom-5">
                                            <div id="StatusHistory" data-template>
                                                <div class="span12 clearfix block-margin-bottom-5 {{CssClass}}" style="margin-left: 0; padding: 10px;">
                                                    <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0;">
                                                        <div class="span3"><b>{{Status}}</b></div>
                                                        <div class="span3">{{StatusDate | date DD-MM-YYYY}}</div>
                                                    </div>
                                                    <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0; display: {% if CommitteeTypeID == 0 %}none{% else %}block{% endif %}">
                                                        <div class="span3"><b>Committee</b></div>
                                                        <div class="span3">{{TypeText}}</div>
                                                        <div class="span3"><b>Committee Date</b></div>
                                                        <div class="span3">{{CommitteDate | date DD-MM-YYYY}}</div>
                                                    </div>
                                                    <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0; display: {% if CurrentPrice == 0 %}none{% else %}block{% endif %}">
                                                        <div class="span3"><b>Current Price</b></div>
                                                        <div class="span3">{{CurrentPrice}}</div>

                                                    </div>
                                                    <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0; display: {% if Comment == '' %}none{% else %}block{% endif %}">
                                                        <div class="span3"><b>Comment</b></div>
                                                        <div class="span3">{{Comment}}</div>

                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="span2">
                                            <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#StatusModal">Add status</button>
                                        </div>
                                        <div class="modal fade" id="StatusModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
                                            <div class="modal-dialog" role="document">
                                                <div class="modal-content">
                                                    <div class="modal-header">
                                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                                        <h4 class="modal-title" id="myModalLabel">Add Status</h4>
                                                    </div>
                                                    <div class="modal-body">
                                                        <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0px;">
                                                            <div class="span3">Status</div>
                                                            <div class="span6">
                                                                <select id="PricingStatus"></select>
                                                            </div>
                                                        </div>
                                                        <div class="span12 clearfix block-margin-bottom-5" id="tr_committee_1" style="margin-left: 0px;">
                                                            <div class="span3">Committee Type</div>
                                                            <div class="span6">
                                                                <select id="ui_drpCommitteeTypes">
                                                                    <option value="1">Evaluation Committee</option>
                                                                    <option value="2">Discussion Committee</option>
                                                                </select>
                                                            </div>
                                                        </div>
                                                        <div class="span12 clearfix block-margin-bottom-5" id="tr_committee_2" style="margin-left: 0px;">
                                                            <div class="span3">Committee Time</div>
                                                            <div class="span9">
                                                                <div class="controls">
                                                        <div class="input-append date date-picker" data-date="12-02-2012" data-date-format="dd/mm/yyyy" >
                                                            <input type="text" id="CommitteDate" style="width: 200px" />
                                                            <span class="add-on"><i class="icon-calendar"></i></span>
                                                        </div>
                                                    </div>
                                                                
                                                                &nbsp;
                                                                    Hours
                                                                    <select id="drpCommitteeHours" style="width: 60px">
                                                                        <option value="09">09</option>
                                                                        <option value="10">10</option>
                                                                        <option value="11">11</option>
                                                                        <option value="12">12</option>
                                                                        <option value="13">13</option>
                                                                        <option value="14">14</option>
                                                                        <option value="15">15</option>
                                                                        <option value="16">16</option>
                                                                        <option value="17">17</option>
                                                                        <option value="18">18</option>
                                                                        <option value="19">19</option>
                                                                        <option value="20">20</option>
                                                                    </select>
                                                                &nbsp;
                                                                    Minutes
                                                                    <select id="drpCommitteeMinutes" style="width: 60px">
                                                                        <option value="00">00</option>
                                                                        <option value="15">15</option>
                                                                        <option value="30">30</option>
                                                                        <option value="45">45</option>
                                                                    </select>
                                                            </div>
                                                        </div>
                                                        <div class="span12 clearfix block-margin-bottom-5" style="margin-left: 0px;">
                                                            <div class="span3">Comment</div>
                                                            <div class="span6">
                                                                <textarea id="Comment" style="width: 100%;" rows="4"></textarea>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="modal-footer">
                                                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                                        <button type="button" class="btn btn-primary" onclick="AddStatus()">Save changes</button>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div id="drugloading">
                                    <div class="span6 center" style="margin:0 auto;float:none;text-align:center">
                                    
                                    <img src="Images/loading.gif" /><br /><br />
                                        <div id="loadingMsg">Loading ...</div>
                                        </div>
                                </div>
                                 </div>

                            <div class="space10"></div>
                            <div class="span12 clearfix block-margin-bottom-5 no-margin ">
                                <div class="span2">
                                </div>
                                <div class="span2">
                                    <asp:LinkButton ID="uiLinkButtonSave" runat="server" CssClass="btn btn-primary" OnClick="uiLinkButtonSave_Click" ValidationGroup="add">Save</asp:LinkButton>
                                </div>
                            </div>
                        </div>

                        <div class="modal fade hide" id="PackageModal" tabindex="-1" role="dialog">
                            <div class="modal-dialog">
                                <div class="modal-content">
                                    <div class="modal-header">                    
                                       <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                        <h4 class="modal-title" id="PackageModalLabel">Add new package</h4>
                                    </div>
                                    <div class="modal-body">
                                        
                                            <iframe src="addpackage.aspx" style="width:100%;height:400px;overflow:hidden;border:0" id="pFrame"></iframe>
                                        
                                        </div>
                                </div>
                                <!-- /.modal-content -->
                            </div>
                            <!-- /.modal-dialog -->
                        </div>

                        <div class="modal fade" id="ErrorModal">
                            <div class="modal-dialog">
                                <div class="modal-content">
                                    <div class="modal-header">                    
                                       <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                        <h4 class="modal-title" id="ErrorModalLabel">Error</h4>
                                    </div>
                                    <div class="modal-body">
                                        <div class="span12 clearfix block-margin-bottom-5 alert alert-danger" style="margin-left: 0px;">
                                            <div id="errorDiv"></div>
                                        </div>
                                        </div>
                                </div>
                                <!-- /.modal-content -->
                            </div>
                            <!-- /.modal-dialog -->
                        </div>  


                        
                    </div>
                </div>
            </div>
        </div>
     </div>
</asp:Content>
