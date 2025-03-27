using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DLogin
    {
        private Conexion Cn = new Conexion(); // Crear conexión

        public static DLogin _instancia = null; // Crear instancia vacía

        public static DLogin Instancia // Si ya hay instancia no instanciar
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DLogin();
                }
                return _instancia;
            }
        }

        public int Login(string Nombre, string Pass) // Procedimiento Login
        {
            int Respuesta = 0;

            using (SqlConnection connection = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand command = new SqlCommand("Login", connection); // Usando el sp
                    command.Parameters.AddWithValue("Nombre", Nombre);
                    command.Parameters.AddWithValue("Pass", Pass);
                    command.Parameters.Add("IdUsuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    command.ExecuteNonQuery();

                    Respuesta = Convert.ToInt32(command.Parameters["IdUsuario"].Value);

                }
                catch (Exception) // En caso de error
                {
                    Respuesta = 0;
                }
            }
            return Respuesta;
        }
    }
}