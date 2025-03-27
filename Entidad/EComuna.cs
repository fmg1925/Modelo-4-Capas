using System;

namespace Entidad // Espacio de trabajo de Entidad
{
    public class EComuna // Clase entidad Comuna
    {
        public int ValIdComuna; // Ir y buscar llaves primarias de la base de datos
        public String ValNombre; // Nombres de la base de datos
        public int ValIdProvincia; // Ir y buscar llaves primarias de la base de datos
        public EProvincia ValProvincia; // Referencia a tabla Provincia
        public int ValIdRegion; // Ir y buscar llaves primarias de la base de datos
        public ERegion ValRegion; // Referencia a tabla Region

        public int IdComuna // IdComuna
        {
            get { return ValIdComuna; } // Asigna valor de las llaves primarias
            set { ValIdComuna = value; } // Asignar valor ID Comuna
        }
        public String Nombre // Nombre
        {
            get { return ValNombre; } // Asigna valor de Nombre
            set { ValNombre = value; }
        }
        public int IdProvincia // IdProvincia
        {
            get { return ValIdProvincia; } // Asigna valor de las llaves primarias
            set { ValIdProvincia = value; } // Asignar valor ID Provincia
        }
        public EProvincia Provincia // Referencia Provincia
        {
            get { return ValProvincia; } // Referencia a Provincia
            set { ValProvincia = value; }
        }
        public int IdRegion // IdProvincia
        {
            get { return ValIdRegion; } // Asigna valor de las llaves primarias
            set { ValIdRegion = value; } // Asignar valor ID Region
        }
        public ERegion Region // Referencia Region
        {
            get { return ValRegion; } // Referencia a Region
            set { ValRegion = value; }
        }
    }
}