using Datos;
using Entidad;
using Negocio;
using Presentacion.AAClases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Presentacion.Localidad // En el namespace de localidad en la presentación
{
    public partial class Comuna : Form // Formulario clase comuna
    {
        EComuna Ent = new EComuna(); // Entidad comuna
        NComuna Neg = new NComuna(); // Negocio comuna
        EProvincia EntPro = new EProvincia(); // Entidad provincia
        NProvincia NegPro = new NProvincia(); // Negocio provincia
        ERegion EntReg = new ERegion(); // Entidad región
        NRegion NegReg = new NRegion(); // Negocio región
        String NombreProvincia, NombreRegion;

        public Comuna()
        {
            InitializeComponent(); // Iniciar componente
        }
        private void Comuna_Load(object sender, EventArgs e) // Al cargar el formulario
        {
            CarDat(); // Cargar datos
        }
        public void CarDat() // Cargar datos
        {
            try // Intentar
            {
                RegionComboBox.Items.Clear(); // Vaciar combobox
                List<ERegion> Listar = new NRegion().Listar(); // Listar objetos de regiones
                foreach (ERegion item in Listar) // Por cada región
                {
                    RegionComboBox.Items.Add(new Filtrar() { Valor = item.IdRegion, Texto = item.Nombre }); // Añadir regiones al combobox
                }
            }
            catch (Exception ex) // En caso de error
            {
                MessageBox.Show(ex.Message); // Mostrar mensaje de error
            }

            RegionComboBox.DisplayMember = "Texto"; // Mostar nombre de la región
            RegionComboBox.ValueMember = "Valor"; // IdProvincia = Valor
            try // Intentar
            {
                RegionComboBox.SelectedIndex = 0; // Índice del combobox es el primer objeto
            }
            catch (Exception) // En caso de error
            {
                // No hacer nada
            }
            try // Intentar
            {
                ProvinciaComboBox.Items.Clear(); // Vaciar combobox
                List<EProvincia> Listar = new NProvincia().Listar(); // Listar objetos de provincia
                foreach (EProvincia item in Listar)
                {
                    ProvinciaComboBox.Items.Add(new Filtrar() { Valor = item.IdProvincia, Texto = item.Nombre }); // Añadir provincias al combobox
                }
            }
            catch (Exception ex) // En caso de error
            {
                MessageBox.Show(ex.Message); // Mostrar mensaje de error
            }

            ProvinciaComboBox.DisplayMember = "Texto"; // Mostrar nombre de la provincia
            try
            {
                ProvinciaComboBox.ValueMember = "Valor"; // IdProvincia = Valor
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }
            try // Intentar
            {
                ProvinciaComboBox.SelectedIndex = 0; // Índice del combobox es el primer objeto
            }
            catch (Exception) // En caso de error
            {
                // No hacer nada
            }
            try // Intentar
            {
                Grilla.Rows.Clear(); // Vaciar grilla
                List<EComuna> Listar = new NComuna().Listar(); // Listar comunas
                foreach (EComuna item in Listar) // Por cada comuna
                {
                    Grilla.Rows.Add(new object[] { "", item.Nombre, item.IdProvincia, item.IdComuna, item.IdRegion, item.Provincia.Nombre, item.Region.Nombre }); // Añadir comunas a la grilla
                }
            }
            catch (Exception ex) // En caso de error
            {
                MessageBox.Show(ex.Message); // Mostrar mensaje de error
            }
            Grilla.ClearSelection(); // Limpiar selección de la grilla
        }
        public void Validar() // Función Validar
        {
            if (IngresarTextBox.Text.Trim() != "") // Si el texto no está vacío
            {
                Ingresar.Enabled = true; // Habilitar botón Ingresar
                Modificar.Enabled = true; // Habilitar botón Modificar
                Eliminar.Enabled = true; // Habilitar botón Eliminar
                IngresarProvincia.Enabled = true; // Habilitar botón ingresar provincia
                IngresarRegion.Enabled = true; // Habilitar botón ingresar región
            }
            else
            {
                Ingresar.Enabled = false; // Deshabilitar botón Ingresar
                Modificar.Enabled = false; // Deshabilitar botón Modificar
                Eliminar.Enabled = false; // Deshabilitar botón Eliminar
                IngresarProvincia.Enabled = false; // Deshabilitar botón ingresar provincia
                IngresarRegion.Enabled = false; // Deshabilitar botón ingresar región
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
            ModificarCheck.Enabled = false; // Habilitar check modificar
            EliminarCheck.Enabled = false; // Habilitar check eliminar
        }

        private void Buscar_Click(object sender, EventArgs e) // Al buscar
        {
            if (RegionComboBox.Items.Count == 0 || ProvinciaComboBox.Items.Count == 0) { return; }
            if (Grilla.Rows.Count > 0) // Si hay filas en la grilla
            {
                if (FiltrarPor.SelectedIndex == 0) // Buscar por comuna
                {
                    foreach (DataGridViewRow row in Grilla.Rows) // Por cada fila
                    {
                        if (row.Cells[1].Value.ToString().Trim().ToUpper().Contains(BuscarTextBox.Text.Trim().ToUpper())) // Si la columna filtro incluye la búsqueda
                            row.Visible = true; // Hacer fila visible
                        else // Si no
                            row.Visible = false; // Hacer fila invisible
                    }
                }
                else if (FiltrarPor.SelectedIndex == 1) // Buscar por provincia
                {
                    foreach (DataGridViewRow row in Grilla.Rows) // Por cada fila
                    {
                        if (row.Cells[5].Value.ToString().Trim().ToUpper().Contains(BuscarTextBox.Text.Trim().ToUpper())) // Si la columna filtro incluye la búsqueda
                            row.Visible = true; // Hacer fila visible
                        else // Si no
                            row.Visible = false; // Hacer fila invisible
                    }
                }
                else if (FiltrarPor.SelectedIndex == 2) // Buscar por región
                {
                    foreach (DataGridViewRow row in Grilla.Rows) // Por cada fila
                    {
                        if (row.Cells[6].Value.ToString().Trim().ToUpper().Contains(BuscarTextBox.Text.Trim().ToUpper())) // Si la columna filtro incluye la búsqueda
                            row.Visible = true; // Hacer fila visible
                        else // Si no
                            row.Visible = false; // Hacer fila invisible
                    }
                }
            }
        }

        private void BuscarTextBox_TextChanged(object sender, EventArgs e) // Al cambiar texto buscar
        {
            BuscarTextBox.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(BuscarTextBox.Text); // Primer letra mayúscula
            BuscarTextBox.SelectionStart = BuscarTextBox.Text.Length; // Selección inicia al final del texto
            Validar(); // Validar
        }

        private void LimpiarBusqueda_Click(object sender, EventArgs e) // Al clickear limpiar búsqueda
        {
            BuscarTextBox.Text = ""; // Limpiar búsqueda
            CarDat(); // Cargar datos
        }

        private void IngresarCheck_CheckedChanged(object sender, EventArgs e) // Cambio del check ingresar
        {
            if (IngresarCheck.CheckState == CheckState.Checked) // Si está checkeado
            {
                ModificarCheck.CheckState = CheckState.Unchecked; // Descheckear modificar
                EliminarCheck.CheckState = CheckState.Unchecked; // Descheckear eliminar
                LabelOperacion.Text = "Ingresar Comuna:"; // Cambiar texto label
                IngresarTextBox.Enabled = true; // Habilitar textbox ingresar
                IngresarTextBox.Clear(); // Limpiar textbox ingresar
                IdTextBox.Clear(); // Limpiar textbox id
                Ingresar.Visible = true; // Hacer visible botón ingresar
            }
            else // Si no
            {
                LabelOperacion.Text = ""; // Limpiar texto label
                Ingresar.Visible = false; // Hacer botón ingresar invisible
            }
            Validar(); // Validar
        }

        private void ModificarCheck_CheckedChanged(object sender, EventArgs e) // Cambio del check modificar
        {
            if (ModificarCheck.CheckState == CheckState.Checked) // Si está checkeado
            {
                IngresarCheck.CheckState = CheckState.Unchecked; // Descheckear ingresar
                EliminarCheck.CheckState = CheckState.Unchecked; // Descheckear eliminar
                LabelOperacion.Text = "Actualizar Comuna:"; // Cambiar texto label
                IngresarTextBox.Enabled = true; // Habilitar textbox ingresar
                Modificar.Visible = true; // Hacer visible botón modificar
            }
            else // Si no
            {
                LabelOperacion.Text = ""; // Limpiar texto label
                Modificar.Visible = false; // Hacer botón modificar invisible
            }
            Validar(); // Validar
        }

        private void EliminarCheck_CheckedChanged(object sender, EventArgs e) // Cambio del check eliminar
        {
            if (EliminarCheck.CheckState == CheckState.Checked) // Sí está checkeado
            {
                IngresarCheck.CheckState = CheckState.Unchecked; // Descheckear ingresar
                ModificarCheck.CheckState = CheckState.Unchecked; // Descheckear modificar
                LabelOperacion.Text = "Eliminar Comuna:"; // Cambiar texto label
                IngresarTextBox.Enabled = false; // Deshabilitar textbox ingresar
                Eliminar.Visible = true; // Hacer botón eliminar visible
            }
            else // Si no
            {
                LabelOperacion.Text = ""; // Limpiar texto label
                Eliminar.Visible = false; // Hacer botón eliminar invisible
            }
            Validar(); // Validar
        }

        private void IngresarTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en ingresar
        {
            if (char.IsDigit(e.KeyChar)) // Si es dígito
            {
                e.Handled = true; // Interrumpir evento
                MessageBox.Show("Solo se permiten letras.", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensaje solo permitido letras
            }
        }

        private void IngresarTextBox_TextChanged(object sender, EventArgs e) // Al cambiar texto en ingresar
        {
            IngresarTextBox.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(IngresarTextBox.Text); // Cambiar a mayúscula
            IngresarTextBox.SelectionStart = IngresarTextBox.Text.Length; // Selección empieza al final del texto
            Validar(); // Validar
        }

        private void Eliminar_Click(object sender, EventArgs e) // Al clickear eliminar
        {
            var res = MessageBox.Show("¿Está seguro de la acción a realizar?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // Mostrar confirmación
            if (res == DialogResult.Yes) // Si la respuesta es sí
            {
                int Id; // Definir id
                if (int.TryParse(IdTextBox.Text, out Id)) // Si hay id
                {
                    Respuesta<bool> resultado = NComuna.Eliminar(Id); // Eliminar comuna
                    if (resultado.Estado) // Si se eliminó
                    {
                        MessageBox.Show("La eliminación se realizó correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); // Eliminado
                        Limpiar.PerformClick(); // Limpiar
                    }
                    else // Si no
                    {
                        MessageBox.Show("No se pudo eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning); // No se pudo eliminar
                    }
                }
                else // Si no
                {
                    MessageBox.Show("Seleccione un registro válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); // No hay id
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

        private void Limpiar_Click(object sender, EventArgs e) // Al clickear impiar
        {
            IdTextBox.Clear(); // Limpiar id
            IngresarTextBox.Clear(); // Limpiar texto ingresar
            IngresarTextBox.Enabled = false; // Deshabilitar texto ingresar
            BuscarTextBox.Text = ""; // Limpiar búsqueda
            ResetGrid(); // Reiniciar grilla
            Check_funciones(); // Checkear funciones
            CarDat(); // Cargar datos
            Validar(); // Validar
        }

        private void Volver_Click(object sender, EventArgs e) // Al clickear volver
        {
            this.Close(); // Cerrar formulario
        }

        private void Salir_Click(object sender, EventArgs e) // Al clickear salir
        {
            System.Windows.Forms.Application.Exit(); // Cerrar programa
        }

        private void Ingresar_Click(object sender, EventArgs e) // Al clickear ingresar
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // Mostrar confirmación
            Ent.Nombre = IngresarTextBox.Text; // Nombre es el texto a ingresar
            Filtrar idProvincia = (Filtrar)ProvinciaComboBox.SelectedItem; // IdProvincia es el item seleccionado en el combobox
            if (res == DialogResult.Yes) // Si la confirmación es sí
            {
                if (idProvincia != null) // Si hay id provincia
                {
                    Ent.IdProvincia = Convert.ToInt32(idProvincia.Valor); // IdProvincia es igual al valor del combobox
                }
                else // Si no
                {
                    MessageBox.Show("No hay provincias para ingresar una comuna.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mostrar error
                    return; // Terminar función
                }
                List<EProvincia> Listar = new NProvincia().Listar(); // Listar provincias
                foreach (EProvincia item in Listar) // Por cada provincia
                {
                    if (item.IdProvincia == Convert.ToInt32(idProvincia.Valor))
                    {
                        Ent.IdRegion = item.IdRegion;
                        NombreProvincia = item.Nombre;
                        NombreRegion = item.Region.Nombre.ToString();
                        break;
                    }
                }
                Respuesta<bool> resultado = NComuna.Ingresar(Ent); // Ingresar comuna

                if (resultado.Estado) // Si se ingresó
                {
                    MessageBox.Show("Se ingresó la comuna de " + IngresarTextBox.Text + " de la provincia de " + NombreProvincia + " de la región de " + NombreRegion, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mostrar diálogo
                    Limpiar.PerformClick(); // Limpiar
                }
                else // Si no
                {
                    MessageBox.Show("Seleccione un registro valido", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mostrar error
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

        private void Modificar_Click(object sender, EventArgs e) // Al clickear modificar
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // Mostrar advertencia
            Ent.IdComuna = Convert.ToInt32(IdTextBox.Text); // Id comuna es igual a textbox Id
            Ent.Nombre = IngresarTextBox.Text; // Nombre es igual a textbox ingresar
            Filtrar idProvincia = (Filtrar)ProvinciaComboBox.SelectedItem; // id Provincia es igual a item seleccionado del combobox
            Ent.IdProvincia = Convert.ToInt32(idProvincia.Valor); // Asignar IdProvincia a el valor de idProvincia
            Filtrar idRegion = (Filtrar)RegionComboBox.SelectedItem; // IdRegion es el item seleccionado en el combobox
            Ent.IdRegion = Convert.ToInt32(this.Grilla.CurrentRow.Cells[4].Value); // IdRegion es igual al valor de la región de la provincia
            if (res == DialogResult.Yes) // Si se elige sí
            {
                Respuesta<bool> resultado = NComuna.Actualizar(Ent); // Actualizar
                if (resultado.Estado) // Si se actualiza
                {
                    MessageBox.Show("Actualización fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mostrar díalogo
                    Limpiar.PerformClick(); // Limpiar
                }
                else // Si no
                {
                    MessageBox.Show("Seleccione un registro valido", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mostrar error
                }
            }
            else if (res == DialogResult.No) // Si se elige no
            {
                Volver.Focus(); // Enfocar botón de volver
            }
            else if (res == DialogResult.Cancel) // Si se elige cancelar
            {
                Salir.Focus(); // Si se elige salir
            }
            Grilla.Rows.Clear(); // Limpiar grilla
            CarDat(); // Cargar datos
        }

        private void Grilla_DoubleClick(object sender, EventArgs e) // Al hacer doble click en la grilla
        {
            IdTextBox.Clear(); // Limpiar id
            IngresarTextBox.Clear(); // Limpiar texto ingresar
            ProvinciaComboBox.Items.Clear();
            ModificarCheck.Enabled = true; // Habilitar botón modificar
            EliminarCheck.Enabled = true; // Habilitar botón eliminar
            IngresarCheck.CheckState = CheckState.Unchecked; // Descheckear ingresar
            IngresarCheck.Enabled = false; // Deshabilitar ingresar
            ModificarCheck.CheckState = CheckState.Unchecked; // Descheckear modificar
            EliminarCheck.CheckState = CheckState.Unchecked; // Descheckear eliminar
            int provinciaId = Convert.ToInt32(this.Grilla.CurrentRow.Cells[2].Value); // provinciaId es igual al valor de la celda 3
            int regionId = Convert.ToInt32(this.Grilla.CurrentRow.Cells[4].Value); // regionId es igual al valor de la celda 3
            foreach (Filtrar item in RegionComboBox.Items) // Por cada item en el combobox
            {
                if (Convert.ToInt32(item.Valor) == regionId) // Si el id del item es la id de la provincia
                {
                    int index = RegionComboBox.Items.IndexOf(item); // índice es igual al item del combobox

                    if (index >= 0) // Si el índice es válido
                    {
                        RegionComboBox.SelectedIndex = index; // Asignar índice del combobox
                    }
                    break; // Romper ciclo
                }
            }
            List<EProvincia> Listar = new NProvincia().Listar(); // Listar objetos de provincia
            foreach (EProvincia item in Listar)
            {
                if (item.IdRegion == regionId)
                {
                    ProvinciaComboBox.Items.Add(new Filtrar() { Valor = item.IdProvincia, Texto = item.Nombre }); // Añadir provincias al combobox
                }
            }
            foreach (Filtrar item in ProvinciaComboBox.Items) // Por cada item en el combobox
            {
                if (Convert.ToInt32(item.Valor) == provinciaId) // Si el id del item es la id de la provincia
                {
                    int index = ProvinciaComboBox.Items.IndexOf(item); // índice es igual al item del combobox

                    if (index >= 0) // Si el índice es válido
                    {
                        ProvinciaComboBox.SelectedIndex = index; // Asignar índice del combobox
                    }
                    break; // Romper ciclo
                }
            }
            IdTextBox.Text = this.Grilla.CurrentRow.Cells[3].Value.ToString(); // Texto id es igual al valor de la celda 4
            IngresarTextBox.Text = this.Grilla.CurrentRow.Cells[1].Value.ToString(); // Texto ingresar es igual al valor de la celda 2
        }

        private void IngresarProvincia_Click(object sender, EventArgs e) // Ingresar provincia
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // Mostrar confirmación
            EntPro.Nombre = IngresarTextBox.Text; // Nombre es el texto a ingresar
            Filtrar idRegion = (Filtrar)RegionComboBox.SelectedItem; // IdRegion es el item seleccionado en el combobox
            if (res == DialogResult.Yes) // Si la confirmación es sí
            {
                if (idRegion != null) // Si hay id region
                {
                    EntPro.IdRegion = Convert.ToInt32(idRegion.Valor); // IdRegion es igual al valor del combobox
                }
                else // Si no
                {
                    MessageBox.Show("No hay regiones para ingresar una provincia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mostrar error
                    return; // Terminar función
                }
                List<ERegion> Listar = new NRegion().Listar(); // Listar regiones
                foreach (ERegion item in Listar) // Por cada región
                {
                    if (item.IdRegion == Convert.ToInt32(idRegion.Valor))
                    {
                        NombreRegion = item.Nombre.ToString();
                        break;
                    }
                }
                Respuesta<bool> resultado = NProvincia.Ingresar(EntPro); // Ingresar comuna

                if (resultado.Estado) // Si se ingresó
                {
                    MessageBox.Show("Se ingresó la provincia de " + IngresarTextBox.Text + " de la región de " + NombreRegion, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mostrar diálogo
                    Limpiar.PerformClick(); // Limpiar
                }
                else // Si no
                {
                    MessageBox.Show("Seleccione un registro valido", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mostrar error
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
        private void RegionComboBox_SelectedValueChanged(object sender, EventArgs e) // Al cambiar el valor de región combobox
        {
            ProvinciaComboBox.Items.Clear();
            Filtrar regionId = (Filtrar)RegionComboBox.SelectedItem;
            if (regionId == null) return;
            List<EProvincia> Listar = new NProvincia().Listar(); // Listar objetos de provincia
            foreach (EProvincia item in Listar)
            {
                if (item.IdRegion == Convert.ToInt32(regionId.Valor))
                {
                    ProvinciaComboBox.Items.Add(new Filtrar() { Valor = item.IdProvincia, Texto = item.Nombre }); // Añadir provincias al combobox
                }
            }
            ProvinciaComboBox.SelectedIndex = 0;
        }

        private void BuscarTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en buscar
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void IngresarTextBox_KeyPress_1(object sender, KeyPressEventArgs e) // Al presionar tecla en ingresar
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void IngresarRegion_Click(object sender, EventArgs e) // Ingresar región
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
    }
}
