<%@ Page Title="Your Purchases" Language="C#" MasterPageFile="~/CoolWheels.master" AutoEventWireup="true" CodeBehind="Purchases.aspx.cs" Inherits="CoolWheels.Purchases" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h2>Your Purchases</h2>
        <asp:GridView ID="purchasesGridView" runat="server" CssClass="purchasesGridView" AutoGenerateColumns="True"></asp:GridView>
    </div>
</asp:Content>
