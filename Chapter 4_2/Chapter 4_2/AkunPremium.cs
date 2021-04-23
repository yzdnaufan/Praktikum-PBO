using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_2
{
    public class AkunPremium : Akun
    {
        public AkunPremium(int id, int saldo, string password ): base(id, saldo, password)
        {
            Id = id;
            Password = password;
            Saldo = saldo;
        }

        public new int Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value<0)
                {
                    throw new InvalidOperationException("Saldo tidak bisa kurang dari 0");
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        public override void Setor(int jumlah)
        {
            Saldo += jumlah + 500;
        }
        public override void Tarik(int jumlah)
        {
            Saldo -= jumlah + 500; 
        }
    }
}
