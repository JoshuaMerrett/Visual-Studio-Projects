using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_App
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {

            List<int> numbers = new List<int>();

            TextBox[] boxes = new TextBox[] { txtNumOne, txtNumTwo, txtNumThree, txtNumFour, txtNumFive, txtNumSix, txtNumBonus };

            int randomnumber = 0;

            for (int i = 0; i < boxes.Length; i++)
            {

                randomnumber = rnd.Next(1, 60);

                bool matchFound = true;

                while (matchFound == true)
                {
                    randomnumber = rnd.Next(1, 60);
                    matchFound = false;

                    for (int x = 0; x < numbers.Count; x++)
                    {
                        if (randomnumber == numbers[x])
                        {
                            matchFound = true;
                        }
                    }
                }
                numbers.Add(randomnumber);
                boxes[i].Text = numbers[i].ToString();
            }
        }
    }
}
