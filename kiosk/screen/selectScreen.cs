using kiosk.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk.screen
{
    public partial class selectScreen : UserControl
    {
        public int num=1;
        public int closenum = 0;
        public int hcvalue = 0; // 0 = hot , 1 = iced
        public int sizedvalue = 0; // 0 = regular , 1 = extra
        public int sumpriceNum = 0;
        public void selectSet(int i, int price)
        {
            showBtn();
            allBtnEnable();
            closenum = 0;
            sumpriceNum = price;
            switch (i)
            {
                case 1:
                    pictureBox1.Image = global::kiosk.Properties.Resources.espresso1;
                    break;
                case 2:
                    pictureBox1.Image = global::kiosk.Properties.Resources.americano2;
                    break;
                case 3:
                    pictureBox1.Image = global::kiosk.Properties.Resources.cafelatte3;
                    break;
                case 4:
                    pictureBox1.Image = global::kiosk.Properties.Resources.cafemoca4;
                    break;
                case 5:
                    pictureBox1.Image = global::kiosk.Properties.Resources.cafuchino5;
                    break;
                case 6:
                    pictureBox1.Image = global::kiosk.Properties.Resources.caramelmacchiatto6;
                    break;
                case 7:
                    pictureBox1.Image = global::kiosk.Properties.Resources.espressoconpanna7;
                    break;
                case 8:
                    pictureBox1.Image = global::kiosk.Properties.Resources.espressomacchiato8;
                    break;
                case 9:
                    pictureBox1.Image = global::kiosk.Properties.Resources.vanilalatte9;
                    break;
                case 10:
                    pictureBox1.Image = global::kiosk.Properties.Resources.whitechocolatemoca10;
                    break;
                case 11:
                    pictureBox1.Image = global::kiosk.Properties.Resources.coldbrewlatte11;
                    break;
                case 12:
                    pictureBox1.Image = global::kiosk.Properties.Resources.coldbrewwhitebienna12;
                    break;
            }
            this.price.Text = price.ToString();
            sumPriceNum.Text = sumpriceNum.ToString();
        }
        public void hideBtn()
        {
            decreaseBtn.Visible = false;
            increaseBtn.Visible = false;
            HotBtn.Visible = false;
            IcedBtn.Visible = false;
            regularBtn.Visible = false;
            extraBtn.Visible = false;
            menuName.Visible = false;
            sizelabel.Visible = false;
            price.Visible = false;
            pricelabel.Visible = false;
            cntlabel.Visible = false;
            pictureBox1.Visible = false;
            sumPriceLabel.Visible = false;
            sumPriceNum.Visible = false;
            pricetag.Visible = false;
            label1.Visible= false;
            label2.Visible=false;
        }
        public void showBtn()
        {
            decreaseBtn.Visible = true;
            increaseBtn.Visible = true;
            HotBtn.Visible = true;
            IcedBtn.Visible = true;
            regularBtn.Visible = true;
            extraBtn.Visible = true;
            menuName.Visible = true;
            sizelabel.Visible = true;
            price.Visible = true;
            pricelabel.Visible = true;
            cntlabel.Visible = true;
            pictureBox1.Visible = true;
            sumPriceLabel.Visible = true;
            sumPriceNum.Visible = true;
            pricetag.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }
        public void allBtnDisable()
        {
            decreaseBtn.Enabled = false;
            increaseBtn.Enabled = false;
            HotBtn.Enabled = false;
            IcedBtn.Enabled = false;
            regularBtn.Enabled = false;
            extraBtn.Enabled = false;
        }
        public void allBtnEnable() 
        { 
            decreaseBtn.Enabled = true;
            increaseBtn.Enabled = true;
            HotBtn.Enabled = true;
            IcedBtn.Enabled = true;
            regularBtn.Enabled = true;
            extraBtn.Enabled = true;
        }
        public selectScreen()
        {
            InitializeComponent();
        }

        private void decreaseBtn_Click(object sender, EventArgs e)
        {
            if (num > 1) num--;
            cntlabel.Text = num.ToString();
            sumPriceNum.Text = sumprice(num, sumpriceNum).ToString();
        }

        private void increaseBtn_Click(object sender, EventArgs e)
        {
            if (num < 20) num++;
            cntlabel.Text = num.ToString();
            sumPriceNum.Text = sumprice(num, sumpriceNum).ToString();
        }

        private void HotBtn_Click(object sender, EventArgs e)
        {
            HotBtn.Enabled = false;
            IcedBtn.Enabled = true;
            hcvalue = 0;
            sumPriceNum.Text = sumprice(num, sumpriceNum).ToString();
        }

        private void IcedBtn_Click(object sender, EventArgs e)
        {
            IcedBtn.Enabled = false;
            HotBtn.Enabled = true;
            hcvalue = 1;
            sumPriceNum.Text = sumprice(num, sumpriceNum).ToString();
        }

        private void regularBtn_Click(object sender, EventArgs e)
        {
            regularBtn.Enabled = false;
            extraBtn.Enabled = true;
            sizedvalue = 0;
            sumPriceNum.Text = sumprice(num, sumpriceNum).ToString();
        }

        private void extraBtn_Click(object sender, EventArgs e)
        {
            extraBtn.Enabled = false;
            regularBtn.Enabled = true;
            sizedvalue = 1;
            sumPriceNum.Text = sumprice(num, sumpriceNum).ToString();
        }
        private int sumprice(int n, int price)
        {
            int temp = price;
            if (hcvalue == 1) temp += 500; // 아이스 +500원
            if (sizedvalue == 1) temp += 500; // extra +500원
            return n * temp;
        }

        private void takeBtn_Click(object sender, EventArgs e)
        {
            closenum = 1;
            allBtnDisable();
        }
    }
}
