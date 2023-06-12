using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace AktuelForm
{
    public partial class AnaEkran : Form
    {
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=127.0.0.1;Database=akutel;Uid=root;Pwd='';");
        public bool Veri { get; set; }

        public AnaEkran()
        {
            InitializeComponent();
        }

        /*hocam resimleri böyle çekicektimk ama bim a101 gibi yerler çekmemize izin vermiyor bizde veri tabanı yapıp oradan çektik
          WebClient client = new WebClient();
          string imageUrl = "https://www.bim.com.tr/Uploads/aktuel-urunler/948_buyuk_543X467_tava.jpg";
          byte[] imageData = client.DownloadData(imageUrl);
          using (MemoryStream ms = new MemoryStream(imageData))
          {
              pictureBox1.Image = Image.FromStream(ms);
          }*/
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Bim bim = new Bim();
            bim.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            A101 a101 = new A101();
            a101.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Sok sok = new Sok();
            sok.Show();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            if (Veri)
            {
                button7.Visible = true;
            }
            else
            {
                button7.Visible = false;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
    }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            A101 a101= new A101();
            a101.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
           Bim bim=new Bim();
            bim.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sok sok=new Sok();
            sok.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin admin=new Admin();
            admin.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Duzen duzen=new Duzen();
            duzen.Show();
        }
    }
}
