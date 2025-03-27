using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DValorDelArriendo
    {
        private Conexion Cn = new Conexion(); // Crear conexión

        public static DValorDelArriendo _instancia = null; // Crear instancia vacía

        public static DValorDelArriendo Instancia // Si ya hay instancia no instanciar
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DValorDelArriendo();
                }
                return _instancia;
            }
        }
        public bool Ingresar(EValorDelArriendo obj) // Procedimiento Ingresar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_ValorDelArriendo", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("ValorUnitario1", obj.ValorUnitario1);
                    cmd.Parameters.AddWithValue("ValorUnitario2", obj.ValorUnitario2);
                    cmd.Parameters.AddWithValue("ValorUnitario3", obj.ValorUnitario3);
                    cmd.Parameters.AddWithValue("ValorUnitario4", obj.ValorUnitario4);
                    cmd.Parameters.AddWithValue("ValorUnitario5", obj.ValorUnitario5);
                    cmd.Parameters.AddWithValue("ValorUnitario6", obj.ValorUnitario6);
                    cmd.Parameters.AddWithValue("ValorUnitario7", obj.ValorUnitario7);
                    cmd.Parameters.AddWithValue("ValorUnitario8", obj.ValorUnitario8);
                    cmd.Parameters.AddWithValue("ValorUnitario9", obj.ValorUnitario9);
                    cmd.Parameters.AddWithValue("ValorUnitario10", obj.ValorUnitario10);
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
        public bool Eliminar(int IdValorUnitario) // Procedimiento Eliminar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Eli_Proveedor", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdValorUnitario", IdValorUnitario);
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