﻿namespace UAM_INVESTIGATION
{
    partial class pantalla_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.Btn_AdminRegis = new FontAwesome.Sharp.IconButton();
            this.Btn_UserRegis = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.img_Home = new System.Windows.Forms.PictureBox();
            this.lbl_form_tittle = new System.Windows.Forms.Label();
            this.Panel_Tittle = new System.Windows.Forms.Panel();
            this.btn_minisize = new FontAwesome.Sharp.IconButton();
            this.Btn_Salir = new FontAwesome.Sharp.IconButton();
            this.icon_form_home = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Home)).BeginInit();
            this.Panel_Tittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_form_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.PanelMenu.Controls.Add(this.Btn_AdminRegis);
            this.PanelMenu.Controls.Add(this.Btn_UserRegis);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 54);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(291, 623);
            this.PanelMenu.TabIndex = 3;
            // 
            // Btn_AdminRegis
            // 
            this.Btn_AdminRegis.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_AdminRegis.FlatAppearance.BorderSize = 0;
            this.Btn_AdminRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AdminRegis.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AdminRegis.ForeColor = System.Drawing.Color.Black;
            this.Btn_AdminRegis.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.Btn_AdminRegis.IconColor = System.Drawing.Color.Black;
            this.Btn_AdminRegis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_AdminRegis.IconSize = 30;
            this.Btn_AdminRegis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AdminRegis.Location = new System.Drawing.Point(0, 367);
            this.Btn_AdminRegis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_AdminRegis.Name = "Btn_AdminRegis";
            this.Btn_AdminRegis.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Btn_AdminRegis.Size = new System.Drawing.Size(291, 96);
            this.Btn_AdminRegis.TabIndex = 2;
            this.Btn_AdminRegis.Text = "ADMIN";
            this.Btn_AdminRegis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AdminRegis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_AdminRegis.UseVisualStyleBackColor = true;
            this.Btn_AdminRegis.Click += new System.EventHandler(this.Btn_AdminRegis_Click_1);
            // 
            // Btn_UserRegis
            // 
            this.Btn_UserRegis.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_UserRegis.FlatAppearance.BorderSize = 0;
            this.Btn_UserRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UserRegis.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UserRegis.ForeColor = System.Drawing.Color.Black;
            this.Btn_UserRegis.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Btn_UserRegis.IconColor = System.Drawing.Color.Black;
            this.Btn_UserRegis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_UserRegis.IconSize = 30;
            this.Btn_UserRegis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_UserRegis.Location = new System.Drawing.Point(0, 271);
            this.Btn_UserRegis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_UserRegis.Name = "Btn_UserRegis";
            this.Btn_UserRegis.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.Btn_UserRegis.Size = new System.Drawing.Size(291, 96);
            this.Btn_UserRegis.TabIndex = 1;
            this.Btn_UserRegis.Text = "PACIENTE";
            this.Btn_UserRegis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_UserRegis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_UserRegis.UseVisualStyleBackColor = true;
            this.Btn_UserRegis.Click += new System.EventHandler(this.Btn_UserRegis_Click_1);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.img_Home);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(291, 271);
            this.PanelLogo.TabIndex = 0;
            // 
            // img_Home
            // 
            this.img_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.img_Home.Image = global::UAM_INVESTIGATION.Properties.Resources.youtube_profile_image;
            this.img_Home.Location = new System.Drawing.Point(0, 0);
            this.img_Home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.img_Home.Name = "img_Home";
            this.img_Home.Size = new System.Drawing.Size(293, 271);
            this.img_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Home.TabIndex = 0;
            this.img_Home.TabStop = false;
            // 
            // lbl_form_tittle
            // 
            this.lbl_form_tittle.AutoSize = true;
            this.lbl_form_tittle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form_tittle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_form_tittle.Location = new System.Drawing.Point(55, 16);
            this.lbl_form_tittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_form_tittle.Name = "lbl_form_tittle";
            this.lbl_form_tittle.Size = new System.Drawing.Size(65, 23);
            this.lbl_form_tittle.TabIndex = 0;
            this.lbl_form_tittle.Text = "Home";
            // 
            // Panel_Tittle
            // 
            this.Panel_Tittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(126)))), ((int)(((byte)(133)))));
            this.Panel_Tittle.Controls.Add(this.btn_minisize);
            this.Panel_Tittle.Controls.Add(this.lbl_form_tittle);
            this.Panel_Tittle.Controls.Add(this.Btn_Salir);
            this.Panel_Tittle.Controls.Add(this.icon_form_home);
            this.Panel_Tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Tittle.Location = new System.Drawing.Point(0, 0);
            this.Panel_Tittle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_Tittle.Name = "Panel_Tittle";
            this.Panel_Tittle.Size = new System.Drawing.Size(1228, 54);
            this.Panel_Tittle.TabIndex = 20;
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
            this.btn_minisize.Location = new System.Drawing.Point(1175, 4);
            this.btn_minisize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_minisize.Name = "btn_minisize";
            this.btn_minisize.Size = new System.Drawing.Size(20, 18);
            this.btn_minisize.TabIndex = 0;
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
            this.Btn_Salir.Location = new System.Drawing.Point(1203, 4);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(20, 18);
            this.Btn_Salir.TabIndex = 0;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // icon_form_home
            // 
            this.icon_form_home.BackColor = System.Drawing.Color.Transparent;
            this.icon_form_home.ForeColor = System.Drawing.Color.Gainsboro;
            this.icon_form_home.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.icon_form_home.IconColor = System.Drawing.Color.Gainsboro;
            this.icon_form_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_form_home.IconSize = 39;
            this.icon_form_home.Location = new System.Drawing.Point(11, 7);
            this.icon_form_home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.icon_form_home.Name = "icon_form_home";
            this.icon_form_home.Size = new System.Drawing.Size(43, 39);
            this.icon_form_home.TabIndex = 0;
            this.icon_form_home.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::UAM_INVESTIGATION.Properties.Resources.pngtree_female_dentist_curing_boy_in_chair_picture_image_8709139;
            this.pictureBox1.Location = new System.Drawing.Point(291, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(937, 623);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1228, 677);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.Panel_Tittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "pantalla_Principal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Home)).EndInit();
            this.Panel_Tittle.ResumeLayout(false);
            this.Panel_Tittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_form_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton Btn_UserRegis;
        private System.Windows.Forms.PictureBox img_Home;
        private FontAwesome.Sharp.IconButton Btn_AdminRegis;
        private FontAwesome.Sharp.IconButton btn_minisize;
        private FontAwesome.Sharp.IconButton Btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox icon_form_home;
        private System.Windows.Forms.Label lbl_form_tittle;
        private System.Windows.Forms.Panel Panel_Tittle;
    }
}

