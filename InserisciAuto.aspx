﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciAuto.aspx.cs" Inherits="InserisciAuto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Modello"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlModello" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Targa"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTarga" runat="server"> </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Costo vettura"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCosto" runat="server"> </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Prezzo noleggio"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPrezzo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Data acquisto"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtData" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" OnClick="btnInserisci_Click" />
        </div>
    </form>
</body>
</html>
