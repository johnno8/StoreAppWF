<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Permissions.aspx.cs" Inherits="StoreAppWF.Permissions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="permissionsGrid"
        ItemType="StoreAppWF.Models.Permission" DataKeyNames="PermissionID" 
        SelectMethod="permissionsGrid_GetData"
        AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="PermissionID" />
            <asp:DynamicField DataField="Title" />
            <asp:DynamicField DataField="Description" />        
        </Columns>
    </asp:GridView>
</asp:Content>
