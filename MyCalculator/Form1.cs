using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Double num1;
        static Double num2;
        string option;
        static Double result;
        Double flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag==1)
            {
                txtTotal.Clear();
                txtTotal.Text = txtTotal.Text + btn1.Text;
                flag = 0;
            }
            else 
            {
             txtTotal.Text = txtTotal.Text + btn1.Text;
            }
   
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                txtTotal.Clear();
                txtTotal.Text = txtTotal.Text + btn2.Text;
                flag = 0;
            }
            else
            {
                txtTotal.Text = txtTotal.Text + btn2.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                txtTotal.Clear();
                txtTotal.Text = txtTotal.Text + btn3.Text;
                flag = 0;
            }
            else
            {
                txtTotal.Text = txtTotal.Text + btn3.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                txtTotal.Clear();
                txtTotal.Text = txtTotal.Text + btn4.Text;
                flag = 0;
            }
            else
            {
                txtTotal.Text = txtTotal.Text + btn4.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                txtTotal.Clear();
                txtTotal.Text = txtTotal.Text + btn5.Text;
                flag = 0;
            }
            else
            {
                txtTotal.Text = txtTotal.Text + btn5.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                txtTotal.Clear();
                txtTotal.Text = txtTotal.Text + btn6.Text;
                flag = 0;
            }
            else
            {
                txtTotal.Text = txtTotal.Text + btn6.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                txtTotal.Clear();
                txtTotal.Text = txtTotal.Text + btn7.Text;
                flag = 0;
            }
            else
            {
                txtTotal.Text = txtTotal.Text + btn7.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                txtTotal.Clear();
                txtTotal.Text = txtTotal.Text + btn8.Text;
                flag = 0;
            }
            else
            {
                txtTotal.Text = txtTotal.Text + btn8.Text;
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                txtTotal.Clear();
                txtTotal.Text = txtTotal.Text + btn9.Text;
                flag = 0;
            }
            else
            {
                txtTotal.Text = txtTotal.Text + btn9.Text;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                txtTotal.Clear();
                txtTotal.Text = txtTotal.Text + btn0.Text;
                flag = 0;
            }
            else
            {
                txtTotal.Text = txtTotal.Text + btn0.Text;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = Double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = Double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = Double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = Double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            result = 0;
            num2 = Double.Parse(txtTotal.Text);
            if (option.Equals("+"))
                result =num1 + num2;
            if (option.Equals("-"))
                result = num1 - num2;
            if (option.Equals("*"))
            result = num1 * num2;
            if (option.Equals("/"))
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else 
                {
                    txtTotal.Clear();
                    MessageBox.Show("Division by 0 Error");
                   
                }
            }

            txtTotal.Text = result + "";
            flag = 1;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
