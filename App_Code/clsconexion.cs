﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Clase de conexion del proyecto
/// </summary>
public class clsconexion
{
    protected SqlDataReader reader;
    protected SqlDataAdapter AdaptadorDatos;
    protected DataSet data;
    protected SqlConnection oconeccion = new SqlConnection();
	public clsconexion()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
    public void conectar(string tabla)
    {
        string strConeccion = ConfigurationManager.ConnectionStrings["personalConnectionString"].ConnectionString;
        oconeccion.ConnectionString = strConeccion;
        oconeccion.Open();
        AdaptadorDatos = new SqlDataAdapter("select * from " + tabla, oconeccion);
        SqlCommandBuilder ejecutacomandos = new SqlCommandBuilder(AdaptadorDatos);
        Data = new DataSet();
        AdaptadorDatos.Fill(Data, tabla);
        oconeccion.Close();

    }
    public void conectar(string tabla, int idpersonal)
    {
        string strConeccion = ConfigurationManager.ConnectionStrings["personalConnectionString"].ConnectionString;
        oconeccion.ConnectionString = strConeccion;
        oconeccion.Open();
        AdaptadorDatos = new SqlDataAdapter("select * from " + tabla + " where Idpersonal =" + idpersonal, oconeccion);
        SqlCommandBuilder ejecutacomandos = new SqlCommandBuilder(AdaptadorDatos);
        Data = new DataSet();
        AdaptadorDatos.Fill(Data, tabla);
        oconeccion.Close();

    }
    public DataSet Data
    {
        set { data = value; }
        get { return data; }
    }
    public SqlDataReader DataReader
    {
        set { reader = value; }
        get { return reader; }
    }
}