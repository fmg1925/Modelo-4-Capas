namespace Presentacion.Localidad
{
    partial class Comuna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EliminarCheck = new System.Windows.Forms.CheckBox();
            this.ModificarCheck = new System.Windows.Forms.CheckBox();
            this.IngresarCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Ingresar = new System.Windows.Forms.Button();
            this.LimpiarBusqueda = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.BuscarTextBox = new System.Windows.Forms.TextBox();
            this.ProvinciaComboBox = new System.Windows.Forms.ComboBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.LabelOperacion = new System.Windows.Forms.Label();
            this.IngresarTextBox = new System.Windows.Forms.TextBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Selec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdComuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volver = new System.Windows.Forms.Button();
            this.RegionComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IngresarProvincia = new System.Windows.Forms.Button();
            this.IngresarRegion = new System.Windows.Forms.Button();
            this.FiltrarPor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 313);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 312;
            this.label5.Text = "Provincia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 311;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 570);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 310;
            this.label3.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 295;
            this.label2.Text = "Buscar:";
            // 
            // EliminarCheck
            // 
            this.EliminarCheck.AutoSize = true;
            this.EliminarCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarCheck.Enabled = false;
            this.EliminarCheck.Font = new System.Drawing.Font("Yu Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarCheck.Location = new System.Drawing.Point(979, 169);
            this.EliminarCheck.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.EliminarCheck.Name = "EliminarCheck";
            this.EliminarCheck.Size = new System.Drawing.Size(80, 21);
            this.EliminarCheck.TabIndex = 294;
            this.EliminarCheck.TabStop = false;
            this.EliminarCheck.Text = "Eliminar";
            this.EliminarCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EliminarCheck.UseVisualStyleBackColor = true;
            this.EliminarCheck.CheckedChanged += new System.EventHandler(this.EliminarCheck_CheckedChanged);
            // 
            // ModificarCheck
            // 
            this.ModificarCheck.AutoSize = true;
            this.ModificarCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModificarCheck.Enabled = false;
            this.ModificarCheck.Font = new System.Drawing.Font("Yu Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarCheck.Location = new System.Drawing.Point(969, 122);
            this.ModificarCheck.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ModificarCheck.Name = "ModificarCheck";
            this.ModificarCheck.Size = new System.Drawing.Size(88, 21);
            this.ModificarCheck.TabIndex = 293;
            this.ModificarCheck.TabStop = false;
            this.ModificarCheck.Text = "Modificar";
            this.ModificarCheck.UseVisualStyleBackColor = true;
            this.ModificarCheck.CheckedChanged += new System.EventHandler(this.ModificarCheck_CheckedChanged);
            // 
            // IngresarCheck
            // 
            this.IngresarCheck.AutoSize = true;
            this.IngresarCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IngresarCheck.Font = new System.Drawing.Font("Yu Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarCheck.Location = new System.Drawing.Point(979, 81);
            this.IngresarCheck.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.IngresarCheck.Name = "IngresarCheck";
            this.IngresarCheck.Size = new System.Drawing.Size(80, 21);
            this.IngresarCheck.TabIndex = 292;
            this.IngresarCheck.TabStop = false;
            this.IngresarCheck.Text = "Ingresar";
            this.IngresarCheck.UseVisualStyleBackColor = true;
            this.IngresarCheck.CheckedChanged += new System.EventHandler(this.IngresarCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(680, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 291;
            this.label1.Text = "Información sobre Comunas";
            // 
            // Eliminar
            // 
            this.Eliminar.Enabled = false;
            this.Eliminar.Font = new System.Drawing.Font("Yu Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar.Location = new System.Drawing.Point(747, 409);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(143, 60);
            this.Eliminar.TabIndex = 302;
            this.Eliminar.TabStop = false;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Visible = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Enabled = false;
            this.Modificar.Font = new System.Drawing.Font("Unispace", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Modificar.Location = new System.Drawing.Point(747, 409);
            this.Modificar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(143, 60);
            this.Modificar.TabIndex = 301;
            this.Modificar.TabStop = false;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Visible = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Salir.Location = new System.Drawing.Point(993, 551);
            this.Salir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Salir.Name = "Salir";
            this.Salir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Salir.Size = new System.Drawing.Size(95, 60);
            this.Salir.TabIndex = 300;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Limpiar.Location = new System.Drawing.Point(993, 309);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Limpiar.Size = new System.Drawing.Size(95, 60);
            this.Limpiar.TabIndex = 299;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Ingresar
            // 
            this.Ingresar.Enabled = false;
            this.Ingresar.Font = new System.Drawing.Font("Unispace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ingresar.Location = new System.Drawing.Point(747, 409);
            this.Ingresar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(143, 60);
            this.Ingresar.TabIndex = 297;
            this.Ingresar.TabStop = false;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Visible = false;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // LimpiarBusqueda
            // 
            this.LimpiarBusqueda.Font = new System.Drawing.Font("Yu Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarBusqueda.Location = new System.Drawing.Point(283, 119);
            this.LimpiarBusqueda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.LimpiarBusqueda.Name = "LimpiarBusqueda";
            this.LimpiarBusqueda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LimpiarBusqueda.Size = new System.Drawing.Size(233, 28);
            this.LimpiarBusqueda.TabIndex = 309;
            this.LimpiarBusqueda.Text = "Limpiar Búsqueda";
            this.LimpiarBusqueda.UseVisualStyleBackColor = true;
            this.LimpiarBusqueda.Click += new System.EventHandler(this.LimpiarBusqueda_Click);
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(136, 119);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Buscar.Name = "Buscar";
            this.Buscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Buscar.Size = new System.Drawing.Size(95, 28);
            this.Buscar.TabIndex = 308;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // BuscarTextBox
            // 
            this.BuscarTextBox.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarTextBox.Location = new System.Drawing.Point(105, 62);
            this.BuscarTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BuscarTextBox.Name = "BuscarTextBox";
            this.BuscarTextBox.Size = new System.Drawing.Size(445, 28);
            this.BuscarTextBox.TabIndex = 307;
            this.BuscarTextBox.TabStop = false;
            this.BuscarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BuscarTextBox.TextChanged += new System.EventHandler(this.BuscarTextBox_TextChanged);
            this.BuscarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarTextBox_KeyPress);
            // 
            // ProvinciaComboBox
            // 
            this.ProvinciaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProvinciaComboBox.FormattingEnabled = true;
            this.ProvinciaComboBox.Location = new System.Drawing.Point(636, 315);
            this.ProvinciaComboBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ProvinciaComboBox.Name = "ProvinciaComboBox";
            this.ProvinciaComboBox.Size = new System.Drawing.Size(205, 24);
            this.ProvinciaComboBox.TabIndex = 306;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(560, 574);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(132, 22);
            this.IdTextBox.TabIndex = 305;
            // 
            // LabelOperacion
            // 
            this.LabelOperacion.AutoSize = true;
            this.LabelOperacion.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOperacion.Location = new System.Drawing.Point(680, 210);
            this.LabelOperacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOperacion.Name = "LabelOperacion";
            this.LabelOperacion.Size = new System.Drawing.Size(254, 25);
            this.LabelOperacion.TabIndex = 303;
            this.LabelOperacion.Text = "Seleccionar Operación a Realizar";
            // 
            // IngresarTextBox
            // 
            this.IngresarTextBox.Enabled = false;
            this.IngresarTextBox.Font = new System.Drawing.Font("Yu Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarTextBox.Location = new System.Drawing.Point(636, 260);
            this.IngresarTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.IngresarTextBox.Name = "IngresarTextBox";
            this.IngresarTextBox.Size = new System.Drawing.Size(445, 28);
            this.IngresarTextBox.TabIndex = 296;
            this.IngresarTextBox.TabStop = false;
            this.IngresarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IngresarTextBox.TextChanged += new System.EventHandler(this.IngresarTextBox_TextChanged);
            this.IngresarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngresarTextBox_KeyPress_1);
            // 
            // Grilla
            // 
            this.Grilla.AllowUserToAddRows = false;
            this.Grilla.AllowUserToDeleteRows = false;
            this.Grilla.AllowUserToResizeColumns = false;
            this.Grilla.AllowUserToResizeRows = false;
            this.Grilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Grilla.ColumnHeadersHeight = 29;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selec,
            this.Nombre,
            this.IdProvincia,
            this.IdComuna,
            this.IdRegion,
            this.Provincia,
            this.Region});
            this.Grilla.EnableHeadersVisualStyles = false;
            this.Grilla.Location = new System.Drawing.Point(13, 190);
            this.Grilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.RowHeadersVisible = false;
            this.Grilla.RowHeadersWidth = 51;
            this.Grilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grilla.Size = new System.Drawing.Size(475, 411);
            this.Grilla.TabIndex = 304;
            this.Grilla.DoubleClick += new System.EventHandler(this.Grilla_DoubleClick);
            // 
            // Selec
            // 
            this.Selec.HeaderText = "";
            this.Selec.MinimumWidth = 6;
            this.Selec.Name = "Selec";
            this.Selec.ReadOnly = true;
            this.Selec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selec.Visible = false;
            this.Selec.Width = 20;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.HeaderText = "Comuna";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 82;
            // 
            // IdProvincia
            // 
            this.IdProvincia.HeaderText = "Id Provincia";
            this.IdProvincia.MinimumWidth = 6;
            this.IdProvincia.Name = "IdProvincia";
            this.IdProvincia.ReadOnly = true;
            this.IdProvincia.Visible = false;
            this.IdProvincia.Width = 200;
            // 
            // IdComuna
            // 
            this.IdComuna.HeaderText = "IdComuna";
            this.IdComuna.MinimumWidth = 6;
            this.IdComuna.Name = "IdComuna";
            this.IdComuna.ReadOnly = true;
            this.IdComuna.Visible = false;
            this.IdComuna.Width = 125;
            // 
            // IdRegion
            // 
            this.IdRegion.HeaderText = "IdRegion";
            this.IdRegion.MinimumWidth = 6;
            this.IdRegion.Name = "IdRegion";
            this.IdRegion.ReadOnly = true;
            this.IdRegion.Visible = false;
            this.IdRegion.Width = 125;
            // 
            // Provincia
            // 
            this.Provincia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.MinimumWidth = 6;
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            this.Provincia.Width = 88;
            // 
            // Region
            // 
            this.Region.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Region.HeaderText = "Región";
            this.Region.MinimumWidth = 6;
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            this.Region.Width = 76;
            // 
            // Volver
            // 
            this.Volver.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Volver.Location = new System.Drawing.Point(993, 486);
            this.Volver.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Volver.Name = "Volver";
            this.Volver.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Volver.Size = new System.Drawing.Size(95, 60);
            this.Volver.TabIndex = 298;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // RegionComboBox
            // 
            this.RegionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionComboBox.FormattingEnabled = true;
            this.RegionComboBox.Location = new System.Drawing.Point(776, 514);
            this.RegionComboBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RegionComboBox.Name = "RegionComboBox";
            this.RegionComboBox.Size = new System.Drawing.Size(176, 24);
            this.RegionComboBox.TabIndex = 313;
            this.RegionComboBox.SelectedValueChanged += new System.EventHandler(this.RegionComboBox_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 510);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 314;
            this.label6.Text = "Región de la Provincia:";
            // 
            // IngresarProvincia
            // 
            this.IngresarProvincia.Enabled = false;
            this.IngresarProvincia.Font = new System.Drawing.Font("Yu Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarProvincia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IngresarProvincia.Location = new System.Drawing.Point(716, 545);
            this.IngresarProvincia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.IngresarProvincia.Name = "IngresarProvincia";
            this.IngresarProvincia.Size = new System.Drawing.Size(237, 36);
            this.IngresarProvincia.TabIndex = 315;
            this.IngresarProvincia.TabStop = false;
            this.IngresarProvincia.Text = "Ingresar Provincia";
            this.IngresarProvincia.UseVisualStyleBackColor = true;
            this.IngresarProvincia.Click += new System.EventHandler(this.IngresarProvincia_Click);
            // 
            // IngresarRegion
            // 
            this.IngresarRegion.Enabled = false;
            this.IngresarRegion.Font = new System.Drawing.Font("Yu Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarRegion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IngresarRegion.Location = new System.Drawing.Point(716, 586);
            this.IngresarRegion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.IngresarRegion.Name = "IngresarRegion";
            this.IngresarRegion.Size = new System.Drawing.Size(237, 36);
            this.IngresarRegion.TabIndex = 316;
            this.IngresarRegion.TabStop = false;
            this.IngresarRegion.Text = "Ingresar Región";
            this.IngresarRegion.UseVisualStyleBackColor = true;
            this.IngresarRegion.Click += new System.EventHandler(this.IngresarRegion_Click);
            // 
            // FiltrarPor
            // 
            this.FiltrarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrarPor.FormattingEnabled = true;
            this.FiltrarPor.Items.AddRange(new object[] {
            "Comuna",
            "Provincia",
            "Región"});
            this.FiltrarPor.Location = new System.Drawing.Point(147, 17);
            this.FiltrarPor.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.FiltrarPor.Name = "FiltrarPor";
            this.FiltrarPor.Size = new System.Drawing.Size(205, 24);
            this.FiltrarPor.TabIndex = 317;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 318;
            this.label7.Text = "Filtrar por:";
            // 
            // Comuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 624);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FiltrarPor);
            this.Controls.Add(this.IngresarRegion);
            this.Controls.Add(this.IngresarProvincia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RegionComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EliminarCheck);
            this.Controls.Add(this.ModificarCheck);
            this.Controls.Add(this.IngresarCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.LimpiarBusqueda);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.BuscarTextBox);
            this.Controls.Add(this.ProvinciaComboBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.LabelOperacion);
            this.Controls.Add(this.IngresarTextBox);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.Volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Comuna";
            this.Text = "Comuna";
            this.Load += new System.EventHandler(this.Comuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox EliminarCheck;
        public System.Windows.Forms.CheckBox ModificarCheck;
        public System.Windows.Forms.CheckBox IngresarCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Modificar;
        public System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Button LimpiarBusqueda;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox BuscarTextBox;
        public System.Windows.Forms.ComboBox ProvinciaComboBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label LabelOperacion;
        private System.Windows.Forms.TextBox IngresarTextBox;
        private System.Windows.Forms.DataGridView Grilla;
        public System.Windows.Forms.Button Volver;
        public System.Windows.Forms.ComboBox RegionComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button IngresarProvincia;
        private System.Windows.Forms.Button IngresarRegion;
        public System.Windows.Forms.ComboBox FiltrarPor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewButtonColumn Selec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdComuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
    }
}