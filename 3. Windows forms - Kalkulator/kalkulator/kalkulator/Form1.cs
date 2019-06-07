using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Name : Form
    {
        String operator1 = "";
        double liczba1=0.0;
         double liczba2=0.0;
        Boolean wybrany_operator;


        public Name()
        {
            InitializeComponent();
        }


        private void Liczby(object sender, EventArgs e)
        {
            {
                Button liczba = (Button)sender;
                textBox1.Text = textBox1.Text + liczba.Text;
            }

        }

        private void Operatory(object sender, EventArgs e)
        {
           Button operatory = (Button)sender;
            operator1 = operatory.Text;
           liczba1 = Double.Parse(textBox1.Text);
            textBox1.Clear();
            wybrany_operator = true;

            switch (operator1)
            {
                case "+":

                    label1.Text = liczba1 + " " + operator1;

                    break;

                case "-":

                    label1.Text = liczba1 + " " + operator1;

                    break;

                case "*":

                    label1.Text = liczba1 + " " + operator1;

                    break;

                case "/":

                    label1.Text = liczba1 + " " + operator1;

                    break;

                case "x^y":

                    label1.Text = liczba1 + " " + operator1;

                    break;

                case "modulo":

                    label1.Text = liczba1 + " " + operator1;

                    break;

                case "sqrt":

                    label1.Text = operator1 + " " + liczba1  ;

                    break;

                case "%":

                    label1.Text = liczba1 + " " + operator1;

                    break;
            }

        }

        private void wynik(object sender, EventArgs e)
        {
            switch (operator1)
            {
                case "+":
                    liczba2 = Double.Parse(textBox1.Text);
                    label1.Text = liczba1 + " " + operator1 + " " + liczba2;
                    textBox1.Text = (liczba1 + liczba2).ToString();
                    break;
                case "-":
                    liczba2 = Double.Parse(textBox1.Text);
                    label1.Text = liczba1 + " " + operator1 + " " + liczba2;
                    textBox1.Text = (liczba1 - liczba2).ToString();
                    break;
                case "*":
                   liczba2= Double.Parse(textBox1.Text);
                    label1.Text = liczba1 + " " + operator1 + " " + liczba2;
                    textBox1.Text = (liczba1 * liczba2).ToString();
                    break;
                case "/":
                    liczba2 = Double.Parse(textBox1.Text);
                    label1.Text = liczba1 + " " + operator1 + " " + liczba2;
                    textBox1.Text = (liczba1 / liczba2).ToString();
                    break;

                case "x^y":
                   liczba2 = Double.Parse(textBox1.Text);
                    label1.Text = liczba1 + " " + operator1 + " " + liczba2;
                    textBox1.Text = (Math.Pow(liczba1, liczba2)).ToString();
                    break;

                case "%":
                    liczba2 = Double.Parse(textBox1.Text);
                    label1.Text = liczba1 + " " + operator1 + " " + liczba2;
                    textBox1.Text = ((liczba1 * liczba2) / 100.0).ToString();
                    break;

                case "sqrt":
                    label1.Text = operator1 + " " + liczba1;
                    textBox1.Text = (Math.Sqrt(liczba1)).ToString();
                    break;

                case "modulo":
                    liczba2 = Double.Parse(textBox1.Text);
                    label1.Text = liczba1 + " " + operator1 + " " + liczba2;
                    textBox1.Text = ((liczba1 % liczba2)).ToString();
                    break;

            }
        }

        private void Przecinek(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void UsunOstatniZnak(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
