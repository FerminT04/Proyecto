
namespace Clave1_Grupo1
{
    partial class Locales
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
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarL = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtNombreL = new System.Windows.Forms.TextBox();
            this.paneldiseño1 = new System.Windows.Forms.Panel();
            this.btnEliminarL = new System.Windows.Forms.Button();
            this.btnActualizarL = new System.Windows.Forms.Button();
            this.cbDisponibilidad = new System.Windows.Forms.ComboBox();
            this.txtDistribucion = new System.Windows.Forms.TextBox();
            this.cbIluminacion = new System.Windows.Forms.ComboBox();
            this.cbSonido = new System.Windows.Forms.ComboBox();
            this.cbSillas = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.paneldiseño1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(581, 352);
            this.dgvUsuario.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Controls.Add(this.cbSillas);
            this.panel1.Controls.Add(this.cbSonido);
            this.panel1.Controls.Add(this.cbIluminacion);
            this.panel1.Controls.Add(this.txtDistribucion);
            this.panel1.Controls.Add(this.cbDisponibilidad);
            this.panel1.Controls.Add(this.btnAgregarL);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtCapacidad);
            this.panel1.Controls.Add(this.txtNombreL);
            this.panel1.Location = new System.Drawing.Point(580, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 450);
            this.panel1.TabIndex = 8;
            // 
            // btnAgregarL
            // 
            this.btnAgregarL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarL.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnAgregarL.FlatAppearance.BorderSize = 0;
            this.btnAgregarL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnAgregarL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnAgregarL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarL.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarL.Location = new System.Drawing.Point(0, 400);
            this.btnAgregarL.Name = "btnAgregarL";
            this.btnAgregarL.Size = new System.Drawing.Size(220, 50);
            this.btnAgregarL.TabIndex = 80;
            this.btnAgregarL.Text = "AGREGAR LOCAL";
            this.btnAgregarL.UseVisualStyleBackColor = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDireccion.Location = new System.Drawing.Point(28, 176);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(169, 57);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.Text = "Direccion";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.ForeColor = System.Drawing.Color.DimGray;
            this.txtCapacidad.Location = new System.Drawing.Point(28, 136);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(169, 20);
            this.txtCapacidad.TabIndex = 3;
            this.txtCapacidad.Text = "Capacidad";
            // 
            // txtNombreL
            // 
            this.txtNombreL.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreL.Location = new System.Drawing.Point(28, 12);
            this.txtNombreL.Name = "txtNombreL";
            this.txtNombreL.Size = new System.Drawing.Size(169, 20);
            this.txtNombreL.TabIndex = 1;
            this.txtNombreL.Text = "Nombre";
            // 
            // paneldiseño1
            // 
            this.paneldiseño1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.paneldiseño1.Controls.Add(this.btnEliminarL);
            this.paneldiseño1.Controls.Add(this.btnActualizarL);
            this.paneldiseño1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneldiseño1.Location = new System.Drawing.Point(0, 350);
            this.paneldiseño1.Name = "paneldiseño1";
            this.paneldiseño1.Size = new System.Drawing.Size(800, 100);
            this.paneldiseño1.TabIndex = 9;
            // 
            // btnEliminarL
            // 
            this.btnEliminarL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnEliminarL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarL.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnEliminarL.FlatAppearance.BorderSize = 0;
            this.btnEliminarL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarL.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarL.Location = new System.Drawing.Point(126, 50);
            this.btnEliminarL.Name = "btnEliminarL";
            this.btnEliminarL.Size = new System.Drawing.Size(322, 50);
            this.btnEliminarL.TabIndex = 79;
            this.btnEliminarL.Text = "ELIMINAR LOCALES";
            this.btnEliminarL.UseVisualStyleBackColor = false;
            // 
            // btnActualizarL
            // 
            this.btnActualizarL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnActualizarL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarL.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnActualizarL.FlatAppearance.BorderSize = 0;
            this.btnActualizarL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnActualizarL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnActualizarL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarL.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarL.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarL.Location = new System.Drawing.Point(126, 0);
            this.btnActualizarL.Name = "btnActualizarL";
            this.btnActualizarL.Size = new System.Drawing.Size(322, 50);
            this.btnActualizarL.TabIndex = 78;
            this.btnActualizarL.Text = "ACTUALIZAR LOCALES";
            this.btnActualizarL.UseVisualStyleBackColor = false;
            // 
            // cbDisponibilidad
            // 
            this.cbDisponibilidad.ForeColor = System.Drawing.Color.DimGray;
            this.cbDisponibilidad.FormattingEnabled = true;
            this.cbDisponibilidad.Location = new System.Drawing.Point(28, 53);
            this.cbDisponibilidad.Name = "cbDisponibilidad";
            this.cbDisponibilidad.Size = new System.Drawing.Size(169, 21);
            this.cbDisponibilidad.TabIndex = 81;
            this.cbDisponibilidad.Text = "Disponibilidad";
            // 
            // txtDistribucion
            // 
            this.txtDistribucion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDistribucion.Location = new System.Drawing.Point(28, 253);
            this.txtDistribucion.Name = "txtDistribucion";
            this.txtDistribucion.Size = new System.Drawing.Size(169, 20);
            this.txtDistribucion.TabIndex = 82;
            this.txtDistribucion.Text = "Distribucion fisica";
            // 
            // cbIluminacion
            // 
            this.cbIluminacion.ForeColor = System.Drawing.Color.DimGray;
            this.cbIluminacion.FormattingEnabled = true;
            this.cbIluminacion.Location = new System.Drawing.Point(28, 291);
            this.cbIluminacion.Name = "cbIluminacion";
            this.cbIluminacion.Size = new System.Drawing.Size(169, 21);
            this.cbIluminacion.TabIndex = 83;
            this.cbIluminacion.Text = "Iluminacion";
            // 
            // cbSonido
            // 
            this.cbSonido.ForeColor = System.Drawing.Color.DimGray;
            this.cbSonido.FormattingEnabled = true;
            this.cbSonido.Location = new System.Drawing.Point(28, 334);
            this.cbSonido.Name = "cbSonido";
            this.cbSonido.Size = new System.Drawing.Size(169, 21);
            this.cbSonido.TabIndex = 84;
            this.cbSonido.Text = "Sonido";
            // 
            // cbSillas
            // 
            this.cbSillas.ForeColor = System.Drawing.Color.DimGray;
            this.cbSillas.FormattingEnabled = true;
            this.cbSillas.Location = new System.Drawing.Point(28, 373);
            this.cbSillas.Name = "cbSillas";
            this.cbSillas.Size = new System.Drawing.Size(169, 21);
            this.cbSillas.TabIndex = 85;
            this.cbSillas.Text = "Sillas";
            // 
            // cbTipo
            // 
            this.cbTipo.ForeColor = System.Drawing.Color.DimGray;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(28, 97);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(169, 21);
            this.cbTipo.TabIndex = 86;
            this.cbTipo.Text = "Tipo de local";
            // 
            // Locales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneldiseño1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Locales";
            this.Text = "Locales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paneldiseño1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbSillas;
        private System.Windows.Forms.ComboBox cbSonido;
        private System.Windows.Forms.ComboBox cbIluminacion;
        private System.Windows.Forms.TextBox txtDistribucion;
        private System.Windows.Forms.ComboBox cbDisponibilidad;
        private System.Windows.Forms.Button btnAgregarL;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtNombreL;
        private System.Windows.Forms.Panel paneldiseño1;
        private System.Windows.Forms.Button btnEliminarL;
        private System.Windows.Forms.Button btnActualizarL;
    }
}