using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dado2
{
    public partial class Form1 : Form
    {
        Dado d = new Dado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLanzar1_Click(object sender, EventArgs e)
        {

            txtSimulacion.Text += Convert.ToString(d.Lanzar()) + Environment.NewLine;
            txtSimulacion.Text += Environment.NewLine;
        }

        private void btnLanzar100_Click(object sender, EventArgs e)
        {
            int[] veces = ContarFrecuencia100();
            for (int i = 0; i < 6; i++)
            {
                txtSimulacion.Text += "Cara: " + (i + 1) + ": " + veces[i] + Environment.NewLine;
            }

            txtSimulacion.Text += Environment.NewLine;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int[] vecesSuma = new int[11];
            for (int i = 0; i < 100; i++)
            {
                vecesSuma[d.Lanzar() + d.Lanzar() - 2]++;
            }
            for (int i = 0; i < 11; i++)
            {
                txtSimulacion.Text += "Suma " + (i + 1) + ": " + vecesSuma[i] + Environment.NewLine;
            }
            txtSimulacion.Text += Environment.NewLine;
            
        }

        public int[] ContarFrecuencia100()
        {
            int[] veces = new int[6];
            for (int i = 0; i < 100; i++)
            {
                int valor = d.Lanzar();
                veces[valor - 1]++;
             
            }
            return veces;

        }

        public int suma100()
        {
            int suma = 0;
            for (int i = 0; i < 100; i++)
            {
                suma += d.Lanzar();
            }
            return suma;
        }

        
    }
}
