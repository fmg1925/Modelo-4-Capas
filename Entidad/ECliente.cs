using System;

namespace Entidad // Espacio de trabajo de Entidad
{
    public class ECliente
    {
        public int ValIdCliente; // Ir y buscar llaves primarias de la base de datos 
        public String ValNombre; // Nombres de la base de datos
        public String ValRut; // Nombres de la base de datos
        public int ValIdComuna; // Ir y buscar llaves primarias de la base de datos
        public EComuna ValComuna; // Referencia a tabla Comuna
        public String ValDireccion; // Nombres de la base de datos
        public String ValTelefono; // Nombres de la base de datos
        public String ValEmail; // Nombres de la base de datos
        public String ValGiro; // Nombres de la base de datos
        public int ValIdProvincia;
        public int ValIdRegion;
        public EProvincia ValProvincia;
        public ERegion ValRegion;
        public int IdCliente // Asignar Id Cliente
        {
            get { return ValIdCliente; } // Asigna valor de las llaves primarias
            set { ValIdCliente = value; }
        }
        public String Nombre // Asignar Nombre
        {
            get { return ValNombre; } // Asigna valor de Nombre
            set { ValNombre = value; }
        }
        public String Rut // Asignar Rut
        {
            get { return ValRut; } // Asigna valor del Rut
            set { ValRut = value; }
        }
        public int IdComuna // Asignar Id Comuna
        {
            get { return ValIdComuna; } // Asigna valor de las llaves primarias
            set { ValIdComuna = value; }
        }
        public EComuna Comuna // Asignar Comuna
        {
            get { return ValComuna; } // Referencia a tabla Comuna
            set { ValComuna = value; }
        }
        public String Direccion // Asignar Dirección
        {
            get { return ValDireccion; } // Asigna valor de Dirección
            set { ValDireccion = value; }
        }
        public String Telefono // Asignar Teléfono
        {
            get { return ValTelefono; } // Asigna valor de Teléfono
            set { ValTelefono = value; }
        }
        public String Email // Asignar Email
        {
            get { return ValEmail; } // Asigna valor de Email
            set { ValEmail = value; }
        }
        public String Giro // Asignar Giro
        {
            get { return ValGiro; } // Asigna valor de Giro
            set { ValGiro = value; }
        }
        public int IdProvincia // Asignar Id Provincia
        {
            get { return ValIdProvincia; } // Asigna valor de las llaves primarias
            set { ValIdProvincia = value; }
        }
        public int IdRegion // Asignar IdRegion
        {
            get { return ValIdRegion; } // Asigna valor de las llaves primarias
            set { ValIdRegion = value; }
        }
        public EProvincia Provincia // Asignar Provincia
        {
            get { return ValProvincia; } // Referencia a tabla Comuna
            set { ValProvincia = value; }
        }
        public ERegion Region // Asignar Region
        {
            get { return ValRegion; } // Referencia a tabla Comuna
            set { ValRegion = value; }
        }
    }
}