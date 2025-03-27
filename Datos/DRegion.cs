using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace Datos
{
    public class DRegion
    {
        private Conexion Cn = new Conexion(); // Crear conexión

        public static DRegion _instancia = null; // Crear instancia vacía

        public static DRegion Instancia // Si ya hay instancia no instanciar
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DRegion();
                }
                return _instancia;
            }
        }

        public List<ERegion> Listar() // Procedimiento Listar
        {
            List<ERegion> Lis = new List<ERegion>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                SqlCommand cmd = new SqlCommand("Bus_Region", oConexion); // Usando el sp
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Lis.Add(new ERegion()
                        {
                            IdRegion = Convert.ToInt32(dr["IdRegion"]),
                            Nombre = dr["Nombre"].ToString(),
                        });
                    }
                    dr.Close();
                    return Lis;
                }
                catch (Exception e) // En caso de error
                {
                    Debug.Print(e.ToString());
                    Lis = null;
                    return Lis;
                }
            }
        }

        public bool Ingresar(ERegion obj) // Procedimiento Ingresar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Region", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception e) // En caso de error
                {
                    Debug.Print(e.ToString());
                    Respuesta = false;
                }
            }
            return Respuesta;
        }

        public bool Actualizar(ERegion obj) // Procedimiento Actualizar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_Region", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdRegion", obj.IdRegion);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception e) // En caso de error
                {
                    Debug.Print(e.ToString());
                    Respuesta = false;
                }
            }
            return Respuesta;
        }

        public bool Eliminar(int Id) // Procedimiento Eliminar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Eli_Region", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdRegion", Id);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception e) // En caso de error
                {
                    Debug.Print(e.ToString());
                    Respuesta = false;
                }
            }
            return Respuesta;
        }
    }
}