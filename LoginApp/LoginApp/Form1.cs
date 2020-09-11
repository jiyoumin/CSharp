using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqicon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\LoginApp\LoginApp\LoginDB.mdf;Integrated Security=True");
            string query = "SELECT * FROM Login WHERE Username='"+textBox1.Text.Trim()+"'"+
                " and Password='"+textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqicon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("비번이나 아이디가 틀렸습니다.");
            }
        }
    }
}
