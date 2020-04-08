using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCotizaciones
{
    public partial class ClientesMantenimiento : Form
    {
        private int tiempo; //variable para el timer
        public ClientesMantenimiento()
        {
            InitializeComponent();
            tiempo = 0;
            timermantenimientoCliente.Start();
        }

        // Codigo para el timer y la barra de carga
        private void timermantenimientoCliente_Tick(object sender, EventArgs e)
        {
            if (tiempo <= 100)
            {
                progresbarmantenimiento.Visible = true;
                progresbarmantenimiento.Value = tiempo;
                tiempo += 5;
            }
            else
            {
                //lblcompleto.Text = "cargado exitosamente";
                progresbarmantenimiento.Value = 0;
                progresbarmantenimiento.Visible = false;
                timermantenimientoCliente.Stop();
                tiempo = 0;
            }
        }
        private void Tiempo(int t)
        {
            tiempo = t;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }

        private void ClientesMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtapellidoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtnombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefonoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton de la pestana de busqueda
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //timerBarra.Start();
            Form Buscar = new ClientesBusqueda();
            Buscar.Show();
        }
    }
}
