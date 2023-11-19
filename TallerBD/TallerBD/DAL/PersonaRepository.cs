using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
namespace DAL
{
    public class PersonaRepository : BaseDatos
    {
        public PersonaRepository():base()
        {
            
        }
        public string InsertarPersona(Persona persona)
        {
            if (persona == null)
            {
                return "datos invalidos de la persona";
            }
            string ssql = "INSERT INTO [Personas]([Cedula],[Nombre],[Telefono],[FechaNacimiento])VALUES" +
                $"('{persona.Cedula}','{persona.Nombre}','{persona.Telefono}','{persona.FechaNacimiento.ToShortDateString()}')";
            SqlCommand cmd= new SqlCommand(ssql,conexion);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();
            if (i>=1)
            {
                return $"se guardo la persona --> {persona.Nombre} ";
            }
            return "datos invalidos de la persona";
        }
        public string EliminarPersona(string cedula)
        {
            string ssql = $"DELETE FROM [dbo].[Personas] WHERE Cedula='{cedula}'";
            SqlCommand cmd = new SqlCommand(ssql, conexion);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();
            if (i >= 1)
            {
                return $"se guardo la persona con la cedula--> {cedula} ";
            }
            return "datos invalidos de la persona";
        }
        public string EditarPersona(Persona persona)
        {
            string ssql = $"UPDATE [dbo].[Personas] SET [Cedula] = '{persona.Cedula}', Nombre='{persona.Nombre}',Telefono='{persona.Telefono}',FechaNacimiento='{persona.FechaNacimiento.ToShortDateString()}' WHERE ID='{persona.Id}'";
            SqlCommand cmd = new SqlCommand(ssql, conexion);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();
            if (i >= 1)
            {
                return $"se actualizo la persona con el nombre--> {persona.Nombre} ";
            }
            return "datos invalidos de la persona";
        }
        public List<Persona> ObtenerTodos() 
        {
            List<Persona> list = new List<Persona>();
            string ssql = "select * from personas";
           
                SqlCommand cmd = new SqlCommand(ssql, conexion);
            AbrirConexion();
                SqlDataReader Rdr = cmd.ExecuteReader();

                while (Rdr.Read())
                {
                    list.Add(Mapear(Rdr));
                }
                Rdr.Close();
                CerrarConexion();
            
            return list;

        }
        private Persona Mapear(SqlDataReader reader)
        {
            Persona persona = new Persona();
          

            persona.Id = Convert.ToInt32(reader["Id"]);
            persona.Cedula = Convert.ToString(reader["Cedula"]);
            persona.Nombre = Convert.ToString(reader["Nombre"]);
            persona.Telefono = Convert.ToString(reader["Telefono"]);
            persona.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
            
            return persona;
        }

    }
}
