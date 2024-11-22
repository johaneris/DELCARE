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

namespace UAM_INVESTIGATION.FormAdmin
{
    public partial class MonitorearDoctores : UserControl
    {
        public MonitorearDoctores()
        {
            InitializeComponent();
            InicializarComboBoxEspecialidades();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InicializarComboBoxEspecialidades()
        {
            cmb_Especilidad.Items.AddRange(new string[]
            {
                "Odontólogo General",
                "Endodoncia",
                "Ortodoncia",
                "Cirujano Maxilofacial"
            });
            cmb_Especilidad.SelectedIndex = 0;


        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int id = new Random().Next(1000, 9999);
            string nombre = txt_Nombre.Text;
            string especialidad = cmb_Especilidad.SelectedItem.ToString();
            string correo = txt_Correo.Text;
            string celular = txt_Celular.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(celular))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Doctor nuevoDoctor = new Doctor(id, nombre, especialidad, correo, celular, true);
            DoctorService.GuardarDoctor(nuevoDoctor);
            MessageBox.Show("Doctor guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt_Nombre.Clear();
            txt_Correo.Clear();
            txt_Celular.Clear();
            cmb_Especilidad.SelectedIndex = 0;
        }


    }
}
