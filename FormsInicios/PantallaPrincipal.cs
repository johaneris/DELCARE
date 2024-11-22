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

namespace UAM_INVESTIGATION
{
    public partial class pantalla_Principal : Form
    {
        public pantalla_Principal()
        {
            InitializeComponent();
        }

        private void Btn_UserRegis_Click_1(object sender, EventArgs e)
        {
            //Mostrar Formulario Inicio Sesion Estudiantes
            InicioSesionUserEst inicioSesionUserEst = new InicioSesionUserEst();
            inicioSesionUserEst.Show();
            this.Hide();
        }

        private void Btn_AdminRegis_Click_1(object sender, EventArgs e)
        {
            InicioSesionUserAdmin inicioSesionUserAdmin = new InicioSesionUserAdmin();
            inicioSesionUserAdmin.Show();
            this.Hide();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
