using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;
using CapaDatos;
using CapaModeloMRP;

namespace CapaVistaMRP
{
    public partial class MDI_MRP : Form
    {
        private int childFormNumber = 0;
        sentencia sn = new sentencia();
        string usuarioact;
        modelo mo = new modelo();
        string ql = "select pp.cod_orden as 'codigo orden', pp.fecha_inicio as 'Fecha Inicio', pe.fecha_limite as 'Fecha Limite' from productos_proceso pp inner join produccion_encabezados pe on pp.cod_orden=pp.cod_orden  where pp.estado =1 order by pp.id_prodproc DESC LIMIT 4  ;";
        string ql2 = "select cod_opp as 'cod_pendiente', cod_orden as 'codigo orden', fecha_limite as 'Fecha Limite' from ordenes_pendientes where estado = 1 order by cod_opp DESC limit 4 ;";
        string ql3 = "select  cod_orden, costo_total from productos_terminados GROUP by cod_orden  order by cod_orden DESC limit 4 ";
        public MDI_MRP()
        {   
            InitializeComponent();

           

        }

        public void actualizardatagriew2(string sql, DataGridView dte)
        {

           
            DataTable dt = mo.consultaLogica2(sql);
           dte.DataSource = dt;
           
           
        }
        public void cu()
        {
            string sql = "select dr.id_detalle, (p.precio_producto/ dr.rendimiento_fijo) as 'costo_unitario' from productos p INNER JOIN detalles_recetas dr ON p.id_producto=dr.id_producto INNER JOIN produccion_procesos pp ON dr.id_proceso=pp.id_proceso where dr.estado =1 and pp.estado=1 and dr.rendimiento_fijo>0;";
            DataTable dt = mo.consultaLogica2(sql);
            int i = 0;

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var id = dt.Rows[i]["id_detalle"].ToString();
                    var costo = dt.Rows[i]["costo_unitario"].ToString();



                    mo.updateestados("detalles_recetas", "costo_unitario", costo, "id_detalle", id);


                    i++;

                }
            }


        }
        public void sumin() {

            DataTable dt = mo.consultaLogica2("select cod_solicitud from solicitudes_encabezados where estado = 1");
            int i = 0;

                if (dt.Rows.Count > 0) {

                foreach (DataRow row in dt.Rows)
                {
                    var id = dt.Rows[i]["cod_solicitud"].ToString();
                    mo.updateestados("solicitudes_encabezados", "estado", "0", "cod_solicitud", id);
                    mo.updateestados("solicitudes_detalles","estado","0","cod_solicitud",id);
                   
  i++;
                }
              
                }



        }
        public void suministros()
        {

            DataTable dt = mo.inventarios();

            if (dt.Rows.Count != 0)
            {

                int i = 0;

                string idmax = mo.idmax("solicitudes_encabezados", "cod_solicitud");


                foreach (DataRow row in dt.Rows)
                {
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    var dato = dt.Rows[i]["id_producto"].ToString();


                    var maximo = dt.Rows[i]["maximo"].ToString();
                    var cantidad = dt.Rows[i]["cantidad_total"].ToString();

                    string existe = mo.ObtenerSimple3("solicitudes_detalles", "id_producto", "id_producto", dato);


                    if (existe == "")
                    {
                        double max = Convert.ToDouble(maximo);
                        double cant = Convert.ToDouble(cantidad);

                        double resultado = max - cant;



                        string cadena = "INSERT INTO solicitudes_encabezados (cod_solicitud, fecha_solicitud , prioridad) VALUES(NULL, '" + fecha + "', 'Alta' );";
                        mo.insertar(cadena);
                        string detalle = " INSERT INTO solicitudes_detalles (cod_solicitud, id_producto, cantidad ) VALUES (" + idmax + " , " + dato + " , '" + resultado + "' ) ;";
                        mo.insertar(detalle);


                    }

                    i++;

                }
            }


        }
        public void productos()
        {

            string sql = "SELECT id_producto FROM productos p where p.id_tipo_producto = 1 and p.estado = 1 ;";
            DataTable dt = mo.consultaLogica2(sql);
            int i = 0;

            string fecha1 = DateTime.Now.ToString("yyyy-MM-dd");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var id = dt.Rows[i]["id_producto"].ToString();

                    string sql2 = "SELECT id_producto FROM costos_produccion where id_producto = " + id + " and estado =1;";

                    string resultado = mo.consulta(sql2);
                    

                    if (resultado == " ")
                    {
                        string insertar = "INSERT INTO costos_produccion (id_producto,fecha) values (" + id + ",'"+fecha1+"');";
                        mo.insertar(insertar);
                    }



                    i++;

                }
            }


        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

  

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void OrdenesDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ordenProduccion frm = new ordenProduccion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void SolicitudDeSuministrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solicitudSuministro frm = new solicitudSuministro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MantenimientoEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string consul = "select cod_orden from produccion_encabezados where estado=1;";

           string resul= mo.consulta(consul);

            if (resul != " ")
            {

                mantenimientoRegistroEmpleados frm = new mantenimientoRegistroEmpleados(lblUsuario.Text);
                frm.MdiParent = this;
                frm.Show();
            }
            else {

                MessageBox.Show("No hay Ordenes Para Producir, no se puede asignar ningun empleado ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }

        }

        

        private void MantenimientoProcesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           procesoProduccion frm = new procesoProduccion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void OrdenesPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void MantenimientoConfiguracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoInvConfg frm = new mantenimientoInvConfg(lblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void ProductosEnProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void GestionDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PedidosEspecialesCRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void MantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OrdenesPendientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ordenesPendientes frm = new ordenesPendientes(lblUsuario.Text);
            frm.MdiParent = this;
            frm.Show();
        }

        private void ProductosEnProcesoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            productosProceso frm = new productosProceso();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PedidosEspecialesCRMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pedidosEspeciales frm = new pedidosEspeciales("Cliente1");
            frm.MdiParent = this;
            frm.Show();
        }

        private void MDI_MRP_Load(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();

            lblUsuario.Text = login.obtenerNombreUsuario();
            usuarioact = lblUsuario.Text;
            productos();
            cu();
            suministros();
            timer1.Start();
            timer2.Start();


        }

        private void SeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoInvetarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoInventario frm = new mantenimientoInventario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void OrdenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantproductopovis frm = new mantproductopovis(lblUsuario.Text) ;
            frm.MdiParent = this;
            frm.Show();
        }

        private void SeguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            MDI_Seguridad seguridad = new MDI_Seguridad(lblUsuario.Text);
            seguridad.lbl_nombreUsuario.Text = lblUsuario.Text;
            seguridad.ShowDialog();
            sn.insertarBitacora(lblUsuario.Text, "Ingreso ", "Usuarios");
        }

        private void EstadisticasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rendimientoProducto frm = new rendimientoProducto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            actualizardatagriew2(ql, Dgv_ordenespen);
            actualizardatagriew2(ql2, Dgv_enProceso);
            actualizardatagriew2(ql3, Dgv_terminadas);
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MantenimientoUnidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoUnidadMedida frm = new mantenimientoUnidadMedida();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            sumin();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda-MRP/AyudaMRP.chm", "AyudaInicio.html");
        }
    }
}
