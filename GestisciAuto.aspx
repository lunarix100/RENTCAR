﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestisciAuto.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/jquery-ui.min.js"></script>

    <script type="text/javascript">

        $(document).ready(function () {

            $('.popupInserisci').click(function () {

                var url = 'InserisciAuto.aspx';
                var inserisci = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                inserisci.dialog({
                    modal: true,
                    title: 'Inserimento Auto',
                    resizable: false,
                    width: '400px',
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

                var url = 'ModificaAuto.aspx';
                var inserisci = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');

                inserisci.dialog({
                    modal: true,
                    title: 'Modifica Auto',
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
    <div>

        <asp:Button ID="btnInserisci" class="popupInserisci" runat="server" Text="Inserisci" />
        <asp:Button ID="btnModifica" class="popupModifica" runat="server" Text="Modifica" Enabled="False" OnClick="btnModifica_Click" />
        <asp:Button ID="btnAggiorna" runat="server" Text="Aggiorna Griglia" OnClick="btnAggiorna_Click"  />

    </div>
    <div>

        <asp:GridView ID="griglia" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" DataKeyNames="codiceAuto" OnSelectedIndexChanged="griglia_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Seleziona" ShowHeader="True" Text="Seleziona" />
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>

    </div>
</asp:Content>

