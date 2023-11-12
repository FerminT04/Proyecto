
namespace Clave1_Grupo1
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnArtista = new System.Windows.Forms.Button();
            this.panelVentanas = new System.Windows.Forms.Panel();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnLocales = new System.Windows.Forms.Button();
            this.btnCerrarImg = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 30);
            this.panel1.TabIndex = 4;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnMinimizar.Image = global::Clave1_Grupo1.Properties.Resources.minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(943, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnSalir.Image = global::Clave1_Grupo1.Properties.Resources.cerrar;
            this.btnSalir.Location = new System.Drawing.Point(973, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.panel_menu.Controls.Add(this.btnUsuarios);
            this.panel_menu.Controls.Add(this.btnArtista);
            this.panel_menu.Controls.Add(this.panelVentanas);
            this.panel_menu.Controls.Add(this.btnReservas);
            this.panel_menu.Controls.Add(this.btnLocales);
            this.panel_menu.Controls.Add(this.btnCerrarImg);
            this.panel_menu.Controls.Add(this.btnCerrar);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(200, 480);
            this.panel_menu.TabIndex = 5;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.Location = new System.Drawing.Point(24, 54);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(145, 30);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Usuario";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnArtista
            // 
            this.btnArtista.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnArtista.FlatAppearance.BorderSize = 0;
            this.btnArtista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtista.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtista.Image = ((System.Drawing.Image)(resources.GetObject("btnArtista.Image")));
            this.btnArtista.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArtista.Location = new System.Drawing.Point(24, 230);
            this.btnArtista.Name = "btnArtista";
            this.btnArtista.Size = new System.Drawing.Size(145, 30);
            this.btnArtista.TabIndex = 8;
            this.btnArtista.Text = "Artistas";
            this.btnArtista.UseVisualStyleBackColor = true;
            this.btnArtista.Click += new System.EventHandler(this.btnArtista_Click);
            // 
            // panelVentanas
            // 
            this.panelVentanas.Location = new System.Drawing.Point(202, 20);
            this.panelVentanas.Name = "panelVentanas";
            this.panelVentanas.Size = new System.Drawing.Size(800, 450);
            this.panelVentanas.TabIndex = 4;
            // 
            // btnReservas
            // 
            this.btnReservas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.Image = ((System.Drawing.Image)(resources.GetObject("btnReservas.Image")));
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReservas.Location = new System.Drawing.Point(24, 170);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(145, 30);
            this.btnReservas.TabIndex = 6;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnLocales
            // 
            this.btnLocales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnLocales.FlatAppearance.BorderSize = 0;
            this.btnLocales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocales.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocales.Image = ((System.Drawing.Image)(resources.GetObject("btnLocales.Image")));
            this.btnLocales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocales.Location = new System.Drawing.Point(24, 108);
            this.btnLocales.Name = "btnLocales";
            this.btnLocales.Size = new System.Drawing.Size(145, 30);
            this.btnLocales.TabIndex = 5;
            this.btnLocales.Text = "Locales";
            this.btnLocales.UseVisualStyleBackColor = true;
            this.btnLocales.Click += new System.EventHandler(this.btnLocales_Click);
            // 
            // btnCerrarImg
            // 
            this.btnCerrarImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarImg.FlatAppearance.BorderSize = 0;
            this.btnCerrarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarImg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarImg.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarImg.Image")));
            this.btnCerrarImg.Location = new System.Drawing.Point(65, 350);
            this.btnCerrarImg.Name = "btnCerrarImg";
            this.btnCerrarImg.Size = new System.Drawing.Size(58, 52);
            this.btnCerrarImg.TabIndex = 4;
            this.btnCerrarImg.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(24, 408);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(145, 30);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Location = new System.Drawing.Point(201, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 6;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnArtista;
        private System.Windows.Forms.Panel panelVentanas;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnLocales;
        private System.Windows.Forms.Button btnCerrarImg;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel2;
    }
}