using System;
using System.CodeDom.Compiler;
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
    public partial class mainScreen : UserControl
    {
        int SumPrice = 0;
        selectScreen sscreen = new selectScreen();
        payscreen pscreen = new payscreen();
        public mainScreen()
        {
            InitializeComponent();
            cancelBtn.Visible = false;
            SumPrice = 0;
            button9.Visible= false;
        }
        private void AllBtnHide()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            product1.Visible = false;
            product2.Visible = false;
            product3.Visible = false;
            product4.Visible = false;
            product5.Visible = false;
            product6.Visible = false;
            product7.Visible = false;
            product8.Visible = false;
            product9.Visible = false;
            product10.Visible = false;
            product11.Visible = false;
            product12.Visible = false;
            cancelBtn.Visible = true;
            payBtn.Visible = false;
            button9.Visible = true;
            allCancelBtn.Visible = false;
        }
        private void AllBtnShow()
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            product1.Visible = true;
            product2.Visible = true;
            product3.Visible = true;
            product4.Visible = true;
            product5.Visible = true;
            product6.Visible = true;
            product7.Visible = true;
            product8.Visible = true;
            product9.Visible = true;
            product10.Visible = true;
            product11.Visible = true;
            product12.Visible = true;
            cancelBtn.Visible = false;
            payBtn.Visible = true;
            button9.Visible = false;
            allCancelBtn.Visible = true;
        }
        private void product1_Click(object sender, EventArgs e)
        {
            int price = 2900;
            AllBtnHide();
            sscreen.selectSet(1,price);
            selectpanel.Controls.Add(sscreen);
        }

        private void product2_Click(object sender, EventArgs e)
        {
            int price = 3200;
            AllBtnHide();
            sscreen.selectSet(2,price);
            selectpanel.Controls.Add(sscreen);
        }

        private void product3_Click(object sender, EventArgs e)
        {
            int price = 3700;
            AllBtnHide();
            sscreen.selectSet(3, price);
            selectpanel.Controls.Add(sscreen);
        }

        private void product4_Click(object sender, EventArgs e)
        {
            int price = 3500;
            AllBtnHide();
            sscreen.selectSet(4, price);
            selectpanel.Controls.Add(sscreen);
        }

        private void product5_Click(object sender, EventArgs e)
        {
            int price = 3700;
            AllBtnHide();
            sscreen.selectSet(5, price);
            selectpanel.Controls.Add(sscreen);
        }

        private void product6_Click(object sender, EventArgs e)
        {
            int price = 3900;
            AllBtnHide();
            sscreen.selectSet(6, price);
            selectpanel.Controls.Add(sscreen);
        }

        private void product7_Click(object sender, EventArgs e)
        {
            int price = 3200;
            AllBtnHide();
            sscreen.selectSet(7, price);
            selectpanel.Controls.Add(sscreen);
        }

        private void product8_Click(object sender, EventArgs e)
        {
            int price = 3200;
            AllBtnHide();
            sscreen.selectSet(8, price);
            selectpanel.Controls.Add(sscreen);
        }

        private void product9_Click(object sender, EventArgs e)
        {
            int price = 3900;
            AllBtnHide();
            sscreen.selectSet(9, price);
            selectpanel.Controls.Add(sscreen);
        }

        private void product10_Click(object sender, EventArgs e)
        {
            int price = 3900;
            AllBtnHide();
            sscreen.selectSet(10, price);
            selectpanel.Controls.Add(sscreen);
        }

        private void product11_Click(object sender, EventArgs e)
        {
            int price = 4200;
            AllBtnHide();
            sscreen.selectSet(11, price);
            selectpanel.Controls.Add(sscreen);
        }

        private void product12_Click(object sender, EventArgs e)
        {
            int price = 4500;
            AllBtnHide();
            sscreen.selectSet(12, price);
            selectpanel.Controls.Add(sscreen);
        }

        private void button9_Click(object sender, EventArgs e)
        {
        
            int temp = sscreen.sumpriceNum;
            if (sscreen.hcvalue == 1) temp += 500; // 아이스 +500원
            if (sscreen.sizedvalue == 1) temp += 500; // extra +500원
            SumPrice += sscreen.num * temp;
            sscreen.num = 1;
            sscreen.hideBtn();
            AllBtnShow();
            sumpricelabel.Text = SumPrice.ToString();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            sscreen.num = 1;
            sscreen.hideBtn();
            AllBtnShow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            AllBtnHide();
            cancelBtn.Visible = false;
            button9.Visible = false;
            label1.Visible = false;
            wonlabel.Visible = false;
            sumpricelabel.Visible = false;
            selectpanel.Controls.Clear();
            selectpanel.Controls.Add(pscreen);
            pscreen.cost = SumPrice;
        }

        private void selectpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void allCancelBtn_Click(object sender, EventArgs e)
        {
            SumPrice = 0;
            sumpricelabel.Text = SumPrice.ToString();
        }
    }
}
