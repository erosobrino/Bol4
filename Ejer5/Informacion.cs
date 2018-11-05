﻿using System;
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
    public partial class Informacion : Form
    {
        public Informacion()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejer5_Form1 f1 = (Ejer5_Form1)Owner;
            f1.textBox1.SelectionStart = Convert.ToInt32(tbInicio.Text);
            f1.textBox1.SelectionLength = Convert.ToInt32(tbLongitud.Text);
            Close();
        }

        private void Informacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ejer5_Form1 f1 = (Ejer5_Form1)Owner;
            f1.btnSecundario.Enabled = true;
        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            modificarDatos();
        }

        public void modificarDatos()
        {
            Ejer5_Form1 f1 = (Ejer5_Form1)Owner;
            tbInicio.Text = f1.textBox1.SelectionStart + "";
            tbLongitud.Text = f1.textBox1.SelectionLength + "";
        }
    }
}
