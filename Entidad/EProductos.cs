using System;

namespace Entidad // Espacio de trabajo de Entidad
{
    public class EProductos
    {
        public int ValIdProducto; // Ir y buscar llaves primarias de la base de datos 
        public String ValNombre; // Nombres de la base de datos
        public String ValFechaIncorporacion; // Nombres de la base de datos
        public String ValCantidadInicial; // Nombres de la base de datos
        public String ValCantidadActual; // Nombres de la base de datos
        public String ValCantidadArrendada; // Nombres de la base de datos
        public String ValTotalActual; // Nombres de la base de datos
        public String ValValorArriendo; // Nombres de la base de datos

        public String Nombre // Asignar Nombre
        {
            get { return ValNombre; } // Asigna valor de las llaves primarias
            set { ValNombre = value; }
        }
        public int IdProducto // Asignar Id Producto
        {
            get { return ValIdProducto; } // Asigna valor de las llaves primarias
            set { ValIdProducto = value; }
        }
        public String FechaIncorporacion // Asignar Fecha Incorporación
        {
            get { return ValFechaIncorporacion; } // Asignar valor de Fecha de Incorporación
            set { ValFechaIncorporacion = value; }
        }
        public String CantidadInicial // Asignar Cantidad Inicial
        {
            get { return ValCantidadInicial; } // Asignar valor de Cantidad Inicial
            set { ValCantidadInicial = value; }
        }
        public String CantidadActual // Asignar Cantidad Actual
        {
            get { return ValCantidadActual; } // Asignar valor de Cantidad Actual
            set { ValCantidadActual = value; }
        }
        public String CantidadArrendada // Asignar Cantidad Arrendada
        {
            get { return ValCantidadArrendada; } // Asignar valor de Cantidad Arrendada
            set { ValCantidadArrendada = value; }
        }
        public String TotalActual // Asignar Total Actual
        {
            get { return ValTotalActual; } // Asignar valor de Total Actual
            set { ValTotalActual = value; }
        }
        public String ValorArriendo // Asignar ValorArriendo
        {
            get { return ValValorArriendo; } // Asignar valor de Valor de Arriendo
            set { ValValorArriendo = value; }
        }
    }
}