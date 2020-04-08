namespace ControlCotizaciones
{
    partial class cotizacionNueva
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textcotizarproducto = new System.Windows.Forms.TextBox();
            this.dtgbusquedaCotizacion = new System.Windows.Forms.DataGridView();
            this.btnbuscarClientes = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgproductoagregado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbusquedaCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgproductoagregado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(650, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textcotizarproducto
            // 
            this.textcotizarproducto.Location = new System.Drawing.Point(690, 91);
            this.textcotizarproducto.Name = "textcotizarproducto";
            this.textcotizarproducto.Size = new System.Drawing.Size(265, 22);
            this.textcotizarproducto.TabIndex = 3;
            // 
            // dtgbusquedaCotizacion
            // 
            this.dtgbusquedaCotizacion.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dtgbusquedaCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgbusquedaCotizacion.Location = new System.Drawing.Point(98, 148);
            this.dtgbusquedaCotizacion.Name = "dtgbusquedaCotizacion";
            this.dtgbusquedaCotizacion.RowHeadersWidth = 51;
            this.dtgbusquedaCotizacion.RowTemplate.Height = 24;
            this.dtgbusquedaCotizacion.Size = new System.Drawing.Size(1239, 243);
            this.dtgbusquedaCotizacion.TabIndex = 4;
            // 
            // btnbuscarClientes
            // 
            this.btnbuscarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnbuscarClientes.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarClientes.IconColor = System.Drawing.Color.Black;
            this.btnbuscarClientes.IconSize = 30;
            this.btnbuscarClientes.Location = new System.Drawing.Point(972, 82);
            this.btnbuscarClientes.Name = "btnbuscarClientes";
            this.btnbuscarClientes.Rotation = 0D;
            this.btnbuscarClientes.Size = new System.Drawing.Size(43, 40);
            this.btnbuscarClientes.TabIndex = 6;
            this.btnbuscarClientes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(609, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Producto Agregado";
            // 
            // dtgproductoagregado
            // 
            this.dtgproductoagregado.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dtgproductoagregado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgproductoagregado.Location = new System.Drawing.Point(98, 464);
            this.dtgproductoagregado.Name = "dtgproductoagregado";
            this.dtgproductoagregado.RowHeadersWidth = 51;
            this.dtgproductoagregado.RowTemplate.Height = 24;
            this.dtgproductoagregado.Size = new System.Drawing.Size(1239, 283);
            this.dtgproductoagregado.TabIndex = 8;
            // 
            // cotizacionNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1434, 781);
            this.Controls.Add(this.dtgproductoagregado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnbuscarClientes);
            this.Controls.Add(this.dtgbusquedaCotizacion);
            this.Controls.Add(this.textcotizarproducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cotizacionNueva";
            this.Text = "Nueva Cotizacion";
            this.Load += new System.EventHandler(this.cotizacionNueva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgbusquedaCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgproductoagregado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textcotizarproducto;
        private System.Windows.Forms.DataGridView dtgbusquedaCotizacion;
        private FontAwesome.Sharp.IconButton btnbuscarClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgproductoagregado;
    }
}