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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.label1.Text = "file loc";
            this.label2.Text = "File name";
            this.button1.Text = "file Write";

        }

        private void button1_Click(object sender, EventArgs e)
        {
                        // StreamWriter sw = new StreamWriter(textBox1.Text+textBox2.Text);
            //sw.Write(this.textBox3.Text);
            //MessageBox.Show("File write");
            //sw.Close();
            //=*=*=*=*=File Write=*=*=*=*=
            
                string fname = textBox1.Text + textBox2.Text;
                FileStream fs = new FileStream(fname, FileMode.OpenOrCreate,FileAccess.Write);
                byte[] bb = new byte[100];
                char[] ch = new char[100];

            ch = this.textBox3.Text.ToCharArray();

            Encoder enn = Encoding.UTF8.GetEncoder();

            enn.GetBytes(ch, 0, ch.Length, bb, 0, true);
            fs.Write(bb, 0, 100);
         /*   foreach (char C in ch)
            {
                this.textBox3.Text += C;
                    
                
           }
          * */
            MessageBox.Show("File written");

           fs.Close();
           }


        }

       
    }