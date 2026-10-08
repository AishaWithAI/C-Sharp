using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_amount_Click(object sender, EventArgs e)
        {
            //Creating Variables
            string food1,food2;
            double price_food1, price_food2, amount_tips, sales_text, tips_amount, total_amount, fullpay, net_amount;

            //Constant
            const double sales_vat = 5;

            //Assign variables
            food1 = txtFood1.Text;
            food2 = txtFood2.Text;
            price_food1 = double.Parse(txtPriceFood1.Text);
            price_food2 = double.Parse(txtPriceFood2.Text);
            amount_tips = double.Parse(txtAmountTips.Text);

            //Calculating
            try
            {
                total_amount = price_food1 + price_food2;
                sales_text = total_amount * (sales_vat / 100);
                tips_amount = total_amount * (amount_tips / 100);
                fullpay = tips_amount + sales_text + total_amount;
                net_amount = total_amount + tips_amount;

                //display the output

                lblSalesText.Text = sales_text.ToString("c");
                lblTipsAmount.Text = tips_amount.ToString("c");
                lblTotalAmount.Text = total_amount.ToString("c");
                lblFullPay.Text = fullpay.ToString("c");
                lblNetAmount.Text = net_amount.ToString("c");
            }

            catch { }


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtFood1.Clear();
            txtFood2.Clear();
            txtPriceFood1.Clear();
            txtPriceFood2.Clear();
            txtAmountTips.Clear();
            lblSalesText.Text = string.Empty;
            lblTipsAmount.Text = string.Empty;
            lblTotalAmount.Text = string.Empty;
            lblFullPay.Text = string.Empty;
            lblNetAmount.Text = string.Empty;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
