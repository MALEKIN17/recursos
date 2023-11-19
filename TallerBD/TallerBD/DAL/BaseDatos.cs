using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
    public class BaseDatos
    {
        protected SqlConnection conexion;
        protected string cadenaConexion = "Server=.\\SQLEXPRESS;Database=ContactosDB;Trusted_Connection=True;";
        public BaseDatos()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public string AbrirConexion()
        {
            conexion.Open();
            return conexion.State.ToString();
        }

        public string CerrarConexion()
        {
            conexion.Close();
            return conexion.State.ToString();
        }
    }
}
