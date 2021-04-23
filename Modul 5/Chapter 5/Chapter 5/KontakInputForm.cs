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
    public partial class KontakInputForm : Form
    {
        Kontak newKontak;
        public enum Mode { Insert, Edit }
        Mode mode;
        public KontakInputForm()
        {
            InitializeComponent();
            mode = Mode.Insert;
            btnAksi.Text = "Tambah";
        }
        public KontakInputForm(string nama, string alamat, string nomor, string email)
        {
            InitializeComponent();
            mode = Mode.Edit;
            newKontak = new Kontak
            {
                Nama = nama,
                Alamat = alamat,
                No_Telp = nomor,
                Email = email
            };
            tbNama.Text = nama;
            tbAlamat.Text = alamat;
            tbNomor.Text = nomor;
            tbEmail.Text = email;
            btnAksi.Text = "Perbaharui";
        }
        private void EditData()
        {
            using (var db = new KontakModel())
            {
                var result = db.Kontaks.SingleOrDefault(k => k.Nama == newKontak.Nama);
                if (result != null)
                {
                    if (tbNama.Text != "" && tbAlamat.Text != "" && tbNomor.Text != "")
                    {
                        result.Nama = tbNama.Text;
                        result.Alamat = tbAlamat.Text;
                        result.No_Telp = tbNomor.Text;
                        result.Email = tbEmail.Text;
                        db.SaveChanges();
                        MessageBox.Show("Kontak berhasil diperbaharui");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Nama, Alamat, dan Nomor HP harus diisi");
                    }
                }
            }
        }
        private void TambahData()
        {
            if(tbNama.Text != "" && tbAlamat.Text != "" & tbNomor.Text != "")
            {
                using (var db = new KontakModel())
                {
                    newKontak = new Kontak
                    {
                        Nama = tbNama.Text,
                        Alamat = tbAlamat.Text,
                        No_Telp = tbNomor.Text,
                        Email = tbEmail.Text,
                    };
                    db.Kontaks.Add(newKontak);
                    db.SaveChanges();
                    MessageBox.Show("Kontak Ditambahkan");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Nama, Alamat, dan Nomor HP harus diisi");
            }
        }
        private void btnAksi_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
                TambahData();
            else if (mode == Mode.Edit)
                EditData();
        }
    }
}
