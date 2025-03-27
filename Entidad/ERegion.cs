using System;

namespace Entidad // Espacio de trabajo de Entidad
{
    public class ERegion
    {
        public int ValIdRegion; // Ir y buscar llaves primarias de la base de datos 

        public String ValNombre; // Nombres de la base de datos

        public int IdRegion // Asignar Id Región
        {
            get { return ValIdRegion; } // Asigna valor de las llaves primarias
            set { ValIdRegion = value; }
        }
        public String Nombre // Asignar Nombre
        {
            get { return ValNombre; } // Asignar valor de Nombre
            set { ValNombre = value; }
        }

    }
}