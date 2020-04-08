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
    public partial class Reportes : Form
    {
        private int tiempo; //variable para el timer
        public Reportes()
        {
            InitializeComponent();
            tiempo = 0;
            timerReportes.Start();
        }


        private void timerReportes_Tick(object sender, EventArgs e)
        {
            if (tiempo <= 100)
            {
                progresbarreportes.Visible = true;
                progresbarreportes.Value = tiempo;
                tiempo += 15;
            }
            else
            {
                //lblcompleto.Text = "cargado exitosamente";
                progresbarreportes.Value = 0;
                progresbarreportes.Visible = false;
                timerReportes.Stop();
                tiempo = 0;
            }
        }

        private void Tiempo(int t)
        {
            tiempo = t;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

    }
}
