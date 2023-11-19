using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DAL.BaseDatos baseDatos= new DAL.BaseDatos();
            //string msg = baseDatos.AbrirConexion();
            //Console.WriteLine(msg);

            //msg = baseDatos.CerrarConexion();
            //Console.WriteLine(msg);
            //DAL.PersonaRepository personaRepository = new DAL.PersonaRepository();
            Persona persona = new Persona(1, "999", "pedro", "87845", DateTime.Now);
             BLL.PersonaService servicio= new BLL.PersonaService();

            var msg =servicio.Insertar(persona);
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
