using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModificaModelli : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Se non vi è nessun elemento selezionato impedisco il proseguimento
            if (string.IsNullOrEmpty(Session["codiceModello"].ToString()))
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
                return;
            }

            MODELLI M = new MODELLI();
            M.codiceModello = int.Parse(Session["codiceModello"].ToString());
            DataTable dt = M.SelectOne();

            CaricaMarche();

            ddlSelezionaMarca.SelectedValue = dt.Rows[0]["codiceMarca"].ToString();
            txtModificaModello.Text = dt.Rows[0]["descrizione"].ToString();
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        // Controlli formali
        if (string.IsNullOrEmpty(txtModificaModello.Text.Trim()) || string.IsNullOrEmpty(txtModificaModello.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Dati non validi')", true);
            return;
        }

        MODELLI M = new MODELLI();

        M.codiceModello = int.Parse(Session["codiceModello"].ToString());

        M.codiceMarca = int.Parse(ddlSelezionaMarca.SelectedValue);
        M.descrizione = txtModificaModello.Text.Trim();

        M.Update();

        // Aggiorno la tabella e resetto i campi
        ScriptManager.RegisterClientScriptBlock(this, GetType(), "SUCCESSO", "alert('Dati modificati correttamente')", true);

        txtModificaModello.Text = "";
        Session["codiceModello"] = null;
    }

    public void CaricaMarche()
    {
        MODELLI M = new MODELLI();

        ddlSelezionaMarca.DataSource = M.SelectForDdl();
        ddlSelezionaMarca.DataTextField = "descrizione";
        ddlSelezionaMarca.DataValueField = "codiceMarca";

        ddlSelezionaMarca.DataBind();
    }
}