using Entidad;
using Negocio;
using Presentacion.AAClases;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;
using System.Diagnostics;
using System.Collections.Generic;

namespace Presentacion.Cliente
{
    public partial class Cliente_Ingresar : Form
    {
        ValidaRut Rut = new ValidaRut(); // Clase validar rut
        ECliente Ent = new ECliente(); // Entidad Cliente
        NComuna NegCom = new NComuna(); // Negocio comuna
        NProvincia NegPro = new NProvincia(); // Negocio provincia
        NRegion NegReg = new NRegion(); // Negocio provincia

        public Cliente_Ingresar() // Iniciar componente
        {
            InitializeComponent();
        }

        public void LleComReg() // Llenar combo box región
        {
            RegionComboBox.DisplayMember = "Nombre";
            RegionComboBox.ValueMember = "IdRegion";
            RegionComboBox.DataSource = NegReg.Listar();
            RegionComboBox.SelectionStart = RegionComboBox.Text.Length; // Deseleccionar texto
            RegionComboBox.SelectionLength = 0;
        }

        private void CargaProvinciaComboBox() // Cargar datos en provincia combo box
        {
            int IdRegion = Convert.ToInt32(RegionComboBox.SelectedValue);
            DataTable dt = NegPro.Filtrar(IdRegion);
            ProvinciaComboBox.DisplayMember = "Nombre";
            ProvinciaComboBox.ValueMember = "IdProvincia";
            ProvinciaComboBox.DataSource = dt;
            ProvinciaComboBox.SelectionStart = ProvinciaComboBox.Text.Length; // Deseleccionar texto
            ProvinciaComboBox.SelectionLength = 0;
        }

        private void CargaComunaComboBox() // Cargar datos en comuna combo box
        {
            int IdProvincia = Convert.ToInt32(ProvinciaComboBox.SelectedValue);
            DataTable dt = NegCom.Filtrar(IdProvincia);
            ComunaComboBox.DisplayMember = "Nombre";
            ComunaComboBox.ValueMember = "IdComuna";
            ComunaComboBox.DataSource = dt;
            ComunaComboBox.SelectionStart = ComunaComboBox.Text.Length; // Deseleccionar texto
            ComunaComboBox.SelectionLength = 0;
        }

        public void HabBotIng() // Habilitar botón de ingresar
        {
            if ((RutTextBox.Text.Trim() != "") && (NombreTextBox.Text.Trim() != "") && (RegionComboBox.Text.Trim() != "") && (ProvinciaComboBox.Text.Trim() != "") && (ComunaComboBox.Text.Trim() != "") && (DireccionTextBox.Text.Trim() != "") && (TelefonoTextBox.Text.Trim() != "") && (EmailTextBox.Text.Trim() != "") && (GiroTextBox.Text.Trim() != "") && RutTextBox.Text != "Rut Inválido") // Si ningún texto está vacío y el rut es válido
            {
                IngresarButton.Enabled = true; // Habilitar botón de ingresar
            }
            else // Si no todos los textbox están completos
            {
                IngresarButton.Enabled = false; // Deshabilitar botón de ingresar
            }
        }
        public void HabBotLim() // Habilitar botón de limpiar
        {
            if ((RutTextBox.Text.Trim() != "") || (NombreTextBox.Text.Trim() != "") || (RegionComboBox.Text.Trim() != "") || (ProvinciaComboBox.Text.Trim() != "") || (ComunaComboBox.Text.Trim() != "") || (DireccionTextBox.Text.Trim() != "") || (TelefonoTextBox.Text.Trim() != "") || (EmailTextBox.Text.Trim() != "") || (GiroTextBox.Text.Trim() != "")) // Si algún texto no está vacío
            {
                Limpiar.Enabled = true; // Habilitar botón de limpiar
            }
            else // Si están todos vacíos
            {
                Limpiar.Enabled = false; // Deshabilitar botón de limpiar
            }
        }

