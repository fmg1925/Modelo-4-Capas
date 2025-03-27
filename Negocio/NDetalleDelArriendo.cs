using Datos;
using Entidad;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class NDetalleDelArriendo
    {
        public static Respuesta<bool> Ingresar(EDetalleDelArriendo obj) // Llamar al procedimiento ingresar
        {
            bool Respuesta = false;
            Respuesta = DDetalleDelArriendo.Instancia.Ingresar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Actualizar(EDetalleDelArriendo obj) // Llamar al procedimiento actualizar
        {
            bool Respuesta = false;
            Respuesta = DDetalleDelArriendo.Instancia.Actualizar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Eliminar(int Id) // Llamar al procedimiento eliminar
        {
            bool Respuesta = false;
            Respuesta = DDetalleDelArriendo.Instancia.Eliminar(Id);
            return new Respuesta<bool>() { Estado = Respuesta };
        }
    }
}