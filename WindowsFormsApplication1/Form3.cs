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
    public partial class Form3 : Form
    {
          
        public Form3()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private form1 form1 = new form1();
        public void button1_Click(object sender, EventArgs e)
        {
            
            string ID = "a"; string Pass = "a";
            if (textBox1.Text == ID && textBox2.Text == Pass)
            {
                MessageBox.Show("Jeni kyçur me sukses!");
                form1.UshtrimetMenu.Enabled = true;
                form1.UserMenu.Enabled = false;
                Close();
                form1.Show();
                
            }
            else
            {
                MessageBox.Show("Emri apo fjalëkalimi i dhënë nuk është i saktë!");
                textBox1.Focus();
            }
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shkruani Emrin/ID tuaj dhe fjalëkalimin në mënyrë identike siç jeni regjistruar, duke përfshirë dhe shkronjat e mëdha(Casp Lock)!");
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
