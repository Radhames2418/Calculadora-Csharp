using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {

        double primero;
        double segundo;

        string oper;
        public Calculadora()
        {
            InitializeComponent();
        }


        Clases.Suma sum = new Clases.Suma();
        Clases.Resta res = new Clases.Resta();
        Clases.Multiplicacion mult = new Clases.Multiplicacion();
        Clases.Division div = new Clases.Division();




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            PantallaResultado.Text = PantallaResultado.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PantallaResultado.Text = PantallaResultado.Text + ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {

            segundo = double.Parse(PantallaResultado.Text);

            double Suma;
            double resta;
            double multi;
            double divi;

            switch (oper)
            { 

                case "+":

                    Suma = sum.Sum((primero),(segundo));
                    PantallaResultado.Text = Suma.ToString();
                    break;

                case "-":

                    resta = res.Res((primero), (segundo));
                    PantallaResultado.Text = resta.ToString();
                    break;


                case "*":

                    multi = mult.mult((primero), (segundo));
                    PantallaResultado.Text = multi.ToString();
                    break;


                case "/":

                    divi =  div.Div((primero), (segundo));
                    PantallaResultado.Text = divi.ToString();
                    break;


            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PantallaResultado.Text = PantallaResultado.Text + "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PantallaResultado.Text = PantallaResultado.Text + "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (PantallaResultado.Text.Length == 1)

                PantallaResultado.Text = "";
            else

                PantallaResultado.Text = PantallaResultado.Text.Substring(0, PantallaResultado.Text.Length - 1);
        }

        private void NButton1_Click(object sender, EventArgs e)
        {
            PantallaResultado.Text = PantallaResultado.Text +  "1";
        }

        private void NButton2_Click(object sender, EventArgs e)
        {
            PantallaResultado.Text = PantallaResultado.Text + "2";
        }

        private void NButton3_Click(object sender, EventArgs e)
        {
            PantallaResultado.Text = PantallaResultado.Text + "3";
        }

        private void NButton5_Click(object sender, EventArgs e)
        {
            PantallaResultado.Text = PantallaResultado.Text + "5";
        }

        private void NButton6_Click(object sender, EventArgs e)
        {
            PantallaResultado.Text = PantallaResultado.Text + "6";
        }

        private void NButton7_Click(object sender, EventArgs e)
        {
            PantallaResultado.Text = PantallaResultado.Text + "7";
        }

        private void NButton9_Click(object sender, EventArgs e)
        {
            PantallaResultado.Text = PantallaResultado.Text + "9";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            PantallaResultado.Clear();
        }

        private void ButtonSum_Click(object sender, EventArgs e)
        {
            oper = "+";
            primero = double.Parse(PantallaResultado.Text);
            PantallaResultado.Clear();

        }

        private void ButtonRes_Click(object sender, EventArgs e)
        {
            oper = "-";
            primero = double.Parse(PantallaResultado.Text);
            PantallaResultado.Clear();

        }

        private void ButtonMult_Click(object sender, EventArgs e)
        {
            oper = "*";
            primero = double.Parse(PantallaResultado.Text);
            PantallaResultado.Clear();
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            oper = "/";
            primero = double.Parse(PantallaResultado.Text);
            PantallaResultado.Clear();
        }
    }
}
