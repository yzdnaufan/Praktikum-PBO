using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_2
{
    interface ITransaksi
    {
        void Setor(int jumlah);

        void Tarik(int jumlah);
    }
}
