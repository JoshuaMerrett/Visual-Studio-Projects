using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedLoginForm
{
    public partial class Form1 : Form
    {
        //Lists to store registered usernames and passwords
        List<string> usernamesList = new List<string>();
        List<string> passwordsList = new List<string>();

        public Form1()
        {
            InitializeComponent();
            txtLoginPassword.UseSystemPasswordChar = true;
            txtRegisterPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            int usernameIndex = 0;
            int passwordIndex = 0;
            bool usernameFound = false;
            bool passwordFound = false;

            for (int i = 0; i < usernamesList.Count; i++)
            {
                if (usernamesList[i] == txtLoginUsername.Text)
                {
                    usernameIndex = i;
                    usernameFound = true;
                }
            }

            for (int i = 0; i < passwordsList.Count; i++)
            {
                if (passwordsList[i] == txtLoginPassword.Text)
                {
                    passwordIndex = i;
                    passwordFound = true;
                }
            }

            if (usernameFound == true && passwordFound == true)
            {
                if (usernameIndex == passwordIndex)
                {
                    MessageBox.Show("Login successful");
                    Form2 form2 = new Form2();
                    this.Hide();
                    form2.Show();
                }

                else
                {
                    MessageBox.Show("Incorrect Login Details");
                }
            }

            else
            {
                MessageBox.Show("Incorrect Login Details");
            }

            txtLoginUsername.Clear();
            txtLoginPassword.Clear();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegisterUsername.Text) || string.IsNullOrWhiteSpace(txtRegisterPassword.Text))
            {
                MessageBox.Show("Complete all fields");
            }

            else
            {
                usernamesList.Add(txtRegisterUsername.Text);
                passwordsList.Add(txtRegisterPassword.Text);
                MessageBox.Show("Registration Successful");
                tcMainTabControl.SelectedTab = tpLogin;
            }
        }
    }
}
