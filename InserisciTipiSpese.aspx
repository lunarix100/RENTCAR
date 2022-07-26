<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciTipiSpese.aspx.cs" Inherits="InserisciTipiSpese2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div>
        <asp:TextBox ID="txtInserisci" runat="server"></asp:TextBox> <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" OnClick="btnInserisci_Click1" /> <br />
        <asp:Label ID="lblErrore" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
