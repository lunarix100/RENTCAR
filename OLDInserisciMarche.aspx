<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OLDInserisciMarche.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>
                <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnInserisci" runat="server" Text="Button" OnClick="btnInserisci_Click" />
            </td>
        </tr>
        <tr>
            <td colspan ="2">
                <asp:GridView ID="griglia" runat="server"></asp:GridView>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

