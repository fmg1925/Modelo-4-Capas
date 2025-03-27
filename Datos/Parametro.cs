namespace Datos
{
    public class Parametro
    {
        public string Nombre { get; set; } // Asignar Nombre
        public object Valor { get; set; } // Asignar Valor

        public Parametro(string nombre, object valor) // Parámetro
        {
            Nombre = nombre; // Nombre = parámetro nombre
            Valor = valor; // Valor = parámetro valor
        }
    }
}