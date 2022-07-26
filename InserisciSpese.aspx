<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciSpese.aspx.cs" Inherits="InserisciSpese" %>

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
            <td><b>Tipo Spesa</b></td>
            <td><b>Importo</b></td>
            <td><b>Data Spesa</b></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlTipoSpesa" runat="server" DataTextField="descrizione" DataValueField="codiceTipoSpesa"></asp:DropDownList>
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
        
    </table>
        </div>
    </form>
</body>
</html>
