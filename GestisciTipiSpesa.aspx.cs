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

    protected void btnInvia_Click(object sender, EventArgs e)
    {
        
    }
    
    public void CaricaGriglia()
    {
        TIPISPESE T = new TIPISPESE();
        griglia.DataSource = T.SelectAll();
        griglia.DataBind();
    }

    protected void btnAggiorna_Click(object sender, EventArgs e)
    {
        CaricaGriglia();
    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["codice"] = int.Parse(griglia.SelectedRow.Cells[1].Text.ToString());
        btnModifica.Enabled = true ;
    }
}