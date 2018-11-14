using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer4
{
    public partial class Form1 : Form
    {
        public delegate double Mydelegate(int num1, int num2);
        Mydelegate suma = new Mydelegate((num1, num2) => num1 + num2);
        Mydelegate resta = new Mydelegate((num1, num2) => num1 - num2);
        Mydelegate multiplicacion = new Mydelegate((num1, num2) => num1 * num2);
        Mydelegate operacion;
        Hashtable hashtable = new Hashtable();

        public Form1()
        {
            InitializeComponent();
            rbSuma.Checked = true;
            Mydelegate[] mydelegates = new Mydelegate[] { suma, resta, multiplicacion, division };
            hashtable.Add(rbSuma.Text, mydelegates[0]);
            hashtable.Add(rbResta.Text, mydelegates[1]);
            hashtable.Add(rbMultiplicacion.Text, mydelegates[2]);
            hashtable.Add(rbDivision.Text, mydelegates[3]);
            operacion = (Mydelegate)hashtable[rbSuma.Text];
        }

        public double division(int num1, int num2)
        {
            if (num2 == 0)
            {
                lbError.Text = "No se puede dividir entre 0";
                lbResultado.Text = "";
            }
            else
            {
                return (double)num1 / num2;
            }
            return 0;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            lbError.Text = "";
            if (tbNum1.TextLength > 0 && tbNum2.TextLength > 0)
            {
                try
                {
                    num1 = Convert.ToInt32(tbNum1.Text);
                    num2 = Convert.ToInt32(tbNum2.Text);
                    if (rbDivision.Checked)
                    {
                        double result = operacion(num1, num2);
                        if (result != 0)
                        {
                            lbResultado.Text = "= "+result;
                        }
                    }
                    else
                    {
                        lbResultado.Text = "= "+operacion(num1, num2);
                    }
                }
                catch (FormatException)
                {
                    lbError.Text = "Debes introducir dos validos";
                    lbResultado.Text = "";
                }
                catch (OverflowException)
                {
                    lbError.Text = "Los numeros no pueden ser tan grandes";
                    lbResultado.Text = "";
                }
            }
            else
            {
                lbError.Text = "Debes introducir dos numeros";
                lbResultado.Text = "";
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            lbIcono.Text = ((RadioButton)sender).Tag + "";
            operacion = (Mydelegate)hashtable[((RadioButton)sender).Text];
        }
    }
}
