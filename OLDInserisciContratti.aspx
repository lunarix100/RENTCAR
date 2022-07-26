<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OLDInserisciContratti.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:DropDownList ID="ddlClienti" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:DropDownList ID="ddlAuto" runat="server"></asp:DropDownList></div>

    <asp:Button ID="btnInserisci" runat="server" Text="Button" OnClick="btnInserisci_Click" />

    <asp:Label ID="lblDataInizio" runat="server" Text="">Data Inizio</asp:Label> 

    <asp:TextBox ID="txtDataInizio" runat="server" TextMode="Date"></asp:TextBox>

    <asp:Label ID="lblDataFine" runat="server" Text="Data Fine"></asp:Label>
    
    <asp:TextBox ID="txtDataFine" runat="server" TextMode="Date"></asp:TextBox>

    <asp:GridView ID="griglia" runat="server"></asp:GridView>
    <br />
</asp:Content>

