using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
namespace BLL
{
    public interface ICrud
    {
        string Insertar(Persona persona);
        string Eliminar(string cedula);   
        string Actualizar(Persona persona);
        List<Persona> ObtenerTodos();

    }
}
