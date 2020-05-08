using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamerind
{
    public partial class GamerIND : Form
    {
        public GamerIND()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fivem://connect/gamerindroleplay.zapto.org");
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void GamerIND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ts3server://gamerindrp.zap-ts3.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ss = new Login();
            ss.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
