using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class SPESE
{

    public int codiceSpesa;
    public int codiceTipoSpesa;
    public decimal importo;
    public string dataSpesa;

    public SPESE()
    {
        
    }

    public DataTable SelectOne()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabSpese_SelectOne";
        cmd.Parameters.AddWithValue("@codiceSpesa", codiceSpesa);

        return c.EseguiSpselectparam(cmd);
    }

    public DataTable SelectAll()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("tabSpese_SelectAll");

    }

    public DataTable SelectForDdl()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("tabSpese_SelectForDdl");

    }

    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabSpese_Insert";
        cmd.Parameters.AddWithValue("@codiceTipoSpesa", codiceTipoSpesa);
        cmd.Parameters.AddWithValue("@importo", importo);
        cmd.Parameters.AddWithValue("@dataSpesa", dataSpesa);

        c.EseguiSpcmdpparam(cmd);
    }

    public void Update()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabSpese_Update";

        cmd.Parameters.AddWithValue("@codiceSpesa",codiceSpesa );
        cmd.Parameters.AddWithValue("@importo",importo );
        cmd.Parameters.AddWithValue("@dataSpesa", dataSpesa );
        cmd.Parameters.AddWithValue("@codiceTipoSpesa", codiceTipoSpesa );

        c.EseguiSpcmdpparam(cmd);

    }

    public bool CheckOne()
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabSpese_CheckOne";
        cmd.Parameters.AddWithValue("@importo",importo );
        cmd.Parameters.AddWithValue("@dataSpesa",dataSpesa );
        cmd.Parameters.AddWithValue("@codiceTipoSpesa",codiceTipoSpesa );

        dt = c.EseguiSpselectparam(cmd);
        return dt.Rows.Count > 0;
    }

    public void Delete()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabSpese_Delete";
        cmd.Parameters.AddWithValue("@codiceSpesa", codiceSpesa);
        c.EseguiSpselectparam(cmd);
    }
}