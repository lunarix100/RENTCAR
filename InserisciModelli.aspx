<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciModelli.aspx.cs" Inherits="InserisciModelli" %>

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
    </table>
        </div>
    </form>
</body>
</html>
