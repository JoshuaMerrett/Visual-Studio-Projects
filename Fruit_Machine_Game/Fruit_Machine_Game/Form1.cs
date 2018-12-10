using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit_Machine_Game
{
    public partial class Form1 : Form
    {

        int y;
        int x;
        int z;
        int tokens = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSpin_Click(object sender, EventArgs e)
        {
            if (btnSpin.Text == "Spin")
            {
                timer1.Start();
                btnSpin.Text = "Stop";
            }

            else if (btnSpin.Text == "Stop")
            {
                timer1.Stop();
                btnSpin.Text = "Spin";

                if (y == x && y == z)
                { 

                    if (y == 0)
                    {
                        tokens = tokens + 3;
                        txtToken.Text = "" + tokens;
                        MessageBox.Show("CONGRATULATIONS - Big Win, 3 Tokens Won");
                    }

                    else if (y == 1)
                    {
                        tokens = tokens + 5;
                        txtToken.Text = "" + tokens;
                        MessageBox.Show("CONGRATULATIONS - Big Win, 5 Tokens Won");
                    }

                    else if (y == 2)
                    {
                        tokens = tokens + 7;
                        txtToken.Text = "" + tokens;
                        MessageBox.Show("CONGRATULATIONS - Big Win, 7 Tokens Won");
                    }

                    else if (y == 3)
                    {
                        tokens = tokens + 10;
                        txtToken.Text = "" + tokens;
                        MessageBox.Show("CONGRATULATIONS - Big Win, 10 Tokens Won");
                    }

                    else if (y == 4)
                    {
                        tokens = tokens + 15;
                        txtToken.Text = "" + tokens;
                        MessageBox.Show("CONGRATULATIONS - Big Win, 15 Tokens Won");
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            y = rnd.Next(0, 5);
            x = rnd.Next(0, 5);
            z = rnd.Next(0, 5);

            pb1.Image = picturesList.Images[y];
            pb2.Image = picturesList.Images[x];
            pb3.Image = picturesList.Images[z];
        }
    }
}
