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

namespace UAM_INVESTIGATION.FormEstudiantes
{
    public partial class Agendar_citas : UserControl
    {
        public Agendar_citas()
        {
            InitializeComponent();
        }

        private void CargarDoctorCmb()
        {
            DoctorService doctorService = new DoctorService();
            var doctores = doctorService.LeerDoctores();

            cmb_Doctores.Items.Clear();

            foreach (var doctor in doctores)
            {
                cmb_Doctores.Items.Add(doctor.Nombre);
            }
        }

        private void CargarFechaHora()
        {
            ControlHorario controlHorario = new ControlHorario();
            var horarios = controlHorario.LeerHorarios();

            cmb_FechaHora.Items.Clear();
            foreach (var horario in horarios)
            {
                cmb_FechaHora.Items.Add($"{horario.HoraInicial} - {horario.HoraFinal} | {horario.DiaSemana}");
            }
        }


        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Agendar_citas_Load(object sender, EventArgs e)
        {
            CargarDoctorCmb();
            CargarFechaHora();
        }
    }
}
