using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4_2
{
    public partial class Form1 : Form
    {
        Akun akun = new AkunPremium(112, 20000, "hiya"); 
        

        private void TarikSaldo (int total)
        {
            akun.Tarik(total);
            lblSaldo.Text = akun.Saldo.ToString();
        }

        private void SetorSaldo (int total)
        {
            akun.Setor(total);
            lblSaldo.Text = akun.Saldo.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            lblSaldo.Text = akun.Saldo.ToString();
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            if (akun.PasswordTervalidasi(tbPassword.Text))
            {
                if (rbSetor.Checked)
                    SetorSaldo(int.Parse(tbUang.Text));
                else if (rbTarik.Checked)
                    TarikSaldo(int.Parse(tbUang.Text));
            }
            else
            {
                MessageBox.Show("Password Salah");
            }
        }
    }
}
