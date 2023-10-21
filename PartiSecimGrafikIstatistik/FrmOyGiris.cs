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

namespace PartiSecimGrafikIstatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-F5HD02D\\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");

        private void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void BtnOyGiris_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("INSERT into Tbl_Ilceler (IlceAd, AParti, BParti, CParti, DParti, EParti) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", bgl);
            cmd.Parameters.AddWithValue("@p1", TxtIlceAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtAParti.Text);
            cmd.Parameters.AddWithValue("@p3", TxtBParti.Text);
            cmd.Parameters.AddWithValue("@p4", TxtCParti.Text);
            cmd.Parameters.AddWithValue("@p5", TxtDParti.Text);
            cmd.Parameters.AddWithValue("@p6", TxtEParti.Text);
            cmd.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show($"{TxtIlceAd.Text} ilçesinde;\nA Partisine: {TxtAParti.Text} Oy,\nB Partisine: {TxtBParti.Text} Oy,\nCPartisine: {TxtCParti.Text} Oy,\nD Partisine: {TxtDParti.Text} Oy,\nE Partisine: {TxtEParti.Text} Oy\nGirişi Yapılmıştır.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Temizle();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm= new FrmGrafikler();
            frm.Show();
            
        }
    }
}
