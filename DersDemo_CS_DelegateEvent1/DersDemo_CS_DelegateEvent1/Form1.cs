using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DersDemo_CS_DelegateEvent1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            MessageBox.Show("Sonuç : " + (a + b));

            //button1.Click -= button1_Click;
            //button1.Click += button1_Click2;
        }

        private void button1_Click2(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            MessageBox.Show("Sonuç : " + (a - b));
            //button1.Click += button1_Click;
            //button1.Click -= button1_Click2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += button1_Click2;
        }
    }
}
