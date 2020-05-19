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
    public partial class mantenimientoRecetas : Form
    {
        modelo mo = new modelo();
        ValidacionLetrasNum val = new ValidacionLetrasNum(); 
        string[] aliasC = new string[120];
        string[] alias = { "Id detalle", "No. proceso", "Producto", " Razon", "Cantidad","rendimiento R","rendimiento F","Cantidad Rendimiento","Costo Unitario","Unidad de Medida" };
        string tabla2 = "detalles_recetas";
        public mantenimientoRecetas(string codreceta, string razon)
        {
            InitializeComponent();
            lbl_noProcesp.Text = codreceta;
            Lbl_paraReceta.Text = razon;
            cmb_productos.llenarse2("productos", "id_producto", "nombre_producto", "id_tipo_producto", "2");
            cu();
            asignarAlias2(alias);
            actualizardatagriew2(codreceta);
            Btn_agregar.Enabled = true;
            Btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            Guardar.Enabled = false;
            restante();
            llenarse("unidades_medida","unidad1");
        }

        public void llenarse(string tabla, string campo1)
        {





            string[] items = mo.items(tabla, campo1);



            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        Cmb_um.Items.Add(items[i]);
                    }
                }

            }





        }
        private void Label2_Click(object sender, EventArgs e)
        {

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
        public void restante()
        {


            if (Dgb_pedidosEspeciales.Rows.Count > 0)
            {





                foreach (DataGridViewRow row in Dgb_pedidosEspeciales.Rows)
                {

                    string id = row.Cells[0].Value.ToString();
                    string nombre = row.Cells[2].Value.ToString();
                
                    string prod = mo.ObtenerSimple2("productos", "id_producto", "nombre_producto", nombre);
                    string cantidad = mo.ObtenerSimple3("inventarios_produccion","cantidad_total", "id_producto", prod);
                    string rendimientof = row.Cells[6].Value.ToString();
                    string cantidadfr = row.Cells[7].Value.ToString();

                  


                    double cant = Convert.ToDouble(cantidad);
                    double rendf = Convert.ToDouble(rendimientof);
                    double cantf = Convert.ToDouble(cantidadfr);
                    if (cantf != 0)
                    {
                        double restante = (rendf * cant) / cantf;

                        string restante1 = Convert.ToString(restante);
                        mo.updateestados("detalles_recetas", "rendimiento_restante", restante1, "id_detalle", id);
                    }
                }

                actualizardatagriew2(lbl_noProcesp.Text);
            }





        }
        private void Nud_cantidad_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Nud_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            string prod2 = cmb_productos.texto2();
            int existe = cmb_productos.existe(prod2);
            if ( existe != -1 && existe != 0)
            {
                string sql = "Select maximo from configuraciones_inventarios ci INNER JOIN  inventarios_produccion ip on ci.cod_config = ip.cod_config WHERE ip.id_producto = '" + cmb_productos.ObtenerIndif() + "' ;";
                string cant = mo.consulta(sql);



                if (cant != null)
                {

                    int canti = Convert.ToInt32(cant);


                    Nud_cantidad.Maximum = canti;
                }
                else
                {
                    MessageBox.Show("Asigne una Configuracion de inventario ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
        }

        private void Nud_cantidad_Enter(object sender, EventArgs e)
        {
            string prod2 = cmb_productos.texto2();
            int existe = cmb_productos.existe(prod2);
            if (existe != -1 && existe != 0)
            {
                string sql = "Select maximo from configuraciones_inventarios ci INNER JOIN  inventarios_produccion ip on ci.cod_config = ip.cod_config WHERE ip.id_producto = '" + cmb_productos.ObtenerIndif() + "' ;";
                string cant = mo.consulta(sql);

                if (cant != " ")
                {

                    int canti = Convert.ToInt32(cant);


                    Nud_cantidad.Maximum = canti;
                }
                else {
                    MessageBox.Show("Asigne una Configuracion de inventario ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {

            string prod2 = cmb_productos.texto2();
            int existe = cmb_productos.existe(prod2);
            decimal rendi = nud_rendi.Value;
            decimal cantidadrendi = nud_cantidadRinde.Value;
            decimal cantidad = Nud_cantidad.Value;
            string med = Cmb_um.Text;

            if (cantidad !=0 && rendi != 0 && cantidadrendi != 0) {
            if (existe == -1 || existe == 0)
            {MessageBox.Show("El producto seleccionados no es valido ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                
              

            }
            else {
                    string idmax = lbl_noProcesp.Text;
                    string yaingresado = cmb_productos.ObtenerIndif();
                    
                    //SELECT dr.id_producto FROM detalles_recetas dr INNER JOIN produccion_procesos pp on dr.id_proceso=pp.id_proceso where dr.estado = 1 and dr.id_producto = "8-Vitamina E" and dr.id_proceso=4
                    string sql2 = "SELECT dr.id_producto FROM detalles_recetas dr INNER JOIN produccion_procesos pp on dr.id_proceso=pp.id_proceso where dr.estado = 1 and dr.id_producto = '"+ yaingresado +"' and dr.id_proceso= '"+ idmax +"' ";

                    string resultado;

                    resultado = mo.consulta(sql2);

                    if (resultado == " ")
                    {
                        
                        string prod = cmb_productos.ObtenerIndif();
                        string cant = Nud_cantidad.Value.ToString();
                        string rendi23 = rendi.ToString();
                        string cantidadrendim = cantidadrendi.ToString();

                        string cadena = "INSERT INTO detalles_recetas (id_detalle, id_proceso , id_producto, cantidad ,rendimiento_fijo, cantidad_rendimiento_f ,unidad_medida, estado) VALUES(NULL," + idmax + ",'" + prod + "','" + cant + "','" + rendi23 + "' , '" + cantidadrendim + "' ,'"+med+"' ,1);";
                        mo.insertar(cadena);
                        cu();
                        actualizardatagriew2(idmax);
                        restante();
                        string vacio = "";
                        cmb_productos.texto(vacio);
                        Guardar.Enabled = true;
                        Nud_cantidad.Value = 1;
                        nud_cantidadRinde.Value = 0;
                        nud_rendi.Value = 0;
                        MessageBox.Show("Registro con exito ", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else {
                        MessageBox.Show("Este registro ya fue ingresado solo puede modificar su cantidad o eliminarlo e ingresar uno nuevo  ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                     
                }
            }
            else
            {

                MessageBox.Show("Complete los campos correctamente ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           

        }

        public void actualizardatagriew2(string encab)
        {
            DataTable dt = mo.consultaLogica5(encab);
            Dgb_pedidosEspeciales.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla2))
            {
                Dgb_pedidosEspeciales.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }

        public void asignarAlias2(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {

            string nombre = Dgb_pedidosEspeciales.CurrentRow.Cells[2].Value.ToString();
            DialogResult resul = MessageBox.Show("¿Esta seguro que desea eliminar " + nombre + "? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resul == DialogResult.Yes)
            {
                if (Dgb_pedidosEspeciales.Rows.Count != 1)
                {
                    if (Dgb_pedidosEspeciales.SelectedRows.Count == 1)
                    {
                        string idmax = Dgb_pedidosEspeciales.CurrentRow.Cells[0].Value.ToString();
                        string idmax2 = lbl_noProcesp.Text;

                        mo.updateestados("detalles_recetas", "estado", "0", "id_detalle", idmax);


                        btn_modificar.Enabled = false;
                        Btn_agregar.Enabled = true;
                        Btn_eliminar.Enabled = false;
                        cmb_productos.Enabled = true;
                        Nud_cantidad.Enabled = true;
                        Guardar.Enabled = true;
                        Cmb_um.Enabled = true;
                        string limpio = " ";
                        cmb_productos.texto(limpio);
                        Cmb_um.Text = limpio;
                        Nud_cantidad.Value = 1;
                        lbl_noreceta.Text = limpio;
                        actualizardatagriew2(idmax2);
                        nud_rendi.Value = 0;
                        nud_cantidadRinde.Value = 0;
                        Txt_rendirRestante.Text = limpio;
                        MessageBox.Show("Registro Eliminado con Exito! ");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar! ");

                    }
                }
                else {
                    MessageBox.Show("La receta no puede tener menos de 1 registro ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
        }

        private void Dgb_pedidosEspeciales_DoubleClick(object sender, EventArgs e)
        {

            
            if (Dgb_pedidosEspeciales.SelectedRows.Count == 1)
            {string nombreprod = Dgb_pedidosEspeciales.CurrentRow.Cells[2].Value.ToString();


                string sql3 = " SELECT id_producto FROM productos where estado = 1 and nombre_producto = '" + nombreprod + "' ";
                string resultado2;
                resultado2 = mo.consulta(sql3);
              


                string comboest = resultado2 + "-" + nombreprod;


                cmb_productos.Enabled = false;
                Cmb_um.Enabled = true;
                Btn_agregar.Enabled = false;
                Btn_eliminar.Enabled = true;
                btn_modificar.Enabled = true;
                Guardar.Enabled = false;
                cmb_productos.texto(comboest);

                lbl_noreceta.Text = Dgb_pedidosEspeciales.CurrentRow.Cells[0].Value.ToString();

                string cant = Dgb_pedidosEspeciales.CurrentRow.Cells[4].Value.ToString();


                decimal cantidad = decimal.Parse(cant);

                Nud_cantidad.Value = cantidad;


                Txt_rendirRestante.Text = Dgb_pedidosEspeciales.CurrentRow.Cells[5].Value.ToString();

                string rendi = Dgb_pedidosEspeciales.CurrentRow.Cells[6].Value.ToString();
                double rendi2 = Convert.ToDouble(rendi);
                decimal rendi3 = Convert.ToDecimal(rendi2);
                nud_rendi.Value = rendi3;

                string rendi8 = Dgb_pedidosEspeciales.CurrentRow.Cells[7].Value.ToString();
                double rendi6 = Convert.ToDouble(rendi8);
                decimal rendi4 = Convert.ToDecimal(rendi6);
                nud_cantidadRinde.Value = rendi4;

                Cmb_um.Text= Dgb_pedidosEspeciales.CurrentRow.Cells[9].Value.ToString();

            }
            else {

                MessageBox.Show("No hay ningun registro seleccionado ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string id = lbl_noreceta.Text;
            string cantidadrindeactual = nud_cantidadRinde.Value.ToString();
            string rendimientoactual = nud_rendi.Value.ToString();
            string cantidad = Nud_cantidad.Value.ToString();
            string um = Cmb_um.Text;

            if (nud_cantidadRinde.Value != 0 && nud_rendi.Value != 0 && Nud_cantidad.Value != 0)
            {
                mo.updateestados("detalles_recetas", "cantidad", cantidad, "id_detalle", id);
                mo.updateestados("detalles_recetas", "rendimiento_fijo", rendimientoactual, "id_detalle", id);
                mo.updateestados("detalles_recetas", "cantidad_rendimiento_f", cantidadrindeactual, "id_detalle", id);
                mo.updateestados("detalles_recetas", "unidad_medida", um, "id_detalle", id);
                cu();
                actualizardatagriew2(lbl_noProcesp.Text);
                restante();
                string limpio = " ";
                cmb_productos.texto(limpio);
                Cmb_um.Text=limpio;
                Nud_cantidad.Value = 1;
                nud_cantidadRinde.Value = 0;
                nud_rendi.Value= 0;
                MessageBox.Show("Registro Actualizado con Exito! ");

                btn_modificar.Enabled = false;
                Btn_agregar.Enabled = true;
                Btn_eliminar.Enabled = false;
                cmb_productos.Enabled = true;
                Nud_cantidad.Enabled = true;
                Cmb_um.Enabled = true;
                Guardar.Enabled = true;
            }
            else {

                MessageBox.Show("Complete los campos para actualizar correctamente, cantidades mayores a 0 ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult resul =  MessageBox.Show("¿Esta seguro que ya ingreso todos los productos? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           if (resul == DialogResult.Yes)
           {    this.Close();                          }


            
        }

        private void Cmb_um_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.nada(e);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda-MRP/AyudaMRP.chm", "AyudaMantenimientoProcRec.html");
        }
    }
}
