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
    public partial class mantenimientoRegistroEmpleados : Form
    {
        string usuario = "";
        public mantenimientoRegistroEmpleados(string user)
        {
            InitializeComponent();
       
            usuario = user;
            string[] alias = { "cod_registro","cod_orden","cod_empleado","fecha", "hora_entrada", "Salida_almuerzo", "Entrada_almuerzo", "salida", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            Color Hotel = Color.FromArgb(253, 254, 254);
            navegador1.asignarColorFondo(Hotel);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("1");
            navegador1.asignarComboConTabla("produccion_encabezados", "cod_orden", 0);
            navegador1.asignarComboConTabla("empleados", "id_empleado", 0);
            navegador1.asignarTabla("registro_horas_emp");
            navegador1.asignarNombreForm("");
        }

        private void MantenimientoRegistroEmpleados_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
      
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda-MRP/AyudaMRP.chm", "AyudaMantenimientoEMP.html");
        }
    }
    }

