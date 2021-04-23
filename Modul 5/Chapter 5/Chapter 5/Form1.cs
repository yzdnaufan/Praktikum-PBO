using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            lblNama.Text = "-";
            lblAlamat.Text = "-";
            lblNomor.Text = "-";
            lblEmail.Text = "-";
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
            using(var db = new KontakModel())
            {
                var query = from kontak in db.Kontaks where kontak.Nama == tbCari.Text select kontak;
                foreach(var item in query)
                {
                    lblNama.Text = item.Nama;
                    lblAlamat.Text = item.Alamat;
                    lblNomor.Text = item.No_Telp;
                    lblEmail.Text = item.Email;
                    btnEdit.Enabled = true;
                    btnHapus.Enabled = true;
                }
            }
        }
        private void btnTambahKontak_Click(object sender, EventArgs e)
        {
            KontakInputForm kontakForm = new KontakInputForm();
            kontakForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            KontakInputForm kontakForm = new KontakInputForm(lblNama.Text, lblAlamat.Text, lblNomor.Text, lblEmail.Text);
            kontakForm.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            using(var db = new KontakModel())
            {
                db.Kontaks.RemoveRange(db.Kontaks.Where(item => item.Nama == lblNama.Text));
                db.SaveChanges();
                lblNama.Text = "-";
                lblAlamat.Text = "-";
                lblNomor.Text = "-";
                lblEmail.Text = "-";
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;
            }
        }
    }
}
