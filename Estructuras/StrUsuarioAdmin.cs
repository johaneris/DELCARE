using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM_INVESTIGATION.Estructuras
{
    public struct UsuarioAdmin
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }

        public UsuarioAdmin(int id, string nombre, string correo, string contrasenia)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            Contrasenia = contrasenia;
        }
    }
}
