using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaModeloMRP;
using System.Diagnostics;
using InputKey;

namespace CapaVistaMRP
{
    public partial class rendimientoProducto : Form
    {
        string[] series1 = new string[120] ;
        double[] puntos = new double[120];
        
        modelo mo = new modelo();
        public rendimientoProducto()
        {
            InitializeComponent();
            
            Dtp_Fechadesde.Format = DateTimePickerFormat.Custom;
            Dtp_Fechadesde.CustomFormat = "yyyy-MM-dd";
            Dtp_fechaHasta.Format = DateTimePickerFormat.Custom;
            Dtp_fechaHasta.CustomFormat = "yyyy-MM-dd";

        }

        public void estatics() {
           
            string desde = Dtp_Fechadesde.Text;
            string hasta = Dtp_fechaHasta.Text;


            string sql = "SELECT  p.nombre_producto,sum(pd.cantidad_producto) as 'cantidad' FROM produccion_encabezados pe INNER JOIN produccion_detalles pd on pe.cod_orden=pd.cod_orden INNER JOIN productos p ON pd.id_producto=p.id_producto WHERE   pe.fecha_orden BETWEEN '"+desde+"' AND '"+hasta+"' GROUP by pd.id_producto;";
            DataTable dt = mo.consultaLogica2(sql);
            int i = 0;


            if (dt.Rows.Count > 0)
            {
                

                foreach (DataRow row in dt.Rows)
                {
                    var nombre = dt.Rows[i]["nombre_producto"].ToString();
                    var cantidad = dt.Rows[i]["cantidad"].ToString();

                    double cant = Convert.ToDouble(cantidad);


                    series1[i] = nombre;
                    puntos[i] = cant;

                    

                   


                    chartprod.Series[0].Points.DataBindXY(series1, puntos);
                    

                    i++;
                }

                chartprod.Titles.Add("Productos mas Solicitados");
           





            }

            else {


                MessageBox.Show("No hay Produccion en este rango de fechas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
        }
        public void estatics2()
        {

            string desde = Dtp_Fechadesde.Text;
            string hasta = Dtp_fechaHasta.Text;


            string sql = "SELECT p.nombre_producto, cp.costo_unitario_producto as 'costo' FROM costos_produccion cp  INNER JOIN productos p ON cp.id_producto=p.id_producto WHERE cp.fecha BETWEEN '"+desde+"' AND '"+hasta+"' and cp.estado = 0 and cp.suma_costo_mo > 0 GROUP BY cp.id_producto ;";
                DataTable dt = mo.consultaLogica2(sql);
            int i = 0;


            if (dt.Rows.Count > 0)
            {


                foreach (DataRow row in dt.Rows)
                {
                    var nombre = dt.Rows[i]["nombre_producto"].ToString();
                    var cantidad = dt.Rows[i]["costo"].ToString();

                    double cant = Convert.ToDouble(cantidad);


                    series1[i] = nombre;
                    puntos[i] = cant;



                    chartprod1.Series[0].Points.AddXY(series1[i], puntos[i]);




                    i++;
                }

             
                chartprod1.Titles.Add("Costos de Productos");





            }

            else
            {


         

            }

        }

        private void RendimientoProducto_Load(object sender, EventArgs e)
        {

           


             }

        private void Btn_estadisticas_Click(object sender, EventArgs e)
        {

            chartprod1.Series[0].Points.Clear();
            chartprod.Series[0].Points.Clear();
            chartprod1.Titles.Clear();
            chartprod.Titles.Clear();
            estatics();
            estatics2();
           

        }

        private void Btn_imagen_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            string fecha1 = DateTime.Now.ToString("yyyy-MM-dd");

            string nombre = InputDialog.mostrar("Nombre con el que desea guardar "); ;

            if (nombre != "")
            {
                chartprod1.SaveImage("graficos/bars"+nombre+"-"+fecha1+".png", ChartImageFormat.Png);
                chartprod.SaveImage("graficos/pie"+nombre+"-"+fecha1+".png", ChartImageFormat.Png);
                MessageBox.Show("Imagen almacenada con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                proceso.StartInfo.FileName = "C:/Users/edgar/Documents/GitHub/MRP-Edgar/MRP/MDI_MRP/MDI_MRP/bin/Debug/graficos/pie"+nombre+"-"+fecha1+".png";
                proceso.Start();
                proceso.StartInfo.FileName = "C:/Users/edgar/Documents/GitHub/MRP-Edgar/MRP/MDI_MRP/MDI_MRP/bin/Debug/graficos/bars"+nombre+"-"+fecha1+".png";
                proceso.Start();
            }
            else {

                MessageBox.Show("Debe escribir un nombre para almacenar su imagen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Dtp_Fechadesde_ValueChanged(object sender, EventArgs e)
        {
            Dtp_fechaHasta.MinDate = Dtp_Fechadesde.Value;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda-MRP/AyudaMRP.chm", "AyudaEstadisticas.html"); 
        }
    }
}
