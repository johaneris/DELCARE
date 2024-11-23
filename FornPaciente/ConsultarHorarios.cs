using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAM_INVESTIGATION.Helpers;

namespace UAM_INVESTIGATION.FornPaciente
{
    public partial class ConsultarHorarios : UserControl
    {
        public ConsultarHorarios()
        {
            InitializeComponent();
        }
        private string ObtenerNombreDoctor(int id)
        {
            DoctorService doctorService = new DoctorService();
            var doctor = doctorService.LeerDoctores();

            foreach (var doc in doctor)
            {
                if(doc.Id == id)
                {
                    return doc.Nombre;
                }
            }
            return "";
        }

        private void CargarHorarios()
        {
            ControlHorario controlHorario = new ControlHorario();
            var horarios = controlHorario.LeerHorarios();
           

            dgvHorarios.Rows.Clear();
            foreach (var horario in horarios )
            {
                string Nombre = ObtenerNombreDoctor(horario.DoctorID);
                dgvHorarios.Rows.Add(Nombre, horario.HoraInicial, horario.HoraFinal, horario.DiaSemana);
            }
        }

        private void FiltrarPorDoctor(string Doctor)
        {
            ControlHorario controlHorario = new ControlHorario();
            var horarios = controlHorario.LeerHorarios();
            
        }
    }
}
