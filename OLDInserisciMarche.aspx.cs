using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Default2 : System.Web.UI.Page
{
    //creo gli elementi della connessione    
    SqlConnection conn = new SqlConnection(@"Data Source=LUNARIX-PC\SQLEXPRESS;Initial Catalog=RENTCAR;Integrated Security=true;");
    SqlCommand cmd = new SqlCommand();  
    SqlDataAdapter DA = new SqlDataAdapter();
    DataTable dt = new DataTable();
   
    protected void Page_Load(object sender, EventArgs e)
    {       
        CaricaGriglia();
    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        //creo le variabili dell'inserimento
        string nuovaMarca = txtMarca.Text.Trim();

        //controllimo l'effettivo inserimento di una marca
        if (string.IsNullOrEmpty(nuovaMarca))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Campo non completo')", true);
            return;
        }

        MARCHE M = new MARCHE();
        M.descrizione = nuovaMarca;
        //preparo gli elementi per il controllo che la marca sia unica

        //controllo che la marca sia unica
        if (M.CheckOne() == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Inserimento marca già effettuato')", true);
            return;
        }

        M.Insert();
     

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Eccellente!", "alert('Marca inserita')", true);
        txtMarca.Text = "";

        CaricaGriglia();
    }

    protected void CaricaGriglia()
    {
        MARCHE M = new MARCHE();
        griglia.DataSource = M.SelectAll();
        griglia.DataBind();

    }
}