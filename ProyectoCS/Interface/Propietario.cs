using ProyectoCS.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos.Interface
{
    public class Propietario
    {
        private readonly ConeccionSQL _conexionSQL;

        public Propietario(ConeccionSQL conexionSQL)
        {
            _conexionSQL = conexionSQL;
        }

        public void InsertarPropietario(string dni, string nombres, string apellidos, string correo, string telefono, string direccion)
        {
            using (SqlConnection connection = _conexionSQL.AbrirConexion())
            {
                using (SqlCommand command = new SqlCommand("InsertarPropietario", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Nombres", nombres);
                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Direccion", direccion);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
