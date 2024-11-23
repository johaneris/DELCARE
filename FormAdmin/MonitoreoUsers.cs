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

namespace UAM_INVESTIGATION.FormAdmin
{
    public partial class MonitoreoUsers : UserControl
    {
        public MonitoreoUsers()
        {
            InitializeComponent();
        }

        private void CargarUsuarios()
        {
            InitRegis initRegis = new InitRegis();
            var estudiantes = initRegis.LeerUsuariosEst();

            // Limpiar y cargar datos al DataGridView
            dgvUsuarios.Rows.Clear();
            foreach (var est in estudiantes)
            {
                dgvUsuarios.Rows.Add(est.Id, est.Nombre, est.Correo, est.Estado ? "Vigente" : "Dado de Baja");
            }
        }

        private void BuscarUsuario(string correo)
        {
            InitRegis initRegis = new InitRegis();
            var estudiantes = initRegis.LeerUsuariosEst();
            var filtrados = estudiantes.Where(est => est.Correo.Contains(correo)).ToList();

            // Limpiar y cargar datos filtrados al DataGridView
            dgvUsuarios.Rows.Clear();
            foreach (var est in filtrados)
            {
                dgvUsuarios.Rows.Add(est.Id, est.Nombre, est.Correo, est.Estado ? "Vigente" : "Dado de Baja");
            }

            if (filtrados.Count == 0)
            {
                MessageBox.Show("No se encontró ningún usuario con el correo proporcionado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void MonitoreoUsers_Load(object sender, EventArgs e)
        {
            CargarUsuarios();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            lbl_Id.Text = "";
            lbl_Nombre.Text = "";
            lbl_Correo.Text = "";
            lbl_Estado.Text = "";
            dgvUsuarios.ClearSelection();
        }

        private void btn_DarDeBaja_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas dar de baja a este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var idSeleccionado = int.Parse(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());

                    InitRegis initRegis = new InitRegis();
                    initRegis.DarDeBajaUsuario(idSeleccionado);

                    MessageBox.Show("El usuario ha sido dado de baja exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lbl_Id.Text = "";
                    lbl_Nombre.Text = "";
                    lbl_Correo.Text = "";
                    lbl_Estado.Text = "";
                    // Recargar los usuarios en el DataGridView
                    CargarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dgvUsuarios.SelectedRows[0];

                lbl_Id.Text = filaSeleccionada.Cells[0].Value != null ? filaSeleccionada.Cells[0].Value.ToString() : "N/A";
                lbl_Nombre.Text = filaSeleccionada.Cells[1].Value != null ? filaSeleccionada.Cells[1].Value.ToString() : "N/A";
                lbl_Correo.Text = filaSeleccionada.Cells[2].Value != null ? filaSeleccionada.Cells[2].Value.ToString() : "N/A";
                lbl_Estado.Text = filaSeleccionada.Cells[3].Value != null ? filaSeleccionada.Cells[3].Value.ToString() : "N/A";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string correo = txt_CorreoBusqueda.Text; // TextBox para ingresar el correo
            if (!string.IsNullOrEmpty(correo))
            {
                BuscarUsuario(correo);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un correo para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_DeshacerFiltrado_Click(object sender, EventArgs e)
        {
            txt_CorreoBusqueda.Clear();
            CargarUsuarios();
        }
    }
}
