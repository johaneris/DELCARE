using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using UAM_INVESTIGATION.Estructuras;
using UAM_INVESTIGATION.Helpers;

namespace UAM_INVESTIGATION.Forms
{
    public partial class RegistroUserAdmin : Form
    {
        public RegistroUserAdmin()
        {
            InitializeComponent();
        }

        private void RegistroUserAdmin_Load(object sender, EventArgs e)
        {
        }

        private void show_Password_CheckedChanged(object sender, EventArgs e)
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

        private void show_code_CheckedChanged(object sender, EventArgs e)
        {
            if (show_code.Checked)
            {
                txt_code_access.UseSystemPasswordChar = false; //Mostrar la contraseña
            }
            else
            {
                txt_code_access.UseSystemPasswordChar = true; //Ocultar Contraseña
            }
        }

        private void Lnk_Sesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Mostrar Formulario Inicio Sesion Admin
            InicioSesionUserAdmin inicioSesionUserAdmin = new InicioSesionUserAdmin();
            inicioSesionUserAdmin.Show();
            this.Hide();
        }

        private void btn_registrarse_Click_1(object sender, EventArgs e)
        {
            string code = txt_code_access.Text;
            string correo = txt_Correo.Text;
            string contrasenia = txt_Contrasenia.Text;
            string nombre = txt_Nombre.Text;

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(code) || string.IsNullOrEmpty(contrasenia) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Todos los campos deben de llenarse, por favor vuelva a intentarlo.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(code.Equals("Delcare")))
            {
                MessageBox.Show("El código de acceso es inválido, por favor vuelva a intentarlo...",
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
            InitRegis initRegis = new InitRegis();

            if (initRegis.CorreoExisteEnAdmins(correo))
            {
                MessageBox.Show("El correo ya está registrado, por favor ingrese otro correo.",
                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int id = new Random().Next(1000, 9999);
                //Crear Nuevo Usuario
                UsuarioAdmin admin = new UsuarioAdmin(id, nombre, correo, contrasenia);
                //Registrarlo
                initRegis.RegistrarUsuarioAdmin(admin);
                MessageBox.Show("Usuario registrado exitosamente!", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicioSesionUserAdmin inicioSesionUserAdmin = new InicioSesionUserAdmin();
                inicioSesionUserAdmin.Show();
                this.Hide();
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

        private void txt_code_access_Enter(object sender, EventArgs e)
        {
            if (txt_code_access.Text == "CODIGO DE ACCESO")
            {
                txt_code_access.Text = "";
                txt_code_access.ForeColor = Color.LightGray;
                txt_code_access.UseSystemPasswordChar = true;
            }
        }

        private void txt_code_access_Leave(object sender, EventArgs e)
        {
            if (txt_code_access.Text == "")
            {
                txt_code_access.Text = "CODIGO DE ACCESO";
                txt_code_access.ForeColor = Color.DimGray;
                txt_code_access.UseSystemPasswordChar = false;
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
            InicioSesionUserAdmin inicioSesionUserAdmin = new InicioSesionUserAdmin();
            inicioSesionUserAdmin.Show();
            this.Hide();
        }
    }
}
