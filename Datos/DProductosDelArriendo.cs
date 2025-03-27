using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DProductosDelArriendo
    {
        private Conexion Cn = new Conexion(); // Crear conexión

        public static DProductosDelArriendo _instancia = null; // Crear instancia vacía

        public static DProductosDelArriendo Instancia // Si ya hay instancia no instanciar
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DProductosDelArriendo();
                }
                return _instancia;
            }
        }
        public bool Ingresar(EProductosDelArriendo obj) // Procedimiento Ingresar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_ProductosDelArriendo", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdDelProducto1", obj.IdDelProducto1);
                    cmd.Parameters.AddWithValue("IdDelProducto2", obj.IdDelProducto2);
                    cmd.Parameters.AddWithValue("IdDelProducto3", obj.IdDelProducto3);
                    cmd.Parameters.AddWithValue("IdDelProducto4", obj.IdDelProducto4);
                    cmd.Parameters.AddWithValue("IdDelProducto5", obj.IdDelProducto5);
                    cmd.Parameters.AddWithValue("IdDelProducto6", obj.IdDelProducto6);
                    cmd.Parameters.AddWithValue("IdDelProducto7", obj.IdDelProducto7);
                    cmd.Parameters.AddWithValue("IdDelProducto8", obj.IdDelProducto8);
                    cmd.Parameters.AddWithValue("IdDelProducto9", obj.IdDelProducto9);
                    cmd.Parameters.AddWithValue("IdDelProducto10", obj.IdDelProducto10);
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

        public bool Actualizar(EProductosDelArriendo obj) // Procedimiento Actualizar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_ProductosDelArriendo", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdProductosArriendo", obj.IdProductosArriendo);
                    cmd.Parameters.AddWithValue("IdDelProducto1", obj.IdDelProducto1);
                    cmd.Parameters.AddWithValue("IdDelProducto2", obj.IdDelProducto2);
                    cmd.Parameters.AddWithValue("IdDelProducto3", obj.IdDelProducto3);
                    cmd.Parameters.AddWithValue("IdDelProducto4", obj.IdDelProducto4);
                    cmd.Parameters.AddWithValue("IdDelProducto5", obj.IdDelProducto5);
                    cmd.Parameters.AddWithValue("IdDelProducto6", obj.IdDelProducto6);
                    cmd.Parameters.AddWithValue("IdDelProducto7", obj.IdDelProducto7);
                    cmd.Parameters.AddWithValue("IdDelProducto8", obj.IdDelProducto8);
                    cmd.Parameters.AddWithValue("IdDelProducto9", obj.IdDelProducto9);
                    cmd.Parameters.AddWithValue("IdDelProducto10", obj.IdDelProducto10);
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
        public bool Eliminar(int IdProductosArriendo) // Procedimiento Eliminar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Eli_ProductosDelArriendo", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdProductosArriendo", IdProductosArriendo);
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