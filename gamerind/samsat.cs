using gamerind.gamerindClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamerind
{
    public partial class samsat : Form
    {
        public samsat()
        {
            InitializeComponent();
        }
        gamerindClass c = new gamerindClass();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;
            MySqlConnection conn = new MySqlConnection(myconnstr);
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM datastnk WHERE nama LIKE '%"+keyword+"%' OR plat LIKE '%"+keyword+"%' OR jenis LIKE '%"+keyword+"%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataSTNK.DataSource = dt;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            c.nama = textBoxnama.Text;
            c.plat = textBoxplat.Text;
            c.jenis = textBoxjenis.Text;
            c.berlaku = dateTimePicker1.Value.ToString();

            bool success = c.Insert(c);
            if(success==true)
            {
                MessageBox.Show("Berhasil menambahkan data");
                clear();

            }
            else
            {
                MessageBox.Show("Gagal menambahkan data, silahkan periksa kembali");
            }
            DataTable dt = c.Select();
            dataSTNK.DataSource = dt;
        }

        private void textBoxnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void samsat_Load(object sender, EventArgs e)
        {
              DataTable dt = c.Select();
            dataSTNK.DataSource = dt;
        }

        private void samsat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        public void clear()
        {
            textBoxnama.Text = "";
            textBoxjenis.Text = "";
            textBoxplat.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            c.nama = textBoxnama.Text;
            c.plat = textBoxplat.Text;
            c.jenis = textBoxjenis.Text;
            c.berlaku = dateTimePicker1.Value.ToString();
            bool success = c.Update(c);
            if(success==true)
            {
                MessageBox.Show("Data berhasil di-update");
                DataTable dt = c.Select();
                dataSTNK.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Update gagal, silahkan cek kembali");
            }
        }

        private void dataSTNK_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxnama.Text = dataSTNK.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxplat.Text = dataSTNK.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxjenis.Text = dataSTNK.Rows[rowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataSTNK.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            c.plat = textBoxplat.Text;
            bool success = c.Delete(c);
            if(success==true)
            {
                MessageBox.Show("Data berhasil dihapus");
                DataTable dt = c.Select();
                dataSTNK.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Gagal menghapus data, silahkan cek kembali");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dataSTNK.DataSource = dt;
            clear();
        }
    }
}
