using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InserisciTipiSpese2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    

    protected void btnInserisci_Click1(object sender, EventArgs e)
    {
       
            if (string.IsNullOrEmpty(txtInserisci.Text))
            {
                lblErrore.Text = "ERRORE, Dati non validi";
                return;
            }

            TIPISPESE t = new TIPISPESE();
            t.descrizione = txtInserisci.Text;
            //verifico che non esista gia
            if (t.CheckOne() == true)
            {
                lblErrore.Text = "Tipo Spesa gia Inserito";
                return;
            }
            //se non esiste faccio insert
            t.Insert();

            lblErrore.Text = "Tipo Spesa inserito";

            txtInserisci.Text = "";


        
    }
}