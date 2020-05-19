using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaControladorMRP;
using System.Data.Odbc;




namespace CapaModeloMRP
{       
       
    public class modelo
    {
        Sentencias sn = new Sentencias();
        public string[] items(string tabla, string campo1)
        {
            string[] Items = sn.llenarCmb(tabla, campo1);

            return Items;


        }
        public DataTable enviar(string tabla, string campo1)
        {



            var dt1 = sn.obtener(tabla, campo1);

            return dt1;
        }

        public DataTable orden()  //obtener datos de la consulta
        {
            OdbcDataAdapter dt = sn.llenaTblorden();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable inventarios() //obtener datos de la consulta
        {
            OdbcDataAdapter dt = sn.inventarios();
            DataTable table = new DataTable();
            dt.Fill(table);

           
            return table;
        }
        public DataTable consultaLogica0(string tabla, string campoOrden)  //obtener datos de la consulta
        {
            OdbcDataAdapter dt = sn.llenaTbl0(tabla, campoOrden);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable consultaLogica(string tabla)  //obtener datos de la consulta
        {
            OdbcDataAdapter dt = sn.llenaTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public int contarCampos(string tabla)
        {
            return sn.contarAlias(tabla);
        }

        public DataTable consultaLogica2(string sql)  //obtener datos de la consulta
        {
            OdbcDataAdapter dt = sn.llenaTbl2(sql);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable consultaLogica3( string where)  //obtener datos de la consulta
        {
            
            OdbcDataAdapter dt = sn.llenaTbl3( where);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable consultaLogica4( string where)  //obtener datos de la consulta
        {

            OdbcDataAdapter dt = sn.llenaTbl4(where);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable consultaLogica5(string where)  //obtener datos de la consulta
        {

            OdbcDataAdapter dt = sn.llenaTbl5(where);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public string ObtenerSimple(string tabla, string campo,string condicion, string id)  //obtener datos de la consulta
        {

            string resul = sn.obtenerSimple(tabla,campo, condicion, id);
            return resul;
        }
        public string ObtenerSimple3(string tabla, string campo, string condicion, string id)  //obtener datos de la consulta
        {

            string resul = sn.obtenerSimple3(tabla, campo, condicion, id);
            return resul;
        }
        public string ObtenerSimple2(string tabla, string campo, string condicion, string id)  //obtener datos de la consulta
        {

            string resul = sn.obtenerSimple2(tabla, campo, condicion, id);
            return resul;
        }
        public string idmax(string tabla, string dato) {



            string idmax = sn.obteneridmax(tabla,dato);
            if (idmax == "")
            {

                idmax = "1";
            }
           
            return idmax;
        }

        public string consulta(string sql) {

            string resultado = sn.consultar(sql);

            return resultado;
        }
        public void insertar(string sql) {

            sn.insertar(sql);

        }
        

        public void updateestados(string tabla, string set, string valorEstado, string WhereCampo, string id) {


            sn.updateEstados( tabla, set,valorEstado, WhereCampo, id);

        }


    }
}
