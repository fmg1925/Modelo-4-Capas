using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Datos
{
    public class DCliente
    {
        private Conexion Cn = new Conexion(); // Crear conexión

        public static DCliente _instancia = null; // Crear instancia vacía

        public static DCliente Instancia // Si ya hay instancia no instanciar
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DCliente();
                }
                return _instancia;
            }
        }

        public List<ECliente> Listar() // Procedimiento Listar
        {
            List<ECliente> Lis = new List<ECliente>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                SqlCommand cmd = new SqlCommand("Bus_Cliente", oConexion); // Usando el sp
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Lis.Add(new ECliente()
                        {
                            IdCliente = Convert.ToInt32(dr["IdCliente"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Rut = dr["Rut"].ToString(),
                            IdComuna = Convert.ToInt32(dr["IdComuna"].ToString()),
                            Comuna = new EComuna() { Nombre = dr["NombreComuna"].ToString() },
                            IdProvincia = Convert.ToInt32(dr["IdProvincia"].ToString()),
                            Provincia = new EProvincia() { Nombre = dr["NombreProvincia"].ToString() },
                            IdRegion = Convert.ToInt32(dr["IdRegion"].ToString()),
                            Region = new ERegion() { Nombre = dr["NombreRegion"].ToString() },
                            Direccion = dr["Direccion"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Email = dr["Email"].ToString(),
                            Giro = dr["Giro"].ToString()
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

        public bool Ingresar(ECliente obj) // Procedimiento Ingresar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Cliente", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Rut", obj.Rut);
                    cmd.Parameters.AddWithValue("IdComuna", obj.IdComuna);
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Email", obj.Email);
                    cmd.Parameters.AddWithValue("Giro", obj.Giro);
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

        public bool Actualizar(ECliente obj) // Procedimiento Actualizar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_Cliente", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdCliente", obj.IdCliente);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Rut", obj.Rut);
                    cmd.Parameters.AddWithValue("IdComuna", obj.IdComuna);
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Email", obj.Email);
                    cmd.Parameters.AddWithValue("Giro", obj.Giro);
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

        public bool Eliminar(int IdCliente) // Procedimiento Eliminar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Eli_Cliente", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdCliente", IdCliente);
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
    }
}