namespace UAM_INVESTIGATION.FornPaciente
{
    partial class ConsultarHorarios
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Salir = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Deshacer = new System.Windows.Forms.Button();
            this.cmb_BuscarDoctor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.Btn_Salir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 514);
            this.panel1.TabIndex = 4;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.IconChar = FontAwesome.Sharp.IconChar.X;
            this.Btn_Salir.IconColor = System.Drawing.Color.Black;
            this.Btn_Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Salir.IconSize = 15;
            this.Btn_Salir.Location = new System.Drawing.Point(3, 3);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(15, 15);
            this.Btn_Salir.TabIndex = 18;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UAM_INVESTIGATION.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(47, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "DentalCare";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(247, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 60);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(167, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Horarios Disponibles";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.panelMain.Controls.Add(this.btn_Buscar);
            this.panelMain.Controls.Add(this.btn_Deshacer);
            this.panelMain.Controls.Add(this.cmb_BuscarDoctor);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.dgvHorarios);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(247, 60);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(603, 454);
            this.panelMain.TabIndex = 6;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.Black;
            this.btn_Buscar.Location = new System.Drawing.Point(240, 383);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(98, 40);
            this.btn_Buscar.TabIndex = 52;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Deshacer
            // 
            this.btn_Deshacer.BackColor = System.Drawing.Color.DimGray;
            this.btn_Deshacer.FlatAppearance.BorderSize = 0;
            this.btn_Deshacer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Deshacer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Deshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deshacer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deshacer.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Deshacer.Location = new System.Drawing.Point(108, 383);
            this.btn_Deshacer.Name = "btn_Deshacer";
            this.btn_Deshacer.Size = new System.Drawing.Size(98, 40);
            this.btn_Deshacer.TabIndex = 51;
            this.btn_Deshacer.Text = "Deshacer";
            this.btn_Deshacer.UseVisualStyleBackColor = false;
            this.btn_Deshacer.Click += new System.EventHandler(this.btn_Deshacer_Click);
            // 
            // cmb_BuscarDoctor
            // 
            this.cmb_BuscarDoctor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_BuscarDoctor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BuscarDoctor.FormattingEnabled = true;
            this.cmb_BuscarDoctor.Items.AddRange(new object[] {
            ""});
            this.cmb_BuscarDoctor.Location = new System.Drawing.Point(87, 349);
            this.cmb_BuscarDoctor.Name = "cmb_BuscarDoctor";
            this.cmb_BuscarDoctor.Size = new System.Drawing.Size(270, 28);
            this.cmb_BuscarDoctor.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(59, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar Doctor";
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.dgvHorarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHorarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHorarios.ColumnHeadersHeight = 30;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doctor,
            this.horaInicial,
            this.horaFinal,
            this.diaSemana});
            this.dgvHorarios.EnableHeadersVisualStyles = false;
            this.dgvHorarios.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvHorarios.Location = new System.Drawing.Point(47, 49);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHorarios.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHorarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHorarios.Size = new System.Drawing.Size(507, 252);
            this.dgvHorarios.TabIndex = 5;
            this.dgvHorarios.TabStop = false;
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.Name = "Doctor";
            this.Doctor.Width = 120;
            // 
            // horaInicial
            // 
            this.horaInicial.HeaderText = "Hora Inicial";
            this.horaInicial.Name = "horaInicial";
            this.horaInicial.Width = 110;
            // 
            // horaFinal
            // 
            this.horaFinal.HeaderText = "Hora Final";
            this.horaFinal.Name = "horaFinal";
            this.horaFinal.Width = 110;
            // 
            // diaSemana
            // 
            this.diaSemana.HeaderText = "Días Semanales";
            this.diaSemana.Name = "diaSemana";
            this.diaSemana.Width = 115;
            // 
            // ConsultarHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ConsultarHorarios";
            this.Size = new System.Drawing.Size(850, 514);
            this.Load += new System.EventHandler(this.ConsultarHorarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaSemana;
        private System.Windows.Forms.ComboBox cmb_BuscarDoctor;
        private System.Windows.Forms.Button btn_Deshacer;
        private System.Windows.Forms.Button btn_Buscar;
    }
}
