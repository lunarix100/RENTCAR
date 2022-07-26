using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InserisciMarche : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
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
    }
}