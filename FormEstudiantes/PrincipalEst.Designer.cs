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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Btn_TrabajosPer = new FontAwesome.Sharp.IconButton();
            this.Btn_NovInvest = new FontAwesome.Sharp.IconButton();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1453, 42);
            this.panel1.TabIndex = 1;
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
            this.btn_minisize.Location = new System.Drawing.Point(1400, 4);
            this.btn_minisize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minisize.Name = "btn_minisize";
            this.btn_minisize.Size = new System.Drawing.Size(20, 18);
            this.btn_minisize.TabIndex = 18;
            this.btn_minisize.TabStop = false;
            this.btn_minisize.UseVisualStyleBackColor = false;
            this.btn_minisize.Click += new System.EventHandler(this.btn_minisize_Click);
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
            this.Btn_Salir.Location = new System.Drawing.Point(1428, 4);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(20, 18);
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
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú Principal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.Btn_TrabajosPer);
            this.panel2.Controls.Add(this.Btn_NovInvest);
            this.panel2.Controls.Add(this.Btn_Perfil);
            this.panel2.Controls.Add(this.Btn_LogOut);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 587);
            this.panel2.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 322);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.iconButton1.Size = new System.Drawing.Size(267, 74);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Horarios";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Btn_TrabajosPer
            // 
            this.Btn_TrabajosPer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_TrabajosPer.FlatAppearance.BorderSize = 0;
            this.Btn_TrabajosPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TrabajosPer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TrabajosPer.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_TrabajosPer.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.Btn_TrabajosPer.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_TrabajosPer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_TrabajosPer.IconSize = 30;
            this.Btn_TrabajosPer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_TrabajosPer.Location = new System.Drawing.Point(0, 248);
            this.Btn_TrabajosPer.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_TrabajosPer.Name = "Btn_TrabajosPer";
            this.Btn_TrabajosPer.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Btn_TrabajosPer.Size = new System.Drawing.Size(267, 74);
            this.Btn_TrabajosPer.TabIndex = 3;
            this.Btn_TrabajosPer.Text = "Consultar Citas";
            this.Btn_TrabajosPer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_TrabajosPer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_TrabajosPer.UseVisualStyleBackColor = true;
            // 
            // Btn_NovInvest
            // 
            this.Btn_NovInvest.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_NovInvest.FlatAppearance.BorderSize = 0;
            this.Btn_NovInvest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NovInvest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NovInvest.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_NovInvest.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.Btn_NovInvest.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_NovInvest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_NovInvest.IconSize = 30;
            this.Btn_NovInvest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_NovInvest.Location = new System.Drawing.Point(0, 174);
            this.Btn_NovInvest.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_NovInvest.Name = "Btn_NovInvest";
            this.Btn_NovInvest.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Btn_NovInvest.Size = new System.Drawing.Size(267, 74);
            this.Btn_NovInvest.TabIndex = 2;
            this.Btn_NovInvest.Text = "Agendar Citas";
            this.Btn_NovInvest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_NovInvest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_NovInvest.UseVisualStyleBackColor = true;
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
            this.Btn_Perfil.Location = new System.Drawing.Point(0, 100);
            this.Btn_Perfil.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Perfil.Name = "Btn_Perfil";
            this.Btn_Perfil.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Btn_Perfil.Size = new System.Drawing.Size(267, 74);
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
            this.Btn_LogOut.Location = new System.Drawing.Point(0, 543);
            this.Btn_LogOut.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Btn_LogOut.Size = new System.Drawing.Size(267, 44);
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
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 100);
            this.panel3.TabIndex = 0;
            // 
            // lblCif
            // 
            this.lblCif.AutoSize = true;
            this.lblCif.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCif.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCif.Location = new System.Drawing.Point(63, 69);
            this.lblCif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCif.Name = "lblCif";
            this.lblCif.Size = new System.Drawing.Size(27, 17);
            this.lblCif.TabIndex = 7;
            this.lblCif.Text = "Cif";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCorreo.Location = new System.Drawing.Point(63, 50);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 17);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(63, 32);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(46, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(63, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
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
            this.iconPictureBox1.IconSize = 55;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(55, 100);
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
            this.pnl_Content.Location = new System.Drawing.Point(267, 42);
            this.pnl_Content.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(1186, 587);
            this.pnl_Content.TabIndex = 3;
            // 
            // PrincipalEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1453, 629);
            this.Controls.Add(this.pnl_Content);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private FontAwesome.Sharp.IconButton Btn_TrabajosPer;
        private FontAwesome.Sharp.IconButton Btn_NovInvest;
        private FontAwesome.Sharp.IconButton Btn_Perfil;
        private FontAwesome.Sharp.IconButton Btn_LogOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Label lblCif;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}