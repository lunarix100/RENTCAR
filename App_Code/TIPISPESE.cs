using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per Class1
/// </summary>
public class TIPISPESE
{
    
    public TIPISPESE()
    {
       
    }

    public class AGGIORNADB
    {
        public int codicetipospesa;
        public string descrizione;
        public void Insert()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "tabTIPISPESE_Insert";
            cmd.Parameters.AddWithValue("@descrizione", descrizione);


            c.EseguiSpselectparam(cmd);
            //c.EseguiCommand("insert into tabTipiSpese values('" + descrizione + "')");

        }
        public void Update()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "tabTIPISPESE_Update";
            cmd.Parameters.AddWithValue("@descrizione", descrizione);
            cmd.Parameters.AddWithValue("@codiceTipoSpesa", codicetipospesa);

            c.EseguiSpcmdpparam(cmd);

            //c.EseguiCommand("UPDATE tabTIPISPESE SET descrizione='" + descrizione + "'where codiceTipoSpesa=" + codicetipospesa);
        }
    }

    //Metodo 1: Seleziona l'intera tabella

    public DataTable Select() //selectall
    {
        DataTable dt = new DataTable();
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("tabTIPISPESE_SelectAll");

    }
    public DataTable Select(int codicetipospesa) //selectone
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabTipiSpese_SelectOne";
        cmd.Parameters.AddWithValue("@codiceTipoSpesa", codicetipospesa);

        return c.EseguiSpselectparam(cmd);
    }
        //Metodo 2: inserimento tipo spesa

    //    public void Insert()
    //{
    //    CONNESSIONE c = new CONNESSIONE();
    //    SqlCommand cmd = new SqlCommand();
    //    cmd.CommandText = "tabTIPISPESE_Insert";
    //    cmd.Parameters.AddWithValue("@descrizione", descrizione);


    //    c.EseguiSpselectparam(cmd);
    //    //c.EseguiCommand("insert into tabTipiSpese values('" + descrizione + "')");

    //}

    //Metodo 3: modific tipo spesa

    //public void Update()
    //{
    //    CONNESSIONE c = new CONNESSIONE();
    //    SqlCommand cmd = new SqlCommand();

    //    cmd.CommandText = "tabTIPISPESE_Update";
    //    cmd.Parameters.AddWithValue("@descrizione", descrizione);
    //    cmd.Parameters.AddWithValue("@codiceTipoSpesa", codicetipospesa);

    //    c.EseguiSpcmdpparam(cmd);

    //    //c.EseguiCommand("UPDATE tabTIPISPESE SET descrizione='" + descrizione + "'where codiceTipoSpesa=" + codicetipospesa);
    //}

    //Metodo 4: verifica l'esistenza tipo spesa come descrizione

    public bool CheckOne(string descrizione)
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabTIPISPESE_CheckOne";
        cmd.Parameters.AddWithValue("@descrizione", descrizione);

        dt = c.EseguiSpselectparam(cmd);

        //dt = c.EseguiSelect("select * from tabTIPISPESE where descrizione = '" + descrizione + "'");

        return dt.Rows.Count > 0;
    }


}