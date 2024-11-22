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
using UAM_INVESTIGATION.FormEstudiantes;

namespace UAM_INVESTIGATION.Forms
{
    public partial class InicioSesionUserEst : Form
    {
        public InicioSesionUserEst()
        {
            InitializeComponent();
        }

        private string ObtenerNombreUsuarioEst(string entrada)
        {
            InitRegis initRegis = new InitRegis();
            var estudiantes = initRegis.LeerUsuariosEst();
            foreach(var est in estudiantes)
            {
                if (est.Correo == entrada)
                {
                    return est.Nombre;
                }
            }
            return "";
        }
       
        private string ObtenerCorreo(string entrada)
        {
            InitRegis initRegis = new InitRegis();
            var estudiantes = initRegis.LeerUsuariosEst();
            foreach (var est in estudiantes)
            {
                if (est.Correo == entrada)
                {
                    return est.Correo;
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
        private void btn_InicioSesion_Click(object sender, EventArgs e)
        {
            string entrada = txt_CorreoCif.Text;
            string contrasenia = txt_Contrasenia.Text;
            string correo = null;
            string cif = null;
            int type = 0;

            if (txt_CorreoCif.Text != "CORREO O CIF")
            {
                if(txt_Contrasenia.Text != "CONTRASEÑA")
                {
                    //Validación si es correo
                    if (entrada.Contains("@") && (entrada.EndsWith(".com") || entrada.EndsWith(".ni")))
                    {
                        correo = entrada; //Si es correo se guarda como correo
                        type = 1;
                    }
                    else if (entrada.Length == 8 && entrada.All(char.IsDigit))
                    {
                        cif = entrada; //Si son 8 carácteres alfanuméricos, se guarda como cif
                        type = 2;
                    }

                    InitRegis initRegis = new InitRegis();
                    bool inicioValido = false;
                    if (type == 1)
                    {
                        var estudiante = initRegis.LeerUsuariosEst().FirstOrDefault(est => est.Correo == correo);
                        if (!estudiante.Estado)
                        {
                            msgError("El usuario está dado de baja y no puede iniciar sesión.");
                            return;
                        }
                        else if (!inicioValido && !string.IsNullOrEmpty(correo))
                        {
                            inicioValido = initRegis.IniciarSesionEstCorreo(correo, contrasenia);
                        }
                    }


                    if (inicioValido)
                    {
                        string nombreUsuario = ObtenerNombreUsuarioEst(correo ?? cif);

                        string correoUsuario = ObtenerCorreo(correo ?? cif);

                        //Redirigir a la pantalla principal de Estudiantes
                        this.Hide();
                        Bienvenida bienvenida = new Bienvenida(nombreUsuario);
                        bienvenida.ShowDialog();

                        if (type == 1)
                        {
                            PrincipalEst principalEst = new PrincipalEst(nombreUsuario, correo);
                            principalEst.Show();
                        }

                        
                        
                    }
                    else
                    {
                        msgError("El Correo/Cif o la Contraseña son incorrectos.");
                        txt_Contrasenia.Clear();
                        txt_CorreoCif.Focus();
                    }
                }
                else msgError("Porfavor ingrese la contraseña");
            }
            else msgError("Porfavor ingrese su correo");

            
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

        private void InicioSesionUserEst_Load(object sender, EventArgs e)
        {
        }

        private void Lnk_Registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUserEst registroUserEst = new RegistroUserEst();
            registroUserEst.Show();
            this.Hide();
        }

        //PLACEHOLDERS
        private void txt_CorreoCif_Enter(object sender, EventArgs e)
        {
            if(txt_CorreoCif.Text == "CORREO O CIF")
            {
                txt_CorreoCif.Text = "";
                txt_CorreoCif.ForeColor = Color.LightGray;
            }
        }

        private void txt_CorreoCif_Leave(object sender, EventArgs e)
        {
            if (txt_CorreoCif.Text == "")
            {
                txt_CorreoCif.Text = "CORREO O CIF";
                txt_CorreoCif.ForeColor = Color.DimGray;
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

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minisize_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            pantalla_Principal pantalla_Principal = new pantalla_Principal();
            pantalla_Principal.Show();
            this.Hide();
        }
    }
}
