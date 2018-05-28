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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        static int faktoriel(int vlera)
        {
            if (vlera == 1)
                return 1;
            else
                return vlera * faktoriel(vlera - 1);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = int.Parse(textBox1.Text);
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i + " X " + a + " = " + (i * a));
            }
            for (int i = 1; i <= a; i++)
            {
                listBox2.Items.Add(i + "!" + " = " + faktoriel(i));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Focus();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
