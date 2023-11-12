
namespace Clave1_Grupo1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalirL = new System.Windows.Forms.Button();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseñas = new System.Windows.Forms.TextBox();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 315);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.btnSalirL);
            this.panel2.Controls.Add(this.btnInicioSesion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtContraseñas);
            this.panel2.Controls.Add(this.txtUsuarios);
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 315);
            this.panel2.TabIndex = 2;
            // 
            // btnSalirL
            // 
            this.btnSalirL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.btnSalirL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.btnSalirL.Image = global::Clave1_Grupo1.Properties.Resources.cerrar;
            this.btnSalirL.Location = new System.Drawing.Point(541, 0);
            this.btnSalirL.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalirL.Name = "btnSalirL";
            this.btnSalirL.Size = new System.Drawing.Size(30, 30);
            this.btnSalirL.TabIndex = 13;
            this.btnSalirL.UseVisualStyleBackColor = false;
            this.btnSalirL.Click += new System.EventHandler(this.btnSalirL_Click);
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnInicioSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicioSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInicioSesion.FlatAppearance.BorderSize = 2;
            this.btnInicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnInicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioSesion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSesion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInicioSesion.Location = new System.Drawing.Point(122, 215);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(331, 36);
            this.btnInicioSesion.TabIndex = 12;
            this.btnInicioSesion.Text = "INICIAR SESION";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnIniciarS);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "LOGIN";
            // 
            // txtContraseñas
            // 
            this.txtContraseñas.BackColor = System.Drawing.Color.White;
            this.txtContraseñas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñas.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseñas.Location = new System.Drawing.Point(148, 152);
            this.txtContraseñas.Name = "txtContraseñas";
            this.txtContraseñas.Size = new System.Drawing.Size(281, 17);
            this.txtContraseñas.TabIndex = 9;
            this.txtContraseñas.Text = "CONTRASEÑA";
            this.txtContraseñas.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseñas.Enter += new System.EventHandler(this.txtContraseña_enter);
            this.txtContraseñas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña);
            this.txtContraseñas.Leave += new System.EventHandler(this.txtContraseña_leave);
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.BackColor = System.Drawing.Color.White;
            this.txtUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarios.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuarios.Location = new System.Drawing.Point(148, 105);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(281, 17);
            this.txtUsuarios.TabIndex = 8;
            this.txtUsuarios.Text = "USUARIO";
            this.txtUsuarios.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuarios.Enter += new System.EventHandler(this.txtUsuario_enter);
            this.txtUsuarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario);
            this.txtUsuarios.Leave += new System.EventHandler(this.txtUsuario_leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 315);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContraseñas;
        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.Button btnSalirL;
    }
}