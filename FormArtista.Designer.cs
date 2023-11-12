
namespace Clave1_Grupo1
{
    partial class FormArtista
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
            this.dgvArtista = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarA = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.paneldiseño1 = new System.Windows.Forms.Panel();
            this.btnEliminarA = new System.Windows.Forms.Button();
            this.btnActualizarA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtista)).BeginInit();
            this.panel1.SuspendLayout();
            this.paneldiseño1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArtista
            // 
            this.dgvArtista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtista.Location = new System.Drawing.Point(0, 0);
            this.dgvArtista.Name = "dgvArtista";
            this.dgvArtista.Size = new System.Drawing.Size(581, 352);
            this.dgvArtista.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.btnAgregarA);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtNombreA);
            this.panel1.Location = new System.Drawing.Point(580, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 450);
            this.panel1.TabIndex = 8;
            // 
            // btnAgregarA
            // 
            this.btnAgregarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarA.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnAgregarA.FlatAppearance.BorderSize = 0;
            this.btnAgregarA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnAgregarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnAgregarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarA.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarA.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarA.Location = new System.Drawing.Point(0, 350);
            this.btnAgregarA.Name = "btnAgregarA";
            this.btnAgregarA.Size = new System.Drawing.Size(220, 50);
            this.btnAgregarA.TabIndex = 80;
            this.btnAgregarA.Text = "AGREGAR ARTISTA";
            this.btnAgregarA.UseVisualStyleBackColor = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.Location = new System.Drawing.Point(28, 79);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(169, 20);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Text = "Descripcion";
            // 
            // txtNombreA
            // 
            this.txtNombreA.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreA.Location = new System.Drawing.Point(28, 32);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(169, 20);
            this.txtNombreA.TabIndex = 1;
            this.txtNombreA.Text = "Nombre";
            // 
            // paneldiseño1
            // 
            this.paneldiseño1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.paneldiseño1.Controls.Add(this.btnEliminarA);
            this.paneldiseño1.Controls.Add(this.btnActualizarA);
            this.paneldiseño1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneldiseño1.Location = new System.Drawing.Point(0, 350);
            this.paneldiseño1.Name = "paneldiseño1";
            this.paneldiseño1.Size = new System.Drawing.Size(800, 100);
            this.paneldiseño1.TabIndex = 9;
            // 
            // btnEliminarA
            // 
            this.btnEliminarA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnEliminarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarA.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnEliminarA.FlatAppearance.BorderSize = 0;
            this.btnEliminarA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarA.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarA.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarA.Location = new System.Drawing.Point(126, 50);
            this.btnEliminarA.Name = "btnEliminarA";
            this.btnEliminarA.Size = new System.Drawing.Size(322, 50);
            this.btnEliminarA.TabIndex = 79;
            this.btnEliminarA.Text = "ELIMINAR ARTISTA";
            this.btnEliminarA.UseVisualStyleBackColor = false;
            // 
            // btnActualizarA
            // 
            this.btnActualizarA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.btnActualizarA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarA.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnActualizarA.FlatAppearance.BorderSize = 0;
            this.btnActualizarA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnActualizarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnActualizarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarA.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarA.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarA.Location = new System.Drawing.Point(126, 0);
            this.btnActualizarA.Name = "btnActualizarA";
            this.btnActualizarA.Size = new System.Drawing.Size(322, 50);
            this.btnActualizarA.TabIndex = 78;
            this.btnActualizarA.Text = "ACTUALIZAR ARTISTA";
            this.btnActualizarA.UseVisualStyleBackColor = false;
            // 
            // FormArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvArtista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneldiseño1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormArtista";
            this.Opacity = 0.9D;
            this.Text = "FormArtista";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paneldiseño1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarA;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.Panel paneldiseño1;
        private System.Windows.Forms.Button btnEliminarA;
        private System.Windows.Forms.Button btnActualizarA;
    }
}