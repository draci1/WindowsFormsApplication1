using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
            textBox6.Focus();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        //public static Bitmap ByteToImage(byte[] blob)
        //{
        //    MemoryStream mStream = new MemoryStream();
        //    byte[] pData = blob;
        //    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
        //    Bitmap bm = new Bitmap(mStream, false);
        //    mStream.Dispose();
        //    return bm;
            
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            string[] emri = new string[] { "Florian Ibrahimi", "Hydajet Qerimi", "Granit Mustafa", "Ilmi Hajdini", "Rinor Selimi", "Valentina Hajdari", "Erzana Rushiti", "Nesa Shahini", "Dritëlinda Hajdari", "Arlinda Islami", "Erza Demi", "Uran Gashi", "Nita Kërqeli", "Rinor Sylejmani", "Besart Mustafa" };
            string[] gjinia = new string[] { "Mashkull", "Mashkull", "Mashkull", "Mashkull", "Mashkull", "Femer", "Femer", "Femer", "Femer", "Femer", "Femer", "Mashkull", "Femer", "Mashkull", "Mashkull" };
            int[] mosha = new int[] { 18, 18, 18, 20, 18, 18, 18, 18, 18, 18, 18, 18, 18, 19, 18 };
            string[] vendi = new string[] { "Përlepnicë", "Gjilan", "Gjilan", "Gjilan", "Gjilan", "Gjilan", "Gjilan", "Gjilan", "Gjilan", "Gjilan", "Gjilan", "Gjilan", "Gjilan", "Gjilan", "Gjilan" };
            string[] verejtje = new string[] { "tekstsi 1 per studentin", "Tjeter tekst per studentin 2", "A bon pauz?", "10-qe interface ;)", "Vërejteje? Qka osht ajo?", "I'm a queen", "Edhe sa bjen zilja?", "Ska vrejtje per mu!", "Matematikën e di ma mir se Xheva ;)", "Qysh po m'hahet 1 milka", "Jam gati per provim", "N'grupin 4 jom amo qeshtu vi najher", "A u kry bre ora?", "Edhe sa kryhet ora bre?", "Veq kur um shef n'vit dyt, jau boj me dor ;)" };
            string[] foto=new string[] { "764.jpg", "765.jpg", "766.jpg", "767.jpg","765.jpg", "767.jpg", "768.jpg", "769.jpg", "770.jpg", "771.jpg",  "772.jpg", "773.jpg", "774.jpg", "775.jpg", "776.jpg"};
            int[] opsionale = new int[] { 1, 1, 1, 2, 2, 2, 1, 2, 1, 2, 2, 1, 2, 2, 1 };
            string name="",gender="",place="",warning=""; int age = 0; string image = ""; int optional=0;
            int j = 0;
            for (int i = 0; i < 15; i++)
            {
                
                    if (textBox6.Text == emri[i])
                    {
                        name = emri[i];
                        gender = gjinia[i];
                        age = mosha[i];
                        place = vendi[i];
                        warning = verejtje[i];
                        image = foto[i];
                        optional = opsionale[i];
                        j++;
                    }
                
                 
            }
            if (j == 1)
            {
                textBox1.Text = name;
                textBox2.Text = gender;
                textBox3.Text = Convert.ToString(age);
                textBox4.Text = place;
                richTextBox1.Text = warning;
                if (optional == 1) { radioButton1.Checked = true; }
                else radioButton2.Checked = true;
                foreach (var control in groupBox1.Controls)
                {
                    if(control is CheckBox)
                    {
                        ((CheckBox)control).Checked = true;
                    }
                }
                    pictureBox1.Image = Image.FromFile(@"C:\" + image);

            }
            else
            { MessageBox.Show("Personi i kërkuar nuk është gjetur!"); }
            textBox6.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            textBox6.Text = richTextBox1.Text = textBox4.Text = textBox3.Text = textBox2.Text = textBox1.Text = "";
            foreach (var control in groupBox1.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
            if (radioButton1.Checked == true) radioButton1.Checked = false;
            else radioButton2.Checked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(30, 93, 148);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
            button2.BackColor = Color.FromArgb(30, 93, 148);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(30, 93, 148);
            button1.BackColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(30, 93, 148);
            button2.BackColor = Color.White;
        }
    }
}
