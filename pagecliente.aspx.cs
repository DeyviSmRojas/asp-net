using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace primerAplicaciom
{
    public partial class pagecliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            clscliente clte = new clscliente(0, "", "", "");
            clte.Idcliente = int.Parse(txtcliente.Text.Trim());//Trim: Sirve para quitar o eliminar espacios en blanco en cualquier lugar para generar error
            clte.Nombre = txtnombre.Text;
            clte.Direccion = txtdireccion.Text;
            clte.Telefono = txttelefono.Text;
            clte.agregar();
            lblestado.Text = "Registro Agregado con Exito";
            txtcliente.Text = "";
            txtnombre.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
        }
    }
}