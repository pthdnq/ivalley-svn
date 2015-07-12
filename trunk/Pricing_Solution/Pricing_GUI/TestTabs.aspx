<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true"
    CodeBehind="TestTabs.aspx.cs" Inherits="Pricing_GUI.TestTabs" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="span12">
        <!--BEGIN TABS-->
        <div class="tabbable tabbable-custom">
            <ul class="nav nav-tabs">
                <li class="active"><a href="#tab_1_1" data-toggle="tab">Section 1</a></li>
                <li><a href="#tab_1_2" data-toggle="tab">Section 2</a></li>
                <li><a href="#tab_1_3" data-toggle="tab">Section 3</a></li>
            </ul>
            <div class="tab-content">
                <div class="tab-pane active" id="tab_1_1">
                    <p>
                        Section 1.</p>
                    <p>
                        Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown
                        aliqua, retro synth master cleanse. Mustache cliche tempor, williamsburg carles
                        vegan helvetica. Reprehenderit butcher retro keffiyeh dreamcatcher synth. Cosby
                        sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia
                        cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate
                        nisi qui.
                    </p>
                </div>
                <div class="tab-pane" id="tab_1_2">
                    <p>
                        Section 2.</p>
                    <p>
                        Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis
                        nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit
                        in vulputate velit esse molestie consequat. Ut wisi enim ad minim veniam, quis nostrud
                        exerci tation.
                    </p>
                </div>
                <div class="tab-pane" id="tab_1_3">
                    <p>
                        Section 3.</p>
                    <p>
                        Duis autem vel eum iriure dolor in hendrerit in vulputate. Ut wisi enim ad minim
                        veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip
                        ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate
                        velit esse molestie consequat
                    </p>
                </div>
            </div>
        </div>
        <!--END TABS-->
    </div>
    <div class="span12">
        <cc1:TabContainer ID="tabTest" runat="server" ActiveTabIndex="0" 
            ScrollBars="Auto" Width="489px" >
            <cc1:TabPanel HeaderText="Test 11" CssClass="tab-pane" ID="sub1" runat="server" >
                <ContentTemplate>
                    Duis autem vel eum iriure dolor in hendrerit in vulputate. Ut wisi enim ad minim
                    veniam, quis nostrud exerci tation ullamco
                </ContentTemplate>
            </cc1:TabPanel>
            <cc1:TabPanel HeaderText="Test 22" CssClass="tab-pane" ID="TabPanel1" runat="server">
                <ContentTemplate>
                    mmmmm mmmm mmmmm mmmm mmmmm mmmm
                    <br />
                    mmmmm mmmm mmmmm mmmm mmmmm mmmm
                    <br />
                    mmmmm mmmm mmmmm mmmm mmmmm mmmm
                    <br />
                </ContentTemplate>
            </cc1:TabPanel>
        </cc1:TabContainer>
    </div>
</asp:Content>
