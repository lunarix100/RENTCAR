using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InserisciContratti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        caricaDDLAuto();
        caricaDDLClienti();
    }

    protected void btnSalva_Click(object sender, EventArgs e)
    {
        CONTRATTI c = new CONTRATTI();
        c.codiceAuto = int.Parse(ddlAuto.SelectedValue);
        c.codiceCliente = int.Parse(ddlClienti.SelectedValue);
        c.dataInizioContratto = txtInizioContratto.Text.Trim();
        c.dataFineContratto = txtFineContratto.Text.Trim();

        c.Insert();

        //reset table dropdownlist
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati inseriti correttamente')", true);

        txtInizioContratto.Text = "";
        txtFineContratto.Text = "";
        ddlClienti.SelectedIndex = 0;
        ddlAuto.SelectedIndex = 0;
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