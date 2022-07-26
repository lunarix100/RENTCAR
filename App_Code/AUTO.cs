using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class AUTO
{

    public int codiceAuto;
    public int codiceModello;
    public string targa;
    public decimal prezzo;
    public decimal costo;
    public string dataAcquisto;
    public AUTO()
    {
        
    }
    public DataTable SelectAll()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("tabAuto_SelectAll");

    }

    public DataTable SelectDdl()
    {
        CONNESSIONE C = new CONNESSIONE();

        return C.EseguiSp("tabAUTO_SelectDdl");
    }
    public DataTable SelectForDdl()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("tabAuto_SelectForDdl");

    }
    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabAuto_Insert";
        cmd.Parameters.AddWithValue("@codiceModello", codiceModello);
        cmd.Parameters.AddWithValue("@targa", targa);
        cmd.Parameters.AddWithValue("@costo", costo);
        cmd.Parameters.AddWithValue("@prezzo", prezzo);
        cmd.Parameters.AddWithValue("@dataAcquisto", dataAcquisto);

        c.EseguiSpcmdpparam(cmd);
    }
    public void Update()
    {
        CONNESSIONE C = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabAuto_Update";
        cmd.Parameters.AddWithValue("@codiceAuto", codiceAuto);
        cmd.Parameters.AddWithValue("@codiceModello", codiceModello);
        cmd.Parameters.AddWithValue("@targa", targa);
        cmd.Parameters.AddWithValue("@costo", costo);
        cmd.Parameters.AddWithValue("@prezzo", prezzo);
        cmd.Parameters.AddWithValue("@dataAcquisto", dataAcquisto);

        C.EseguiSpcmdpparam(cmd);
    }
    public DataTable SelectOne()
    {
        CONNESSIONE C = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabAuto_SelectOne";
        cmd.Parameters.AddWithValue("@codiceAuto", codiceAuto);

        return C.EseguiSpselectparam(cmd);
    }
}