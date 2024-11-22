using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM_INVESTIGATION.Estructuras
{
    public struct Horario
    {
        public int IdHorario { get; set; }
        public int IdDoctor { get; set; }
        public string Especialidades { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public string DiaSemana { get; set; }

        public Horario(int idHorario, int idDoctor, string especialidades, DateTime horaInicial, DateTime horaFinal, string diaSemana)
        {
            IdHorario = idHorario;
            IdDoctor = idDoctor;
            Especialidades = especialidades;
            HoraInicial = horaInicial;
            HoraFinal = horaFinal;
            DiaSemana = diaSemana;
        }
    }
}
