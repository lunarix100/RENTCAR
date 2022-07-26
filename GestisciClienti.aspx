<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestisciClienti.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/themes/base/jquery-ui.css" type="text/css" media="all" />
    <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/jquery-ui.min.js"></script>

    <script type="text/javascript">

        $(document).ready(function () {

            $('.popupInserisci').click(function () {

                var url = 'InserisciClienti.aspx';
                var pippo = $('<iframe src="' + url + '"frameborder="0"></iframe>').appendTo('body');

                pippo.dialog({
                    modal: true,
                    title: 'Inserisci Clienti',
                    resizable: true,
                    width: '400px',
                    overlay: { opacity: 0.9, background: 'black' },
                    open: function (type, data) { $(this).parent().appendTo('form'); }
                });
                return false;
            });
        });

        $(document).ready(function () {

            $('.popupModifica').click(function () {

                var url = 'ModificaClienti.aspx';
                var pippo = $('<iframe src="' + url + '"frameborder="0"></iframe>').appendTo('body');

                pippo.dialog({
                    modal: true,
                    title: 'Modifica Clienti',
                    resizable: true,
                    width: '400px',
                    overlay: { opacity: 0.9, background: 'black' },
                    open: function (type, data) { $(this).parent().appendTo('form'); }
                });
                return false;
            });
        });

        

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <table>
       <tr>
           <td> <asp:Button Class="popupInserisci" ID="btnInvia" runat="server" Text="Inserisci" /></td>
           <td> <asp:Button Class="popupModifica" ID="btnModifica" runat="server" Text="Modifica" Enabled="False" /></td>
       </tr>
</table>
    <asp:GridView ID="griglia" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="griglia_SelectedIndexChanged" DataKeyNames="codiceCliente">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Seleziona" ShowHeader="True" Text="Seleziona" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView> <br />
    <asp:Button ID="btnAggiornaGriglia" runat="server" Text="Aggiorna Griglia" OnClick="btnAggiornaGriglia_Click" />
</asp:Content>

