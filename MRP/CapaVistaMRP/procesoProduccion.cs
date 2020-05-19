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
    public partial class procesoProduccion : Form
    {
        ValidacionLetrasNum val = new ValidacionLetrasNum();
        modelo mo = new modelo();
        string tabla = "produccion_procesos";
        string[] aliasC = new string[40];
        string[] alias = { "cod_proceso", "cod_producto","nombre_producto", "descripcion", "tiempo", "estado"};
        string sql3 = "  SELECT pp.id_proceso,pp.id_producto,p.nombre_producto, pp.descripcion_proceso,pp.tiempo_pp,pp.estado from  productos p inner join produccion_procesos pp on p.id_producto=pp.id_producto and  pp.estado=1";

        public procesoProduccion()
        {
            InitializeComponent();
            asignarAlias(alias);
            actualizardatagriew();
            Txt_idproceso.Text = mo.idmax("produccion_procesos","id_proceso");
            Cmb_producto.llenarse2("productos", "id_producto", "nombre_producto", "id_tipo_producto", "1");
         
            Btn_actualizar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Txt_idproceso.Enabled = false;
            Btn_Receta.Enabled = false;

            

        }




        public void actualizardatagriew()
        {
            DataTable dt = mo.consultaLogica2(sql3);
            dgb_produccionProceso.DataSource = dt;
            int head = 0;
            while (head < mo.contarCampos(tabla))
            {
                dgb_produccionProceso.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }

       
        public void asignarAlias(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string idmax = Txt_idproceso.Text;
            string nombre = txt_para.Text;
            DialogResult resul = MessageBox.Show("¿Esta seguro que desea eliminar " + nombre + "? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resul == DialogResult.Yes)
            {
                if (dgb_produccionProceso.SelectedRows.Count == 1)
                {


                    mo.updateestados("produccion_procesos", "estado", "0", "id_proceso", idmax);


                }
                actualizardatagriew();
                Btn_eliminar.Enabled = false;
                Btn_actualizar.Enabled = false;
                Btn_insertar.Enabled = true;
                Btn_Receta.Enabled = false;
                string limpio = " ";
                Cmb_producto.texto(limpio);
                txt_para.Clear();
                Txt_tiempopp.Clear();
                Txt_descripcion.Clear();
                Txt_idproceso.Text = mo.idmax("produccion_procesos", "id_proceso");
                txt_para.Enabled = true;
                Cmb_producto.Enabled = true;
            }
        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {

            string id = Txt_idproceso.Text;
            string valor = Txt_tiempopp.Text;
       

            mo.updateestados("produccion_procesos", "tiempo_pp", valor, "id_proceso", id);
        

            actualizardatagriew();


            MessageBox.Show("Registro Actualizado con Exito! ");
          
            Btn_actualizar.Enabled = false;
            Btn_insertar.Enabled = true;
            Btn_eliminar.Enabled = false;
            Btn_Receta.Enabled = false;
            Cmb_producto.Enabled = true;
            string limpio = " ";
            Cmb_producto.texto(limpio);
            txt_para.Clear();
            Txt_tiempopp.Clear();
            Txt_descripcion.Clear();
            Txt_idproceso.Text = mo.idmax("produccion_procesos", "id_proceso");

        }

        private void Dgb_produccionProceso_DoubleClick(object sender, EventArgs e)
        {


            if (dgb_produccionProceso.Rows.Count > 1)
            {
                if (dgb_produccionProceso.SelectedRows.Count == 1)
                {
                    Cmb_producto.Enabled = false;
                    Btn_insertar.Enabled = false;
                    Btn_eliminar.Enabled = true;
                    Btn_actualizar.Enabled = true;
                    Btn_Receta.Enabled = true;
                    string nombreprod = dgb_produccionProceso.CurrentRow.Cells[2].Value.ToString();
                    string where = dgb_produccionProceso.CurrentRow.Cells[0].Value.ToString();

                    string sql3 = " SELECT id_producto FROM productos where estado = 1 and nombre_producto = '" + nombreprod + "' ";
                    string resultado2;
                    resultado2 = mo.consulta(sql3);
                    string sql = "Select nombre from produccion_procesos where estado =1 and  id_proceso = " + where + " ;";
                    string razon = mo.consulta(sql);


                    string comboest = resultado2 + "-" + nombreprod;



                    txt_para.Text = razon;
                    Txt_idproceso.Text = where;

                    Cmb_producto.texto(comboest);

                    Txt_descripcion.Text = dgb_produccionProceso.CurrentRow.Cells[3].Value.ToString();

                    Txt_tiempopp.Text = dgb_produccionProceso.CurrentRow.Cells[4].Value.ToString();


                    txt_para.Enabled = false;
                    Txt_idproceso.Enabled = false;


                }
                else
                {

                    MessageBox.Show("Seleccione un dato", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else {
                MessageBox.Show("No existen datos en la tabla, Por favor ingrese datos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
         



        }

        private void Btn_insertar_Click(object sender, EventArgs e)
        {

            string producto = Cmb_producto.texto2();
            string para = txt_para.Text;
            string descripcion = Txt_descripcion.Text;
            string tiempo = Txt_tiempopp.Text;
            int existe = Cmb_producto.existe(producto);

            if (para != "" && descripcion != "" && tiempo != "")
            {

                if (existe == -1) {
                    MessageBox.Show("El Producto seleccionados no es valido ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else {

                    string yaingresado = Cmb_producto.ObtenerIndif();

                    string sql2 = "SELECT id_producto FROM produccion_procesos where estado = 1 and id_producto = '" + yaingresado + "' ";

                    string resultado;

                    resultado = mo.consulta(sql2);


                    if (resultado == " ")
                    {

                        string idproceso = Txt_idproceso.Text;
                        string idprod = Cmb_producto.ObtenerIndif();


                        string sql = "INSERT INTO produccion_procesos (id_proceso, id_producto, nombre, descripcion_proceso, tiempo_pp, estado) VALUES ( " + idproceso + " , '" + idprod + "' , '" + para + "' , '" + descripcion + "' , '" + tiempo + "' , 1 );";
                        mo.insertar(sql);

                        actualizardatagriew();
                        MessageBox.Show("Registro Realizado con Exito ");

                        string limpio = " ";
                        Cmb_producto.texto(limpio);

                        Txt_idproceso.Text = mo.idmax("produccion_procesos", "id_proceso");
                        Txt_descripcion.Clear();
                        Txt_tiempopp.Clear();
                        txt_para.Clear();


                    }

                    else
                    {

                        
                        MessageBox.Show("Este registro ya fue ingresado solo puede modificar su configuracion o eliminarlo e ingresar uno nuevo  ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }


            }
            else {
                MessageBox.Show("Por favor llene los campos correspondientes para un registro correcto ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }


           
        }

        private void Btn_Receta_Click(object sender, EventArgs e)
        {
            if (dgb_produccionProceso.SelectedRows.Count == 1)
            {


                string where = Txt_idproceso.Text;
                string sql = "Select nombre from produccion_procesos where estado =1 and  id_proceso = "+ where +" ;";
                string razon = mo.consulta(sql);

                


                mantenimientoRecetas frm = new mantenimientoRecetas(where, razon);//pasarle el id del encabezado que se esta consultando
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void Txt_para_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letra(e);
        }

        private void Txt_tiempopp_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void Txt_tiempopp_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numerosimbolo(e);

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda-MRP/AyudaMRP.chm", "AyudaOrdenPendiente.html");
        }
    }
}
