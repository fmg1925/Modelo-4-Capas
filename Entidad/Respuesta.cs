namespace Entidad
{
    public class Respuesta<T> // Clase Respuesta
    {
        public bool Estado { get; set; } // Asignar Estado
        public string Valor { get; set; } // Asignar Valor
        public T Objeto { get; set; } // Asignar Objeto
    }
}