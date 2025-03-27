using Datos;
using Entidad;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class NProvincia
    {
        public List<EProvincia> Listar() // Llamar al procedimiento listar
        {
            return DProvincia.Instancia.Listar();
        }

        public DataTable Filtrar(int IdProvincia) // Llamar al procedimiento filtrar
        {
            return DProvincia.Instancia.Filtrar(IdProvincia);
        }

        public static Respuesta<bool> Ingresar(EProvincia obj) // Llamar al procedimiento ingresar
        {
            bool Respuesta = false;
            Respuesta = DProvincia.Instancia.Ingresar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Actualizar(EProvincia obj) // Llamar al procedimiento actualizar
        {
            bool Respuesta = false;
            Respuesta = DProvincia.Instancia.Actualizar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Eliminar(int Id) // Llamar al procedimiento eliminar
        {
            bool Respuesta = false;
            Respuesta = DProvincia.Instancia.Eliminar(Id);
            return new Respuesta<bool>() { Estado = Respuesta };
        }
    }
}