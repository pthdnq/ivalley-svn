EmailSignupForm={prepareSubmit:function(form){var isValid=$("#emailSignup").valid();if(isValid){$(form).submit()}if(!submitRequest()){return}}};$(document).ready(function(){$("#emailSignup").validate({onfocusout:false,onkeyup:false,onclick:false,errorClass:"required",errorElement:"span",rules:{check18Years:{required:true},email:{required:true,email:true}},messages:{check18Years:MessageHelper.messages.ERROR_CERT_18,email:MessageHelper.messages.ERROR_EMAIL_EMPTY_FOOTER},errorPlacement:function(error,element){$(error).insertAfter("#go-signup")},highlight:function(element,errorClass){$(element).addClass("required")},unhighlight:function(element,errorClass){$(element).removeClass("required")}});$("#footer form[name=emailSignup]").submit(submitFooterEmail)});function submitFooterEmail(){var $form=$(this);if(constants.ajaxParams.loggedIn){MessageHelper.displayErrorMessage(MessageHelper.messages.ERROR_EMAIL_SIGNUP_LOGGED_IN);return false}else{$.ajax({url:$form.attr("action"),data:$form.serialize(),dataType:"json",type:"post",complete:function(response){try{var responseData=$.parseJSON(response.responseText);if(responseData.success=="true"){if(responseData.info=="_ERR_EMAIL_ALREADY_SUBSCRIBED"){MessageHelper.displayErrorMessage(MessageHelper.messages._ERR_EMAIL_ALREADY_SUBSCRIBED)}else{MessageHelper.displayStatusMessage(MessageHelper.messages.EMAIL_SIGNUP_SUCCESS)}}else{MessageHelper.displayErrorMessage(constants.error.ajax)}}catch(err){MessageHelper.displayErrorMessage(constants.error.ajax)}}});return false}};