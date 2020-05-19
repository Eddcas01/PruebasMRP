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
    public partial class mantenimientoInventario : Form
    {
        modelo mo = new modelo();
        ValidacionLetrasNum val = new ValidacionLetrasNum();
        string tabla = "inventarios_produccion";
        string[] aliasC = new string[100];
        string[] alias = { "cod_inventario", "Nombre_Producto", "Temporada", "Cantidad" ,"Unidad_de_Medida ", "Estado" };
        string sql3 = "  SELECT ip.id_inventario,p.nombre_producto,ci.Temporada, ip.cantidad_total , ip.unidad_medida ,ip.estado  from productos p inner join inventarios_produccion ip on p.id_producto=ip.id_producto INNER join configuraciones_inventarios ci on ip.cod_config=ci.cod_config and  ip.estado=1;";

        public mantenimientoInventario()
        {
            InitializeComponent();
            asignarAlias(alias);
            actualizardatagriew();
     
            Txt_idinv.Enabled = false;
            Cmb_prod.llenarse2("productos","id_producto","nombre_producto","id_tipo_producto","2");
            cmb_config.llenarse("configuraciones_inventarios","cod_config","temporada");
            //cmb_unidadmedida.llenarse("unidades_medida","id_medida","unidad");
            Txt_idinv.Text = mo.idmax("inventarios_produccion","id_inventario");
       
            Btn_actualizar.Enabled = false;
            Btn_eliminar.Enabled = false;

            llenarse("unidades_medida","unidad1");
        }




        public void actualizardatagriew()
        {
            DataTable dt = mo.consultaLogica2(sql3);
            dgb_inventarios.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla))
            {
                dgb_inventarios.Columns[head].HeaderText = aliasC[head];
                head++;
            }
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
                        cmb_unidadmedida.Items.Add(items[i]);
                    }
                }

            }





        }

        public void asignarAlias(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            string id = Txt_idinv.Text;
            string valor = cmb_config.ObtenerIndif();
            string um = cmb_unidadmedida.Text;
            string idcong2 = cmb_config.texto2();

            int existe2 = cmb_config.existe(idcong2);

            if (existe2 != -1)
            {
                mo.updateestados("inventarios_produccion", "cod_config", valor, "id_inventario", id);
                mo.updateestados("inventarios_produccion", "unidad_medida", um, "id_inventario", id);

                actualizardatagriew();
              

                string limpio = " ";
                cmb_config.texto(limpio);
                Cmb_prod.texto(limpio);
                cmb_unidadmedida.Text =limpio;
                Nud_cantidad.Value = 0;
              

                MessageBox.Show("Registro Actualizado con Exito! ");

                Txt_idinv.Text = mo.idmax("inventarios_produccion", "id_inventario");
             
                Btn_actualizar.Enabled = false;
                Btn_insertar.Enabled = true;
                Btn_eliminar.Enabled = false;
                Cmb_prod.Enabled = true;
                Nud_cantidad.Enabled = true;
                cmb_unidadmedida.Enabled = true;

            }

        }

        /*DialogResult resul =  MessageBox.Show("¿Esta seguro que desea validar los documentos? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resul == DialogResult.Yes)
            {                              }*/
        private void Btn_insertar_Click(object sender, EventArgs e)
        {
            

            string idprod2 = Cmb_prod.texto2();
            string idcong2 = cmb_config.texto2();
            decimal cantidad2 = Nud_cantidad.Value;
            string um = cmb_unidadmedida.Text;
            int existe = Cmb_prod.existe(Cmb_prod.texto2());
            int existe2 = cmb_config.existe(idcong2);

           

            if (idprod2 != "" && idcong2 != "" && um != "" && cantidad2 != 0 && um != "")
            {
                if (existe == -1 || existe2 == -1)
                {
                    MessageBox.Show("La Configuracion o el Producto seleccionados no son validos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);




                }

                else {

                    string yaingresado = Cmb_prod.ObtenerIndif();

                    string sql2 = "SELECT id_producto FROM inventarios_produccion where estado = 1 and id_producto = '" + yaingresado + "' ";

                    string resultado;

                    resultado = mo.consulta(sql2);



                    if (resultado == " ")
                    {

                        string idinv = Txt_idinv.Text;
                        string idprod = Cmb_prod.ObtenerIndif();
                        string idcong = cmb_config.ObtenerIndif();
                    
                        string unidad = cmb_unidadmedida.Text;
                        string cantidad = Nud_cantidad.Value.ToString();
                        

                        

                        string sql = "INSERT INTO inventarios_produccion (id_inventario, id_producto, cod_config, cantidad_total,unidad_medida, estado) VALUES ( " + idinv + " , '" + idprod + "' , '" + idcong + "' , '" + cantidad + "' , '"+ unidad +"' , 1 );";
                        mo.insertar(sql);

                        actualizardatagriew();
                     
                        MessageBox.Show("Registro Realizado con Exito ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string limpio = " ";
                        cmb_config.texto(limpio);
                        Cmb_prod.texto(limpio);
                        Nud_cantidad.Minimum = 0;
                        Nud_cantidad.Value = 0;
                        Txt_idinv.Text = mo.idmax("inventarios_produccion", "id_inventario");

                    }

                    else
                    {
                        MessageBox.Show("Este registro ya fue ingresado solo puede modificar su configuracion o eliminarlo e ingresar uno nuevo ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                    }


                }


               
            }
            else
            {

                MessageBox.Show("Por favor llene los campos correspondientes para un registro correcto ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }



        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            string idmax = Txt_idinv.Text;
            string nombre = dgb_inventarios.CurrentRow.Cells[1].Value.ToString();

            DialogResult resul = MessageBox.Show("¿Esta seguro que desea eliminar "+nombre+"? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resul == DialogResult.Yes)
            {
                if (dgb_inventarios.SelectedRows.Count == 1)
                {


                    mo.updateestados("inventarios_produccion", "estado", "0", "id_inventario", idmax);

                    actualizardatagriew();
                    Btn_eliminar.Enabled = false;
                    Btn_actualizar.Enabled = false;
                    Btn_insertar.Enabled = true;
                    Cmb_prod.Enabled = true;
                    Nud_cantidad.Enabled = true;
                    cmb_unidadmedida.Enabled = true;
                  
                   
                    Txt_idinv.Text = mo.idmax("inventarios_produccion", "id_inventario");
                    string limpio = " ";
                    cmb_config.texto(limpio);
                    Cmb_prod.texto(limpio);
                    Nud_cantidad.Value = 0;
                    cmb_unidadmedida.Text=limpio;
                   
                }
            }
        }

        private void Dgb_inventarios_DoubleClick(object sender, EventArgs e)
        {
            
            if (dgb_inventarios.SelectedRows.Count == 1)
            {Nud_cantidad.Enabled = false;
             
               
          
            Cmb_prod.Enabled = false;
                cmb_unidadmedida.Enabled = true;
            Btn_insertar.Enabled = false;
            Btn_eliminar.Enabled = true;
            Btn_actualizar.Enabled = true;
            
            string nombreprod = dgb_inventarios.CurrentRow.Cells[2].Value.ToString();

                string sql3 = " SELECT cod_config FROM configuraciones_inventarios where estado = 1 and temporada = '" + nombreprod + "' ";
                string resultado2;
                resultado2 = mo.consulta(sql3);

                string comboest = resultado2 + "-" + nombreprod;

                string where = dgb_inventarios.CurrentRow.Cells[0].Value.ToString();
                Txt_idinv.Text = where;
                string prod = dgb_inventarios.CurrentRow.Cells[1].Value.ToString();
                Cmb_prod.texto(prod);

                cmb_unidadmedida.Text =(dgb_inventarios.CurrentRow.Cells[4].Value.ToString());
            
                cmb_config.texto(comboest);
                string cant = dgb_inventarios.CurrentRow.Cells[3].Value.ToString();
                double canti = Convert.ToDouble(cant);
                decimal canti1 = Convert.ToDecimal(canti);
                Nud_cantidad.Value = canti1;

              


               




            }
            else
            {

                MessageBox.Show("No hay datos en la tabla", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Nud_cantidad_MouseClick(object sender, MouseEventArgs e)
        {
       /*     string vacio = cmb_config.texto2();

            if (vacio != "") {
                string sql = "Select maximo from configuraciones_inventarios where cod_config = '" + cmb_config.ObtenerIndif() + "' ;";
                string cant = mo.consulta(sql);

                string sql2 = "Select minimo from configuraciones_inventarios where cod_config = '" + cmb_config.ObtenerIndif() + "' ;";
                string cant2 = mo.consulta(sql2);

                int canti = Convert.ToInt32(cant);
                int canti2 = Convert.ToInt32(cant2);

                Nud_cantidad.Maximum = canti;
                Nud_cantidad.Minimum = canti2; }*/

        }

        private void Nud_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            string idcong2 = cmb_config.texto2();
            int existe = Cmb_prod.existe(Cmb_prod.texto2());
            int existe2 = cmb_config.existe(idcong2);
            string vacio = cmb_config.texto2();
            if ( existe != -1 && existe != 0 && existe2 != -1 && existe2 != 0)
            {
                string sql = "Select maximo from configuraciones_inventarios where cod_config = '" + cmb_config.ObtenerIndif() + "' ;";
                string cant = mo.consulta(sql);

                string sql2 = "Select minimo from configuraciones_inventarios where cod_config = '" + cmb_config.ObtenerIndif() + "' ;";
                string cant2 = mo.consulta(sql2);


                int canti = Convert.ToInt32(cant);
                int canti2 = Convert.ToInt32(cant2);

                Nud_cantidad.Maximum = canti;
                Nud_cantidad.Minimum = canti2;
            }
        }

        private void Nud_cantidad_Enter(object sender, EventArgs e)
        {
           /* string vacio = cmb_config.texto2();
            if (vacio != "")
            {
                string sql = "Select maximo from configuraciones_inventarios where cod_config = '" + cmb_config.ObtenerIndif() + "' ;";
                string cant = mo.consulta(sql);

                string sql2 = "Select minimo from configuraciones_inventarios where cod_config = '" + cmb_config.ObtenerIndif() + "' ;";
                string cant2 = mo.consulta(sql2);
                MessageBox.Show(cant2);
                int canti = Convert.ToInt32(cant);
                int canti2 = Convert.ToInt32(cant2);

                Nud_cantidad.Maximum = canti;
                Nud_cantidad.Minimum = canti2;
            }*/
        }

        private void Cmb_unidadmedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.nada(e);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda-MRP/AyudaMRP.chm", "AyudaMantenimientoInv.html");
        }
    }
}
