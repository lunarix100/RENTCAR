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

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnElimina_Click(object sender, EventArgs e)
    {
        SPESE S = new SPESE();
        S.codiceSpesa = int.Parse(griglia.SelectedRow.Cells[1].Text.ToString());

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Successo", "alert('Dati eliminati')", true);
        S.Delete();

        CaricaGriglia();
    }

    protected void CaricaGriglia()
    {
        SPESE S = new SPESE();
        griglia.DataSource = S.SelectAll();
        griglia.DataBind();
    }
}