﻿using System;
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

    public void CaricaGriglia()
    {
        SPESE S = new SPESE();
        griglia.DataSource = S.SelectAll();
        griglia.DataBind();
    }

    protected void btnAggiornaGriglia_Click(object sender, EventArgs e)
    {
        CaricaGriglia();

    }

    protected void btnInvia_Click(object sender, EventArgs e)
    {

    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["codiceSpesa"] = griglia.SelectedDataKey[0];
        btnModifica.Enabled = true;

    }
}