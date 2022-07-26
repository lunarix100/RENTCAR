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
        CaricaGriglia();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow riga = griglia.SelectedRow;
        ddlSelezionaMarca.SelectedValue = griglia.SelectedDataKey[1].ToString();
        txtModello.Text = riga.Cells[3].Text;
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        // controlli formali
        if (string.IsNullOrEmpty(txtModello.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Dati non validi')", true);
            return;
        }    

        // verifica ridondanza
        // prendi il valore della ddl marche
        int valoreMarca = int.Parse(ddlSelezionaMarca.SelectedValue.ToString());

        // prendi il valore della textbox modelli
        string nomeModello = txtModello.Text.Trim();


        MODELLI M = new MODELLI();
        M.descrizione = txtModello.Text;
        M.codiceMarca = int.Parse(griglia.SelectedDataKey[1].ToString());
        M.codiceModello = int.Parse(griglia.SelectedDataKey[1].ToString());

        if (M.CheckOne() == true)
        {
            //lblErrore.Text = "ERRORE : riga gia esistente";
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('riga gia esistente')", true);
            return;
        }

        M.Update();



        // aggiorna la griglia -databind-
        griglia.SelectedIndex = 0;

        ScriptManager.RegisterClientScriptBlock(this, GetType(), "SUCCESSO", "alert('Dati modificati correttamente')", true);
        CaricaGriglia();

    }

    

    protected void CaricaGriglia()
    {
        MODELLI M = new MODELLI();
        griglia.DataSource = M.SelectAll();
        griglia.DataBind();
    }
}