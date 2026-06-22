using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            listBox3.SelectedIndex = listBox1.SelectedIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string urlDoviz = "https://www.tcmb.gov.tr/kurlar/202212/27122022.xml";
            WebClient wcDoviz= new WebClient();
            wcDoviz.Encoding= Encoding.UTF8;
            string htmlDoviz = wcDoviz.DownloadString(urlDoviz);
            MatchCollection mcKurlar = Regex.Matches(htmlDoviz, "<Currency.*?</Currency>", RegexOptions.Multiline | RegexOptions.Singleline);
            foreach (Match mKur in mcKurlar) 
            {
                Match mKurIsim = Regex.Match(mKur.Value, "<Isim>.*?</Isim>");
                string KurIsim = mKurIsim.Value.Replace("Isim", "").Replace("</Isim>", "");
                listBox1.Items.Add(KurIsim);
                comboBox1.Items.Add(KurIsim);
                Match mKurAlis = Regex.Match(mKur.Value, "<ForexSelling>.*?</ForexSelling>");
                string KurAlis = mKurAlis.Value.Replace("ForexSelling", "").Replace("</ForexSelling>", "");
                listBox2.Items.Add(KurAlis);
                Match mKurSatis = Regex.Match(mKur.Value, "<ForexBuying>.*?</ForexBuying>");
                string KurSatis = mKurSatis.Value.Replace("ForexBuying", "").Replace("</ForexBuying>", "");
                listBox3.Items.Add(KurSatis);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seciliKurIndexi = comboBox1.SelectedIndex;
            listBox1.SelectedIndex= seciliKurIndexi;
            listBox2.SelectedIndex= seciliKurIndexi;
            listBox3.SelectedIndex= seciliKurIndexi;
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex;
            listBox3.SelectedIndex = listBox2.SelectedIndex;
        }

        private void listBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox3.SelectedIndex;
            listBox2.SelectedIndex = listBox3.SelectedIndex;
        }
    }
}
