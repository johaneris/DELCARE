using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAM_INVESTIGATION.Forms;

namespace UAM_INVESTIGATION.FormAdmin
{
    public partial class PrincipalAdmin : Form
    {
        private string nombreUsuario;
        private string correoUsuario;
        public PrincipalAdmin(string nombreUsuario, string correoUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.correoUsuario = correoUsuario;
            EditarPerfil editarPerfil = new EditarPerfil(correoUsuario);
        }

        private void btn_minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrincipalAdmin_Load(object sender, EventArgs e)
        {
            lblNombre.Text = $"{nombreUsuario}";
            lblCorreo.Text = $"{correoUsuario}";
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cerrar sesión?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            pantalla_Principal pantalla_Principal = new pantalla_Principal();
            pantalla_Principal.Show();
        }

        private void Btn_Perfil_Click(object sender, EventArgs e)
        {
            EditarPerfil editarPerfil = new EditarPerfil(correoUsuario);
            pnl_Contenido.Controls.Clear();

            //Agregar el UserControl al Panel
            editarPerfil.Dock = DockStyle.Fill;
            pnl_Contenido.Controls.Add(editarPerfil);
        }

        private void Btn_Reportes_Click(object sender, EventArgs e)
        {
            
        }


        private void btn_GestionarUsuarios(object sender, EventArgs e)
        {
            MonitoreoUsers users = new MonitoreoUsers();
            pnl_Contenido.Controls.Clear();

            users.Dock = DockStyle.Fill;
            pnl_Contenido.Controls.Add(users);
        }

        private void btnGestionarDoctores_Click(object sender, EventArgs e)
        {
            Horarios horariodedoctor = new Horarios();
            pnl_Contenido.Controls.Clear();

            horariodedoctor.Dock = DockStyle.Fill;
            pnl_Contenido.Controls.Add(horariodedoctor);
        }
    }
}
