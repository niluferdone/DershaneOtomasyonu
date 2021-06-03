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

namespace Dersane1
{
    public partial class frmOgrEkle : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public void Veri_Cek() {
             con = new SqlConnection(ApplicationConfigs.ConnectionString);
             da = new SqlDataAdapter("Select İsim ,Soyad ,No From Ogrenciler", con);
             ds = new DataSet();
            con.Open();
            da.Fill(ds, "Ogrenciler");
            dataGridView1.DataSource = ds.Tables["Ogrenciler"];
            con.Close();
            
        }
        public frmOgrEkle()
        {
            InitializeComponent();
        }

        private void frmOgrEkle_Load(object sender, EventArgs e)
        {
            Veri_Cek();
           
        }
  

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (textAd.Text.Trim() == "")
            {
                MessageBox.Show("Ad giriniz");
                
            }

            if (textSoyad.Text.Trim() == "")
            {
                MessageBox.Show("Soyad Giriniz");
                
            }

            if (textNo.Text.Trim() == "")
            {
                MessageBox.Show("No Giriniz");

            }
            else
            {
                string query = "insert into Ogrenciler(İsim,Soyad,No) values(@isim,@soyad,@no)";
                SqlConnection conn = new SqlConnection(ApplicationConfigs.ConnectionString);
                SqlCommand comm = new SqlCommand(query, conn);

                comm.Parameters.AddWithValue("@isim", textAd.Text);
                comm.Parameters.AddWithValue("@soyad", textSoyad.Text);
                comm.Parameters.AddWithValue("@no", textNo.Text);
                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();
                this.Close();
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
         
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update Ogrenciler set İsim='" + textAd.Text + "',Soyad='" + textSoyad.Text + "'Where No=" + textNo.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            Veri_Cek();

        }

    

       

      

        
    }
}
/*  string query = "Select * From Ogrenciler where İsim='" + textAd.Text + "'and Soyad='" + textSoyad.Text + "'";
                SqlConnection conn = new SqlConnection(ApplicationConfigs.ConnectionString);
                SqlCommand comm = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {

                    listBox1.Items.Add(dr["No"].ToString());
                }
                conn.Close();*/