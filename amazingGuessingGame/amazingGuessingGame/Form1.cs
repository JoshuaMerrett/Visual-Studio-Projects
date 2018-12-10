using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amazingGuessingGame
{
    public partial class frmGame : Form
    {

        int guess;
        int attempts = 0;
        int wins = 0;
        int gamesPlayed = 0;

        public frmGame()
        {
            InitializeComponent();
            cbDifficulty.SelectedItem = "Easy";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            attempts = 0;

            gamesPlayed++; //Inceases the games played by 1
            txtPlayed.Text = "" + gamesPlayed; //Dispalys the number of games played in the text box
            txtWins.Text = "" + wins; //Displays the number of games won in the text box

            Random x = new Random(); //Generates a random number once x is used in a statement

            int randomNum = x.Next(1, 26); //Generates a random number between 1 and 25

            //Changes the difficulty of the game 
            if (cbDifficulty.Text == "Easy")
            {
                randomNum = x.Next(1, 26);
            }

            else if (cbDifficulty.Text == "Medium")
            {
                randomNum = x.Next(1, 51);
            }

            else if (cbDifficulty.Text == "Hard")
            {
                randomNum = x.Next(1, 101);
            }

            else if (cbDifficulty.Text == "Insanity")
            {
                randomNum = x.Next(1, 1001);
            }

            else
            {
                MessageBox.Show("Select a difficulty to continue");
                System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
                this.Close(); //to turn off current app
            }

            do
            {

                txtAttempts.Text = "" + attempts; //Displays the number of attempts+ in the text box

                if (txtAttempts.Text == "5" && cbDifficulty.Text == "Easy")
                {
                    MessageBox.Show("Run out of attempts. Try Again");
                    gamesPlayed++;
                    break;
                }

                if (txtAttempts.Text == "7" && cbDifficulty.Text == "Medium")
                {
                    MessageBox.Show("Run out of attempts. Try Again");
                    gamesPlayed++;
                    break;
                }

                if (txtAttempts.Text == "12" && cbDifficulty.Text == "Hard")
                {
                    MessageBox.Show("Run out of attempts. Try Again");
                    gamesPlayed++;
                    break;
                }

                if (txtAttempts.Text == "20" && cbDifficulty.Text == "Insanity")
                {
                    MessageBox.Show("Run out of attempts. Try Again");
                    gamesPlayed++;
                    break;
                }


                int input = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Input guess: ", "Guess input", "", 0, 0));

                guess = input;
                
                if(guess == randomNum)
                {
                    MessageBox.Show("You got it right. Well Done. The answer was: '" + randomNum + "'.");
                    wins++;
                }

                else if (guess < randomNum)
                {
                    MessageBox.Show("Your guess is too low, try again.");
                    attempts++;
                }

                else if (guess > randomNum)
                {
                    MessageBox.Show("Your guess is too high, try again.");
                    attempts++;
                }

            }

            while (guess != randomNum);
        }
    }
}
