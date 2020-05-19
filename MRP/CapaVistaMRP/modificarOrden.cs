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
    public partial class modificarOrden : Form
    {
        string orden="";
        modelo mo = new modelo();
        string tabla2 = "produccion_detalles";
        string[] aliasC = new string[120];
        string[] alias = { "Nombre de Producto", "Cantidad Total", "Numero de detalle", "Numero de Orden", "Estado" };
        public modificarOrden(string codorden)
        {
            InitializeComponent();
            cmb_productos.llenarse2("productos", "id_producto", "nombre_producto","id_tipo_producto","1");
            orden = codorden;
            lbl_noOrden.Text = orden;
            Dtp_fechalim.Enabled = false;
            Dtp_fechalim.Format = DateTimePickerFormat.Custom;
            Dtp_fechalim.CustomFormat = "yyyy-MM-dd";
            Dtp_FechaOrden.Format = DateTimePickerFormat.Custom;
            Dtp_FechaOrden.CustomFormat = "yyyy-MM-dd";
            asignarAlias2(alias);
            actualizardatagriew2(orden);
            Dtp_FechaOrden.Enabled = false;
            Btn_actualizarFecha.Enabled=false;
            lbl_tipo.Text = mo.ObtenerSimple("produccion_encabezados", "tipo_produccion", "cod_orden", orden);
            Dtp_FechaOrden.Text = mo.ObtenerSimple("produccion_encabezados", "fecha_orden", "cod_orden", orden);
            Dtp_fechalim.Text = mo.ObtenerSimple("produccion_encabezados", "fecha_limite", "cod_orden", orden);

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {


            
            int existe = cmb_productos.existe(cmb_productos.texto2());

            if (existe != -1 && cmb_productos.texto2() != "")
            {
                string idmax = lbl_noOrden.Text;
                string prod = cmb_productos.ObtenerIndif();
                string cant = Nud_cantidad.Value.ToString();
                string cadena = "INSERT INTO produccion_detalles (id_detalle, cod_orden, id_producto, cantidad_producto, estado) VALUES(NULL," + idmax + ",'" + prod + "'," + cant + ",1);";
                mo.insertar(cadena);
                actualizardatagriew2(idmax);
            }

            else {

                MessageBox.Show("Por favor llene los campos correspondientes para un registro correcto ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            


            MessageBox.Show("Orden Generada");
            this.Close();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            string idmax = lbl_noOrden.Text;

            if (Dgb_modificarOd.RowCount == 1) {
                MessageBox.Show("No puede eliminar todos los elementos de la Orden ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

            //si da tiempo agregar btn restar cantidad
            else
            {
                if (Dgb_modificarOd.SelectedRows.Count == 1)
                {

                    string id = Dgb_modificarOd.CurrentRow.Cells[2].Value.ToString();
                    mo.updateestados("produccion_detalles", "estado", "0", "id_detalle", id);
                }
                else
                {

                    MessageBox.Show("Ya no hay elementos para eliminar ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

              
            }


            /*DialogResult resul =  MessageBox.Show("¿Esta seguro que desea actualizar esta orden? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resul == DialogResult.Yes)
            {                              }*/


            actualizardatagriew2(idmax);

        }
        public void actualizardatagriew2(string encab)
        {
            DataTable dt = mo.consultaLogica4(encab);
            Dgb_modificarOd.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla2))
            {
                Dgb_modificarOd.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }
        

        public void asignarAlias2(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }

        private void Chb_editar_CheckedChanged(object sender, EventArgs e)
        {
            Dtp_fechalim.Enabled = true;
            Btn_actualizarFecha.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string id = lbl_noOrden.Text;
            string fecha = Dtp_fechalim.Text;
            mo.updateestados("produccion_encabezados","fecha_limite",fecha,"cod_orden",id);

            Dtp_fechalim.Enabled = false;
            Btn_actualizarFecha.Enabled = false;
        }

        private void Grb_encabezado_Enter(object sender, EventArgs e)
        {
            
        }

        private void ModificarOrden_Load(object sender, EventArgs e)
        {
            Dtp_fechalim.MinDate = Dtp_FechaOrden.Value.AddDays(7);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda-MRP/AyudaMRP.chm", "AyudaOrdenPendiente.html");
        }
    }
}
