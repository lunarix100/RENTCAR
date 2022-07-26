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



        if (griglia.SelectedRow == null)
        {
            //lblErrore.Text = "ERRORE : nessuna riga selezionata;"
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Nessuna riga selezionata')", true);
            return;
        }
        if (string.IsNullOrEmpty(txtImporto.Text.Trim()))
        {
            //lblErrore.Text = "ERRORE : nessuna riga selezionata;"
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Campo importo vuoto')", true);
            return;
        }
        if (string.IsNullOrEmpty(txtDataSpesa.Text))
        {
            //lblErrore.Text = "ERRORE : nessuna riga selezionata;"
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Nessuna data inserita')", true);
            return;
        }

        SPESE S = new SPESE();
        S.codiceSpesa = int.Parse(griglia.SelectedRow.Cells[1].Text.ToString());
        S.importo = decimal.Parse(txtImporto.Text.Trim());
        S.dataSpesa = txtDataSpesa.Text.ToString();
        S.codiceTipoSpesa = int.Parse(ddlCodiceTipoSpesa.Text.ToString());
        //S.codiceTipoSpesa =

        S.Update();
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Successo", "alert('Dati modificati')", true);
        CaricaGriglia();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = griglia.SelectedRow;
        ddlCodiceTipoSpesa.SelectedValue = row.Cells[2].Text;
        txtImporto.Text = row.Cells[4].Text;
        txtDataSpesa.Text = row.Cells[5].Text;
    }

    protected void CaricaGriglia()
    {
        SPESE S = new SPESE();
        griglia.DataSource = S.SelectAll();
        griglia.DataBind();
    }
}