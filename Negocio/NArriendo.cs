using Datos;
using Entidad;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class NArriendo
    {
        public List<EArriendo> Listar() // Llamar al procedimiento listar
        {
            return DArriendo.Instancia.Listar();
        }

        public static Respuesta<bool> Ingresar(EArriendo obj) // Llamar al procedimiento ingresar
        {
            bool Respuesta = false;
            Respuesta = DArriendo.Instancia.Ingresar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Actualizar(EArriendo obj) // Llamar al procedimiento actualizar
        {
            bool Respuesta = false;
            Respuesta = DArriendo.Instancia.Actualizar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Eliminar(int IdArriendo, int IdDetalleDelArriendo, int IdProductosDelArriendo, int IdValorDelArriendo) // Llamar al procedimiento eliminar
        {
            bool Respuesta = false;
            Respuesta = DArriendo.Instancia.Eliminar(IdArriendo, IdDetalleDelArriendo, IdProductosDelArriendo, IdValorDelArriendo);
            return new Respuesta<bool>() { Estado = Respuesta };
        }
    }
}