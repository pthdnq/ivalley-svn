$(document).ready(function () {
   
    PrepareDesignTab();
    PrepareGiveAwaysTab();
    // get designers 
   /* var designers;
    $.ajax({
        url: 'common/commonMethods.asmx/GetJODesigners',
        async: false,
        success: function (json) {
            designers = json;
        }
    });

    // get status 
    var statuses;
    $.ajax({
        url: 'common/commonMethods.asmx/GetJOStatuses',
        async: false,
        success: function (json) {
            statuses = json;
        }
    });*/

    
    /*$('#OffsetGrid').jqxGrid();
    $('#InOutDoorGrid').jqxGrid();
    $('#GiveawaysGrid').jqxGrid();
    
    */

    $('.checkSections').click(function () {
        ViewSections();
    });

    ViewSections();
});

function PrepareDesignTab() {
    var Designersource =
    {
        datatype: "json",
        datafields: [
            { name: 'DesignerID', type: 'number' },
            { name: 'DesignerName', type: 'string' },
            { name: 'Email', type: 'string' },
            { name: 'CategoryID', type: 'number' },
            { name: 'Address', type: 'string' },
            { name: 'Telephone', type: 'string' },
        ],
        id: 'DesignerID',
        url: "common/commonMethods.asmx/GetJODesigners"
    };

    var DesignerdataAdapter = new $.jqx.dataAdapter(Designersource);

    var Statussource =
    {
        datatype: "json",
        datafields: [
            { name: 'StatusID', type: 'number' },
            { name: 'StatusName', type: 'string' },
            { name: 'StatusNameAr', type: 'string' },
            { name: 'StatusClass', type: 'string' }
        ],
        id: 'StatusID',
        url: "common/commonMethods.asmx/GetJOStatuses"
    };

    var StatusdataAdapter = new $.jqx.dataAdapter(Statussource);


    var JODesignsource =
    {
        datatype: "json",
        datafields: [
            { name: 'DesignDetailsID', type: 'number' },
            { name: 'DesignerName', value: 'DesignerID', values: { source: DesignerdataAdapter.records, value: 'DesignerID', name: 'DesignerName' } },
            { name: 'StartDate', type: 'date' },
            { name: 'EndDate', type: 'date' },
            { name: 'StatusClass', value: 'StatusID', values: { source: StatusdataAdapter.records, value: 'StatusID', name: 'StatusClass' } },
            { name: 'StatusNameAr', value: 'StatusID', values: { source: StatusdataAdapter.records, value: 'StatusID', name: 'StatusNameAr' } }
        ],
        url: "common/commonMethods.asmx/GetDesignDetails?ID=" + $('#uiHiddenFieldCurrentJO').val()
    };

    var dataAdapter = new $.jqx.dataAdapter(JODesignsource);


    $('#DesignGrid').jqxGrid(
        {
            width: '100%',
            source: dataAdapter,
            filterable: false,
            showeverpresentrow: true,
            enablebrowserselection: true,
            everpresentrowposition: "bottom",
            everpresentrowactionsmode: "columns",
            editable: true,
            autoheight: true,
            rtl: true,
            localization: getLocalization('ar'),
            selectionmode: 'checkbox',
            columns: [
                {
                    text: 'DesignDetailsID', columntype: 'textbox', datafield: 'DesignDetailsID', hidden: true,

                },

                 {
                     text: 'المصمم', datafield: 'DesignerName', columntype: 'dropdownlist', cellsalign: 'center', align: 'center', width: '22%',
                     createeditor: function (row, column, editor) {
                         editor.jqxDropDownList({ rtl: true, source: DesignerdataAdapter, autoOpen: true, displayMember: 'DesignerName', valueMember: 'DesignerID', placeHolder: "إختر  " });
                     },
                     createEverPresentRowWidget: function (datafield, htmlElement, popup, addCallback) {
                         var inputTag = $("<div style='border: none;float:right;width:100%'></div>").appendTo(htmlElement);
                         inputTag.jqxDropDownList({ rtl: true, popupZIndex: 99999999, placeHolder: "إختر ", source: DesignerdataAdapter, displayMember: 'DesignerName', valueMember: 'DesignerID' });
                         $(document).on('keydown.productname', function (event) {
                             if (event.keyCode == 13) {
                                 if (event.target === inputTag[0]) {
                                     addCallback();
                                 }
                                 else if ($(event.target).ischildof(inputTag)) {
                                     addCallback();
                                 }
                             }
                         });
                         return inputTag;
                     },
                     validateEverPresentRowWidgetValue: function (datafield, value, rowValues) {
                         if (value == 0) {
                             return { message: "يجب إختيار أحد المصممين", result: false };
                         }
                         return true;
                     },
                     getEverPresentRowWidgetValue: function (datafield, htmlElement, validate) {
                         var selectedItem = htmlElement.jqxDropDownList('getSelectedItem');
                         if (!selectedItem)
                             return "";

                         var value = selectedItem.label;
                         return value;
                     },
                     resetEverPresentRowWidgetValue: function (datafield, htmlElement) {
                         htmlElement.jqxDropDownList('clearSelection');
                     }

                 },
                {
                    text: 'التاريخ : من ', cellsalign: 'center', align: 'center', datafield: 'StartDate', width: '24%', cellsformat: 'dd/MM/yyyy', formatString: 'dd/MM/yyyy', columntype: 'datetimeinput',
                    createEverPresentRowWidget: function (datafield, htmlElement, popup, addCallback) {
                        var inputTag = $("<div style='border: none;'></div>").appendTo(htmlElement);
                        inputTag.jqxDateTimeInput({ value: null, popupZIndex: 99999999, placeHolder: "إختر التاريخ ", width: '100%', height: 30, formatString: 'dd/MM/yyyy' });
                        $(document).on('keydown.date', function (event) {
                            if (event.keyCode == 13) {
                                if (event.target === inputTag[0]) {
                                    addCallback();
                                }
                                else if ($(event.target).ischildof(inputTag)) {
                                    addCallback();
                                }
                            }
                        });
                        return inputTag;
                    },
                    initEverPresentRowWidget: function (datafield, htmlElement) {
                    },
                    getEverPresentRowWidgetValue: function (datafield, htmlElement, validate) {
                        var value = htmlElement.val();
                        return value;
                    },
                    resetEverPresentRowWidgetValue: function (datafield, htmlElement) {
                        htmlElement.val(null);
                    }
                },
                {
                    text: 'إلى', datafield: 'EndDate', width: '24%', cellsalign: 'center', align: 'center', cellsformat: 'dd/MM/yyyy', formatString: 'dd/MM/yyyy', columntype: 'datetimeinput',
                    createEverPresentRowWidget: function (datafield, htmlElement, popup, addCallback) {
                        var inputTag = $("<div style='border: none;;float:right;width:100%'></div>").appendTo(htmlElement);
                        inputTag.jqxDateTimeInput({ value: null, popupZIndex: 99999999, placeHolder: "إختر التاريخ ", width: '100%', height: 30, formatString: 'dd/MM/yyyy' });
                        $(document).on('keydown.date', function (event) {
                            if (event.keyCode == 13) {
                                if (event.target === inputTag[0]) {
                                    addCallback();
                                }
                                else if ($(event.target).ischildof(inputTag)) {
                                    addCallback();
                                }
                            }
                        });
                        return inputTag;
                    },
                    initEverPresentRowWidget: function (datafield, htmlElement) {
                    },
                    getEverPresentRowWidgetValue: function (datafield, htmlElement, validate) {
                        var value = htmlElement.val();
                        return value;
                    },
                    resetEverPresentRowWidgetValue: function (datafield, htmlElement) {
                        htmlElement.val(null);
                    }
                }
                ,

                 {
                     text: 'الحالة', cellsalign: 'center', align: 'center', datafield: 'StatusNameAr', columntype: 'dropdownlist',
                     createeditor: function (row, column, editor) {
                         editor.jqxDropDownList({ rtl: true, source: StatusdataAdapter, autoOpen: true, displayMember: 'StatusNameAr', valueMember: 'StatusID', placeHolder: "إختر  " });
                     },
                     createEverPresentRowWidget: function (datafield, htmlElement, popup, addCallback) {
                         var inputTag = $("<div style='border: none;'></div>").appendTo(htmlElement);
                         inputTag.jqxDropDownList({ rtl: true, popupZIndex: 99999999, placeHolder: "إختر  ", source: StatusdataAdapter, displayMember: 'StatusNameAr', valueMember: 'StatusID' });
                         $(document).on('keydown.productname', function (event) {
                             if (event.keyCode == 13) {
                                 if (event.target === inputTag[0]) {
                                     addCallback();
                                 }
                                 else if ($(event.target).ischildof(inputTag)) {
                                     addCallback();
                                 }
                             }
                         });
                         return inputTag;
                     },
                     validateEverPresentRowWidgetValue: function (datafield, value, rowValues) {
                         if (value == 0) {
                             return { message: "يجب إختيار أحد الحالات", result: false };
                         }
                         return true;
                     },
                     getEverPresentRowWidgetValue: function (datafield, htmlElement, validate) {
                         var selectedItem = htmlElement.jqxDropDownList('getSelectedItem');
                         if (!selectedItem)
                             return "";

                         var value = selectedItem.label;
                         return value;
                     },
                     resetEverPresentRowWidgetValue: function (datafield, htmlElement) {
                         htmlElement.jqxDropDownList('clearSelection');
                     }

                 },

            ]

        });
}


