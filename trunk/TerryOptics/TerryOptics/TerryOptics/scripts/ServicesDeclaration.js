dojo.require("wc.service.common");ServicesDeclarationJS={langId:"-1",storeId:"",catalogId:"",catentryId:"",setCommonParameters:function(langId,storeId,catalogId){this.langId=langId;this.storeId=storeId;this.catalogId=catalogId},setCatentryId:function(catentryId){this.catentryId=catentryId}};wc.service.declare({id:"AjaxInterestItemAddAndDeleteFromCart",actionId:"AjaxInterestItemAddAndDeleteFromCart",url:getAbsoluteURL()+"AjaxInterestItemAdd",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();requestSubmitted=false;CheckoutHelperJS.deleteFromCart(serviceResponse.orderItemId,true);MessageHelper.displayStatusMessage(MessageHelper.messages.WISHLIST_ADDED)},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxAddOrderItem",actionId:"AjaxAddOrderItem",url:getAbsoluteURL()+"AjaxOrderChangeServiceItemAdd",formId:"",successHandler:function(serviceResponse){if(window.responseJSON){addToCart(window.responseJSON)}else{var storeId=constants.ajaxParams.storeId;var langId=constants.ajaxParams.langId;var catalogId=constants.ajaxParams.catalogId;var productId=ServicesDeclarationJS.catentryId;$.ajax({type:"POST",url:getAbsoluteURL()+"GetCatalogEntryDetailsByID",data:"catalogId="+catalogId+"&langId="+langId+"&productId="+productId+"&storeId="+storeId,dataType:"text",success:function(data){var d=data.replace("/*","");d=d.replace("*/","");var theJSON=JSON.parse(d);addToCart(theJSON)}})}MessageHelper.hideAndClearMessage();cursor_clear();if(categoryDisplayJS){var attributes=document.getElementsByName("attrValue");var singleSKU=true;for(var i=0;i<attributes.length;i++){if(attributes[i].options.length>1){singleSKU=false}}if(!singleSKU){categoryDisplayJS.selectedAttributes=[];for(var i=0;i<attributes.length;i++){if(attributes[i]!=null){attributes[i].value=""}}}}if(typeof(ShipmodeSelectionExtJS)!=null&&typeof(ShipmodeSelectionExtJS)!="undefined"){ShipmodeSelectionExtJS.setOrderItemId(serviceResponse.orderItemId[0])}},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorMessageKey=="_ERR_NO_ELIGIBLE_TRADING"){MessageHelper.displayErrorMessage(MessageHelper.messages.ERROR_CONTRACT_EXPIRED_GOTO_ORDER)}else{if(serviceResponse.errorMessageKey=="_ERR_RETRIEVE_PRICE"){MessageHelper.displayErrorMessage(MessageHelper.messages.ERROR_RETRIEVE_PRICE)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxAddOrderItem_shopCart",actionId:"AjaxAddOrderItem",url:getAbsoluteURL()+"AjaxOrderChangeServiceItemAdd",formId:"",successHandler:function(serviceResponse){document.location.href="AjaxOrderItemDisplayView?storeId="+ServicesDeclarationJS.storeId+"&catalogId="+ServicesDeclarationJS.catalogId+"&langId="+ServicesDeclarationJS.langId},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorMessageKey=="_ERR_NO_ELIGIBLE_TRADING"){MessageHelper.displayErrorMessage(MessageHelper.messages.ERROR_CONTRACT_EXPIRED_GOTO_ORDER)}else{if(serviceResponse.errorMessageKey=="_ERR_RETRIEVE_PRICE"){MessageHelper.displayErrorMessage(MessageHelper.messages.ERROR_RETRIEVE_PRICE)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxDeleteOrderItem",actionId:"AjaxDeleteOrderItem",url:getAbsoluteURL()+"AjaxOrderChangeServiceItemDelete",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();MessageHelper.displayStatusMessage(MessageHelper.messages.SHOPCART_REMOVEITEM)},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxDeleteOrderItemForShippingBillingPage",actionId:"AjaxDeleteOrderItemForShippingBillingPage",url:getAbsoluteURL()+"AjaxOrderChangeServiceItemDelete",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();MessageHelper.displayStatusMessage(MessageHelper.messages.SHOPCART_REMOVEITEM)},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxDeleteOrderItemFromCart",actionId:"AjaxDeleteOrderItem",url:getAbsoluteURL()+"AjaxOrderChangeServiceItemDelete",formId:"",failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxDeleteOrderItem1",actionId:"AjaxDeleteOrderItem",url:getAbsoluteURL()+"AjaxOrderChangeServiceItemDelete",formId:"",successHandler:function(serviceResponse){if(!CheckoutHelperJS.pendingOrderDetailsPage){if(CheckoutHelperJS.shoppingCartPage){document.location.href="AjaxOrderItemDisplayView?storeId="+ServicesDeclarationJS.storeId+"&catalogId="+ServicesDeclarationJS.catalogId+"&langId="+ServicesDeclarationJS.langId}else{document.location.href="OrderShippingBillingView?storeId="+ServicesDeclarationJS.storeId+"&catalogId="+ServicesDeclarationJS.catalogId+"&langId="+ServicesDeclarationJS.langId+"&orderId="+serviceResponse.orderId}}else{cursor_clear()}},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxUpdateOrderItem",actionId:"AjaxUpdateOrderItem",url:getAbsoluteURL()+"AjaxOrderChangeServiceItemUpdate",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();cursor_clear()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorMessageKey=="_ERR_RETRIEVE_PRICE"){MessageHelper.displayErrorMessage(MessageHelper.messages.ERROR_RETRIEVE_PRICE_QTY_UPDATE)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxUpdateOrderItem1",actionId:"AjaxUpdateOrderItem",url:getAbsoluteURL()+"AjaxOrderChangeServiceItemUpdate",formId:"",successHandler:function(serviceResponse){if(!CheckoutHelperJS.pendingOrderDetailsPage){if(CheckoutHelperJS.shoppingCartPage){document.location.href="AjaxOrderItemDisplayView?storeId="+ServicesDeclarationJS.storeId+"&catalogId="+ServicesDeclarationJS.catalogId+"&langId="+ServicesDeclarationJS.langId}}else{cursor_clear()}},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorMessageKey=="_ERR_RETRIEVE_PRICE"){MessageHelper.displayErrorMessage(MessageHelper.messages.ERROR_RETRIEVE_PRICE_QTY_UPDATE)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxUpdateOrderShippingInfo",actionId:"AjaxUpdateOrderShippingInfo",url:getAbsoluteURL()+"AjaxOrderChangeServiceShipInfoUpdate",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();cursor_clear()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxPrepareOrderForSubmit",actionId:"AjaxPrepareOrderForSubmit",url:getAbsoluteURL()+"AjaxOrderProcessServiceOrderPrepare",formId:"",successHandler:function(serviceResponse){CheckoutHelperJS.setOrderPrepared("true");CheckoutHelperJS.checkoutOrder(CheckoutHelperJS.getSavedParameter("tempOrderId"),CheckoutHelperJS.getSavedParameter("tempUserType"),CheckoutHelperJS.getSavedParameter("tempEmailAddresses"),CheckoutHelperJS.getSavedParameter("tempIsQuote"))},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxSubmitOrder",actionId:"AjaxSubmitOrder",url:getAbsoluteURL()+"AjaxOrderProcessServiceOrderSubmit",formId:"",successHandler:function(serviceResponse){var shipmentTypeId=CheckoutHelperJS.getShipmentTypeId();document.location.href="OrderShippingBillingConfirmationView?storeId="+ServicesDeclarationJS.storeId+"&catalogId="+ServicesDeclarationJS.catalogId+"&langId="+ServicesDeclarationJS.langId+"&orderId="+serviceResponse.orderId+"&shipmentTypeId="+shipmentTypeId},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxSubmitQuote",actionId:"AjaxSubmitQuote",url:getAbsoluteURL()+"AjaxSubmitQuote",formId:"",successHandler:function(serviceResponse){var redirectURL="OrderShippingBillingConfirmationView?storeId="+ServicesDeclarationJS.storeId+"&catalogId="+ServicesDeclarationJS.catalogId+"&langId="+ServicesDeclarationJS.langId+"&orderId="+CheckoutHelperJS.getOrderId()+"&shipmentTypeId="+CheckoutHelperJS.getShipmentTypeId()+"&isQuote=true&quoteId="+serviceResponse.outOrderId;if(serviceResponse.outExternalQuoteId!=undefined&&serviceResponse.outExternalQuoteId!=null){redirectURL+=redirectURL+"&externalQuoteId="+serviceResponse.outExternalQuoteId}document.location.href=redirectURL},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxAddAddressForPerson",actionId:"AjaxAddAddressForPerson",url:getAbsoluteURL()+"AjaxPersonChangeServiceAddressAdd",formId:"",successHandler:function(serviceResponse){AddressHelper.updateOrderAfterAddressUpdate();MessageHelper.hideAndClearMessage();cursor_clear()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxUpdateAddressForPerson",actionId:"AjaxUpdateAddressForPerson",url:getAbsoluteURL()+"AjaxPersonChangeServiceAddressUpdate",formId:"",successHandler:function(serviceResponse){AddressHelper.updateOrderAfterAddressUpdate();MessageHelper.hideAndClearMessage();cursor_clear()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"UpdateBillingAddressInCheckOut",actionId:"UpdateBillingAddressInCheckOut",url:getAbsoluteURL()+"AjaxPersonChangeServiceAddressUpdate",formId:"",successHandler:function(serviceResponse){wc.render.updateContext("contextForMainAndAddressDiv",{showArea:"mainContents",hideArea:"editAddressContents"});wc.render.updateContext("billingAddressDropDownBoxContext",{billingAddress1:serviceResponse.addressId})},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxUpdateOrderAfterAddressUpdate",actionId:"AjaxUpdateOrderAfterAddressUpdate",url:getAbsoluteURL()+"AjaxOrderChangeServiceItemUpdate",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();cursor_clear()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxInterestItemAdd",actionId:"AjaxInterestItemAdd",url:getAbsoluteURL()+"AjaxInterestItemAdd",formId:"",successHandler:function(serviceResponse){if(window.responseJSON){addToWishlist(window.responseJSON,true)}else{var storeId=constants.ajaxParams.storeId;var langId=constants.ajaxParams.langId;var catalogId=constants.ajaxParams.catalogId;var productId=ServicesDeclarationJS.catentryId;addToWishlistExists(getAbsoluteURL(),catalogId,langId,productId,storeId,true)}MessageHelper.hideAndClearMessage();cursor_clear();if(categoryDisplayJS){categoryDisplayJS.selectedAttributes=[]}},failureHandler:function(serviceResponse){if(serviceResponse.errorMessageKey=="_ERR_IITEM_ALREADY_EXIST"){if($("#second_level_category_popup").is(":visible")){$("#second_level_category_popup").dialog("close")}if(window.responseJSON){addToWishlist(window.responseJSON,false)}else{var storeId=constants.ajaxParams.storeId;var langId=constants.ajaxParams.langId;var catalogId=constants.ajaxParams.catalogId;var productId=ServicesDeclarationJS.catentryId;addToWishlistExists(getAbsoluteURL(),catalogId,langId,productId,storeId,false)}}else{if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}}cursor_clear()}}),wc.service.declare({id:"AjaxInterestItemAdd_shopCart",actionId:"AjaxInterestItemAdd",url:getAbsoluteURL()+"AjaxInterestItemAdd",formId:"",successHandler:function(serviceResponse){document.location.href="AjaxOrderItemDisplayView?storeId="+ServicesDeclarationJS.storeId+"&catalogId="+ServicesDeclarationJS.catalogId+"&langId="+ServicesDeclarationJS.langId},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxInterestItemDelete",actionId:"AjaxInterestItemDelete",url:getAbsoluteURL()+"AjaxInterestItemDelete",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxInterestItemListMessage",actionId:"AjaxInterestItemListMessage",url:getAbsoluteURL()+"SendEmailCmd",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxPromotionCodeManage",actionId:"AjaxPromotionCodeManage",url:getAbsoluteURL()+"AjaxPromotionCodeManage",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();var params=[];params.storeId=this.storeId;params.catalogId=this.catalogId;params.langId=this.langId;params.orderId=".";params.calculationUsage="-1,-2,-3,-4,-5,-6,-7";wc.service.invoke("AjaxUpdateOrderItem",params)},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxCouponsAddRemove",actionId:"AjaxCouponsAddRemove",url:getAbsoluteURL()+"AjaxCouponsAddRemove",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();var params=[];params.storeId=this.storeId;params.catalogId=this.catalogId;params.langId=this.langId;params.orderId=serviceResponse.orderId;params.calculationUsage="-1,-2,-3,-4,-5,-6,-7";wc.service.invoke("AjaxUpdateOrderItem",params)},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AddBillingAddress",actionId:"AddBillingAddress",url:getAbsoluteURL()+"AjaxPersonChangeServiceAddressAdd",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"ScheduleOrder",actionId:"ScheduleOrder",url:getAbsoluteURL()+"AjaxOrderProcessServiceOrderSchedule",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();var originalOrderId=document.getElementById("orderIdToSchedule").value;var newOrderId=serviceResponse.orderId;var shipmentTypeId=CheckoutHelperJS.getShipmentTypeId();var purchaseOrderNumber="";if(document.forms.purchaseOrderNumberInfo.purchase_order_number.value!=null){purchaseOrderNumber=document.forms.purchaseOrderNumberInfo.purchase_order_number.value}var url="OrderProcessServiceOrderCancel?orderId="+originalOrderId+"&storeId="+ServicesDeclarationJS.storeId+"&catalogId="+ServicesDeclarationJS.catalogId+"&langId="+ServicesDeclarationJS.langId+"&URL=OrderShippingBillingConfirmationView%3ForderId%3D"+newOrderId+"%26originalOrderId%3D"+originalOrderId+"%26shipmentTypeId%3D"+shipmentTypeId+"%26purchaseOrderNumber%3D"+purchaseOrderNumber;document.location.href=url},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"SubmitRecurringOrder",actionId:"SubmitRecurringOrder",url:getAbsoluteURL()+"AjaxOrderProcessServiceRecurringOrderSubmit",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();var shipmentTypeId=CheckoutHelperJS.getShipmentTypeId();var url="OrderShippingBillingConfirmationView?storeId="+ServicesDeclarationJS.storeId+"&catalogId="+ServicesDeclarationJS.catalogId+"&langId="+ServicesDeclarationJS.langId+"&orderId="+serviceResponse.orderId+"&shipmentTypeId="+shipmentTypeId;document.location.href=url;cursor_clear()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxUpdateRewardOption",actionId:"AjaxUpdateRewardOption",url:getAbsoluteURL()+"AjaxOrderChangeServiceRewardOptionUpdate",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();cursor_clear()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxOrderCreate",actionId:"AjaxOrderCreate",url:getAbsoluteURL()+"AjaxOrderCreate",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();MessageHelper.displayStatusMessage(MessageHelper.messages.ORDER_CREATED);cursor_clear()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorCode=="CMN0409E"){MessageHelper.displayErrorMessage(MessageHelper.messages.ORDER_NOT_CREATED)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxSingleOrderCancel",actionId:"AjaxSingleOrderCancel",url:getAbsoluteURL()+"AjaxOrderProcessServiceOrderCancel",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();MessageHelper.displayStatusMessage(MessageHelper.messages.ORDERS_CANCELLED);cursor_clear()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorCode=="CMN0409E"){MessageHelper.displayErrorMessage(MessageHelper.messages.ORDER_NOT_CANCELLED)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxOrderCancel",actionId:"AjaxOrderCancel",url:getAbsoluteURL()+"AjaxOrderProcessServiceOrderCancel",formId:"",successHandler:function(serviceResponse){savedOrdersJS.cancelSavedOrder(false)},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorCode=="CMN0409E"){MessageHelper.displayErrorMessage(MessageHelper.messages.ORDER_NOT_CANCELLED)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxSingleOrderSave",actionId:"AjaxSingleOrderSave",url:getAbsoluteURL()+"AjaxOrderCopy",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();if(savedOrdersJS.isOrderDetailsPageValue){MessageHelper.displayStatusMessage(MessageHelper.messages.PENDING_ORDER_SAVED)}else{MessageHelper.displayStatusMessage(MessageHelper.messages.ORDERS_SAVED)}var inputElement=document.getElementById("OrderDescription_input");if(inputElement!=null&&inputElement!="undefined"){dojo.removeClass(inputElement,"savedOrderDetailsInputBorderWarning");dojo.addClass(inputElement,"savedOrderDetailsInputBorder");document.getElementById("OldOrderDescription").value=inputElement.value}cursor_clear();if(savedOrdersJS.updateCartRequired){savedOrdersJS.updateCartRequired=false;CheckoutHelperJS.updateShoppingCart(document.ShopCartForm)}},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorCode=="CMN0409E"||serviceResponse.errorCode=="CMN1024E"){if(serviceResponse.errorCode=="CMN1024E"&&serviceResponse.systemMessage!=""){MessageHelper.displayErrorMessage(serviceResponse.systemMessage)}else{if(savedOrdersJS.isOrderDetailsPageValue){MessageHelper.displayStatusMessage(MessageHelper.messages.PENDING_ORDER_NOT_SAVED)}else{MessageHelper.displayErrorMessage(MessageHelper.messages.ORDER_NOT_SAVED)}}}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxOrderSave",actionId:"AjaxOrderSave",url:getAbsoluteURL()+"AjaxOrderCopy",formId:"",successHandler:function(serviceResponse){savedOrdersJS.saveOrder(false)},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorCode=="CMN0409E"){MessageHelper.displayErrorMessage(MessageHelper.messages.ORDER_NOT_SAVED)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxSetPendingOrder",actionId:"AjaxSetPendingOrder",url:getAbsoluteURL()+"AjaxSetPendingOrder",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();MessageHelper.displayStatusMessage(MessageHelper.messages.ORDER_SET_CURRENT);savedOrdersJS.determinePageForward("AjaxSetPendingOrder");cursor_clear()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorCode=="CMN0409E"||serviceResponse.errorCode=="CMN1024E"){MessageHelper.displayErrorMessage(MessageHelper.messages.ORDER_NOT_SET_CURRENT)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxUpdatePendingOrder",actionId:"AjaxUpdatePendingOrder",url:getAbsoluteURL()+"AjaxSetPendingOrder",formId:"",successHandler:function(serviceResponse){savedOrdersJS.determinePageForward("AjaxUpdatePendingOrder");cursor_clear()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorCode=="CMN0409E"){MessageHelper.displayErrorMessage(MessageHelper.messages.ORDER_NOT_SET_CURRENT)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxSingleOrderCopy",actionId:"AjaxSingleOrderCopy",url:getAbsoluteURL()+"AjaxOrderCopy",formId:"",successHandler:function(serviceResponse){var params=[];params.storeId=this.storeId;params.catalogId=this.catalogId;params.langId=this.langId;params.URL="";params.updatePrices="1";params.orderId=serviceResponse.orderId;params.calculationUsageId="-1";wc.service.invoke("AjaxSingleOrderCalculate",params);MessageHelper.hideAndClearMessage()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorCode=="CMN0409E"){MessageHelper.displayErrorMessage(MessageHelper.messages.ORDER_NOT_COPIED)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxOrderCopy",actionId:"AjaxOrderCopy",url:getAbsoluteURL()+"AjaxOrderCopy",formId:"",successHandler:function(serviceResponse){var params=[];params.storeId=this.storeId;params.catalogId=this.catalogId;params.langId=this.langId;params.URL="";params.updatePrices="1";params.orderId=serviceResponse.orderId;params.calculationUsageId="-1";wc.service.invoke("AjaxOrderCalculate",params);MessageHelper.hideAndClearMessage()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorCode=="CMN0409E"){MessageHelper.displayErrorMessage(MessageHelper.messages.ORDER_NOT_COPIED)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxSingleOrderCalculate",actionId:"AjaxSingleOrderCalculate",url:getAbsoluteURL()+"AjaxOrderCalculate",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();MessageHelper.displayStatusMessage(MessageHelper.messages.ORDER_COPIED);cursor_clear()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorCode=="CMN0409E"){MessageHelper.displayErrorMessage(MessageHelper.messages.ORDER_NOT_COPIED)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxCurrentOrderCalculate",actionId:"AjaxCurrentOrderCalculate",url:getAbsoluteURL()+"AjaxOrderCalculate",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();MessageHelper.displayStatusMessage(MessageHelper.messages.ORDER_SET_CURRENT);cursor_clear()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorCode=="CMN0409E"){MessageHelper.displayErrorMessage(MessageHelper.messages.ORDER_NOT_COPIED)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxOrderCalculate",actionId:"AjaxOrderCalculate",url:getAbsoluteURL()+"AjaxOrderCalculate",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();savedOrdersJS.copyOrder(false)},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){if(serviceResponse.errorCode=="CMN0409E"){MessageHelper.displayErrorMessage(MessageHelper.messages.ORDER_NOT_COPIED)}else{MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxPunchoutPay",actionId:"AjaxPunchoutPay",url:"PunchoutPaymentRepay",formId:"",successHandler:function(serviceResponse){PunchoutJS.handleResponse(serviceResponse.orderId);MessageHelper.hideAndClearMessage();cursor_clear()},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"AjaxCategorySubscribe",actionId:"AjaxCategorySubscribe",url:"AjaxMarketingTriggerProcessServiceEvaluate",formId:"",successHandler:function(serviceResponse){MessageHelper.hideAndClearMessage();MessageHelper.displayStatusMessage(MessageHelper.messages.SUBSCRIPTION_UPDATED)},failureHandler:function(serviceResponse){if(serviceResponse.errorMessage){MessageHelper.displayErrorMessage(serviceResponse.errorMessage)}else{if(serviceResponse.errorMessageKey){MessageHelper.displayErrorMessage(serviceResponse.errorMessageKey)}}cursor_clear()}}),wc.service.declare({id:"ajaxLogonService",actionId:"ajaxLogonService",url:"AjaxLogon",formId:"",successHandler:function(serviceResponse){var errorCodes="2010,2030,2110";if(errorCodes.indexOf(serviceResponse.ErrorCode)>-1){document.getElementById("logonErrorMessage").innerHTML="Your email and/or password did not match our records. Please try entering them again.";document.getElementById("WC_CheckoutLogon_FormInput_logonId").value="";document.getElementById("WC_CheckoutLogon_FormInput_logonPassword").value=""}else{var redirectURL=serviceResponse.redirecturl.toString();document.location.href=redirectURL.split("&amp;").join("&")}},failureHandler:function(serviceResponse){document.getElementById("logonErrorMessage").innerHTML="Your email and/or password did not match our records. Please try entering them again.";document.getElementById("WC_CheckoutLogon_FormInput_logonId").value="";document.getElementById("WC_CheckoutLogon_FormInput_logonPassword").value=""}});