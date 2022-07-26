using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class MARCHE
{
    public int codiceMarca;
    public string descrizione;
    public MARCHE()
    {

    }
    //Metodo 1: Seleziona l'intera tabella

    public DataTable SelectAll()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("tabMarche_SelectAll");

    }

    //Metodo 2: insert
    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabMarche_Insert";
        cmd.Parameters.AddWithValue("@descrizione", descrizione);

        c.EseguiSpcmdpparam(cmd);
    }
    //Metodo 3: Modifica
    public void Update()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabMarche_Update";
        cmd.Parameters.AddWithValue("@descrizione", descrizione);
        cmd.Parameters.AddWithValue("@codiceMarca", codiceMarca);

        c.EseguiSpcmdpparam(cmd);

    }
    //Metodo 4: CheckOne
    public bool CheckOne()
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabMarche_CheckOne";
        cmd.Parameters.AddWithValue("@descrizione", descrizione);

        dt = c.EseguiSpselectparam(cmd);
        return dt.Rows.Count > 0;
    }
}