function PrepareDigitalTab() {
    var Designersource =
    {
        datatype: "json",
        datafields: [
            { name: 'DesignerID', type: 'number' },
            { name: 'DesignerName', type: 'string' },
            { name: 'Email', type: 'string' },
            { name: 'CategoryID', type: 'number' },
            { name: 'Address', type: 'string' },
            { name: 'Telephone', type: 'string' },
        ],
        id: 'DesignerID',
        url: "common/commonMethods.asmx/GetJODesigners"
    };

    var DesignerdataAdapter = new $.jqx.dataAdapter(Designersource);

    var Statussource =
    {
        datatype: "json",
        datafields: [
            { name: 'StatusID', type: 'number' },
            { name: 'StatusName', type: 'string' },
            { name: 'StatusNameAr', type: 'string' },
            { name: 'StatusClass', type: 'string' }
        ],
        id: 'StatusID',
        url: "common/commonMethods.asmx/GetJOStatuses"
    };

    var StatusdataAdapter = new $.jqx.dataAdapter(Statussource);


    var JODesignsource =
    {
        datatype: "json",
        datafields: [
            { name: 'DesignDetailsID', type: 'number' },
            { name: 'DesignerName', value: 'DesignerID', values: { source: DesignerdataAdapter.records, value: 'DesignerID', name: 'DesignerName' } },
            { name: 'StartDate', type: 'date' },
            { name: 'EndDate', type: 'date' },
            { name: 'StatusClass', value: 'StatusID', values: { source: StatusdataAdapter.records, value: 'StatusID', name: 'StatusClass' } },
            { name: 'StatusNameAr', value: 'StatusID', values: { source: StatusdataAdapter.records, value: 'StatusID', name: 'StatusNameAr' } }
        ],
        url: "common/commonMethods.asmx/GetDesignDetails?ID=" + $('#uiHiddenFieldCurrentJO').val()
    };

    var dataAdapter = new $.jqx.dataAdapter(JODesignsource);


    $('#DesignGrid').jqxGrid(
        {
            width: '100%',
            source: dataAdapter,
            filterable: false,
            showeverpresentrow: true,
            enablebrowserselection: true,
            everpresentrowposition: "bottom",
            everpresentrowactionsmode: "columns",
            editable: true,
            autoheight: true,
            rtl: true,
            localization: getLocalization('ar'),
            selectionmode: 'checkbox',
            columns: [
                {
                    text: 'DesignDetailsID', columntype: 'textbox', datafield: 'DesignDetailsID', hidden: true,

                },

                 {
                     text: 'المصمم', datafield: 'DesignerName', columntype: 'dropdownlist', cellsalign: 'center', align: 'center', width: '22%',
                     createeditor: function (row, column, editor) {
                         editor.jqxDropDownList({ rtl: true, source: DesignerdataAdapter, autoOpen: true, displayMember: 'DesignerName', valueMember: 'DesignerID', placeHolder: "إختر  " });
                     },
                     createEverPresentRowWidget: function (datafield, htmlElement, popup, addCallback) {
                         var inputTag = $("<div style='border: none;float:right;width:100%'></div>").appendTo(htmlElement);
                         inputTag.jqxDropDownList({ rtl: true, popupZIndex: 99999999, placeHolder: "إختر ", source: DesignerdataAdapter, displayMember: 'DesignerName', valueMember: 'DesignerID' });
                         $(document).on('keydown.productname', function (event) {
                             if (event.keyCode == 13) {
                                 if (event.target === inputTag[0]) {
                                     addCallback();
                                 }
                                 else if ($(event.target).ischildof(inputTag)) {
                                     addCallback();
                                 }
                             }
                         });
                         return inputTag;
                     },
                     validateEverPresentRowWidgetValue: function (datafield, value, rowValues) {
                         if (value == 0) {
                             return { message: "يجب إختيار أحد المصممين", result: false };
                         }
                         return true;
                     },
                     getEverPresentRowWidgetValue: function (datafield, htmlElement, validate) {
                         var selectedItem = htmlElement.jqxDropDownList('getSelectedItem');
                         if (!selectedItem)
                             return "";

                         var value = selectedItem.label;
                         return value;
                     },
                     resetEverPresentRowWidgetValue: function (datafield, htmlElement) {
                         htmlElement.jqxDropDownList('clearSelection');
                     }

                 },
                {
                    text: 'التاريخ : من ', cellsalign: 'center', align: 'center', datafield: 'StartDate', width: '24%', cellsformat: 'dd/MM/yyyy', formatString: 'dd/MM/yyyy', columntype: 'datetimeinput',
                    createEverPresentRowWidget: function (datafield, htmlElement, popup, addCallback) {
                        var inputTag = $("<div style='border: none;'></div>").appendTo(htmlElement);
                        inputTag.jqxDateTimeInput({ value: null, popupZIndex: 99999999, placeHolder: "إختر التاريخ ", width: '100%', height: 30, formatString: 'dd/MM/yyyy' });
                        $(document).on('keydown.date', function (event) {
                            if (event.keyCode == 13) {
                                if (event.target === inputTag[0]) {
                                    addCallback();
                                }
                                else if ($(event.target).ischildof(inputTag)) {
                                    addCallback();
                                }
                            }
                        });
                        return inputTag;
                    },
                    initEverPresentRowWidget: function (datafield, htmlElement) {
                    },
                    getEverPresentRowWidgetValue: function (datafield, htmlElement, validate) {
                        var value = htmlElement.val();
                        return value;
                    },
                    resetEverPresentRowWidgetValue: function (datafield, htmlElement) {
                        htmlElement.val(null);
                    }
                },
                {
                    text: 'إلى', datafield: 'EndDate', width: '24%', cellsalign: 'center', align: 'center', cellsformat: 'dd/MM/yyyy', formatString: 'dd/MM/yyyy', columntype: 'datetimeinput',
                    createEverPresentRowWidget: function (datafield, htmlElement, popup, addCallback) {
                        var inputTag = $("<div style='border: none;;float:right;width:100%'></div>").appendTo(htmlElement);
                        inputTag.jqxDateTimeInput({ value: null, popupZIndex: 99999999, placeHolder: "إختر التاريخ ", width: '100%', height: 30, formatString: 'dd/MM/yyyy' });
                        $(document).on('keydown.date', function (event) {
                            if (event.keyCode == 13) {
                                if (event.target === inputTag[0]) {
                                    addCallback();
                                }
                                else if ($(event.target).ischildof(inputTag)) {
                                    addCallback();
                                }
                            }
                        });
                        return inputTag;
                    },
                    initEverPresentRowWidget: function (datafield, htmlElement) {
                    },
                    getEverPresentRowWidgetValue: function (datafield, htmlElement, validate) {
                        var value = htmlElement.val();
                        return value;
                    },
                    resetEverPresentRowWidgetValue: function (datafield, htmlElement) {
                        htmlElement.val(null);
                    }
                }
                ,

                 {
                     text: 'الحالة', cellsalign: 'center', align: 'center', datafield: 'StatusNameAr', columntype: 'dropdownlist',
                     createeditor: function (row, column, editor) {
                         editor.jqxDropDownList({ rtl: true, source: StatusdataAdapter, autoOpen: true, displayMember: 'StatusNameAr', valueMember: 'StatusID', placeHolder: "إختر  " });
                     },
                     createEverPresentRowWidget: function (datafield, htmlElement, popup, addCallback) {
                         var inputTag = $("<div style='border: none;'></div>").appendTo(htmlElement);
                         inputTag.jqxDropDownList({ rtl: true, popupZIndex: 99999999, placeHolder: "إختر  ", source: StatusdataAdapter, displayMember: 'StatusNameAr', valueMember: 'StatusID' });
                         $(document).on('keydown.productname', function (event) {
                             if (event.keyCode == 13) {
                                 if (event.target === inputTag[0]) {
                                     addCallback();
                                 }
                                 else if ($(event.target).ischildof(inputTag)) {
                                     addCallback();
                                 }
                             }
                         });
                         return inputTag;
                     },
                     validateEverPresentRowWidgetValue: function (datafield, value, rowValues) {
                         if (value == 0) {
                             return { message: "يجب إختيار أحد الحالات", result: false };
                         }
                         return true;
                     },
                     getEverPresentRowWidgetValue: function (datafield, htmlElement, validate) {
                         var selectedItem = htmlElement.jqxDropDownList('getSelectedItem');
                         if (!selectedItem)
                             return "";

                         var value = selectedItem.label;
                         return value;
                     },
                     resetEverPresentRowWidgetValue: function (datafield, htmlElement) {
                         htmlElement.jqxDropDownList('clearSelection');
                     }

                 },

            ]

        });
}

