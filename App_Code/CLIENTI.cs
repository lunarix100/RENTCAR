using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per CLIENTI
/// </summary>
public class CLIENTI
{
    public int codiceCliente;
    public string regioneSociale;
    public string partitaIVA;
    public string codiceFiscale;
    public string indirizzo;
    public string cap;
    public string citta;
    public string provincia;

    public CLIENTI()
    {
        
    }

    public DataTable SelectAll()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("tabCLIENTI_SelectAll");
    }

    public DataTable SelectOne()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabCLIENTI_SelectOne";
        cmd.Parameters.AddWithValue("@codiceCliente", codiceCliente);

        return c.EseguiSpselectparam(cmd);
    }

    public DataTable SelectForDdl()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("tabClienti_SelectForDdl");
    }

    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabCLIENTI_Insert";
        cmd.Parameters.AddWithValue("@regioneSociale",regioneSociale );
        cmd.Parameters.AddWithValue("@partitaIVA",partitaIVA );
        cmd.Parameters.AddWithValue("@codiceFiscale",codiceFiscale );
        cmd.Parameters.AddWithValue("@indirizzo",indirizzo );
        cmd.Parameters.AddWithValue("@cap",cap );
        cmd.Parameters.AddWithValue("@citta",citta );
        cmd.Parameters.AddWithValue("@provincia",provincia );

        c.EseguiSpcmdpparam(cmd);
    }
    public void Update()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabCLIENTI_Update";
        cmd.Parameters.AddWithValue("@codiceCliente", codiceCliente);
        cmd.Parameters.AddWithValue("@regioneSociale", regioneSociale);
        cmd.Parameters.AddWithValue("@partitaIVA", partitaIVA);
        cmd.Parameters.AddWithValue("@codiceFiscale", codiceFiscale);
        cmd.Parameters.AddWithValue("@indirizzo", indirizzo);
        cmd.Parameters.AddWithValue("@cap", cap);
        cmd.Parameters.AddWithValue("@citta", citta);
        cmd.Parameters.AddWithValue("@provincia", provincia);

        c.EseguiSpcmdpparam(cmd);

    }

    public bool CheckOne()
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabCLIENTI_CheckOne";  
        cmd.Parameters.AddWithValue("@partitaIVA", partitaIVA);
        cmd.Parameters.AddWithValue("@codiceFiscale", codiceFiscale);      

        dt = c.EseguiSpselectparam(cmd);
        return dt.Rows.Count > 0;
    }
    public bool CheckOneUpdate()
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabCLIENTI_CheckOne_Update";
        cmd.Parameters.AddWithValue("@regioneSociale", regioneSociale);
        cmd.Parameters.AddWithValue("@partitaIVA", partitaIVA);
        cmd.Parameters.AddWithValue("@codiceFiscale", codiceFiscale);
        cmd.Parameters.AddWithValue("@indirizzo", indirizzo);
        cmd.Parameters.AddWithValue("@cap", cap);
        cmd.Parameters.AddWithValue("@citta", citta);
        cmd.Parameters.AddWithValue("@provincia", provincia);


        dt = c.EseguiSpselectparam(cmd);
        return dt.Rows.Count > 0;
    }
}