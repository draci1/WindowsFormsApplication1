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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            MessageBox.Show("Nëse keni më pak se 10 lëndë , vendos '0' në lëndët përkatëse!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = "";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int pjestues = 10;
            float shuma = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text) + int.Parse(textBox6.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text) + int.Parse(textBox10.Text);
            if (textBox1.Text == Convert.ToString(0))
            {
                pjestues--;
            }
            if (textBox2.Text == Convert.ToString(0))
            {
                pjestues--;
            }
            if (textBox3.Text == Convert.ToString(0))
            {
                pjestues--;
            }
            if (textBox4.Text == Convert.ToString(0))
            {
                pjestues--;
            }
            if (textBox5.Text == Convert.ToString(0))
            {
                pjestues--;
            }
            if (textBox6.Text == Convert.ToString(0))
            {
                pjestues--;
            }
            if (textBox7.Text == Convert.ToString(0))
            {
                pjestues--;
            }
            if (textBox8.Text == Convert.ToString(0))
            {
                pjestues--;
            }
            if (textBox9.Text == Convert.ToString(0))
            {
                pjestues--;
            }
            if (textBox10.Text == Convert.ToString(0))
            {
                pjestues--;
            }
            //for (int i = 1; i < 11; i++)
            //    if (int.Parse(textBox(i).Text) == 0)
            //    {
            //        pjestues--;
            //    }
            float mesatare = shuma / pjestues;
            
            textBox11.Text = Convert.ToString(mesatare);
        }
        
        }
}
//string[] txtB = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text };
