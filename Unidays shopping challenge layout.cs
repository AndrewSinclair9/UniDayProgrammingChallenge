using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Unidayschallenge : Form
    {
        public int price = 0;
        public int amountofB = 0;
        public int i = 6;
        public int test1 = 1;
        public bool cdiscount = false;
        public Unidayschallenge()
        {
            InitializeComponent();
        }
        private void Addatobasket_Click(object sender, EventArgs e)
        {
            var countA = Convert.ToInt32(Math.Round(AmountofA.Value, 0));
            price = price + countA * 8;
            Cart.Text = Cart.Text + string.Concat(Enumerable.Repeat("A", countA)); 
        }
        private void AmountofA_ValueChanged(object sender, EventArgs e)
        {

        }
        private void AddBtobasket_Click(object sender, EventArgs e)
        {
            var countB = Convert.ToInt32(Math.Round(AmountofB.Value, 0));
            Cart.Text = Cart.Text + string.Concat(Enumerable.Repeat("B", countB));
            if (countB > test1)
            {
                countB = countB + 12;
            }
            countB = 0;
            string basket = Cart.Text;
            var count = basket.Count(x => x == 'B');
            basket = basket.Replace('B', ' ');
            amountofB = amountofB + count;
            if (amountofB % 2 == 0 && amountofB == 2)
            {
                price = price + amountofB * 10;
            }
            else if (amountofB % 2 != 0)
            {
                amountofB++;
                amountofB = amountofB / 2;
                amountofB--;
                amountofB = amountofB * 20;
                price = price + amountofB + 12;
            }
            else if (amountofB % 2 == 0 && amountofB > 2)
            {
                price = price + amountofB * 10;
            }
        }
        private void AmountofB_ValueChanged(object sender, EventArgs e)
        {

        }
        private void AddCtobasket_Click(object sender, EventArgs e)
        {
            var count = 0;
            var countC = Convert.ToInt32(Math.Round(AmountofC.Value, 0));
            Cart.Text = Cart.Text + string.Concat(Enumerable.Repeat("C", countC));
            string basket = Cart.Text;
            count = basket.Count(x => x == 'C');
            basket = basket.Replace('C', 'l');
            if (count <= 2)
            {
                price = price + count * 4;
                if (count == 2)
                {
                    price = price - 4;
                }
            }
            if(count > 2)
            {
                count--;
                price = price + count * 4 + 2;
                if(countC == 1)
                {
                    price = price - 8;
                    if (count >= 4)
                    {
                        var test = count - 3;
                        price = price + 1 * test;
                    }
                }
            }
        }
        private void AmountofC_ValueChanged(object sender, EventArgs e)
        {

        }
        private void AddDtobasket_Click(object sender, EventArgs e)
        {
            var countD = Convert.ToInt32(Math.Round(AmountofD.Value, 0));
            Cart.Text = Cart.Text + string.Concat(Enumerable.Repeat("D", countD));
            price = price + 7 * countD;
            Cart.Text = Cart.Text + string.Concat(Enumerable.Repeat("D", countD));
            
        }
        private void AmountofD_ValueChanged(object sender, EventArgs e)
        {

        }
        private void AddEtobasket_Click(object sender, EventArgs e)
        {
            var count = 0;
            var countE = Convert.ToInt32(Math.Round(AmountofE.Value, 0));
            Cart.Text = Cart.Text + string.Concat(Enumerable.Repeat("E", countE));
            
            string basket = Cart.Text;
            count = basket.Count(x => x == 'E');
            basket = basket.Replace('E', 'l');
            price = price + countE * 5;
            if (count % 3 == 0)
            {
                price = price - 5;
            }
        }

        private void AmountofE_ValueChanged(object sender, EventArgs e)
        {

        }
        private void Checkout_Click(object sender, EventArgs e)
        {

            Value.Text = "Price: £"+price;
            int Deliveryfee = 7;
            int total = price + Deliveryfee;
            if (price > 0 && price < 50)
            {

                Delivery.Text = "Delivery Fee : £" + Deliveryfee;
                Total.Text = "Total: £"+ total;
            }
            else if (price == 0)
            {
                Delivery.Text = "Delivery Fee : Free";
                Total.Text = "Total: £ 0";
            }
            else if (price >= 50)
            {
                Delivery.Text = "Delivery Fee : Free";
                total = total - 7;
                Total.Text = "Total: £" + total;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            price = 0;
            Value.Text = "Price: £" + price;
            Delivery.Text = "Delivery Fee : Free";
            Total.Text = "Total: £ 0";
            Cart.Text = "My Basket:";
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delivery_TextChanged(object sender, EventArgs e)
        {

        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
