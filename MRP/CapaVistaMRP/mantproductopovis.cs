using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaMRP
{
    public partial class mantproductopovis : Form
    {
        string usuario = "";
        public mantproductopovis(string user)
        {
            InitializeComponent();
            usuario = user;
            string[] alias = { "cod prod","id_tipo prod","nombre prod","descripcion","costo prod","precio prod","stock", "cantidad_maxima_producto", "cantidad_minima_product", "estado"};
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            Color Hotel = Color.FromArgb(253, 254, 254);
            navegador1.asignarColorFondo(Hotel);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("1");

            navegador1.asignarTabla("productos");
            navegador1.asignarNombreForm("");

        }

        private void Navegador1_Load(object sender, EventArgs e)
        {

            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
