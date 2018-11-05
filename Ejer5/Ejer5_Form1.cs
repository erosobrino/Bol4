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
        bool invertir = false;
        public int inicio;
        public int cantidad;
        Informacion info;

        public Ejer5_Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info = new Informacion();
            info.Show(this);
            btnSecundario.Enabled = false;
        }

        private void CheckedChangedFuente(object sender, EventArgs e)
        {
            Font font = new Font(((RadioButton)sender).Text, 10);
            textBox1.Font = font;
        }

        private void CheckedChangedColor(object sender, EventArgs e)
        {
            if (invertir)
            {
                BackColor = Color.FromName(((RadioButton)sender).Name);
            }
            else
            {
                textBox1.BackColor = Color.FromName(((RadioButton)sender).Name);
            }

        }

        private void cbHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                gbColor.Enabled = true;
                cbInvertirColores.Enabled = true;
            }
            else
            {
                gbColor.Enabled = false;
                cbInvertirColores.Enabled = false;
            }
        }

        private void cbInvertirColores_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                invertir = true;
            }
            else
            {
                invertir = false;
            }
            Color aux = BackColor;
            BackColor = textBox1.BackColor;
            textBox1.BackColor = aux;
        }

        private void Ejer5_Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (info != null)
            {
                info.modificarDatos();
            }
        }
    }
}
