using Negocio;
using Entidad;
using System;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace Presentacion.Productos
{
    public partial class Productos_Actualizar : Form
    {
        public Productos_Actualizar() // Iniciar formulario
        {
            InitializeComponent();
        }

        EProductos Ent = new EProductos(); // Entidad Productos
        private void ButMod_Click(object sender, EventArgs e) // Al clickear modificar
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // Mostrar comprobación
            Ent.IdProducto = Convert.ToInt32(TextIdProducto.Text); // Conseguir parámetros de los textboxes
            Ent.Nombre = NombreTextBox.Text;
            Ent.FechaIncorporacion = FechaTextBox.Text;
            Ent.CantidadInicial = CantidadInicialTextBox.Text;
            Ent.CantidadActual = CantidadActualTextBox.Text;
            Ent.CantidadArrendada = CantidadArrendadaTextBox.Text;
            Ent.TotalActual = TotalActualTextBox.Text;
            Ent.ValorArriendo = ValorArriendoPorUnidadTextBox.Text;
            if (res == DialogResult.Yes) // Al elegir sí
            {
                Respuesta<bool> resultado = NProductos.Actualizar(Ent); // Actualizar
                if (resultado.Estado) // Si se actualizó
                {
                    MessageBox.Show("Actualización fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextNombre.Text = NombreTextBox.Text; // Cambiar textboxes de valores antiguos
                    TextFecha.Text = FechaTextBox.Text;
                    TextCantidadInicial.Text = CantidadInicialTextBox.Text;
                    TextCantidadActual.Text = CantidadActualTextBox.Text;
                    TextCantidadArrendada.Text = CantidadArrendadaTextBox.Text;
                    TextTotalActual.Text = TotalActualTextBox.Text;
                    TextValor.Text = ValorArriendoPorUnidadTextBox.Text;
                    ButAnu.Enabled = false; // Deshabilitar anular y modificar
                    ButMod.Enabled = false;
                }
                else // Si no
                {
                    MessageBox.Show("No se puedo actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mostrar error
                }
            }
            else if (res == DialogResult.No) // Si se elige no
            {
                ButVol.Focus(); // Enfocar volver
            }
            else if (res == DialogResult.Cancel) // Si se elige cancelar
            {
                ButSal.Focus(); // Enfocar salir
            }
        }

        private void ButAnu_Click(object sender, EventArgs e) // Al clickear anular
        {
            NombreTextBox.Text = TextNombre.Text; // Devolver valores a los originales
            FechaTextBox.Text = TextFecha.Text;
            CantidadInicialTextBox.Text = TextCantidadInicial.Text;
            CantidadActualTextBox.Text = TextCantidadActual.Text;
            CantidadArrendadaTextBox.Text = TextCantidadArrendada.Text;
            TotalActualTextBox.Text = TextTotalActual.Text;
            ValorArriendoPorUnidadTextBox.Text = TextValor.Text;
        }

        private void ButVol_Click(object sender, EventArgs e) // Al clickear volver
        {
            this.Close(); // Cerrar formulario
        }

        private void ButSal_Click(object sender, EventArgs e) // Al clickear salir
        {
            Application.Exit(); // Cerrar aplicación
        }

        private void Validar()
        {
            if (NombreTextBox.Text.Trim() == TextNombre.Text && FechaTextBox.Text.Trim() == TextFecha.Text && CantidadInicialTextBox.Text.Trim() == TextCantidadInicial.Text && CantidadActualTextBox.Text == TextCantidadActual.Text && CantidadArrendadaTextBox.Text.Trim() == TextCantidadArrendada.Text && TotalActualTextBox.Text.Trim() == TextTotalActual.Text && ValorArriendoPorUnidadTextBox.Text.Trim() == TextValor.Text) // Si los textos son iguales a los anteriores
            {
                ButMod.Enabled = false; // Deshabilitar modificar y anular
                ButAnu.Enabled = false;
            }
            else // Si no
            {
                ButMod.Enabled = true; // Habilitar modificar y anular
                ButAnu.Enabled = true;
            }
            if (NombreTextBox.Text.Trim() == "" || FechaTextBox.Text.Trim() == "" || CantidadInicialTextBox.Text.Trim() == "" || CantidadActualTextBox.Text.Trim() == "" || CantidadArrendadaTextBox.Text.Trim() == "" || TotalActualTextBox.Text.Trim() == "" || ValorArriendoPorUnidadTextBox.Text.Trim() == "") // Si algún texto está vacío
            {
                ButMod.Enabled = false; // Deshabilitar modificar
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
