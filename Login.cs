using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Clave1_Grupo1.Clases;

namespace Clave1_Grupo1
{
    public partial class Login : Form
    {
        //private MySqlConnection conexion;
        public Login()
        {
            InitializeComponent();

            //string cadenaConexion = "Server=localhost;Database=clave1_grupo1db;User ID=root;Password=root;";
            //conexion = new MySqlConnection(cadenaConexion);
        }

        MySqlConnection conexiondb = Conexion.conexion();

        private void btnSalirL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void validarBoton()
        {
            var bl = !string.IsNullOrEmpty(txtUsuarios.Text) && !string.IsNullOrEmpty(txtContraseñas.Text);

            btnInicioSesion.Enabled = bl;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            validarBoton();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            validarBoton();
        }

        private void txtUsuario(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContraseña(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIniciarS(object sender, EventArgs e)
        {

            try
            {
                conexiondb.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conexiondb;

            codigo.CommandText = ("SELECT * FROM usuarios WHERE nombre = '" + txtUsuarios.Text + "'and contraseña ='" + txtContraseñas.Text + "'");

            MySqlDataReader leer = codigo.ExecuteReader();

            if (leer.Read())
            {
                MessageBox.Show("Bienvenido, Inicio de sesion exitoso");
                FormPrincipal llamar = new FormPrincipal();
                llamar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                txtUsuarios.Clear();
                txtContraseñas.Clear();
            }

            conexiondb.Close();
            //string usuario = txtUsuarios.Text;
            //string contraseña = txtContraseñas.Text;

            //if (ValidarCredenciales(usuario, contraseña))
            //{
            //    MessageBox.Show("Inicio de sesión exitoso");
            //    this.Hide();
            //    FormPrincipal formularioPrincipal = new FormPrincipal();
            //    formularioPrincipal.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Error en las credenciales");
            //}
        }

        //private bool ValidarCredenciales(string usuario, string contraseña)
        //{
        //    if (conexion.State == ConnectionState.Closed)
        //    {
        //        conexion.Open();
        //    }

        //    try
        //    {
        //        string consulta = "SELECT * FROM usuarios WHERE nombre = @nombre AND contraseña = @contraseña";
        //        MySqlCommand comando = new MySqlCommand(consulta, conexion);
        //        comando.Parameters.AddWithValue("@nombre", usuario);
        //        comando.Parameters.AddWithValue("@contraseña", contraseña);

        //        MySqlDataReader reader = comando.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            // Credenciales válidas
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error al validar credenciales: {ex.Message}");
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }

        //    return false;
        //}

        private void txtUsuario_leave(object sender, EventArgs e)
        {
            if (txtUsuarios.Text == "")
            {
                txtUsuarios.Text = "USUARIO";
                txtUsuarios.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_enter(object sender, EventArgs e)
        {
            if (txtContraseñas.Text == "CONTRASEÑA")
            {
                txtContraseñas.Text = "";
                txtContraseñas.ForeColor = Color.Black;
                txtContraseñas.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_enter(object sender, EventArgs e)
        {
            if (txtUsuarios.Text == "USUARIO")
            {
                txtUsuarios.Text = "";
                txtUsuarios.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_leave(object sender, EventArgs e)
        {
            if (txtContraseñas.Text == "")
            {
                txtContraseñas.Text = "CONTRASEÑA";
                txtContraseñas.UseSystemPasswordChar = false;
                txtContraseñas.ForeColor = Color.DimGray;
            }
        }
    }
}