        private void RutTextBox_TextChanged(object sender, EventArgs e) // Al cambiar el rut
        {
            if (RutTextBox.Text.Trim() != "") // Si no está vacío
            {
                NombreTextBox.TabStop = true;
                RutTextBox.TabStop = false;
            }
            else // Si está vacío
            {
                NombreTextBox.TabStop = false;
                RutTextBox.TabStop = true;
            }
            HabBotIng(); // Habilitar botón de ingresar
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en el nombre
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e) // Al cambiar texto en el nombre
        {
            NombreTextBox.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(NombreTextBox.Text); // Empezar con mayúsculas
            NombreTextBox.SelectionStart = NombreTextBox.Text.Length;
            if (NombreTextBox.Text.Trim() != "") // Si no está vacío
            {
                RegionComboBox.TabStop = true;
                NombreTextBox.TabStop = false;
            }
            else // Si está vacío
            {
                RegionComboBox.TabStop = false;
                NombreTextBox.TabStop = true;
            }
            HabBotIng(); // Habilitar botón de ingresar
        }

        private void RegionComboBox_SelectedIndexChanged(object sender, EventArgs e) // Al cambiar la región
        {
            if (RegionComboBox.Text.Trim() != "") // Si no está vacío
            {
                ProvinciaComboBox.TabStop = true;
                RegionComboBox.TabStop = false;
                CargaProvinciaComboBox(); // Cargar provincias
            }
            else // Si está vacío
            {
                RegionComboBox.TabStop = false;
                ProvinciaComboBox.TabStop = true;
            }
            HabBotLim(); // Habilitar botón de limpiar
            HabBotIng(); // Habilitar botón de ingresar
        }

        private void ProvinciaComboBox_SelectedIndexChanged(object sender, EventArgs e) // Al cambiar la provincia
        {
            if (ProvinciaComboBox.Text.Trim() != "") // Si no está vacío
            {
                ComunaComboBox.TabStop = true;
                ProvinciaComboBox.TabStop = false;
                CargaComunaComboBox(); // Cargar comunas
            }
            else // Si está vacío
            {
                ProvinciaComboBox.TabStop = false;
                ComunaComboBox.TabStop = true;
            }
            HabBotLim(); // Habilitar botón de limpiar
            HabBotIng(); // Habilitar botón de ingresar
        }

        private void ComunaComboBox_SelectedIndexChanged(object sender, EventArgs e) // Al cambiar la comuna
        {
            if (ComunaComboBox.Text.Trim() != "") // Si no está vacío
            {
                DireccionTextBox.TabStop = true;
                ComunaComboBox.TabStop = false;
            }
            else // Si está vacío
            {
                DireccionTextBox.TabStop = false;
                ComunaComboBox.TabStop = true;
            }
            HabBotLim(); // Habilitar botón de limpiar
            HabBotIng(); // Habilitar botón de ingresar
        }

        private void DireccionTextBox_TextChanged(object sender, EventArgs e) // Al cambiar la dirección
        {
            if (DireccionTextBox.Text.Trim() != "") // Si no está vacío
            {
                TelefonoTextBox.TabStop = true;
                DireccionTextBox.TabStop = false;
            }
            else
            {
                TelefonoTextBox.TabStop = false;
                DireccionTextBox.TabStop = true;
            }
            HabBotLim(); // Habilitar botón de limpiar
            HabBotIng(); // Habilitar botón de ingresar
        }

        private void RutTextBox_Leave(object sender, EventArgs e) // Al dejar de escribir en el rut
        {
            bool respuesta = false;
            if (RutTextBox.Text.Length < 8) // Si el rut tiene menos de 8 carácteres
            {
                RutTextBox.Text = "Rut Inválido";
                return; // Invalidar rut
            }
            respuesta = Rut.validarRut(RutTextBox.Text); // Comprobar rut

            if (respuesta == false) // Si el rut no es válido
            {
                RutTextBox.Text = "Rut Inválido"; // Invalidar rut
            }
            else
            {
                string rutformateado = RutTextBox.Text.Replace(".", "").Replace("-", ""); // Formatear rut añadiendo puntos y guión
                rutformateado = rutformateado.Insert(rutformateado.Length - 1, "-");
                rutformateado = rutformateado.Insert(rutformateado.Length - 5, ".");
                rutformateado = rutformateado.Insert(rutformateado.Length - 9, ".");
                RutTextBox.Text = rutformateado;
                Ent.Rut = rutformateado;
            }
        }

        private void Volver_Click(object sender, EventArgs e) // Al clickear volver
        {
            this.Close(); // Cerrar formulario
        }

