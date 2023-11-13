using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clave1_Grupo1.Clases;
using MySql.Data.MySqlClient;


namespace Clave1_Grupo1
{
    public partial class FormArtista : Form
    {
        int posicion;
        Crud_Artista objetoFunciones = new Crud_Artista();
        //void agregar()

        //{
        //    try
        //    {


        //        if (txtNombreA.Text.Trim() == "" || txtDescripcion.Text.Trim() == "")
        //        {
        //            MessageBox.Show("Existen campos vacíos", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //        {
        //            Constructor_Artista agregar = new Constructor_Artista();
        //            agregar.Nombre = txtNombreA.Text;
        //            agregar.Descripcion = txtDescripcion.Text;
        //            int datos = Crud_Artista.agregarArtista(agregar);
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Error al agregar clientes", "Error critico");
        //    }
        //}
        void CargarArtista()
        {
            try
            {
                dgvArtista.DataSource = objetoFunciones.mostrarArtista();
            }
            catch
            {
                MessageBox.Show("Error al cargar Artistas");
            }


        }
        public FormArtista()
        {
            InitializeComponent();
        }

        private void btnAgregarA_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    agregar();
            //    CargarArtista();
            //}
            //catch
            //{
            //    MessageBox.Show("Error al insertar cliente", "Error critico");
            //}
        }

        private void btnActualizarA_Click(object sender, EventArgs e)
        {
            if (txtNombreA.Text.Trim() == "" || txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos vacíos", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Constructor_Artista actualizar = new Constructor_Artista();
                actualizar.idartista = Convert.ToInt32(txtId_artista.Text);
                actualizar.Nombre = txtNombreA.Text;
                actualizar.Descripcion = txtDescripcion.Text;

                int datos = Crud_Artista.actualizarArtista(actualizar);
                if (datos > 0)
                {
                    MessageBox.Show("Actualizado");
                }
                else
                {
                    MessageBox.Show("No Actualizado");
                }

                CargarArtista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombreA.Text.Trim() == "" || txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos vacíos", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int datos = Crud_Artista.eliminarArtista(Convert.ToInt32(txtId_artista.Text));
                if (datos > 0)
                {
                    MessageBox.Show("Artista eliminado", "Eliminado");
                }

                CargarArtista();
            }
        }

        private void txtNombreA_leave(object sender, EventArgs e)
        {
            if (txtNombreA.Text == "")
            {
                txtNombreA.Text = "Nombre";
                txtNombreA.ForeColor = Color.DimGray;
            }
        }

        private void txtNombreA_enter(object sender, EventArgs e)
        {
            if (txtNombreA.Text == "Nombre")
            {
                txtNombreA.Text = "";
                txtNombreA.ForeColor = Color.Black;
            }
        }

        private void txtDescripcion_enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripcion")
            {
                txtDescripcion.Text = "";
                txtDescripcion.ForeColor = Color.Black;
            }
        }

        private void txtDescripcion_leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripcion";
                txtDescripcion.ForeColor = Color.DimGray;
            }
        }

        private void dgvArtista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvArtista.CurrentRow.Index;
            txtId_artista.Text = dgvArtista[0, posicion].Value.ToString();
            txtNombreA.Text = dgvArtista[1, posicion].Value.ToString();
            txtDescripcion.Text = dgvArtista[2, posicion].Value.ToString();

            btnAgregarA.Enabled = false;
            txtNombreA.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        private void btnMostrarA_Click(object sender, EventArgs e)
        {
            CargarArtista();
        }

        private void btnEliminarA_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNombreA.Text.Trim() == "" || txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos vacíos", "Error de inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int datos = Crud_Artista.eliminarArtista(Convert.ToInt32(txtId_artista.Text));
                if (datos > 0)
                {
                    MessageBox.Show("Artista eliminado", "Eliminado");
                }

                CargarArtista();
            }
        }
    }
}
