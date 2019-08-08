<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyExample._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>This is my example</h1>
    </div>

    <div class="row">
      
        <table style="width: 100%; height: 301px;">
            <tr>
                <td class="modal-sm" style="width: 233px; height: 56px">First Name:</td>
                <td style="height: 36px; width: 263px;padding: 9px 7px 6px 15px">
                    <asp:TextBox ID="txtFName" runat="server" Height="22px" Width="210px"   ></asp:TextBox>
                </td>
                <td style="height: 56px; width: 120px">Last Name:</td>
                <td style="height: 56px">
                    <asp:TextBox ID="txtLName" runat="server" Width="191px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 233px">Contact Info:</td>
                <td class="modal-sm" style="width: 263px">
                    <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="210px"></asp:TextBox>
                </td>
                <td style="width: 120px">Telephone No:</td>
                <td>
                    <asp:TextBox ID="txttelephone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 233px">Address:</td>
                <td class="modal-sm" style="width: 263px">
                    <asp:TextBox ID="txtAddress" runat="server" Height="22px" Width="210px"></asp:TextBox>
                </td>
                <td style="width: 120px">Address2:</td>
                <td>
                    <asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="modal-sm" style="width: 233px">&nbsp;</td>
                <td class="modal-sm" style="width: 263px">
                    &nbsp;</td>
                <td style="width: 120px">
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="117px" />
                 </td>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save" Width="171px" />
                </td>
            </tr>
        </table>
      
    </div>

</asp:Content>
