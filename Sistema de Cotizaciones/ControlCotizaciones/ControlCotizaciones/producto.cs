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
    public partial class producto : Form
    {
        private int tiempo; //variable para el timer
        public producto()
        {
            InitializeComponent();
            tiempo = 0;
            timerProducto.Start();
        }


        private void producto_Load(object sender, EventArgs e)
        {

        }

        private void timerProducto_Tick(object sender, EventArgs e)
        {
            if (tiempo <= 100)
            {
                progresbarProducto.Visible = true;
                progresbarProducto.Value = tiempo;
                tiempo += 15;
            }
            else
            {
                //lblcompleto.Text = "cargado exitosamente";
                progresbarProducto.Value = 0;
                progresbarProducto.Visible = false;
                timerProducto.Stop();
                tiempo = 0;
            }
        }


        private void Tiempo(int t)
        {
            tiempo = t;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form Buscar = new productoBusqueda();
            Buscar.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form mantenimiento = new prodcutoMantenimiento();
            mantenimiento.Show();
        }
    }
}
