using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class PersonaService : ICrud
    {
        DAL.PersonaRepository repo = new PersonaRepository();
        public string Actualizar(Persona persona)
        {
           return  repo.EditarPersona(persona);
        }

        public string Eliminar(string cedula)
        {
            var msg = repo.EliminarPersona(cedula);
            return msg;
        }

        public string Insertar(Persona persona)
        {
            var msg= repo.InsertarPersona(persona);
            return msg;
        }

        public List<Persona> ObtenerTodos()
        {
            var msg = repo.ObtenerTodos();
            return msg;
        }
    }
}
