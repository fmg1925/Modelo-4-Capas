using Datos;
using Entidad;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class NProductosDelArriendo
    {

        public static Respuesta<bool> Ingresar(EProductosDelArriendo obj) // Llamar al procedimiento ingresar
        {
            bool Respuesta = false;
            Respuesta = DProductosDelArriendo.Instancia.Ingresar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Actualizar(EProductosDelArriendo obj) // Llamar al procedimiento actualizar
        {
            bool Respuesta = false;
            Respuesta = DProductosDelArriendo.Instancia.Actualizar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Eliminar(int Id) // Llamar al procedimiento eliminar
        {
            bool Respuesta = false;
            Respuesta = DProductosDelArriendo.Instancia.Eliminar(Id);
            return new Respuesta<bool>() { Estado = Respuesta };
        }
    }
}