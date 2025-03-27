using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DArriendo
    {
        private Conexion Cn = new Conexion(); // Crear conexión

        public static DArriendo _instancia = null; // Crear instancia vacía

        public static DArriendo Instancia // Si ya hay instancia no instanciar
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DArriendo();
                }
                return _instancia;
            }
        }

        public List<EArriendo> Listar() // Procedimiento Listar
        {
            List<EArriendo> Lis = new List<EArriendo>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                SqlCommand cmd = new SqlCommand("Bus_Arriendo", oConexion); // Usando el sp
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Lis.Add(new EArriendo()
                        {
                            IdArriendo = Convert.ToInt32(dr["IdArriendo"].ToString()),
                            IdCliente = Convert.ToInt32(dr["IdCliente"].ToString()),
                            Cliente = new ECliente() { Nombre = dr["Nombre"].ToString() },
                            Fecha = dr["Fecha"].ToString(),
                            IdProductosArriendo = Convert.ToInt32(dr["IdProductosArriendo"].ToString()),
                            IdDetalleDelArriendo = Convert.ToInt32(dr["IdDetalleDelArriendo"].ToString()),
                            IdValorUnitario = Convert.ToInt32(dr["IdValorUnitario"].ToString()),
                            Subtotal = dr["Subtotal"].ToString(),
                            Descuento = dr["Descuento"].ToString(),
                            IVA = dr["IVA"].ToString(),
                            Total = dr["Total"].ToString()
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

        public bool Ingresar(EArriendo obj) // Procedimiento Ingresar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Arriendo", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdCliente", obj.IdCliente);
                    cmd.Parameters.AddWithValue("Fecha", obj.Fecha);
                    cmd.Parameters.AddWithValue("IdProductosArriendo", obj.IdProductosArriendo);
                    cmd.Parameters.AddWithValue("IdDetalleDelArriendo", obj.IdDetalleDelArriendo);
                    cmd.Parameters.AddWithValue("IdValorUnitario", obj.IdValorUnitario);
                    cmd.Parameters.AddWithValue("Subtotal", obj.Subtotal);
                    cmd.Parameters.AddWithValue("Descuento", obj.Descuento);
                    cmd.Parameters.AddWithValue("IVA", obj.IVA);
                    cmd.Parameters.AddWithValue("Total", obj.Total);
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
            return Respuesta;
        }

        public bool Actualizar(EArriendo obj) // Procedimiento Actualizar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_Arriendo", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdArriendo", obj.IdArriendo);
                    cmd.Parameters.AddWithValue("IdCliente", obj.IdCliente);
                    cmd.Parameters.AddWithValue("Fecha", obj.Fecha);
                    cmd.Parameters.AddWithValue("Subtotal", obj.Subtotal);
                    cmd.Parameters.AddWithValue("Descuento", obj.Descuento);
                    cmd.Parameters.AddWithValue("IVA", obj.IVA);
                    cmd.Parameters.AddWithValue("Total", obj.Total);
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
            return Respuesta;
        }

        public bool Eliminar(int IdArriendo, int IdDetalleDelArriendo, int IdProductosDelArriendo, int IdValorDelArriendo) // Procedimiento Eliminar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Eli_Arriendo", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdDetalleDelArriendo", IdDetalleDelArriendo);
                    cmd.Parameters.AddWithValue("IdProductosDelArriendo", IdProductosDelArriendo);
                    cmd.Parameters.AddWithValue("IdValorUnitario", IdValorDelArriendo);
                    cmd.Parameters.AddWithValue("IdArriendo", IdArriendo);
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
            return Respuesta;
        }
    }
}