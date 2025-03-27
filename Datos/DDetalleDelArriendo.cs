using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DDetalleDelArriendo
    {
        private Conexion Cn = new Conexion(); // Crear conexión

        public static DDetalleDelArriendo _instancia = null; // Crear instancia vacía

        public static DDetalleDelArriendo Instancia // Si ya hay instancia no instanciar
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DDetalleDelArriendo();
                }
                return _instancia;
            }
        }
        public bool Ingresar(EDetalleDelArriendo obj) // Procedimiento Ingresar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_DetalleDelArriendo", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("DetalleDelProducto1", obj.DetalleDelProducto1);
                    cmd.Parameters.AddWithValue("DetalleDelProducto2", obj.DetalleDelProducto2);
                    cmd.Parameters.AddWithValue("DetalleDelProducto3", obj.DetalleDelProducto3);
                    cmd.Parameters.AddWithValue("DetalleDelProducto4", obj.DetalleDelProducto4);
                    cmd.Parameters.AddWithValue("DetalleDelProducto5", obj.DetalleDelProducto5);
                    cmd.Parameters.AddWithValue("DetalleDelProducto6", obj.DetalleDelProducto6);
                    cmd.Parameters.AddWithValue("DetalleDelProducto7", obj.DetalleDelProducto7);
                    cmd.Parameters.AddWithValue("DetalleDelProducto8", obj.DetalleDelProducto8);
                    cmd.Parameters.AddWithValue("DetalleDelProducto9", obj.DetalleDelProducto9);
                    cmd.Parameters.AddWithValue("DetalleDelProducto10", obj.DetalleDelProducto10);
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

        public bool Actualizar(EDetalleDelArriendo obj) // Procedimiento Actualizar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_DetalleDelArriendo", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdDetalleDelArriendo", obj.IdDetalleDelArriendo);
                    cmd.Parameters.AddWithValue("DetalleDelProducto1", obj.DetalleDelProducto1);
                    cmd.Parameters.AddWithValue("DetalleDelProducto2", obj.DetalleDelProducto2);
                    cmd.Parameters.AddWithValue("DetalleDelProducto3", obj.DetalleDelProducto3);
                    cmd.Parameters.AddWithValue("DetalleDelProducto4", obj.DetalleDelProducto4);
                    cmd.Parameters.AddWithValue("DetalleDelProducto5", obj.DetalleDelProducto5);
                    cmd.Parameters.AddWithValue("DetalleDelProducto6", obj.DetalleDelProducto6);
                    cmd.Parameters.AddWithValue("DetalleDelProducto7", obj.DetalleDelProducto7);
                    cmd.Parameters.AddWithValue("DetalleDelProducto8", obj.DetalleDelProducto8);
                    cmd.Parameters.AddWithValue("DetalleDelProducto9", obj.DetalleDelProducto9);
                    cmd.Parameters.AddWithValue("DetalleDelProducto10", obj.DetalleDelProducto10);
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

        public bool Eliminar(int IdDetalleDelArriendo) // Procedimiento Eliminar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Eli_DetalleDelArriendo", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdDetalleDelArriendo", IdDetalleDelArriendo);
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