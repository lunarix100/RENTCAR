using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class CONTRATTI
{
    public int codiceContratto;
    public int codiceCliente;
    public int codiceAuto;
    public string dataInizioContratto;
    public string dataFineContratto;

    public CONTRATTI()
    {

    }
    public DataTable SelectAll()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("tabContratti_SelectAll");

    }

    public void Insert()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabContratti_Insert";
        cmd.Parameters.AddWithValue("@codiceCliente", codiceCliente);
        cmd.Parameters.AddWithValue("@codiceAuto", codiceAuto);
        cmd.Parameters.AddWithValue("@dataInizioContratto", dataInizioContratto);
        cmd.Parameters.AddWithValue("@dataFineContratto", dataFineContratto);

        c.EseguiSpcmdpparam(cmd);
    }
    //Metodo 3: Modifica
    public void Update()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabContratti_Update";
        cmd.Parameters.AddWithValue("@codiceContratto", codiceContratto);
        cmd.Parameters.AddWithValue("@codiceCliente", codiceCliente);
        cmd.Parameters.AddWithValue("@codiceAuto", codiceAuto);
        cmd.Parameters.AddWithValue("@dataInizioContratto", dataInizioContratto);
        cmd.Parameters.AddWithValue("@dataFineContratto", dataFineContratto);

        c.EseguiSpcmdpparam(cmd);

    }

    public void Delete()
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "tabContratti_Delete";
        cmd.Parameters.AddWithValue("@codiceContratto", codiceContratto);
        c.EseguiSpcmdpparam(cmd);
    }

    public DataTable SelectOne()
    {
        CONNESSIONE C = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "tabContratti_SelectOne";
        cmd.Parameters.AddWithValue("@codiceContratto", codiceContratto);

        return C.EseguiSpselectparam(cmd);
    }
}