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
    <script type="text/javascript">
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
                     $('#uiHiddenFieldDrugID').attr('value', item.id);
                     $('#selectDrug').show();
                     return item.name;
                 }
            });
        });


        function SearchDrugs() {
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
            var html = '<a style="display:block;margin:0 auto;" target="_blank" onclick="getPricingInfo(' + row + ')" class="btn btn-default">Select</a>';
            return html;
        }

        function getPackInfo(row) {
            $('#PackInfoGrid').show();
            $('#loadingMsg').html("Loading package details info ...");
            var datarow = $("#jqxgrid").jqxGrid('getrowdata', row);
            $('uiHiddenFieldDrugID').val(datarow.TradeCode);
            try {
                $('#packagejqxgrid').jqxGrid('destroy');
            } catch (e) {

            }

            $('#PackInfoGrid').append("<div id='packagejqxgrid'></div>");

            var source =
            {
                datatype: "json",
                datafields: [
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

        function getPricingInfo(row) {
            $('#gridHolder').fadeOut(200);
            $('#PackInfoGrid').fadeOut(200);

            var datarow = $("#packagejqxgrid").jqxGrid('getrowdata', row);

            $('#druginfotabs').fadeIn(300).delay(500);
            $('#loadingMsg').html("Loading drug info ...");
            $('#drugloading').show();
            
            $.ajax({
                url: 'services/PricingService.asmx/GetTradeDrugById',
                type: 'POST',
                dataType: 'JSON',
                data: 'id=' + $('#uiHiddenFieldDrugID').val(),
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
                    
                    getGenerics();
                    
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
                    id: $('#uiHiddenFieldDrugID').val(),
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


        function SetAttachment(id, value)
        {            
            $('#hf' + id).val(value);            
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
                        <div class="span12 clearfix">
                            <div class="span2">Drug trade name</div>
                            <div class="span4">
                                <asp:TextBox ID="uiTextBoxDrugs" runat="server" ></asp:TextBox>
                                <input type="hidden" id="uiHiddenFieldDrugID" />
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

                        <div class="span12 clearfix" id="gridHolder" style="margin-left:0px;display:none;">
                        <h4>Available drugs</h4>    
                        </div>

                        <div id="PackInfoGrid" class="span12 clearfix block-margin-bottom-5" style="margin-left:0px;display:none;">
                            <h4>Available packages</h4>    
                        </div>

                        <div class="span12 clearfix" id="druginfotabs" style="display:none;margin-left:0px;" >
                           
                            <div class="tabbable tabbable-custom" style="position:relative;">
                                    <ul class="nav nav-tabs">
                                       <li class="active"><a href="#tab_1_1" data-toggle="tab">Drug info</a></li>
                                       <%--<li><a href="#tab_1_2" data-toggle="tab">Packages info</a></li>--%>
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
                                                        <td style="width: 9%; height: 24px;">
                                                            
                                                        </td>
                                                        <td style="width: 15%; height: 24px;">
                                                            <asp:Label ID="Label5" runat="server" Text="Dosage Form"></asp:Label>
                                                        </td>
                                                        <td>                                                           
                                                            <asp:TextBox ID="ui_txtDosageForm" runat="server" Width="220px" Enabled="false"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                           
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label2" runat="server" Text="Applicant"></asp:Label>
                                                        </td>
                                                        <td>
                                                            
                                                            <asp:TextBox ID="ui_txtCompanies" runat="server" Width="220px" Enabled="false"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label6" runat="server" Text="Strength"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txt_strength" runat="server"  Width="220px" Enabled="false"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                           
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            Product Type :	
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txt_prodType" runat="server"  Width="220px" Enabled="false"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                           
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                   
                                                </tbody>
                                            </table>
                                           <hr style="width:100%" />
                                           <h4>Registration Details </h4>
                                           <div class="span12 clearfix block-margin-bottom-5" style="margin-left:0px;">
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
                                                        <td>
                                                           Licensor Holder
                                                        </td>
                                                    </tr>
                                                   <tr>
                                                        
                                                        <td>                                                           
                                                            <asp:Label ID="TextBox2_comp" runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                           Manufacturer
                                                        </td>
                                                    </tr><tr>
                                                        
                                                        <td>                                                           
                                                            <asp:Label ID="TextBox3_comp" runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                           Packager
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        
                                                        <td>                                                           
                                                            <asp:Label ID="TextBox4_comp" runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                           Batch Releaser
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        
                                                        <td>                                                           
                                                            <asp:Label ID="TextBox5_comp" runat="server"></asp:Label>
                                                        </td>
                                                        <td>
                                                           Storage Site
                                                        </td>
                                                    </tr>
                                                   
                                                </tbody>
                                            </table>
                                          </div>

                                           <div class="span12 clearfix " style="margin-left:0px;">
                                           <div class="span2 " style="margin-left:0px;">   
                                                            <asp:Label ID="Label3" runat="server" Text="Registration No :"></asp:Label>
                                                        </div>
                                               <div class="span4" style="margin-left:0px;">   
                                                            <asp:TextBox ID="txt_regNo" runat="server" Width="220px" Enabled="false"></asp:TextBox>
                                                        </div>
                                               <div class="span2" style="margin-left:0px;">   
                                                            <asp:Label ID="Label4" runat="server" Text="Registration Type :"></asp:Label>
                                                                                                        </div>
                                               <div class="span4" style="margin-left:0px;">              
                                                            <asp:TextBox ID="txt_regType" runat="server" Width="220px" Enabled="false"></asp:TextBox>
                                                        </div>
                                           </div>
                                           <hr style="width:100%" />
                                           <h4>Generics </h4>
                                           <div class="span12 clearfix" style="margin-left:0px;">
                                               <div id="genericsGrid"></div>
                                           </div>
                                       </div>
                                       <%--<div class="tab-pane" id="tab_1_2">
                                          
                                       </div>--%>
                                       <div class="tab-pane" id="tab_1_3">
                                          <div class="span12 clearfix block-margin-bottom-5" style="margin-left:0">
                                              <div class="span2">Covering Letter</div>
                                              <div class="span10">
                                                  <iframe src="uiUpload.html?id=1" style="border: 0; width: 80%; overflow: hidden; height: 100px;"></iframe>
                                                  <input type="hidden" id="hf1" />
                                              </div>
                                          </div>
                                          
                                           <div class="span12 clearfix block-margin-bottom-5" style="margin-left:0">
                                              <div class="span2">Box Approval Letter</div>
                                              <div class="span10">
                                                  <iframe src="uiUpload.html?id=2" style="border: 0; width: 80%; overflow: hidden; height: 100px;"></iframe>
                                                  <input type="hidden" id="hf2" />
                                              </div>
                                          </div>
                                           <div class="span12 clearfix block-margin-bottom-5" style="margin-left:0">
                                              <div class="span2">Trade Name Approval Letter</div>
                                              <div class="span10">
                                                  <iframe src="uiUpload.html?id=3" style="border: 0; width: 80%; overflow: hidden; height: 100px;"></iframe>
                                                  <input type="hidden" id="hf3" />
                                              </div>
                                          </div>
                                           <div class="span12 clearfix block-margin-bottom-5" style="margin-left:0">
                                              <div class="span2">Cost Sheet</div>
                                              <div class="span10">
                                                  <iframe src="uiUpload.html?id=4" style="border: 0; width: 80%; overflow: hidden; height: 100px;"></iframe>
                                                  <input type="hidden" id="hf4" />
                                              </div>
                                          </div>
                                           <div class="span12 clearfix block-margin-bottom-5" style="margin-left:0">
                                              <div class="span2">Proforma invoice</div>
                                              <div class="span10">
                                                  <iframe src="uiUpload.html?id=5" style="border: 0; width: 80%; overflow: hidden; height: 100px;"></iframe>
                                                  <input type="hidden" id="hf5" />
                                              </div>
                                          </div>
                                           <div class="span12 clearfix block-margin-bottom-5" style="margin-left:0">
                                              <div class="span2">CIF Price To Egypt </div>
                                              <div class="span10">
                                                  <iframe src="uiUpload.html?id=6" style="border: 0; width: 80%; overflow: hidden; height: 100px;"></iframe>
                                                  <input type="hidden" id="hf6" />
                                              </div>
                                          </div>
                                           <div class="span12 clearfix block-margin-bottom-5" style="margin-left:0">
                                              <div class="span2">Price of Product in the country of origin</div>
                                              <div class="span10">
                                                  <iframe src="uiUpload.html?id=7" style="border: 0; width: 80%; overflow: hidden; height: 100px;"></iframe>
                                                  <input type="hidden" id="hf7" />
                                              </div>
                                          </div> 
                                           <div class="span12 clearfix block-margin-bottom-5" style="margin-left:0">
                                              <div class="span2">Country Prices of the Product </div>
                                              <div class="span10">
                                                  <iframe src="uiUpload.html?id=8" style="border: 0; width: 80%; overflow: hidden; height: 100px;"></iframe>
                                                  <input type="hidden" id="hf8" />
                                              </div>
                                          </div>
                                           <div class="span12 clearfix block-margin-bottom-5" style="margin-left:0">
                                              <div class="span2">Product Pack or Artwork and leaflet</div>
                                              <div class="span10">
                                                  <iframe src="uiUpload.html?id=9" style="border: 0; width: 80%; overflow: hidden; height: 100px;"></iframe>
                                                  <input type="hidden" id="hf9" />
                                              </div>
                                          </div>
                                          
                                       </div>
                                       
                                       <div class="tab-pane" id="tab_1_5">
                                           <table style="width: 81%;">
                                               <tbody>
                                                   <tr>
                                                       <td style="width: 16%; height: 24px;">
                                                           <asp:Label ID="Label7" runat="server" Text="Reg. No."></asp:Label>
                                                       </td>
                                                       <td style="width: 19%; height: 24px;">
                                                           <asp:TextBox ID="uiTextBoxBeforeRegNo" runat="server" Width="220px"></asp:TextBox>
                                                       </td>
                                                       <td style="width: 9%; height: 24px;">&nbsp;</td>
                                                       <td style="width: 15%; height: 24px;">
                                                           <asp:Label ID="Label9" runat="server" Text="Sector type"></asp:Label>
                                                       </td>
                                                       <td>
                                                           <asp:DropDownList ID="uiDropDownListSectorType_Before" runat="server"
                                                               Width="225px">
                                                           </asp:DropDownList>
                                                       </td>
                                                       <td>&nbsp;</td>
                                                   </tr>
                                                   <tr>
                                                       <td>
                                                           <asp:Label ID="Label16" runat="server" Text="License Type"></asp:Label>
                                                       </td>
                                                       <td>
                                                           <asp:DropDownList ID="uiDropDownListLicenseType" runat="server" Width="225px">
                                                           </asp:DropDownList>
                                                       </td>
                                                       <td>&nbsp;</td>
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
                                                       <td colspan="1" style="text-align: right">
                                                          
                                                       </td>

                                                       <td style="text-align: right">&nbsp;</td>

                                                   </tr>

                                               </tbody>
                                           </table>
                                       </div>
                                       <div class="tab-pane" id="tab_1_6">
                                           <table style="width: 81%;">
                                               <tbody>
                                                   <tr>
                                                       <td style="width: 16%; height: 24px;">
                                                           <asp:Label ID="Label26" runat="server" Text="Reg. No."></asp:Label>
                                                       </td>
                                                       <td style="width: 19%; height: 24px;">
                                                           <asp:TextBox ID="uiTextBoxRegNoAfter" runat="server" Width="220px"></asp:TextBox>
                                                       </td>
                                                       <td style="width: 9%; height: 24px;">&nbsp;</td>
                                                       <td style="width: 15%; height: 24px;">
                                                           <asp:Label ID="Label27" runat="server" Text="Sector type"></asp:Label>
                                                       </td>
                                                       <td>
                                                           <asp:DropDownList ID="uiDropDownListSectorType" runat="server"
                                                               Width="225px">
                                                           </asp:DropDownList>
                                                       </td>
                                                       <td>&nbsp;</td>
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
                                                           <asp:TextBox ID="uiTextBoxCommitteDate" runat="server" Width="220px"></asp:TextBox>
                                                           
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
                                                       <td>
                                                           <asp:Label ID="Label36" runat="server" Text="Final Price"></asp:Label>
                                                       </td>
                                                       <td>
                                                           <asp:TextBox ID="uiTextBoxFinalPrice" runat="server" Width="220px"></asp:TextBox>
                                                       </td>
                                                       <td>&nbsp;</td>
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
                                                           <asp:TextBox ID="uiTextBoxNotes" runat="server" Width="220px"></asp:TextBox>


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
                                                       <td>Month</td>
                                                       <td>
                                                           <asp:TextBox ID="uiTextBoxMonth" runat="server" Width="220px"></asp:TextBox>


                                                       </td>
                                                       <td>&nbsp;</td>
                                                       <td>
                                                           <asp:Label ID="Label37" runat="server" Text="similar or not"></asp:Label>
                                                       </td>
                                                       <td>
                                                           <asp:CheckBox ID="uiCheckBoxSimilar" runat="server" />
                                                       </td>
                                                       <td>&nbsp;</td>
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
                                                       <td colspan="1" style="text-align: right">
                                                         

                                                       </td>

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
                                                          <asp:TextBox ID="uiTextBoxApprovalDate" runat="server" Width="220px"></asp:TextBox>
                                                       </td>
                                                       <td>&nbsp;</td>
                                                       <td>
                                                           <asp:Label ID="Label12" runat="server" Text="Issue date"></asp:Label>
                                                       </td>
                                                       <td>
                                                           <asp:TextBox ID="uiTextBoxIssueDate" runat="server" Width="220px"></asp:TextBox>
                                                       </td>
                                                       <td>&nbsp;</td>
                                                   </tr>
                                                   <tr>
                                                       <td>Scanned Sheet after minister approval </td>
                                                       <td colspan="5">

                                                         
                                                  <iframe src="uiUpload.html?id=after_1" style="border: 0; width: 80%; overflow: hidden; height: 100px;"></iframe>
                                                  <input type="hidden" id="hf1_after" />
                                              
                                                       </td>
                                                       
                                                   </tr>
                                                   
                                                   <tr>
                                                       <td>
                                                           <asp:Label ID="Label15" runat="server" Text="Scanned Approval Letters "></asp:Label>
                                                       </td>
                                                       <td colspan="5">
                                                               
                                                  <iframe src="uiUpload.html?id=after_2" style="border: 0; width: 80%; overflow: hidden; height: 100px;"></iframe>
                                                  <input type="hidden" id="hf2_after" />
                                               
                                                       </td>
                                                       
                                                   </tr>

                                                   

                                               </tbody>
                                           </table>
                                       </div> 
                                        <div class="tab-pane" id="tab_1_4">
                                          
                                       </div>
                                    </div>
                                <div id="drugloading">
                                    <div class="span6 center" style="margin:0 auto;float:none;text-align:center">
                                    
                                    <img src="Images/loading.gif" /><br /><br />
                                        <div id="loadingMsg">Loading ...</div>
                                        </div>
                                </div>
                                 </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
     </div>
</asp:Content>
