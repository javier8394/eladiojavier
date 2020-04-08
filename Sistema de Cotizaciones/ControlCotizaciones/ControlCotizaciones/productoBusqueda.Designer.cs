namespace ControlCotizaciones
{
    partial class productoBusqueda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgproductos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caracteristicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnombreProducto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxproveedor = new System.Windows.Forms.ComboBox();
            this.progresbarproducto = new System.Windows.Forms.ProgressBar();
            this.timerBusqueda = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgproductos
            // 
            this.dtgproductos.AllowUserToOrderColumns = true;
            this.dtgproductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgproductos.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dtgproductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombreProducto,
            this.precio,
            this.Caracteristicas,
            this.tipoProducto,
            this.fechaIngreso});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgproductos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgproductos.Location = new System.Drawing.Point(32, 149);
            this.dtgproductos.Margin = new System.Windows.Forms.Padding(2);
            this.dtgproductos.Name = "dtgproductos";
            this.dtgproductos.RowHeadersWidth = 51;
            this.dtgproductos.RowTemplate.Height = 24;
            this.dtgproductos.Size = new System.Drawing.Size(671, 171);
            this.dtgproductos.TabIndex = 10;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Descripcion";
            this.nombreProducto.MinimumWidth = 6;
            this.nombreProducto.Name = "nombreProducto";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            // 
            // Caracteristicas
            // 
            this.Caracteristicas.HeaderText = "Caracteristicas";
            this.Caracteristicas.MinimumWidth = 6;
            this.Caracteristicas.Name = "Caracteristicas";
            // 
            // tipoProducto
            // 
            this.tipoProducto.HeaderText = "Tipo de Producto";
            this.tipoProducto.MinimumWidth = 6;
            this.tipoProducto.Name = "tipoProducto";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.HeaderText = "Fecha de Ingreso";
            this.fechaIngreso.MinimumWidth = 6;
            this.fechaIngreso.Name = "fechaIngreso";
            // 
            // txtnombreProducto
            // 
            this.txtnombreProducto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtnombreProducto.Location = new System.Drawing.Point(143, 97);
            this.txtnombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombreProducto.Name = "txtnombreProducto";
            this.txtnombreProducto.Size = new System.Drawing.Size(258, 20);
            this.txtnombreProducto.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 64);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Proveedor ";
            // 
            // cbxproveedor
            // 
            this.cbxproveedor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxproveedor.FormattingEnabled = true;
            this.cbxproveedor.Location = new System.Drawing.Point(143, 63);
            this.cbxproveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cbxproveedor.Name = "cbxproveedor";
            this.cbxproveedor.Size = new System.Drawing.Size(193, 21);
            this.cbxproveedor.TabIndex = 13;
            // 
            // progresbarproducto
            // 
            this.progresbarproducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progresbarproducto.BackColor = System.Drawing.Color.Lime;
            this.progresbarproducto.Location = new System.Drawing.Point(285, 31);
            this.progresbarproducto.Name = "progresbarproducto";
            this.progresbarproducto.Size = new System.Drawing.Size(200, 5);
            this.progresbarproducto.Step = 5;
            this.progresbarproducto.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progresbarproducto.TabIndex = 26;
            // 
            // timerBusqueda
            // 
            this.timerBusqueda.Tick += new System.EventHandler(this.timerBusqueda_Tick);
            // 
            // productoBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(731, 342);
            this.Controls.Add(this.progresbarproducto);
            this.Controls.Add(this.cbxproveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgproductos);
            this.Controls.Add(this.txtnombreProducto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "productoBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Productos";
            this.Load += new System.EventHandler(this.productoBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgproductos;
        private System.Windows.Forms.TextBox txtnombreProducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxproveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caracteristicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.ProgressBar progresbarproducto;
        private System.Windows.Forms.Timer timerBusqueda;
    }
}