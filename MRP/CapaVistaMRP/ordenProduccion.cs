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
    public partial class ordenProduccion : Form
    {
        modelo mo = new modelo();
        public ordenProduccion()
        {
            InitializeComponent();
            cmb_productos.llenarse("productos", "id_producto", "nombre_producto");
            grb_detalle.Enabled = false;
            lbl_noOrden.Text = mo.idmax("produccion_encabezados", "cod_orden");

           
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            Dtp_fechalim.Format = DateTimePickerFormat.Custom;
            Dtp_fechalim.CustomFormat = "yyyy-MM-dd";
            Lbl_date.Text = fecha;
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Btn_orden_Click(object sender, EventArgs e)
        {
            string fecha1 = DateTime.Now.ToString("yyyy-MM-dd");
            string fecha2 = Dtp_fechalim.Text;

            grb_detalle.Enabled = true;
            grb_encabezado.Enabled = false;
            string cantidad = Nud_cantidad.Value.ToString();


            string cadena = "INSERT INTO produccion_encabezados (cod_orden, fecha_orden, fecha_limite, tipo_produccion, estado) VALUES(NULL,'" + fecha1 + "','" + fecha2 + "', 'Ordinaria_Modificada',1);";
            mo.insertar(cadena);

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {

            string primero = cmb_productos.ObtenerIndif();
            string cantidad = Nud_cantidad.Value.ToString();
            string fecha = Lbl_date.Text;
            string fechalim = Dtp_fechalim.Text;

            Dgb_pedidosEspeciales.Rows.Add(primero, cantidad, fecha, fechalim);
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Dgb_pedidosEspeciales.SelectedRows.Count == 1)
            {


                Dgb_pedidosEspeciales.Rows.RemoveAt(Dgb_pedidosEspeciales.CurrentRow.Index);
            }
        }

        private void Btn_generarod_Click(object sender, EventArgs e)
        {
            string idmax = lbl_noOrden.Text;

            foreach (DataGridViewRow row in Dgb_pedidosEspeciales.Rows)
            {
                string cadena = "INSERT INTO produccion_detalles (id_detalle, cod_orden, id_producto, cantidad_producto, estado) VALUES(NULL," + idmax + ",'" + row.Cells[0].Value.ToString() + "'," + row.Cells[1].Value.ToString() + ",1);";
                mo.insertar(cadena);
            }

            MessageBox.Show("Orden Generada");
            this.Close();
        }
    }
}
