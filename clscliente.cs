using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


//clase Cliente
namespace primerAplicaciom
{
    public class clscliente: clsconexion
    {
        string tabla = "cliente"; //nombre de la tabla
        protected string  nombre, direccion, telefono;
        protected int idcliente;

        public clscliente(int idcliente,string nombre, string direccion, string telefono)
        {
            this.idcliente = idcliente;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;

        }

        //metodos para establecer y recuperar datos
        public int Idcliente
        {
            set { idcliente = value; }
            get { return idcliente; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
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
        //metodo para agregar cliente

        public void agregar()
        {
            conectar(tabla);
            DataRow fila;
            fila = data.Tables[tabla].NewRow();
            fila["idcliente"] = Idcliente;
            fila["nombre"] = Nombre;
            fila["direccion"] = Direccion;
            fila["telefono"] = Telefono;

            data.Tables[tabla].Rows.Add(fila);
            AdaptadorDatos.Update(Data, tabla);
        }
    }
}