using System;

namespace Entidad // Espacio de trabajo de Entidad
{
    public class ELogin
    {
        public int ValIdUsuario; // Ir y buscar llaves primarias de la base de datos 

        public String ValNombre; // Nombres de la base de datos

        public String ValPass; // Nombres de la base de datos

        public int IdUsuario // Asignar Id Usuario
        {
            get { return ValIdUsuario; } // Asigna valor de las llaves primarias
            set { ValIdUsuario = value; }
        }
        public String Nombre // Asignar Nombre
        {
            get { return ValNombre; } // Asignar valor del Nombre
            set { ValNombre = value; }
        }
        public String Pass // Asignar Contraseña
        {
            get { return ValPass; } // Asignar valor de Contraseña
            set { ValPass = value; }
        }
    }
}