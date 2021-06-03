using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dersane1
{
    public partial class Form1 : Form
    {
        
        public void Veri_Cek()
        {
            string query = "insert into Ogrenciler(İsim,Soyad,No) values(@isim,@soyad,@no)";
            SqlConnection conn = new SqlConnection(ApplicationConfigs.ConnectionString);
            SqlCommand komut = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IDtextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasstextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Giris_button_Click(object sender, EventArgs e)
        {

            Panel panel = new Panel();
            panel.Show();
        }
    }
}
