using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            NumeroParImpar();
            NumeroPositivoNegativo();
        }

        private int NumeroParImpar()
        {
            int NumEntero = 0;
            NumEntero = int.Parse(NumEnterotextBox.Text);
            if (NumEntero %2 == 0)
            {
                NumIPtextBox.Text = "PAR";
            }
            else
            {
                NumIPtextBox.Text = "IMPAR";
            }
            return 0; 
        }

        private double NumeroPositivoNegativo()
        {
            double NumNP;
            NumNP = Convert.ToDouble(NumEnterotextBox.Text);

            if (NumNP>=1)
            {
                NumNPtextBox.Text = "POSITIVO";
            }
            else if (NumNP == 0)
            {
                NumNPtextBox.Text = "NEUTRO";
            }
            else
            {
                NumNPtextBox.Text = "NEGATIVO";
            }
            return 0;
        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            NumEnterotextBox.Clear();
            NumNPtextBox.Clear();
            NumIPtextBox.Clear();

        }
    }
}
