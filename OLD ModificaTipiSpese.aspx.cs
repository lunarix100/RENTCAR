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
        //dichiaro connessione a datadapter nella classe del programma
    protected void Page_Load(object sender, EventArgs e)
    {
        CaricaGriglia();
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        //controllo che sia selezionata una riga
        if (griglia.SelectedRow == null)
        {
            //lblErrore.Text = "ERRORE : nessuna riga selezionata;"
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Nessuna riga selezionata')", true);
            return;
        }

        //dichiaro le variabili
        string nuovaDescrizione = txtModificaTipoSpesa.Text.Trim();
        string vecchiaDescrizione = griglia.SelectedRow.Cells[2].Text.ToString();
        int codice = int.Parse(griglia.SelectedRow.Cells[1].Text.ToString());


        //controlli formali
        if (string.IsNullOrEmpty(nuovaDescrizione))
        {
            //lblErrore.Text = "ERRORE : dati non validi";
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non validi')", true);
            return;
        }
        
        if (vecchiaDescrizione==nuovaDescrizione)
        {
            //lblErrore.Text = "ERRORE : riga gia esistente";
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('riga gia esistente')", true);
            return;
        }        
        //confronto della presenza della nuova descrizione con quelli esistenti per evitare duplicati
        TIPISPESE t = new TIPISPESE();
        
        t.descrizione = nuovaDescrizione;
        t.codicetipospesa = codice;
        
        //verifico che non esista gia
        if (t.CheckOne() == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('riga gia esistente')", true);
            return;
        }
        t.Update();
        griglia.DataBind();
        griglia.SelectedIndex = 0;
        //azzero i campi
        txtModificaTipoSpesa.Text = "";
        //lblErrore.Text = "";
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Successo", "alert('Modifica effettuata')", true);
        CaricaGriglia();
        return;
        

    }

   
    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        {
            GridViewRow riga = griglia.SelectedRow; //assegno a una riga della griglia la riga della griglia selezionata
            txtModificaTipoSpesa.Text = riga.Cells[2].Text; //assegno alla textbox il campo riga selezionata
        }
    }


    protected void CaricaGriglia()
    {
        TIPISPESE t = new TIPISPESE();
        griglia.DataSource = t.SelectAll();
        griglia.DataBind();
    }

}
