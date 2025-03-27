using Negocio;
using Entidad;
using System;
using System.Windows.Forms;

namespace Presentacion.Productos
{
    public partial class Productos_Ingresar : Form
    {
        EProductos Ent = new EProductos(); // Entidad Productos
        public Productos_Ingresar() // Iniciar formulario
        {
            InitializeComponent();
        }

        private void Limpiar_Click(object sender, EventArgs e) // Al clickear limpiar
        {
            NombreTextBox.Text = ""; // Limpiar valores
            FechaTextBox.Text = "";
            CantidadInicialTextBox.Text = "";
            CantidadActualTextBox.Text = "";
            CantidadArrendadaTextBox.Text = "";
            TotalActualTextBox.Text = "";
            ValorArriendoPorUnidadTextBox.Text = "";
        }

        private void Volver_Click(object sender, EventArgs e) // Al clickear volver
        {
            this.Close(); // Cerrar formulario productos
        }

        private void Salir_Click(object sender, EventArgs e) // Al clickear salir
        {
            System.Windows.Forms.Application.Exit(); // Cerrar aplicación
        }

        private void Validar() // Función validar
        {
            if (NombreTextBox.Text.Trim() == "" && FechaTextBox.Text.Trim() == "" && CantidadInicialTextBox.Text.Trim() == "" && CantidadArrendadaTextBox.Text.Trim() == "" && TotalActualTextBox.Text.Trim() == "" && ValorArriendoPorUnidadTextBox.Text.Trim() == "" && CantidadActualTextBox.Text.Trim() == "") // Si los textos están vacíos
            {
                IngresarButton.Enabled = false; // Deshabilitar ingresar y limpiar
                Limpiar.Enabled = false;
                return; // Terminar función
            }
            else // Si no
            {
                Limpiar.Enabled = true; // Habilitar limpiar
            }
            if (NombreTextBox.Text.Trim() != "" && FechaTextBox.Text.Trim() != "" && CantidadInicialTextBox.Text.Trim() != "" && CantidadArrendadaTextBox.Text.Trim() != "" && TotalActualTextBox.Text.Trim() != "" && ValorArriendoPorUnidadTextBox.Text.Trim() != "" && CantidadActualTextBox.Text.Trim() != "") // Si los textos no están vacíos
            {
                IngresarButton.Enabled = true; // Habilitar botón limpiar
            }
        }
        private void NombreTextBox_TextChanged(object sender, EventArgs e) // Al cambiar nombre
        {
            Validar(); // Validar
        }

        private void FechaTextBox_TextChanged(object sender, EventArgs e) // Al cambiar fecha
        {
            Validar(); // Validar
        }

        private void CantidadInicialTextBox_TextChanged(object sender, EventArgs e) // Al cambiar cantidad inicial
        {
            Validar(); // Validar
        }

        private void CantidadActualTextBox_TextChanged(object sender, EventArgs e) // Al cambiar cantidad actual
        {
            Validar(); // Validar
        }

        private void CantidadArrendadaTextBox_TextChanged(object sender, EventArgs e) // Al cambiar cantidad arrendada
        {
            Validar(); // Validar
        }

        private void TotalActualTextBox_TextChanged(object sender, EventArgs e) // Al cambiar total actual
        {
            Validar(); // Validar
        }

        private void ValorArriendoPorUnidadTextBox_TextChanged(object sender, EventArgs e) // Al cambiar valor
        {
            Validar(); // Validar
        }

        private void IngresarButton_Click(object sender, EventArgs e) // Al clickear ingresar
        {
            MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // Mostrar confirmación
            Ent.Nombre = NombreTextBox.Text; // Conseguir parámetros de los textboxes
            Ent.FechaIncorporacion = FechaTextBox.Text;
            Ent.CantidadInicial = CantidadInicialTextBox.Text;
            Ent.CantidadActual = CantidadActualTextBox.Text;
            Ent.CantidadArrendada = CantidadArrendadaTextBox.Text;
            Ent.TotalActual = TotalActualTextBox.Text;
            Ent.ValorArriendo = ValorArriendoPorUnidadTextBox.Text;
            Respuesta<bool> resultado = NProductos.Ingresar(Ent); // Ingresar Producto
            if (resultado.Estado) // Si se ingresó
            {
                MessageBox.Show("Ingreso fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mostrar confirmación
                Limpiar.PerformClick(); // Limpiar
            }
            else // Si no
            {
                MessageBox.Show("Ingreso fallido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Reclamar
            }
        }

        private void CantidadInicialTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // Si no es dígito o de control
            {
                e.Handled = true; // Interrumpir evento
                MessageBox.Show("Solo se permiten números.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensaje solo permitido números
            }
        }

        private void CantidadActualTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // Si no es dígito o de control
            {
                e.Handled = true; // Interrumpir evento
                MessageBox.Show("Solo se permiten números.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensaje solo permitido números
            }
        }

        private void CantidadArrendadaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // Si no es dígito o de control
            {
                e.Handled = true; // Interrumpir evento
                MessageBox.Show("Solo se permiten números.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensaje solo permitido números
            }
        }

        private void TotalActualTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // Si no es dígito o de control
            {
                e.Handled = true; // Interrumpir evento
                MessageBox.Show("Solo se permiten números.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensaje solo permitido números
            }
        }

        private void ValorArriendoPorUnidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // Si no es dígito o de control
            {
                e.Handled = true; // Interrumpir evento
                MessageBox.Show("Solo se permiten números.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensaje solo permitido números
            }
        }
    }
}
