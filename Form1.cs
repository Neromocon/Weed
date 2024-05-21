using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part7_WindowsControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEvent_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("버튼을 클릭하였습니다.");
            string strOrder = "";
            if(ckbSoon.Checked) 
            {
                strOrder += ckbSoon.Text + "\n";
            }
            if (ckbPasta.Checked)
            {
                strOrder += ckbPasta.Text + "\n";
            }
            if (ckbSteak.Checked)
            {
                strOrder += ckbSteak.Text + "\n";
            }
            if (ckbTang.Checked)
            {
                strOrder += ckbTang.Text + "\n";
            }
            lblOrder.Text = strOrder + "메뉴를 요청하였습니다.";

            if (radioAgree.Checked) 
            {
                MessageBox.Show("개인정보 수집에 동의 하셨습니다.");
            }
            else
            {
                MessageBox.Show("개인정보 수집에 동의하지 않으셨습니다.");
            }
        }

        private void BtnReceipt_click(object sender, EventArgs e)
        {
            string strText = textBox1.Text + "\n라고 요구 사항이 접수되었습니다.";
            MessageBox.Show(strText);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbArea.Items.Clear();
            if(cbPay.SelectedIndex == 0)
            {
                lbArea.Items.Add("일시불");
                lbArea.Items.Add("3개월 할부");
                lbArea.Items.Add("6개월 할부");
            }
            else if (cbPay.SelectedIndex == 1)
            {
                lbArea.Items.Add("하루은행");
                lbArea.Items.Add("신용은행");
                lbArea.Items.Add("국물은행");
            }
            else if (cbPay.SelectedIndex == 2)
            {
                lbArea.Items.Add("N포인트");
                lbArea.Items.Add("주유포인트");
                lbArea.Items.Add("레이저포인트");
            }

        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            string strText = cbPay.Text + "(으)로" + lbArea.Text + "결제방법을" + "\n선택하셨습니다.";
            MessageBox.Show(strText);
        }

        
    }
}
