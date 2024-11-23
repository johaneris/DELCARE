namespace UAM_INVESTIGATION.FormAdmin
{
    partial class PrincipalAdmin
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
            this.btnGestionarDoctores = new FontAwesome.Sharp.IconButton();
            this.btnDisponibilidad = new FontAwesome.Sharp.IconButton();
            this.Btn_GestionarUser = new FontAwesome.Sharp.IconButton();
            this.Btn_Perfil = new FontAwesome.Sharp.IconButton();
            this.Btn_LogOut = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pnl_Contenido = new System.Windows.Forms.Panel();
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
            this.panel1.Size = new System.Drawing.Size(1190, 34);
            this.panel1.TabIndex = 0;
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
            this.btn_minisize.Location = new System.Drawing.Point(1151, 3);
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
            this.Btn_Salir.Location = new System.Drawing.Point(1172, 3);
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
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú Principal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.btnGestionarDoctores);
            this.panel2.Controls.Add(this.btnDisponibilidad);
            this.panel2.Controls.Add(this.Btn_GestionarUser);
            this.panel2.Controls.Add(this.Btn_Perfil);
            this.panel2.Controls.Add(this.Btn_LogOut);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 427);
            this.panel2.TabIndex = 1;
            // 
            // btnGestionarDoctores
            // 
            this.btnGestionarDoctores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarDoctores.FlatAppearance.BorderSize = 0;
            this.btnGestionarDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarDoctores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarDoctores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionarDoctores.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btnGestionarDoctores.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGestionarDoctores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionarDoctores.IconSize = 30;
            this.btnGestionarDoctores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarDoctores.Location = new System.Drawing.Point(0, 240);
            this.btnGestionarDoctores.Name = "btnGestionarDoctores";
            this.btnGestionarDoctores.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGestionarDoctores.Size = new System.Drawing.Size(200, 58);
            this.btnGestionarDoctores.TabIndex = 6;
            this.btnGestionarDoctores.Text = "Gestionar Doctores";
            this.btnGestionarDoctores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarDoctores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionarDoctores.UseVisualStyleBackColor = true;
            this.btnGestionarDoctores.Click += new System.EventHandler(this.btnGestionarDoctores_Click);
            // 
            // btnDisponibilidad
            // 
            this.btnDisponibilidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDisponibilidad.FlatAppearance.BorderSize = 0;
            this.btnDisponibilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponibilidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponibilidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDisponibilidad.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnDisponibilidad.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDisponibilidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDisponibilidad.IconSize = 30;
            this.btnDisponibilidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisponibilidad.Location = new System.Drawing.Point(0, 185);
            this.btnDisponibilidad.Name = "btnDisponibilidad";
            this.btnDisponibilidad.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDisponibilidad.Size = new System.Drawing.Size(200, 55);
            this.btnDisponibilidad.TabIndex = 5;
            this.btnDisponibilidad.Text = "Gestionar Horarios";
            this.btnDisponibilidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisponibilidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisponibilidad.UseVisualStyleBackColor = true;
            this.btnDisponibilidad.Click += new System.EventHandler(this.btnDisponibilidad_Click);
            // 
            // Btn_GestionarUser
            // 
            this.Btn_GestionarUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_GestionarUser.FlatAppearance.BorderSize = 0;
            this.Btn_GestionarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GestionarUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GestionarUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_GestionarUser.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.Btn_GestionarUser.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_GestionarUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_GestionarUser.IconSize = 30;
            this.Btn_GestionarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_GestionarUser.Location = new System.Drawing.Point(0, 130);
            this.Btn_GestionarUser.Name = "Btn_GestionarUser";
            this.Btn_GestionarUser.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_GestionarUser.Size = new System.Drawing.Size(200, 55);
            this.Btn_GestionarUser.TabIndex = 3;
            this.Btn_GestionarUser.Text = "Monitorear Usuarios";
            this.Btn_GestionarUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_GestionarUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_GestionarUser.UseVisualStyleBackColor = true;
            this.Btn_GestionarUser.Click += new System.EventHandler(this.btn_GestionarUsuarios);
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
            this.Btn_Perfil.Location = new System.Drawing.Point(0, 75);
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
            this.Btn_LogOut.Location = new System.Drawing.Point(0, 391);
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
            // pnl_Contenido
            // 
            this.pnl_Contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.pnl_Contenido.BackgroundImage = global::UAM_INVESTIGATION.Properties.Resources.youtube_profile_image;
            this.pnl_Contenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_Contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Contenido.Location = new System.Drawing.Point(200, 34);
            this.pnl_Contenido.Name = "pnl_Contenido";
            this.pnl_Contenido.Size = new System.Drawing.Size(990, 427);
            this.pnl_Contenido.TabIndex = 2;
            // 
            // PrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1190, 461);
            this.Controls.Add(this.pnl_Contenido);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalAdmin";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalAdmin";
            this.Load += new System.EventHandler(this.PrincipalAdmin_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton Btn_Salir;
        private FontAwesome.Sharp.IconButton btn_minisize;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton Btn_Perfil;
        private FontAwesome.Sharp.IconButton Btn_LogOut;
        private FontAwesome.Sharp.IconButton Btn_GestionarUser;
        private System.Windows.Forms.Panel pnl_Contenido;
        private FontAwesome.Sharp.IconButton btnDisponibilidad;
        private FontAwesome.Sharp.IconButton btnGestionarDoctores;
    }
}