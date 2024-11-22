namespace UAM_INVESTIGATION.FormAdmin
{
    partial class Horarios
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
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDoctores = new System.Windows.Forms.ComboBox();
            this.dataGridViewHorarios = new System.Windows.Forms.DataGridView();
            this.cmbDiaSemana = new System.Windows.Forms.ComboBox();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDoctores = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbEspecialidad = new System.Windows.Forms.TextBox();
            this.tbNombreDoctor = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnGuardarHorario = new FontAwesome.Sharp.IconButton();
            this.btnEliminarDoctor = new FontAwesome.Sharp.IconButton();
            this.btnActualizarDoctor = new FontAwesome.Sharp.IconButton();
            this.BtnGuardarDoctor = new FontAwesome.Sharp.IconButton();
            this.Btn_LogOut = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbGestionHiorario = new System.Windows.Forms.GroupBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minisize = new FontAwesome.Sharp.IconButton();
            this.Btn_Salir = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Content.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctores)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Content
            // 
            this.pnl_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.pnl_Content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_Content.Controls.Add(this.groupBox2);
            this.pnl_Content.Controls.Add(this.groupBox1);
            this.pnl_Content.Location = new System.Drawing.Point(200, 34);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(898, 470);
            this.pnl_Content.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDoctores);
            this.groupBox2.Controls.Add(this.dataGridViewHorarios);
            this.groupBox2.Controls.Add(this.cmbDiaSemana);
            this.groupBox2.Controls.Add(this.dtpHoraFin);
            this.groupBox2.Controls.Add(this.dtpHoraInicio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(0, 259);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(898, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestionar horarios";
            // 
            // cmbDoctores
            // 
            this.cmbDoctores.FormattingEnabled = true;
            this.cmbDoctores.Location = new System.Drawing.Point(128, 40);
            this.cmbDoctores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDoctores.Name = "cmbDoctores";
            this.cmbDoctores.Size = new System.Drawing.Size(188, 21);
            this.cmbDoctores.TabIndex = 20;
            // 
            // dataGridViewHorarios
            // 
            this.dataGridViewHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorarios.Location = new System.Drawing.Point(370, 8);
            this.dataGridViewHorarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewHorarios.Name = "dataGridViewHorarios";
            this.dataGridViewHorarios.RowHeadersWidth = 51;
            this.dataGridViewHorarios.RowTemplate.Height = 24;
            this.dataGridViewHorarios.Size = new System.Drawing.Size(527, 238);
            this.dataGridViewHorarios.TabIndex = 19;
            // 
            // cmbDiaSemana
            // 
            this.cmbDiaSemana.FormattingEnabled = true;
            this.cmbDiaSemana.Location = new System.Drawing.Point(128, 185);
            this.cmbDiaSemana.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDiaSemana.Name = "cmbDiaSemana";
            this.cmbDiaSemana.Size = new System.Drawing.Size(188, 21);
            this.cmbDiaSemana.TabIndex = 18;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Location = new System.Drawing.Point(128, 131);
            this.dtpHoraFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(188, 20);
            this.dtpHoraFin.TabIndex = 17;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Location = new System.Drawing.Point(128, 84);
            this.dtpHoraInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(188, 20);
            this.dtpHoraInicio.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "dia de la semana";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "hora final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "hora inicial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Doctor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDoctores);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTelefono);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbEspecialidad);
            this.groupBox1.Controls.Add(this.tbNombreDoctor);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(898, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar doctores";
            // 
            // dgvDoctores
            // 
            this.dgvDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctores.Location = new System.Drawing.Point(370, 15);
            this.dgvDoctores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDoctores.Name = "dgvDoctores";
            this.dgvDoctores.RowHeadersWidth = 51;
            this.dgvDoctores.RowTemplate.Height = 24;
            this.dgvDoctores.Size = new System.Drawing.Size(524, 238);
            this.dgvDoctores.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Especialidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(142, 171);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(188, 27);
            this.tbTelefono.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(142, 124);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(188, 27);
            this.tbEmail.TabIndex = 2;
            // 
            // tbEspecialidad
            // 
            this.tbEspecialidad.Location = new System.Drawing.Point(142, 75);
            this.tbEspecialidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEspecialidad.Name = "tbEspecialidad";
            this.tbEspecialidad.Size = new System.Drawing.Size(188, 27);
            this.tbEspecialidad.TabIndex = 1;
            // 
            // tbNombreDoctor
            // 
            this.tbNombreDoctor.Location = new System.Drawing.Point(142, 30);
            this.tbNombreDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombreDoctor.Name = "tbNombreDoctor";
            this.tbNombreDoctor.Size = new System.Drawing.Size(188, 27);
            this.tbNombreDoctor.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.btnGuardarHorario);
            this.panel2.Controls.Add(this.btnEliminarDoctor);
            this.panel2.Controls.Add(this.btnActualizarDoctor);
            this.panel2.Controls.Add(this.BtnGuardarDoctor);
            this.panel2.Controls.Add(this.Btn_LogOut);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 474);
            this.panel2.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 375);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 63);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // btnGuardarHorario
            // 
            this.btnGuardarHorario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardarHorario.FlatAppearance.BorderSize = 0;
            this.btnGuardarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarHorario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarHorario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGuardarHorario.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.btnGuardarHorario.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGuardarHorario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarHorario.IconSize = 30;
            this.btnGuardarHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarHorario.Location = new System.Drawing.Point(0, 300);
            this.btnGuardarHorario.Name = "btnGuardarHorario";
            this.btnGuardarHorario.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGuardarHorario.Size = new System.Drawing.Size(200, 75);
            this.btnGuardarHorario.TabIndex = 5;
            this.btnGuardarHorario.Text = "guardar horario";
            this.btnGuardarHorario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarHorario.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDoctor
            // 
            this.btnEliminarDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarDoctor.FlatAppearance.BorderSize = 0;
            this.btnEliminarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDoctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDoctor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarDoctor.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.btnEliminarDoctor.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarDoctor.IconSize = 30;
            this.btnEliminarDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDoctor.Location = new System.Drawing.Point(0, 225);
            this.btnEliminarDoctor.Name = "btnEliminarDoctor";
            this.btnEliminarDoctor.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEliminarDoctor.Size = new System.Drawing.Size(200, 75);
            this.btnEliminarDoctor.TabIndex = 3;
            this.btnEliminarDoctor.Text = "Eliminar doctor";
            this.btnEliminarDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarDoctor.UseVisualStyleBackColor = true;
            // 
            // btnActualizarDoctor
            // 
            this.btnActualizarDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActualizarDoctor.FlatAppearance.BorderSize = 0;
            this.btnActualizarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarDoctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDoctor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnActualizarDoctor.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnActualizarDoctor.IconColor = System.Drawing.Color.Gainsboro;
            this.btnActualizarDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarDoctor.IconSize = 30;
            this.btnActualizarDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarDoctor.Location = new System.Drawing.Point(0, 150);
            this.btnActualizarDoctor.Name = "btnActualizarDoctor";
            this.btnActualizarDoctor.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnActualizarDoctor.Size = new System.Drawing.Size(200, 75);
            this.btnActualizarDoctor.TabIndex = 2;
            this.btnActualizarDoctor.Text = "Actualizar doctor";
            this.btnActualizarDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarDoctor.UseVisualStyleBackColor = true;
            // 
            // BtnGuardarDoctor
            // 
            this.BtnGuardarDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGuardarDoctor.FlatAppearance.BorderSize = 0;
            this.BtnGuardarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarDoctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarDoctor.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnGuardarDoctor.IconChar = FontAwesome.Sharp.IconChar.User;
            this.BtnGuardarDoctor.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnGuardarDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardarDoctor.IconSize = 30;
            this.BtnGuardarDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarDoctor.Location = new System.Drawing.Point(0, 75);
            this.BtnGuardarDoctor.Name = "BtnGuardarDoctor";
            this.BtnGuardarDoctor.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnGuardarDoctor.Size = new System.Drawing.Size(200, 75);
            this.BtnGuardarDoctor.TabIndex = 1;
            this.BtnGuardarDoctor.Text = "Guardar Doctor";
            this.BtnGuardarDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardarDoctor.UseVisualStyleBackColor = true;
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_LogOut.FlatAppearance.BorderSize = 0;
            this.Btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LogOut.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_LogOut.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.Btn_LogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_LogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_LogOut.IconSize = 30;
            this.Btn_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_LogOut.Location = new System.Drawing.Point(0, 438);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_LogOut.Size = new System.Drawing.Size(200, 36);
            this.Btn_LogOut.TabIndex = 4;
            this.Btn_LogOut.Text = "Log out";
            this.Btn_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lblCorreo);
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 75);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.gbGestionHiorario);
            this.panel4.Location = new System.Drawing.Point(37, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(889, 474);
            this.panel4.TabIndex = 6;
            // 
            // gbGestionHiorario
            // 
            this.gbGestionHiorario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gbGestionHiorario.Location = new System.Drawing.Point(0, 219);
            this.gbGestionHiorario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbGestionHiorario.Name = "gbGestionHiorario";
            this.gbGestionHiorario.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbGestionHiorario.Size = new System.Drawing.Size(513, 255);
            this.gbGestionHiorario.TabIndex = 1;
            this.gbGestionHiorario.TabStop = false;
            this.gbGestionHiorario.Text = "Agregar doctores";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCorreo.Location = new System.Drawing.Point(47, 47);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(43, 15);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(47, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(38, 15);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(47, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Administrador";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 41;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 75);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.btn_minisize);
            this.panel1.Controls.Add(this.Btn_Salir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 34);
            this.panel1.TabIndex = 3;
            // 
            // btn_minisize
            // 
            this.btn_minisize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btn_minisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_minisize.FlatAppearance.BorderSize = 0;
            this.btn_minisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minisize.IconChar = FontAwesome.Sharp.IconChar.Compress;
            this.btn_minisize.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_minisize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minisize.IconSize = 20;
            this.btn_minisize.Location = new System.Drawing.Point(1050, 3);
            this.btn_minisize.Name = "btn_minisize";
            this.btn_minisize.Size = new System.Drawing.Size(15, 15);
            this.btn_minisize.TabIndex = 18;
            this.btn_minisize.TabStop = false;
            this.btn_minisize.UseVisualStyleBackColor = false;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.IconChar = FontAwesome.Sharp.IconChar.X;
            this.Btn_Salir.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Salir.IconSize = 15;
            this.Btn_Salir.Location = new System.Drawing.Point(1071, 3);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(15, 15);
            this.Btn_Salir.TabIndex = 17;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú Principal";
            // 
            // Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.pnl_Content);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Horarios";
            this.Size = new System.Drawing.Size(1098, 508);
            this.pnl_Content.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnGuardarHorario;
        private FontAwesome.Sharp.IconButton btnEliminarDoctor;
        private FontAwesome.Sharp.IconButton btnActualizarDoctor;
        private FontAwesome.Sharp.IconButton BtnGuardarDoctor;
        private FontAwesome.Sharp.IconButton Btn_LogOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_minisize;
        private FontAwesome.Sharp.IconButton Btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gbGestionHiorario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbEspecialidad;
        private System.Windows.Forms.TextBox tbNombreDoctor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.DataGridView dgvDoctores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDiaSemana;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DataGridView dataGridViewHorarios;
        private System.Windows.Forms.ComboBox cmbDoctores;
    }
}
