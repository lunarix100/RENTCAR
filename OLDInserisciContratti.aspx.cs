using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaGriglia();
            CaricaAuto();
            CaricaClienti();
        }
    }


    public void CaricaGriglia()
    {
        CONTRATTI C = new CONTRATTI();
        griglia.DataSource = C.SelectAll();
        griglia.DataBind();
    }
    public void CaricaAuto()
    {
        AUTO a = new AUTO();
        ddlAuto.DataSource = a.SelectForDdl();
        ddlAuto.DataValueField = "codiceAuto";
        ddlAuto.DataTextField = "Automobile";
        ddlAuto.DataBind();
    }

    public void CaricaClienti()
    {
        CLIENTI C = new CLIENTI();
        ddlClienti.DataSource = C.SelectForDdl();
        ddlClienti.DataValueField = "codiceCliente";
        ddlClienti.DataTextField = "Cliente";
        ddlClienti.DataBind();
    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtDataFine.Text) || string.IsNullOrEmpty(txtDataInizio.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non validi')", true);
            return;
        }
        CONTRATTI CT = new CONTRATTI();
        CT.codiceCliente = int.Parse(ddlClienti.SelectedValue.ToString());
        CT.codiceAuto = int.Parse(ddlAuto.SelectedValue.ToString());
        CT.dataInizioContratto = txtDataInizio.Text;
        CT.dataFineContratto = txtDataFine.Text;

        

        CT.Insert();

        CaricaGriglia();
    }
}