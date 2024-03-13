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
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Divicion = 3,
        Multiplicacion = 4,
        Modulo = 5,
    }

    public partial class Form1 : Form
    {
        Double valor1 = 0;
        Double valor2 = 0;
        Operacion operador = Operacion.NoDefinida;
        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeerNumero("1");


        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (valor2 == 0)
            {
                valor2 = Convert.ToDouble(cajaResultado.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                cajaResultado.Text = Convert.ToString(resultado);


            }
        }

        private void cajaResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            operador = Operacion.Modulo;
            ObtenerValor("%");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            operador = Operacion.Divicion;
            ObtenerValor("/");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = "0";
            lblHistorial.Text = "";



        }

        private void button16_Click(object sender, EventArgs e)
        {
                }

            }
            else
            {

            

        }
    }

        private void LeerNumero(string numero)
        {
            if (cajaResultado.Text == "0" && cajaResultado.Text != null)
            {
                cajaResultado.Text = numero;
            }
            else
            {
                cajaResultado.Text += numero;
            }
        }
        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2; 
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Divicion:
                    if(valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }

                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case Operacion.Modulo:
                    resultado = valor1 % valor2;
                    break;
            }
            return resultado;
        }
            private void btnCero_Click(object sender, EventArgs e)

        {
            if (cajaResultado.Text == "0") 
            {
                return;
            }
            else
            {
                cajaResultado.Text += "0";

            }

            
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }
        private void ObtenerValor (string operador)
        {
            valor1 = Convert.ToDouble(cajaResultado.Text);
            lblHistorial.Text = cajaResultado.Text + operador;
            cajaResultado.Text = "0";
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }
        }
    }
}