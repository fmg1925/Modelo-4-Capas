using System;

namespace Entidad // Espacio de trabajo de Entidad
{
    public class EProvincia // Clase entidad Provincia
    {
        public int ValIdProvincia; // Ir y buscar llaves primarias de la base de datos

        public int ValIdRegion; // Ir y buscar llaves primarias de la base de datos

        public String ValNombre; // Nombres de la base de datos

        public ERegion ValRegion; // Referencia a tabla Región

        public int IdProvincia // IdProvincia
        {
            get { return ValIdProvincia; } // Asigna valor de las llaves primarias
            set { ValIdProvincia = value; } // Asignar valor ID Provincia
        }
        public String Nombre // IdNombre
        {
            get { return ValNombre; } // Asigna valor de las llaves primarias
            set { ValNombre = value; } // Asignar valor Nombre
        }

        public int IdRegion // IdRegion
        {
            get { return ValIdRegion; } // Asigna valor de las llaves primarias
            set { ValIdRegion = value; } // Asignar valor ID Region
        }

        public ERegion Region // Asignar Región
        {
            get { return ValRegion; } // Referencia a Región
            set { ValRegion = value; }
        }
    }
}