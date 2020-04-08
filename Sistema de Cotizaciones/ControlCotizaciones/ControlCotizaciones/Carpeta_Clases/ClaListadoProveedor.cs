using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ControlCotizaciones.Carpeta_Clases;
using System.Windows.Forms;


namespace ControlCotizaciones.Carpeta_Clases
{
    class ClaListadoProveedor
    {
        private List<ClaProveedor> proveedor;
        private ClaConexion conexion;
        private DataTable tabla;
        private DateTime fecha;
        public ClaListadoProveedor()


        {
            proveedor = new List<ClaProveedor>();
            conexion = new ClaConexion();
            tabla = new DataTable();
            fecha = DateTime.Today;
            Cargar_Datos();
        }
        private void Cargar_Datos()
        {
            conexion.Conectar();
            tabla = conexion.consultar(string.Format("SELECT CodigoProveedor, NombreProveedor, Direccion, Telefono, TelefonoSecundario FROM dbicma.Proveedor"));
            foreach (DataRow f in tabla.Rows)
            {
                ClaProveedor datos = new ClaProveedor();
                datos.CodigoProveedor = f.Field<int>(0);
                datos.NombreProveedor = f.Field<string>(1);
                datos.DireccionProveedor = f.Field<string>(2);
                datos.TelefonoProveedor = f.Field<string>(3);
                datos.TelefonoSecundarioProveedor = f.Field<string>(4);
                proveedor.Add(datos);
            }
        }

            public List<ClaProveedor> ListaProveedor
        {
            get
            {
                return proveedor;
            }
        }
        public DataTable Tabla
        {
            get { return tabla;
            }
        }
        public DataTable SQL(string sql)
        {
            DataTable t = conexion.consultar(sql);
            return t;
        }
    }
    }

