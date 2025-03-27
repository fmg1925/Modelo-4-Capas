using Datos;
using Entidad;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class NCliente
    {
        public List<ECliente> Listar() // Llamar al procedimiento listar
        {
            return DCliente.Instancia.Listar();
        }

        public static Respuesta<bool> Ingresar(ECliente obj) // Llamar al procedimiento ingresar
        {
            bool Respuesta = false;
            Respuesta = DCliente.Instancia.Ingresar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Actualizar(ECliente obj) // Llamar al procedimiento actualizar
        {
            bool Respuesta = false;
            Respuesta = DCliente.Instancia.Actualizar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Eliminar(int Id) // Llamar al procedimiento eliminar
        {
            bool Respuesta = false;
            Respuesta = DCliente.Instancia.Eliminar(Id);
            return new Respuesta<bool>() { Estado = Respuesta };
        }
    }
}