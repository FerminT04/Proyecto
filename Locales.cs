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
    public partial class Locales : Form
    {
        public Locales()
        {
            InitializeComponent();
        }

        private void ValidarCapacidad()
        {
            // Obtén el valor de los controles
            string tipoLocal = cbTipo.Text;
            int capacidad;

            // Intenta convertir el valor de txtCapacidad a un entero
            if (!int.TryParse(txtCapacidad.Text, out capacidad))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para la capacidad.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // No necesitas cancelar la validación si la entrada no es válida
                return;
            }

            // Realiza la validación basada en el tipo de local
            if (tipoLocal.ToLower() == "cerrado" && capacidad > 500)
            {
                MessageBox.Show("La capacidad máxima para locales cerrados es de 500.", "Error de capacidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Maneja la lógica de error, por ejemplo, puedes limpiar el valor o indicar al usuario que corrija la entrada
                txtCapacidad.Text = "500";
            }
            else if (tipoLocal.ToLower() == "abierto" && capacidad > 1000)
            {
                MessageBox.Show("La capacidad máxima para locales abiertos es de 1000.", "Error de capacidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Maneja la lógica de error, por ejemplo, puedes limpiar el valor o indicar al usuario que corrija la entrada
                txtCapacidad.Text = "1000";
            }
        }
    }
}
