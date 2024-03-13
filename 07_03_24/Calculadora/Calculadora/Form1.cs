//Realizacion de una calculadora en C#
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
    //agregamos una adeclaracion para las operaciones matematicas
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
    // creamos variables para la soperaciones matematicas

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
            //Dando valor al booton numero 1
            LeerNumero("1");


        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Damos valor al igual para que realice sus funciones 
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
            // agregamos codigos para que el porcentaje  realice su funcion
            operador = Operacion.Modulo;
            ObtenerValor("%");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // agregamos codigos para que la divicion realice su funcion
            operador = Operacion.Divicion;
            ObtenerValor("/");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Agregamos codigo para recet(elimina todo)
            cajaResultado.Text = "0";
            lblHistorial.Text = "";



        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Agregamos codigo a borrar (Borra un numero a la vez)
               if (cajaResultado.Text.Length > 1)
            {
                string txtResultado = cajaResultado.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);
                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    cajaResultado.Text = "0";
                }
                else
                {
                    cajaResultado.Text = txtResultado;
                }


            }
            else
            {
                cajaResultado.Text = "0";
            }


        }
    
    // Creamos una clase para que los botones con numeros realicen su función
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
    // Creamos otra clase para las operacion matematicas
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
            //Dando el valo al booton numero 0
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
            //Dando valor al booton  numero2 
            LeerNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            //Dando valor al booton numero 3
            LeerNumero("3");
        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            //Dando valor al booton numero 4
            LeerNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            //Dando valor al booton numero 5
            LeerNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            //Dando valor al booton numero 6
            LeerNumero("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            //Dando valor al booton numero 7
            LeerNumero("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            //Dando valor al booton numero 8
            LeerNumero("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            //Dando valor al booton numero 9
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
            // agregamos codigos para que la suma realice su funcion
            operador = Operacion.Suma;
            ObtenerValor("+");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            // agregamos codigos para que la resta realice su funcion
            operador = Operacion.Resta;
            ObtenerValor("-");

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            // agregamos codigos para que la multiplicacion realice su funcion
            operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //Agregamos funciones para que de el punto 
            if(cajaResultado.Text.Contains("."))
            {
                return;
            }
            cajaResultado.Text += ".";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
