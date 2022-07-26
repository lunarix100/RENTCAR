<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OLD ModificaTipiSpese.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:TextBox ID="txtModificaTipoSpesa" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnModificaTipiSpesa" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
    <br />
    <br />
    <%--<asp:Label ID="lblErrore" runat="server" Text=""></asp:Label>--%>
    <asp:GridView ID="griglia" runat="server" OnSelectedIndexChanged="griglia_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Selezione" ShowHeader="True" Text="Seleziona" />
        </Columns>
    </asp:GridView>
    </asp:Content>

