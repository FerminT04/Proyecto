
namespace Clave1_Grupo1
{
    partial class FormReserva
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
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.cbArtista = new System.Windows.Forms.ComboBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.btnAgregarR = new System.Windows.Forms.Button();
            this.paneldiseño1 = new System.Windows.Forms.Panel();
            this.btnEliminarR = new System.Windows.Forms.Button();
            this.btnActualizarR = new System.Windows.Forms.Button();
            this.txtId_reservas = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.btnMostrarR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.panel1.SuspendLayout();
            this.paneldiseño1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReserva
            // 
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Location = new System.Drawing.Point(0, 0);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.Size = new System.Drawing.Size(581, 352);
            this.dgvReserva.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.txtId_reservas);
            this.panel1.Controls.Add(this.txtCosto);
            this.panel1.Controls.Add(this.cbUsuario);
            this.panel1.Controls.Add(this.cbArtista);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.cbLocal);
            this.panel1.Controls.Add(this.btnAgregarR);
            this.panel1.Controls.Add(this.txtCapacidad);
            this.panel1.Location = new System.Drawing.Point(580, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 450);
            this.panel1.TabIndex = 8;
            // 
            // txtCosto
            // 
            this.txtCosto.ForeColor = System.Drawing.Color.DimGray;
            this.txtCosto.Location = new System.Drawing.Point(29, 279);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(169, 20);
            this.txtCosto.TabIndex = 86;
            this.txtCosto.Text = "Costo total";
            this.txtCosto.Enter += new System.EventHandler(this.txtCosto_enter);
            this.txtCosto.Leave += new System.EventHandler(this.txtCosto_leave);
            // 
            // cbUsuario
            // 
            this.cbUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(29, 322);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(169, 21);
            this.cbUsuario.TabIndex = 85;
            this.cbUsuario.Text = "Usuario";
            this.cbUsuario.Enter += new System.EventHandler(this.cbUsuario_enter);
            this.cbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbUsuario_keypress);
            this.cbUsuario.Leave += new System.EventHandler(this.cbUsuario_leave);
            // 
            // cbArtista
            // 
            this.cbArtista.ForeColor = System.Drawing.Color.DimGray;
            this.cbArtista.FormattingEnabled = true;
            this.cbArtista.Location = new System.Drawing.Point(29, 194);
            this.cbArtista.Name = "cbArtista";
            this.cbArtista.Size = new System.Drawing.Size(169, 21);
            this.cbArtista.TabIndex = 84;
            this.cbArtista.Text = "Artista";
            this.cbArtista.Enter += new System.EventHandler(this.cbArtista_enter);
            this.cbArtista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbArtista_keypress);
            this.cbArtista.Leave += new System.EventHandler(this.cbArtista_leave);
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFin.Location = new System.Drawing.Point(29, 149);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(169, 20);
            this.dtpFin.TabIndex = 83;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInicio.Location = new System.Drawing.Point(29, 101);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(169, 20);
            this.dtpInicio.TabIndex = 82;
            this.dtpInicio.Tag = "";
            // 
            // cbLocal
            // 
            this.cbLocal.ForeColor = System.Drawing.Color.DimGray;
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Location = new System.Drawing.Point(29, 57);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(169, 21);
            this.cbLocal.TabIndex = 81;
            this.cbLocal.Text = "Local";
            this.cbLocal.Enter += new System.EventHandler(this.cbLocal_enter);
            this.cbLocal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbLocal_keypress);
            this.cbLocal.Leave += new System.EventHandler(this.cbLocal_leave);
            // 
            // btnAgregarR
            // 
            this.btnAgregarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarR.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnAgregarR.FlatAppearance.BorderSize = 0;
            this.btnAgregarR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnAgregarR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnAgregarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarR.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarR.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarR.Location = new System.Drawing.Point(0, 375);
            this.btnAgregarR.Name = "btnAgregarR";
            this.btnAgregarR.Size = new System.Drawing.Size(220, 50);
            this.btnAgregarR.TabIndex = 80;
            this.btnAgregarR.Text = "AGREGAR RESERVA";
            this.btnAgregarR.UseVisualStyleBackColor = false;
            // 
            // paneldiseño1
            // 
            this.paneldiseño1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.paneldiseño1.Controls.Add(this.btnMostrarR);
            this.paneldiseño1.Controls.Add(this.btnEliminarR);
            this.paneldiseño1.Controls.Add(this.btnActualizarR);
            this.paneldiseño1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneldiseño1.Location = new System.Drawing.Point(0, 350);
            this.paneldiseño1.Name = "paneldiseño1";
            this.paneldiseño1.Size = new System.Drawing.Size(800, 100);
            this.paneldiseño1.TabIndex = 9;
            // 
            // btnEliminarR
            // 
            this.btnEliminarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnEliminarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarR.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnEliminarR.FlatAppearance.BorderSize = 0;
            this.btnEliminarR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarR.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarR.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarR.Location = new System.Drawing.Point(0, 50);
            this.btnEliminarR.Name = "btnEliminarR";
            this.btnEliminarR.Size = new System.Drawing.Size(322, 50);
            this.btnEliminarR.TabIndex = 79;
            this.btnEliminarR.Text = "ELIMINAR RESERVA";
            this.btnEliminarR.UseVisualStyleBackColor = false;
            // 
            // btnActualizarR
            // 
            this.btnActualizarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnActualizarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarR.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnActualizarR.FlatAppearance.BorderSize = 0;
            this.btnActualizarR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnActualizarR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnActualizarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarR.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarR.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarR.Location = new System.Drawing.Point(0, 0);
            this.btnActualizarR.Name = "btnActualizarR";
            this.btnActualizarR.Size = new System.Drawing.Size(322, 50);
            this.btnActualizarR.TabIndex = 78;
            this.btnActualizarR.Text = "ACTUALIZAR RESERVA";
            this.btnActualizarR.UseVisualStyleBackColor = false;
            // 
            // txtId_reservas
            // 
            this.txtId_reservas.ForeColor = System.Drawing.Color.DimGray;
            this.txtId_reservas.Location = new System.Drawing.Point(29, 21);
            this.txtId_reservas.Name = "txtId_reservas";
            this.txtId_reservas.ReadOnly = true;
            this.txtId_reservas.Size = new System.Drawing.Size(169, 20);
            this.txtId_reservas.TabIndex = 87;
            this.txtId_reservas.Text = "Id";
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.ForeColor = System.Drawing.Color.DimGray;
            this.txtCapacidad.Location = new System.Drawing.Point(29, 237);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(169, 20);
            this.txtCapacidad.TabIndex = 4;
            this.txtCapacidad.Text = "Capacidad Maxima";
            this.txtCapacidad.Enter += new System.EventHandler(this.txtCapacidad_enter);
            this.txtCapacidad.Leave += new System.EventHandler(this.txtCapacidad_leave);
            // 
            // btnMostrarR
            // 
            this.btnMostrarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnMostrarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarR.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnMostrarR.FlatAppearance.BorderSize = 0;
            this.btnMostrarR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnMostrarR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnMostrarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarR.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarR.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMostrarR.Location = new System.Drawing.Point(351, 25);
            this.btnMostrarR.Name = "btnMostrarR";
            this.btnMostrarR.Size = new System.Drawing.Size(223, 50);
            this.btnMostrarR.TabIndex = 80;
            this.btnMostrarR.Text = "MOSTRAR RESERVAS";
            this.btnMostrarR.UseVisualStyleBackColor = false;
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReserva);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneldiseño1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReserva";
            this.Opacity = 0.9D;
            this.Text = "FormReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paneldiseño1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.ComboBox cbArtista;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.Button btnAgregarR;
        private System.Windows.Forms.Panel paneldiseño1;
        private System.Windows.Forms.Button btnEliminarR;
        private System.Windows.Forms.Button btnActualizarR;
        private System.Windows.Forms.TextBox txtId_reservas;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Button btnMostrarR;
    }
}