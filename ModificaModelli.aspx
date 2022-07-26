<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaModelli.aspx.cs" Inherits="ModificaModelli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
            <table style="width:100%">
                <tr>
                    <td>
                        <asp:Label ID="lblImporto" runat="server" Text="Marca"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlSelezionaMarca" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblModificaModello" runat="server" Text="Modello"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtModificaModello" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
            </table>
            <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
    </form>
</body>
</html>
