using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) > 49 && int.Parse(textBox1.Text) <= 59)
            {
                textBox2.Text = "Gjashtë (6)";
            }
            else if (int.Parse(textBox1.Text) > 59 && int.Parse(textBox1.Text) <= 69)
            {
                textBox2.Text = "Shtatë (7)";
            }
            else if (int.Parse(textBox1.Text) > 69 && int.Parse(textBox1.Text) <= 79)
            {
                textBox2.Text = "Tetë (8)";
            }
            else if (int.Parse(textBox1.Text) > 79 && int.Parse(textBox1.Text) <= 89)
            {
                textBox2.Text = "Nëntë (9)";
            }
            else if (int.Parse(textBox1.Text) > 89 && int.Parse(textBox1.Text) <= 100)
            {
                textBox2.Text = "Dhjetë (10)";
            }
            else
            {
                textBox2.Text = "Pesë (5)";
            }
            textBox1.Focus();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
