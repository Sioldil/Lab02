using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_T7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, Ketqua;
                a = float.Parse(TxtA.Text);
                b = float.Parse(TxtB.Text);

                Ketqua = a + b;
                TxtKetqua.Text = Ketqua.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool checkNum(string text)
        {
            bool temp = float.TryParse(text, out float KQ);
            if (!temp)
                return false;
            return true;
        }

        private void TxtA_TextChanged(object sender, EventArgs e)
        {
            if (!checkNum(TxtA.Text))
            {
                MessageBox.Show("Bạn vui lòng nhập đúng định dạng!", "Cảnh báo",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            } 
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, Ketqua;
                a = float.Parse(TxtA.Text);
                b = float.Parse(TxtB.Text);

                Ketqua = a - b;
                TxtKetqua.Text = Ketqua.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, Ketqua;
                a = float.Parse(TxtA.Text);
                b = float.Parse(TxtB.Text);

                Ketqua = a * b;
                TxtKetqua.Text = Ketqua.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnChia_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, Ketqua;
                a = float.Parse(TxtA.Text);
                b = float.Parse(TxtB.Text);

                Ketqua = a / b;
                TxtKetqua.Text = Ketqua.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void TxtB_TextChanged(object sender, EventArgs e)
        {
            if (!checkNum(TxtB.Text))
            {
                MessageBox.Show("Bạn vui lòng nhập đúng định dạng!", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void TxtKetqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
