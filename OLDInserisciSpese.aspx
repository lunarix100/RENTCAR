<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OLDInserisciSpese.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <td><b>Tipo Spesa</b></td>
            <td><b>Importo</b></td>
            <td><b>Data Spesa</b></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlTipoSpesa" runat="server" DataSourceID="SqlDataSource1" DataTextField="descrizione" DataValueField="codiceTipoSpesa"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RENTCARConnectionString %>" SelectCommand="SELECT [descrizione], [codiceTipoSpesa] FROM [tabTIPISPESE] ORDER BY [descrizione]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:TextBox ID="txtImporto" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtDataSpesa" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspanì="2"></td>
            <td>
                <asp:Button ID="btnInvia" runat="server" Text="Aggiungi Spesa" OnClick="btnInvia_Click" />
            </td>

            <%--<asp:Label ID="lblErrore" runat="server" Text=""></asp:Label>--%>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView runat="server" ID="griglia"></asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

