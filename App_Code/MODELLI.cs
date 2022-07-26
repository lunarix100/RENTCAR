using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public class MODELLI
{
    public int codiceModello;
    public int codiceMarca;
    public string descrizione;
    public MODELLI()
    {

    }

    //Metodo 1: Seleziona l'intera tabella

    public DataTable SelectAll()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("tabModelli_SelectAll");

    }

    //Metodo 2: insert
    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabModelli_Insert";
        cmd.Parameters.AddWithValue("@descrizione", descrizione);
        cmd.Parameters.AddWithValue("@codiceMarca", codiceMarca);

        c.EseguiSpcmdpparam(cmd);
    }
    //Metodo 3: Modifica
    public void Update()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabModelli_Update";
        cmd.Parameters.AddWithValue("@codiceModello", codiceModello);
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
        cmd.CommandText = "tabModelli_CheckOne";
        cmd.Parameters.AddWithValue("@codiceMarca", codiceMarca);
        cmd.Parameters.AddWithValue("@descrizione", descrizione);

        dt = c.EseguiSpselectparam(cmd);
        return dt.Rows.Count > 0;
    }

    public DataTable SelectForDdl()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("tabModelli_SelectForDdl");

    }

    public DataTable SelectOne()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabModelli_SelectOne";
        cmd.Parameters.AddWithValue("@codiceModello", codiceModello);

        return c.EseguiSpselectparam(cmd);
    }
}