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
    public partial class configuraciones : Form
    {

        public configuraciones()
        {
            InitializeComponent();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Form Buscar = new ClientesBusqueda();
            Buscar.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form Mantenimiento = new ClientesMantenimiento();
            Mantenimiento.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Form Buscar = new productoBusqueda();
            Buscar.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Form Mantenimiento = new prodcutoMantenimiento();
            Mantenimiento.Show();
        }

        private void configuraciones_Load(object sender, EventArgs e)
        {

        }

        private void timerConfiguraciones_Tick(object sender, EventArgs e)
        {
       
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Form Mantenimiento = new Proveedores();
            Mantenimiento.Show();
        }
    }
}
