using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private double firstNumber = 0;
        private string operatorSymbol = "";
        private bool isOperatorClicked = false;

        private void btnOne_Click(object sender, EventArgs e)
        {
            if(txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "1";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "0";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "3";
        }

        private void btnFore_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += "9";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text += ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNumber;
            if (double.TryParse(txtNumber.Text, out secondNumber))
            {
                double result = 0;
                switch (operatorSymbol)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "x":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            result = firstNumber / secondNumber;
                        }
                        else
                        {
                            MessageBox.Show("除數不能為零！");
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("請選擇一個運算符");
                        return;
                }

                txtNumber.Text = result.ToString();
                firstNumber = result;  
                operatorSymbol = "";    
                isOperatorClicked = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber.Text, out firstNumber))
            {
                operatorSymbol = "+";
                isOperatorClicked = true;
                txtNumber.Text = ""; //  
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber.Text, out firstNumber))
            {
                operatorSymbol = "-";
                isOperatorClicked = true;
                txtNumber.Text = ""; //  
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber.Text, out firstNumber))
            {
                operatorSymbol = "x";
                isOperatorClicked = true;
                txtNumber.Text = ""; //  
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber.Text, out firstNumber))
            {
                operatorSymbol = "/";
                isOperatorClicked = true;
                txtNumber.Text = ""; //  
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
        }
    }
}
