using Datos;
using Entidad;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class NProveedor
    {
        public List<EProveedor> Listar() // Llamar al procedimiento listar
        {
            return DProveedor.Instancia.Listar();
        }

        public static Respuesta<bool> Ingresar(EProveedor obj) // Llamar al procedimiento ingresar
        {
            bool Respuesta = false;
            Respuesta = DProveedor.Instancia.Ingresar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Actualizar(EProveedor obj) // Llamar al procedimiento actualizar
        {
            bool Respuesta = false;
            Respuesta = DProveedor.Instancia.Actualizar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Eliminar(int Id) // Llamar al procedimiento eliminar
        {
            bool Respuesta = false;
            Respuesta = DProveedor.Instancia.Eliminar(Id);
            return new Respuesta<bool>() { Estado = Respuesta };
        }
    }
}