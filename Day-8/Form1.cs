namespace Day_8
{
    public partial class Form1 : Form
    {
        private string operation = ""; // İşlem türü (+, -, *, /)
        private double firstNumber = 0; // İlk sayı

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearDefaultZero()
        {
            if (result.Text == "0")
            {
                result.Text = string.Empty;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            firstNumber = 0;
            operation = "";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            ClearDefaultZero();
            result.Text += "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            ClearDefaultZero();
            result.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            ClearDefaultZero();
            result.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            ClearDefaultZero();
            result.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            ClearDefaultZero();
            result.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            ClearDefaultZero();
            result.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            ClearDefaultZero();
            result.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            ClearDefaultZero();
            result.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            ClearDefaultZero();
            result.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            ClearDefaultZero();
            result.Text += "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(result.Text);
            operation = "+";
            result.Text = "0";
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(result.Text);
            operation = "-";
            result.Text = "0";
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(result.Text);
            operation = "*";
            result.Text = "0";
        }

        private void division_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(result.Text);
            operation = "/";
            result.Text = "0";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(result.Text);
            double calculationResult = 0;

            if (operation == "+")
            {
                calculationResult = firstNumber + secondNumber;
            }
            else if (operation == "-")
            {
                calculationResult = firstNumber - secondNumber;
            }
            else if (operation == "*")
            {
                calculationResult = firstNumber * secondNumber;
            }
            else if (operation == "/")
            {
                if (secondNumber != 0)
                {
                    calculationResult = firstNumber / secondNumber;
                }
                else
                {
                    MessageBox.Show("The number cannot be divided by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result.Text = "0";
                    return;
                }
            }
            else if (operation == "^") 
            {
                calculationResult = Math.Pow(firstNumber, secondNumber);
            }

            result.Text = calculationResult.ToString();
            historyListBox.Items.Add(firstNumber + operation + secondNumber + "=" + result.Text);
        }


        private void sqrt_Click(object sender, EventArgs e)
        {
            double number = double.Parse(result.Text);
            if (number >= 0)
            {
                result.Text = Math.Sqrt(number).ToString();
            }
            else
            {
                MessageBox.Show("Cannot calculate the square root of a negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result.Text = "0";
            }
        }

        private void percentage_Click(object sender, EventArgs e)
        {
            double number = double.Parse(result.Text);
            result.Text = (number / 100).ToString();
        }

        private void power_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(result.Text);
            operation = "^";
            result.Text = "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!result.Text.Contains("."))
            {
                result.Text += ".";
            }
        }
    }
}
