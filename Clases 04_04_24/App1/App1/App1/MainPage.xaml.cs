using System;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        string currentInput = string.Empty;
        double result = 0;
        string currentOperator = string.Empty;
        bool isResultDisplayed = false;

        public MainPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (isResultDisplayed)
            {
                currentInput = string.Empty;
                isResultDisplayed = false;
            }
            currentInput += button.Text;
            resultLabel.Text = currentInput;
        }

        void OnOperatorClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (!string.IsNullOrEmpty(currentOperator) && !isResultDisplayed)
            {
                PerformOperation();
                currentOperator = button.Text;
            }
            else
            {
                currentOperator = button.Text;
                result = double.Parse(currentInput);
            }
            currentInput = string.Empty;
        }

        void OnClearClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button.Text == "C")
            {
                currentInput = string.Empty;
                result = 0;
                currentOperator = string.Empty;
                resultLabel.Text = "0";
            }
            else if (button.Text == "⌫" && currentInput.Length > 0)
            {
                currentInput = currentInput.Remove(currentInput.Length - 1);
                resultLabel.Text = currentInput;
            }
        }

        void OnEqualClicked(object sender, EventArgs e)
        {
            PerformOperation();
            isResultDisplayed = true;
        }

        void PerformOperation()
        {
            if (!string.IsNullOrEmpty(currentOperator))
            {
                var secondNumber = double.Parse(currentInput);
                switch (currentOperator)
                {
                    case "+":
                        result += secondNumber;
                        break;
                    case "-":
                        result -= secondNumber;
                        break;
                    case "*":
                        result *= secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                            result /= secondNumber;
                        else
                            DisplayAlert("Error", "No se puede dividir por cero", "OK");
                        break;
                }
                resultLabel.Text = result.ToString();
                currentInput = string.Empty;
                currentOperator = string.Empty;
            }
        }
    }
}
