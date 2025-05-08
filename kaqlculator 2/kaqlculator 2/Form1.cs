using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaqlculator_2
{
    public partial class Form1 : Form
    {
        private string _input = "";  
        private double _firstNumber = 0;  
        private double _secondNumber = 0; 
        private string _operation = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _input += button.Text;
            textBox1.Text = _input;
        }
        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_input != "")
            {
                _firstNumber = double.Parse(_input);
                _operation = button.Text;
                _input = "";
            }
        }
        

        private void button16_Click(object sender, EventArgs e)
        {
            _input = "";
            _firstNumber = 0;
            _secondNumber = 0;
            _operation = "";
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (_input != "" && _operation != "")
            {
                _secondNumber = double.Parse(_input);
                double result = 0;

                switch (_operation)
                {
                    case "+":
                        result = _firstNumber + _secondNumber;
                        break;
                    case "-":
                        result = _firstNumber - _secondNumber;
                        break;
                    case "*":
                        result = _firstNumber * _secondNumber;
                        break;
                    case "/":
                        if (_secondNumber != 0)
                            result = _firstNumber / _secondNumber;
                        else
                            MessageBox.Show("Ошибка: Деление на 0!");
                        break;
                    case "^":
                        result = Math.Pow(_firstNumber, _secondNumber);
                        break;
                }

                textBox1.Text = result.ToString();
                _input = result.ToString();
                _operation = "";
            }
        }
    }
    }

