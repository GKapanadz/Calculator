
using System;
using System.Windows.Forms;

namespace Clculator
{
    public partial class Form1 : Form
    {   
        Double resultValue = 0;

        String operationPerformed = "";

        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void button15_Click(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result + button.Text;
        }

        private void btnMultiply_Click(object sender, System.EventArgs e)
        {
           
        }

        private void button1_Click(object sender, System.EventArgs e)
        {   
            if(textBox_Result.Text == "0" || isOperationPerformed == true)
            {
                textBox_Result.Clear();
            }

            isOperationPerformed = false;

            Button button = (Button)sender;

            if(button.Text == ".")
            {
                if(!textBox_Result.Text.Contains(".")) 
                {
                    textBox_Result.Text = textBox_Result.Text + button.Text;
                }               
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Operator_Click(object sender, EventArgs e)
        {  
            Button button = (Button)sender;
            if(resultValue != 0)
            {
                button11.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (operationPerformed == "+")
            {
                textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
            }
            else if (operationPerformed == "*")
            {
                textBox_Result.Text = (resultValue  * Double.Parse(textBox_Result.Text)).ToString();
            }
            else if(operationPerformed == "/")
            {      
                textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
