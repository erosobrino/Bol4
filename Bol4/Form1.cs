using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bol4
{
    //Validado
    public partial class Form1 : Form
    {
        Color color;
        public Form1()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btColor_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                int rojo = Convert.ToInt32(tbR.Text);
                int verde = Convert.ToInt32(tbG.Text);
                int azul = Convert.ToInt32(tbB.Text);
                this.BackColor = Color.FromArgb(rojo, verde, azul);
                this.BackgroundImage = null;
            }
            catch (OverflowException)
            {
                lblError.Text = "Los valores son muy altos (0-255)";
            }
            catch (FormatException)
            {
                lblError.Text = "Los valores deben ser numericos (0-255)";
            }
            catch (Exception)
            {
                lblError.Text = "Los valores no son validos (0-255)";
            }
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            color = bt.BackColor;
            bt.BackColor = Color.Blue;
        }
        private void MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = color;
        }

        private void btImagen_Click(object sender, EventArgs e)
        {
            //D:\Descargas\Hopstarter-Software-Mozilla-Firefox.ico
            string ruta = tbImagen.Text;
            if (ruta.Length != 0)
            {
                try
                {
                    this.BackgroundImage = new Bitmap(ruta);
                    ResetBackColor();
                    lblError.Text = "";
                }
                catch
                {
                    lblError.Text = "La ruta no es valida";
                }
            }
            else
            {
                this.BackgroundImage = null;
            }
        }
    }
}
