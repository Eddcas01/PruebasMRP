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
    public partial class mantenimientoInvConfg : Form
    {
        string usuario = "";
        public mantenimientoInvConfg(string user)
        {
            InitializeComponent();
         
            usuario = user;
            string[] alias = { "cod_config", "Temporada", "max", "repedido", "minimo", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            Color Hotel = Color.FromArgb(253, 254, 254);
            navegador1.asignarColorFondo(Hotel);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("configuraciones_inventarios");
            navegador1.asignarNombreForm("");
        }

     

        

        private void MantenimientoInvConfg_Load_1(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda-MRP/AyudaMRP.chm", "AyudaMantenimientoConf.html" );
        }
    }
}
