using Datos;
using Entidad;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class NProductos
    {
        public List<EProductos> Listar() // Llamar al procedimiento listar
        {
            return DProductos.Instancia.Listar();
        }

        public static Respuesta<bool> Ingresar(EProductos obj) // Llamar al procedimiento ingresar
        {
            bool Respuesta = false;
            Respuesta = DProductos.Instancia.Ingresar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Actualizar(EProductos obj) // Llamar al procedimiento actualizar
        {
            bool Respuesta = false;
            Respuesta = DProductos.Instancia.Actualizar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Actualizar2(EProductos obj) // Llamar al procedimiento actualizar2
        {
            bool Respuesta = false;
            Respuesta = DProductos.Instancia.Actualizar2(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Eliminar(int Id) // Llamar al procedimiento eliminar
        {
            bool Respuesta = false;
            Respuesta = DProductos.Instancia.Eliminar(Id);
            return new Respuesta<bool>() { Estado = Respuesta };
        }
    }
}