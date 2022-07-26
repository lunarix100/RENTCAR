<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestisciModelli.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/themes/base/jquery-ui.css" type="text/css" media="all" />
    <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/jquery-ui.min.js"></script>

    <script type="text/javascript">

        $(document).ready(function () {

            $('.popupInserisci').click(function () {

                var url = 'InserisciModelli.aspx';
                var pippo = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                pippo.dialog({
                    modal: true,
                    title: 'Inserisci Modelli',
                    resizable: false,
                    width: 800,
                    overlay: { opacity: 0.9, background: 'black' },
                    open: function (type, data) { $(this).parent().appendTo('form'); }
                });
                return false;
            });
        });

    </script>
    <script type="text/javascript">

        $(document).ready(function () {

            $('.popupModifica').click(function () {

                var url = 'ModificaModelli.aspx';
                var pippo = $('<iframe src="' + url + '" width="100%" frameborder="0"></iframe>').appendTo('body');

                pippo.dialog({
                    modal: true,
                    title: 'Modifica Modelli',
                    resizable: false,
                    width: 800,
                    height: 500,
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
    <asp:GridView ID="griglia" runat="server" DataKeyNames="codiceModello" OnSelectedIndexChanged="griglia_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Seleziona" ShowHeader="True" Text="Seleziona" />
        </Columns>
    </asp:GridView> <br />
    <asp:Button ID="btnAggiornaGriglia" runat="server" Text="Aggiorna Griglia" OnClick="btnAggiornaGriglia_Click" />
</asp:Content>

