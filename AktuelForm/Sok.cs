using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace AktuelForm
{
    public partial class Sok : Form
    {
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=127.0.0.1;Database=akutel;Uid=root;Pwd='';");

        public Sok()
        {
            InitializeComponent();
        }

        private void Sok_Load(object sender, EventArgs e)
        {
            string query = "SELECT Urun_adi FROM sok_urun WHERE sok_urun_id =1";

            {
                MySqlCommand komut = new MySqlCommand(query, mysqlbaglan);
                mysqlbaglan.Open();
                MySqlDataReader reader = komut.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string value = reader.GetString(0);
                    label1.Text = value;
                }

                reader.Close();
                mysqlbaglan.Close();
            }
            string query1 = "SELECT Urun_Gorseli FROM sok_urun WHERE sok_urun_id =1";

            {
                MySqlCommand komut1 = new MySqlCommand(query1, mysqlbaglan);
                mysqlbaglan.Open();
                MySqlDataReader reader1 = komut1.ExecuteReader();

                if (reader1.HasRows)
                {
                    reader1.Read();
                    string value = reader1.GetString(0);
                    pictureBox1.ImageLocation = value;
                }

                reader1.Close();
                mysqlbaglan.Close();
            }
            string query2 = "SELECT Urun_fiyati FROM sok_urun WHERE sok_urun_id =1";

            {
                MySqlCommand komut2 = new MySqlCommand(query2, mysqlbaglan);
                mysqlbaglan.Open();
                MySqlDataReader reader2 = komut2.ExecuteReader();

                if (reader2.HasRows)
                {
                    reader2.Read();
                    string value = reader2.GetString(0);
                    label7.Text = value;
                }

                reader2.Close();
                mysqlbaglan.Close();
            }
            string query3 = "SELECT Urun_adi FROM sok_urun WHERE sok_urun_id =2";

            {
                MySqlCommand komut3 = new MySqlCommand(query3, mysqlbaglan);
                mysqlbaglan.Open();
                MySqlDataReader reader3 = komut3.ExecuteReader();

                if (reader3.HasRows)
                {
                    reader3.Read();
                    string value = reader3.GetString(0);
                    label2.Text = value;
                }

                reader3.Close();
                mysqlbaglan.Close();
            }
            string query4 = "SELECT Urun_Gorseli FROM sok_urun WHERE sok_urun_id =2";

            {
                MySqlCommand komut4 = new MySqlCommand(query4, mysqlbaglan);
                mysqlbaglan.Open();
                MySqlDataReader reader4 = komut4.ExecuteReader();

                if (reader4.HasRows)
                {
                    reader4.Read();
                    string value = reader4.GetString(0);
                    pictureBox3.ImageLocation = value;
                }

                reader4.Close();
                mysqlbaglan.Close();
            }
            string query5 = "SELECT Urun_fiyati FROM sok_urun WHERE sok_urun_id =2";

            {
                MySqlCommand komut5 = new MySqlCommand(query5, mysqlbaglan);
                mysqlbaglan.Open();
                MySqlDataReader reader5 = komut5.ExecuteReader();

                if (reader5.HasRows)
                {
                    reader5.Read();
                    string value = reader5.GetString(0);
                    label8.Text = value;
                }

                reader5.Close();
                mysqlbaglan.Close();
            }
            string query6 = "SELECT Urun_adi FROM sok_urun WHERE sok_urun_id =3";

            {
                MySqlCommand komut6 = new MySqlCommand(query6, mysqlbaglan);
                mysqlbaglan.Open();
                MySqlDataReader reader6 = komut6.ExecuteReader();

                if (reader6.HasRows)
                {
                    reader6.Read();
                    string value = reader6.GetString(0);
                    label3.Text = value;
                }

                reader6.Close();
                mysqlbaglan.Close();
            }
            string query7 = "SELECT Urun_Gorseli FROM sok_urun WHERE sok_urun_id =3";

            {
                MySqlCommand komut7 = new MySqlCommand(query7, mysqlbaglan);
                mysqlbaglan.Open();
                MySqlDataReader reader7 = komut7.ExecuteReader();

                if (reader7.HasRows)
                {
                    reader7.Read();
                    string value = reader7.GetString(0);
                    pictureBox2.ImageLocation = value;
                }

                reader7.Close();
                mysqlbaglan.Close();
            }
            string query8 = "SELECT Urun_fiyati FROM sok_urun WHERE sok_urun_id =3";

            {
                MySqlCommand komut8 = new MySqlCommand(query8, mysqlbaglan);
                mysqlbaglan.Open();
                MySqlDataReader reader8 = komut8.ExecuteReader();

                if (reader8.HasRows)
                {
                    reader8.Read();
                    string value = reader8.GetString(0);
                    label9.Text = value;
                }

                reader8.Close();
                mysqlbaglan.Close();
            }
            string query9 = "SELECT Urun_adi FROM sok_urun WHERE sok_urun_id =3";

            {
                MySqlCommand komut9 = new MySqlCommand(query9, mysqlbaglan);
                mysqlbaglan.Open();
                MySqlDataReader reader9 = komut9.ExecuteReader();

                if (reader9.HasRows)
                {
                    reader9.Read();
                    string value = reader9.GetString(0);
                    label3.Text = value;
                }

                reader9.Close();
                mysqlbaglan.Close();
            }
        }
    }
}
