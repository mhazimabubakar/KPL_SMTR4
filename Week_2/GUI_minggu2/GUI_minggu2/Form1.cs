using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_minggu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.textBox1.Text != string.Empty && this.checkBox1.Checked == true) {
                this.label1.Text = ("Welcome, " + this.textBox1.Text + " :)");
            }
            else if (this.textBox1.Text == string.Empty && this.checkBox1.Checked == true)
            {
                this.label1.Text = ("Put your name first");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Submit.Enabled = this.checkBox1.Checked;
        }
    }
}
