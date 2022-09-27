<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PManage1.UI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br \ />
    <table align="center" style="width: 50%; height:323px;background-color:cadetblue">
        <tr>
            <td style="font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: bold; font-style: italic; font-variant: normal; text-transform: none; color: #000000">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ADMIN PANNEL&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <table align="center" class="nav-justified">
                    <tr>
                        <td style="height: 42px; font-family: 'Times New Roman', Times, serif; font-size: medium; font-weight: bold; font-style: italic; font-variant: normal; text-transform: none; color: #000000;">User Name:</td>
                        <td style="height: 42px">
                            <asp:TextBox ID="txtun" runat="server"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td style="font-family: 'Times New Roman', Times, serif; font-size: medium; font-weight: bold; font-style: italic; font-variant: normal; text-transform: none; color: #000000">Password:</td>
                        <td>
                            <asp:TextBox ID="txtpw" runat="server" TextMode="Password"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" />
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="lblmsg" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
                &nbsp;</td>
        </tr>
</table>
    <br \ >
</asp:Content>
