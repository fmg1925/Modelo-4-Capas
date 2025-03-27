namespace Presentacion
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.localidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Region = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.Provincia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.Comuna = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IngresarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ActualizarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.EliminarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IngresarProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ActualizarProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.EliminarProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IngresarProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ActualizarProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EliminarProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.arriendosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localidadToolStripMenuItem,
            this.toolStripMenuItem1,
            this.clienteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.proveedorToolStripMenuItem,
            this.toolStripMenuItem3,
            this.productosToolStripMenuItem,
            this.toolStripMenuItem4,
            this.arriendosToolStripMenuItem,
            this.toolStripMenuItem5,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1129, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // localidadToolStripMenuItem
            // 
            this.localidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Region,
            this.toolStripSeparator7,
            this.Provincia,
            this.toolStripSeparator8,
            this.Comuna});
            this.localidadToolStripMenuItem.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidadToolStripMenuItem.Name = "localidadToolStripMenuItem";
            this.localidadToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.localidadToolStripMenuItem.Text = "Localidad";
            // 
            // Region
            // 
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(145, 22);
            this.Region.Text = "Región";
            this.Region.Click += new System.EventHandler(this.Region_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(142, 6);
            // 
            // Provincia
            // 
            this.Provincia.Name = "Provincia";
            this.Provincia.Size = new System.Drawing.Size(145, 22);
            this.Provincia.Text = "Provincia";
            this.Provincia.Click += new System.EventHandler(this.Provincia_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(142, 6);
            // 
            // Comuna
            // 
            this.Comuna.Name = "Comuna";
            this.Comuna.Size = new System.Drawing.Size(145, 22);
            this.Comuna.Text = "Comuna";
            this.Comuna.Click += new System.EventHandler(this.Comuna_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IngresarCliente,
            this.toolStripSeparator6,
            this.ActualizarCliente,
            this.toolStripSeparator5,
            this.EliminarCliente});
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // IngresarCliente
            // 
            this.IngresarCliente.Name = "IngresarCliente";
            this.IngresarCliente.Size = new System.Drawing.Size(151, 22);
            this.IngresarCliente.Text = "Ingresar";
            this.IngresarCliente.Click += new System.EventHandler(this.IngresarCliente_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(148, 6);
            // 
            // ActualizarCliente
            // 
            this.ActualizarCliente.Name = "ActualizarCliente";
            this.ActualizarCliente.Size = new System.Drawing.Size(151, 22);
            this.ActualizarCliente.Text = "Actualizar";
            this.ActualizarCliente.Click += new System.EventHandler(this.ActualizarCliente_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(148, 6);
            // 
            // EliminarCliente
            // 
            this.EliminarCliente.Name = "EliminarCliente";
            this.EliminarCliente.Size = new System.Drawing.Size(151, 22);
            this.EliminarCliente.Text = "Eliminar";
            this.EliminarCliente.Click += new System.EventHandler(this.EliminarCliente_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem2.Text = "|";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IngresarProveedor,
            this.toolStripSeparator4,
            this.ActualizarProveedor,
            this.toolStripSeparator3,
            this.EliminarProveedor});
            this.proveedorToolStripMenuItem.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // IngresarProveedor
            // 
            this.IngresarProveedor.Name = "IngresarProveedor";
            this.IngresarProveedor.Size = new System.Drawing.Size(151, 22);
            this.IngresarProveedor.Text = "Ingresar";
            this.IngresarProveedor.Click += new System.EventHandler(this.IngresarProveedor_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(148, 6);
            // 
            // ActualizarProveedor
            // 
            this.ActualizarProveedor.Name = "ActualizarProveedor";
            this.ActualizarProveedor.Size = new System.Drawing.Size(151, 22);
            this.ActualizarProveedor.Text = "Actualizar";
            this.ActualizarProveedor.Click += new System.EventHandler(this.ActualizarProveedor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(148, 6);
            // 
            // EliminarProveedor
            // 
            this.EliminarProveedor.Name = "EliminarProveedor";
            this.EliminarProveedor.Size = new System.Drawing.Size(151, 22);
            this.EliminarProveedor.Text = "Eliminar";
            this.EliminarProveedor.Click += new System.EventHandler(this.EliminarProveedor_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem3.Text = "|";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IngresarProductos,
            this.toolStripSeparator1,
            this.ActualizarProductos,
            this.toolStripSeparator2,
            this.EliminarProductos});
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // IngresarProductos
            // 
            this.IngresarProductos.Name = "IngresarProductos";
            this.IngresarProductos.Size = new System.Drawing.Size(180, 22);
            this.IngresarProductos.Text = "Ingresar";
            this.IngresarProductos.Click += new System.EventHandler(this.IngresarProductos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ActualizarProductos
            // 
            this.ActualizarProductos.Name = "ActualizarProductos";
            this.ActualizarProductos.Size = new System.Drawing.Size(180, 22);
            this.ActualizarProductos.Text = "Actualizar";
            this.ActualizarProductos.Click += new System.EventHandler(this.ActualizarProductos_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // EliminarProductos
            // 
            this.EliminarProductos.Name = "EliminarProductos";
            this.EliminarProductos.Size = new System.Drawing.Size(180, 22);
            this.EliminarProductos.Text = "Eliminar";
            this.EliminarProductos.Click += new System.EventHandler(this.EliminarProductos_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem4.Text = "|";
            // 
            // arriendosToolStripMenuItem
            // 
            this.arriendosToolStripMenuItem.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arriendosToolStripMenuItem.Name = "arriendosToolStripMenuItem";
            this.arriendosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.arriendosToolStripMenuItem.Text = "Arriendos";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Enabled = false;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem5.Text = "|";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 677);
            this.panel1.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 705);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem localidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arriendosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem Region;
        private System.Windows.Forms.ToolStripMenuItem Provincia;
        private System.Windows.Forms.ToolStripMenuItem Comuna;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem IngresarProveedor;
        private System.Windows.Forms.ToolStripMenuItem ActualizarProveedor;
        private System.Windows.Forms.ToolStripMenuItem EliminarProveedor;
        private System.Windows.Forms.ToolStripMenuItem IngresarCliente;
        private System.Windows.Forms.ToolStripMenuItem ActualizarCliente;
        private System.Windows.Forms.ToolStripMenuItem EliminarCliente;
        private System.Windows.Forms.ToolStripMenuItem IngresarProductos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ActualizarProductos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem EliminarProductos;
    }
}