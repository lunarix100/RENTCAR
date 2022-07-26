using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class CONNESSIONE //classe
{

    public SqlConnection conn = new SqlConnection();
    public string query;
    public CONNESSIONE() // costruttore della classe
    {
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["RENTCARConnectionString"].ConnectionString;



    }
    
    public DataTable EseguiSelect(string query)
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        
        cmd.Connection = conn;
        cmd.CommandText = query;
        
        SqlDataAdapter DA = new SqlDataAdapter();
        
        DA.SelectCommand = cmd;
        DA.Fill(dt);
        return dt;
    }
    public void EseguiCommand(string query)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = query;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    public DataTable EseguiSp(string query)
    {
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.CommandText = query;
        SqlDataAdapter DA = new SqlDataAdapter();

        DA.SelectCommand = cmd;
        DA.Fill(dt);
        return dt;
    }
    public void EseguiSpcmdpparam(SqlCommand cmd)
    {
        cmd.Connection = conn;
        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    public DataTable EseguiSpselectparam(SqlCommand cmd)
    {
        DataTable dt = new DataTable();
        cmd.Connection = conn;

        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataAdapter DA = new SqlDataAdapter();

        DA.SelectCommand = cmd;
        DA.Fill(dt);

        return dt;
    }
}