using System;
using System.Data.SqlClient;

namespace ProyectoCS.Controlador
{
    public class ConeccionSQL : IDisposable
    {
        private SqlConnection conexion;
        private string connectionString;

        public ConeccionSQL()
        {
            // Modifica la cadena de conexión según tu configuración
            connectionString = "Data Source=DESKTOP-5755S3Q\\SQLEXPRESS;Initial Catalog=CS6-3;Integrated Security=True";
            conexion = new SqlConnection(connectionString);
        }

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (conexion == null)
                {
                    conexion = new SqlConnection(connectionString);
                }

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

                return conexion;
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades (puedes lanzarla nuevamente o loggearla)
                throw new Exception("Error al abrir la conexión: " + ex.Message);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades (puedes lanzarla nuevamente o loggearla)
                throw new Exception("Error al cerrar la conexión: " + ex.Message);
            }
            finally
            {
                conexion.Dispose(); // Liberar recursos
            }
        }

        public void Dispose()
        {
            CerrarConexion();
            GC.SuppressFinalize(this);
        }
    }
}
