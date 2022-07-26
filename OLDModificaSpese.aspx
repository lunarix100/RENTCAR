<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OLDModificaSpese.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>
                <asp:Label ID="lblCodiceTipoSpesa" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlCodiceTipoSpesa" runat="server" DataSourceID="sdsTIPISPESA" DataTextField="descrizione" DataValueField="codiceTipoSpesa"></asp:DropDownList>
                <asp:SqlDataSource ID="sdsTIPISPESA" runat="server" ConnectionString="<%$ ConnectionStrings:RENTCARConnectionString %>" SelectCommand="SELECT [codiceTipoSpesa], [descrizione] FROM [tabTIPISPESE]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblImporto" runat="server" Text="Importo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtImporto" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDataSpesa" runat="server" Text="Data Spesa"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDataSpesa" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />

    <asp:GridView ID="griglia" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Seleziona" ShowHeader="True" Text="Seleziona" />
        </Columns>
    </asp:GridView>
    </asp:Content>

