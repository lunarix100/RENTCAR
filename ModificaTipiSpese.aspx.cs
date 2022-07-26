using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModificaTipiSpese : System.Web.UI.Page
{
    private object txtModificaTipiSpese;

    protected void Page_Load(object sender, EventArgs e)
    {
        {
            if (!IsPostBack)
            {
                TIPISPESE T = new TIPISPESE();
                T.codicetipospesa = int.Parse(Session["codice"].ToString());
                DataTable dt = T.SelectOne();

                txtModifica.Text = dt.Rows[0]["descrizione"].ToString();
            }
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        
        //controllo che sia selezionata una riga
        if (string.IsNullOrEmpty(Session["codice"].ToString()))
        {
            //lblErrore.Text = "ERRORE : nessuna riga selezionata;"
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Nessuna riga selezionata')", true);
            return;
        }

        //dichiaro le variabili
        string nuovaDescrizione = txtModifica.Text.Trim();

        //controlli formali
        if (string.IsNullOrEmpty(nuovaDescrizione))
        {
            //lblErrore.Text = "ERRORE : dati non validi";
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non validi')", true);
            return;
        }

        //confronto della presenza della nuova descrizione con quelli esistenti per evitare duplicati
        TIPISPESE t = new TIPISPESE();

        t.descrizione = txtModifica.Text.Trim();
        t.codicetipospesa = int.Parse(Session["codice"].ToString());

        //verifico che non esista gia
        if (t.CheckOne() == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('riga gia esistente')", true);
            return;
        }
        t.Update();
        
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Successo", "alert('Modifica effettuata')", true);
        //azzero i campi
        txtModifica.Text = "";
        //lblErrore.Text = "";

        return;
    }
}