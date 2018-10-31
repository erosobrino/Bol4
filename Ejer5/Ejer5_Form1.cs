using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer5
{
    public partial class Ejer5_Form1 : Form
    {
        public Ejer5_Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CheckedChangedFuente(object sender, EventArgs e)
        {
            Font font = new Font(((RadioButton)sender).Text, 10);
            textBox1.Font = font;
        }

        private void CheckedChangedColor(object sender, EventArgs e)
        {
            BackColor = Color.FromName(((RadioButton)sender).Name);
        }
    }
}
