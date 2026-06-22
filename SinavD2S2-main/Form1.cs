namespace SinavD2S2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
            }
        }
        double carpanKatSayisi;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                if (comboBox1.SelectedIndex == 0)
                {
                    numericUpDown1.Enabled = true;
                    numericUpDown2.Enabled = true;
                    numericUpDown3.Enabled = true;
                    numericUpDown4.Enabled = false;
                    MessageBox.Show("Üçgenin Kenar Uzunluklarýný Giriniz");
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    numericUpDown1.Enabled = true;
                    numericUpDown2.Enabled = true;
                    numericUpDown3.Enabled = true;
                    numericUpDown4.Enabled = true;
                    MessageBox.Show("Karenin Kenar Uzunluklarýný Giriniz");
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    numericUpDown1.Enabled = true;
                    numericUpDown2.Enabled = false;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = false;
                    MessageBox.Show("Dairenin Yarý Çapýný Giriniz");
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                if (comboBox1.SelectedIndex == 0)
                {
                    numericUpDown1.Enabled = true;
                    numericUpDown2.Enabled = true;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = false;
                    MessageBox.Show("Üçgenin Bir Kenarýný Ve Yüksekliðini Giriniz");
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    numericUpDown1.Enabled = true;
                    numericUpDown2.Enabled = true;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = false;
                    MessageBox.Show("Dörtgenin Bir Kenarýný Ve Yüksekliðini Giriniz");
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    numericUpDown1.Enabled = true;
                    numericUpDown2.Enabled = false;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = false;
                    MessageBox.Show("Dairenin Yarý Çapýný Giriniz");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    numericUpDown1.Enabled = true;
                    numericUpDown2.Enabled = true;
                    numericUpDown3.Enabled = true;
                    numericUpDown4.Enabled = false;
                    MessageBox.Show("Üçgenin Kenar Uzunluklarýný Giriniz");
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    numericUpDown1.Enabled = true;
                    numericUpDown2.Enabled = true;
                    numericUpDown3.Enabled = true;
                    numericUpDown4.Enabled = true;
                    MessageBox.Show("Karenin Kenar Uzunluklarýný Giriniz");
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    numericUpDown1.Enabled = true;
                    numericUpDown2.Enabled = false;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = false;
                    MessageBox.Show("Dairenin Yarý Çapýný Giriniz");
                }
            }
            else if(radioButton2.Checked) 
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    numericUpDown1.Enabled = true;
                    numericUpDown2.Enabled = true;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = false;
                    MessageBox.Show("Üçgenin Bir Kenarýný Ve Yüksekliðini Giriniz");
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    numericUpDown1.Enabled = true;
                    numericUpDown2.Enabled = true;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = false;
                    MessageBox.Show("Dörtgenin Bir Kenarýný Ve Yüksekliðini Giriniz");
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    numericUpDown1.Enabled = true;
                    numericUpDown2.Enabled = false;
                    numericUpDown3.Enabled = false;
                    numericUpDown4.Enabled = false;
                    MessageBox.Show("Dairenin Yarý Çapýný Giriniz");
                }
            }
            else
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Bir Alan Tipi Seçin");
            }
            else if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Bir Bölge Seçiniz");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        label5.Text = "Uzunluk : " + (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value).ToString();
                        label7.Text = "Fiyat : " + (Convert.ToDouble(numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value) * carpanKatSayisi).ToString();
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        label5.Text = "Uzunluk : " + (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value).ToString();
                        label7.Text = "Fiyat : " + (Convert.ToDouble(numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value) * carpanKatSayisi).ToString();
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        label5.Text = "Uzunluk : " + (Convert.ToDouble(numericUpDown1.Value) * 3.14 * 2).ToString();
                        label7.Text = "Fiyat : " + (Convert.ToDouble(numericUpDown1.Value) * 3.14 * 2 * carpanKatSayisi).ToString();
                    }
                }
                if (radioButton2.Checked)
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        label5.Text = "Alan : " + ((numericUpDown1.Value * numericUpDown2.Value)/2).ToString();
                        label7.Text = "Fiyat : " + (Convert.ToDouble((numericUpDown1.Value * numericUpDown2.Value) / 2)* carpanKatSayisi).ToString();
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        label5.Text = "Alan : " + (numericUpDown1.Value * numericUpDown2.Value).ToString();
                        label7.Text = "Fiyat : " + (Convert.ToDouble(numericUpDown1.Value * numericUpDown2.Value) * carpanKatSayisi).ToString();
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        label5.Text = "Alan : " + (Math.Sqrt(Convert.ToDouble(numericUpDown1.Value)) * 3.14).ToString();
                        label7.Text = "Fiyat : " + (Math.Sqrt(Convert.ToDouble(numericUpDown1.Value)) * 3.14 * carpanKatSayisi).ToString();
                    }
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                carpanKatSayisi = 3;
            }
            else if (comboBox2.SelectedIndex == 0)
            {
                carpanKatSayisi = 2.5;
            }
            else if (comboBox2.SelectedIndex == 0)
            {
                carpanKatSayisi = 2;
            }
        }
    }
}