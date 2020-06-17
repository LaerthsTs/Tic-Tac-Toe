using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form2 : Form
    {
        public Form2(string User)
        {
 
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public class UserName
        {
            private  string Name = "WELCOME ";

             public string userName(string nametext)
            {
                string x;
                x = Name + nametext;
                return x;
            }
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.User;
            UserName user = new UserName();
            string c= user.userName(label2.Text);
            label2.Text = c;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form4 f4 = new Form4();
                this.Hide();
                f4.Show();
            }
            else if (radioButton2.Checked)
            {
                Form5 f5 = new Form5();
                this.Hide();
                f5.Show();
            }
        }
    }
}
