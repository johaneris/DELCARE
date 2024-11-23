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

        private void CargarDoctores()
        {
            DoctorService doctorService = new DoctorService();
            var doctores = doctorService.LeerDoctores();

            cmb_BuscarDoctor.Items.Clear();

            foreach (var doctor in doctores)
            {
                if (doctor.Activo == true)
                {
                    cmb_BuscarDoctor.Items.Add(doctor.Nombre);
                }
            }
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

        private void FiltrarPorDoctor(string nombreDoctor)
        {
            ControlHorario controlHorario = new ControlHorario();
            var horarios = controlHorario.LeerHorarios();

            var horariosFiltrados = horarios.Where(h 
                => ObtenerNombreDoctor(h.DoctorID).Equals(nombreDoctor, StringComparison.OrdinalIgnoreCase));

            dgvHorarios.Rows.Clear();
            foreach (var horario in horarios )
            {
                string nombre = ObtenerNombreDoctor(horario.DoctorID);
                dgvHorarios.Rows.Add(nombre, horario.HoraInicial, horario.HoraFinal, horario.DiaSemana);
            }
        }

        private void ConsultarHorarios_Load(object sender, EventArgs e)
        {
            CargarHorarios();
            CargarDoctores();
        }

        private void btn_Deshacer_Click(object sender, EventArgs e)
        {
            cmb_BuscarDoctor.SelectedIndex = -1;
            CargarHorarios();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string nombre = cmb_BuscarDoctor.Text;

            if(!string.IsNullOrEmpty(nombre))
            {
                FiltrarPorDoctor(nombre);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un doctor para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
