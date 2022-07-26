<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaTipiSpese.aspx.cs" Inherits="ModificaTipiSpese" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtModifica" runat="server"></asp:TextBox>
            <asp:Button ID="btnModifica" runat="server" Text="Button" OnClick="btnModifica_Click" /><br />
            <asp:Label ID="lblErrore" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
