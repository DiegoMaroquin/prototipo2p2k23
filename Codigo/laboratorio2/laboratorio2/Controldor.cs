using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laboratorio2;
using System.Data.Odbc;
using System.Data;


namespace laboratorio2
{
    public class Controldor
    {
       sentensias sn = new sentensias();

            {
            string consulta = "select * from  alumnos";
            OdbcDataAdapter dt = sn.llenartb2(consulta);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public void CargarTablas(ComboBox comboBox1, string BD)
        {
            OdbcDataAdapter dt = sn.buscartbl(BD);
            DataTable table = new DataTable();
            dt.Fill(table);
            int contador = 0;
            comboBox1.Items.Clear();
            foreach (DataRow Row in table.Rows)
            {
                comboBox1.Items.Add(table.Rows[contador][0].ToString());
                contador++;
            }


        }
    }
    
