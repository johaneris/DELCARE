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

namespace UAM_INVESTIGATION.Forms
{
    public partial class RegistroUserEst : Form
    {
        public RegistroUserEst()
        {
            InitializeComponent();
        }

        private void RegistroUserEst_Load(object sender, EventArgs e)
        {
        }

        private void btn_Registrarse_Click_1(object sender, EventArgs e)
        {
            string correo = txt_Correo.Text;
           
            string contrasenia = txt_Contrasenia.Text;
            string nombre = txt_Nombre.Text;
         
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasenia) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Todos los campos deben de llenarse, por favor vuelva a intentarlo.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(correo.Contains("@") && (correo.EndsWith(".com") || correo.EndsWith(".ni"))))
            {
                MessageBox.Show("El correo electrónico es inválido, por favor vuelva a intentarlo.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (contrasenia.Length < 8)
            {
                MessageBox.Show("La contraseña es demasiado débil, por favor vuelva a intentarlo.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (char c in nombre)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("El nombre no puede contener carácteres alfanuméricos, por favor vuelva a intentarlo.",
                            "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            
            InitRegis regis = new InitRegis();

            if (regis.CorreoExistenteEnEstudiantes(correo))
            {
                MessageBox.Show("El correo ya está registrado, por favor ingrese otro correo.",
                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int id = new Random().Next(1000, 9999);
                bool estado = true;
                //Crear nuevo Usuario
                UsuarioEst nuevoUsuarioEst = new UsuarioEst(id, nombre, correo, contrasenia, estado);

                //Registrarlo
                regis.RegistrarUsuarioEst(nuevoUsuarioEst);

                MessageBox.Show("Usuario registrado exitosamente!", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicioSesionUserEst inicioSesionUserEst = new InicioSesionUserEst();
                inicioSesionUserEst.Show();
                this.Hide();
            }
            
        }

        private void Lnk_Sesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicioSesionUserEst inicioSesionUserEst = new InicioSesionUserEst();
            inicioSesionUserEst.Show();
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

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            InicioSesionUserEst inicioSesionUserEst = new InicioSesionUserEst();
            inicioSesionUserEst.Show();
            this.Hide();
        }

        private void show_Password_CheckedChanged_1(object sender, EventArgs e)
        {
            if (show_Password.Checked)
            {
                txt_Contrasenia.UseSystemPasswordChar = false; //Mostrar la contraseña
            }
            else
            {
                txt_Contrasenia.UseSystemPasswordChar = true; //Ocultar Contraseña
            }
        }

        private void txt_Correo_Enter(object sender, EventArgs e)
        {
            if (txt_Correo.Text == "CORREO")
            {
                txt_Correo.Text = "";
                txt_Correo.ForeColor = Color.LightGray;
            }
        }

        private void txt_Correo_Leave(object sender, EventArgs e)
        {
            if (txt_Correo.Text == "")
            {
                txt_Correo.Text = "CORREO";
                txt_Correo.ForeColor = Color.DimGray;
            }
        }


        private void txt_Contrasenia_Enter(object sender, EventArgs e)
        {
            if (txt_Contrasenia.Text == "CONTRASEÑA")
            {
                txt_Contrasenia.Text = "";
                txt_Contrasenia.ForeColor = Color.LightGray;
                txt_Contrasenia.UseSystemPasswordChar = true;
            }
        }

        private void txt_Contrasenia_Leave(object sender, EventArgs e)
        {
            if (txt_Contrasenia.Text == "")
            {
                txt_Contrasenia.Text = "CONTRASEÑA";
                txt_Contrasenia.ForeColor = Color.DimGray;
                txt_Contrasenia.UseSystemPasswordChar = false;
            }
        }

        private void txt_Nombre_Enter(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "NOMBRE COMPLETO")
            {
                txt_Nombre.Text = "";
                txt_Nombre.ForeColor = Color.LightGray;
            }
        }

        private void txt_Nombre_Leave(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "")
            {
                txt_Nombre.Text = "NOMBRE COMPLETO";
                txt_Nombre.ForeColor = Color.DimGray;
            }
        }

       

       
    }
}
