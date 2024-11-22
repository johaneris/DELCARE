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

namespace UAM_INVESTIGATION.FormEstudiantes
{
    public partial class EditarPerfilEst : UserControl
    {
        private string correo;
        private string cif;
        private string contrasenia;
        private string nombre;
        private string carrera;
        private int Id;
        private bool estado;
        public EditarPerfilEst(string correo)
        {
            InitializeComponent();
            this.correo = correo;
        }

        private void ObtenerCachesEstudiante(string correoCache)
        {
            InitRegis initRegis = new InitRegis();
            var est = initRegis.LeerUsuariosEst().FirstOrDefault(a => a.Correo == correoCache);

            if(!est.Equals(default(UsuarioEst)))
            {
                Id = est.Id;
                
                contrasenia = est.Contrasenia;
                nombre = est.Nombre;
                
                estado = est.Estado;

                //Actualizar labels
                lbl_Id.Text = Id.ToString();
                lbl_Correo.Text = correoCache;
                lbl_Cif.Text = cif;
                lbl_Nombre.Text = nombre;
                lbl_Carrera.Text = carrera;
            }
        }

        private void EditarPerfilEst_Load(object sender, EventArgs e)
        {
            ObtenerCachesEstudiante(correo);
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
            string cif = txt_Cif.Text;
            string carrera = txt_Carrera.Text;
            string contrasenia = txt_Contrasenia.Text;
            string contraseniaConfirm = txt_ContraseniaConfirm.Text;
            string contraseniaCurrent = txt_CurrentContrasenia.Text;

            if(txt_Nombre.Text != "")
            {
                if(txt_Correo.Text != "")
                {
                    if(txt_Cif.Text != "")
                    {
                        if(txt_Carrera.Text != "")
                        {
                            if(txt_Contrasenia.Text != "" || txt_ContraseniaConfirm.Text != "")
                            {
                                if(contrasenia == contraseniaConfirm)
                                {
                                    if(txt_CurrentContrasenia.Text != "")
                                    {
                                        DialogResult result = MessageBox.Show("¿Estás seguro de que deseas guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (result == DialogResult.Yes)
                                        {
                                            //Aplicar lógica para actualizar
                                            InitRegis initRegis = new InitRegis();

                                            try
                                            {
                                                initRegis.ActualizarUsuarioEst(Id, nombre, correo, cif, contraseniaCurrent, carrera, estado);
                                                MessageBox.Show("El perfil se actualizó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                txt_Nombre.Clear();
                                                txt_Correo.Clear();
                                                txt_Cif.Clear();
                                                txt_Carrera.Clear();
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
                                    msgError("Las contraseñas no coinciden");
                                }
                            }
                            else
                            {
                                msgError("Porfavor ingrese la contraseña");
                            }
                        }
                        else
                        {
                            msgError("Porfavor ingrese la carrera");
                        }
                    }
                    else
                    {
                        msgError("Porfavor ingrese el cif");
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
            txt_Cif.Clear();
            txt_Carrera.Clear();
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