        private void Salir_Click(object sender, EventArgs e) // Al clickear salir
        {
            Application.Exit(); // Cerrar aplicación
        }

        private void IngresarButton_Click(object sender, EventArgs e) // Al clickear ingresar
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            string Mensaje = string.Empty;
            Ent.Nombre = NombreTextBox.Text; // Conseguir valores de los textboxes y comuna del combobox
            Ent.Rut = RutTextBox.Text;
            Ent.IdComuna = Convert.ToInt32(ComunaComboBox.SelectedValue);
            Ent.Direccion = DireccionTextBox.Text;
            Ent.Telefono = TelefonoTextBox.Text;
            Ent.Email = EmailTextBox.Text;
            Ent.Giro = GiroTextBox.Text;
            List<ECliente> Listar = new NCliente().Listar();
            foreach (ECliente item in Listar) // Buscar rut en clientes
            {
                if(item.Rut == Ent.Rut)
                {
                    MessageBox.Show("Ya hay un cliente existente con ese rut", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Reclamar que el rut ya existe
                    return; // Cancelar ingreso
                }
            }
                if (res == DialogResult.Yes)
            {
                Respuesta<bool> resultado = NCliente.Ingresar(Ent); // Ingresar Cliente

                if (resultado.Estado) // Si se ingresó
                {
                    MessageBox.Show("Ingreso fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar.PerformClick(); // Limpiar
                }
                else // Si no
                {
                    MessageBox.Show("Ingreso fallido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Reclamar
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
        }

        private void Limpiar_Click(object sender, EventArgs e) // Al clickear limpiar
        {
            RutTextBox.Clear(); // Limpiar textboxes
            NombreTextBox.Clear();
            DireccionTextBox.Clear();
            TelefonoTextBox.Clear();
            EmailTextBox.Clear();
            GiroTextBox.Clear();
            RegionComboBox.DataSource = null; // Limpiar combo boxes
            ProvinciaComboBox.DataSource = null;
            ComunaComboBox.DataSource = null;
            LleComReg();
            HabBotIng(); // Función botón de ingresar
        }

        private void GiroTextBox_TextChanged(object sender, EventArgs e) // Al cambiar el texto de giro
        {
            if (GiroTextBox.Text.Trim() != "") // Si no está vacío
            {
                GiroTextBox.TabStop = false; // Deshabilitar tabulación en giro
            }
            else // Si está vacío
            {
                GiroTextBox.TabStop = true; // Habilitar tabulación en giro
            }
            HabBotLim(); // Habilitar botón de limpiar
            HabBotIng(); // Habilitar botón de ingresar
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e) // Al cambiar el texto de email
        {
            if (EmailTextBox.Text.Trim() != "") // Si no está vacío
            {
                GiroTextBox.TabStop = true; // Habilitar tabulación en giro
                EmailTextBox.TabStop = false; // Deshabilitar tabulación en email
            }
            else // Si está vacío
            {
                GiroTextBox.TabStop = false; // Deshabilitar tabulación en giro
                EmailTextBox.TabStop = true; // Habilitar tabulación en email
            }
            HabBotLim(); // Habilitar botón de limpiar
            HabBotIng(); // Habilitar botón de ingresar
        }

        private void TelefonoTextBox_TextChanged(object sender, EventArgs e) // Al cambiar el texto de teléfono
        {
            if (TelefonoTextBox.Text.Trim() != "") // Si no está vacío
            {
                EmailTextBox.TabStop = true; // Habilitar tabulación en email
                TelefonoTextBox.TabStop = false; // Deshabilitar tabulación en telefono
            }
            else // Si está vacío
            {
                EmailTextBox.TabStop = false; // Deshabilitar tabulación en email
                TelefonoTextBox.TabStop = true; // Habilitar tabulación en telefono
            }
            HabBotLim(); // Habilitar botón de limpiar
            HabBotIng(); // Habilitar botón de ingresar
        }

        private void Ingresar_Load(object sender, EventArgs e) // Al cargar el formulario
        {
            LleComReg(); // Llenar combobox de región
        }

        private void RutTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en rut
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void DireccionTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en dirección
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void TelefonoTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en teléfono
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en email
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void GiroTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en giro
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }
    }
}
