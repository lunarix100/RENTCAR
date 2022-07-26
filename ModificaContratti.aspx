<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaContratti.aspx.cs" Inherits="ModificaContratti" %>

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
                    <asp:DropDownList ID="ddlClienti" runat="server"></asp:DropDownList>
                    <asp:DropDownList ID="ddlAuto" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtInizioContratto" runat="server" TextMode="Date"></asp:TextBox>
                    <asp:TextBox ID="txtFineContratto" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
        </div>
    </form>
</body>
</html>
