using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Clave1_Grupo1.Clases
{
    class Crud_Artista
    {
        public DataTable mostrarArtista()
        {
            DataTable datos = new DataTable();
            string instruccion = "SELECT id, nombre AS Nombre, descripcion AS Descripcion FROM artistas";
            MySqlCommand comando = new MySqlCommand(instruccion, Conexion.conexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(datos);
            return datos;
        }

        public static int actualizarArtista(Constructor_Artista update)
        {

            int retorno = 0;
            try
            {
                MySqlCommand consulta = new MySqlCommand(string.Format("UPDATE artistas SET id ='{0}', nombre ='{1}', descripcion ='{2}' WHERE id ='{0}'", update.idartista, update.Nombre, update.Descripcion), Conexion.conexion());
                retorno = consulta.ExecuteNonQuery();
                return retorno;
            }
            catch
            {
                MessageBox.Show("Error de datos, por favor consulte con su administrador");
                return retorno;
            }
        }

        public static int eliminarArtista(int iduser)
        {

            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("DELETE * FROM artistas WHERE id ='{0}' WHERE id ='{0}'", iduser), Conexion.conexion());
                retorno = comando.ExecuteNonQuery();

                if (retorno > 0)
                {
                    MessageBox.Show("Artista eliminado exitosamente", "Inserción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Artista no a sido eliminado", "Inserción incompletada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return retorno;
            }
            catch
            {
                MessageBox.Show("Error critico");
                return retorno;
            }

        }
    }
}
