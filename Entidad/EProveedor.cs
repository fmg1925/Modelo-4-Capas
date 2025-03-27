using System;

namespace Entidad // Espacio de trabajo de Entidad
{
    public class EProveedor
    {
        public int ValIdProveedor; // Ir y buscar llaves primarias de la base de datos 
        public String ValNombre; // Nombres de la base de datos
        public String ValRut; // Nombres de la base de datos
        public int ValIdComuna; // Ir y buscar llaves primarias de la base de datos
        public String ValDireccion; // Nombres de la base de datos
        public String ValTelefono; // Nombres de la base de datos
        public String ValEmail; // Nombres de la base de datos
        public String ValGiro; // Nombres de la base de datos
        public String ValDescripcion; // Nombres de la base de datos

        public EComuna ValComuna;
        public int ValIdProvincia;
        public int ValIdRegion;
        public EProvincia ValProvincia;
        public ERegion ValRegion;

        public int IdProveedor // Asignar Id Proveedor
        {
            get { return ValIdProveedor; } // Asigna valor de las llaves primarias
            set { ValIdProveedor = value; }
        }
        public String Nombre // Asignar Nombre
        {
            get { return ValNombre; } // Asignar valor de Nombre
            set { ValNombre = value; }
        }
        public String Rut // Asignar Rut
        {
            get { return ValRut; } // Asignar valor de Rut
            set { ValRut = value; }
        }
        public int IdComuna // Asignar Id Comuna
        {
            get { return ValIdComuna; } // Asigna valor de las llaves primarias
            set { ValIdComuna = value; }
        }
        public String Direccion // Asignar Dirección
        {
            get { return ValDireccion; } // Asignar valor de Dirección
            set { ValDireccion = value; }
        }
        public String Telefono // Asignar Teléfono
        {
            get { return ValTelefono; } // Asignar valor de Teléfono
            set { ValTelefono = value; }
        }
        public String Email // Asignar Email
        {
            get { return ValEmail; } // Asignar valor de Email
            set { ValEmail = value; }
        }
        public String Giro // Asignar Giro
        {
            get { return ValGiro; } // Asignar valor de Giro
            set { ValGiro = value; }
        }
        public String Descripcion // Asignar Descripción
        {
            get { return ValDescripcion; } // Asignar valor de Descripción
            set { ValDescripcion = value; }
        }
        public EComuna Comuna // Asignar Comuna
        {
            get { return ValComuna; } // Referencia de Comuna
            set { ValComuna = value; }
        }
        public int IdProvincia // Asignar IdProvincia
        {
            get { return ValIdProvincia; } // Referencia de Comuna
            set { ValIdProvincia = value; }
        }
        public int IdRegion // Asignar IdRegion
        {
            get { return ValIdRegion; } // Referencia de Comuna
            set { ValIdRegion = value; }
        }
        public EProvincia Provincia // Asignar Provincia
        {
            get { return ValProvincia; } // Referencia de Comuna
            set { ValProvincia = value; }
        }
        public ERegion Region // Asignar Region
        {
            get { return ValRegion; } // Referencia de Comuna
            set { ValRegion = value; }
        }
    }
}