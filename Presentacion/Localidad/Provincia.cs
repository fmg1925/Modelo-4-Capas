using Datos;
using Entidad;
using Negocio;
using Presentacion.AAClases;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Presentacion.Localidad// En el namespace de localidad en la presentación
{
    public partial class Provincia : Form // Formulario de Provincia
    {
        EProvincia Ent = new EProvincia(); // Asignar Entidad Provincia
        NProvincia Neg = new NProvincia(); // Asignar Negocio Provincia
        ERegion EntReg = new ERegion(); // Entidad región
        NRegion NegReg = new NRegion(); // Negocio región
        EComuna EntCom = new EComuna(); // Entidad comuna
        NComuna NegCom = new NComuna(); // Negocio comuna
        String NombreProvincia, NombreRegion;
        public Provincia()
        {
            InitializeComponent(); // Iniciar formulario
        }

        private void Provincia_Load(object sender, EventArgs e) // Al cargar el formulario
        {
            CarDat(); // Cargar datos
        }
        public void CarDat() // Cargar datos
        {
            try // Intentar
            {
                RegionComboBox.Items.Clear(); // Limpiar objetos del combobox
                List<ERegion> Listar = new NRegion().Listar(); // Listar regiones
                foreach (ERegion item in Listar) // Por cada región
                {
                    RegionComboBox.Items.Add(new Filtrar() { Valor = item.IdRegion, Texto = item.Nombre }); // Añadir región al combobox
                }
            }
            catch (Exception ex) // En caso de error
            {
                MessageBox.Show(ex.Message); // Mostrar error
            }

            RegionComboBox.DisplayMember = "Texto"; // Asignar nombre
            RegionComboBox.ValueMember = "Valor"; // Asignar id
            try // Intentar
            {
                RegionComboBox.SelectedIndex = 0; // Seleccionar primer índice del combobox
            }
            catch (Exception) // En caso de error
            {
                // No hacer nada
            }
            try // Intentar
            {
                ProvinciaComboBox.Items.Clear(); // Limpiar objetos del combobox
                List<EProvincia> Listar = new NProvincia().Listar(); // Listar regiones
                foreach (EProvincia item in Listar) // Por cada región
                {
                    ProvinciaComboBox.Items.Add(new Filtrar() { Valor = item.IdProvincia, Texto = item.Nombre }); // Añadir región al combobox
                }
            }
            catch (Exception ex) // En caso de error
            {
                MessageBox.Show(ex.Message); // Mostrar error
            }
            ProvinciaComboBox.DisplayMember = "Texto"; // Asignar nombre
            ProvinciaComboBox.ValueMember = "Valor"; // Asignar id
            try // Intentar
            {
                ProvinciaComboBox.SelectedIndex = 0; // Seleccionar primer índice del combobox
            }
            catch (Exception) // En caso de error
            {
                // No hacer nada
            }
            try // Intentar
            {
                Grilla.Rows.Clear(); // Limpiar grilla
                List<EProvincia> Listar = new NProvincia().Listar(); // Listar provincias
                foreach (EProvincia item in Listar) // Por cada provincia
                {
                    Grilla.Rows.Add(new object[] { "", item.Nombre, item.IdRegion, item.IdProvincia, item.Region.Nombre }); // Añadir provincia a la grilla
                }
            }
            catch (Exception ex) // En caso de error
            {
                MessageBox.Show(ex.Message); // Mostrar error
            }
            Grilla.ClearSelection(); // Limpiar selección de grilla
        }
        public void Validar() // Validar
        {
            if (IngresarTextBox.Text.Trim() != "") // Si hay texto
            {
                Ingresar.Enabled = true; // Habilitar botón de ingresar
                Modificar.Enabled = true; // Habilitar botón de modificar
                Eliminar.Enabled = true; // Habilitar botón de eliminar
                IngresarRegion.Enabled = true; // Habilitar botón ingresar región
                IngresarComuna.Enabled = true; // Habilitar botón ingresar comuna
            }
            else // Si no
            {
                Ingresar.Enabled = false; // Deshabilitar botón de ingresar
                Modificar.Enabled = false; // Deshabilitar botón de modificar
                Eliminar.Enabled = false; // Deshabilitar botón de eliminar
                IngresarRegion.Enabled = false; // Deshabilitar botón ingresar región
                IngresarComuna.Enabled = false; // Deshabilitar botón ingresar comuna
            }
        }
        public void ResetGrid() // Reiniciar grilla
        {
            foreach (DataGridViewRow row in Grilla.Rows) // Por cada fila
            {
                row.Visible = true; // Hacer fila visible
            }
        }
        public void Check_funciones() // Checkear funciones
        {
            IngresarCheck.CheckState = CheckState.Unchecked; // Descheckear ingresar
            ModificarCheck.CheckState = CheckState.Unchecked; // Descheckear modificar
            EliminarCheck.CheckState = CheckState.Unchecked; // Descheckear eliminar
            IngresarCheck.Enabled = true; // Habilitar check ingresar
            ModificarCheck.Enabled = false; // Deshabilitar check modificar
            EliminarCheck.Enabled = false; // Deshabilitar check eliminar
        }

        private void Buscar_Click(object sender, EventArgs e) // Al clickear buscar
        {
            if (RegionComboBox.Items.Count == 0) { return; }
            if (Grilla.Rows.Count > 0) // Si hay filas en la grilla
            {
                if (FiltrarPor.SelectedIndex == 0) // Buscar por provincia
                {
                    foreach (DataGridViewRow row in Grilla.Rows) // Por cada fila
                    {
                        if (row.Cells[1].Value.ToString().Trim().ToUpper().Contains(BuscarTextBox.Text.Trim().ToUpper())) // Si la columna filtro incluye la búsqueda
                            row.Visible = true; // Hacer fila visible
                        else // Si no
                            row.Visible = false; // Hacer fila invisible
                    }
                }
                else if (FiltrarPor.SelectedIndex == 1) // Buscar por región
                {
                    foreach (DataGridViewRow row in Grilla.Rows) // Por cada fila
                    {
                        if (row.Cells[4].Value.ToString().Trim().ToUpper().Contains(BuscarTextBox.Text.Trim().ToUpper())) // Si la columna filtro incluye la búsqueda
                            row.Visible = true; // Hacer fila visible
                        else // Si no
                            row.Visible = false; // Hacer fila invisible
                    }
                }
            }
        }

        private void BuscarTextBox_TextChanged(object sender, EventArgs e) // Al cambiar texto buscar
        {
            BuscarTextBox.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(BuscarTextBox.Text); // Poner texto en mayúsculas
            BuscarTextBox.SelectionStart = BuscarTextBox.Text.Length; // Poner selección al final
            Validar(); // Validar
        }

        private void LimpiarBusqueda_Click(object sender, EventArgs e) // Limpiar búsqueda
        {
            BuscarTextBox.Text = ""; // Limpiar búsqueda
            CarDat(); // Cargar datos
        }

        private void IngresarCheck_CheckedChanged(object sender, EventArgs e) // Al cambiarse check ingresar
        {
            if (IngresarCheck.CheckState == CheckState.Checked) // Si está checkeado
            {
                ModificarCheck.CheckState = CheckState.Unchecked; // Descheckear modificar
                EliminarCheck.CheckState = CheckState.Unchecked; // Descheckear eliminar
                LabelOperacion.Text = "Ingresar Provincia:"; // Cambiar texto label
                IngresarTextBox.Enabled = true; // Habilitar textbox ingresar
                IngresarTextBox.Clear(); // Limpiar textobox ingresar
                IdTextBox.Clear(); // Limpiar id
                Ingresar.Visible = true; // Hacer botón ingresar visible
            }
            else
            {
                LabelOperacion.Text = "";
                Ingresar.Visible = false;
            }
            Validar();
        }

        private void ModificarCheck_CheckedChanged(object sender, EventArgs e) // Si se cambia el check de modificar
        {
            if (ModificarCheck.CheckState == CheckState.Checked)
            {
                IngresarCheck.CheckState = CheckState.Unchecked;
                EliminarCheck.CheckState = CheckState.Unchecked;
                LabelOperacion.Text = "Actualizar Provincia:";
                IngresarTextBox.Enabled = true;
                Modificar.Visible = true;
            }
            else
            {
                LabelOperacion.Text = "";
                Modificar.Visible = false;
            }
            Validar();
        }

        private void EliminarCheck_CheckedChanged(object sender, EventArgs e) // Si se cambia el check de eliminar
        {
            if (EliminarCheck.CheckState == CheckState.Checked)
            {
                IngresarCheck.CheckState = CheckState.Unchecked;
                ModificarCheck.CheckState = CheckState.Unchecked;
                LabelOperacion.Text = "Eliminar Provincia:";
                IngresarTextBox.Enabled = false;
                Eliminar.Visible = true;
            }
            else
            {
                LabelOperacion.Text = "";
                Eliminar.Visible = false;
            }
            Validar();
        }

        private void IngresarTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en ingresar
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IngresarTextBox_TextChanged(object sender, EventArgs e) // Al cambiar texto en ingresar
        {
            IngresarTextBox.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(IngresarTextBox.Text); // Poner texto en mayúsculas
            IngresarTextBox.SelectionStart = IngresarTextBox.Text.Length;
            Validar();
        }

        private void Eliminar_Click(object sender, EventArgs e) // Al clickear eliminar
        {
            var res = MessageBox.Show("¿Está seguro de la acción a realizar?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // Mostrar confirmación
            if (res == DialogResult.Yes)
            {
                int Id;
                if (int.TryParse(IdTextBox.Text, out Id))
                {
                    Respuesta<bool> resultado = NProvincia.Eliminar(Id); // Eliminar provincia
                    if (resultado.Estado)
                    {
                        MessageBox.Show("La eliminación se realizó correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un registro válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (res == DialogResult.No)
            {
                Volver.Focus();
            }
            else if (res == DialogResult.Cancel)
            {
                Salir.Focus();
            }
            Grilla.Rows.Clear();
            CarDat();
        }

        private void Limpiar_Click(object sender, EventArgs e) // Al clickear limpiar
        {
            IdTextBox.Clear(); // Limpiar todo y cargar datos
            IngresarTextBox.Clear();
            IngresarTextBox.Enabled = false;
            BuscarTextBox.Text = "";
            IngresarTextBox.Enabled = false;
            ResetGrid();
            Check_funciones();
            CarDat();
            Validar();
        }

        private void Volver_Click(object sender, EventArgs e) // Al clickear volver
        {
            this.Close(); // Cerrar formulario provincia
        }

        private void Salir_Click(object sender, EventArgs e) // Al clickear salir
        {
            System.Windows.Forms.Application.Exit(); // Cerrar aplicación
        }

        private void Ingresar_Click(object sender, EventArgs e) // Al clickear ingresar
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            Ent.Nombre = IngresarTextBox.Text;
            Filtrar idRegion = (Filtrar)RegionComboBox.SelectedItem;
            if (idRegion != null)
            {
                Ent.IdRegion = Convert.ToInt32(idRegion.Valor);
            } else
            {
                MessageBox.Show("No hay regiones para ingresar una provincia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<ERegion> Listar = new NRegion().Listar(); // Listar provincias
            foreach (ERegion item in Listar) // Por cada provincia
            {
                if (item.IdRegion == Convert.ToInt32(idRegion.Valor))
                {
                    NombreRegion = item.Nombre.ToString();
                    break;
                }
            }
            if (res == DialogResult.Yes)
            {
                Respuesta<bool> resultado = NProvincia.Ingresar(Ent); // Ingresar provincia

                if (resultado.Estado)
                {
                    MessageBox.Show("Se ingresó la provincia de " + IngresarTextBox.Text + " de la región de " + NombreRegion, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Seleccione un registro valido", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (res == DialogResult.No)
            {
                Volver.Focus();
            }
            else if (res == DialogResult.Cancel)
            {
                Salir.Focus();
            }
            Grilla.Rows.Clear();
            CarDat();
        }

        private void Modificar_Click(object sender, EventArgs e) // Al clickear modificar
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            Ent.IdProvincia = Convert.ToInt32(IdTextBox.Text);
            Ent.Nombre = IngresarTextBox.Text;
            Filtrar idRegion = (Filtrar)RegionComboBox.SelectedItem;
            Ent.IdRegion = Convert.ToInt32(idRegion.Valor);
            if (res == DialogResult.Yes)
            {
                Respuesta<bool> resultado = NProvincia.Actualizar(Ent); // Actualizar provincia
                if (resultado.Estado)
                {
                    MessageBox.Show("Actualización fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Seleccione un registro valido", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (res == DialogResult.No)
            {
                Volver.Focus();
            }
            else if (res == DialogResult.Cancel)
            {
                Salir.Focus();
            }
            Grilla.Rows.Clear();
            CarDat();
        }

        private void Grilla_DoubleClick(object sender, EventArgs e) // Al hacer doble click en la grilla
        {
            IdTextBox.Clear(); // Limpiar datos y descheckear checkboxes
            IngresarTextBox.Clear();
            ModificarCheck.Enabled = true;
            EliminarCheck.Enabled = true;
            IngresarCheck.CheckState = CheckState.Unchecked;
            IngresarCheck.Enabled = false;
            ModificarCheck.CheckState = CheckState.Unchecked;
            EliminarCheck.CheckState = CheckState.Unchecked;
            IdTextBox.Text = this.Grilla.CurrentRow.Cells[3].Value.ToString(); // Cambiar id textbox
            int regionId = Convert.ToInt32(this.Grilla.CurrentRow.Cells[2].Value); // Conseguir id región del item de la grilla
            foreach (Filtrar item in RegionComboBox.Items)
            {
                if (Convert.ToInt32(item.Valor) == regionId)
                {
                    int index = RegionComboBox.Items.IndexOf(item);

                    if (index >= 0)
                    {
                        RegionComboBox.SelectedIndex = index; // Cambiar item combobox
                    }
                    break;
                }
            }
            IngresarTextBox.Text = this.Grilla.CurrentRow.Cells[1].Value.ToString(); // Texto es igual al nombre de la provincia
        }

        private void IngresarRegion_Click(object sender, EventArgs e) // Al clickear ingresar región
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            EntReg.Nombre = IngresarTextBox.Text;
            if (res == DialogResult.Yes)
            {
                Respuesta<bool> resultado = NRegion.Ingresar(EntReg); // Ingresar región

                if (resultado.Estado) // Si se ingresó
                {
                    MessageBox.Show("Se ingresó la región de " + IngresarTextBox.Text, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar.PerformClick();
                }
                else // Si no
                {
                    MessageBox.Show("Seleccione un registro valido", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (res == DialogResult.No)
            {
                Volver.Focus();
            }
            else if (res == DialogResult.Cancel)
            {
                Salir.Focus();
            }
            Grilla.Rows.Clear(); // Limpiar datos
            CarDat(); // Cargar datos
        }

        private void BuscarTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en buscar
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void IngresarTextBox_KeyPress_1(object sender, KeyPressEventArgs e) // Al presionar tecla en ingresar
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void IngresarComuna_Click(object sender, EventArgs e) // Al clickear ingresar comuna
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            EntCom.Nombre = IngresarTextBox.Text;
            Filtrar idProvincia = (Filtrar)ProvinciaComboBox.SelectedItem;
            if (idProvincia != null)
            {
                EntCom.IdProvincia = Convert.ToInt32(idProvincia.Valor);
            }
            else
            {
                MessageBox.Show("No hay provincias para ingresar una comuna.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<EProvincia> Listar = new NProvincia().Listar(); // Listar provincias
            foreach (EProvincia item in Listar) // Por cada provincia
            {
                if (item.IdProvincia == Convert.ToInt32(idProvincia.Valor))
                {
                    EntCom.IdRegion = item.IdRegion;
                    NombreProvincia = item.Nombre;
                    NombreRegion = item.Region.Nombre.ToString();
                    break;
                }
            }
            if (res == DialogResult.Yes)
            {
                Respuesta<bool> resultado = NComuna.Ingresar(EntCom); // Ingresar comuna

                if (resultado.Estado) // Si se ingresó
                {
                    MessageBox.Show("Se ingresó la comuna " + IngresarTextBox.Text + " de la provincia " + NombreProvincia + " de la región de " + NombreRegion, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar.PerformClick();
                }
                else // Si no
                {
                    MessageBox.Show("Seleccione un registro valido", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (res == DialogResult.No)
            {
                Volver.Focus();
            }
            else if (res == DialogResult.Cancel)
            {
                Salir.Focus();
            }
            CarDat(); // Cargar datos
        }
    }
}
