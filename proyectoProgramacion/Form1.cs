using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProyectoProgramacion_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 48;
            double A, B, C;
            int valor = 2;
            double perimetrocirc;
            double areacirc;
            double hipotenusa;
            double hipotenusacalc;
            double perimetrotriang;
            double areatriang;
            double arearomb;
            double rombohip;
            double rombosqrt;
            double perimetrorect;
            double arearect;


            A = double.Parse(textBox1.Text);
            B = double.Parse(textBox2.Text);
            C = double.Parse(textBox3.Text);


          


            if (i % A == 0)
            {
                perimetrocirc = valor * Math.PI * A;

                areacirc = Math.PI * (Math.Pow(A, 2));

                textBox6.Text = String.Format("El perimetro del circulo es: {0}", perimetrocirc);

                textBox9.Text = String.Format("el area del circulo es: {0}", areacirc);

            } else
            {
                textBox6.Text = String.Format("El primer valor no es factor de 48");
                textBox9.Text = String.Format("El primer valor no es factor de 48");

            }

            if (B % 2 == 1 && C % 2 == 1)
            {
                hipotenusa = (Math.Pow(B, 2)) + (Math.Pow(C, 2));
                hipotenusacalc = Math.Sqrt(hipotenusa);
                perimetrotriang = hipotenusacalc + B + C;
                areatriang = (B * C) / valor;

                textBox7.Text = String.Format("El perimetro del triangulo es: {0}", perimetrotriang);
                textBox10.Text = String.Format("El area del triangulo es: {0}", areatriang);

                rombohip = (Math.Pow(B, 2)) + (Math.Pow(C, 2));
                rombosqrt = Math.Sqrt(rombohip) * valor;
                arearomb = (B * C) / valor;

                textBox8.Text = String.Format("El perimetro del rombo es: {0}", rombosqrt);
                textBox11.Text = String.Format("El area del rombo es: {0}", arearomb);

            } else
            {
                textBox7.Text = String.Format("El segundo y tercer valor no son impares");
                textBox10.Text = String.Format("El segundo y tercer valor no son impares");

            }

            if(B % 2 == 1 && C % 2 == 1)
            {

                rombohip = (Math.Pow(B, 2)) + (Math.Pow(C, 2));
                rombosqrt = Math.Sqrt(rombohip) * valor;
                arearomb = (B * C) / valor;

                textBox8.Text = String.Format("El perimetro del rombo es: {0}", rombosqrt);
                textBox11.Text = String.Format("El area del rombo es: {0}", arearomb);
            } else
            {
                textBox8.Text = String.Format("El segundo y tercer valor no son impares");
                textBox11.Text = String.Format("El segundo y tercer valor no son impares");

            }

            if (A != C)
            {
                perimetrorect = (valor * A) + (valor * C);
                textBox4.Text = String.Format("El perimetro del rectangulo es: {0}", perimetrorect);
                arearect = A * C;
                textBox5.Text = String.Format("El area del rectangulo es: {0}", arearect);


            } else
            {
                textBox4.Text = String.Format("El primer y tercer valor no son diferentes");
                textBox5.Text = String.Format("El primer y tercer valor no son diferentes");
            }

     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Complete el campo requerido");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Complete el campo requerido");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Complete el campo requerido");
            }
        }
    }
    
    
}
