using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM_INVESTIGATION.Estructuras
{
    public struct Citas

    {
        public int Id { get; set; }
        public string NombrePaciente { get; set; }
        public int IdDoctor { get; set; }
        public string FechaHora { get; set; }
        public string NumPaciente { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        public Citas(int id, string nombrePaciente, int idDoctor, string fechaHora, string numPaciente,  string descripcion, bool activo)
        {
            Id = id;
            NombrePaciente = nombrePaciente;
            IdDoctor = idDoctor;
            FechaHora = fechaHora;
            NumPaciente = numPaciente;
            Descripcion = descripcion;
            Activo = activo;
        }

    }
}
