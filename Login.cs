using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Clear();
            textBox2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IV6BR82\\" +
                "SQLEXPRESS;" +"Initial Catalog=Stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
   FROM [Stock] [dbo].[Login] WHERE UserName = '"+ textBox2.Text +"' and Password = '"+ textBox1 +"'",con);
            DataTable dt = new DataTable();
            this.Hide();
            StockMain main = new StockMain();
            main.Show();
        }
    }
}
