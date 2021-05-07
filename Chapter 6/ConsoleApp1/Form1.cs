using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        List<string> listKota = new List<string>();
        JsonArray listKotaId;

        public Form1()
        {
            InitializeComponent();
            listKota = ongkir.GetKotaList();
            listKotaId = ongkir.GetKotaIDList();
            foreach (string Kota in listKota)
            {
                tbAsal.AutoCompleteCustomSource.Add(Kota);
                tbAsal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbAsal.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbTujuan.AutoCompleteCustomSource.Add(Kota);
                tbTujuan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbTujuan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbAsal.Text != "" && tbTujuan.Text != "" && tbBerat.Text != "" )
            {
                string kurir = "";

                if (rbJne.Checked)
                {
                    kurir = "jne";
                }
                else if (rbPos.Checked)
                {
                    kurir = "pos";
                }
                else if (rbTiki.Checked)
                {
                    kurir = "tiki";
                }
                List<string> daftarLayanan = ongkir.GetLayananList(
                    GetIdKota(tbAsal.Text), GetIdKota(tbTujuan.Text), int.Parse(tbBerat.Text), kurir);
                TampilkanDaftar(daftarLayanan);
            }
        }

        private int GetIdKota(string kota)
        {
            int IdKota = -1;
            foreach (JsonObject city in listKotaId)
            {
                if (((string)city["city_name"]) == kota)
                {
                    IdKota = int.Parse((string)city["city_id"]);
                    break;
                }
            }
            return IdKota;
        }

        private void TampilkanDaftar (List<string> daftarLayanan)
        {
            groupBox1.Text = "Detail Layanan";
            foreach (string layanan in daftarLayanan)
            {
                groupBox1.Text += "\n-" + layanan;
            }
        }
    }
}
