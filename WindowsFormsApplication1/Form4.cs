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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        double rezultati { get; set; }
        public void btn1_Click(object sender, EventArgs e)
        {
            double rezultati = double.Parse(textBox1.Text) + double.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(rezultati);
        }

        public void btn2_Click(object sender, EventArgs e)
        {
            double rezultati = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(rezultati);
        }

        public void btn3_Click(object sender, EventArgs e)
        {
            double rezultati = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(rezultati);
        }

        public void btn4_Click(object sender, EventArgs e)
        {
            double rezultati = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(rezultati);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            textBox1.Focus();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
