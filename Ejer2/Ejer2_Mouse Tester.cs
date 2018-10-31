#define OPCION

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ejer2
{
    public partial class Form1 : Form
    {

        //Validado
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = -1;
            int y = -1;
            if (sender is Button)
            {
                Button boton = (Button)sender;
                x = boton.Location.X + e.X;
                y = boton.Location.Y + e.Y;
            }
            else
            {
                x = e.X;
                y = e.Y;
            }
            Text = "x:" + x + " y:" + y;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Text = "Mouse Tester";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseButtons boton = e.Button;
            if (boton == MouseButtons.Left)
            {
                btnIzquierdo.BackColor = Color.Blue;
            }
            else
            {
                if (boton == MouseButtons.Right)
                {
                    btnDerecho.BackColor = Color.Blue;
                }
                else
                {
                    btnIzquierdo.BackColor = Color.Blue;
                    btnDerecho.BackColor = Color.Blue;
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseButtons boton = e.Button;
            if (boton == MouseButtons.Left)
            {
                btnIzquierdo.BackColor = BackColor;
            }
            else
            {
                if (boton == MouseButtons.Right)
                {
                    btnDerecho.BackColor = BackColor;
                }
                else
                {
                    btnIzquierdo.BackColor = BackColor;
                    btnDerecho.BackColor = BackColor;
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
#if OPCION
            Text = "Tecla: " + e.KeyChar;
#endif

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
#if !OPCION
            Keys tecla = e.KeyCode;
            if (tecla==Keys.Escape)
            {
                Text = "Mouse Tester";
            }
            else
            {
                Text = "Tecla: "+e.KeyCode;
            }
#endif
        }
    }
}