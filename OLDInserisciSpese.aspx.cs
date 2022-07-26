using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Caricagriglia();
    }

    protected void btnInvia_Click(object sender, EventArgs e)
    {
        // Faccio i controlli formali prima di riservare memoria alle variabili
        if (string.IsNullOrEmpty(txtImporto.Text) || string.IsNullOrEmpty(txtDataSpesa.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non validi')", true);
            return;
        }

        if (decimal.TryParse(txtImporto.Text, out decimal result) == false)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non validi')", true);
            return;
        }

        SPESE S = new SPESE();
        S.codiceTipoSpesa = int.Parse(ddlTipoSpesa.SelectedValue);
        S.importo = decimal.Parse(txtImporto.Text.ToString());
        S.dataSpesa = txtDataSpesa.Text.Trim();

        S.Insert();

        // Mostro il messaggio di conferma
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Successo", "alert('Spesa inserita')", true);
        txtImporto.Text = "";

        //ripulisco i campi


        ddlTipoSpesa.SelectedIndex = 0;
        

        //lego la griglia con l'origine dei dati
        Caricagriglia();
    }

    protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    public void Caricagriglia()
    {
        SPESE S = new SPESE();
        griglia.DataSource = S.SelectAll();
        griglia.DataBind();
    }

}