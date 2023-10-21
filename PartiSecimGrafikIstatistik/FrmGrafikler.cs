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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-F5HD02D\\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //ilçe adlarını comboboxa çekme
            bgl.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT IlceAd from Tbl_Ilceler", bgl);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                CmbIlceler.Items.Add(dr[0]);
            }
            bgl.Close();

            //grafiğe toplam sonuçları getirme
            bgl.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT SUM(AParti), SUM(BParti), SUM(CParti), SUM(DParti), SUM(EParti) FROM Tbl_Ilceler", bgl);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Parti", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B Parti", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C Parti", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D Parti", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E Parti", dr2[4]);
            }
            bgl.Close();
            CmbIlceler.SelectedIndex = 0;
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CmbIlceler_SelectedIndexChanged(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Ilceler WHERE IlceAd = @p1",bgl);
            cmd.Parameters.AddWithValue("@p1",CmbIlceler.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //progress barlar
                PrbAp.Value =Convert.ToInt32(dr[2].ToString());
                PrbBp.Value =Convert.ToInt32(dr[3].ToString());
                PrbCp.Value =Convert.ToInt32(dr[4].ToString());
                PrbDp.Value =Convert.ToInt32(dr[5].ToString());
                PrbEp.Value =Convert.ToInt32(dr[6].ToString());

                //labeller
                LblAp.Text = dr[2].ToString();
                LblBp.Text = dr[3].ToString();
                LblCp.Text = dr[4].ToString();
                LblDp.Text = dr[5].ToString();
                LblEp.Text = dr[6].ToString();

                //geçerli oy
                LblGecerliOy.Text = (PrbAp.Value + PrbBp.Value + PrbCp.Value + PrbDp.Value + PrbEp.Value).ToString();
            }
            bgl.Close();
        }
    }
}
