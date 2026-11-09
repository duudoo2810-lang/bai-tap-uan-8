using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form2 : Form
    {
        //properties
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        //delegate
        public delegate void kq(double tong, double tich, double thuong);

        //costructor
        public Form2(double a,double b, double c)
        {
            InitializeComponent();
            A = a;B = b;C = c;
            Tinh();
        }
        public Form2()
        {
            InitializeComponent();
        }
        public void Tinh()
        {
            double tong = A + B + C;
            double tich = A * B * C;
            if (B == 0 || C == 0)
            {
                MessageBox.Show("Khong the chia co 0");return;
            }
            double thuong = A / B / C;
            hienthi(tong, tich, thuong);
        }
        public void hienthi(double tong, double tich, double thuong)
        {
            textBox1.Text = tong.ToString();
            textBox2.Text = tich.ToString();
            textBox3.Text = thuong.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
