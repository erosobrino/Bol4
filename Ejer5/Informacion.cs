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
    //Validado
    public partial class Informacion : Form
    {
        public Informacion()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejer5_Form1 f1 = (Ejer5_Form1)Owner;
            try
            {
                lblError.Visible = false;
                f1.textBox1.SelectionStart = Convert.ToInt32(tbInicio.Text);
                f1.textBox1.SelectionLength = Convert.ToInt32(tbLongitud.Text);
                f1.textBox1.Focus();
            }
            catch
            {
                lblError.Visible = true;
            }
        }

        private void Informacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ejer5_Form1 f1 = (Ejer5_Form1)Owner;
            f1.btnSecundario.Enabled = true;
        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            modificarDatos();
        }

        public void modificarDatos()
        {
            Ejer5_Form1 f1 = (Ejer5_Form1)Owner;
            try
            {
                tbInicio.Text = f1.textBox1.SelectionStart + "";
                tbLongitud.Text = f1.textBox1.SelectionLength + "";
            }
            catch { }
        }
    }
}
