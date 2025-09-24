using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2.A
{
    public partial class Form1 : Form
    {
        private Calculator myCalculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int mulNum1 = int.Parse(textBox1.Text);
            int mulNum2 = int.Parse(textBox2.Text);
            textBox9.Text = myCalculator.Multiply(mulNum1, mulNum2).ToString();

            
            int divNum1 = int.Parse(textBox3.Text);
            int divNum2 = int.Parse(textBox4.Text);
            textBox10.Text = myCalculator.Divide(divNum1, divNum2).ToString();

            
            int addNum1 = int.Parse(textBox5.Text);
            int addNum2 = int.Parse(textBox6.Text);
            textBox11.Text = myCalculator.Add(addNum1, addNum2).ToString();

           
            int subNum1 = int.Parse(textBox7.Text);
            int subNum2 = int.Parse(textBox8.Text);
            textBox12.Text = myCalculator.Subtract(subNum1, subNum2).ToString();
        }
    }
}
