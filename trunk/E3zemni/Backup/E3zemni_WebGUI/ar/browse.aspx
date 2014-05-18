﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Ar.Master" AutoEventWireup="true" CodeBehind="browse.aspx.cs" Inherits="E3zemni_WebGUI.ar.browse" %>
<%@ MasterType VirtualPath="~/MasterPages/Ar.Master" %>
<%@ Register src="~/ar/controls/ucsearch.ascx" tagname="ucSearch" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
<script type="text/javascript" src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
<script src="../js/purl.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSlider" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderContent" runat="server">
<div class="row clearfix mbs">
<div class="grid_9">
<div class="products shop clearfix mbf">
    <asp:Repeater ID="uiRepeaterCards" runat="server">
    <ItemTemplate>
        <div class="product grid_4">
			<img class="product_img" src='../<%# Eval("MainPhoto") %>' alt=""><!-- featured thumbnail -->
			<img class="product_img_hover" src='../<%# Eval("MainPhotoHover") %>' alt=""><!-- featured thumbnail hover -->			
			<div class="product_inner">
				<h3> <a href='viewCard.aspx?cid=<%# Eval("CardID") %>'> <%# Eval("CardNameAr")%> </a> </h3>
				<div class="clearfix">
					<p class="price"> EGP <%# Eval("PriceNow")%> </p>					
				</div>
			</div>
			<div class="product_meta clearfix">				
				<a href='viewCard.aspx?cid=<%# Eval("CardID") %>' class="f_btn"><span><i class="icon_menu"></i> التفاصيل</span></a>
			</div>
		</div>
    </ItemTemplate>
    </asp:Repeater>
    <div class="clear" style="height:5px;"></div>
    <div class="pagination-tt clearfix">
	    <ul>
		    		    
		    <li>
            <asp:LinkButton ID="uiLinkButtonNext" runat="server" OnClick="uiLinkButtonNext_Click"
                                Font-Bold="True" Font-Size="Medium"><i class="arrow_right"></i> التالى </asp:LinkButton>
            </li>
            <li>
            <asp:LinkButton ID="uiLinkButtonPrev" runat="server" OnClick="uiLinkButtonPrev_Click"
                                Font-Bold="True" Font-Size="Medium"> السابق <i class="arrow_left"></i></asp:LinkButton>
            </li>
	    </ul>
    </div><!-- pagination -->

</div>
</div>

<div class="grid_3 sidebar">
    
    <uc1:ucSearch ID="ucSearch1" runat="server" />
    
</div>
</div>
</asp:Content>