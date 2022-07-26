<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OLDInserisci Modelli.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td><b>Marca</b></td>
            <td colspan="2"><b>Modello</b></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlMarca" runat="server" DataSourceID="sdsMarche" DataTextField="descrizione" DataValueField="codiceMarca"></asp:DropDownList>
                <asp:SqlDataSource ID="sdsMarche" runat="server" ConnectionString="<%$ ConnectionStrings:RENTCARConnectionString %>" SelectCommand="SELECT [codiceMarca], [descrizione] FROM [tabMarche]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:TextBox ID="txtModello" runat="server"></asp:TextBox></td>
            <td>
                <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" OnClick="btnInserisci_Click" /></td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="griglia" runat="server"></asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>