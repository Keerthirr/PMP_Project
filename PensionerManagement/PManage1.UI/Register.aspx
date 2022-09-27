<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PManage1.UI.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br \><br \>
    <table align="center" style="width: 50%">
        <tr>
            <td style="height: 20px">PensionerID:</td>
            <td style="height: 20px">
                <asp:TextBox ID="txtpid" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtpid" ErrorMessage="Pls enter ID"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>AadharID:</td>
            <td>
                <asp:TextBox ID="txtaid" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtaid" ErrorMessage="Pls enter AadharNo"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Name:</td>
            <td>
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtname" ErrorMessage="Enter Name"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Age:</td>
            <td>
                <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtage" ErrorMessage="Invalid Age" MaximumValue="100" MinimumValue="60" Type="Integer"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>Gender:</td>
            <td>
                <asp:RadioButtonList ID="radiobutton0" runat="server" Height="16px"  RepeatDirection="Horizontal" style="margin-left: 0px" Width="186px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>Address:</td>
            <td>
                <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 25px">MobileNo:</td>
            <td style="height: 25px">
                <asp:TextBox ID="txtmobileno" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtmobileno" ErrorMessage="Enter MobileNo"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 22px">BankName:</td>
            <td style="height: 22px">
                <asp:TextBox ID="txtbankname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>AccountNumber:</td>
            <td>
                <asp:TextBox ID="txtaccountnumber" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtaccountnumber" ErrorMessage="Enter AccountNo"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>PensionAmount:</td>
            <td>
                <asp:TextBox ID="txtpensionamount" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Reason:</td>
            <td>
                <asp:DropDownList ID="ddl1" runat="server">
                    <asp:ListItem>WIDOW</asp:ListItem>
                    <asp:ListItem>OLD</asp:ListItem>
                    <asp:ListItem>PH</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnregister" runat="server" Text="Register" OnClick="Register_Pensioner" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="lbnmsg" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
