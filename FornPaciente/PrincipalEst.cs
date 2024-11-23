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
using UAM_INVESTIGATION.FormAdmin;
using UAM_INVESTIGATION.FornPaciente;

namespace UAM_INVESTIGATION.FormEstudiantes
{
    public partial class PrincipalEst : Form
    {
        private string nombreUsuario;
        private string correoUsuario;
        private int idPaciente;        
        public PrincipalEst(string nombreUsuario, string correoUsuario, int id)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.correoUsuario = correoUsuario;
            this.idPaciente = id;

        }

        private void btn_minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrincipalEst_Load(object sender, EventArgs e)
        {
            lblNombre.Text = $"{nombreUsuario}";
            lblCorreo.Text = $"{correoUsuario}";

        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cerrar sesión?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                pantalla_Principal pantalla_Principal = new pantalla_Principal();
                pantalla_Principal.Show();
            }

        }

        private void Btn_Perfil_Click(object sender, EventArgs e)
        {
            EditarPerfilEst editarPerfilEst = new EditarPerfilEst(correoUsuario);
            pnl_Content.Controls.Clear();

            //Agregar el UserControl al Panel
            editarPerfilEst.Dock = DockStyle.Fill;
            pnl_Content.Controls.Add(editarPerfilEst);
        }

        private void Btno_Horarios_Click(object sender, EventArgs e)
        {
            ConsultarHorarios consultarHorarios = new ConsultarHorarios();
            pnl_Content.Controls.Clear();

            consultarHorarios.Dock = DockStyle.Fill;
            pnl_Content.Controls.Add(consultarHorarios);
        }

        private void Btn_AgendarCitas_Click(object sender, EventArgs e)
        {
            Agendar_citas agendar_Citas = new Agendar_citas(idPaciente);
            pnl_Content.Controls.Clear();

            agendar_Citas.Dock = DockStyle.Fill;
            pnl_Content.Controls.Add(agendar_Citas);
        }

        private void Btn_HistorialCitas_Click(object sender, EventArgs e)
        {
            ConsultarCitas consultarCitas = new ConsultarCitas(idPaciente);
            pnl_Content.Controls.Clear();

            consultarCitas.Dock = DockStyle.Fill;
            pnl_Content.Controls.Add(consultarCitas);
        }
    }
}
