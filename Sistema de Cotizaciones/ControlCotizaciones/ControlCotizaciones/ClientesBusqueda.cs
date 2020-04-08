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
    public partial class ClientesBusqueda : Form
    {
        private int tiempo; //variable para el timer
        public ClientesBusqueda()
        {
            InitializeComponent();
            tiempo = 0;
            timerbusqueda.Start();
        }

        private void timerbusqueda_Tick(object sender, EventArgs e)
        {
            if (tiempo <= 100)
            {
                progresbarcliente.Visible = true;
                progresbarcliente.Value = tiempo;
                tiempo += 15;
            }
            else
            {
                //lblcompleto.Text = "cargado exitosamente";
                progresbarcliente.Value = 0;
                progresbarcliente.Visible = false;
                timerbusqueda.Stop();
                tiempo = 0;
            }
        }

        private void Tiempo(int t)
        {
            tiempo = t;
        }


        private void ClientesBusqueda_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
