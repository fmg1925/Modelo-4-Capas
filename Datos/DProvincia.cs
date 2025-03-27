using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Datos
{
    public class DProvincia
    {
        private Conexion Cn = new Conexion(); // Crear conexión

        public static DProvincia _instancia = null; // Crear instancia vacía

        public static DProvincia Instancia // Si ya hay instancia no instanciar
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DProvincia();
                }
                return _instancia;
            }
        }

        public List<EProvincia> Listar() // Procedimiento Listar
        {
            List<EProvincia> Lis = new List<EProvincia>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                SqlCommand cmd = new SqlCommand("Bus_Provincia", oConexion); // Usando el sp
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Lis.Add(new EProvincia()
                        {
                            IdProvincia = Convert.ToInt32(dr["IdProvincia"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            IdRegion = Convert.ToInt32(dr["IdRegion"].ToString()),
                            Region = new ERegion() { Nombre = dr["NombreRegion"].ToString() },
                        });
                    }
                    dr.Close();
                    return Lis;
                }
                catch (Exception) // En caso de error
                {
                    Lis = null;
                    return Lis;
                }
            }
        }

        public DataTable Filtrar(int IdRegion) // Procedimiento Filtrar
        {
            DataTable dt = new DataTable();
            List<Parametro> parametros = new List<Parametro>();
            try
            {
                parametros.Add(new Parametro("@IdRegion", IdRegion));
                using (SqlConnection conexion = new SqlConnection(Conexion.Conex)) // Conexión a bd
                {
                    SqlCommand cmd = new SqlCommand("Fil_Provincia", conexion); // Usando el sp
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var parametro in parametros)
                    {
                        cmd.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch (Exception ex) // En caso de error
            {
                throw ex;
            }
        }

        public bool Ingresar(EProvincia obj) // Procedimiento Ingresar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Provincia", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("IdRegion", obj.IdRegion);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception)
                {
                    Respuesta = false;
                }
            }
            return Respuesta;
        }

        public bool Actualizar(EProvincia obj) // Procedimiento Actualizar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_Provincia", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdProvincia", obj.IdProvincia);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("IdRegion", obj.IdRegion);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception) // En caso de error
                {
                    Respuesta = false;
                }
            }
            return Respuesta;
        }

        public bool Eliminar(int IdProvincia) // Procedimiento Eliminar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Eli_Provincia", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdProvincia", IdProvincia);
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