using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Int64 say1 = 0;
        Int64 say2 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox1.Text, out value))
            {
                say1 = Convert.ToInt64(textBox1.Text);
            }
            else
            {
                MessageBox.Show("You Should Enter An Intger Value To The 1st Box");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int64 syı = 0;
            for (Int64 i = say1; i < say2+1; i++)
            {
                syı = syı + i;
            }
            label3.Text = Convert.ToString(syı);
            listBox1.Items.Add((say1 + "ve" + say2 + "arasının toplamı =" + label3.Text));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox2.Text, out value))
            {
                say2 = Convert.ToInt64(textBox2.Text);
            }
            else
            {
                MessageBox.Show("You Should Enter An Intger Value To The 2nd Box");
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "2. Sayı")
            {
                textBox2.Text = "0";
            }
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "1. Sayı")
            {
                textBox1.Text = "0";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox2.Text == "0")
            {
                MessageBox.Show("You Can't Use 0 At Dividing");
            }
            else
            {
                label3.Text = Convert.ToString(say1/say2);
                listBox1.Items.Add((say1+"÷"+say2+"="+label3.Text));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(say1 * say2);
            listBox1.Items.Add((say1 + "X" + say2 + "=" + label3.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(say1 + say2);
            listBox1.Items.Add((say1 + "+" + say2 + "=" + label3.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(say1 - say2);
            listBox1.Items.Add((say1 + "-" + say2 + "=" + label3.Text));
            if (Convert.ToInt64(label3.Text) < 0)
            {
                MessageBox.Show("Sayınız Negatiftir");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var syı = say1;
            for (int i = 0; i < say2-1; i++)
            {
                syı = syı * say1;
            }
            label3.Text = Convert.ToString(syı);
            listBox1.Items.Add((say1 + "^" + say2 + "=" + label3.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                MessageBox.Show("You Can't Use 0 At Dividing");
            }
            else
            {
                label3.Text = Convert.ToString(Math.Sqrt(say1));
                listBox1.Items.Add(("√" + say1 + "=" + label3.Text));
            }
        }
    }
}
