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
    public partial class EditarPerfil : UserControl
    {
        private string correo;
        private string contrasenia;
        private string nombre;
        private int Id;
        public EditarPerfil(string correo)
        {
            InitializeComponent();
            this.correo = correo;
        }
        private void ObtenerCachesAdmin(string correoCache)
        {
            InitRegis initRegis = new InitRegis();

            // Buscamos al administrador cuyo correo coincida con el proporcionado
            var admin = initRegis.LeerUsuariosAdmin().FirstOrDefault(a => a.Correo == correoCache);

            // Comprobamos si 'admin' es el valor por defecto del struct
            if (!admin.Equals(default(UsuarioAdmin))) // 'admin' no es el valor predeterminado
            {
                Id = admin.Id;
                nombre = admin.Nombre;
                contrasenia = admin.Contrasenia;

                // Actualizamos los labels con los datos del administrador
                lbl_Id.Text = Id.ToString();
                lbl_Nombre.Text = nombre;
                lbl_Correo.Text = correoCache; 
            }
        }


        private void EditarPerfil_Load(object sender, EventArgs e)
        {
            ObtenerCachesAdmin(correo);
            txt_Contrasenia.UseSystemPasswordChar = true;
            txt_ContraseniaConfirm.UseSystemPasswordChar = true;
            txt_CurrentContrasenia.UseSystemPasswordChar = true;
        }

        private void msgError(string message)
        {
            lblErrorMessage.Text = message;
            lblErrorMessage.Visible = true;
            iconPictureBox2.Visible = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nombre.Text;
            string correo = txt_Correo.Text;
            string contrasenia = txt_Contrasenia.Text;
            string contraseniaConfirm = txt_ContraseniaConfirm.Text;
            string currentContrasenia = txt_CurrentContrasenia.Text;

            if (txt_Nombre.Text != "")
            {
                if (txt_Correo.Text != "")
                {
                    if (txt_Contrasenia.Text != "" || txt_ContraseniaConfirm.Text != "")
                    {
                        if(contrasenia == contraseniaConfirm)
                        {
                            if (txt_CurrentContrasenia.Text != "")
                            {
                                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    //Aplicar lógica para actualizar
                                    InitRegis initRegis = new InitRegis();

                                    try
                                    {
                                        initRegis.ActualizarUsuarioAdmin(Id, nombre, correo, currentContrasenia);
                                        MessageBox.Show("El perfil se actualizó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txt_Nombre.Clear();
                                        txt_Correo.Clear();
                                        txt_Contrasenia.Clear();
                                        txt_ContraseniaConfirm.Clear();
                                        txt_CurrentContrasenia.Clear();
                                        lblErrorMessage.Visible = false;
                                        iconPictureBox2.Visible = false;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"Hubo un problema al actualizar el perfil: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                
                            }
                            else
                            {
                                msgError("Porfavor ingrese una nueva contraseña");
                                
                            }
                        }
                        else
                        {
                            msgError("Las contraseñas no coinciden.");
                        }
                    }
                    else
                    {
                        msgError("Porfavor ingrese la contraseña");
                    }
                }
                else
                {
                    msgError("Porfavor ingrese el correo");
                }
            }
            else
            {
                msgError("Porfavor ingrese el nombre");
            }
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            txt_Correo.Clear();
            txt_Contrasenia.Clear();
            txt_ContraseniaConfirm.Clear();
            txt_CurrentContrasenia.Clear();
        }

        private void cb_ShowCont_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowCont.Checked)
            {
                txt_Contrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Contrasenia.UseSystemPasswordChar = true;
            }
        }

        private void cb_ShowContConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowContConfirm.Checked)
            {
                txt_ContraseniaConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txt_ContraseniaConfirm.UseSystemPasswordChar = true;
            }
        }

        private void cb_ShowCurrentCont_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowCurrentCont.Checked)
            {
                txt_CurrentContrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                txt_CurrentContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
