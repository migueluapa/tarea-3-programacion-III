using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


using System.Windows.Forms;

namespace Empleados
{
    public partial class Ver_Listado : Form
    {
        public Ver_Listado()
        {
            InitializeComponent();
        }

        public SQLiteConnection conexion = new SQLiteConnection("Data Source=C:/Users/User/Desktop/Visual C #-SQLite/Empleados_BD_SQLite.s3db");


        private void cargardato()
        {


            SQLiteConnection conexion = new SQLiteConnection("Data Source=C:/Users/User/Desktop/Visual C #-SQLite/Empleados_BD_SQLite.s3db");



        conexion.Open();
           

            SQLiteDataAdapter da;
            DataTable dt = new DataTable();


            da = new SQLiteDataAdapter("SELECT  * from empleado ", conexion);

            da.Fill(dt);

            this.dataGridView1.DataSource = dt;

            conexion.Close();


        }


        private void Ver_Listado_Load(object sender, EventArgs e)
        {
             cargardato();

        }
    }
}
