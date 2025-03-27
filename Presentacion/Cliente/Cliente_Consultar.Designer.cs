namespace Presentacion.Cliente
{
    partial class Cliente_Consultar
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
            this.IdProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giro = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.IdProv,
            this.Nombre,
            this.Rut,
            this.IdCom,
            this.Comuna,
            this.Direccion,
            this.Tel,
            this.Email,
            this.Giro});
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
            this.label1.Size = new System.Drawing.Size(295, 32);
            this.label1.TabIndex = 256;
            this.label1.Text = "Información sobre Cliente";
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
            // IdProv
            // 
            this.IdProv.HeaderText = "IdCli";
            this.IdProv.MinimumWidth = 6;
            this.IdProv.Name = "IdProv";
            this.IdProv.ReadOnly = true;
            this.IdProv.Visible = false;
            this.IdProv.Width = 125;
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
            // Rut
            // 
            this.Rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Rut.HeaderText = "Rut";
            this.Rut.MinimumWidth = 6;
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            this.Rut.Width = 55;
            // 
            // IdCom
            // 
            this.IdCom.HeaderText = "IdCom";
            this.IdCom.MinimumWidth = 6;
            this.IdCom.Name = "IdCom";
            this.IdCom.ReadOnly = true;
            this.IdCom.Visible = false;
            this.IdCom.Width = 125;
            // 
            // Comuna
            // 
            this.Comuna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Comuna.HeaderText = "Comuna";
            this.Comuna.MinimumWidth = 6;
            this.Comuna.Name = "Comuna";
            this.Comuna.ReadOnly = true;
            this.Comuna.Width = 88;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 98;
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tel.HeaderText = "Teléfono";
            this.Tel.MinimumWidth = 6;
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 94;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 71;
            // 
            // Giro
            // 
            this.Giro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Giro.HeaderText = "Giro";
            this.Giro.MinimumWidth = 6;
            this.Giro.Name = "Giro";
            this.Giro.ReadOnly = true;
            this.Giro.Width = 61;
            // 
            // Cliente_Consultar
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
            this.Name = "Cliente_Consultar";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giro;
    }
}