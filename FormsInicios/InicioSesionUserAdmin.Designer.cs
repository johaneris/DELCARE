namespace UAM_INVESTIGATION.Forms
{
    partial class InicioSesionUserAdmin
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
            this.cb_MostrarContrasenia = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_regresar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lnk_Registro = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.btn_InicioSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_minisize = new FontAwesome.Sharp.IconButton();
            this.Btn_Salir = new FontAwesome.Sharp.IconButton();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_MostrarContrasenia
            // 
            this.cb_MostrarContrasenia.AutoSize = true;
            this.cb_MostrarContrasenia.Location = new System.Drawing.Point(691, 146);
            this.cb_MostrarContrasenia.Name = "cb_MostrarContrasenia";
            this.cb_MostrarContrasenia.Size = new System.Drawing.Size(15, 14);
            this.cb_MostrarContrasenia.TabIndex = 11;
            this.cb_MostrarContrasenia.TabStop = false;
            this.cb_MostrarContrasenia.UseVisualStyleBackColor = true;
            this.cb_MostrarContrasenia.CheckedChanged += new System.EventHandler(this.cb_MostrarContrasenia_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.btn_regresar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Lnk_Registro);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 12;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_regresar.IconColor = System.Drawing.Color.Black;
            this.btn_regresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_regresar.IconSize = 20;
            this.btn_regresar.Location = new System.Drawing.Point(3, 3);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(15, 15);
            this.btn_regresar.TabIndex = 24;
            this.btn_regresar.TabStop = false;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(60, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 33);
            this.label2.TabIndex = 23;
            this.label2.Text = "ADMINS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "¿No tienes una cuenta?";
            // 
            // Lnk_Registro
            // 
            this.Lnk_Registro.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Lnk_Registro.AutoSize = true;
            this.Lnk_Registro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnk_Registro.ForeColor = System.Drawing.Color.White;
            this.Lnk_Registro.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.Lnk_Registro.Location = new System.Drawing.Point(156, 282);
            this.Lnk_Registro.Name = "Lnk_Registro";
            this.Lnk_Registro.Size = new System.Drawing.Size(63, 16);
            this.Lnk_Registro.TabIndex = 4;
            this.Lnk_Registro.TabStop = true;
            this.Lnk_Registro.Text = "Regístrarse";
            this.Lnk_Registro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_Registro_LinkClicked_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UAM_INVESTIGATION.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Correo
            // 
            this.txt_Correo.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Correo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correo.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Correo.Location = new System.Drawing.Point(309, 91);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(401, 27);
            this.txt_Correo.TabIndex = 1;
            this.txt_Correo.Text = "CORREO";
            this.txt_Correo.Enter += new System.EventHandler(this.txt_Correo_Enter_1);
            this.txt_Correo.Leave += new System.EventHandler(this.txt_Correo_Leave_1);
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Contrasenia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contrasenia.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Contrasenia.Location = new System.Drawing.Point(309, 139);
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.Size = new System.Drawing.Size(401, 27);
            this.txt_Contrasenia.TabIndex = 2;
            this.txt_Contrasenia.Text = "CONTRASEÑA";
            this.txt_Contrasenia.Enter += new System.EventHandler(this.txt_Contrasenia_Enter_1);
            this.txt_Contrasenia.Leave += new System.EventHandler(this.txt_Contrasenia_Leave_1);
            // 
            // btn_InicioSesion
            // 
            this.btn_InicioSesion.BackColor = System.Drawing.Color.LightBlue;
            this.btn_InicioSesion.FlatAppearance.BorderSize = 0;
            this.btn_InicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_InicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_InicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InicioSesion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InicioSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_InicioSesion.Location = new System.Drawing.Point(309, 240);
            this.btn_InicioSesion.Name = "btn_InicioSesion";
            this.btn_InicioSesion.Size = new System.Drawing.Size(409, 40);
            this.btn_InicioSesion.TabIndex = 3;
            this.btn_InicioSesion.Text = "INICIAR SESIÓN";
            this.btn_InicioSesion.UseVisualStyleBackColor = false;
            this.btn_InicioSesion.Click += new System.EventHandler(this.btn_InicioSesion_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "INICIO DE SESIÓN\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_minisize);
            this.panel2.Controls.Add(this.Btn_Salir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 50);
            this.panel2.TabIndex = 22;
            // 
            // btn_minisize
            // 
            this.btn_minisize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_minisize.FlatAppearance.BorderSize = 0;
            this.btn_minisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minisize.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btn_minisize.IconChar = FontAwesome.Sharp.IconChar.Compress;
            this.btn_minisize.IconColor = System.Drawing.Color.Black;
            this.btn_minisize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minisize.IconSize = 20;
            this.btn_minisize.Location = new System.Drawing.Point(491, 3);
            this.btn_minisize.Name = "btn_minisize";
            this.btn_minisize.Size = new System.Drawing.Size(15, 15);
            this.btn_minisize.TabIndex = 17;
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
            this.Btn_Salir.IconColor = System.Drawing.Color.Black;
            this.Btn_Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Salir.IconSize = 15;
            this.Btn_Salir.Location = new System.Drawing.Point(512, 3);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(15, 15);
            this.Btn_Salir.TabIndex = 16;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMessage.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.DimGray;
            this.lblErrorMessage.Location = new System.Drawing.Point(340, 191);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(102, 19);
            this.lblErrorMessage.TabIndex = 23;
            this.lblErrorMessage.Text = "Error Message";
            this.lblErrorMessage.Visible = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 26;
            this.iconPictureBox1.Location = new System.Drawing.Point(314, 188);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(29, 26);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 24;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Visible = false;
            // 
            // InicioSesionUserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.cb_MostrarContrasenia);
            this.Controls.Add(this.btn_InicioSesion);
            this.Controls.Add(this.txt_Contrasenia);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesionUserAdmin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InicioSesionUserAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cb_MostrarContrasenia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel Lnk_Registro;
        private FontAwesome.Sharp.IconButton btn_minisize;
        private FontAwesome.Sharp.IconButton Btn_Salir;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Contrasenia;
        private System.Windows.Forms.Button btn_InicioSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_regresar;
        private System.Windows.Forms.Label lblErrorMessage;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}