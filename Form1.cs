using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitapsoduong
{
    public partial class Form1 : Form
    {
        double number_one, number_two;

        public double Number_two
        {
            get { return number_two; }
            set { number_two = value; }
        }

        public double Number_one
        {
            get { return number_one; }
            set { number_one = value; }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cong_Click(object sender, EventArgs e)
        {
            Number_one = Double.Parse(txtNumberOne.Text);
            Number_two = Double.Parse(txtNumberTwo.Text);

            Double resultCong = (Number_one + Number_two);
            result.Text = resultCong.ToString();
        }

        private void btn_Tru_Click(object sender, EventArgs e)
        {
            Number_one = Double.Parse(txtNumberOne.Text);
            Number_two = Double.Parse(txtNumberTwo.Text);

            Double resultTru = (Number_one - Number_two);
            result.Text = resultTru.ToString();
        }


        private void btnNhan_Click(object sender, EventArgs e)
        {
            Number_one = Double.Parse(txtNumberOne.Text);
            Number_two = Double.Parse(txtNumberTwo.Text);

            Double resultNhan = (Number_one * Number_two);
            result.Text = resultNhan.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            Number_one = Double.Parse(txtNumberOne.Text);
            Number_two = Double.Parse(txtNumberTwo.Text);
            if (Number_two == 0)
            {
                MessageBox.Show("Nhập b khác 0 ");
            }
            else {
                Double resultChia = (Number_one / Number_two);
                result.Text = resultChia.ToString();
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("THÔNG BÁO", "BẠN MUỐN ĐÓNG FORM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); 
            }
            else
            {
                
            }
        
        }
    }
}
