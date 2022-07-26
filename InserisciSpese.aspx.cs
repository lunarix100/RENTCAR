using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InserisciSpese : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        CaricaDdl();

        }
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

    }

    public void CaricaDdl()
    {
        SPESE S = new SPESE();

        ddlTipoSpesa.DataSource = S.SelectForDdl();
        ddlTipoSpesa.DataTextField = "descrizione";
        ddlTipoSpesa.DataValueField = "codiceTipoSpesa";

        ddlTipoSpesa.DataBind();
    }

}
