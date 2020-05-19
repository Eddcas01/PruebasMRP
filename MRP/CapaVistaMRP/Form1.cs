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
    public partial class Form1 : Form
    {
        modelo mo = new modelo();
        public Form1()
        {
            InitializeComponent();
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
        public void cutmo()
        {
            string sql = "SELECT pr.id_producto  ,((pp.tiempo_pp*pd.cantidad_producto)*((s.salario*12)/52/40)/60) as 'costo_mo' FROM empleados e INNER JOIN puestos p ON e.id_puesto=p.id_puesto INNER JOIN sueldos s ON p.id_sueldo=s.id_sueldo INNER JOIN registro_horas_emp rhe ON e.id_empleado=rhe.id_empleado INNER JOIN produccion_encabezados pe ON rhe.cod_orden=pe.cod_orden INNER JOIN produccion_detalles pd ON pe.cod_orden=pd.cod_orden INNER JOIN productos pr ON pd.id_producto=pr.id_producto INNER JOIN produccion_procesos pp ON pr.id_producto=pp.id_producto WHERE e.estado=1 and pd.estado=1 and pp.estado=1 GROUP BY e.id_empleado";
            DataTable dt = mo.consultaLogica2(sql);
            int i = 0;
            string fecha1 = DateTime.Now.ToString("yyyy-MM-dd");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var id = dt.Rows[i]["id_producto"].ToString();
                    var costo = dt.Rows[i]["costo_mo"].ToString();

                    string sql1 = "INSERT INTO costos_produccion (id_producto, suma_costo_mo, fecha) VALUES(" + id + "," + costo + ", '" + fecha1 + "');";

                    mo.insertar(sql1);




                    i++;

                }


            }



        }

        public void cutmp()
        {

            string sql = "SELECT pp.id_producto , sum(dr.costo_unitario) as 'costo_mp' FROM detalles_recetas dr  INNER JOIN produccion_procesos pp ON dr.id_proceso=pp.id_proceso WHERE dr.estado=1 and pp.estado=1 GROUP BY pp.id_proceso ";
            DataTable dt = mo.consultaLogica2(sql);
            int i = 0;
            string fecha1 = DateTime.Now.ToString("yyyy-MM-dd");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var id = dt.Rows[i]["id_producto"].ToString();
                    var costo = dt.Rows[i]["costo_mp"].ToString();

                    //string sql1 = "INSERT INTO costos_produccion (id_producto, suma_costo_mp, fecha) VALUES(" + id + "," + costo + ", '"+fecha1+"');";

                    //  mo.insertar(sql1);
                    MessageBox.Show(id);
                    MessageBox.Show(costo);
                    mo.updateestados("costos_produccion", "suma_costo_mp", costo, "id_producto", id);



                    i++;

                }


            }




        }
        public void productos()
        {

            string sql = "SELECT id_producto FROM productos p where p.id_tipo_producto = 1 and p.estado = 1 ;";
            DataTable dt = mo.consultaLogica2(sql);
            int i = 0;



            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    var id = dt.Rows[i]["id_producto"].ToString();

                    string sql2 = "SELECT id_producto FROM costos_produccion where id_producto = " + id + ";";

                    string resultado = mo.consulta(sql2);
                    MessageBox.Show(resultado);

                    if (resultado == " ")
                    {
                        string insertar = "INSERT INTO costos_produccion (id_producto) values (" + id + ");";
                        mo.insertar(insertar);
                    }



                    i++;

                }
            }


        }
        private void Button1_Click(object sender, EventArgs e)
        {

            cutmp();










        }
    }
}
