namespace ControlCotizaciones
{
    partial class productos
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
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnbusquedaProducto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnmantenimientoProducto = new System.Windows.Forms.ToolStripButton();
            this.lblProductos = new System.Windows.Forms.Label();
            this.pnlFondo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.Controls.Add(this.toolStrip1);
            this.pnlFondo.Controls.Add(this.lblProductos);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1348, 750);
            this.pnlFondo.TabIndex = 0;
            this.pnlFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFondo_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnbusquedaProducto,
            this.toolStripSeparator1,
            this.btnmantenimientoProducto});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1348, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Barra Menu";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnbusquedaProducto
            // 
            this.btnbusquedaProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbusquedaProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnbusquedaProducto.Image = global::ControlCotizaciones.Properties.Resources.buscar;
            this.btnbusquedaProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbusquedaProducto.Name = "btnbusquedaProducto";
            this.btnbusquedaProducto.Size = new System.Drawing.Size(128, 36);
            this.btnbusquedaProducto.Text = "Busqueda";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnmantenimientoProducto
            // 
            this.btnmantenimientoProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmantenimientoProducto.Image = global::ControlCotizaciones.Properties.Resources.settings_cogwheel_button;
            this.btnmantenimientoProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmantenimientoProducto.Name = "btnmantenimientoProducto";
            this.btnmantenimientoProducto.Size = new System.Drawing.Size(182, 36);
            this.btnmantenimientoProducto.Text = "Mantenimiento";
            // 
            // lblProductos
            // 
            this.lblProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(612, 203);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(152, 32);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Productos";
            // 
            // productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1348, 750);
            this.Controls.Add(this.pnlFondo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "productos";
            this.Text = "productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnbusquedaProducto;
        private System.Windows.Forms.ToolStripButton btnmantenimientoProducto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}