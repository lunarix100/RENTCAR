using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InserisciModelli : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        //dichiarazione delle variabili
        string nuovoModello = txtModello.Text.Trim();
        int codiceMarca = int.Parse(ddlMarca.SelectedValue);

        //faccio i controlli formali
        //controllo se la stringa e nuova
        if (string.IsNullOrEmpty(nuovoModello))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Campo Vuoto')", true);
            return;
        }
        MODELLI M = new MODELLI();
        M.descrizione = nuovoModello;
        M.codiceMarca = codiceMarca;

        M.Insert();


        //mostro il messaggio di conferma
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Dati Inseriti Correttamente')", true);
        //pulisco i campi      
        txtModello.Text = "";
        //aggiorna la griglia
    }
}