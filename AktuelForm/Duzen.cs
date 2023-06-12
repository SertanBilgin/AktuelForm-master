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
using MySql.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AktuelForm
{
    public partial class Duzen : Form
    {
        Admin ana = new Admin();
        public string Verii { get; set; }

        public Duzen()
        {
            InitializeComponent();
            this.ana = new Admin();
        }
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=127.0.0.1;Database=akutel;Uid=root;Pwd='';");

        private void Duzen_Load(object sender, EventArgs e)
        {

            button7.Visible = false;
            button9.Visible = false;
            button8.Visible = false;

            textBox3.Visible = false;
            if (Verii == "a101")
            {
                kayitGetir1();
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                button3.Visible = false;
                button5.Visible = false;

            }
            else if (Verii == "bim")
            {
                kayitGetir2();
                dataGridView1.Visible = false;
                dataGridView3.Visible = false;
                button2.Visible = false;
                button5.Visible = false;

            }
            else if (Verii == "sok")
            {
                button3.Visible = false;
                button2.Visible = false;
                dataGridView2.Visible = false;
                dataGridView1.Visible = false;
            }
                
            }
,        }
       

        private void kayitGetir1()
        {
            mysqlbaglan.Open();

            string query1 = "SELECT a101_urun_id, Urun_adi, Urun_fiyati FROM a101_urun";
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(query1, mysqlbaglan);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);

            mysqlbaglan.Close();

         

           
            mysqlbaglan.Open();

            string query3 = "SELECT sok_urun_id, Urun_adi, Urun_fiyati FROM sok_urun";
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(query3, mysqlbaglan);
            DataTable dataTable3 = new DataTable();
            adapter3.Fill(dataTable3);

            dataGridView1.DataSource = dataTable1;
            dataGridView3.DataSource = dataTable3;
            mysqlbaglan.Close();
        }
        private void kayitGetir2()
        {
            mysqlbaglan.Open();

            string query2 = "SELECT bim_urun_id, Urun_adi, Urun_fiyati FROM bim_urun";
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, mysqlbaglan);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);
            mysqlbaglan.Close();
            dataGridView2.DataSource = dataTable2;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button9.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            button8.Visible = true;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            button7.Visible = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult uyar;

            uyar = MessageBox.Show(this, textBox3.Text + " Ürünü silmek istediğinize emin misiniz", "SİLME UYARISI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (uyar == DialogResult.Yes)

            {
                int n = Convert.ToInt16(textBox3.Text);
                mysqlbaglan.Open();
                string sil = "DELETE FROM sok_urun " + "Where sok_urun_id = '" + n + "'";
                MySqlCommand komut = new MySqlCommand(sil, mysqlbaglan);
                komut.ExecuteNonQuery();
                mysqlbaglan.Close();

            }
            try
            {
                MySqlDataAdapter adaptor = new MySqlDataAdapter("Select * from sok_urun", mysqlbaglan);
                DataSet ds = new DataSet();
                ds.Clear();
                adaptor.Fill(ds, "sok_urun");
                dataGridView3.DataSource = ds.Tables["sok_urun"];
                adaptor.Dispose();
            }
            catch
            {
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult uyar;

            uyar = MessageBox.Show(this, textBox2.Text + " Ürünü silmek istediğinize emin misiniz", "SİLME UYARISI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (uyar == DialogResult.Yes)

            {
                int n = Convert.ToInt16(textBox2.Text);
                mysqlbaglan.Open();
                string sil = "DELETE FROM bim_urun " + "Where Bim_urun_id = '" + n + "'";
                MySqlCommand komut = new MySqlCommand(sil, mysqlbaglan);
                komut.ExecuteNonQuery();
                mysqlbaglan.Close();

            }
            try
            {
                MySqlDataAdapter adaptor = new MySqlDataAdapter("Select * from bim_urun", mysqlbaglan);
                DataSet ds = new DataSet();
                ds.Clear();
                adaptor.Fill(ds, "bim_urun");
                dataGridView3.DataSource = ds.Tables["bim_urun"];
                adaptor.Dispose();
            }
            catch
            {
                return;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult uyar;

            uyar = MessageBox.Show(this, textBox1.Text + " Ürünü silmek istediğinize emin misiniz", "SİLME UYARISI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (uyar == DialogResult.Yes)

            {
                int n = Convert.ToInt16(textBox1.Text);
                mysqlbaglan.Open();
                string sil = "DELETE FROM a101_urun " + "Where a101_urun_id = '" + n + "'";
                MySqlCommand komut = new MySqlCommand(sil, mysqlbaglan);
                komut.ExecuteNonQuery();
                mysqlbaglan.Close();

            }
            try
            {
                MySqlDataAdapter adaptor = new MySqlDataAdapter("Select * from a101_urun", mysqlbaglan);
                DataSet ds = new DataSet();
                ds.Clear();
                adaptor.Fill(ds, "a101_urun");
                dataGridView3.DataSource = ds.Tables["a101_urun"];
                adaptor.Dispose();
            }
            catch
            {
                return;
            }
        }
    }
}
