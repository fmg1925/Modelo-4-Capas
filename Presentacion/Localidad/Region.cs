using Entidad;
using Negocio;
using Presentacion.AAClases;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Presentacion.Localidad
{
    public partial class Region : Form // Formulario región
    {
        ERegion Ent = new ERegion(); // Entidad región 
        NRegion Neg = new NRegion(); // Negocio región
        public Region() // Iniciar componente
        {
            InitializeComponent();
        }

        private void Region_Load(object sender, EventArgs e)
        {
            CarDat(); // Al iniciar cargar datos
        }
        public void CarDat() // Cargar datos
        {
            try
            {
                RegionComboBox.Items.Clear();
                List<ERegion> Listar = new NRegion().Listar(); // Listar regiones
                foreach (ERegion item in Listar) // Por cada región
                {
                    RegionComboBox.Items.Add(new Filtrar() { Valor = item.IdRegion, Texto = item.Nombre }); // Añadir al combobox
                }
            }
            catch (Exception ex) // En caso de error
            {
                MessageBox.Show(ex.Message); // Reclamar
            }

            RegionComboBox.DisplayMember = "Texto";
            RegionComboBox.ValueMember = "Valor";
            try // Intentar
            {
                RegionComboBox.SelectedIndex = 0; // Seleccionar primer objeto del combo box
            }
            catch (Exception) // En caso de error
            {
                // No hacer nada
            }
            try
            {
                Grilla.Rows.Clear();
                List<ERegion> Listar = new NRegion().Listar(); // Listar regiones
                foreach (ERegion item in Listar)
                {
                    Grilla.Rows.Add(new object[] { "", item.Nombre, item.IdRegion}); // Añadir regiones a la grilla
                }
            }
            catch (Exception ex) // En caso de error
            {
                MessageBox.Show(ex.Message); // Reclamar
            }
            Grilla.ClearSelection();
        }
        public void Validar() // Validar texto
        {
            if (IngresarTextBox.Text.Trim() != "") // Si no está vacío
            {
                Ingresar.Enabled = true; // Habilitar ingresar modificar y eliminar
                Modificar.Enabled = true;
                Eliminar.Enabled = true;
            }
            else // Si no
            {
                Ingresar.Enabled = false; // Deshabilitar ingresar modificar y eliminar
                Modificar.Enabled = false;
                Eliminar.Enabled = false;
            }
        }
        public void ResetGrid() // Hacer filas visibles en la grilla
        {
            foreach (DataGridViewRow row in Grilla.Rows)
            {
                row.Visible = true;
            }
        }
        public void Check_funciones() // Reiniciar checks
        {
            IngresarCheck.CheckState = CheckState.Unchecked;
            ModificarCheck.CheckState = CheckState.Unchecked;
            EliminarCheck.CheckState = CheckState.Unchecked;
            IngresarCheck.Enabled = true;
            ModificarCheck.Enabled = false;
            EliminarCheck.Enabled = false;
        }

        private void Buscar_Click(object sender, EventArgs e) // Buscar
        {
            if (RegionComboBox.Items.Count == 0) { return; }
            if (Grilla.Rows.Count > 0) // Si hay filas en la grilla
            {
                foreach (DataGridViewRow row in Grilla.Rows) // Por cada fila
                {
                    if (row.Cells[1].Value.ToString().Trim().ToUpper().Contains(BuscarTextBox.Text.Trim().ToUpper())) // Si la columna filtro incluye la búsqueda
                        row.Visible = true; // Hacer fila visible
                    else // Si no
                        row.Visible = false; // Hacer fila invisible
                }
            }
        }

        private void BuscarTextBox_TextChanged(object sender, EventArgs e) // Al cambiar texto en buscar
        {
            BuscarTextBox.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(BuscarTextBox.Text); // Hacer texto mayúsculas
            BuscarTextBox.SelectionStart = BuscarTextBox.Text.Length;
            Validar();
        }

        private void LimpiarBusqueda_Click(object sender, EventArgs e) // Al clickear limpiar búsqueda
        {
            BuscarTextBox.Text = ""; // Limpiar búsqueda
            CarDat(); // Cargar datos
        }

        private void IngresarCheck_CheckedChanged(object sender, EventArgs e) // Al cambiar check de ingresar
        {
            if (IngresarCheck.CheckState == CheckState.Checked) // Si está checkeado ingresar
            {
                ModificarCheck.CheckState = CheckState.Unchecked; // Descheckear otros
                EliminarCheck.CheckState = CheckState.Unchecked;
                LabelOperacion.Text = "Ingresar Región:";
                IngresarTextBox.Enabled = true;
                IngresarTextBox.Clear();
                IdTextBox.Clear();
                Ingresar.Visible = true;
            }
            else // Si no
            {
                LabelOperacion.Text = "";
                Ingresar.Visible = false; // Deshabilitar ingresar
            }
            Validar();
        }

        private void ModificarCheck_CheckedChanged(object sender, EventArgs e) // Al cambiar check de modificar
        {
            if (ModificarCheck.CheckState == CheckState.Checked) // Si está checkeado modificar
            {
                IngresarCheck.CheckState = CheckState.Unchecked; // Descheckear otros
                EliminarCheck.CheckState = CheckState.Unchecked;
                LabelOperacion.Text = "Actualizar Región:";
                IngresarTextBox.Enabled = true;
                Modificar.Visible = true;
            }
            else // Si no
            {
                LabelOperacion.Text = "";
                Modificar.Visible = false; // Deshabilitar modificar
            }
            Validar(); // Validar
        }

        private void EliminarCheck_CheckedChanged(object sender, EventArgs e) // Al cambiar check de eliminar
        {
            if (EliminarCheck.CheckState == CheckState.Checked) // Si está checkeado eliminar
            {
                IngresarCheck.CheckState = CheckState.Unchecked; // Descheckear otros
                ModificarCheck.CheckState = CheckState.Unchecked;
                LabelOperacion.Text = "Eliminar Región:";
                IngresarTextBox.Enabled = false;
                Eliminar.Visible = true;
            }
            else
            {
                LabelOperacion.Text = "";
                Eliminar.Visible = false; // Deshabilitar eliminar
            }
            Validar();
        }

        private void IngresarTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en ingresar
        {
            if (char.IsDigit(e.KeyChar)) // Solo permitir letras
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IngresarTextBox_TextChanged(object sender, EventArgs e) // Al cambiar texto en ingresar
        {
            IngresarTextBox.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(IngresarTextBox.Text);
            IngresarTextBox.SelectionStart = IngresarTextBox.Text.Length;
            Validar(); // Validar
        }

        private void RegionComboBox_SelectedIndexChanged(object sender, EventArgs e) // Al cambiar valor del región combo box
        {
            Validar(); // Validar
        }

        private void Eliminar_Click(object sender, EventArgs e) // Eliminar
        {
            var res = MessageBox.Show("¿Está seguro de la acción a realizar?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // Mostrar confirmación
            if (res == DialogResult.Yes)
            {
                int Id;
                if (int.TryParse(IdTextBox.Text, out Id)) // Conseguir Id del textbox
                {
                    Respuesta<bool> resultado = NRegion.Eliminar(Id); // Eliminar región
                    if (resultado.Estado)
                    {
                        MessageBox.Show("La eliminación se realizó correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar.PerformClick();
                    }
                    else // Si no
                    {
                        MessageBox.Show("No se pudo eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Reclamar
                    }
                }
                else // Id inválida
                {
                    MessageBox.Show("Seleccione un registro válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); // Reclamar
                }
            }
            else if (res == DialogResult.No) // Si se elige no
            {
                Volver.Focus(); // Enfocar botón de volver
            }
            else if (res == DialogResult.Cancel) // Si se elige cancelar
            {
                Salir.Focus(); // Enfocar botón de salir
            }
            Grilla.Rows.Clear(); // Limpiar grilla
            CarDat(); // Cargar datos
        }

        private void Limpiar_Click(object sender, EventArgs e) // Al clickear limpiar
        {
            IdTextBox.Clear(); // Limpiar todo
            IngresarTextBox.Clear();
            IngresarTextBox.Enabled = false;
            BuscarTextBox.Text = "";
            IngresarTextBox.Enabled = false;
            ResetGrid();
            Check_funciones();
            CarDat(); // Cargar datos
            Validar(); // Validar
        }

        private void Volver_Click(object sender, EventArgs e) // Al clickear volver
        {
            this.Close(); // Cerrar formulario región
        }

        private void Salir_Click(object sender, EventArgs e) // Al clickear salir
        {
            System.Windows.Forms.Application.Exit(); // Cerrar aplicación
        }

        private void Ingresar_Click_1(object sender, EventArgs e) // Al clickear ingresar
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // Mostrar confirmación
            Ent.Nombre = IngresarTextBox.Text;
            if (res == DialogResult.Yes)
            {
                Respuesta<bool> resultado = NRegion.Ingresar(Ent); // Ingresar región

                if (resultado.Estado)
                {
                    MessageBox.Show("Se ingresó la región de " + IngresarTextBox.Text, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar.PerformClick(); // Limpiar
                }
                else
                {
                    MessageBox.Show("Seleccione un registro valido", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information); // Reclamar
                }
            }
            else if (res == DialogResult.No) // Si se elige no
            {
                Volver.Focus(); // Enfocar botón de volver
            }
            else if (res == DialogResult.Cancel) // Si se elige cancelar
            {
                Salir.Focus(); // Enfocar botón de salir
            }
            Grilla.Rows.Clear(); // Limpiar grilla
            CarDat(); // Cargar datos
        }

        private void Modificar_Click_1(object sender, EventArgs e) // Modificar
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // Mostrar confirmación
            Ent.IdRegion = Convert.ToInt32(IdTextBox.Text);
            Ent.Nombre = IngresarTextBox.Text;
            if (res == DialogResult.Yes)
            {
                Respuesta<bool> resultado = NRegion.Actualizar(Ent); // Actualizar región
                if (resultado.Estado)
                {
                    MessageBox.Show("Actualización fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar.PerformClick(); // Limpiar
                }
                else // Si no se actualizó
                {
                    MessageBox.Show("Seleccione un registro valido", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information); // Reclamar
                }
            }
            else if (res == DialogResult.No) // Si se elige no
            {
                Volver.Focus(); // Enfocar botón de volver
            }
            else if (res == DialogResult.Cancel) // Si se elige cancelar
            {
                Salir.Focus(); // Enfocar botón de salir
            }
            Grilla.Rows.Clear(); // Limpiar grilla
            CarDat(); // Cargar datos
        }

        private void Grilla_DoubleClick_1(object sender, EventArgs e) // Al hacer doble click en la grilla
        {
            IdTextBox.Clear(); // Limpiar datos y reiniciar checks
            IngresarTextBox.Clear();
            ModificarCheck.Enabled = true;
            EliminarCheck.Enabled = true;
            IngresarCheck.CheckState = CheckState.Unchecked;
            IngresarCheck.Enabled = false;
            ModificarCheck.CheckState = CheckState.Unchecked;
            EliminarCheck.CheckState = CheckState.Unchecked;
            IdTextBox.Text = this.Grilla.CurrentRow.Cells[2].Value.ToString(); // Id es igual al valor de la región
            IngresarTextBox.Text = this.Grilla.CurrentRow.Cells[1].Value.ToString(); // Texto es igual al nombre de la región
        }

        private void BuscarTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en buscar
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void IngresarTextBox_KeyPress_1(object sender, KeyPressEventArgs e) // Al presionar tecla en ingresar
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }
    }
}
