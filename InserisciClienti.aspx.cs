using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InserisciClienti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInvia_Click(object sender, EventArgs e)
    {
        //controlli formali
        if (string.IsNullOrEmpty(txtRAGSOC.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Campo Vuoto')", true);
            return;
        }
        if (string.IsNullOrEmpty(txtPiva.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Campo Vuoto')", true);
            return;
        }
        if (string.IsNullOrEmpty(txtCodFisc.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Campo Vuoto')", true);
            return;
        }
        if (string.IsNullOrEmpty(txtIndirizzo.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Campo Vuoto')", true);
            return;
        }
        if (string.IsNullOrEmpty(txtCap.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Campo Vuoto')", true);
            return;
        }
        if (string.IsNullOrEmpty(txtCitta.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Campo Vuoto')", true);
            return;
        }
        if (string.IsNullOrEmpty(txtProvincia.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ATTENZIONE", "alert('Campo Vuoto')", true);
            return;
        }
        CLIENTI CL = new CLIENTI();
        CL.regioneSociale = txtRAGSOC.Text.Trim();
        CL.partitaIVA = txtPiva.Text.Trim();
        CL.codiceFiscale = txtCodFisc.Text.Trim();
        CL.indirizzo = txtIndirizzo.Text.Trim();
        CL.cap = txtCap.Text.Trim();
        CL.citta = txtCitta.Text.Trim();
        CL.provincia = txtProvincia.Text.Trim();


        if (CL.CheckOne() == true)
        {
            //lblErrore.Text = "ERRORE : riga gia esistente";
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('riga gia esistente')", true);
            return;
        }


        CL.Insert();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "successo", "alert('campi inseriti')", true);
    }
}