using Datos;

namespace Negocio
{
    public class NLogin
    {
        private DLogin Datos = new DLogin();

        public int Login(string Nombre, string Pass) // Llamar al procedimiento login
        {
            return DLogin.Instancia.Login(Nombre, Pass);
        }
    }
}
