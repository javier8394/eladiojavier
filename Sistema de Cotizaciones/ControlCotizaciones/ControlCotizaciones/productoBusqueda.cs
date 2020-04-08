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
    public partial class productoBusqueda : Form
    {
        private int tiempo; //variable para el timer
        public productoBusqueda()
        {
            InitializeComponent();
            tiempo = 0;
            timerBusqueda.Start();
        }

        private void timerBusqueda_Tick(object sender, EventArgs e)
        {
            if (tiempo <= 100)
            {
                progresbarproducto.Visible = true;
                progresbarproducto.Value = tiempo;
                tiempo += 15;
            }
            else
            {
                //lblcompleto.Text = "cargado exitosamente";
                progresbarproducto.Value = 0;
                progresbarproducto.Visible = false;
                timerBusqueda.Stop();
                tiempo = 0;
            }
        }


        private void Tiempo(int t)
        {
            tiempo = t;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productoBusqueda_Load(object sender, EventArgs e)
        {

        }


    }
}
