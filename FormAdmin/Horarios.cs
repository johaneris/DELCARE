using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAM_INVESTIGATION.BasesdeDatos;
using System.Data.SQLite;


namespace UAM_INVESTIGATION.FormAdmin
{
    public partial class Horarios : UserControl
    {
        public Horarios()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     



        private void ConfigurarDataGridView()
        {
            // Definir columnas si no están definidas desde el diseñador
            if (dataGridViewHorarios.Columns.Count == 0)
            {
                dataGridViewHorarios.Columns.Clear();
                dataGridViewHorarios.Columns.Add("DiaSemana", "Día de la Semana");
                dataGridViewHorarios.Columns.Add("HoraInicio", "Hora de Inicio");
                dataGridViewHorarios.Columns.Add("HoraFin", "Hora de Fin");
            }
        }

       
    }
}

