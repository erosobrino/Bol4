using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer3
{
    public partial class Ejer3_Form2 : Form
    {
        public Ejer3_Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ejer3_Form1 f1 = (Ejer3_Form1)Owner;
            if (f1 != null)
            {
                f1.cambiarEnabledBoton(true);
            }
        }
    }
}
