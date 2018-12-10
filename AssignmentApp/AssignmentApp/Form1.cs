using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentApp
{
    public partial class Form1 : Form
    {
        double total = 0;
        List<Game> games = new List<Game>();
        List<Game> checkout = new List<Game>();

        public Form1()
        {
            InitializeComponent();

            Game game1 = new Game();
            game1.name = "Assassin's Creed Odyssey";
            game1.developer = "Ubisoft";
            game1.releaseDate = "05/10/2018";
            game1.description = "Assassin's Creed Odyssey places more emphasis on role-playing elements than previous games in the series. The game contains dialogue options, branching quests, and multiple endings.";
            game1.price = 49.99;
            game1.quantity = 1;
            games.Add(game1);

            Game game2 = new Game();
            game2.name = "Call Of Duty: Black Ops 4";
            game2.developer = "Treyarch";
            game2.releaseDate = "12/10/2018";
            game2.description = "Call of Duty: Black Ops 4 is a multiplayer first-person shooter video game. Unlike previous titles in the Call of Duty series, Black Ops 4 is the first entry to not feature a traditional single-player campaign, and contains only Multiplayer, Zombies and a new battle royale mode called Blackout.";
            game2.price = 49.99;
            game2.quantity = 1;
            games.Add(game2);

            Game game3 = new Game();
            game3.name = "Dark Souls Remastered";
            game3.developer = "From Software";
            game3.releaseDate = "23/05/2018";
            game3.description = "Dark Souls takes place in the fictional kingdom of Lordran, where players assume the role of a cursed undead character who begins a pilgrimage to discover the fate of their kind.";
            game3.price = 29.99;
            game3.quantity = 1;
            games.Add(game3);

            Game game4 = new Game();
            game4.name = "Red Dead Redemption 2";
            game4.developer = "Rockstar";
            game4.releaseDate = "26/10/2018";
            game4.description = "Red Dead Redemption 2 is a Western-themed action-adventure game set in an open world environment. It is played from either a third or first-person perspective and the player controls Arthur Morgan, an outlaw and a member of the Van der Linde gang.";
            game4.price = 49.99;
            game4.quantity = 1;
            games.Add(game4);

            DisplayGames();
        }

        private void lstItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstItem.SelectedIndex > -1)
            {
                int i = lstItem.SelectedIndex;

                txtName.Text = games[i].name;
                txtDeveloper.Text = games[i].developer;
                txtRelease.Text = games[i].releaseDate;
                txtDescription.Text = games[i].description;
                txtPrice.Text = games[i].price.ToString();
                numericUpDown.Value = games[i].quantity;
            }
        }

        private void DisplayGames()
        {
            for (int i = 0; i < games.Count; i++)
            {
                lstItem.Items.Add(games[i].name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Game newGame = new Game();
            newGame.name = txtName.Text;
            newGame.developer = null;
            newGame.releaseDate = null;
            newGame.description = null;
            newGame.price = Convert.ToDouble(txtPrice.Text);
            newGame.quantity = Convert.ToInt32(numericUpDown.Value);

            checkout.Add(newGame);

            for(int i = 0; i < checkout.Count; i++)
            {
                for (int n = 0; n < checkout.Count; n++)
                {
                    if (checkout[i].name == checkout[n].name && i != n)
                    {
                        checkout.RemoveAt(n);
                        checkout[i].quantity = checkout[i].quantity + newGame.quantity;
                    }
                }
            }

            DisplayBasket();

            double gamePrice = newGame.price * newGame.quantity;
            total = total + gamePrice;

            txtTotal.Text = Convert.ToString(total);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order placed: " + "£" + total);

            txtName.Clear();
            txtDeveloper.Clear();
            txtRelease.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtTotal.Clear();

            lstBasket.Items.Clear();
        }
        private void DisplayBasket()
        {
            lstBasket.Items.Clear();

            for (int i = 0; i < checkout.Count; i++)
            {
                lstBasket.Items.Add(checkout[i].name + " [" + checkout[i].quantity.ToString() + "]");
            }
        }
    }
    public class Game
    {
        public string name;
        public string developer;
        public string releaseDate;
        public string description;
        public double price;
        public int quantity;
    }
}
