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



    }
}
