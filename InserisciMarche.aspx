<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciMarche.aspx.cs" Inherits="InserisciMarche" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Invia" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
