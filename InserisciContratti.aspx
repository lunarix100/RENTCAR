<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciContratti.aspx.cs" Inherits="InserisciContratti" %>

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
            <asp:Button ID="btnSalva" runat="server" Text="Salva" OnClick="btnSalva_Click"  />
        </div>
    </form>
</body>
</html>
