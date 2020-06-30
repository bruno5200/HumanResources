using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pagepersonal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnagregar_Click(object sender, EventArgs e)
    {
        try
        {
            clspersonal clte = new clspersonal(0, "", "", "", "", "", "", "", "", "", "", "", "", "");
            clte.Idpersonal = int.Parse(txtpersonal.Text.Trim());
            clte.Nombre = txtnombre.Text;
            clte.Apepaterno = txtapepaterno.Text;
            clte.Apematerno = txtapematerno.Text;
            clte.CI = txtci.Text;
            clte.Fchanacimiento = txtfchanacimiento.Text;
            clte.Sexo = txtsexo.Text;
            clte.Nacionalidad = txtnacionalidad.Text;
            clte.Estadocivil = txtestadocivil.Text;
            clte.Email = txtemail.Text;
            clte.Codigo = txtcodigo.Text;
            clte.Estado = txtestado.Text;
            clte.Direccion = txtdireccion.Text;
            clte.Telefono = txttelefono.Text;
            clte.agregar();
            lblestado.Text = "Regisstro Agregado con exito";
            txtpersonal.Text = "";
            txtnombre.Text = "";
            txtapepaterno.Text = "";
            txtapematerno.Text = "";
            txtci.Text = "";
            txtfchanacimiento.Text = "";
            txtsexo.Text = "";
            txtnacionalidad.Text = "";
            txtestadocivil.Text = "";
            txtemail.Text = "";
            txtcodigo.Text = "";
            txtestado.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";

        }
        catch
        {
            lblestado.Text = "Se ha generado una esepcion";
        }
    }


    protected void btneliminar_Click(object sender, EventArgs e)
    {
        clspersonal clte = new clspersonal(0, "", "", "", "", "", "", "", "", "", "", "", "", "");
        {
            if (clte.eliminar(int.Parse(txtpersonal.Text)))
            {
                lblestado.Text = "El registro se elimino con exito";
                txtpersonal.Text = "";
                txtnombre.Text = "";
                txtapepaterno.Text = "";
                txtapematerno.Text = "";
                txtci.Text = "";
                txtfchanacimiento.Text = "";
                txtsexo.Text = "";
                txtnacionalidad.Text = "";
                txtestadocivil.Text = "";
                txtemail.Text = "";
                txtcodigo.Text = "";
                txtestado.Text = "";
                txtdireccion.Text = "";
                txttelefono.Text = "";
            }
            else
            {
                lblestado.Text = "El registro no se elimino";
            }
        }
    }
    protected void btnbuscar_Click(object sender, EventArgs e)
    {
        clspersonal clte = new clspersonal(0, "", "", "", "", "", "", "", "", "", "", "", "", "");
        if (clte.existe(int.Parse(txtpersonal.Text)))
        {
            txtpersonal.Text = clte.Idpersonal.ToString();
            txtnombre.Text = clte.Nombre;
            txtapepaterno.Text = clte.Apepaterno;
            txtapematerno.Text = clte.Apematerno;
            txtci.Text = clte.CI;
            txtfchanacimiento.Text = clte.Fchanacimiento;
            txtsexo.Text = clte.Sexo;
            txtnacionalidad.Text = clte.Nacionalidad;
            txtestadocivil.Text = clte.Estadocivil;
            txtemail.Text = clte.Email;
            txtcodigo.Text = clte.Codigo;
            txtestado.Text = clte.Estado;
            txtdireccion.Text = clte.Direccion;
            txttelefono.Text = clte.Telefono;
            txtDiasVacacion.Text = clte.DiasVac.ToString();
            lblestado.Text = "Registro encontrado";
        }
        else
        {
            lblestado.Text = "Registro no encontrado";
        }
    }
    protected void btnlimpiar_Click(object sender, EventArgs e)
    {
        txtpersonal.Text = "";
        txtnombre.Text = string.Empty;
        txtapepaterno.Text = "";
        txtapematerno.Text = "";
        txtci.Text = "";
        txtfchanacimiento.Text = "";
        txtsexo.Text = "";
        txtnacionalidad.Text = "";
        txtestadocivil.Text = "";
        //txtemail.Text = clte.Email;
        //txtcodigo.Text = clte.Codigo;
        //txtestado.Text = clte.Estado;
        //txtdireccion.Text = clte.Direccion;
        //txttelefono.Text = clte.Telefono;

    }
    protected void txtDiasVacacion_TextChanged(object sender, EventArgs e)
    {

    }
}