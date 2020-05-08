using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gamerind
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox2.Text;
            string pass = textBox1.Text;
            MySqlConnection conn = new MySqlConnection("server=gamerindroleplay.zapto.org;user id=gamerindrp;password=bikinibottom;persistsecurityinfo=True;database=stnk");
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from data where username = '"+textBox2.Text+"' and password = '"+textBox1.Text+"'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                samsat ss = new samsat();
                ss.Show();
            }
            else
            {
                MessageBox.Show("PASSWORD SALAH");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamerIND ss = new GamerIND();
            ss.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                button1.PerformClick();
            }
        }
    }
}
