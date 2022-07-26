using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModificaClienti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (string.IsNullOrEmpty(Session["codiceCliente"].ToString()))
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Seleziona una riga da modificare')", true);
                return;
            }
                CLIENTI C = new CLIENTI();
                C.codiceCliente = int.Parse(Session["codiceCliente"].ToString());
                DataTable dt = C.SelectOne();

                txtRAGSOC.Text = dt.Rows[0]["regioneSociale"].ToString();
                txtPiva.Text = dt.Rows[0]["partitaIVA"].ToString();
                txtCodFisc.Text = dt.Rows[0]["codiceFiscale"].ToString();
                txtIndirizzo.Text = dt.Rows[0]["indirizzo"].ToString();
                txtCap.Text = dt.Rows[0]["cap"].ToString();
                txtCitta.Text = dt.Rows[0]["citta"].ToString();
                txtProvincia.Text = dt.Rows[0]["provincia"].ToString();
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        // Controlli formali
        if (string.IsNullOrEmpty(txtRAGSOC.Text.Trim()) || 
            string.IsNullOrEmpty(txtPiva.Text.Trim()) || 
            string.IsNullOrEmpty(txtCodFisc.Text.Trim()) ||
            string.IsNullOrEmpty(txtIndirizzo.Text.Trim()) ||
            string.IsNullOrEmpty(txtCap.Text.Trim()) ||
            string.IsNullOrEmpty(txtCitta.Text.Trim()) ||
            string.IsNullOrEmpty(txtProvincia.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Dati non validi')", true);
            return;
        }

        CLIENTI C = new CLIENTI();

        C.codiceCliente = int.Parse(Session["codiceCliente"].ToString());
        C.regioneSociale = txtRAGSOC.Text.Trim();
        C.partitaIVA = txtPiva.Text.Trim();
        C.codiceFiscale = txtCodFisc.Text.Trim();
        C.indirizzo = txtIndirizzo.Text.Trim();
        C.cap = txtCap.Text.Trim();
        C.citta = txtCitta.Text.Trim();
        C.provincia = txtProvincia.Text.Trim();



        C.Update();

        // Aggiorno la tabella e resetto i campi
        ScriptManager.RegisterClientScriptBlock(this, GetType(), "SUCCESSO", "alert('Dati modificati correttamente')", true);

        txtRAGSOC.Text = "";
        txtPiva.Text = "";
        txtCodFisc.Text = "";
        txtIndirizzo.Text = "";
        txtCap.Text = "";
        txtCitta.Text = "";
        txtProvincia.Text = "";
        Session["codiceCliente"] = null;
    }
}