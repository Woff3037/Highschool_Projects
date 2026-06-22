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

namespace _1d2sınav
{
    public partial class Form1 : Form
    {
        public string Input { get; set; }
        public string selectedtxtfile { get; set; }
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void resimAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "png files (*.png*)|*.png*|All files (*.*)|*.*|jpeg files (*.jpg*)|*.jpg*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedpngfile = openFileDialog1.FileName;
                Console.WriteLine(selectedpngfile);
                FileInfo fileInfo = new FileInfo(selectedpngfile);
                long fileSize = fileInfo.Length;
                pictureBox1.Image = Image.FromFile(selectedpngfile);
                label8.Text = Image.FromFile(selectedpngfile).Size.ToString();
                label10.Text = fileSize.ToString();
                // Do something with the selected file
            }
        }

        private void metinAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedtxtfile = openFileDialog1.FileName;
                label2.Text = openFileDialog1.SafeFileName;
                richTextBox1.LoadFile(selectedtxtfile, RichTextBoxStreamType.PlainText);
                label4.Text = richTextBox1.Text.Length.ToString();
                // Do something with the selected file
            }
        }

        int secondsElapsed = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;
            label6.Text = secondsElapsed.ToString();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedtxtfile == null)
            {
                FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
                folderBrowserDialog1.ShowNewFolderButton = true;

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    Form inputForm = new Form();

                    // Add a label
                    Label label = new Label();
                    label.Text = "Dosya Adı Giriniz (örn: a.txt):";
                    label.Top = 10;
                    label.Left = 10;
                    label.Width = 150;
                    inputForm.Controls.Add(label);

                    // Add a textbox
                    TextBox textBox = new TextBox();
                    textBox.Top = 30;
                    textBox.Left = 10;
                    textBox.Width = 150;
                    inputForm.Controls.Add(textBox);

                    // Add a button
                    Button button = new Button();
                    button.Text = "OK";
                    button.Top = 60;
                    button.Left = 10;
                    button.Width = 50;
                    button.Click += (sender2, e2) =>
                    {
                        Input = textBox.Text;
                        inputForm.Close();
                    };
                    inputForm.Controls.Add(button);

                    // Show the form

                    inputForm.ShowDialog();
                    selectedtxtfile = folderBrowserDialog1.SelectedPath + "\\" + Input;
                    if (!File.Exists(selectedtxtfile))
                    {
                        using (FileStream fs = File.Create(selectedtxtfile))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(richTextBox1.Text);
                            fs.Write(info, 0, info.Length);
                            FileInfo fileInfo = new FileInfo(selectedtxtfile);
                            label2.Text = fileInfo.Name;
                            label4.Text = richTextBox1.Text.Length.ToString();
                        }
                    }
                    else
                    {
                        FileInfo fileInfo = new FileInfo(selectedtxtfile);
                        label2.Text = fileInfo.Name;
                        label4.Text = richTextBox1.Text.Length.ToString();
                    }
                }
            }
            else
            {
                using (FileStream fs = File.Create(selectedtxtfile))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(richTextBox1.Text);
                    fs.Write(info, 0, info.Length);
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowNewFolderButton = true;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Form inputForm = new Form();

                // Add a label
                Label label = new Label();
                label.Text = "Dosya Adı Giriniz (örn: a.txt):";
                label.Top = 10;
                label.Left = 10;
                label.Width = 150;
                inputForm.Controls.Add(label);

                // Add a textbox
                TextBox textBox = new TextBox();
                textBox.Top = 30;
                textBox.Left = 10;
                textBox.Width = 150;
                inputForm.Controls.Add(textBox);

                // Add a button
                Button button = new Button();
                button.Text = "OK";
                button.Top = 60;
                button.Left = 10;
                button.Width = 50;
                button.Click += (sender2, e2) =>
                {
                    Input = textBox.Text;
                    inputForm.Close();
                };
                inputForm.Controls.Add(button);

                // Show the form

                inputForm.ShowDialog();
                selectedtxtfile = folderBrowserDialog1.SelectedPath +"\\" + Input;
                if (!File.Exists(selectedtxtfile))
                {
                    using (FileStream fs = File.Create(selectedtxtfile))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(richTextBox1.Text);
                        fs.Write(info, 0, info.Length);
                        FileInfo fileInfo = new FileInfo(selectedtxtfile);
                        label2.Text = fileInfo.Name;
                        label4.Text = richTextBox1.Text.Length.ToString();
                    }
                }
                else
                {
                    FileInfo fileInfo = new FileInfo(selectedtxtfile);
                    label2.Text = fileInfo.Name;
                    label4.Text = richTextBox1.Text.Length.ToString();
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = richTextBox1.Text.Length.ToString();
        }
    }
}
