using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCotizaciones.Carpeta_Clases;
using MySql.Data.MySqlClient;

namespace ControlCotizaciones
{
    public partial class Proveedores : Form

    {
        ClaConexion enlace; // Variable tipo ClaConexion
        private int tiempo; //variable para el timer
        private ClaListadoProveedor listadoProveedor;
        private ClaProveedor proveedor;

        public Proveedores()
        {
            InitializeComponent();
            proveedor = new ClaProveedor();
            enlace = new ClaConexion();
            listadoProveedor = new ClaListadoProveedor();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            DataTable tabla1 = listadoProveedor.SQL("SELECT NombreProveedor,Direccion,Telefono, TelefonoSecundario FROM dbicma.Proveedor");
            datagridproveedor.DataSource = null;
            datagridproveedor.DataSource = tabla1;
            datagridproveedor.Columns["NombreProveedor"].Visible = false;
            datagridproveedor.Columns[",Direccion"].Visible = false;
            datagridproveedor.Columns["Telefono"].Visible = false;
            datagridproveedor.Columns["TelefonoSecundario"].Visible = false;
            datagridproveedor.Refresh();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                proveedor.NombreProveedor = txtnombreProveedor.Text;
                proveedor.DireccionProveedor = txtdireccionProveedor.Text;
                proveedor.TelefonoProveedor = txtTelefono.Text;
                proveedor.TelefonoProveedor = txttelefono2.Text;
                try
                {
                    proveedor.Guardar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(string.Format("No se pudo agregar el proveedor. Error: \n{0}", ex.ToString()), "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RecargarPantalla();
                LimpiarPantalla();
            }
        }
        private Boolean Validar()
        {
            Boolean resultado = true;
            if (txtnombreProveedor.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre al proveedor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnombreProveedor.Focus();
                resultado = false;
            }
            if (txtdireccionProveedor.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar la direccion para el proveedor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdireccionProveedor.Focus();
                resultado = false;
                return resultado;
            }

            if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el numero de telefono del proveedor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                resultado = false;
            }
            if (txttelefono2.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el numero de telefono secundario del proveedor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttelefono2.Focus();
                resultado = false;
            }

            return resultado;
        }
        private void LimpiarPantalla()
        {
            txtnombreProveedor.Text = string.Empty;
            txtdireccionProveedor.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txttelefono2.Text = string.Empty;

        }
        private void RecargarPantalla()
        {
            DataTable tabla1 = listadoProveedor.SQL("SELECT NombreProveedor,Direccion,Telefono, TelefonoSecundario FROM dbicma.Proveedor");
            datagridproveedor.DataSource = null;
            datagridproveedor.DataSource = tabla1;
            datagridproveedor.Columns["NombreProveedor"].Visible = false;
            datagridproveedor.Columns[",Direccion"].Visible = false;
            datagridproveedor.Columns["Telefono"].Visible = false;
            datagridproveedor.Columns["TelefonoSecundario"].Visible = false;
            datagridproveedor.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla1 = listadoProveedor.SQL("SELECT NombreProveedor,Direccion,Telefono, TelefonoSecundario FROM dbicma.Proveedor");
            datagridproveedor.DataSource = tabla1;
            datagridproveedor.Columns["NombreProveedor"].Visible = false;
            datagridproveedor.Columns["Direccion"].Visible = false;
            datagridproveedor.Columns["Telefono"].Visible = false;
            datagridproveedor.Columns["TelefonoSecundario"].Visible = false;
            datagridproveedor.Refresh();
        }
        private void datagridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtnombreProveedor.Text = datagridproveedor.CurrentRow.Cells[0].Value.ToString();
            txtdireccionProveedor.Text = datagridproveedor.CurrentRow.Cells[1].Value.ToString();
            txtTelefono.Text = datagridproveedor.CurrentRow.Cells[2].Value.ToString();
            txttelefono2.Text = datagridproveedor.CurrentRow.Cells[3].Value.ToString();

            btnAgregarProveedor.Enabled = false;
            btnBuscar.Enabled = false;
            btnModificar.Enabled = true;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                proveedor.NombreProveedor = txtnombreProveedor.Text;
                proveedor.DireccionProveedor= txtdireccionProveedor.Text;
                proveedor.TelefonoProveedor = txtTelefono.Text;
                proveedor.TelefonoSecundarioProveedor = txttelefono2.Text;
                try
                {
                    proveedor.Modificar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(string.Format("No se podo modificar el producto. Error: \n{0}", ex.ToString()), "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            RecargarPantalla();
            LimpiarPantalla();
            btnAgregarProveedor.Enabled = true;
            btnBuscar.Enabled = true;
            btnModificar.Enabled = false;
        }
        public static void validarSoloNumeros(KeyPressEventArgs n)
        {
            if (char.IsDigit(n.KeyChar))
            {
                n.Handled = false;
            }
            else if (char.IsSeparator(n.KeyChar))
            {
                n.Handled = false;
            }
            else if (char.IsControl(n.KeyChar) || n.KeyChar.ToString().Equals("."))
            {
                n.Handled = false;
            }
            else
            {
                n.Handled = true;
                MessageBox.Show("Solo se permite ingresar numeros", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento encargado de llamar al evento de validar que solo se ingresen numeros
        /// </summary>
        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarSoloNumeros(e);
        }


    }
}
    

