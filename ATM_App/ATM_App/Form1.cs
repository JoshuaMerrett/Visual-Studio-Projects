using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_App
{
    public partial class Form1 : Form
    {

        double balance = 0, amount = 0;
        int amount5Left = 0, amount10Left = 0, amount20Left =  0;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBalance.Text = "0";

            lbl5Left.Text = amount5Left.ToString() + " / " + "300";
            lbl10Left.Text = amount10Left.ToString() + " / " + "400";
            lbl20Left.Text = amount20Left.ToString() + " / " + "500";

            pbAmount5.Maximum = 300;
            pbAmount10.Maximum = 400;
            pbAmount20.Maximum = 500;
            pbAmount5.Value = amount5Left;
            pbAmount10.Value = amount10Left;
            pbAmount20.Value = amount20Left;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

            bool correctParsed = false;
            try
            {
                amount = Convert.ToInt32(txtAmount.Text);
                correctParsed = true;
            }
            catch
            {
                MessageBox.Show("Amount to be deposited could not be parsed! Only enter numbers");
            }

            if (correctParsed == true)
            {
                if ((amount % 5) == 0)
                {
                    balance = balance + amount;
                    txtBalance.Text = balance.ToString();

                    // multiples of 20
                    if (amount >= 20)
                    {
                        for (int i = 0; amount >= 20 && amount20Left <= pbAmount20.Maximum; i++)
                        {
                            amount -= 20;
                            amount20Left++;
                            pbAmount20.Value = amount20Left;
                            lbl20Left.Text = amount20Left.ToString() + " / " + "500";
                        }
                    }

                    if (amount >= 10)
                    {
                        for (int i = 0; amount >= 10 && amount10Left <= pbAmount10.Maximum; i++)
                        {
                            amount -= 10;
                            amount10Left++;
                            pbAmount10.Value = amount10Left;
                            lbl10Left.Text = amount10Left.ToString() + " / " + "400";
                        }
                    }

                    if (amount >= 5)
                    {
                        for (int i = 0; amount >= 5 && amount5Left <= pbAmount5.Maximum; i++)
                        {
                            amount -= 5;
                            amount5Left++;
                            pbAmount5.Value = amount5Left;
                            lbl5Left.Text = amount5Left.ToString() + " / " + "300";
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Please enter a multiple of 5!");
                }
            }
            else if (amount > balance)
            {
                MessageBox.Show("You do not have enough in your account to withdraw: £" + amount.ToString());
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

            bool correctParsed = false;
            try
            {
                amount = Convert.ToInt32(txtAmount.Text);
                correctParsed = true;
            }
            catch
            {
                MessageBox.Show("Amount to be deposited could not be parsed! Only enter numbers");
            }

            if (correctParsed == true)
            {
                if (amount <= balance)
                {
                    if ((amount % 5) == 0)
                    {
                        balance = balance - amount;
                        txtBalance.Text = balance.ToString();

                        // multiples of 20
                        if (amount >= 20)
                        {
                            for (int i = 0; amount >= 20; i++)
                            {
                                amount -= 20;
                                amount20Left--;
                                pbAmount20.Value = amount20Left;
                                lbl20Left.Text = amount20Left.ToString() + " / " + "500";
                            }
                        }
                        if (amount >= 10)
                        {
                            for (int i = 0; amount >= 10; i++)
                            {
                                amount -= 10;
                                amount10Left--;
                                pbAmount10.Value = amount10Left;
                                lbl10Left.Text = amount10Left.ToString() + " / " + "400";
                            }
                        }
                        if (amount >= 5)
                        {
                            for (int i = 0; amount >= 5; i++)
                            {
                                amount -= 5;
                                amount5Left--;
                                pbAmount5.Value = amount5Left;
                                lbl5Left.Text = amount5Left.ToString() + " / " + "300";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a multiple of 5!");
                    }
                }
                else if (amount > balance)
                {
                    MessageBox.Show("You do not have enough in your account to withdraw: £" + amount.ToString());
                }
            }

        }
    }
}
