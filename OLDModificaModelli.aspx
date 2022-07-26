<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OLDModificaModelli.aspx.cs" Inherits="Default2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="griglia" runat="server" DataKeyNames="CodiceModello,CodiceMarca" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Seleziona" ShowHeader="True" Text="Seleziona" />
        </Columns>
    </asp:GridView>
    <table>
        <tr>
            <td>
                <asp:Label ID="lblSelezionaMarca" runat="server" Text="Seleziona Marca"></asp:Label>
            </td>
            <td colspan="2">
                <asp:DropDownList ID="ddlSelezionaMarca" runat="server" DataSourceID="sdsSELEZIONAMARCHE" DataTextField="descrizione" DataValueField="codiceMarca"></asp:DropDownList>
                <asp:SqlDataSource ID="sdsSELEZIONAMARCHE" runat="server" ConnectionString="<%$ ConnectionStrings:RENTCARConnectionString %>" SelectCommand="SELECT [descrizione], [codiceMarca] FROM [tabMarche]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblModificaModello" runat="server" Text="Modifica Modello"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtModello" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
            </td>
        </tr>
    </table>
    </asp:Content>

