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
    public partial class mantenimientoUnidadMedida : Form
    {
        ValidacionLetrasNum val = new ValidacionLetrasNum();
        modelo mo = new modelo();
        string sql3 = "SELECT id_medida as 'Id', cantidad1 as 'Cantidad 1', unidad1 as 'Unidad 1', cantidad2 as 'Cantidad 2', unidad2 as 'Unidad 2' FROM unidades_medida where estado =1";

        public mantenimientoUnidadMedida()
        {
            InitializeComponent();
            Btn_insertar.Enabled = true;
            Btn_eliminar.Enabled = false;
          
            actualizardatagriew(sql3);

        }

        private void MantenimientoUnidadMedida_Load(object sender, EventArgs e)
        {

        }

        public void actualizardatagriew(string sql3)
        {

            DataTable dt = mo.consultaLogica2(sql3);
            Dgb_UM.DataSource = dt;


        }
        void unidadesnew(string un2, double cant2, string un1)
        {



            double resultado = 1 / cant2;
            double resultador = Math.Round(resultado, 4);
            string sql = " INSERT INTO unidades_medida (unidad1, cantidad1, unidad2 , cantidad2) VALUES ('" + un2 + "' , " + 1 + " , '" + un1 + "' , " + resultado + ") ;";
            mo.insertar(sql);

            string consultar5 = "Select id_medida from unidades_medida where unidad1 = '" + un1 + "' and unidad2 = '" + un1 + "' and estado = 1 ;";
            string ex = mo.consulta(consultar5);
            if (ex == " ")
            {

                string sql6 = " INSERT INTO unidades_medida (unidad1, cantidad1, unidad2 , cantidad2) VALUES ('" + un1 + "' ,  " + 1 + "  , '" + un1 + "' , " + 1 + ") ;";
                mo.insertar(sql6);
            }
            string consultar7 = "Select id_medida from unidades_medida where unidad1 = '" + un2 + "' and unidad2 = '" + un2 + "' and estado = 1 ;";
            string ex2 = mo.consulta(consultar7);
            if (ex2 == " ")
            {

                string sql7 = " INSERT INTO unidades_medida (unidad1, cantidad1, unidad2 , cantidad2) VALUES ('" + un2 + "' ,  " + 1 + "  , '" + un2 + "' , " + 1 + ") ;";
                mo.insertar(sql7);
            }




        }
        void eliminar(string un2,  string un1)
        {

            string sql4 = "Select id_medida from unidades_medida where unidad1= '" + un2 + "' and unidad2 = '" + un1 + "' and estado = 1;";
            string idmax = mo.consulta(sql4);

            mo.updateestados("unidades_medida", "estado", "0", "id_medida", idmax);






        }



        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letra(e);
        }

        private void Dgb_ordenesPendientes_DoubleClick(object sender, EventArgs e)
        {
            if (Dgb_UM.Rows.Count > 1)
            {
               
                Btn_eliminar.Enabled = true;
                Btn_insertar.Enabled = false;
                Txt_um1.Enabled = false;
                Txt_um2.Enabled = false;

                if (Dgb_UM.SelectedRows.Count == 1)
                {

                    Txt_um1.Text = Dgb_UM.CurrentRow.Cells[2].Value.ToString();
                    Txt_um2.Text = Dgb_UM.CurrentRow.Cells[4].Value.ToString();

                    string cantidad2 = Dgb_UM.CurrentRow.Cells[1].Value.ToString();
                        decimal cant3 = Convert.ToDecimal(cantidad2);

                    if (cant3 == 1)
                    {

                        string cantidad4 = Dgb_UM.CurrentRow.Cells[3].Value.ToString();
                        decimal cant4 = Convert.ToDecimal(cantidad4);
                        Nud_cant.Value = cant4;

                    }
                    else
                    {
                        Nud_cant.Value = cant3;


                    }
                   

                }
                else
                {

                    MessageBox.Show("Seleccione un dato de la tabla");
                }
            }
            else {
                MessageBox.Show("No existen registros para seleccionar, inserte registros.");

            }
        }

        private void Btn_insertar_Click(object sender, EventArgs e)
        {
            //validar que no sean vacios ni valor 0
            string um1 = Txt_um1.Text.ToLower();
            string um2 = Txt_um2.Text.ToLower();
            decimal val = Nud_cant.Value;
            double valr = Convert.ToDouble(val);
            //validar si existe
            if (um1 != "" && um2 != "" && valr != 0)
            {
                string sql = "Select id_medida from unidades_medida where unidad1 = '" + um1 + "' and unidad2 = '" + um2 + "' and estado = 1 ;";
                string existe = mo.consulta(sql);
                if (existe == " ")
                {


                    string sql2 = "INSERT INTO unidades_medida (unidad1, cantidad1, unidad2 , cantidad2) VALUES ('" + um1 + "' , '" + 1 + "' , '" + um2 + "' , '" + valr + "') ;";

                    mo.insertar(sql2);

                    unidadesnew(um2, valr, um1);

                    MessageBox.Show("Registro Almacenado ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    Txt_um1.Text = "";
                    Txt_um2.Text = "";
                    Nud_cant.Value = 0;
                    actualizardatagriew(sql3);

                }
                else
                {
                    MessageBox.Show("Este registro ya fue ingresado  ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }




            }
            else
            {
                MessageBox.Show("Complete los datos correctamente ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }





        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            string nom1 = Txt_um1.Text.ToLower();
            string nom2 = Txt_um2.Text.ToLower();


            DialogResult resul = MessageBox.Show("¿Esta seguro que desea eliminar " + nom1 + " a " + nom2 + " ? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resul == DialogResult.Yes)
            {
                if (Dgb_UM.SelectedRows.Count == 1)
                {
                    string sql4 = "Select id_medida from unidades_medida where unidad1= '" + nom1 + "' and unidad2 = '" + nom2 + "' and estado = 1;";
                    string idmax = mo.consulta(sql4);

                    mo.updateestados("unidades_medida", "estado", "0", "id_medida", idmax);
                    eliminar(nom2, nom1);

                    Txt_um1.Text = "";
                    Txt_um2.Text = "";
                    Nud_cant.Value = 0;
                    MessageBox.Show("Registro Actualizado ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Btn_insertar.Enabled = true;
                    Btn_eliminar.Enabled = false;
                
                    Txt_um1.Enabled = true;
                    Txt_um2.Enabled = true;
                    actualizardatagriew(sql3);
                }
                else {

                    MessageBox.Show("Error al eliminar ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {


            
        }

        private void Txt_um2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.letra(e);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayuda-MRP/AyudaMRP.chm", "AyudaUnidadesMedida.html");
        }
    }
}
