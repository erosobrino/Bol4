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
        public int longitud;
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

        private void cambiaFuente(object sender, EventArgs e)
        {
            Font font = new Font(((RadioButton)sender).Text.Substring(1), 12);
            textBox1.Font = font;
        }

        private void CheckedChangedColor(object sender, EventArgs e)
        {
            if (invertir)
            {
                textBox1.ForeColor= Color.FromName(((RadioButton)sender).Name);
            }
            else
            {
                textBox1.BackColor = Color.FromName(((RadioButton)sender).Name);
            }

        }

        private void cbHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            gbColor.Enabled = ((CheckBox)sender).Checked;
            cbInvertirColores.Enabled = ((CheckBox)sender).Checked;
        }

        private void cbInvertirColores_CheckedChanged(object sender, EventArgs e)
        {
            invertir = ((CheckBox)sender).Checked;
            Color aux = textBox1.ForeColor;
            textBox1.ForeColor = textBox1.BackColor;
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

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (info != null)
            {
                info.modificarDatos();
            }
        }
    }
}
