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
        </Columns>
    </asp:GridView>
</asp:Content>
