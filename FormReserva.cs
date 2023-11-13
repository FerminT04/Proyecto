using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1_Grupo1
{
    public partial class FormReserva : Form
    {
        public FormReserva()
        {
            InitializeComponent();
        }

        private void CalcularCostoFinal()
        {
            // Obtén los valores de los controles
            string tipoLocal = cbLocal.Text.ToLower(); // Convierte a minúsculas para hacer la comparación de manera insensible a mayúsculas
            DateTime horarioInicio;
            DateTime horarioFin;

            if (!DateTime.TryParse(dtpInicio.Text, out horarioInicio) || !DateTime.TryParse(dtpFin.Text, out horarioFin))
            {
                MessageBox.Show("Por favor, ingrese un formato de hora válido para los campos de horario.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double costoPorHora = 0;

            // Determina el costo por hora según el tipo de local
            if (tipoLocal == "cerrado")
            {
                costoPorHora = 1000;
            }
            else if (tipoLocal == "abierto")
            {
                costoPorHora = 2000;
            }
            else
            {
                MessageBox.Show("Tipo de local no válido. Por favor, seleccione 'cerrado' o 'abierto'.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcula el costo total sin impuestos
            double costoTotal = costoPorHora * (horarioFin - horarioInicio).TotalHours;

            // Aplica impuestos municipales si el evento sobrepasa la medianoche (12 AM)
            if (horarioFin.Hour >= 0 && horarioFin.Hour < 12)
            {
                costoTotal += 500 * (horarioFin - new DateTime(horarioFin.Year, horarioFin.Month, horarioFin.Day, 0, 0, 0)).TotalHours;
            }

            // Asigna el costo total al campo costo_final
            txtCosto.Text = costoTotal.ToString("C"); // Formatea como moneda
        }

        private void cbLocal_enter(object sender, EventArgs e)
        {
            if (cbLocal.Text == "Tipo de local")
            {
                cbLocal.Text = "";
                cbLocal.ForeColor = Color.Black;
            }
        }

        private void cbArtista_enter(object sender, EventArgs e)
        {
            if (cbArtista.Text == "Artista")
            {
                cbArtista.Text = "";
                cbArtista.ForeColor = Color.Black;
            }
        }

        private void txtCapacidad_enter(object sender, EventArgs e)
        {
            if (txtCapacidad.Text == "Capacidad máxima")
            {
                txtCapacidad.Text = "";
                txtCapacidad.ForeColor = Color.Black;
            }
        }

        private void txtCosto_enter(object sender, EventArgs e)
        {
            if (txtCosto.Text == "Costo total")
            {
                txtCosto.Text = "";
                txtCosto.ForeColor = Color.Black;
            }
        }

        private void cbUsuario_enter(object sender, EventArgs e)
        {
            if (cbUsuario.Text == "Usuario")
            {
                cbUsuario.Text = "";
                cbUsuario.ForeColor = Color.Black;
            }
        }

        private void cbLocal_leave(object sender, EventArgs e)
        {
            if (cbLocal.Text == "")
            {
                cbLocal.Text = "Tipo de local";
                cbLocal.ForeColor = Color.DimGray;
            }
        }

        private void cbArtista_leave(object sender, EventArgs e)
        {
            if (cbArtista.Text == "")
            {
                cbArtista.Text = "Artista";
                cbArtista.ForeColor = Color.DimGray;
            }
        }

        private void txtCapacidad_leave(object sender, EventArgs e)
        {
            if (txtCapacidad.Text == "")
            {
                txtCapacidad.Text = "Capacidad máxima";
                txtCapacidad.ForeColor = Color.DimGray;
            }
        }

        private void txtCosto_leave(object sender, EventArgs e)
        {
            if (txtCosto.Text == "")
            {
                txtCosto.Text = "Costo total";
                txtCosto.ForeColor = Color.DimGray;
            }
        }

        private void cbUsuario_leave(object sender, EventArgs e)
        {
            if (cbUsuario.Text == "")
            {
                cbUsuario.Text = "Usuario";
                cbUsuario.ForeColor = Color.DimGray;
            }
        }

        private void cbLocal_keypress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbArtista_keypress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbUsuario_keypress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
