using System;
using System.Windows.Forms;
using System.Drawing;

namespace Chapter_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTukar_Click(object sender, EventArgs e)
        {
            QRManager.TukarInfo(ref tbNamaPenerima, ref tbNamaPengirim);
            QRManager.TukarInfo(ref tbAlamatAsal, ref tbAlamatTujuan);
            QRManager.TukarInfo(ref tbHpPenerima, ref tbHpPengirim);
        }

        private void btProses_Click(object sender, EventArgs e)
        {
            Bitmap qr;
            tbQr.Text = QRManager.GenerateInfo(
                tbNamaPengirim.Text,
                tbAlamatAsal.Text,
                tbHpPengirim.Text,
                tbNamaPenerima.Text,
                tbAlamatTujuan.Text,
                tbHpPenerima.Text, out qr);
            pbQR.Image = qr;
            
        }
    }
}
