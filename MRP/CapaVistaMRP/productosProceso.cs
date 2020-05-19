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
    public partial class productosProceso : Form
    {
        modelo mo = new modelo();
        string tabla = "productos_proceso";
        string[] aliasC = new string[40];
        string[] alias = { "cod_produccion", "Numero de orden", "fecha de inicio", "estado"};

        public productosProceso()
        {
            InitializeComponent();
           
            asignarAlias(alias);
            actualizardatagriew();

            if (dgb_productosProceso.Rows.Count >1) {
                actualizarod();
                cord();

            }
           
        }
        public void cord()
        {
            string sql = "SELECT pd.cod_orden ,cp.costo_unitario_producto* pd.cantidad_producto as 'costo_orden' FROM costos_produccion cp INNER JOIN produccion_detalles pd ON cp.id_producto=pd.id_producto inner join produccion_encabezados pe on pd.cod_orden=pe.cod_orden inner join productos_proceso pp on pp.cod_orden=pe.cod_orden   where pp.estado=0 group by pe.cod_orden";

            DataTable dt = mo.consultaLogica2(sql);
            int i = 0;


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var id = dt.Rows[i]["cod_orden"].ToString();
                    var costo = dt.Rows[i]["costo_orden"].ToString();

                    //string sql1 = "INSERT INTO costos_produccion (id_producto, suma_costo_mp, fecha) VALUES(" + id + "," + costo + ", '"+fecha1+"');";

                    //  mo.insertar(sql1);


                    mo.updateestados("productos_terminados", "costo_total", costo, "cod_orden", id);



                    i++;

                }


            }

        }
        public void actualizarod() {

            string fecha = "select pe.cod_orden from produccion_encabezados pe INNER JOIN productos_proceso pp on pe.cod_orden=pp.cod_orden where pe.estado = 0 and  pe.fecha_limite <= now();";
            DataTable dt = mo.consultaLogica2(fecha);
            int i = 0;


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var id = dt.Rows[i]["cod_orden"].ToString();
                    

                    //string sql1 = "INSERT INTO costos_produccion (id_producto, suma_costo_mp, fecha) VALUES(" + id + "," + costo + ", '"+fecha1+"');";

                    //  mo.insertar(sql1);

                    mo.updateestados("productos_proceso", "estado", "0", "cod_orden", id);


                    i++;

                }


            }




        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dgb_productosProceso.SelectedRows.Count == 1)
            {

                string where = dgb_productosProceso.CurrentRow.Cells[1].Value.ToString();


                enProcesoDetalle frm = new enProcesoDetalle(where);//pasarle el id del encabezado que se esta consultando
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            else {

                MessageBox.Show("No hay datos seleccionados en la tabla ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            
        }


        public void actualizardatagriew()
        {
            DataTable dt = mo.consultaLogica(tabla);
            dgb_productosProceso.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla))
            {
                dgb_productosProceso.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }

        public void asignarAlias(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }

        private void ProductosProceso_Load(object sender, EventArgs e)
        {
            if (dgb_productosProceso.Rows.Count > 0)
            {
                button1.Enabled = true;
                button2.Enabled=true;
            }
            else {

                button1.Enabled = false;
                button2.Enabled = false;
            }

            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string id = dgb_productosProceso.CurrentRow.Cells[1].Value.ToString();
            if (dgb_productosProceso.SelectedRows.Count == 1)
            {
                mo.updateestados("productos_proceso", "estado", "0", "cod_orden", id);
                actualizardatagriew();
            }
            else {
                MessageBox.Show("Ningun dato seleccionado ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda-MRP/AyudaMRP.chm", "AyudaOrdenPendiente.html");
        }
    }
}
