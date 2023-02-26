using System;
using System.Linq;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        // Variables Here
        public double number1, number2;
        public string ops;

        public Calculator()
        {
            InitializeComponent();
        }

        private void lblNumber_TextChanged(object sender, EventArgs e)
        {
            if (lblNumber.Text.Length >= 13)
            {
                lblNumber.Text = lblNumber.Text.Remove(lblNumber.Text.Length - 1, 1);
            }
            if (lblNumber.Text.Length == 0)
            {
                lblNumber.Text = "0";
            }
            if (lblNumber.Text.Contains('.'))
            {
                btnPoint.Enabled = false;
                pnlNumber.Focus();
            }
            else if (!lblNumber.Text.Contains('.'))
            {
                btnPoint.Enabled = true;
            }
        }

        private void clearButtons(object sender, EventArgs e)
        {
            if (sender == btnClear)
            {
                lblNumber.Text = "0";
                number1 = 0;
            }
            else
            {
                lblNumber.Text = lblNumber.Text.Remove(lblNumber.Text.Length - 1, 1);
            }
        }

        private void operatorButtons(object sender, EventArgs e)
        {
            ops = (sender as Button).Text;
                number1 = Convert.ToDouble(lblNumber.Text);
                lblNumber.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (number1 != 0)
            {
                number2 = Convert.ToDouble(lblNumber.Text);
                switch (ops)
                {
                    case "+":
                        lblNumber.Text = (number1 += number2).ToString();
                        break;
                    case "-":
                        lblNumber.Text = (number1 -= number2).ToString();
                        break;
                    case "X":
                        lblNumber.Text = (number1 *= number2).ToString();
                        break;
                    case "/":
                        lblNumber.Text = (number1 /= number2).ToString();
                        break;
                }
                number1 = 0;
            }
        }

        private void numberButtons_Click(object sender, EventArgs e)
        {
            if (lblNumber.Text == 0.ToString() && sender != btnPoint)
            {
                lblNumber.Text = (sender as Button).Text;
            }
            else if (lblNumber.Text == 0.ToString() && sender == btnPoint)
            {
                lblNumber.Text = "0.";
            }
            else
            {
                lblNumber.Text += (sender as Button).Text;
            }
        }
    }
}