function PrepareGiveAwaysTab() {
    
    var JOGiveAwayssource =
    {
        datatype: "json",
        datafields: [
            { name: 'GiveawayID', type: 'number' },
            { name: 'ItemName', type:'string' },
            { name: 'GiveawayDescription', type: 'string' },
            { name: 'GiveawayQuantity', type: 'number' },
            { name: 'PricePerItem', type:'' },            
        ],
        url: "common/commonMethods.asmx/GetGiveAwayDetails?ID=" + $('#uiHiddenFieldCurrentJO').val()
    };

    var GAdataAdapter = new $.jqx.dataAdapter(JOGiveAwayssource);


    $('#GiveawaysGrid').jqxGrid(
        {
            width: '100%',
            source: GAdataAdapter,
            filterable: false,
            showeverpresentrow: true,
            enablebrowserselection: true,
            everpresentrowposition: "bottom",
            everpresentrowactionsmode: "columns",
            editable: true,
            autoheight: true,
            rtl: true,
            localization: getLocalization('ar'),
            selectionmode: 'checkbox',
            columns: [
                {
                    text: 'GiveawayID', columntype: 'textbox', datafield: 'DesignDetailsID', hidden: true,
                },

                 {
                     text: 'الصنف', datafield: 'ItemName', columntype: 'textbox', cellsalign: 'center', align: 'center', width: '22%'

                 },
                 {
                     text: 'الوصف', datafield: 'GiveawayDescription', columntype: 'textbox', cellsalign: 'center', align: 'center', width: '22%'

                 },
                 {
                     text: 'الكمية', datafield: 'GiveawayQuantity', cellsalign: 'center', align: 'center', width: '22%', columntype: 'numberinput',
                     validation: function (cell, value) {
                         if (value <= 0 ) {
                             return { result: false, message: "الكمية يجب أن تكون أكبر من صفر(0)" };
                         }
                         return true;
                     },
                     createeditor: function (row, cellvalue, editor) {
                         editor.jqxNumberInput({ decimalDigits: 0 , inputMode: 'simple'});
                     },
                     createEverPresentRowWidget: function (datafield, htmlElement, popup, addCallback) {
                         var inputTag = $("<div style='border: none;float:right;width:100%'></div>").appendTo(htmlElement);
                         inputTag.jqxNumberInput({ decimalDigits: 0, inputMode: 'simple' });
                         $(document).on('keydown.productname', function (event) {
                             if (event.keyCode == 13) {
                                 if (event.target === inputTag[0]) {
                                     addCallback();
                                 }
                                 else if ($(event.target).ischildof(inputTag)) {
                                     addCallback();
                                 }
                             }
                         });
                         return inputTag;
                     },
                     validateEverPresentRowWidgetValue: function (datafield, value, rowValues) {
                         if (value == 0) {
                             return { message: "الكمية يجب أن تكون أكبر من صفر(0)", result: false };
                         }
                         return true;
                     },
                     getEverPresentRowWidgetValue: function (datafield, htmlElement, validate) {
                         var selectedItem = htmlElement.jqxNumberInput();
                         if (!selectedItem)
                             return "";

                         var value = selectedItem.jqxNumberInput('val');
                         return value;
                     },
                     resetEverPresentRowWidgetValue: function (datafield, htmlElement) {
                         htmlElement.jqxNumberInput('clear');
                     }

                 },
                 {
                     text: 'السعر / الصنف', datafield: 'PricePerItem', cellsalign: 'center', align: 'center', width: '22%',columntype: 'numberinput',
                    validation: function (cell, value) {
            
                        return true;
                    },
                    createeditor: function (row, cellvalue, editor) {
                        editor.jqxNumberInput({ decimalDigits: 0, inputMode: 'simple' });
                    },
                    createEverPresentRowWidget: function (datafield, htmlElement, popup, addCallback) {
                        var inputTag = $("<div style='border: none;float:right;width:100%'></div>").appendTo(htmlElement);
                        inputTag.jqxNumberInput({ decimalDigits: 2, inputMode: 'simple' });
                        $(document).on('keydown.productname', function (event) {
                            if (event.keyCode == 13) {
                                if (event.target === inputTag[0]) {
                                    addCallback();
                                }
                                else if ($(event.target).ischildof(inputTag)) {
                                    addCallback();
                                }
                            }
                        });
                        return inputTag;
                    },
                    validateEverPresentRowWidgetValue: function (datafield, value, rowValues) {
                        if (value == 0) {
                            return { message: "السعر يجب أن يكون أكبر من صفر(0)", result: false };
                        }
                        return true;
                    },
                    getEverPresentRowWidgetValue: function (datafield, htmlElement, validate) {
                        var selectedItem = htmlElement.jqxNumberInput();
                        if (!selectedItem)
                            return "";

                        var value = selectedItem.jqxNumberInput('val');
                        return value;
                    },
                    resetEverPresentRowWidgetValue: function (datafield, htmlElement) {
                        htmlElement.jqxNumberInput('clear');
                    }

                 },

            ]

        });
}

function ViewSections()
{
    $('.tab-pane').removeClass('active');
    $('ul.nav-tabs li').removeClass('active');

    var notcheckedItems = $('#DivSections').find('input:not(:checked)');
    $.each(notcheckedItems, function (i, item) {
        var self = $(item);
        $('a[href="#tab' + self.val() + '"]').parent("li").css("display", "none");
        
    });

    if ($('#DivSections').find('input').length == notcheckedItems.length) {
        $('.nav-tabs').css('display', 'none');
    }
    else {
        $('.nav-tabs').css('display', 'block');
    }
    var checkedItems = $('#DivSections').find('input:checked');
    var viewdItemsCounter = 0;
    $.each(checkedItems, function (i, item) {
        var self = $(item);
        $('a[href="#tab' + self.val() + '"]').parent("li").css("display", "block");
        if (viewdItemsCounter == 0) {            
            $('a[href="#tab' + self.val() + '"]').parent("li").addClass('active');
            $('#tab' + self.val()).addClass('active');
            viewdItemsCounter++;
        }
    });


}