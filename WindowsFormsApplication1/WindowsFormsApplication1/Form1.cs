using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5anahtar = new MD5CryptoServiceProvider();
            byte[] byteblok = Encoding.UTF8.GetBytes(textBox1.Text);
            byteblok = md5anahtar.ComputeHash(byteblok);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in byteblok)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            
            textBox2.Text = sb.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}