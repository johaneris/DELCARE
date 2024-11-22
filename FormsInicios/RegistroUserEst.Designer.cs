namespace UAM_INVESTIGATION.Forms
{
    partial class RegistroUserEst
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
            this.btn_regresar = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lnk_Sesion = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Salir = new FontAwesome.Sharp.IconButton();
            this.btn_minisize = new FontAwesome.Sharp.IconButton();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Registrarse = new System.Windows.Forms.Button();
            this.show_Password = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.btn_regresar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Lnk_Sesion);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 519);
            this.panel1.TabIndex = 21;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_regresar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_regresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_regresar.IconSize = 20;
            this.btn_regresar.Location = new System.Drawing.Point(4, 4);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(20, 18);
            this.btn_regresar.TabIndex = 25;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(74, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 46);
            this.label8.TabIndex = 24;
            this.label8.Text = "PACIENTE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 487);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "¿Ya tienes una cuenta?";
            // 
            // Lnk_Sesion
            // 
            this.Lnk_Sesion.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Lnk_Sesion.AutoSize = true;
            this.Lnk_Sesion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnk_Sesion.ForeColor = System.Drawing.Color.Black;
            this.Lnk_Sesion.LinkColor = System.Drawing.Color.Black;
            this.Lnk_Sesion.Location = new System.Drawing.Point(208, 487);
            this.Lnk_Sesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lnk_Sesion.Name = "Lnk_Sesion";
            this.Lnk_Sesion.Size = new System.Drawing.Size(92, 19);
            this.Lnk_Sesion.TabIndex = 7;
            this.Lnk_Sesion.TabStop = true;
            this.Lnk_Sesion.Text = "Inicia Sesión";
            this.Lnk_Sesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_Sesion_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UAM_INVESTIGATION.Properties.Resources.DentalCare;
            this.pictureBox1.Location = new System.Drawing.Point(0, 111);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Btn_Salir);
            this.panel2.Controls.Add(this.btn_minisize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(333, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 62);
            this.panel2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(179, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "REGISTRO USUARIO";
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
            this.Btn_Salir.Location = new System.Drawing.Point(683, 4);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(20, 18);
            this.Btn_Salir.TabIndex = 14;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // btn_minisize
            // 
            this.btn_minisize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_minisize.FlatAppearance.BorderSize = 0;
            this.btn_minisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minisize.IconChar = FontAwesome.Sharp.IconChar.Compress;
            this.btn_minisize.IconColor = System.Drawing.Color.Black;
            this.btn_minisize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minisize.IconSize = 20;
            this.btn_minisize.Location = new System.Drawing.Point(655, 4);
            this.btn_minisize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minisize.Name = "btn_minisize";
            this.btn_minisize.Size = new System.Drawing.Size(20, 18);
            this.btn_minisize.TabIndex = 15;
            this.btn_minisize.TabStop = false;
            this.btn_minisize.UseVisualStyleBackColor = false;
            this.btn_minisize.Click += new System.EventHandler(this.btn_minisize_Click);
            // 
            // txt_Correo
            // 
            this.txt_Correo.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correo.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Correo.Location = new System.Drawing.Point(401, 237);
            this.txt_Correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(535, 25);
            this.txt_Correo.TabIndex = 1;
            this.txt_Correo.Text = "CORREO";
            this.txt_Correo.Enter += new System.EventHandler(this.txt_Correo_Enter);
            this.txt_Correo.Leave += new System.EventHandler(this.txt_Correo_Leave);
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Contrasenia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contrasenia.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Contrasenia.Location = new System.Drawing.Point(401, 300);
            this.txt_Contrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.Size = new System.Drawing.Size(535, 25);
            this.txt_Contrasenia.TabIndex = 3;
            this.txt_Contrasenia.Text = "CONTRASEÑA";
            this.txt_Contrasenia.Enter += new System.EventHandler(this.txt_Contrasenia_Enter);
            this.txt_Contrasenia.Leave += new System.EventHandler(this.txt_Contrasenia_Leave);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Nombre.Location = new System.Drawing.Point(401, 178);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(535, 25);
            this.txt_Nombre.TabIndex = 4;
            this.txt_Nombre.Text = "NOMBRE COMPLETO";
            this.txt_Nombre.Enter += new System.EventHandler(this.txt_Nombre_Enter);
            this.txt_Nombre.Leave += new System.EventHandler(this.txt_Nombre_Leave);
            // 
            // btn_Registrarse
            // 
            this.btn_Registrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(179)))), ((int)(((byte)(190)))));
            this.btn_Registrarse.FlatAppearance.BorderSize = 0;
            this.btn_Registrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Registrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrarse.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrarse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Registrarse.Location = new System.Drawing.Point(401, 375);
            this.btn_Registrarse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Registrarse.Name = "btn_Registrarse";
            this.btn_Registrarse.Size = new System.Drawing.Size(545, 49);
            this.btn_Registrarse.TabIndex = 6;
            this.btn_Registrarse.Text = "REGISTRARSE";
            this.btn_Registrarse.UseVisualStyleBackColor = false;
            this.btn_Registrarse.Click += new System.EventHandler(this.btn_Registrarse_Click_1);
            // 
            // show_Password
            // 
            this.show_Password.AutoSize = true;
            this.show_Password.BackColor = System.Drawing.Color.Transparent;
            this.show_Password.Location = new System.Drawing.Point(973, 307);
            this.show_Password.Margin = new System.Windows.Forms.Padding(4);
            this.show_Password.Name = "show_Password";
            this.show_Password.Size = new System.Drawing.Size(18, 17);
            this.show_Password.TabIndex = 30;
            this.show_Password.TabStop = false;
            this.show_Password.UseVisualStyleBackColor = false;
            this.show_Password.CheckedChanged += new System.EventHandler(this.show_Password_CheckedChanged_1);
            // 
            // RegistroUserEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1040, 519);
            this.Controls.Add(this.show_Password);
            this.Controls.Add(this.btn_Registrarse);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Contrasenia);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistroUserEst";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RegistroUserEst_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_regresar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel Lnk_Sesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Btn_Salir;
        private FontAwesome.Sharp.IconButton btn_minisize;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Contrasenia;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btn_Registrarse;
        private System.Windows.Forms.CheckBox show_Password;
    }
}