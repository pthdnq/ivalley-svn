<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterEn.Master" AutoEventWireup="true" CodeBehind="Splash.aspx.cs" Inherits="ComboPortal.Splash" %>
<%@ MasterType VirtualPath="~/MasterPages/MasterEn.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row-fluid">
        <div class="span12">
            <!-- BEGIN BLANK PAGE PORTLET-->
            <div class="widget color-default">
                <div class="widget-title">
                    <h4><i class="icon-edit"></i>Blank Page </h4>
                    <span class="tools">
                        <a href="javascript:;" class="icon-chevron-down"></a>
                        <a href="javascript:;" class="icon-remove"></a>
                    </span>
                </div>
                <div class="widget-body">
                    Blank page sample
                </div>
            </div>
            <!-- END BLANK PAGE PORTLET-->
        </div>
    </div>
</asp:Content>
