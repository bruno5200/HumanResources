using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


/// <summary>
/// Clase Clientes
/// </summary>
public class clspersonal : clsconexion      // siempre conexio ojo//
{
    string tabla = "personal";  // nombre de la tabla
    protected string nombre, apepaterno, apematerno, ci, fchanacimiento, sexo, nacionalidad, estadocivil, email, codigo, estado, direccion, telefono;
    protected int idpersonal, diasvac;
    public clspersonal(int idpersonal, string nombre, string apepaterno, string apematerno, string ci, string fchanacimiento, string sexo, string nacionalidad, string estadocivil, string email, string codigo, string estado, string direccion, string telefono)
    {
        this.idpersonal = idpersonal;
        this.nombre = nombre;
        this.apepaterno = apepaterno;
        this.apematerno = apematerno;
        this.ci = ci;
        this.fchanacimiento = fchanacimiento;
        this.sexo = sexo;
        this.nacionalidad = nacionalidad;
        this.estadocivil = estadocivil;
        this.email = email;
        this.codigo = codigo;
        this.estado = estado;
        this.direccion = direccion;
        this.telefono = telefono;

    }
    //metodos para establecer  y recuperar datos
    public int Idpersonal
    {
        set { idpersonal = value; }
        get { return idpersonal; }
    }
    public String Nombre
    {
        set { nombre = value; }
        get { return nombre; }
    }
    public String Apepaterno
    {
        set { apepaterno = value; }
        get { return apepaterno; }
    }
    public String Apematerno
    {
        set { apematerno = value; }
        get { return apematerno; }
    }
    public String CI
    {
        set { ci = value; }
        get { return ci; }
    }
    public String Fchanacimiento
    {
        set { fchanacimiento = value; }
        get { return fchanacimiento; }
    }
    public String Sexo
    {
        set { sexo = value; }
        get { return sexo; }
    }
    public string Nacionalidad
    {
        set { nacionalidad = value; }
        get { return nacionalidad; }
    }
    public String Estadocivil
    {
        set { estadocivil = value; }
        get { return estadocivil; }
    }
    public string Email
    {
        set { email = value; }
        get { return email; }
    }
    public string Codigo
    {
        set { codigo = value; }
        get { return codigo; }
    }
    public string Estado
    {
        set { estado = value; }
        get { return estado; }
    }
    public string Direccion
    {
        set { direccion = value; }
        get { return direccion; }
    }
    public string Telefono
    {
        set { telefono = value; }
        get { return telefono; }
    }
    public int DiasVac
    {
        set { diasvac = value; }
        get { return diasvac; }
    }
    //metodo para agregar el fregistro
    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables["personal"].NewRow();
        fila["idpersonal"] = Idpersonal;
        fila["nombre"] = Nombre;
        fila["apepaterno"] = Apepaterno;
        fila["apematerno"] = Apematerno;
        fila["ci"] = CI;
        fila["fchanacimiento"] = Fchanacimiento;
        fila["sexo"] = Sexo;
        fila["nacionalidad"] = Nacionalidad;
        fila["estadocivil"] = Estadocivil;
        fila["email"] = Email;
        fila["codigo"] = Codigo;
        fila["estado"] = Estado;
        fila["direccion"] = Direccion;
        fila["telefono"] = Telefono;

        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }
    // funcion eliminar
    public bool eliminar(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idpersonal"].ToString()) == valor)
            {
                fila = Data.Tables[tabla].Rows[i];
                fila.Delete();
                DataTable tablaborrados;
                tablaborrados = Data.Tables[tabla].GetChanges(DataRowState.Deleted);
                AdaptadorDatos.Update(tablaborrados);
                Data.Tables[tabla].AcceptChanges();
                return true;
            }
        } return false;
    }
    // funcion buscar
    public bool existe(int valor)
    {
        conectar(tabla, valor);
        int x = Data.Tables[tabla].Rows.Count;
        if (x == 1)
        {
            DataRow fila = Data.Tables[tabla].Rows[0];
            Idpersonal = int.Parse(fila["idpersonal"].ToString());
            Nombre = fila["nombre"].ToString();
            Apepaterno = fila["apepaterno"].ToString();
            Apematerno = fila["apematerno"].ToString();
            CI = fila["ci"].ToString();
            Fchanacimiento = fila["fchanacimiento"].ToString();
            Sexo = fila["sexo"].ToString();
            Nacionalidad = fila["nacionalidad"].ToString();
            Estadocivil = fila["estadocivil"].ToString();
            Email = fila["email"].ToString();
            Codigo = fila["codigo"].ToString();
            Estado = fila["estado"].ToString();
            Direccion = fila["direccion"].ToString();
            Telefono = fila["telefono"].ToString();
            DiasVac = int.Parse(fila["DiasVac"].ToString());
            return true;
        }
        //for (int i = 0; i <= x; i++)
        //{
        //    fila = Data.Tables[tabla].Rows[i];
        //    if (int.Parse(fila["idpersonal"].ToString()) == valor)
        //    {
        //        Idpersonal = int.Parse(fila["idpersonal"].ToString());
        //        Nombre = fila["nombre"].ToString();
        //        Apepaterno = fila["apepaterno"].ToString();
        //        Apematerno = fila["apematerno"].ToString();
        //        CI = fila["ci"].ToString();
        //        Fchanacimiento = fila["fchanacimiento"].ToString();
        //        Sexo = fila["sexo"].ToString();
        //        Nacionalidad = fila["nacionalidad"].ToString();
        //        Estadocivil = fila["estadocivil"].ToString();
        //        Email = fila["email"].ToString();
        //        Codigo = fila["codigo"].ToString();
        //        Estado = fila["estado"].ToString();
        //        Direccion = fila["direccion"].ToString();
        //        Telefono = fila["telefono"].ToString();
        //        return true;
        //      }
        //} 
        return false;

    }
}