<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OLD InserisciTipiSpese.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="popup">

    <asp:TextBox ID="txtTipoSpesa" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnInserisci" runat="server" Text="Button" OnClick="btnInserisci_Click" /> <br />
    <br />
    <asp:Label ID="lblErrore" runat="server" Text=""></asp:Label>
    <asp:GridView ID="griglia" runat="server"></asp:GridView>
    </div>
</asp:Content>

