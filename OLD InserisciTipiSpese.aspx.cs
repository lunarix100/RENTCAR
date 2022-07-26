using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)

    {

        CaricaGriglia();

        //c.query = "tabTipiSpese.SelectAll";
        //griglia.DataSource = c.EseguiSp(c.query);
        //DataValueField = "codiceTipoSpesa";
        //griglia.DataTextField = "descrizione";
        //griglia.DataBind();
    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtTipoSpesa.Text))
        {
            lblErrore.Text = "ERRORE, Dati non validi";
            return;
        }

        TIPISPESE t = new TIPISPESE();
        t.descrizione = txtTipoSpesa.Text;
        //verifico che non esista gia
        if (t.CheckOne() == true)
        {
            lblErrore.Text = "Tipo Spesa gia Inserito";
            return;
        }
        //se non esiste faccio insert
        t.Insert();       
        
        lblErrore.Text = "Tipo Spesa inserito";
        
        txtTipoSpesa.Text = "";
       
        CaricaGriglia();
    }
    protected void CaricaGriglia()
    {
        TIPISPESE t = new TIPISPESE();
        griglia.DataSource = t.SelectAll();
        griglia.DataBind();
    }
}






    
       