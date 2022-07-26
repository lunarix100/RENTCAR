using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{ //dichiaro connessione a datadapter nella classe del programma
    SqlConnection conn = new SqlConnection(@"Data Source=LUNARIX-PC\SQLEXPRESS;Initial Catalog=RENTCAR;Integrated Security=true;");
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter DA = new SqlDataAdapter();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        CaricaGriglia();
    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow riga = griglia.SelectedRow; //assegno a una riga della griglia la riga della griglia selezionata
        txtMarca.Text = riga.Cells[2].Text; //assegno alla textbox il campo riga selezionata
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        if (griglia.SelectedRow == null)
        {
            //lblErrore.Text = "ERRORE : nessuna riga selezionata;"
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Nessuna riga selezionata')", true);
            return;


        }
        //dichiaro le variabili

        string nuovaMarca = txtMarca.Text.Trim();
        string vecchiaMarca = griglia.SelectedRow.Cells[2].Text.ToString();
        int codice = int.Parse(griglia.SelectedRow.Cells[1].Text.ToString());

        MARCHE M = new MARCHE();
        M.descrizione = nuovaMarca;
        M.codiceMarca = codice;
        //controlli formali
        if (string.IsNullOrEmpty(M.descrizione))
        {
            //lblErrore.Text = "ERRORE : dati non validi";
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non validi')", true);
            return;
        }
        if (vecchiaMarca == nuovaMarca)
        {
            //lblErrore.Text = "ERRORE : dati non validi";
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati gia esistend')", true);
            return;
        }

        if (M.CheckOne() == true)
        {
            //lblErrore.Text = "ERRORE : riga gia esistente";
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('riga gia esistente')", true);
            return;
        }

        M.Update();              

        //azzero i campi
        txtMarca.Text = "";
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Successo", "alert('Marca modificata con successo')", true);
        //lblErrore.Text = "";
        CaricaGriglia();
    }
    public void CaricaGriglia()
    {
        MARCHE M = new MARCHE();
        griglia.DataSource = M.SelectAll();
        griglia.DataBind();
    }




    
}