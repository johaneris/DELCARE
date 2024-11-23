namespace UAM_INVESTIGATION.FormEstudiantes
{
    partial class PrincipalEst
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minisize = new FontAwesome.Sharp.IconButton();
            this.Btn_Salir = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btno_Horarios = new FontAwesome.Sharp.IconButton();
            this.Btn_HistorialCitas = new FontAwesome.Sharp.IconButton();
            this.Btn_AgendarCitas = new FontAwesome.Sharp.IconButton();
            this.Btn_Perfil = new FontAwesome.Sharp.IconButton();
            this.Btn_LogOut = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCif = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1090, 34);
            this.panel1.TabIndex = 1;
            // 
            // btn_minisize
            // 
            this.btn_minisize.BackColor = System.Drawing.Color.Transparent;
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
            this.btn_minisize.Click += new System.EventHandler(this.btn_minisize_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Transparent;
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
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú Principal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.Btno_Horarios);
            this.panel2.Controls.Add(this.Btn_HistorialCitas);
            this.panel2.Controls.Add(this.Btn_AgendarCitas);
            this.panel2.Controls.Add(this.Btn_Perfil);
            this.panel2.Controls.Add(this.Btn_LogOut);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 477);
            this.panel2.TabIndex = 2;
            // 
            // Btno_Horarios
            // 
            this.Btno_Horarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btno_Horarios.FlatAppearance.BorderSize = 0;
            this.Btno_Horarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btno_Horarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btno_Horarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btno_Horarios.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.Btno_Horarios.IconColor = System.Drawing.Color.Gainsboro;
            this.Btno_Horarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btno_Horarios.IconSize = 30;
            this.Btno_Horarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btno_Horarios.Location = new System.Drawing.Point(0, 246);
            this.Btno_Horarios.Name = "Btno_Horarios";
            this.Btno_Horarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btno_Horarios.Size = new System.Drawing.Size(200, 55);
            this.Btno_Horarios.TabIndex = 5;
            this.Btno_Horarios.Text = "Horarios";
            this.Btno_Horarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btno_Horarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btno_Horarios.UseVisualStyleBackColor = true;
            this.Btno_Horarios.Click += new System.EventHandler(this.Btno_Horarios_Click);
            // 
            // Btn_HistorialCitas
            // 
            this.Btn_HistorialCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_HistorialCitas.FlatAppearance.BorderSize = 0;
            this.Btn_HistorialCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_HistorialCitas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_HistorialCitas.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_HistorialCitas.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.Btn_HistorialCitas.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_HistorialCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_HistorialCitas.IconSize = 30;
            this.Btn_HistorialCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_HistorialCitas.Location = new System.Drawing.Point(0, 191);
            this.Btn_HistorialCitas.Name = "Btn_HistorialCitas";
            this.Btn_HistorialCitas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_HistorialCitas.Size = new System.Drawing.Size(200, 55);
            this.Btn_HistorialCitas.TabIndex = 3;
            this.Btn_HistorialCitas.Text = "Historial Citas";
            this.Btn_HistorialCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_HistorialCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_HistorialCitas.UseVisualStyleBackColor = true;
            this.Btn_HistorialCitas.Click += new System.EventHandler(this.Btn_HistorialCitas_Click);
            // 
            // Btn_AgendarCitas
            // 
            this.Btn_AgendarCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_AgendarCitas.FlatAppearance.BorderSize = 0;
            this.Btn_AgendarCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AgendarCitas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AgendarCitas.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_AgendarCitas.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.Btn_AgendarCitas.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_AgendarCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_AgendarCitas.IconSize = 30;
            this.Btn_AgendarCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AgendarCitas.Location = new System.Drawing.Point(0, 136);
            this.Btn_AgendarCitas.Name = "Btn_AgendarCitas";
            this.Btn_AgendarCitas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_AgendarCitas.Size = new System.Drawing.Size(200, 55);
            this.Btn_AgendarCitas.TabIndex = 2;
            this.Btn_AgendarCitas.Text = "Agendar Citas";
            this.Btn_AgendarCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AgendarCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_AgendarCitas.UseVisualStyleBackColor = true;
            this.Btn_AgendarCitas.Click += new System.EventHandler(this.Btn_AgendarCitas_Click);
            // 
            // Btn_Perfil
            // 
            this.Btn_Perfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Perfil.FlatAppearance.BorderSize = 0;
            this.Btn_Perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Perfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Perfil.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Perfil.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Btn_Perfil.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_Perfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Perfil.IconSize = 30;
            this.Btn_Perfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Perfil.Location = new System.Drawing.Point(0, 81);
            this.Btn_Perfil.Name = "Btn_Perfil";
            this.Btn_Perfil.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Perfil.Size = new System.Drawing.Size(200, 55);
            this.Btn_Perfil.TabIndex = 1;
            this.Btn_Perfil.Text = "Perfil";
            this.Btn_Perfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Perfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Perfil.UseVisualStyleBackColor = true;
            this.Btn_Perfil.Click += new System.EventHandler(this.Btn_Perfil_Click);
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
            this.Btn_LogOut.Location = new System.Drawing.Point(0, 441);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_LogOut.Size = new System.Drawing.Size(200, 36);
            this.Btn_LogOut.TabIndex = 4;
            this.Btn_LogOut.Text = "Log out";
            this.Btn_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            this.panel3.Controls.Add(this.lblCif);
            this.panel3.Controls.Add(this.lblCorreo);
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 81);
            this.panel3.TabIndex = 0;
            // 
            // lblCif
            // 
            this.lblCif.AutoSize = true;
            this.lblCif.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCif.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCif.Location = new System.Drawing.Point(47, 56);
            this.lblCif.Name = "lblCif";
            this.lblCif.Size = new System.Drawing.Size(22, 15);
            this.lblCif.TabIndex = 7;
            this.lblCif.Text = "Cif";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCorreo.Location = new System.Drawing.Point(47, 41);
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
            this.lblNombre.Location = new System.Drawing.Point(47, 26);
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
            this.label3.Location = new System.Drawing.Point(47, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estudiante";
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
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 81);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // pnl_Content
            // 
            this.pnl_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.pnl_Content.BackgroundImage = global::UAM_INVESTIGATION.Properties.Resources.youtube_profile_image;
            this.pnl_Content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Content.Location = new System.Drawing.Point(200, 34);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(890, 477);
            this.pnl_Content.TabIndex = 3;
            // 
            // PrincipalEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1090, 511);
            this.Controls.Add(this.pnl_Content);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalEst";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalEst";
            this.Load += new System.EventHandler(this.PrincipalEst_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_minisize;
        private FontAwesome.Sharp.IconButton Btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton Btn_HistorialCitas;
        private FontAwesome.Sharp.IconButton Btn_AgendarCitas;
        private FontAwesome.Sharp.IconButton Btn_Perfil;
        private FontAwesome.Sharp.IconButton Btn_LogOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Label lblCif;
        private FontAwesome.Sharp.IconButton Btno_Horarios;
    }
}