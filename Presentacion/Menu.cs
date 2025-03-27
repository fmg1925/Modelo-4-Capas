//using Presentacion.Arriendo;
using Presentacion.Cliente;
//using Presentacion.Productos;
using Presentacion.Localidad;
using Presentacion.Proveedor;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Entidad;
using Negocio;
using System.Runtime.ConstrainedExecution;
using Presentacion.Productos;

namespace Presentacion
{
    public partial class Menu : Form // Formulario menú
    {
        private static ToolStripMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Menu() // Iniciar menú
        {
            InitializeComponent();
        }

        private void AbrirFormulario(ToolStripMenuItem menu, Form formulario) // Función para abrir formularios
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;
            panel1.Controls.Add(formulario);
            formulario.Show();
        }

        private void Region_Click(object sender, EventArgs e) // Abrir formulario región
        {
            AbrirFormulario((ToolStripMenuItem)sender, new Localidad.Region());
        }

        private void Provincia_Click(object sender, EventArgs e) // Abrir formulario provincia
        {
            AbrirFormulario((ToolStripMenuItem)sender, new Provincia());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) // Al clickear salir
        {
            System.Windows.Forms.Application.Exit(); // Cerrar aplicación
        }

        private void Comuna_Click(object sender, EventArgs e) // Abrir formulario comuna
        {
            AbrirFormulario((ToolStripMenuItem)sender, new Comuna());
        }

        private void IngresarProveedor_Click(object sender, EventArgs e) // Abrir formulario ingresar proveedor
        {
            AbrirFormulario((ToolStripMenuItem)sender, new Proveedor_Ingresar());
        }

        private void EliminarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor_Consultar ver = new Proveedor_Consultar();
            ver.ButEli.Visible = true;
            AbrirFormulario((ToolStripMenuItem)sender, ver);
        }

        private void ActualizarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor_Consultar ver = new Proveedor_Consultar();
            ver.ButMod.Visible = true;
            AbrirFormulario((ToolStripMenuItem)sender, ver);
        }

        private void IngresarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new Cliente_Ingresar());
        }

        private void ActualizarCliente_Click(object sender, EventArgs e)
        {
            Cliente_Consultar ver = new Cliente_Consultar();
            ver.ButMod.Visible = true;
            AbrirFormulario((ToolStripMenuItem)sender, ver);
        }

        private void EliminarCliente_Click(object sender, EventArgs e)
        {
            Cliente_Consultar ver = new Cliente_Consultar();
            ver.ButEli.Visible = true;
            AbrirFormulario((ToolStripMenuItem)sender, ver);
        }

        private void IngresarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new Productos_Ingresar());
        }

        private void ActualizarProductos_Click(object sender, EventArgs e)
        {
            Productos_Consultar ver = new Productos_Consultar();
            ver.ButMod.Visible = true;
            AbrirFormulario((ToolStripMenuItem)sender, ver);
        }

        private void EliminarProductos_Click(object sender, EventArgs e)
        {
            Productos_Consultar ver = new Productos_Consultar();
            ver.ButEli.Visible = true;
            AbrirFormulario((ToolStripMenuItem)sender, ver);
        }
    }
}
