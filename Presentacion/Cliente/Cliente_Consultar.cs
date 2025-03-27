using Entidad;
using Negocio;
using Presentacion.AAClases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace Presentacion.Cliente
{
    public partial class Cliente_Consultar : Form
    {
        public Cliente_Consultar() // Iniciar formulario
        {
            InitializeComponent();
        }

        private void Cliente_Consultar_Load(object sender, EventArgs e) // Al cargar formulario
        {
            foreach (DataGridViewColumn columna in Grilla.Columns) // Por cada columna de la grilla
            {

                if (columna.Visible == true && columna.Name != "Selec") // Si es columna visible
                {
                    ComboBus.Items.Add(new Filtrar() { Valor = columna.Name, Texto = columna.HeaderText }); // Añadir al combobox de búsqueda
                }
            }
            ComboBus.DisplayMember = "Texto";
            ComboBus.ValueMember = "Valor";
            ComboBus.SelectedIndex = 0;
            CarDat(); // Cargar datos
        }

        public void CarDat() // Cargar datos
        {
            try
            {
                Grilla.Rows.Clear(); // Limpiar grilla
                List<ECliente> Listar = new NCliente().Listar(); 
                foreach (ECliente item in Listar) // Por cada cliente añadir a la grilla
                {
                    Grilla.Rows.Add(new object[] { "", item.IdCliente, item.Nombre, item.Rut, item.IdComuna, item.Comuna.Nombre, item.Direccion, item.Telefono, item.Email, item.Giro});
                }
            }
            catch (Exception ex) // En caso de error reclamar
            {
                MessageBox.Show(ex.Message);
            }
            Grilla.ClearSelection(); // Deseleccionar grilla
        }

        private void TextBus_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en la búsqueda
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void TextBus_TextChanged(object sender, EventArgs e) // Al cambiar texto en búsqueda
        {
            TextBus.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TextBus.Text); // Empezar con mayúscula
            TextBus.SelectionStart = TextBus.Text.Length;
        }

        private void ButBus_Click(object sender, EventArgs e) // Al clickear buscar
        {
            string columnaFiltro = ((Filtrar)ComboBus.SelectedItem).Valor.ToString(); // Usando el filtro
            if (Grilla.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Grilla.Rows) // Por cada fila de la grilla
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(TextBus.Text.Trim().ToUpper())) // Si está el nombre
                        row.Visible = true; // Mostrar fila
                    else // Si no
                        row.Visible = false; // Ocultar fila
                }
            }
        }

        private void ButLimBus_Click(object sender, EventArgs e) // Al clickear Limpiar búsqueda
        {
            TextBus.Text = ""; // Limpiar búsqueda
            CarDat(); // Cargar datos
        }

        private void Grilla_DoubleClick(object sender, EventArgs e) // Al hacer doble click en la grilla
        {
            ButMod.Enabled = true; // Habilitar modificar y eliminar
            ButEli.Enabled = true;
            TextBox1.Text = this.Grilla.CurrentRow.Cells[1].Value.ToString(); // Asignar id al textbox oculto
        }

        private void ButMod_Click(object sender, EventArgs e) // Al clickear actualizar
        {
            Cliente_Actualizar pasar = new Cliente_Actualizar(); // Crear formulario y pasar los parámetros de la grilla
            pasar.TextIdCliente.Text = this.Grilla.CurrentRow.Cells[1].Value.ToString();
            pasar.Nombre.Text = this.Grilla.CurrentRow.Cells[2].Value.ToString();
            pasar.TextNombre.Text = this.Grilla.CurrentRow.Cells[2].Value.ToString();
            pasar.RutT.Text = this.Grilla.CurrentRow.Cells[3].Value.ToString();
            pasar.RutActual.Text = this.Grilla.CurrentRow.Cells[3].Value.ToString();
            pasar.TextIdComuna.Text = this.Grilla.CurrentRow.Cells[4].Value.ToString();
            pasar.TextComuna.Text = this.Grilla.CurrentRow.Cells[5].Value.ToString();
            pasar.ComunaActual.Text = this.Grilla.CurrentRow.Cells[5].Value.ToString();
            pasar.Direccion.Text = this.Grilla.CurrentRow.Cells[6].Value.ToString();
            pasar.TextDireccion.Text = this.Grilla.CurrentRow.Cells[6].Value.ToString();
            pasar.Telefono.Text = this.Grilla.CurrentRow.Cells[7].Value.ToString();
            pasar.TextTelefono.Text = this.Grilla.CurrentRow.Cells[7].Value.ToString();
            pasar.Email.Text = this.Grilla.CurrentRow.Cells[8].Value.ToString();
            pasar.TextEmail.Text = this.Grilla.CurrentRow.Cells[8].Value.ToString();
            pasar.Giro.Text = this.Grilla.CurrentRow.Cells[9].Value.ToString();
            pasar.TextGiro.Text = this.Grilla.CurrentRow.Cells[9].Value.ToString();
            pasar.RutActual.Text = this.Grilla.CurrentRow.Cells[3].Value.ToString();
            pasar.Show(); // Mostrar formulario
            ButMod.Enabled = false;
            ButEli.Enabled = false;
            this.Close(); // Cerrar este formulario
        }

        private void ButEli_Click(object sender, EventArgs e) // Al clickear eliminar
        {
            var res = MessageBox.Show("¿Está seguro de la acción a realizar?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // Mostrar comprobación
            if (res == DialogResult.Yes)
            {
                int Id;
                if (int.TryParse(TextBox1.Text, out Id))
                {
                    Respuesta<bool> resultado = NCliente.Eliminar(Id);
                    if (resultado.Estado) // Si se eliminó
                    {
                        MessageBox.Show("La eliminación se realizó correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Si no
                    {
                        MessageBox.Show("No se pudo eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else // Si no es válida la id
                {
                    MessageBox.Show("Seleccione un registro válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Grilla.Rows.Clear(); // Limpiar grilla
            CarDat(); // Cargar datos
        }

        private void ButVol_Click(object sender, EventArgs e) // Al clickear volver
        {
            this.Close(); // Cerrar formulario
        }

        private void ButSal_Click(object sender, EventArgs e) // Al clickear salir
        {
            Application.Exit(); // Cerrar aplicación
        }
    }
}
