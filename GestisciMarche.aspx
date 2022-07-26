<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestisciMarche.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/themes/base/jquery-ui.css" type="text/css" media="all" />
    <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/jquery-ui.min.js"></script>

    <script type="text/javascript">

        $(document).ready(function () {

            $('.popupInserisci').click(function () {

                var url = 'InserisciMarche.aspx';
                var pippo = $('<iframe src="' + url + '"frameborder="0"></iframe>').appendTo('body');

                pippo.dialog({
                    modal: true,
                    title: 'inserimento TipiSpese',
                    resizable: false,
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
            <td>
                <asp:Button class="popupInserisci" ID="btnInvia" runat="server" Text="Invia" OnClick="btnInvia_Click" /></td>
            <td>
                <asp:Button ID="btnModifica" runat="server" Text="Modifica" /></td>
        </tr>
    </table>
    <asp:GridView ID="griglia" runat="server"></asp:GridView><br />
    <asp:Button ID="Button1" runat="server" Text="Aggiorna Griglia" OnClick="Button1_Click" />

</asp:Content>

