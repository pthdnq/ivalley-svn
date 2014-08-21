(function(e){"use strict";e(document).ready(function(){function r(t,n){if(!t){return}var r=null;if(n==="prev"){r=e("#ut-portfolio-details-"+t).find(".active").prev().height()}if(n==="current"){r=e("#ut-portfolio-details-"+t).find(".active").height()}if(n==="next"){r=e("#ut-portfolio-details-"+t).find(".active").next().height()}e("#ut-portfolio-details-wrap-"+t).height(r+30)}function i(t){if(!t){return}var n=e("#ut-portfolio-details-"+t).find(".active").prev(".ut-portfolio-detail"),r=e("#ut-portfolio-details-"+t).find(".active").next(".ut-portfolio-detail");if(!n.length){e("#ut-portfolio-details-wrap-"+t).find(".prev-portfolio-details").animate({opacity:0})}else{e("#ut-portfolio-details-wrap-"+t).find(".prev-portfolio-details").animate({opacity:1})}if(!r.length){e("#ut-portfolio-details-wrap-"+t).find(".next-portfolio-details").animate({opacity:0})}else{e("#ut-portfolio-details-wrap-"+t).find(".next-portfolio-details").animate({opacity:1})}s()}function s(){e(".ut-portfolio-details-navigation").each(function(){var t=e(this),n=t.parent(),r=n.find(".active"),i=r.find(".ut-portfolio-media").height();if(i>0){t.find(".next-portfolio-details").animate({top:i/2+45});t.find(".prev-portfolio-details").animate({top:i/2+45})}else{t.find(".next-portfolio-details").animate({top:n.height()/2+45});t.find(".prev-portfolio-details").animate({top:n.height()/2+45})}})}function o(e){if(!e){return}if(e.parent().get(0).offsetHeight<e.parent().get(0).scrollHeight){e.parent().height(e.parent().get(0).scrollHeight);return}else{e.parent().height(e.height());return}}function u(t,n){if(!n){return}t.find("#ut-video-call-"+n).fadeOut(400,function(){e(this).html("")})}function a(e,t){if(!t){return}if(e.find("#portfolio-gallery-slider-"+t).hasClass("ut-sliderimages-loaded")){e.find("#portfolio-gallery-slider-"+t).flexslider("destroy")}}function f(t,n){if(!t){return}var r=e("#ut-portfolio-detail-"+t),i=utPortfolio.ajaxurl;e.ajax({type:"POST",url:i,data:{action:"ut_get_portfolio_post",portfolio_id:t},success:function(e){r.find(".ut-video-call").show().html(e).fitVids();return false},complete:function(){if(n&&typeof n==="function"){n()}}})}function l(e,t,n){if(!e){return}var r=t.find("#ut-portfolio-detail-"+e).find(".ut-load-me"),i=r.data("original");if(!r.attr("src")){r.attr("src",i).one("load",function(){if(!this.complete||typeof this.naturalWidth=="undefined"||this.naturalWidth==0){alert("There is a broken image inside your portfolio: "+$this.attr("src",i))}else{if(n&&typeof n==="function"){n()}}})}else{if(n&&typeof n==="function"){n()}}}function c(t,n,r){if(!t){return}var i=n.find("#portfolio-gallery-slider-"+t);if(i.hasClass("ut-sliderimages-loaded")){i.flexslider({animation:"fade",controlNav:false,animationLoop:true,slideshow:false,smoothHeight:true,startAt:0,after:function(){o(n);s()}});if(r&&typeof r==="function"){r()}}var u=i.find(".ut-load-me"),a=u.length;if(a){u.each(function(t){var u=e(this),f=u.data("original");u.attr("src",f).removeClass("ut-load-me").one("load",function(){if(!this.complete||typeof this.naturalWidth=="undefined"||this.naturalWidth==0){alert("There is a broken image inside your portfolio: "+u.attr("src",f))}else{if(!--a){i.flexslider({animation:"fade",controlNav:false,animationLoop:true,slideshow:false,smoothHeight:true,startAt:0,after:function(){o(n);s()}}).addClass("ut-sliderimages-loaded");if(r&&typeof r==="function"){r()}}}})})}else{if(r&&typeof r==="function"){r()}}}var t=e("img.portfolio-lazy");t.lazyload({event:"scroll",load:function(){e(this).animate({opacity:1});e.waypoints("refresh")},failure_limit:Math.max(t.length-1,0)});e('a[data-rel^="utPortfolio"]').prettyPhoto({social_tools:false,deeplinking:false,default_width:1024,allow_resize:true,markup:'<div class="pp_pic_holder"> 						<div class="pp_top"> 							<div class="pp_left"></div> 							<div class="pp_middle"></div> 							<div class="pp_right"></div> 						</div> 						<div class="pp_content_container"> 							<div class="pp_left"> 							<div class="pp_right"> 								<div class="pp_content"> 									<div class="pp_loaderIcon"></div> 									<div class="pp_fade"> 										<a href="#" class="pp_expand" title="Expand the image">Expand</a> 										<div class="pp_hoverContainer"> 											<a class="pp_next" href="#">next</a> 											<a class="pp_previous" href="#">previous</a> 										</div> 										<div id="pp_full_res"></div> 										<div class="pp_details"> 											<div class="pp_nav"> 												<a href="#" class="pp_arrow_previous">Previous</a> 												<p class="currentTextHolder">0/0</p> 												<a href="#" class="pp_arrow_next">Next</a> 											</div> 											<div class="ppt">&nbsp;</div> 											<p class="pp_description"></p> 											{pp_social} 											<a class="pp_close" href="#">Close</a> 										</div> 									</div> 								</div> 							</div> 							</div> 						</div> 						<div class="pp_bottom"> 							<div class="pp_left"></div> 							<div class="pp_middle"></div> 							<div class="pp_right"></div> 						</div> 					</div> 					<div class="pp_overlay"></div>'});e(".ut-hover").each(function(t,n){var r=e(this).closest(".ut-portfolio-wrap").data("textcolor");e(this).find(".ut-hover-layer").css({color:r});e(this).find(".ut-hover-layer").find(".portfolio-title").attr("style","color: "+r+" !important")});e(".ut-hover").mouseenter(function(){var t=e(this).closest(".ut-portfolio-wrap").data("hovercolor"),n=e(this).closest(".ut-portfolio-wrap").data("opacity");e(this).find(".ut-hover-layer").css("background","rgba("+t+","+n+")");e(this).find(".ut-hover-layer").css("opacity",1)}).mouseleave(function(){e(this).find(".ut-hover-layer").css("opacity",0)});var n=false;e(window).smartresize(function(){s()});e(document).on("click",".ut-portfolio-link",function(t){if(n){return false}n=true;var r=e(this).data("post"),s=e(this).data("wrap"),o=e("#ut-loader-"+s),u=e("#ut-portfolio-details-wrap-"+s),a=e("#ut-portfolio-details-"+s),h=u.find("#ut-portfolio-detail-"+r),p=u.closest("section").data("width"),d=h.data("format");o.stop(true).fadeIn(400,function(){e.scrollTo(u,650,{easing:"easeInOutExpo",offset:-100,axis:"y",onAfter:function(){if(p==="fullwidth"){a.addClass("grid-container")}a.find(".ut-portfolio-detail").removeClass("active").hide();h.addClass("active").css("visibility","hidden").show().slideDown(800,"easeInOutExpo",function(){if(d==="gallery"){c(r,a,function(){o.fadeOut(400,function(){u.addClass("show overflow-visible");u.find(".ut-portfolio-details-navigation").addClass("show").data("single",r);h.css("visibility","visible").animate({opacity:1},400,"easeInOutExpo",function(){i(s);u.height(a.outerHeight()+50);e(window).trigger("scroll");n=false})})})}else if(d==="video"){f(r,function(){o.fadeOut(400,function(){u.addClass("show overflow-visible");u.find(".ut-portfolio-details-navigation").addClass("show").data("single",r);h.css("visibility","visible").animate({opacity:1},400,"easeInOutExpo",function(){i(s);u.height(a.outerHeight()+50);e(window).trigger("scroll");n=false})})})}else{l(r,a,function(){o.fadeOut(400,function(){u.addClass("show overflow-visible");u.find(".ut-portfolio-details-navigation").addClass("show").data("single",r);h.css("visibility","visible").animate({opacity:1},400,"easeInOutExpo",function(){i(s);u.height(a.outerHeight()+50);e(window).trigger("scroll");n=false})})})}})}})});t.preventDefault()});e(document).on("click",".next-portfolio-details",function(t){if(n){return false}n=true;var r=e(this).data("wrap"),s=e("#ut-portfolio-details-wrap-"+r),o=s.closest("section").data("width"),h=e("#ut-portfolio-details-"+r),p=e("#ut-loader-"+r),d=h.find(".active").next().data("post"),v=h.find(".active").next().data("format"),m=h.find(".active").data("post"),g=h.find(".active").data("format"),y=h.find("#ut-portfolio-detail-"+d);if(g==="video"){u(h,m)}if(g==="gallery"){a(h,m)}if(o!=="centered"){y.addClass("grid-container")}h.find("#ut-portfolio-detail-"+m).removeClass("active").fadeOut(function(){p.stop(true).fadeIn(400,function(){y.addClass("active").css("visibility","hidden").slideDown(800,"easeInOutExpo",function(){if(v==="gallery"){c(d,h,function(){p.fadeOut(400,function(){h.find(".ut-portfolio-details-navigation").data("single",d);y.css("visibility","visible").animate({opacity:1},400,"easeInOutExpo",function(){i(r);s.height(h.outerHeight()+50);n=false})})})}else if(v==="video"){f(d,function(){p.fadeOut(400,function(){h.find(".ut-portfolio-details-navigation").data("single",d);y.css("visibility","visible").animate({opacity:1},400,"easeInOutExpo",function(){i(r);s.height(h.outerHeight()+50);n=false})})})}else{l(d,h,function(){p.fadeOut(400,function(){h.find(".ut-portfolio-details-navigation").data("single",d);y.css("visibility","visible").animate({opacity:1},400,"easeInOutExpo",function(){i(r);s.height(h.outerHeight()+50);n=false})})})}})})});t.preventDefault()});e(document).on("click",".prev-portfolio-details",function(t){if(n){return}n=true;var r=e(this).data("wrap"),s=e("#ut-portfolio-details-wrap-"+r),o=s.closest("section").data("width"),h=e("#ut-portfolio-details-"+r),p=e("#ut-loader-"+r),d=h.find(".active").prev().data("post"),v=h.find(".active").prev().data("format"),m=h.find(".active").data("post"),g=h.find(".active").data("format"),y=h.find("#ut-portfolio-detail-"+d);if(g==="video"){u(h,m)}if(g==="gallery"){a(h,m)}if(o!=="centered"){y.addClass("grid-container")}h.find("#ut-portfolio-detail-"+m).removeClass("active").fadeOut(function(){p.stop(true).fadeIn(400,function(){y.addClass("active").css("visibility","hidden").slideDown(800,"easeInOutExpo",function(){if(v==="gallery"){c(d,h,function(){p.fadeOut(400,function(){h.find(".ut-portfolio-details-navigation").data("single",d);y.css("visibility","visible").animate({opacity:1},400,"easeInOutExpo",function(){i(r);s.height(h.outerHeight()+50);n=false})})})}else if(v==="video"){f(d,function(){p.fadeOut(400,function(){h.find(".ut-portfolio-details-navigation").data("single",d);y.css("visibility","visible").animate({opacity:1},400,"easeInOutExpo",function(){i(r);s.height(h.outerHeight()+50);n=false})})})}else{l(d,h,function(){p.fadeOut(400,function(){h.find(".ut-portfolio-details-navigation").data("single",d);y.css("visibility","visible").animate({opacity:1},400,"easeInOutExpo",function(){i(r);s.height(h.outerHeight()+50);n=false})})})}})})});t.preventDefault()});e(document).on("click",".close-portfolio-details",function(t){if(n){return false}n=true;var r=e(this).data("wrap"),i=e(this).parent().data("single"),s=e("#ut-portfolio-details-wrap-"+r),o=e(this).data("post"),f=e("#ut-portfolio-detail-"+i).data("format");s.find(".ut-portfolio-details-navigation").removeClass("show");s.find("#ut-portfolio-detail-"+i).removeClass("active").animate({opacity:0},200,"easeInOutExpo",function(){e("#ut-portfolio-details-wrap-"+r).removeClass("show").removeClass("overflow-visible");if(f==="video"){u(s,i)}if(f==="gallery"){a(s,i)}n=false});t.preventDefault()})})})(jQuery)