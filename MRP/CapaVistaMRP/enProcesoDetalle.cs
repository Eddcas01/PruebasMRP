using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloMRP;

namespace CapaVistaMRP
{
    public partial class enProcesoDetalle : Form
    {
        modelo mo = new modelo();
        string donde;
        string tabla = "produccion_encabezados";
        string tabla2 = "produccion_detalles";
        string[] aliasC = new string[120];
        string[] alias = { "Numero de Orden", "fecha orden", "fecha limite","tipo de produccion", "Estado"};
        string[] alias2 = { "Nombre de Producto", "Cantidad Total", "Numero de detalle", "Numero de Orden", "Estado" };
        public enProcesoDetalle(string dato)
        {
            InitializeComponent();
            asignarAlias(alias);          
            actualizardatagriew(dato);
            asignarAlias2(alias2);
            actualizardatagriew2(dato);
          

        }




        public void actualizardatagriew(string algo)
        {
            
            DataTable dt = mo.consultaLogica3(algo);
            Dgb_encabezadoProductosP.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla))
            {
                Dgb_encabezadoProductosP.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }

        public void asignarAlias(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }

        public void actualizardatagriew2(string encab)
        {
            DataTable dt = mo.consultaLogica4(encab);
            Dgb_detalleProductosP.DataSource = dt;  
            int head = 0;
            while (head < mo.contarCampos(tabla2))
            {
                Dgb_detalleProductosP.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }

        public void asignarAlias2(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda-MRP/AyudaMRP.chm", "AyudaOrdenPendiente.html");
        }
    }
}
