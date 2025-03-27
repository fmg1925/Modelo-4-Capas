using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Datos
{
    public class DProductos
    {
        private Conexion Cn = new Conexion(); // Crear conexión

        public static DProductos _instancia = null; // Crear instancia vacía

        public static DProductos Instancia // Si ya hay instancia no instanciar
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DProductos();
                }
                return _instancia;
            }
        }

        public List<EProductos> Listar() // Procedimiento Listar
        {
            List<EProductos> Lis = new List<EProductos>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                SqlCommand cmd = new SqlCommand("Bus_Productos", oConexion); // Usando el sp
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Lis.Add(new EProductos()
                        {
                            IdProducto = Convert.ToInt32(dr["IdProducto"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            FechaIncorporacion = dr["FechaIncorporacion"].ToString(),
                            CantidadInicial = dr["CantidadInicial"].ToString(),
                            CantidadActual = dr["CantidadActual"].ToString(),
                            CantidadArrendada = dr["CantidadArrendada"].ToString(),
                            TotalActual = dr["TotalActual"].ToString(),
                            ValorArriendo = dr["ValorArriendo"].ToString(),
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
        public bool Ingresar(EProductos obj) // Procedimiento Ingresar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Productos", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("FechaIncorporacion", obj.FechaIncorporacion);
                    cmd.Parameters.AddWithValue("CantidadInicial", obj.CantidadInicial);
                    cmd.Parameters.AddWithValue("CantidadActual", obj.CantidadActual);
                    cmd.Parameters.AddWithValue("CantidadArrendada", obj.CantidadArrendada);
                    cmd.Parameters.AddWithValue("TotalActual", obj.TotalActual);
                    cmd.Parameters.AddWithValue("ValorArriendo", obj.ValorArriendo);
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

        public bool Actualizar(EProductos obj) // Procedimiento Actualizar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_Productos", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("FechaIncorporacion", obj.FechaIncorporacion);
                    cmd.Parameters.AddWithValue("CantidadInicial", obj.CantidadInicial);
                    cmd.Parameters.AddWithValue("CantidadActual", obj.CantidadActual);
                    cmd.Parameters.AddWithValue("CantidadArrendada", obj.CantidadArrendada);
                    cmd.Parameters.AddWithValue("TotalActual", obj.TotalActual);
                    cmd.Parameters.AddWithValue("ValorArriendo", obj.ValorArriendo);
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

        public bool Actualizar2(EProductos obj) // Procedimiento Actualizar 2
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_Productos2", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdProducto", obj.IdProducto);
                    cmd.Parameters.AddWithValue("CantidadArrendada", obj.CantidadArrendada);
                    cmd.Parameters.AddWithValue("TotalActual", obj.TotalActual);
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

        public bool Eliminar(int IdProducto) // Procedimiento Eliminar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Eli_Productos", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdProducto", IdProducto);
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