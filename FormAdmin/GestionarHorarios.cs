﻿using System;
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
    public partial class GestionarHorarios : UserControl
    {
        private DoctorService doctorService;
        private ControlHorario controlHorario;
        public GestionarHorarios()
        {
            InitializeComponent();
            doctorService = new DoctorService();
            controlHorario = new ControlHorario();
            InicializarFormulario();
            ConfigurarDateTimePickers();
        }

        private void InicializarFormulario()
        {
            CargarDoctoresComboBox();
            //CargarDoctores();
            InicializarComboBoxDias();
            CargarHorarios();
        }

        private void CargarDoctoresComboBox()
        {
            DoctorService doctorService = new DoctorService();
            var doctores = doctorService.LeerDoctores();

            cmb_Doctores.Items.Clear();

            foreach (var doctor in doctores)
            {
                if(doctor.Activo == true)
                {
                    cmb_Doctores.Items.Add(doctor.Nombre);
                }
            }
        }

        /*
        private void CargarDoctores()
        {
            var doctores = doctorService.LeerDoctores();
            cmb_Doctores.DataSource = doctores.FindAll(d => d.Activo); // Filtrar doctores activos
            cmb_Doctores.DisplayMember = "Nombre";
            cmb_Doctores.ValueMember = "Id";
        }
        */

        private void InicializarComboBoxDias()
        {
            cmb_DiaSemana.Items.AddRange(new string[]
            {
                "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"
            });
            cmb_DiaSemana.SelectedIndex = -1;
        }

        private void ConfigurarDateTimePickers()
        {
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.CustomFormat = "HH:mm";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Value = DateTime.Today.AddHours(8); // Valor inicial 8:00 AM

            dtpFinal.Format = DateTimePickerFormat.Custom;
            dtpFinal.CustomFormat = "HH:mm";
            dtpFinal.ShowUpDown = true;
            dtpFinal.Value = DateTime.Today.AddHours(9); // Valor inicial 9:00 AM
        }
        private void CargarHorarios()
        {
            try
            {
                var horarios = controlHorario.LeerHorarios();
                dgvHorarios.Rows.Clear();

                foreach (var horario in horarios)
                {
                    dgvHorarios.Rows.Add(horario.ID, horario.DoctorID, horario.HoraInicial, horario.HoraFinal, horario.DiaSemana, horario.Activo ? "Activo" : "Inactivo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los horarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerIdDoctor(string nombreDoctor)
        {
            DoctorService doctorService= new DoctorService();
            var doctor = doctorService.LeerDoctores();

            foreach (var doc in doctor)
            {
                if (doc.Nombre == nombreDoctor)
                {
                    return doc.Id;
                }
            }
            return 0;
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación del doctor seleccionado
                if (cmb_Doctores.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un doctor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación del ComboBox (día de la semana)
                if (cmb_DiaSemana.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un día de la semana.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación de las horas
                DateTime horaInicial = dtpHoraInicio.Value;
                DateTime horaFinal = dtpFinal.Value;

                if (!ValidarHoras(horaInicial, horaFinal))
                {
                    return; // La función ValidarHoras muestra mensajes de error si las horas son inválidas.
                }

                // Validación del rango de fechas (noviembre de 2024 a diciembre de 2025)
                if (!ValidarFechas(horaInicial))
                {
                    return; // La función ValidarFechas muestra mensajes de error si la fecha es inválida.
                }

                // Crear y guardar el horario
                int idHorario = new Random().Next(1000, 9999); // Generar ID aleatorio
                int idDoctor = ObtenerIdDoctor(cmb_Doctores.Text);
                string diaSemana = cmb_DiaSemana.SelectedItem.ToString();
                bool activo = true;

                Horario nuevoHorario = new Horario(idHorario, idDoctor, horaInicial, horaFinal, diaSemana, activo);
                controlHorario.GuardarHorarios(nuevoHorario);

                // Confirmación
                MessageBox.Show("Horario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarHorarios();

                // Limpiar campos
                LimpiarCamposHorario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el horario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarHoras(DateTime horaInicial, DateTime horaFinal)
        {
            if (horaInicial < DateTime.Today.AddHours(8) || horaInicial > DateTime.Today.AddHours(20))
            {
                MessageBox.Show("La hora de inicio debe estar entre las 8:00 AM y las 8:00 PM.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (horaFinal <= horaInicial)
            {
                MessageBox.Show("La hora de fin debe ser mayor que la hora de inicio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (horaFinal > DateTime.Today.AddHours(20))
            {
                MessageBox.Show("La hora de fin no puede exceder las 8:00 PM.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidarFechas(DateTime fecha)
        {
            if (fecha.Year < 2024 || (fecha.Year == 2024 && fecha.Month < 11))
            {
                MessageBox.Show("La fecha debe ser a partir de noviembre de 2024.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (fecha.Year > 2025 || (fecha.Year == 2025 && fecha.Month > 12))
            {
                MessageBox.Show("La fecha no puede exceder diciembre de 2025.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarCamposHorario()
        {
            cmb_Doctores.SelectedIndex = -1;
            cmb_DiaSemana.SelectedIndex = -1; // Limpiar selección del ComboBox
            dtpHoraInicio.Value = DateTime.Today.AddHours(8); // Resetear al inicio del rango permitido
            dtpFinal.Value = DateTime.Today.AddHours(9);    // Resetear a un valor por defecto
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCamposHorario();
        }


        //private void LimpiarCampos()
        //{
        //   
        //    cmb_Doctores.Clear();
        //    cmbDiadeSemana.SelectedIndex = 0;
        //}
    }
}
