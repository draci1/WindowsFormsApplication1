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
    public partial class form1 : Form
    { 
            public form1()
        {
            InitializeComponent();
            
        }

        private void rectCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        public void UshtrimetMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void kalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listaEStudentaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void txtb1_TextChanged(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            txtb1.Text = Convert.ToString(data);
        }

        private void notaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void notaMesatareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabelaEShumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }
    }
}
