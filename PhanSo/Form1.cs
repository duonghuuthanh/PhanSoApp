using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhanSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t1 = int.Parse(textBox1.Text);
            int m1 = int.Parse(textBox2.Text);
            int t2 = int.Parse(textBox3.Text);
            int m2 = int.Parse(textBox4.Text);

            PhanSo p1 = new PhanSo(t1, m1);
            PhanSo p2 = new PhanSo(t2, m2);

            if (PhanSo.soSanh(p1, p2) == true)
                MessageBox.Show("Hai phan so bang nhau");
            else
                MessageBox.Show("Hai phan so KHONG bang nhau");
        }
    }
}
