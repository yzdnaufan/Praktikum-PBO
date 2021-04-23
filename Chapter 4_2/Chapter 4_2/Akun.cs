using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_2
{
    public class Akun : IIdentitas, ITransaksi
    {
        private const int maxSaldo = 2000000;
        protected int _saldo;
        protected string password;

        public int Id { get; set; }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length > 8)
                {
                    password = value;
                }
                else
                {
                    throw new InvalidOperationException("password harus lebih dari 8 karakter");
                }
            }
        }

        public int Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Saldo kurang dari 0 rupiah");
                else if ( value>maxSaldo)
                {
                    throw new InvalidOperationException("Saldo tidak boleh melebihi 2,000,000 Rupiah");
                }
                else
                {
                    _saldo = value;
                }
            }
        }
        public Akun (int id, int saldo, string password)
        {
            Id = id;
            _saldo = saldo;
            Password = password;
        }

        public virtual void Setor(int jumlah)
        {
            Saldo += jumlah;
        }

        public virtual void Tarik (int jumlah)
        {
            Saldo -= jumlah;
        }

        public bool PasswordTervalidasi (string password)
        {
            if (this.password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

   
}
