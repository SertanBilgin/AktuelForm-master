﻿using MySql.Data.MySqlClient;
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
namespace AktuelForm
{
    public partial class Admin : Form
    {
        AnaEkran ana = new AnaEkran();

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=127.0.0.1;Database=akutel;Uid=root;Pwd='';");


        public Admin()
        {
            this.ana = new AnaEkran();
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string kullanici_adi = textBox1.Text;
            string sifre = textBox2.Text;
            MySqlCommand cmd = new MySqlCommand();
            mysqlbaglan.Open();
            cmd.Connection = mysqlbaglan;
            cmd.CommandText = "SELECT * FROM giris_kontrol where kullanici_adi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (kullanici_adi == "a101")
                {
                    string Verii = kullanici_adi;
                }
                else if (kullanici_adi == "bim") 
                {
                    string Verii = kullanici_adi;
                }
                else if(kullanici_adi == "sok")
                {
                    string Verii = kullanici_adi;
                }
                bool veri = true;
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Veri = veri;
                anaEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            mysqlbaglan.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
