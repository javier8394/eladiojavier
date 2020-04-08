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
    public partial class Clientes : Form
    {
        private int tiempo; //variable para el timer
        public Clientes()
        {
            InitializeComponent();
            tiempo = 0;
            timerBarra.Start();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void timerBarra_Tick(object sender, EventArgs e)
        {
            if (tiempo <= 100)
            {
                progresbarClientes.Visible = true;
                progresbarClientes.Value = tiempo;
                tiempo += 15;
            }
            else
            {
                //lblcompleto.Text = "cargado exitosamente";
                progresbarClientes.Value = 0;
                progresbarClientes.Visible = false;
                timerBarra.Stop();
                tiempo = 0;
            }
        }

        private void Tiempo(int t)
        {
            tiempo = t;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //timerBarra.Start();
            Form Buscar = new ClientesBusqueda();
            Buscar.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //timerBarra.Start();
            Form Mantenimiento = new ClientesMantenimiento();
            Mantenimiento.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //timerBarra.Start();
            Form Mantenimiento = new ClientesMantenimiento();
            Mantenimiento.Show();
        }
    }
}
