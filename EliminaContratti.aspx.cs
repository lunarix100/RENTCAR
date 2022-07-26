using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Elimina_Contratti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (string.IsNullOrEmpty(Session["codiceContratto"].ToString()))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE!", "alert('Inserisci dati validi!')", true);
                return;
            }
        }
    }

    protected void btnElimina_Click(object sender, EventArgs e)
    {
        CONTRATTI c = new CONTRATTI();
        c.codiceContratto = int.Parse(Session["codiceContratto"].ToString());
        DataTable dt = c.SelectOne();

        c.Delete();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO!", "alert('Eliminazione avvenuta!')", true);
        return;
    }
}