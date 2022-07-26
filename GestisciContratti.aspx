<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestisciContratti.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/jquery-ui.min.js"></script>
    <link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/themes/base/jquery-ui.css" type="text/css" media="all" />

    <script type="text/javascript">

        $(document).ready(function () {

            $('.popupInserisci').click(function () {

                var url = 'InserisciContratti.aspx';
                var inserisci = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                inserisci.dialog({
                    modal: true,
                    title: 'Inserisci contratti',
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

    <script>
        $(document).ready(function () {

            $('.popupModifica').click(function () {

                var url = 'ModificaContratti.aspx';
                var inserisci = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                inserisci.dialog({
                    modal: true,
                    title: 'Modifica contratti',
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
    <script>

        $(document).ready(function () {

            $('.popupElimina').click(function () {

                var url = 'EliminaContratti.aspx';
                var inserisci = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                inserisci.dialog({
                    modal: true,
                    title: 'Elimina contratti',
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
    <div>
        <table>
            <tr>
                <td colspan="5">
                    <asp:Button ID="btnInserisci" class="popupInserisci" runat="server" Text="Inserisci contratto" Width="210px" />
                    <asp:Button ID="btnModifica" class="popupModifica" runat="server" Text="Modifica contratto" Enabled="False" />
                    <asp:Button ID="btnElimina" class="popupElimina" runat="server" Text="Elimina contratto" Enabled="False" />
                    <asp:Button ID="btnAggiorna" runat="server" Text="Aggiorna" Width="210px" OnClick="btnAggiorna_Click"  />
                </td>
            </tr>
        </table>
        <asp:GridView ID="griglia" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" DataKeyNames="codiceContratto" OnSelectedIndexChanged="griglia_SelectedIndexChanged" >
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Seleziona" />
        </Columns>
    </asp:GridView>
    </div>
</asp:Content>

