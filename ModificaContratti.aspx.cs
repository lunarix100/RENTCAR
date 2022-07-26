using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModificaContratti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Se non vi è nessun elemento selezionato impedisco il proseguimento
            if (string.IsNullOrEmpty(Session["codiceContratto"].ToString()))
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
                return;
            }

            CONTRATTI c = new CONTRATTI();
            c.codiceContratto = int.Parse(Session["codiceContratto"].ToString());
            DataTable dt = c.SelectOne();

            caricaDDLAuto();
            caricaDDLClienti();

            ddlAuto.SelectedValue = dt.Rows[0]["codiceAuto"].ToString();
            ddlClienti.SelectedValue = dt.Rows[0]["codiceCliente"].ToString();
            txtInizioContratto.Text = dt.Rows[0]["dataInizioContratto"].ToString();
            txtFineContratto.Text = dt.Rows[0]["dataFineContratto"].ToString();
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        // Controlli formali
        if (string.IsNullOrEmpty(txtInizioContratto.Text.Trim()) || string.IsNullOrEmpty(txtFineContratto.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Dati non validi')", true);
            return;
        }

        CONTRATTI c = new CONTRATTI();

        c.codiceContratto = int.Parse(Session["codiceContratto"].ToString());
        c.codiceAuto = int.Parse(ddlAuto.SelectedValue);
        c.codiceCliente = int.Parse(ddlClienti.SelectedValue);
        c.dataInizioContratto = txtInizioContratto.Text.Trim();
        c.dataFineContratto = txtFineContratto.Text.Trim();

        c.Update();

        // Aggiorno la tabella e resetto i campi
        ScriptManager.RegisterClientScriptBlock(this, GetType(), "SUCCESSO", "alert('Dati modificati correttamente')", true);

        txtInizioContratto.Text = "";
        txtFineContratto.Text = "";
        Session["codiceContratto"] = null;
    }

    protected void caricaDDLAuto()
    {
        // carico dati in ddl
        AUTO a = new AUTO();

        // SelectAll ritorna DataTable
        ddlAuto.DataSource = a.SelectForDdl();
        ddlAuto.DataValueField = "codiceAuto";
        ddlAuto.DataTextField = "Automobile";
        ddlAuto.DataBind();
    }
    protected void caricaDDLClienti()
    {
        // carico dati in ddl
        CLIENTI c = new CLIENTI();

        // SelectAll ritorna DataTable
        ddlClienti.DataSource = c.SelectForDdl();
        ddlClienti.DataValueField = "codiceCliente";
        ddlClienti.DataTextField = "Cliente";
        ddlClienti.DataBind();
    }
}