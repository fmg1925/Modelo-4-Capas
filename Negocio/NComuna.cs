using Datos;
using Entidad;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class NComuna
    {
        public List<EComuna> Listar() // Llamar al procedimiento listar
        {
            return DComuna.Instancia.Listar();
        }

        public DataTable Filtrar(int IdComuna) // Llamar al procedimiento filtrar
        {
            return DComuna.Instancia.Filtrar(IdComuna);
        }

        public static Respuesta<bool> Ingresar(EComuna obj) // Llamar al procedimiento ingresar
        {
            bool Respuesta = false;
            Respuesta = DComuna.Instancia.Ingresar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Actualizar(EComuna obj) // Llamar al procedimiento actualizar
        {
            bool Respuesta = false;
            Respuesta = DComuna.Instancia.Actualizar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Eliminar(int Id) // Llamar al procedimiento eliminar
        {
            bool Respuesta = false;
            Respuesta = DComuna.Instancia.Eliminar(Id);
            return new Respuesta<bool>() { Estado = Respuesta };
        }
    }
}