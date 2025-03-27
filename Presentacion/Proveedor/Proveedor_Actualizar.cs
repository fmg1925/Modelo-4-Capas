using Entidad;
using Negocio;
using Presentacion.AAClases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace Presentacion.Proveedor
{
    public partial class Proveedor_Actualizar : Form
    {
        public Proveedor_Actualizar() // Iniciar formulario
        {
            InitializeComponent();
        }

        ValidaRut Rut = new ValidaRut(); // Referencia a ValidaRut
        EProveedor Ent = new EProveedor(); // Entidad Proveedor
        NProveedor Neg = new NProveedor(); // Negocio Proveedor
        NComuna NegCom = new NComuna(); // Negocio Comuna
        NProvincia NegPro = new NProvincia(); // Negocio Provincia
        NRegion NegReg = new NRegion(); // Negocio Región
        public void LleComReg() // Llenar combobox región
        {
            CBReg.DisplayMember = "Nombre";
            CBReg.ValueMember = "IdRegion";
            CBReg.DataSource = NegReg.Listar(); // Listar regiones
        }

        private void CargaCBPro() // Cargar provincias
        {
            int IdReg = Convert.ToInt32(CBReg.SelectedValue);
            DataTable dt = NegPro.Filtrar(IdReg); // Filtrar por región
            CBPro.DisplayMember = "Nombre";
            CBPro.ValueMember = "IdProvincia";
            CBPro.DataSource = dt;
        }

        private void CargaCBCom() // Cargar comunas
        {
            int IdPro = Convert.ToInt32(CBPro.SelectedValue);
            DataTable dt = NegCom.Filtrar(IdPro); // Filtrar por provincia
            CBCom.DisplayMember = "Nombre";
            CBCom.ValueMember = "IdComuna";
            CBCom.DataSource = dt;
        }

        private void LlenarComboBoxes() // Llenar comboboxes
        {
            List<EComuna> Listar = new NComuna().Listar(); // Listar objetos de comunas
            EComuna comuna = Listar.Find(c => c.IdComuna == Convert.ToInt32(TextIdComuna.Text)); // Buscar comuna por id
            LleComReg(); // Cargar regiones
            CBReg.SelectedIndex = comuna.IdRegion - 1;
            CargaCBPro(); // Cargar provincias
            foreach (DataRowView item in CBPro.Items) // Por cada provincia
            {
                if (Convert.ToInt32(item["IdProvincia"]) == comuna.IdProvincia) // Buscar provincia
                {
                    int index = CBPro.Items.IndexOf(item); // Seleccionar provincia
                    CBPro.SelectedIndex = index; // Seleccionar en el combobox
                    break; // Romper ciclo
                }
            }
            CargaCBCom(); // Cargar comunas
            foreach (DataRowView item in CBCom.Items) // Por cada comuna
            {
                if (Convert.ToInt32(item["IdComuna"]) == comuna.IdComuna) // Buscar comuna
                {
                    int index = CBCom.Items.IndexOf(item); // Seleccionar comuna
                    CBCom.SelectedIndex = index; // Seleccionar en el combobox
                    break; // Romper ciclo
                }
            }
        }

        private void TextRutF_Leave(object sender, EventArgs e) // Al terminar de escribir rut
        {
            bool respuesta = false;
            if (RutT.Text.Length < 8) // Si el rut tiene menos de 8 carácteres
            {
                RutT.Text = "Rut Inválido";
                return; // Invalidar rut
            }
            respuesta = Rut.validarRut(RutT.Text); // Comprobar rut

            if (respuesta == false) // Si el rut no es válido
            {
                RutT.Text = "Rut Inválido"; // Invalidar rut
            }
            else
            {
                string rutformateado = RutT.Text.Replace(".", "").Replace("-", ""); // Formatear rut añadiendo puntos y guión
                rutformateado = rutformateado.Insert(rutformateado.Length - 1, "-");
                rutformateado = rutformateado.Insert(rutformateado.Length - 5, ".");
                rutformateado = rutformateado.Insert(rutformateado.Length - 9, ".");
                RutT.Text = rutformateado;
                Ent.Rut = rutformateado;
            }
        }

        private void TextNomF_KeyPress(object sender, KeyPressEventArgs e) // Al escribir nombre
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void TextNomF_TextChanged(object sender, EventArgs e) // Al cambiar nombre
        {
            Nombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Nombre.Text); // Empezar texto con mayúsculas
            Nombre.SelectionStart = Nombre.Text.Length;
            Validar(); // Validar
        }

        private void TextTelF_TextChanged(object sender, EventArgs e) // Al cambiar teléfono
        {
            Validar(); // Validar
        }
        private void TextDireF_TextChanged(object sender, EventArgs e) // Al cambiar dirección
        {
            Validar(); // Validar
        }

        private void TextEmaF_TextChanged(object sender, EventArgs e) // Al cambiar email
        {
            Validar(); // Validar
        }

        private void TextGirF_TextChanged(object sender, EventArgs e) // Al cambiar giro
        {
            Validar(); // Validar
        }

        private void TextDesF_TextChanged(object sender, EventArgs e) // Al cambiar descripción
        {
            Validar(); // Validar
        }

        private void ButMod_Click(object sender, EventArgs e) // Al clickear modificar
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // Mostrar confirmación
            Ent.IdProveedor = Convert.ToInt32(TextIdCliente.Text); // Conseguir parámetros de los textboxes
            Ent.Nombre = Nombre.Text;
            Ent.Rut = RutT.Text;
            Ent.IdComuna = Convert.ToInt32(CBCom.SelectedValue);
            Ent.Direccion = Direccion.Text;
            Ent.Telefono = Telefono.Text;
            Ent.Email = Email.Text;
            Ent.Giro = Giro.Text;
            Ent.Descripcion = Descripcion.Text;
            if (res == DialogResult.Yes) // Si se elige sí
            {
                Respuesta<bool> resultado = NProveedor.Actualizar(Ent);
                if (resultado.Estado) // Si se actualiza
                {
                    MessageBox.Show("Actualización fue realizado correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextNombre.Text = Nombre.Text; // Actualizar textboxes
                    RutActual.Text = RutT.Text;
                    TextComuna.Text = (CBCom.SelectedItem as DataRowView)["Nombre"].ToString();
                    TextIdComuna.Text = Ent.IdComuna.ToString();
                    TextDireccion.Text = Direccion.Text;
                    TextTelefono.Text = Telefono.Text;
                    TextEmail.Text = Email.Text;
                    TextGiro.Text = Giro.Text;
                    TextDescripcion.Text = Descripcion.Text;
                    ButAnu.Enabled = false;
                    ButMod.Enabled = false;
                }
                else // Si no
                {
                    MessageBox.Show("No se pudo actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (res == DialogResult.No) // Si se elige no
            {
                ButVol.Focus(); // Enfocar botón de volver
            }
            else if (res == DialogResult.Cancel) // Si se elige cancelar
            {
                ButSal.Focus(); // Enfocar botón de salir
            }
        }

        private void ButAnu_Click(object sender, EventArgs e) // Al clickear anular
        {
            Nombre.Text = TextNombre.Text; // Restaurar valores
            RutT.Text = RutActual.Text;
            ComunaActual.Text = TextComuna.Text;
            Direccion.Text = TextDireccion.Text;
            Telefono.Text = TextTelefono.Text;
            Email.Text = TextEmail.Text;
            Giro.Text = TextGiro.Text;
            Descripcion.Text = TextDescripcion.Text;
            ButAnu.Enabled = false;
            ButMod.Enabled = false;
            LlenarComboBoxes(); // Llenar combo boxes
        }

        private void ButVol_Click(object sender, EventArgs e) // Al clickear volver
        {
            this.Close(); // Cerrar formulario
        }

        private void ButSal_Click(object sender, EventArgs e) // Al clickear salir
        {
            Application.Exit(); // Cerrar aplicación
        }

        private void Proveedor_Actualizar_Load(object sender, EventArgs e) // Al cargar formulario
        {
            LlenarComboBoxes(); // Llenar comboboxes
        }

        private void RutT_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en rut
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void Telefono_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en teléfono
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void Direccion_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en dirección
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en email
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void Giro_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en giro
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void Descripcion_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en descripción
        {
            if (Convert.ToInt32(e.KeyChar) == 127) { e.Handled = true; } // Prohibir ctrl + backspace
        }

        private void CBReg_SelectedIndexChanged(object sender, EventArgs e) // Al cambiar región
        {
            CargaCBPro(); // Cargar provincias
        }

        private void CBPro_SelectedIndexChanged(object sender, EventArgs e) // Al cambiar provincia
        {
            CargaCBCom(); // Cargar comunas
        }

        private void CBCom_SelectedIndexChanged(object sender, EventArgs e) // Al cambiar comuna
        {
            Validar(); // Validar
        }

        private void Validar() // Validar
        {
            if (CBCom.SelectedItem == null) return; // Si no han cargado las comunas no hacer nada
            if (RutT.Text == "Rut Inválido") // Si el rut es inválido
            {
                ButMod.Enabled = false; // Deshabilitar botón de modificar
                return; // Terminar validación
            }
            if (RutT.Text.Trim() != RutActual.Text.Trim() || Nombre.Text.Trim() != TextNombre.Text.Trim() || Telefono.Text.Trim() != TextTelefono.Text.Trim() || Direccion.Text.Trim() != TextDireccion.Text.Trim() || Email.Text.Trim() != TextEmail.Text.Trim() || Giro.Text.Trim() != TextGiro.Text.Trim() || Descripcion.Text.Trim() != TextDescripcion.Text.Trim() || (CBCom.SelectedItem as DataRowView)["Nombre"].ToString().Trim() != TextComuna.Text.Trim()) // Si se cambió algo
            {
                ButAnu.Enabled = true; // Habilitar botón de anular y modificar
                ButMod.Enabled = true;
            }
            else // Si no
            {
                ButAnu.Enabled = false; // Deshabilitar botón de anular y modificar
                ButMod.Enabled = false;
            }
        }

        private void RutT_TextChanged(object sender, EventArgs e) // Si se cambió el rut
        {
            Validar(); // Validar
        }
    }
}
