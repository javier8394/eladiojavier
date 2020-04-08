namespace ControlCotizaciones
{
    partial class Reportes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.progresbarreportes = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datmrEmpresa = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroVenta = new System.Windows.Forms.ComboBox();
            this.dtgriedCotizaciones = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnImpresion1 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDuda = new FontAwesome.Sharp.IconButton();
            this.timerReportes = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgriedCotizaciones)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.progresbarreportes);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 54);
            this.panel1.TabIndex = 0;
            // 
            // progresbarreportes
            // 
            this.progresbarreportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progresbarreportes.BackColor = System.Drawing.Color.Lime;
            this.progresbarreportes.Location = new System.Drawing.Point(-1, 3);
            this.progresbarreportes.Name = "progresbarreportes";
            this.progresbarreportes.Size = new System.Drawing.Size(842, 5);
            this.progresbarreportes.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progresbarreportes.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ControlCotizaciones.Properties.Resources.catalogo;
            this.pictureBox1.Location = new System.Drawing.Point(765, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catalogo de Cotizaciones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(1, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 13);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.datmrEmpresa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumeroVenta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de busqueda";
            // 
            // datmrEmpresa
            // 
            this.datmrEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datmrEmpresa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datmrEmpresa.Location = new System.Drawing.Point(688, 27);
            this.datmrEmpresa.Name = "datmrEmpresa";
            this.datmrEmpresa.Size = new System.Drawing.Size(99, 21);
            this.datmrEmpresa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(641, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreCliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombreCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtNombreCliente.FormattingEnabled = true;
            this.txtNombreCliente.Location = new System.Drawing.Point(399, 28);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(171, 23);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de venta";
            // 
            // txtNumeroVenta
            // 
            this.txtNumeroVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumeroVenta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNumeroVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtNumeroVenta.FormattingEnabled = true;
            this.txtNumeroVenta.Location = new System.Drawing.Point(204, 28);
            this.txtNumeroVenta.Name = "txtNumeroVenta";
            this.txtNumeroVenta.Size = new System.Drawing.Size(87, 23);
            this.txtNumeroVenta.TabIndex = 0;
            // 
            // dtgriedCotizaciones
            // 
            this.dtgriedCotizaciones.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.dtgriedCotizaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgriedCotizaciones.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dtgriedCotizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgriedCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgriedCotizaciones.Location = new System.Drawing.Point(12, 193);
            this.dtgriedCotizaciones.Name = "dtgriedCotizaciones";
            this.dtgriedCotizaciones.Size = new System.Drawing.Size(817, 284);
            this.dtgriedCotizaciones.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(182, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 43);
            this.label8.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.btnImpresion1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(181, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 85);
            this.panel3.TabIndex = 22;
            // 
            // btnImpresion1
            // 
            this.btnImpresion1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpresion1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnImpresion1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImpresion1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnImpresion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpresion1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnImpresion1.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImpresion1.IconColor = System.Drawing.Color.White;
            this.btnImpresion1.IconSize = 30;
            this.btnImpresion1.Location = new System.Drawing.Point(182, 12);
            this.btnImpresion1.Margin = new System.Windows.Forms.Padding(2);
            this.btnImpresion1.Name = "btnImpresion1";
            this.btnImpresion1.Rotation = 0D;
            this.btnImpresion1.Size = new System.Drawing.Size(166, 50);
            this.btnImpresion1.TabIndex = 18;
            this.btnImpresion1.Text = "Imprimir";
            this.btnImpresion1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImpresion1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnDuda);
            this.panel4.Location = new System.Drawing.Point(782, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 44);
            this.panel4.TabIndex = 24;
            // 
            // btnDuda
            // 
            this.btnDuda.FlatAppearance.BorderSize = 0;
            this.btnDuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuda.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDuda.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnDuda.IconColor = System.Drawing.Color.OrangeRed;
            this.btnDuda.IconSize = 29;
            this.btnDuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDuda.Location = new System.Drawing.Point(3, 3);
            this.btnDuda.Name = "btnDuda";
            this.btnDuda.Rotation = 0D;
            this.btnDuda.Size = new System.Drawing.Size(44, 38);
            this.btnDuda.TabIndex = 23;
            this.btnDuda.UseVisualStyleBackColor = true;
            // 
            // timerReportes
            // 
            this.timerReportes.Tick += new System.EventHandler(this.timerReportes_Tick);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(842, 591);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtgriedCotizaciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgriedCotizaciones)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtNumeroVenta;
        private System.Windows.Forms.DateTimePicker datmrEmpresa;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtNombreCliente;
        private System.Windows.Forms.DataGridView dtgriedCotizaciones;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconButton btnImpresion1;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnDuda;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ProgressBar progresbarreportes;
        private System.Windows.Forms.Timer timerReportes;
    }
}