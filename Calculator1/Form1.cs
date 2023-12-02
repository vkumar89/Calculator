using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        
        double number;
        String Symbol = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            if (richTextBox1.Text.Contains("-"))
            {
                //richTextBox1.Text.

                //number = Convert.ToDouble(richTextBox1.Text);
            }

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text=="0")
            {
                richTextBox1.Text = "";
            }
             richTextBox1.Text = richTextBox1.Text + "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text = richTextBox1.Text + "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text = richTextBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text = richTextBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text = richTextBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text = richTextBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text = richTextBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text = richTextBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text = richTextBox1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "0";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = richTextBox1.Text + "-";
        }

        private void btnDevid_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "/";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "x";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "+ ";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }
    }
}
