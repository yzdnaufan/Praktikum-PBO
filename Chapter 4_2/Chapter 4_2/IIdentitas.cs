using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_2
{
    interface IIdentitas
    {
        int Id { get; set; }

        string Password { get; set; }

        int Saldo { get; set; }
        
    }
}
