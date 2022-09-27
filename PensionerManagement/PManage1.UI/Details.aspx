<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="PManage1.UI.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br \ >
    <table align="center" style="width: 50%">
        <tr>
            <td>
                <asp:Button ID="btnregister" runat="server" Height="50px" OnClick="btnregister_Click" Text="REGISTER" Width="300px" />
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btndetails" runat="server" Height="50px" OnClick="btndetails_Click" Text="GET DETAILS" Width="300px" />
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btndelete" runat="server" Height="50px" OnClick="btndelete_Click" Text="DELETE" Width="300px" />
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
