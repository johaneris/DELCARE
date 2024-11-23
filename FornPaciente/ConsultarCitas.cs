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

namespace UAM_INVESTIGATION.FornPaciente
{
    public partial class ConsultarCitas : UserControl
    {
        public ConsultarCitas()
        {
            InitializeComponent();
        }
        private string ObtenerNombreDoctor(int id)
        {
            DoctorService doctorService = new DoctorService();
            var doctor = doctorService.LeerDoctores();

            foreach (var doc in doctor)
            {
                if (doc.Id == id)
                {
                    return doc.Nombre;
                }
            }
            return "";
        }

        private void CargarCitas()
        {
            ControlCitas controlCitas = new ControlCitas();
            var citas = controlCitas.LeerCitas();
            dgv_Citas.Rows.Clear();
            foreach (var cita in citas)
            {
                string Nombre = ObtenerNombreDoctor(cita.IdDoctor);
                dgv_Citas.Rows.Add(cita.NombrePaciente, Nombre, cita.FechaHora);
            }
        }

        private void ConsultarCitas_Load(object sender, EventArgs e)
        {
            CargarCitas();
        }
    }
}
