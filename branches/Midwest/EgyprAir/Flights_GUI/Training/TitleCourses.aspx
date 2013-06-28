﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/E_Training.Master" AutoEventWireup="true" CodeBehind="TitleCourses.aspx.cs" Inherits="Flights_GUI.Training.TitleCourses" %>
<%@ MasterType VirtualPath="~/MasterPages/E_Training.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Panel ID="uiPanelAllTitleCourses" runat="server">
        <div class="row-fluid">
            <div class="span12">
                <!-- BEGIN BORDERED TABLE widget-->
                <div class="widget">
                    <div class="widget-title">
                        <h4>
                            <i class="icon-reorder"></i>Title courses</h4>
                        <span class="tools"><a href="javascript:;" class="icon-chevron-down"></a><a href="javascript:;"
                            class="icon-remove"></a></span>
                    </div>
                    <div class="widget-body">
                        <div class="form-horizontal">
                            <div class="control-group">
                                <div class="span12">
                                    <label class="control-label">
                                        Title</label>
                                    <div class="controls">
                                        <asp:DropDownList ID="uiDropDownListTitle" runat="server" AutoPostBack="true" CssClass="input-large"
                                            OnSelectedIndexChanged="uiDropDownListTitle_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                </div>
                            <div class="control-group">
                                <div class="span12">
                                    <label class="control-label">
                                        Course</label>
                                    <div class="controls">
                                        <asp:DropDownList ID="uiDropDownListCourses" runat="server" CssClass="input-large">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                </div>
                            <div class="form-actions" style="margin-bottom: 0 !important; padding-bottom: 0 !important;">
                                <div class="control-group">
                                <div class="span12">
                                    <asp:LinkButton ID="uiLinkButtonAdd" runat="server" CssClass="btn blue" OnClick="uiLinkButtonAdd_Click"><i class='icon-plus'></i> Add Course</asp:LinkButton>
                                </div>
                            </div>
                            </div>
                        </div>
                        
                        <div class="clearfix" style="height: 20px;">
                        </div>
                        <asp:GridView ID="uiGridViewTitleCourses" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                            CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="uiGridViewTitleCourses_PageIndexChanging"
                            OnRowCommand="uiGridViewTitleCourses_RowCommand" Width="90%" >
                            <AlternatingRowStyle BackColor="White" HorizontalAlign="Center" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                            <Columns>                                
                               <asp:BoundField DataField="Name" HeaderText="Course" />
                                <asp:TemplateField HeaderText="Actions">
                                    <ItemTemplate>                                        
                                        <asp:LinkButton ID="uiLinkButtonDelete" runat="server" CommandArgument='<%# Eval("CourseID") %>'
                                            CssClass="btn blue" CommandName="DeleteCourse" OnClientClick="return confirm('Do you want to delete this record?');"><i class='icon-remove'></i> Delete</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
                <!-- END BORDERED TABLE widget-->
            </div>
        </div>
    </asp:Panel>
</asp:Content>
