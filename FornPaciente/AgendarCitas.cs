using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAM_INVESTIGATION.Estructuras;
using UAM_INVESTIGATION.Helpers;

namespace UAM_INVESTIGATION.FormEstudiantes
{
    public partial class Agendar_citas : UserControl
    {
        private int Id;
        public Agendar_citas(int idPaciente)
        {
            InitializeComponent();
            this.Id = idPaciente;
        }

        private void CargarDoctorCmb()
        {
            DoctorService doctorService = new DoctorService();
            var doctores = doctorService.LeerDoctores();

            cmb_Doctores.Items.Clear();

            foreach (var doctor in doctores)
            {
                if (doctor.Activo == true)
                {
                    cmb_Doctores.Items.Add(doctor.Nombre);
                }
            }
        }

        private void CargarFechaHora(string nombreDoc)
        {
            ControlHorario controlHorario = new ControlHorario();
            var horarios = controlHorario.LeerHorarios();

            cmb_FechaHora.Items.Clear();
            int idDoctor = ObtenerIdDoctor(nombreDoc);
            Console.WriteLine(idDoctor);
            foreach (var horario in horarios)
            {
                if (idDoctor == horario.DoctorID)
                {
                    cmb_FechaHora.Items.Add($"{horario.HoraInicial} - {horario.HoraFinal} / {horario.DiaSemana}");
                }
                    
            }
        }

        private int ObtenerIdDoctor(string nombreDoctor)
        {
            DoctorService doctorService = new DoctorService();
            var doctor = doctorService.LeerDoctores();
            foreach (var doc in  doctor)
            {
                if(nombreDoctor == doc.Nombre)
                {
                    return doc.Id;
                }
                
            }
            return 0;
        }


        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Agendar_citas_Load(object sender, EventArgs e)
        {
            CargarDoctorCmb();
            //CargarFechaHora(cmb_Doctores.Text);
        }

        private void btn_Agendar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txt_Nombre.Text;
                string doctor = cmb_Doctores.Text;
                string fecha = cmb_FechaHora.Text;
                string telefono = txt_Telefono.Text;
                string descripcion = txt_Descripcion.Text;  
                if (nombre == "")
                {
                    MessageBox.Show("Por favor, introduzca su nombre", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }else if(doctor == "")
                {
                    MessageBox.Show("Por favor, seleccione un doctor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }else if(fecha == "")
                {
                    MessageBox.Show("Por favor, seleccione la fecha.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (telefono == "")
                {
                    MessageBox.Show("Por favor, introduzca su telefono.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (descripcion == "")
                {
                    MessageBox.Show("Por favor, escriba su motivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCita = new Random().Next(1000, 9999);
                int idDoctor = ObtenerIdDoctor(doctor);
                bool activo = true;
                int id = Id;
                Citas nuevaCitas = new Citas(idCita, nombre, idDoctor, fecha, telefono, descripcion, activo, id);
                var controlCitas = new ControlCitas();
                controlCitas.GuardarCitar(nuevaCitas);
                MessageBox.Show("Cita agendada con éxicto.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agendar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmb_Doctores_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarFechaHora(cmb_Doctores.Text);
        }
    }
}
