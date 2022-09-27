<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GetDetails.aspx.cs" Inherits="PManage1.UI.GetDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br \ />
    <table align="center" style="width: 50%">
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ObjectDataSource1" Height="125px" Width="923px">
                    <Columns>
                        <asp:CommandField ShowEditButton="True" ShowSelectButton="True" />
                        <asp:BoundField DataField="PensionerID" HeaderText="PensionerID" SortExpression="PensionerID" />
                        <asp:BoundField DataField="AadharID" HeaderText="AadharID" SortExpression="AadharID" />
                        <asp:BoundField DataField="Names" HeaderText="Names" SortExpression="Names" />
                        <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                        <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                        <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                        <asp:BoundField DataField="MobileNo" HeaderText="MobileNo" SortExpression="MobileNo" />
                        <asp:BoundField DataField="BankName" HeaderText="BankName" SortExpression="BankName" />
                        <asp:BoundField DataField="AccountNumber" HeaderText="AccountNumber" SortExpression="AccountNumber" />
                        <asp:BoundField DataField="PensionAmount" HeaderText="PensionAmount" SortExpression="PensionAmount" />
                        <asp:BoundField DataField="Reason" HeaderText="Reason" SortExpression="Reason" />
                    </Columns>
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="PManage.Entities.Pensioner" SelectMethod="GetPensioners" TypeName="Pmanage.BusinessLayer.PensionerService" UpdateMethod="UpdatePensioner"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>
