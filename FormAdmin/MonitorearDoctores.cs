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
        private DoctorService doctorService;

        public MonitorearDoctores()
        {
            InitializeComponent();
            doctorService = new DoctorService();

            InicializarComboBoxEspecialidades();
            cmb_Especilidad.SelectedIndex = -1;
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
            try
            {
                // Generar ID aleatorio
                int id = new Random().Next(1000, 9999);

                // Recoger datos del formulario
                string nombre = txt_Nombre.Text.Trim();
                string especialidad = cmb_Especilidad.SelectedItem.ToString();
                string correo = txt_Correo.Text.Trim();
                string celular = txt_Celular.Text.Trim();

                // Validaciones
                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(celular))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!correo.Contains("@") || !correo.Contains("."))
                {
                    MessageBox.Show("Por favor, ingrese un correo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear y guardar el objeto Doctor
                Doctor nuevoDoctor = new Doctor(id, nombre, especialidad, correo, celular, true);
                doctorService.GuardarDoctor(nuevoDoctor);
                CargarDoctores();
                // Confirmación y limpieza
                MessageBox.Show("Doctor guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txt_Nombre.Clear();
            txt_Correo.Clear();
            txt_Celular.Clear();
            cmb_Especilidad.SelectedIndex = -1;
        }
        private void CargarDoctores()
        {
            try
            {
                var doctores = doctorService.LeerDoctores(); // Método que obtiene los doctores

                dgvDoctores.Rows.Clear();

                foreach (var doctor in doctores)
                {
                    // Agrega las filas al DataGridView
                    dgvDoctores.Rows.Add(doctor.Id, doctor.Nombre, doctor.Especialidad, doctor.Correo, doctor.Celular, doctor.Activo ? "Activo" : "Inactivo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los doctores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDoctores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDoctores.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dgvDoctores.SelectedRows[0];


                // Obtener el valor del nombre y establecerlo en el TextBox correspondiente
                txt_Nombre.Text = filaSeleccionada.Cells[1].Value != null ? filaSeleccionada.Cells[1].Value.ToString() : "N/A";

                // Establecer el valor en el ComboBox de especialidad
                cmb_Especilidad.Text = filaSeleccionada.Cells[1].Value != null ? filaSeleccionada.Cells[2].Value.ToString() : "N/A";
                txt_Correo.Text = filaSeleccionada.Cells[1].Value != null ? filaSeleccionada.Cells[3].Value.ToString() : "N/A";
                txt_Celular.Text = filaSeleccionada.Cells[1].Value != null ? filaSeleccionada.Cells[4].Value.ToString() : "N/A";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            cmb_Especilidad.SelectedIndex = -1;
            txt_Correo.Clear();
            txt_Celular.Clear();
            dgvDoctores.ClearSelection();
        }

        private void btn_DarBaja1_Click(object sender, EventArgs e)
        {
            if (dgvDoctores.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas dar de baja a este doctor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Obtén el ID del doctor de la fila seleccionada
                        int idDoctor = Convert.ToInt32(dgvDoctores.SelectedRows[0].Cells[0].Value);

                        // Llama al servicio para dar de baja al doctor
                        doctorService.DarDeBajaDoctor(idDoctor);

                        MessageBox.Show("El doctor ha sido dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recarga los doctores
                        CargarDoctores();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al dar de baja al doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un doctor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MonitorearDoctores_Load(object sender, EventArgs e)
        {
            CargarDoctores();
        }
    }
}
