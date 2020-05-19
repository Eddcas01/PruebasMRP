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
   
    public partial class ordenesPendientes : Form
    {
        modelo mo = new modelo();
        string tabla = "ordenes_pendientes";
        string campoOrden = "fecha_limite";
        string[] aliasC = new string[40];
        string[] alias = { "Fecha Limite", "Numero de Orden", "Cod OPP", "Estado" };
        string[] alias2 = { "Cantidad", "Numero de Orden", "Cod_OPP", "Fecha Limite" };
        string usuario = "";
        public ordenesPendientes(string user)
        {
            InitializeComponent();
            Btn_producir.Enabled = false;
            Btn_cancelar.Enabled = false;
            usuario = user;
          

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
                        string insertar = "INSERT INTO costos_produccion (id_producto,fecha) values (" + id + ",'" + fecha1 + "');";
                        mo.insertar(insertar);
                    }



                    i++;

                }
            }


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
        public void cutmo() {
            string sql = "SELECT pr.id_producto ,sum(((pp.tiempo_pp*pd.cantidad_producto)*((s.salario*12)/52/40)/60)) as 'costo_mo' FROM empleados e INNER JOIN puestos p ON e.id_puesto=p.id_puesto INNER JOIN sueldos s ON p.id_sueldo=s.id_sueldo INNER JOIN registro_horas_emp rhe ON e.id_empleado=rhe.id_empleado INNER JOIN produccion_encabezados pe ON rhe.cod_orden=pe.cod_orden INNER JOIN produccion_detalles pd ON pe.cod_orden=pd.cod_orden INNER JOIN productos pr ON pd.id_producto=pr.id_producto INNER JOIN produccion_procesos pp ON pr.id_producto=pp.id_producto WHERE e.estado=1 and pd.estado=1 and pp.estado=1 and rhe.estado=1 GROUP BY pr.id_producto";
            DataTable dt = mo.consultaLogica2(sql);
            int i = 0;
            string fecha1 = DateTime.Now.ToString("yyyy-MM-dd");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var id = dt.Rows[i]["id_producto"].ToString();
                    var costo = dt.Rows[i]["costo_mo"].ToString();

                    //string sql1 = "INSERT INTO costos_produccion (id_producto, suma_costo_mo) VALUES("+id+","+costo+");";

                    //mo.insertar(sql1);

                    mo.updateestados("costos_produccion", "suma_costo_mo", costo, "id_producto", id);
                    


                    i++;

                }


            }



            }

        public void cutmp() {

            string sql = "SELECT pp.id_producto , sum(dr.costo_unitario) as 'costo_mp' FROM detalles_recetas dr  INNER JOIN produccion_procesos pp ON dr.id_proceso=pp.id_proceso WHERE dr.estado=1 and pp.estado=1 GROUP BY pp.id_proceso ";
            DataTable dt = mo.consultaLogica2(sql);
            int i = 0;
            

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var id = dt.Rows[i]["id_producto"].ToString();
                    var costo = dt.Rows[i]["costo_mp"].ToString();

                    //string sql1 = "INSERT INTO costos_produccion (id_producto, suma_costo_mp, fecha) VALUES(" + id + "," + costo + ", '"+fecha1+"');";

                  //  mo.insertar(sql1);

                    mo.updateestados("costos_produccion","suma_costo_mp",costo,"id_producto",id);



                    i++;

                }


            }




        }

        public void cif() {

            string sql= "SELECT pd.id_producto ,(ci.cantidad/sum(pd.cantidad_producto)) as 'cantidad' FROM cif ci, produccion_encabezados pe INNER JOIN produccion_detalles pd ON pe.cod_orden=pd.cod_orden INNER JOIN productos p on pd.id_producto=p.id_producto  WHERE pd.estado=1 and pe.estado=0 GROUP by pd.id_producto";
            DataTable dt = mo.consultaLogica2(sql);
            int i = 0;


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var id = dt.Rows[i]["id_producto"].ToString();
                    var costo = dt.Rows[i]["cantidad"].ToString();

                    //string sql1 = "INSERT INTO costos_produccion (id_producto, suma_costo_mp, fecha) VALUES(" + id + "," + costo + ", '"+fecha1+"');";

                    //  mo.insertar(sql1);

                    mo.updateestados("costos_produccion", "cif_unidad", costo, "id_producto", id);



                    i++;

                }


            }



        }

        public void ctp() {

            string sql = "SELECT id_producto, sum(suma_costo_mp+suma_costo_mo+cif_unidad) as 'cup' from costos_produccion WHERE estado = 1 GROUP BY id_producto";
            DataTable dt = mo.consultaLogica2(sql);
            int i = 0;


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var id = dt.Rows[i]["id_producto"].ToString();
                    var costo = dt.Rows[i]["cup"].ToString();

                    //string sql1 = "INSERT INTO costos_produccion (id_producto, suma_costo_mp, fecha) VALUES(" + id + "," + costo + ", '"+fecha1+"');";

                    //  mo.insertar(sql1);

                    mo.updateestados("costos_produccion", "costo_unitario_producto", costo, "id_producto", id);

                    mo.updateestados("costos_produccion", "estado","0","id_producto",id);

                    i++;

                }


            }


        }

      
        public void actualizardatagriew()
        {
            DataTable dt = mo.consultaLogica0(tabla,campoOrden);
            Dgb_ordenesPendientes.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla))
            {
                Dgb_ordenesPendientes.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }
        public void actualizarfatagridorden() {
            DataTable dt = mo.orden();
            Dgb_ordenesPendientes.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla))
            {
                Dgb_ordenesPendientes.Columns[head].HeaderText = aliasC[head];
                head++;
            }



        }

        public void asignarAlias(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }
        public void asignarAlias2(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Dgb_ordenesPendientes_DoubleClick(object sender, EventArgs e)
        {

            
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            if (Dgb_ordenesPendientes.SelectedRows.Count == 1)
            {
                string where = Dgb_ordenesPendientes.CurrentRow.Cells[1].Value.ToString();


                modificarOrden frm = new modificarOrden(where);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            else {
                MessageBox.Show("No hay datos seleccionados en la tabla ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }


        private void Btn_producir_Click(object sender, EventArgs e)
        {



            if (Dgb_ordenesPendientes.SelectedRows.Count == 1)
            {

                int i = 0;
                string where = Dgb_ordenesPendientes.CurrentRow.Cells[1].Value.ToString();
                string emp = "SELECT rhe.id_empleado  FROM registro_horas_emp rhe INNER JOIN produccion_encabezados pe on rhe.cod_orden=pe.cod_orden WHERE pe.cod_orden = " + where + " and rhe.estado=1 ;";
                string empl = mo.consulta(emp);
               
           
           
                    if (empl != " ")
                    {

                        string where2 = Dgb_ordenesPendientes.CurrentRow.Cells[2].Value.ToString();
                        mo.updateestados("produccion_encabezados", "estado", "0", "cod_orden", where);
                        mo.updateestados("ordenes_pendientes", "estado", "0", "cod_opp", where2);

                        string inventario = "select dr.id_producto, dr.cantidad, dr.unidad_medida as 'umr' ,pd.cantidad_producto , ip.cantidad_total, ip.unidad_medida as 'umi'  from detalles_recetas dr INNER JOIN produccion_procesos pp ON dr.id_proceso=pp.id_proceso INNER JOIN produccion_detalles pd ON pp.id_producto=pd.id_producto INNER JOIN produccion_encabezados pe ON pd.cod_orden=pe.cod_orden INNER JOIN inventarios_produccion ip ON dr.id_producto =ip.id_producto  WHERE pd.cod_orden= "+where+" and dr.estado=1 and ip.estado=1;";
                        DataTable dt = mo.consultaLogica2(inventario);


                        foreach (DataRow row in dt.Rows)
                        {
                            var dato = dt.Rows[i]["id_producto"].ToString();
                            var cantidad = dt.Rows[i]["cantidad"].ToString();
                            var existencia = dt.Rows[i]["cantidad_total"].ToString();
                            var mult = dt.Rows[i]["cantidad_producto"].ToString();
                            var umr = dt.Rows[i]["umr"].ToString();
                            var umi = dt.Rows[i]["umi"].ToString();

                        string conv = mo.consulta("select cantidad2 from unidades_medida where unidad1 = '"+umr+"' and unidad2 = '"+umi+"' and estado = 1;");
                        if (conv != "" || conv != null)
                        {
                            double conv2 = Convert.ToDouble(conv);

                            int mm = Convert.ToInt32(mult);
                            double max = Convert.ToDouble(existencia);
                            double cant = Convert.ToDouble(cantidad);

                            double resul = (cant * conv2) * mm;
                            double resultado = max - resul;

                            string result = resultado.ToString();

                            mo.updateestados("inventarios_produccion", "cantidad_total", result, "id_producto", dato);
                        }
                        else
                        {

                            MessageBox.Show("el registro no existe o esta mal ingresado, revisar las dimensionales de unidades de medida ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }


                            i++;
                        }

                        suministros();
                        actualizardatagriew();
                        productos();
                        cu();
                        cutmo();
                        cutmp();
                        cif();
                        ctp();

                        productosProceso frm = new productosProceso();
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                    else {
                        MessageBox.Show("No hay empleados asignados e esta orden, Por favor asgine en Mantenimiento 4001", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        mantenimientoRegistroEmpleados frm = new mantenimientoRegistroEmpleados(usuario);
                        frm.MdiParent = this.MdiParent;
                        frm.Show();

                    }
              
            }
            else {
                MessageBox.Show("No hay datos seleccionados en la tabla ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            
         
        }
        public void limpiardgb() {

            
            Dgb_ordenesPendientes.DataSource = " ";



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
        private void Cmb_Orden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Orden.Text == "Orden por Fecha")
            {
                limpiardgb();
                asignarAlias(alias);
                actualizardatagriew();

                if (Dgb_ordenesPendientes.RowCount > 0)
                {

                    Btn_producir.Enabled = true;
                    Btn_cancelar.Enabled = true;
                }


            }
            if (Cmb_Orden.Text == "Orden por Cantidad")
            {
                limpiardgb();
                asignarAlias2(alias2);
                actualizarfatagridorden();
                if (Dgb_ordenesPendientes.RowCount > 0)
                {

                    Btn_producir.Enabled = true;
                    Btn_cancelar.Enabled = true;
                }


            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda-MRP/AyudaMRP.chm", "AyudaOrdenPendiente.html");
        }
    }
}
