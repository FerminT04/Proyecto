using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Clave1_Grupo1.Clases
{
    class Conexion
    {
        public static  MySqlConnection conexion()
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "clave1_grupo1db"; //Nombre de la base de datos
            string usuario = "root"; //Usuario de acceso a MySQL
            string password = "root"; //Contraseña de usuario de acceso a MySQL
                                             //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor +
            "; User Id=" + usuario + "; Password=" + password + "";
            //Instancia para conexión a MySQL, recibe la cadena de conexión

            try
            {
                MySqlConnection conexiondb = new MySqlConnection(cadenaConexion);
                return conexiondb;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar a la base", "Error critico" + ex);
                return null;
            }
        }
    }
}
