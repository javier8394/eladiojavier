using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices; //Nos permite usar librerias nativas del sistema operativo
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp; //Importamos la libreria Fontawesome

namespace ControlCotizaciones
{
    public partial class MenuPrincipal : Form
    {
        //Declaramos campos de forma privada para almacenar el boton actual y un panel para aplicar un borde 
        //izquierdo al boton
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        //Declaramos un campode tipo formulario para almacenar el formuario actual
        private Form formularioHijoActual = new Form();

        //Constructor
        public MenuPrincipal()
        {

            InitializeComponent();
            //inicializamos el panel del borde izquierdo
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);

            //Se agrega el panel borde izquierdo del boton de los controles del panel menu
            panelMenu.Controls.Add(leftBorderBtn);

            // Para Quitar La barra de Titulo

            this.Text = string.Empty; //Colocamos una cadena vacia en el texto del formulario
            this.ControlBox = false; //Quitamos la caja de control
            this.DoubleBuffered = true; //Activamos buffered
            //Par evitar que ocupe toda la pantalla establecemos los limites del formulario
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //CREACION DE METODOS

        //Metodo para resaltar el boton activo
        private void ActivateButton(object senderbtn, Color color)
        {
            //verficamos que el boton sea diferente a nulo
            if (senderbtn != null)
            {
                //Antes de todo llamamos el metodo antes de resaltar el boton y desactivar el boton anterior

                DisableButton();

                //============= personalizacion del boton y el borde izquierdo ==========

                //asignamos el boton actual con el boton remitente
                //y convertimos el objeto al mismo tipo de boton
                currentBtn = (IconButton)senderbtn;
                //cambiamos el color del boton
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                // y el color de texto al del parametro color
                currentBtn.ForeColor = color;
                //alineamos el texto a el centro
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                // y el color del icono al parametro color
                currentBtn.IconColor = color;
                // y la relacion texto imagen a imagen antes de texto
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //alineamos el icono a la derecha
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //====== BORDE IZQUIERDO DEL BOTON ======
                leftBorderBtn.BackColor = color;
                //asignamos ubicaciones x y y en el boton atual
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                //colocar la visivilidad en verdadero
                leftBorderBtn.Visible = true;
                // lo traemos al frente
                leftBorderBtn.BringToFront();

                //Cambio del icono del formulario al mismo del boton actual
                iconDeFormulario.IconChar = currentBtn.IconChar;
                iconDeFormulario.IconColor = color;
            }
        }

        // METODO PARA DESACTIVAR EL RESALTADO DEL BOTON
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //Si eso es asi vamos a retornar la configuracion de el boton a los valorees por defecto

                //cambiamos el color del boton
                currentBtn.BackColor = Color.FromArgb(29, 46, 66);
                // y el color de texto al del parametro color
                currentBtn.ForeColor = Color.White;
                //alineamos el texto a el centro
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                // y el color del icono al parametro color
                currentBtn.IconColor = Color.White;
                // y la relacion texto imagen a imagen antes de texto
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //alineamos el icono a la derecha
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        //Crearemos una estructura para almacenar colores RGB

        private struct ColoresRGB
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(29, 234, 8);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }


  

        ///========================         Eventos Click de los botones del panel =======================================


        private void btnClientes_Click(object sender, EventArgs e)
        {
            //En el evento click de cada boton mandamos a llamar el metodo activar boton
            ActivateButton(sender, ColoresRGB.color3);

            //llamamos el formulario hijo desde los eventos click
            abrirFormularioHijo(new ClientesMantenimiento());


        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColoresRGB.color3);
            //llamamos el formulario hijo desde los eventos click
            abrirFormularioHijo(new cotizaciones());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColoresRGB.color3);

            //llamamos el formulario hijo desde los eventos click
            abrirFormularioHijo(new Reportes());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColoresRGB.color3);

            //llamamos el formulario hijo desde los eventos click
            abrirFormularioHijo(new prodcutoMantenimiento());
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColoresRGB.color3);

            //llamamos el formulario hijo desde los eventos click
            abrirFormularioHijo(new Proveedores());
        }


        private void btnlogo(object sender, EventArgs e)
        {
            
            formularioHijoActual.Close();
            //Metodo de reiniciar
            Reset();
        }

        //En ese metodo vamos a llamar el metodo desactivar boton
        private void Reset()
        {
            //ocultamos la visibilidad del borde izquierdo del boton
            DisableButton();
            leftBorderBtn.Visible = false;
            //Cambio del icono del formulario al mismo del boton actual
            iconDeFormulario.IconChar = IconChar.Home;
            iconDeFormulario.IconColor = Color.Lime;
            lblTituloDeFormulario.Text = "Inicio";
        }
        // Drag form


        // using System.Runtime.InteropServices; //Nos permite usar librerias nativas del sistema operativo

        //[DllImport("User32.DLL", EntryPoint = "ReleaseCapture")] //Permite mover el formulario atravez del evento del mouse
        //private extern static void ReleaseCapture();

        //[DllImport("User32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParan);

        //Evento Mouse Down (para la funcion de arrastrar el formulario desde el panel de barra de titulo

        //private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        //{
           // ReleaseCapture();
           // SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}

        //Abriendo Formularios dentro del Formulario Principal

        //Creamos un MEtodo de Abrir "formulario hijo"

        private void abrirFormularioHijo(Form formulariohijo) //como parametro un campo de tipo formulario
        {
            //Condicion si el formulario es distinto de null lo cerramos
            if (formularioHijoActual != null)
            {
                formularioHijoActual.Close(); //de esta manera solo abriremos unicamente un formulario
            }

            formularioHijoActual = formulariohijo;
            formulariohijo.TopLevel = false; //indicamos que no es de nivel superior
            formulariohijo.FormBorderStyle = FormBorderStyle.None; //le quitamos los bordes
            formulariohijo.Dock = DockStyle.Fill; //Para que llene el contenedor
            //Agegamosel formulario hijo a los controles del panel escritorio
            formulariohijo.Anchor = AnchorStyles.None;
            panelFondo.Controls.Add(formulariohijo);
            //Tamano del formulario hijo sea igual al del panel
            formulariohijo.Size = panelFondo.Size;
            //Asociamos los datos del formulario al panel
            panelFondo.Tag = formulariohijo;
            formulariohijo.BringToFront(); //Loa traemos al frente
            formulariohijo.Show();
            //Mostramos el nombre  del formulario en la etiqueta titulo
            lblTituloDeFormulario.Text = formulariohijo.Text;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelFondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColoresRGB.color3);

            //llamamos el formulario hijo desde los eventos click
            abrirFormularioHijo(new configuraciones());

        }
    }
}
