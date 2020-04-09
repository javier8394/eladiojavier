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
            direccionProveedor = "";
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


        public Boolean Guardar()
        {
            if (conexion.Ejecutar(string.Format("INSERT INTO `dbicma`.`Proveedor` (`NombreProveedor`, `Direccion`, `Telefono`, `TelefonoSecundario`) VALUES ('{0}', {1}, '{2}', {3})", NombreProveedor, DireccionProveedor, TelefonoProveedor, TelefonoSecundarioProveedor)))
            {
                DataTable codigoBD = conexion.consultar("SELECT NombreProveedor FROM  Proveedor");

                DataRow codigoInt = codigoBD.Rows[0];



                MessageBox.Show("El proveedor se agrego correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return true;
        }


        public String TelefonoSecundarioProveedor
        {
            get
            {
                return telefonoSecundarioProveedor;
            }
            set
            {
                telefonoSecundarioProveedor = value;
            }

        }

        public Boolean Modificar()
        {
            if (conexion.Ejecutar(string.Format("UPDATE `dbicma`.`Proveedor` SET `NombreProveedor` = '{0}', `Direccion` = {1}, `Telefono` = '{2}', `TelefonoSecundario` = {3}", NombreProveedor, DireccionProveedor, TelefonoProveedor, TelefonoSecundarioProveedor)))
            {

                if (conexion.Ejecutar(string.Format("UPDATE `dbicma`.`Proveedor` SET `NombreProveedor` = '{0}', `Direccion` = {1}, `Telefono` = '{2}', `TelefonoSecundario` = {3}", NombreProveedor, DireccionProveedor, TelefonoProveedor, TelefonoSecundarioProveedor)))
                {
                    MessageBox.Show("El proveedor  se modifico correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return true;
        }
        public Boolean Buscar(int nombre)
        {
            DataTable t1 = conexion.consultar(string.Format("SELECT NombreProveedor,Direccion,Telefono, TelefonoSecundario FROM dbicma.Proveedor "));
            {
                NombreProveedor = t1.Rows[0][0].ToString();
                DireccionProveedor = t1.Rows[0][1].ToString();
                TelefonoProveedor = t1.Rows[0][2].ToString();
                TelefonoSecundarioProveedor = t1.Rows[0][3].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


