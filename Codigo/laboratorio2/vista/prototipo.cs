using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vista;

namespace vista
{
    public partial class prototipo : Form
    {
        public prototipo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reporte1 frm = new Reporte1();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = cn.llenarTbl(tabla);
             = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new prototipo());
    }
}



