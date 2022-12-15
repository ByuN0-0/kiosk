using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk.screen
{
    public partial class payscreen : UserControl
    {
        public int cost, m;
        public payscreen()
        {
            InitializeComponent();
        }

        public void paintinit()
        {
            label2.Text = cost.ToString() + "원";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String msg = "";
            msg += "손님이 현금 결제를 요청했습니다.\n";
            msg += "카운터에서 건네받을 금액 : ";
            msg += cost.ToString() + "원";
            MessageBox.Show(msg , "현금결제");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String msg = "";
            msg += "손님이 신용카드로 결제했습니다.\n";
            msg += "지불한 비용 : ";
            msg += cost.ToString() + "원 ";
            msg += "할부" + m.ToString() + " 개월";
            MessageBox.Show(msg, "현금결제");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String msg = "";
            msg += "손님이 체크카드로 일시불 결제했습니다.\n";
            msg += "지불한 비용 : ";
            msg += cost.ToString() + "원";
            MessageBox.Show(msg, "현금결제");
        }
    }
}
