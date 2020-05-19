using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaControladorMRP
{


    public class Sentencias
    {
        string cmb;
        string tbl;
        string camp;

        conexionMRP con = new conexionMRP();
        public DataTable obtener(string tabla, string campo1)
        {

            string sql = "SELECT " + campo1 +  " FROM " + tabla + " where estado = 1  ;";

            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }
        public OdbcDataAdapter llenaTbl0(string tabla, string campoOrden)// metodo  que obtinene el contenio de una tabla
        {
          //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT pe.fecha_limite , op.cod_orden, op.cod_opp ,op.estado FROM " + tabla + " op , produccion_encabezados pe WHERE op.estado=1 and op.cod_orden=pe.cod_orden ORDER BY " + campoOrden+ " ASC ;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenaTblorden()// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT sum(pd.cantidad_producto) ,  op.cod_orden, op.cod_opp, pe.fecha_limite  FROM ordenes_pendientes op INNER JOIN produccion_encabezados pe on op.cod_orden=pe.cod_orden INNER JOIN produccion_detalles pd on pe.cod_orden=pd.cod_orden  WHERE op.estado=1 GROUP by pd.cod_orden  DESC";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenaTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            string[] camposDesc = obtenerCampos(tabla); //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + " WHERE estado=1 ORDER BY " + camposDesc[0] + " DESC ;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenaTbl2(string sql)// metodo  que obtinene el contenio de una tabla
        {
          
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());

            return dataTable;
        }

        public OdbcDataAdapter llenaTbl3( string where)// metodo  que obtinene el contenio de una tabla
        {
            
            string sql = "SELECT cod_orden, fecha_orden, fecha_limite, tipo_produccion, estado FROM produccion_encabezados WHERE cod_orden = " + where+";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenaTbl4( string where)// metodo  que obtinene el contenio de una tabla
        {
            string sql ="SELECT p.nombre_producto, sum(pd.cantidad_producto) as 'cantidad_total',pd.id_detalle ,op.cod_orden, pd.estado FROM ordenes_pendientes op INNER JOIN produccion_encabezados pe on op.cod_orden = pe.cod_orden INNER JOIN produccion_detalles pd on pe.cod_orden = pd.cod_orden INNER JOIN productos p on pd.id_producto = p.id_producto WHERE pd.estado = 1 and pe.cod_orden = "+where+" GROUP by p.nombre_producto DESC; ";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenaTbl5(string where)// metodo  que obtinene el contenio de una tabla
        {
            string sql = "SELECT dr.id_detalle, dr.id_proceso, p.nombre_producto,pp.nombre, dr.cantidad, dr.rendimiento_restante, dr.rendimiento_fijo, dr.cantidad_rendimiento_f,dr.costo_unitario,dr.unidad_medida FROM detalles_recetas dr INNER JOIN productos p ON dr.id_producto = p.id_producto INNER JOIN produccion_procesos pp on dr.id_proceso =pp.id_proceso WHERE dr.estado = 1 and dr.id_proceso = " + where+";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public string obtenerSimple(string tabla, string campo,string condicion,string id)// metodo  que obtinene el contenio de una tabla
        {
            string resultado = "";
            string sql = "SELECT " +campo+ " FROM " +tabla+ " WHERE " +condicion+ "=" + id +";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            OdbcDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                resultado = reader.GetValue(0).ToString();
            }
            return resultado;
        }
        public string obtenerSimple2(string tabla, string campo, string condicion, string id)// metodo  que obtinene el contenio de una tabla
        {
            string resultado = "";
            string sql = "SELECT " + campo + " FROM " + tabla + " WHERE " + condicion + "= '" + id + "';";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            OdbcDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                resultado = reader.GetValue(0).ToString();
            }
            return resultado;
        }
        public string obtenerSimple3(string tabla, string campo, string condicion, string id)// metodo  que obtinene el contenio de una tabla
        {
            string resultado = "";
            string sql = "SELECT " + campo + " FROM " + tabla + " WHERE " + condicion + "=" + id + " and estado = 1;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            OdbcDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                resultado = reader.GetValue(0).ToString();
            }
            return resultado;
        }
        public string obteneridmax(string tabla, string dato)// metodo  que obtinene el contenio de una tabla
        {
            string id = "";
            string sql = "SELECT MAX("+dato+"+1) FROM "+tabla+";";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            OdbcDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                id = reader.GetValue(0).ToString();
            }
            return id;
        }

        public string consultar(string sql)
        {

            string resultado = " ";

            OdbcCommand consulta = new OdbcCommand(sql, con.conexion());
            OdbcDataReader reader = consulta.ExecuteReader();

            while (reader.Read())
            {
                resultado = reader.GetValue(0).ToString();

            }

            return resultado ;


        }
        public void insertar(string sql) {

          

            OdbcCommand consulta = new OdbcCommand(sql, con.conexion());
                consulta.ExecuteNonQuery();




        }
        public string[] obtenerCampos(string tabla)//metodo que obtiene la lista de los campos que requiere una tabla
        {
            string[] Campos = new string[30];
            int i = 0;
            try
            {
                OdbcCommand command = new OdbcCommand("DESCRIBE " + tabla + "", con.conexion());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString();
                    i++;

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parámetros \n -" + tabla); }
            return Campos;// devuelve un arrgeglo con los campos
        }

        public void updateEstados(string tabla,string set ,string valorEstado, string WhereCampo, string id) {

            string sql = "UPDATE "+tabla+" SET "+set+" = '"+valorEstado+"' WHERE "+WhereCampo+" = " + id + ";";
            OdbcCommand consulta = new OdbcCommand(sql, con.conexion());
            consulta.ExecuteNonQuery();

            
        }

        public int contarAlias(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            int Campos = 0;

            try
            {
                OdbcCommand command = new OdbcCommand("DESCRIBE " + tabla + "", con.conexion());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Campos++;

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parámetros de la tabla  \n -" + tabla.ToUpper() + "\n -"); }
            return Campos;// devuelve un arreglo con los tiposlos campos
        }

       public OdbcDataAdapter inventarios() {



            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "select ip.id_producto, ci.maximo,  ip.cantidad_total  from inventarios_produccion ip INNER join configuraciones_inventarios ci on ip.cod_config=ci.cod_config INNER JOIN productos p ON ip.id_producto=p.id_producto where p.id_tipo_producto = 2 and ip.cantidad_total<=ci.repedido and ip.estado = 1 ;";
            //SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;



        }

        public string[] llenarCmb(string tabla, string campo1)
        {

            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string sql = "SELECT DISTINCT " + campo1 + " FROM " + tabla + " where estado = 1 ;";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Campos[i] = reader.GetValue(0).ToString();
                    i++;


                }




            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }


            return Campos;



        }





    }
   








    
}
