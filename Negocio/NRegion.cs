using Datos;
using Entidad;
using System.Collections.Generic;

namespace Negocio
{
    public class NRegion
    {
        public List<ERegion> Listar() // Llamar al procedimiento listar
        {
            return DRegion.Instancia.Listar();
        }

        public static Respuesta<bool> Ingresar(ERegion obj) // Llamar al procedimiento ingresar
        {
            bool Respuesta = false;
            Respuesta = DRegion.Instancia.Ingresar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Actualizar(ERegion obj) // Llamar al procedimiento actualizar
        {
            bool Respuesta = false;
            Respuesta = DRegion.Instancia.Actualizar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Eliminar(int Id) // Llamar al procedimiento eliminar
        {
            bool Respuesta = false;
            Respuesta = DRegion.Instancia.Eliminar(Id);
            return new Respuesta<bool>() { Estado = Respuesta };
        }
    }
}