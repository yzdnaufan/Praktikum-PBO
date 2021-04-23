using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using QRCoder;

namespace Chapter_4
{
    class QRManager
    {
        public static void TukarInfo ( ref TextBox textBox1, ref TextBox textBox2)
        {
            string temp = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = temp;
        }

        public static string GenerateInfo (string namaAsal, string alamatAsal, string noHpAsal, 
            string namaTujuan, string alamatTujuan, string noHpTujuan)
        {
            string result = '#' + namaAsal + '*' + alamatAsal + '*' + noHpAsal + '*' + namaTujuan + '*' +
                alamatTujuan + '*' + noHpTujuan;
            return result;
        }

        public static string GenerateInfo(string namaAsal, string alamatAsal, string noHpAsal,
            string namaTujuan, string alamatTujuan, string noHpTujuan, out Bitmap Qrbitmap)
        {
            string text = GenerateInfo(namaAsal, alamatAsal, noHpAsal, namaTujuan, alamatTujuan, noHpTujuan);

            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qRCodeData);
            Qrbitmap = qRCode.GetGraphic(20);

            return text;

        }

    }
}
