<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="StoreAppWF.Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <asp:GridView runat="server" ID="usersGrid"
        ItemType="StoreAppWF.Models.User" DataKeyNames="ID" 
        SelectMethod="usersGrid_GetData"
        AutoGenerateColumns="False">
        <Columns>
            <asp:DynamicField DataField="ID" />
            <asp:DynamicField DataField="Name" />
            <asp:DynamicField DataField="Address" />
            <asp:DynamicField DataField="Nationality" />
            <asp:TemplateField HeaderText="Permissions">
                <ItemTemplate>
                    <asp:GridView ID="upGrid" runat="server" AutoGenerateColumns="False" DataKeyNames="UserID" ItemType="StoreAppWF.Models.UserPermission" SelectMethod="upGrid_GetData">
                        <Columns>
                            <asp:DynamicField DataField="Title" />
                         </columns>
                    </asp:gridview>
                </itemtemplate>
            </asp:templatefield> 
        </Columns>
    </asp:GridView>
</asp:Content>
