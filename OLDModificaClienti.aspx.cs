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
        CaricaGriglia();
    }

    protected void btnModifica_Click(object sender, EventArgs e)
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
        
        CL.codiceCliente = int.Parse(griglia.SelectedRow.Cells[1].Text.ToString());
        CL.regioneSociale = txtRAGSOC.Text.Trim();
        CL.partitaIVA = txtPiva.Text.Trim();
        CL.codiceFiscale = txtCodFisc.Text.Trim();
        CL.indirizzo = txtIndirizzo.Text.Trim();
        CL.cap = txtCap.Text.Trim();
        CL.citta = txtCitta.Text.Trim();
        CL.provincia = txtProvincia.Text.Trim();

        if (CL.CheckOneUpdate() == true)
        {
            //lblErrore.Text = "ERRORE : riga gia esistente";
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('riga gia esistente')", true);
            return;
        }

        CL.Update();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('FORZA NAPOLI')", true);
        CaricaGriglia();

    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow riga = griglia.SelectedRow; //assegno a una riga della griglia la riga della griglia selezionata
        txtRAGSOC.Text = riga.Cells[2].Text;
        txtPiva.Text = riga.Cells[3].Text;
        txtCodFisc.Text = riga.Cells[4].Text;
        txtIndirizzo.Text = riga.Cells[5].Text;
        txtCap.Text = riga.Cells[6].Text;
        txtCitta.Text = riga.Cells[7].Text;
        txtProvincia.Text = riga.Cells[8].Text; 
    }
    public void CaricaGriglia()
    {
        CLIENTI CL = new CLIENTI();
        griglia.DataSource = CL.SelectAll();
        griglia.DataBind();
    }

}