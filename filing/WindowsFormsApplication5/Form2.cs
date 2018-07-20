using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = "file loc";
            this.label2.Text = "file name";
            this.button1.Text = "file Read";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(this.textBox1.Text + this.textBox2.Text);
            //this.textBox3.Text = sr.ReadToEnd();
            //sr.Close();
            //File read
            string fname = textBox1.Text + textBox2.Text;


            FileStream sr = new FileStream(fname, FileMode.Open, FileAccess.Read);
            byte[] bb = new byte[1000];
            char[] ch = new char[1000];
            sr.Read(bb, 0, 100);
            Decoder de = Encoding.UTF8.GetDecoder();
            de.GetChars(bb, 0, bb.Length, ch, 0);
            foreach (char C in ch)
            {
                this.textBox3.Text += C;
            }

            sr.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] bb = new byte[100];
            char[] ch = new char[100];
            FileStream fs = new FileStream(@"d:\ramesh.txt",FileMode.OpenOrCreate);
            fs.Read(bb,0,100); 
            Decoder d=Encoding.UTF8.GetDecoder(); 
            d.GetChars(bb,0,bb.Length,ch,0); 
        }


        
    }
}
