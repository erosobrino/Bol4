﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//D:\Descargas\Hopstarter-Software-Mozilla-Firefox.ico
//D:\Descargas\imagen.png
namespace Ejer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (tbRuta.Text.Length != 0)
            {
                try
                {
                    Bitmap img = new Bitmap(tbRuta.Text);
                    Form2 f2 = new Form2();
                    f2.Text = Path.GetFileName(tbRuta.Text);
                    f2.ClientSize = img.Size;
                    f2.BackgroundImage = img;
                    if (cbModal.Checked)
                    {
                        f2.ShowDialog();
                    }
                    else
                    {
                        f2.Show(this);
                        btnAbrir.Enabled = false;
                    }
                }
                catch
                {
                    lblError.Text = "Error en la ruta";
                }
            }
            else
            {
                lblError.Text = "Error en la ruta";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
