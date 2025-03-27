using Datos;
using Entidad;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class NValorDelArriendo
    {
        public static Respuesta<bool> Ingresar(EValorDelArriendo obj) // Llamar al procedimiento ingresar
        {
            bool Respuesta = false;
            Respuesta = DValorDelArriendo.Instancia.Ingresar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Eliminar(int Id) // Llamar al procedimiento eliminar
        {
            bool Respuesta = false;
            Respuesta = DValorDelArriendo.Instancia.Eliminar(Id);
            return new Respuesta<bool>() { Estado = Respuesta };
        }
    }
}