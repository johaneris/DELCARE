using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using UAM_INVESTIGATION.Helpers;
using UAM_INVESTIGATION.FormAdmin;


namespace UAM_INVESTIGATION.Forms
{
    public partial class InicioSesionUserAdmin : Form
    {
        public InicioSesionUserAdmin()
        {
            InitializeComponent();
        }

        private void cb_MostrarContrasenia_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_MostrarContrasenia.Checked)
            {
                txt_Contrasenia.UseSystemPasswordChar = false; //Mostrar la contraseña
            }
            else
            {
                txt_Contrasenia.UseSystemPasswordChar = true; //Ocultar Contraseña
            }
        }

        private void InicioSesionUserAdmin_Load(object sender, EventArgs e)
        {
        } 

        private void btn_minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //PLACEHOLDERS

        private void txt_Correo_Enter_1(object sender, EventArgs e)
        {
            if (txt_Correo.Text == "CORREO")
            {
                txt_Correo.Text = "";
                txt_Correo.ForeColor = Color.Black;
            }
        }

        private void txt_Correo_Leave_1(object sender, EventArgs e)
        {
            if (txt_Correo.Text == "")
            {
                txt_Correo.Text = "CORREO";
                txt_Correo.ForeColor = Color.DimGray;
            }
        }

        private void txt_Contrasenia_Enter_1(object sender, EventArgs e)
        {
            if (txt_Contrasenia.Text == "CONTRASEÑA")
            {
                txt_Contrasenia.Text = "";
                txt_Contrasenia.ForeColor = Color.Black;
                txt_Contrasenia.UseSystemPasswordChar = true;
            }
        }

        private void txt_Contrasenia_Leave_1(object sender, EventArgs e)
        {
            if (txt_Contrasenia.Text == "")
            {
                txt_Contrasenia.Text = "CONTRASEÑA";
                txt_Contrasenia.ForeColor = Color.DimGray;
                txt_Contrasenia.UseSystemPasswordChar = false;
            }
        }

        private void Lnk_Registro_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUserAdmin registroUserAdmin = new RegistroUserAdmin();
            registroUserAdmin.Show();
            this.Hide();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            pantalla_Principal pantalla_Principal = new pantalla_Principal();
            pantalla_Principal.Show();
            this.Hide();
        }
        private string ObtenerNombreUsuarioAdmin(string correo)
        {
            InitRegis initRegis = new InitRegis();
            var admins = initRegis.LeerUsuariosAdmin();

            foreach (var admin in admins)
            {
                if(admin.Correo == correo)
                {
                    return admin.Nombre;
                }
            }
            return "";
        }
        private void msgError(string message)
        {
            lblErrorMessage.Text = message;
            lblErrorMessage.Visible = true;
            iconPictureBox1.Visible = true;
        }
        private void btn_InicioSesion_Click_1(object sender, EventArgs e)
        {
            
            string entrada = txt_Correo.Text;
            string contrasenia = txt_Contrasenia.Text;
            string correo = entrada;

            InitRegis initRegis = new InitRegis();
            bool inicioValido = false;
            if (txt_Correo.Text != "CORREO")
            {
                if (txt_Contrasenia.Text != "CONTRASEÑA") {
                    if (!inicioValido && !string.IsNullOrEmpty(correo))
                    {
                        inicioValido = initRegis.IniciarSesionAdmin(correo, contrasenia);
                    }

                    if (inicioValido)
                    {
                        string nombreUsuario = ObtenerNombreUsuarioAdmin(correo);

                        //Redirigir a la pantalla principal de Admins
                        this.Hide();
                        Bienvenida bienvenida = new Bienvenida(nombreUsuario);
                        bienvenida.ShowDialog();
                        PrincipalAdmin principalAdmin = new PrincipalAdmin(nombreUsuario, correo);
                        principalAdmin.Show();
                    }
                    else
                    {
                        msgError("El Correo o la Contraseña son incorrectos.");
                        txt_Contrasenia.Clear();
                        txt_Correo.Focus();
                    }
                }
                else msgError("Porfavor ingrese la contraseña");
            }
            else msgError("Porfavor ingrese su correo"); 
        }
    }
}
