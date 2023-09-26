using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
namespace modelo
{
    

        public class Sentencias
        {      Conexion con = new Conexion();
            
            public OdbcDataAdapter buscartbl(string BD)
            {
                string sql = "SELECT TABLE_NAME From INFORMATION_SCHEMA.TABLES  WHERE TABLE_SCHEMA = '" + BD + "'";
                OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

                return datatable;
            }

            //Función: Inserción de datos
            public void insertar(string dato, string tipo, string tabla)
            {
                try
                {
                    string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
                    OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                }

            }

            //Función: Modificación de datos

            public void actualizar(string dato, string condicion, string tabla)
            {
                try
                {
                    string sql = "Update " + tabla + " " + dato + " where " + condicion;
                    OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                }


            }

            //Función: Consulta de datos

            public void insertarconsulta(string cadena)
            {
                try
                {
                    OdbcCommand consulta = new OdbcCommand(cadena, con.conexion());
                    consulta.ExecuteNonQuery();
                }
                catch (Exception Error)
                {
                    Console.WriteLine("Error en modelo" + Error);
                }
            }

            public OdbcDataAdapter llenartb2(string sql)
            {
                OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
                return datatable;
            }

        }
    
}
