using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace ControlCotizaciones.Carpeta_Clases
{
    class ClaProveedor
    {
        private int codigoProveedor;
        private string nombreProveedor;
        private string direccionProveedor;
        private string telefonoProveedor;
        private string telefonoSecundarioProveedor;
        private ClaConexion conexion;

        public ClaProveedor()
      {
            codigoProveedor = 0;
            nombreProveedor = "";
            direccionProveedor= "";
            telefonoProveedor = "";
            telefonoSecundarioProveedor = "";
            conexion = new ClaConexion();

        }
        public ClaProveedor(int codigoProveedor, string nombre, string direccion, string telefono, string telefonoSecundario)
        {
            codigoProveedor = 0;
            nombreProveedor = nombre;
            direccionProveedor = direccion;
            telefonoProveedor = telefono;
            telefonoSecundarioProveedor = telefonoSecundario;
            conexion = new ClaConexion();

        }

        public int CodigoProveedor
        {
            get
            {
                return codigoProveedor;
            }
            set
            {
                codigoProveedor = value;
            }
        }
        public String NombreProveedor
        {
            get
            {
                return nombreProveedor;
            }
            set
            {
                nombreProveedor = value;
            }
        }
        public String DireccionProveedor
        {
            get
            {
                return direccionProveedor;
            }
            set
            {
                direccionProveedor = value;
            }
        }
        public String TelefonoProveedor
        {
            get
            {
                return telefonoProveedor;
            }
            set
            {
                telefonoProveedor = value;

            }
        }

        internal void Guardar()
        {
            throw new NotImplementedException();
        }

        public String TelefonoSecundarioProveedor
        {
            get
            {
              return  telefonoSecundarioProveedor;
            }
            set
            {
                telefonoSecundarioProveedor = value;
            }

        }

        internal void Modificar()
        {
            throw new NotImplementedException();
        }
    }
}
