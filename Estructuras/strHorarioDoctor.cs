using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM_INVESTIGATION.Estructuras
{
    public struct Doctor

    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public bool Activo { get; set; }

        public Doctor(int id, string nombre, string especialidad, string correo, string celular, bool activo)
        {
            Id = id;
            Nombre = nombre;
            Especialidad = especialidad;
            Correo = correo;
            Celular = celular;
            Activo = activo;
        }

    }

    public class Horario
    {
        public int ID { get; set; }
        public int DoctorID { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public string DiaSemana { get; set; }
    }
}
