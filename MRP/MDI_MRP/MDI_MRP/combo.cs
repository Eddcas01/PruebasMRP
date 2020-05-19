using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_MRP
{
    public partial class combo : Form
    {
        public combo()
        {
            InitializeComponent();
            combo1.llenarse2("productos","id_producto","nombre_producto","id_tipo_producto","2");
        }


        
        

        private void Combo_Load(object sender, EventArgs e)
        {


            
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lbl_amigo.Text = combo1.obtenerP();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;

            combo1.texto(texto);
        }

        private void Button3_Click(object sender, EventArgs e)
        {



            
          
        }




        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
