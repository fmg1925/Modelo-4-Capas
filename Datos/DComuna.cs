using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DComuna
    {
        private Conexion Cn = new Conexion(); // Crear conexión

        public static DComuna _instancia = null; // Crear instancia vacía

        public static DComuna Instancia // Si ya hay instancia no instanciar
        {
            get
            {
                if (_instancia == null) // Si no hay instancia
                {
                    _instancia = new DComuna(); // Crear nueva instancia
                }
                return _instancia; // Devolver instancia
            }
        }

        public List<EComuna> Listar() // Procedimiento Listar 
        {
            List<EComuna> Lis = new List<EComuna>(); // Listar comuna
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex)) // Conectar a bd
            {
                SqlCommand cmd = new SqlCommand("Bus_Comuna", oConexion); // Usando el sp
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read()) // Leer datos
                    {
                        Lis.Add(new EComuna() // Crear lista
                        {
                            IdComuna = Convert.ToInt32(dr["IdComuna"].ToString()), // Parámetros de comuna
                            Nombre = dr["Nombre"].ToString(),
                            IdProvincia = Convert.ToInt32(dr["IdProvincia"].ToString()),
                            Provincia = new EProvincia() { Nombre = dr["NombreProvincia"].ToString() },
                            IdRegion = Convert.ToInt32(dr["IdRegion"].ToString()),
                            Region = new ERegion() { Nombre = dr["NombreRegion"].ToString() }
                        });
                    }
                    dr.Close();
                    return Lis;
                }
                catch (Exception) // En caso de error devolver lista vacía
                {
                    Lis = null;
                    return Lis;
                }
            }
        }

        public DataTable Filtrar(int IdProvincia) // Procedimiento Filtrar
        {
            DataTable dt = new DataTable(); // Nueva tabla de datos
            List<Parametro> parametros = new List<Parametro>(); // Crear nueva lista de parámetros
            try
            {
                parametros.Add(new Parametro("@IdProvincia", IdProvincia)); // Filtrar por id
                using (SqlConnection conexion = new SqlConnection(Conexion.Conex))
                {
                    SqlCommand cmd = new SqlCommand("Fil_Comuna", conexion); // Usando el sp
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var parametro in parametros) // Por cada parámetro
                    {
                        cmd.Parameters.AddWithValue(parametro.Nombre, parametro.Valor); // Añadir a los parámetros
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt; // Devolver tabla de datos
            }
            catch (Exception ex) // En caso de error
            {
                throw ex; // Tirar error
            }
        }

        public bool Ingresar(EComuna obj) // Procedimiento Ingresar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Comuna", Con); // Usando el sp y los parámetros
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("IdProvincia", obj.IdProvincia);
                    cmd.Parameters.AddWithValue("IdRegion", obj.IdRegion);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception) // En caso de error
                {
                    Respuesta = false; // Devolver false
                }
            }
            return Respuesta; // Devolver true
        }

        public bool Actualizar(EComuna obj) // Procedimiento Actualizar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_Comuna", Con); // Usando el sp y los parámetros
                    cmd.Parameters.AddWithValue("IdComuna", obj.IdComuna);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("IdProvincia", obj.IdProvincia);
                    cmd.Parameters.AddWithValue("IdRegion", obj.IdRegion);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception) // En caso de error
                {
                    Respuesta = false; // Respuesta es false
                }
            }
            return Respuesta; // Respuesta es true
        }

        public bool Eliminar(int IdComuna) // Procedimiento Eliminar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Eli_Comuna", Con); // Usando el sp y los parámetros
                    cmd.Parameters.AddWithValue("IdComuna", IdComuna);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception) // En caso de error
                {
                    Respuesta = false; // Respuesta es false
                }
            }
            return Respuesta; // Devolver true
        }
    }
}