using System;

namespace Entidad // Espacio de trabajo de Entidad
{
    public class EArriendo
    {
        public int ValIdArriendo; // Ir y buscar llaves primarias de la base de datos 
        public int ValIdCliente; // Ir y buscar llaves primarias de la base de datos 
        public String ValFecha; // Nombres de la base de datos
        public int ValIdProductosArriendo; // Ir y buscar llaves primarias de la base de datos
        public int ValIdDetalleDelArriendo; // Ir y buscar llaves primarias de la base de datos
        public int ValIdValorUnitario; // Ir y buscar llaves primarias de la base de datos
        public String ValSubtotal; // Nombres de la base de datos
        public String ValDescuento; // Nombres de la base de datos
        public String ValIVA; // Nombres de la base de datos
        public String ValTotal;// Nombres de la base de datos

        public ECliente ValCliente; // Referencia Cliente
        public EProductosDelArriendo ValProductosDelArriendo; // Referencia Productos del Arriendo
        public EDetalleDelArriendo ValDetalleDelArriendo; // Referencia Detalle del Arriendo
        public EValorDelArriendo ValValorUnitario; // Referencia Valor del Arriendo
        public int IdArriendo // Asignar Id Arriendo
        {
            get { return ValIdArriendo; } // Asigna valor de las llaves primarias
            set { ValIdArriendo = value; }
        }
        public int IdCliente // Asignar Id Cliente
        {
            get { return ValIdCliente; } // Asigna valor de las llaves primarias
            set { ValIdCliente = value; }
        }
        public String Fecha // Asignar Fecha
        {
            get { return ValFecha; } // Asigna valor de la fecha
            set { ValFecha = value; }
        }
        public int IdProductosArriendo // Asignar Id Productos del Arriendo
        {
            get { return ValIdProductosArriendo; } // Asigna valor de las llaves primarias
            set { ValIdProductosArriendo = value; }
        }
        public int IdDetalleDelArriendo // Asignar Id Detalle del Arriendo
        {
            get { return ValIdDetalleDelArriendo; } // Asigna valor de las llaves primarias
            set { ValIdDetalleDelArriendo = value; }
        }
        public int IdValorUnitario // Asignar Id Valor Unitario
        {
            get { return ValIdValorUnitario; } // Asigna valor de las llaves primarias
            set { ValIdValorUnitario = value; }
        }
        public String Subtotal // Asignar Subtotal
        {
            get { return ValSubtotal; } // Asigna valor del subtotal
            set { ValSubtotal = value; }
        }
        public String Descuento // Asignar Descuento
        {
            get { return ValDescuento; } // Asigna valor del descuento
            set { ValDescuento = value; }
        }
        public String IVA // Asignar IVA
        {
            get { return ValIVA; } // Asigna valor del IVA
            set { ValIVA = value; }
        }
        public String Total // Asignar Total
        {
            get { return ValTotal; } // Asigna valor del total
            set { ValTotal = value; }
        }
        public ECliente Cliente // Asignar Cliente
        {
            get { return ValCliente; } // Referencia a Cliente
            set { ValCliente = value; }
        }
        public EProductosDelArriendo ProductosDelArriendo // Asignar Productos del Arriendo
        {
            get { return ValProductosDelArriendo; } // Referencia a Productos del Arriendo
            set { ValProductosDelArriendo = value; }
        }
        public EDetalleDelArriendo DetalleDelArriendo // Asignar Detalle del Arriendo
        {
            get { return ValDetalleDelArriendo; } // Referencia a Detalle del Arriendo
            set { ValDetalleDelArriendo = value; }
        }
        public EValorDelArriendo ValorUnitario // Asignar Valor Unitario
        {
            get { return ValValorUnitario; } // Referencia Valor Unitario
            set { ValValorUnitario = value; }
        }
    }
}