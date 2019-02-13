using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


//clase conexion del proyecto   
namespace primerAplicaciom
{
    public class clsconexion
    {
        protected SqlDataReader reader;
        protected SqlDataAdapter AdaptadorDatos;
        protected DataSet data;
        protected SqlConnection oconexion = new SqlConnection();

        public clsconexion()
        {

        }

        public void conectar(string tabla)
        {
            string strconexion = ConfigurationManager.ConnectionStrings["ClientesConnectionString"].ConnectionString;
            oconexion.ConnectionString = strconexion;
            oconexion.Open();
            AdaptadorDatos = new SqlDataAdapter("select * from " + tabla, oconexion);
            SqlCommandBuilder ejecutacomandos = new SqlCommandBuilder(AdaptadorDatos);
            Data = new DataSet();

            AdaptadorDatos.Fill(Data, tabla);
            oconexion.Close();
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
}