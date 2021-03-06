﻿<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerDetails.aspx.cs" Inherits="MyExample.CustomerDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>
</h2>

    <asp:GridView ID="GridView1" runat="server" Width="500px" CellPadding="4" ForeColor="#333333" GridLines="None" EmptyDataText="Data Not Found">

    <AlternatingRowStyle BackColor="White" />

    <EditRowStyle BackColor="#7C6F57" />

    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />

    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />

    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />

    <RowStyle BackColor="#E3EAEB" />

    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />

    <SortedAscendingCellStyle BackColor="#F8FAFA" />

    <SortedAscendingHeaderStyle BackColor="#246B61" />

    <SortedDescendingCellStyle BackColor="#D4DFE1" />

    <SortedDescendingHeaderStyle BackColor="#15524A" />

</asp:GridView>
    </asp:Content>
