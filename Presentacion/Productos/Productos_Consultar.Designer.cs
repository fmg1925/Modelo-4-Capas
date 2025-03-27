namespace Presentacion.Productos
{
    partial class Productos_Consultar
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
            this.ButLimBus = new System.Windows.Forms.Button();
            this.ButBus = new System.Windows.Forms.Button();
            this.TextBus = new System.Windows.Forms.TextBox();
            this.ComboBus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.ButEli = new System.Windows.Forms.Button();
            this.ButMod = new System.Windows.Forms.Button();
            this.ButSal = new System.Windows.Forms.Button();
            this.ButVol = new System.Windows.Forms.Button();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Selec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadArrendada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorArriendoPorUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // ButLimBus
            // 
            this.ButLimBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButLimBus.Location = new System.Drawing.Point(98, 96);
            this.ButLimBus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButLimBus.Name = "ButLimBus";
            this.ButLimBus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButLimBus.Size = new System.Drawing.Size(175, 23);
            this.ButLimBus.TabIndex = 267;
            this.ButLimBus.Text = "Limpiar Búsqueda";
            this.ButLimBus.UseVisualStyleBackColor = true;
            this.ButLimBus.Click += new System.EventHandler(this.ButLimBus_Click);
            // 
            // ButBus
            // 
            this.ButBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButBus.Location = new System.Drawing.Point(21, 96);
            this.ButBus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButBus.Name = "ButBus";
            this.ButBus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButBus.Size = new System.Drawing.Size(71, 23);
            this.ButBus.TabIndex = 266;
            this.ButBus.Text = "Buscar";
            this.ButBus.UseVisualStyleBackColor = true;
            this.ButBus.Click += new System.EventHandler(this.ButBus_Click);
            // 
            // TextBus
            // 
            this.TextBus.Location = new System.Drawing.Point(18, 69);
            this.TextBus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBus.Name = "TextBus";
            this.TextBus.Size = new System.Drawing.Size(335, 22);
            this.TextBus.TabIndex = 265;
            this.TextBus.TabStop = false;
            this.TextBus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBus.TextChanged += new System.EventHandler(this.TextBus_TextChanged);
            this.TextBus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBus_KeyPress);
            // 
            // ComboBus
            // 
            this.ComboBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBus.FormattingEnabled = true;
            this.ComboBus.Location = new System.Drawing.Point(124, 41);
            this.ComboBus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBus.Name = "ComboBus";
            this.ComboBus.Size = new System.Drawing.Size(142, 24);
            this.ComboBus.TabIndex = 264;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 263;
            this.label4.Text = "Buscar Por:";
            // 
            // TextBox1
            // 
            this.TextBox1.Enabled = false;
            this.TextBox1.Location = new System.Drawing.Point(18, 516);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(101, 22);
            this.TextBox1.TabIndex = 262;
            this.TextBox1.TabStop = false;
            this.TextBox1.Visible = false;
            // 
            // ButEli
            // 
            this.ButEli.Enabled = false;
            this.ButEli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButEli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButEli.Location = new System.Drawing.Point(685, 82);
            this.ButEli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButEli.Name = "ButEli";
            this.ButEli.Size = new System.Drawing.Size(118, 49);
            this.ButEli.TabIndex = 261;
            this.ButEli.TabStop = false;
            this.ButEli.Text = "Eliminar";
            this.ButEli.UseVisualStyleBackColor = true;
            this.ButEli.Visible = false;
            this.ButEli.Click += new System.EventHandler(this.ButEli_Click);
            // 
            // ButMod
            // 
            this.ButMod.Enabled = false;
            this.ButMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButMod.Location = new System.Drawing.Point(685, 82);
            this.ButMod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButMod.Name = "ButMod";
            this.ButMod.Size = new System.Drawing.Size(118, 49);
            this.ButMod.TabIndex = 260;
            this.ButMod.TabStop = false;
            this.ButMod.Text = "Actualizar";
            this.ButMod.UseVisualStyleBackColor = true;
            this.ButMod.Visible = false;
            this.ButMod.Click += new System.EventHandler(this.ButMod_Click);
            // 
            // ButSal
            // 
            this.ButSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButSal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButSal.Location = new System.Drawing.Point(732, 11);
            this.ButSal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButSal.Name = "ButSal";
            this.ButSal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButSal.Size = new System.Drawing.Size(71, 49);
            this.ButSal.TabIndex = 259;
            this.ButSal.Text = "Salir";
            this.ButSal.UseVisualStyleBackColor = true;
            this.ButSal.Click += new System.EventHandler(this.ButSal_Click);
            // 
            // ButVol
            // 
            this.ButVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButVol.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButVol.Location = new System.Drawing.Point(655, 11);
            this.ButVol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButVol.Name = "ButVol";
            this.ButVol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButVol.Size = new System.Drawing.Size(71, 49);
            this.ButVol.TabIndex = 258;
            this.ButVol.Text = "Volver";
            this.ButVol.UseVisualStyleBackColor = true;
            this.ButVol.Click += new System.EventHandler(this.ButVol_Click);
            // 
            // Grilla
            // 
            this.Grilla.AllowUserToAddRows = false;
            this.Grilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Grilla.ColumnHeadersHeight = 29;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selec,
            this.IdProducto,
            this.Nombre,
            this.Fecha,
            this.CantidadInicial,
            this.CantidadActual,
            this.CantidadArrendada,
            this.TotalActual,
            this.ValorArriendoPorUnidad});
            this.Grilla.EnableHeadersVisualStyles = false;
            this.Grilla.Location = new System.Drawing.Point(18, 139);
            this.Grilla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.RowHeadersVisible = false;
            this.Grilla.RowHeadersWidth = 51;
            this.Grilla.Size = new System.Drawing.Size(796, 340);
            this.Grilla.TabIndex = 257;
            this.Grilla.DoubleClick += new System.EventHandler(this.Grilla_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 256;
            this.label1.Text = "Información sobre Productos";
            // 
            // Selec
            // 
            this.Selec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Selec.HeaderText = "Column1";
            this.Selec.MinimumWidth = 6;
            this.Selec.Name = "Selec";
            this.Selec.ReadOnly = true;
            this.Selec.Visible = false;
            this.Selec.Width = 72;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 87;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fecha.HeaderText = "Fecha de Incorporación";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 196;
            // 
            // CantidadInicial
            // 
            this.CantidadInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CantidadInicial.HeaderText = "Cantidad Inicial";
            this.CantidadInicial.MinimumWidth = 6;
            this.CantidadInicial.Name = "CantidadInicial";
            this.CantidadInicial.ReadOnly = true;
            this.CantidadInicial.Width = 139;
            // 
            // CantidadActual
            // 
            this.CantidadActual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CantidadActual.HeaderText = "Cantidad Actual";
            this.CantidadActual.MinimumWidth = 6;
            this.CantidadActual.Name = "CantidadActual";
            this.CantidadActual.ReadOnly = true;
            this.CantidadActual.Width = 141;
            // 
            // CantidadArrendada
            // 
            this.CantidadArrendada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CantidadArrendada.HeaderText = "Cantidad Arrendada";
            this.CantidadArrendada.MinimumWidth = 6;
            this.CantidadArrendada.Name = "CantidadArrendada";
            this.CantidadArrendada.ReadOnly = true;
            this.CantidadArrendada.Width = 171;
            // 
            // TotalActual
            // 
            this.TotalActual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalActual.HeaderText = "Total Actual";
            this.TotalActual.MinimumWidth = 6;
            this.TotalActual.Name = "TotalActual";
            this.TotalActual.ReadOnly = true;
            this.TotalActual.Width = 115;
            // 
            // ValorArriendoPorUnidad
            // 
            this.ValorArriendoPorUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ValorArriendoPorUnidad.HeaderText = "Valor Arriendo por Unidad";
            this.ValorArriendoPorUnidad.MinimumWidth = 6;
            this.ValorArriendoPorUnidad.Name = "ValorArriendoPorUnidad";
            this.ValorArriendoPorUnidad.ReadOnly = true;
            this.ValorArriendoPorUnidad.Width = 213;
            // 
            // Productos_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 501);
            this.ControlBox = false;
            this.Controls.Add(this.ButLimBus);
            this.Controls.Add(this.ButBus);
            this.Controls.Add(this.TextBus);
            this.Controls.Add(this.ComboBus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.ButEli);
            this.Controls.Add(this.ButMod);
            this.Controls.Add(this.ButSal);
            this.Controls.Add(this.ButVol);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productos_Consultar";
            this.Text = "Información sobre Cliente";
            this.Load += new System.EventHandler(this.Cliente_Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButLimBus;
        private System.Windows.Forms.Button ButBus;
        private System.Windows.Forms.TextBox TextBus;
        public System.Windows.Forms.ComboBox ComboBus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox1;
        public System.Windows.Forms.Button ButEli;
        public System.Windows.Forms.Button ButMod;
        public System.Windows.Forms.Button ButSal;
        public System.Windows.Forms.Button ButVol;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn Selec;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadArrendada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorArriendoPorUnidad;
    }
}