<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ExceptionLight.Master" AutoEventWireup="true" CodeBehind="ticket.aspx.cs" Inherits="Flights_GUI.tracker.ticket" %>
<%@ MasterType VirtualPath="~/MasterPages/ExceptionLight.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="default.aspx" class="btn btn-success pull-right" >Back to tickets</a>      
    <div class="cell-12">
        <div class="cell-2 bold">
            Title
        </div>
        <div class="cell-5 ">
            <asp:Label ID="uiLabelTitle" runat="server"></asp:Label>
        </div>

        <div class="cell-2 bold">
            Added by
        </div>
        <div class="cell-3 ">
            <asp:Label ID="uiLabelUser" runat="server"></asp:Label>
        </div>

        <div style="clear:both;height:5px"></div>

        <div class="cell-2 bold">
            Description
        </div>
        <div class="cell-5 ">
            <asp:Label ID="uiLabelDesc" runat="server"></asp:Label>
        </div>
        
        <div class="cell-2 bold">
            Ticket type
        </div>
        <div class="cell-3 ">
            <asp:Label ID="uiLabelType" runat="server" ></asp:Label>
        </div>
        <div style="clear:both;height:5px"></div>
        <div class="cell-2 bold">
            Current status
        </div>
        <div class="cell-5 ">
            <asp:DropDownList ID="uiDropDownListStatus" runat="server"></asp:DropDownList>
        </div>
        <div style="clear:both;height:5px"></div>

        <div class="cell-2 bold">
         Attachments 
        </div>
        <div class="cell-5 ">
            <asp:Repeater ID="uiRepeaterAttachments" runat="server">
                <ItemTemplate>
                    <a href='<%# Eval("Path") %>'>Download</a>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div style="clear:both;height:5px"></div>

        <div class="cell-2  "></div>
        <div class="cell-2  ">
            <asp:LinkButton ID="uLinkButtonUpdate" runat="server" CssClass="btn btn-primary" OnClick="uLinkButtonUpdate_Click">Update status</asp:LinkButton>
        </div>
    </div>
    <div style="clear:both;height:5px"></div>
    <hr />
    <h2>Add comment </h2>

    <div class="cell-12 form-horizontal">        
        <div class="cell-2 bold">
            Comment
        </div>
        
        <div class="cell-5 ">
            <asp:TextBox ID="uiTextBoxDesc" runat="server" TextMode="MultiLine" CssClass="form-control" Rows="5"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" Font-Bold="true" ValidationGroup="add" ControlToValidate="uiTextBoxDesc"> </asp:RequiredFieldValidator>
        </div>
        

        <div style="clear:both;height:5px"></div>

        <div class="cell-2 bold">
            Attachments
        </div>
        <div class="cell-5 ">
            <asp:FileUpload ID="uiFileUploadAttach" runat="server" />
        </div>
        <div style="clear:both;height:5px"></div>

        <div class="cell-2  "></div>
        <div class="cell-2  ">
            <asp:LinkButton ID="uLinkButtonAdd" runat="server" ValidationGroup="add" CssClass="btn btn-primary" OnClick="uLinkButtonAdd_Click">Add comment</asp:LinkButton>
        </div>
    

    </div>
    <div style="clear:both;height:5px"></div>
    <hr />
    <h4>Recent comments</h4>
    <div class="cell-12 ">
        <asp:GridView ID="uiGridViewComments" CssClass="table table-bordered table-condensed" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="uiGridViewComments_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="CommentText" HeaderText="Comment " />
            <asp:BoundField DataField="CommentDate" HeaderText="Date" DataFormatString="{0:dd/MM/yyyy}"/>
           
            <asp:TemplateField HeaderText="Added by">
                <ItemTemplate>
                    <%# Eval("UserName") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Attachment">
                <ItemTemplate>
                    
                   <a href='<%#Eval("Path") %>' style='display:<%# !string.IsNullOrEmpty( Eval("Path").ToString()) ? "block" : "none" %>'>Download</a>
                    
                </ItemTemplate>
            </asp:TemplateField>
           
        </Columns>
           <RowStyle HorizontalAlign="Center" /> 
    </asp:GridView>
    </div>

</asp:Content>
