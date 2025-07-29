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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox9.Text = ((int.Parse(textBox1.Text) * (int.Parse(textBox2.Text))).ToString());
            textBox10.Text = ((int.Parse(textBox3.Text) / (int.Parse(textBox4.Text))).ToString());
            textBox11.Text = ((int.Parse(textBox5.Text) + (int.Parse(textBox6.Text))).ToString());
            textBox12.Text = ((int.Parse(textBox7.Text) - (int.Parse(textBox8.Text))).ToString());
        }
    }
}
