using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
namespace wage_calculator
{
    class Program
    {

        static double gross;
        static double net;
        static string title;
        static string first_name;
        static string surname;
        static string ni_number;
        static double hoursworked;
        static double difference;
        static double wage;
        static double overtime;
        static double overtimeone;
        static double overtimetwo;
        static double ni_pay;
        static double tax;

        static private MySqlConnection connection; //global variables
        static private string server;
        static private string database;
        static private string uid;
        static private string password;

        static void Initialise()
        {
            server = "localhost"; //local host (WAMP)
            database = "wage_slip"; //database name
            uid = "root"; //database username
            password = ""; //database password

            try
            {
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
            }
            catch
            {
                Console.WriteLine("Not connecting");
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {//Start main Method
            string user_input;

            //Header of console
            Console.Write("[---------[");
            Console.ForegroundColor = ConsoleColor.Green; //Changes colour of the text to green
            Console.Write("Login");
            Console.ResetColor(); //Resets the colour of the text to grey
            Console.Write("]---------] \n");
            //End of console header

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Are you: \n\n User 1 \n User 2 \n User 3 \n");
            Console.ResetColor();
            user_input = Console.ReadLine();

            if (user_input.Equals("User 1"))
            {
                user1();
            }

            else if (user_input.Equals("User 2"))
            {
                user2();
            }

            else if (user_input.Equals("User 3"))
            {
                user3();
            }

            else
            {
                Console.WriteLine("Enter a vaild user");
            }

            Console.ReadLine();

        }//End main Method

        static void user1()
        {//Start User 1 Method

            string user_name;
            string user_password;

            Console.Clear();

            //Header of console
            Console.Write("[---------[");
            Console.ForegroundColor = ConsoleColor.Green; //Changes colour of the text to green
            Console.Write("Login");
            Console.ResetColor(); //Resets the colour of the text to grey
            Console.Write("]---------] \n");
            //End of console header

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Enter your username: \n");
            Console.ResetColor();
            user_name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Enter your password: \n");
            Console.ResetColor();
            user_password = Console.ReadLine();

            if (user_name.Equals("Joshua") && user_password.Equals("password123"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" \n --- Access Granted ---");
                Console.ResetColor();
                Thread.Sleep(3000);
                home();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" \n --- Access Denied ---");
                Console.ResetColor();
                Thread.Sleep(3000);
                user1();
            }

            Console.ReadLine();
        }//End User 1 Method

        static void user2()
        {//Start User 2 Method
            string user_name;
            string user_password;

            Console.Clear();

            //Header of console
            Console.Write("[---------[");
            Console.ForegroundColor = ConsoleColor.Green; //Changes colour of the text to green
            Console.Write("Login");
            Console.ResetColor(); //Resets the colour of the text to grey
            Console.Write("]---------] \n");
            //End of console header

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Enter your username: \n");
            Console.ResetColor();
            user_name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Enter your password \n");
            Console.ResetColor();
            user_password = Console.ReadLine();

            if (user_name.Equals("Britney") && user_password.Equals("Pass123"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" \n --- Access Granted ---");
                Console.ResetColor();
                Thread.Sleep(3000);
                home();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" \n --- Access Denied ---");
                Console.ResetColor();
                Thread.Sleep(3000);
                user2();
            }

            Console.ReadLine();
        }//End User 2 Method

        static void user3()
        {//Start User 3 Method

            string user_name;
            string user_password;

            Console.Clear();

            //Header of console
            Console.Write("[---------[");
            Console.ForegroundColor = ConsoleColor.Green; //Changes colour of the text to green
            Console.Write("Login");
            Console.ResetColor(); //Resets the colour of the text to grey
            Console.Write("]---------] \n");
            //End of console header

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Enter your username: \n");
            Console.ResetColor();
            user_name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Enter your password \n");
            Console.ResetColor();
            user_password = Console.ReadLine();

            if (user_name.Equals("Harry") && user_password.Equals("Bone7"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" \n --- Access Granted ---");
                Console.ResetColor();
                Thread.Sleep(3000);
                home();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" \n --- Access Denied ---");
                Console.ResetColor();
                Thread.Sleep(3000);
                user3();
            }

            Console.ReadLine();

        }//End User 3 Method

        static void home()
        {//Start of home Method

            bool loopCounter = true;
            while (loopCounter == true)
            {//Start of loop

                Console.Clear();

                Console.Write("[---------[");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Home");
                Console.ResetColor();
                Console.Write("]---------] \n");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Choose an option: \n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("<A> Create a Wage Slip");
                Console.WriteLine("<B> View a Wage Slip");
                Console.WriteLine("<C> Update a Wage Slip");
                Console.WriteLine("<D> Delete a Wage Slip");
                Console.WriteLine("<H> Help");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("<X> Exit");
                Console.ResetColor();

                ConsoleKeyInfo myKey = Console.ReadKey(); //Reads the key pressed by the user

                if (myKey.Key == ConsoleKey.A)
                {
                    createWageSlip();
                }

                else if (myKey.Key == ConsoleKey.B)
                {
                    viewWageSlip();
                }

                else if (myKey.Key == ConsoleKey.C)
                {
                    updateWageSlip();
                }

                else if (myKey.Key == ConsoleKey.D)
                {
                    deleteWageSlip();
                }

                else if (myKey.Key == ConsoleKey.H)
                {
                    help();
                }

                else if (myKey.Key == ConsoleKey.X)
                {
                    loopCounter = false; //exit loop
                    Environment.Exit(0);
                }
            }//End of loop
        }//End of home Method

        static void createWageSlip()
        {//Start of create Wage Slip Method

            Initialise();

            Console.Clear();

            Console.Write("[---------[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Create a Wage Slip");
            Console.ResetColor();
            Console.Write("]---------] \n");

            Regex regex = new Regex(@"^[a-zA-Z -]*$");
            Regex regex2 = new Regex(@"^[a-zA-Z0-9 ]*$");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter Title: \n");
                Console.ResetColor();
                title = Console.ReadLine();

                if (string.IsNullOrEmpty(title))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only letter and hyphens");
                    Console.ResetColor();
                }
                else if (regex.IsMatch(title))
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only letter and hyphens");
                    Console.ResetColor();
                }
            }

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter First Name: \n");
                Console.ResetColor();
                first_name = Console.ReadLine();

                if (string.IsNullOrEmpty(first_name)) //The regex rule accepts null values
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only letter and hyphens");
                    Console.ResetColor();
                }

                else if (regex.IsMatch(first_name))
                {
                    break;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only letter and hyphens");
                    Console.ResetColor();
                }
            }

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter Surname: \n");
                Console.ResetColor();
                surname = Console.ReadLine();

                if (string.IsNullOrEmpty(surname))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only letter and hyphens");
                    Console.ResetColor();
                }

                else if (regex.IsMatch(surname))
                {
                    break;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only letter and hyphens");
                    Console.ResetColor();
                }
            }

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter National Insurance Number: \n");
                Console.ResetColor();
                ni_number = Console.ReadLine();

                if (string.IsNullOrEmpty(ni_number))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only letter and numbers");
                    Console.ResetColor();
                }

                else if (regex2.IsMatch(ni_number))
                {
                    break;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only letter and numbers");
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("What is your job role? \n");
            Console.WriteLine("<A> Programmer");
            Console.WriteLine("<B> Administrators/Clerks");
            Console.WriteLine("<C> Project Leader/Manager");
            Console.WriteLine("<D> Other");
            ConsoleKeyInfo myKey = Console.ReadKey();
            Console.ResetColor();

            if (myKey.Key == ConsoleKey.A)
            {//Start of Programmer Wage Method

                Console.Clear();

                double hourlyrate = 12.03;

                Console.Write("[---------[");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Create a Wage Slip");
                Console.ResetColor();
                Console.Write("]---------] \n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Your hourly rate is £12.03 \n");
                Console.WriteLine("Enter hours worked: ");
                Console.ResetColor();
                hoursworked = double.Parse(Console.ReadLine());

                if (hoursworked >= 50) //Calcualtes overtime if worked more than 50 hours
                {
                    difference = hoursworked - 50;
                    wage = 40 * hourlyrate;
                    overtimeone = 10 * (hourlyrate * 1.5);
                    overtimetwo = difference * (hourlyrate * 2);
                    gross = wage + overtimeone + overtimetwo;
                    gross = Math.Round(gross, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total gross: {0}", gross);
                    Console.ResetColor();
                    ni_pay = gross * 0.11;
                    ni_pay = Math.Round(ni_pay, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total national insurance number: {0}", ni_pay);
                    Console.ResetColor();
                    tax = (gross - ni_pay) * 0.25;
                    tax = Math.Round(tax, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total tax: {0}", tax);
                    Console.ResetColor();
                    net = gross - ni_pay - tax;
                    net = Math.Round(net, 2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Total net pay after deductions: {0} \n", net);
                    Console.ResetColor();
                }

                else if (hoursworked >= 40 && hoursworked < 50) //Calculates overtime if worked more than 40 hours and less than 50
                {
                    difference = hoursworked - 40;
                    wage = 40 * hourlyrate;
                    overtime = difference * (hourlyrate * 1.5);
                    gross = wage + overtime;
                    gross = Math.Round(gross, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total gross: {0}", gross);
                    Console.ResetColor();
                    ni_pay = gross * 0.11;
                    ni_pay = Math.Round(ni_pay, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total national insurance pay: {0}", ni_pay);
                    Console.ResetColor();
                    tax = (gross - ni_pay) * 0.25;
                    tax = Math.Round(tax, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total tax: {0}", tax);
                    Console.ResetColor();
                    net = gross - ni_pay - tax;
                    net = Math.Round(net, 2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Total net pay after deductions: {0} \n", net);
                    Console.ResetColor();
                }

                else
                {
                    gross = hoursworked * hourlyrate;
                    gross = Math.Round(gross, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total gross: {0}", gross);
                    Console.ResetColor();
                    ni_pay = gross * 0.11;
                    ni_pay = Math.Round(ni_pay, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total national insurance pay: {0}", ni_pay);
                    Console.ResetColor();
                    tax = (gross - ni_pay) * 0.25;
                    tax = Math.Round(tax, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total tax: {0}", tax);
                    Console.ResetColor();
                    net = gross - ni_pay - tax;
                    net = Math.Round(net, 2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Total net pay after deductions: {0} \n", net);
                    Console.ResetColor();
                }
            }//End of Programmer Wage Method

            if (myKey.Key == ConsoleKey.B)
            {//Start of Administrators/Clerks Wage Method

                Console.Clear();

                double hourlyrate = 8.07;

                Console.Write("[---------[");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Create a Wage Slip");
                Console.ResetColor();
                Console.Write("]---------] \n");

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Your hourly rate is £8.07 \n");
                Console.WriteLine("Enter hours worked: ");
                Console.ResetColor();
                hoursworked = double.Parse(Console.ReadLine());

                if (hoursworked >= 50) //Calcualtes overtime if worked more than 50 hours
                {
                    difference = hoursworked - 50;
                    wage = 40 * hourlyrate;
                    overtimeone = 10 * (hourlyrate * 1.5);
                    overtimetwo = difference * (hourlyrate * 2);
                    gross = wage + overtimeone + overtimetwo;
                    gross = Math.Round(gross, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total gross: {0}", gross);
                    Console.ResetColor();
                    ni_pay = gross * 0.11;
                    ni_pay = Math.Round(ni_pay, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total national insurance pay: {0}", ni_pay);
                    Console.ResetColor();
                    tax = (gross - ni_pay) * 0.25;
                    tax = Math.Round(tax, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total tax: {0}", tax);
                    Console.ResetColor();
                    net = gross - ni_pay - tax;
                    net = Math.Round(net, 2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Total net pay after deductions: {0} \n", net);
                    Console.ResetColor();
                }

                else if (hoursworked >= 40 && hoursworked < 50) //Calculates overtime if worked more than 40 hours and less than 50
                {
                    difference = hoursworked - 40;
                    wage = 40 * hourlyrate;
                    overtime = difference * (hourlyrate * 1.5);
                    gross = wage + overtime;
                    gross = Math.Round(gross, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total gross: {0}", gross);
                    Console.ResetColor();
                    ni_pay = gross * 0.11;
                    ni_pay = Math.Round(ni_pay, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total national insurance pay: {0}", ni_pay);
                    Console.ResetColor();
                    tax = (gross - ni_pay) * 0.25;
                    tax = Math.Round(tax, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total tax: {0}", tax);
                    Console.ResetColor();
                    net = gross - ni_pay - tax;
                    net = Math.Round(net, 2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Total net pay after deductions: {0} \n", net);
                    Console.ResetColor();
                }

                else
                {
                    gross = hoursworked * hourlyrate;
                    gross = Math.Round(gross, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total gross: {0}", gross);
                    Console.ResetColor();
                    ni_pay = gross * 0.11;
                    ni_pay = Math.Round(ni_pay, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total national insurance pay: {0}", ni_pay);
                    Console.ResetColor();
                    tax = (gross - ni_pay) * 0.25;
                    tax = Math.Round(tax, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total tax: {0}", tax);
                    Console.ResetColor();
                    net = gross - ni_pay - tax;
                    net = Math.Round(net, 2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Total net pay after deductions: {0} \n", net);
                    Console.ResetColor();
                }
            }//End of Administrators/Clerks Wage Method

            if (myKey.Key == ConsoleKey.C)
            {//Start of Project Leader/Manager Wage Method

                Console.Clear();

                double hourlyrate = 22.54;

                Console.Write("[---------[");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Create a Wage Slip");
                Console.ResetColor();
                Console.Write("]---------] \n");

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Your hourly rate is £22.54 \n");
                Console.WriteLine("Enter hours worked: ");
                Console.ResetColor();
                hoursworked = double.Parse(Console.ReadLine());

                if (hoursworked >= 50) //Calcualtes overtime if worked more than 50 hours
                {
                    difference = hoursworked - 50;
                    wage = 40 * hourlyrate;
                    overtimeone = 10 * (hourlyrate * 1.5);
                    overtimetwo = difference * (hourlyrate * 2);
                    gross = wage + overtimeone + overtimetwo;
                    gross = Math.Round(gross, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total gross: {0}", gross);
                    Console.ResetColor();
                    ni_pay = gross * 0.11;
                    ni_pay = Math.Round(ni_pay, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total national insurance pay: {0}", ni_pay);
                    Console.ResetColor();
                    tax = (gross - ni_pay) * 0.25;
                    tax = Math.Round(tax, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total tax: {0}", tax);
                    Console.ResetColor();
                    net = gross - ni_pay - tax;
                    net = Math.Round(net, 2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Total net pay after deductions: {0} \n", net);
                    Console.ResetColor();
                }

                else if (hoursworked >= 40 && hoursworked < 50) //Calculates overtime if worked more than 40 hours and less than 50
                {
                    difference = hoursworked - 40;
                    wage = 40 * hourlyrate;
                    overtime = difference * (hourlyrate * 1.5);
                    gross = wage + overtime;
                    gross = Math.Round(gross, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total gross: {0}", gross);
                    Console.ResetColor();
                    ni_pay = gross * 0.11;
                    ni_pay = Math.Round(ni_pay, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total national insurance pay: {0}", ni_pay);
                    Console.ResetColor();
                    tax = (gross - ni_pay) * 0.25;
                    tax = Math.Round(tax, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total tax: {0}", tax);
                    Console.ResetColor();
                    net = gross - ni_pay - tax;
                    net = Math.Round(net, 2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Total net pay after deductions: {0} \n", net);
                    Console.ResetColor();
                }

                else
                {
                    gross = hoursworked * hourlyrate;
                    gross = Math.Round(gross, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total gross: {0}", gross);
                    Console.ResetColor();
                    ni_pay = gross * 0.11;
                    ni_pay = Math.Round(ni_pay, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total national insurance pay: {0}", ni_pay);
                    Console.ResetColor();
                    tax = (gross - ni_pay) * 0.25;
                    tax = Math.Round(tax, 2);
                    net = gross - ni_pay - tax;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total tax: {0}", tax);
                    Console.ResetColor();
                    net = Math.Round(net, 2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Total net pay after deductions: {0} \n", net);
                    Console.ResetColor();
                }
            }//End of Project Leader/Manager Wage Method

            if (myKey.Key == ConsoleKey.D)
            {//Start of Other Wage Method

                Console.Clear();

                double hourlyrate = 0;
                string job_title;

                Console.Write("[---------[");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Create a Wage Slip");
                Console.ResetColor();
                Console.Write("]---------] \n");

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Additional information is required to complete this payslip \n");
                Console.WriteLine("Enter your job title: \n");
                Console.ResetColor();
                job_title = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter hours worked: \n");
                Console.ResetColor();
                hoursworked = double.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter hourly rate: \n");
                Console.ResetColor();
                hourlyrate = double.Parse(Console.ReadLine());

                if (hoursworked >= 50) //Calcualtes overtime if worked more than 50 hours
                {
                    difference = hoursworked - 50;
                    wage = 40 * hourlyrate;
                    overtimeone = 10 * (hourlyrate * 1.5);
                    overtimetwo = difference * (hourlyrate * 2);
                    gross = wage + overtimeone + overtimetwo;
                    gross = Math.Round(gross, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total gross: {0}", gross);
                    Console.ResetColor();
                    ni_pay = gross * 0.11;
                    ni_pay = Math.Round(ni_pay, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total national insurance pay: {0}", ni_pay);
                    Console.ResetColor();
                    tax = (gross - ni_pay) * 0.25;
                    tax = Math.Round(tax, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total tax: {0}", tax);
                    Console.ResetColor();
                    net = gross - ni_pay - tax;
                    net = Math.Round(net, 2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Total net pay after deductions: {0} \n", net);
                    Console.ResetColor();
                }

                else if (hoursworked >= 40 && hoursworked < 50) //Calculates overtime if worked more than 40 hours and less than 50
                {
                    difference = hoursworked - 40;
                    wage = 40 * hourlyrate;
                    overtime = difference * (hourlyrate * 1.5);
                    gross = wage + overtime;
                    gross = Math.Round(gross, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total gross: {0}", gross);
                    Console.ResetColor();
                    ni_pay = gross * 0.11;
                    ni_pay = Math.Round(ni_pay, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total national insurance pay: {0}", ni_pay);
                    Console.ResetColor();
                    tax = (gross - ni_pay) * 0.25;
                    tax = Math.Round(tax, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total tax: {0}", tax);
                    Console.ResetColor();
                    net = gross - ni_pay - tax;
                    net = Math.Round(net, 2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Total net pay after deductions: {0} \n", net);
                    Console.ResetColor();
                }

                else
                {
                    gross = hoursworked * hourlyrate;
                    gross = Math.Round(gross, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total gross: {0}", gross);
                    Console.ResetColor();
                    ni_pay = gross * 0.11;
                    ni_pay = Math.Round(ni_pay, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total national insurance pay: {0}", ni_pay);
                    Console.ResetColor();
                    tax = (gross - ni_pay) * 0.25;
                    tax = Math.Round(tax, 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Total tax: {0}", tax);
                    Console.ResetColor();
                    net = gross - ni_pay - tax;
                    net = Math.Round(net, 2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Total net pay after deductions: {0} \n", net);
                    Console.ResetColor();
                }
            }//End of Other Wage Method

            string query = "INSERT INTO wageslip VALUES(NULL, '" + title + "','" + first_name + "','" + surname + "','" + ni_number + "','" + hoursworked + "','" + difference + "','" + gross + "','" + ni_pay + "','" + tax + "','" + net + "', NOW())";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n -->Record Added - Press ENTER To Continue...");
            Console.ReadLine();

            Console.ResetColor();

        }//End of create Wage Slip Method

        static void viewWageSlip()
        {//Start of view Wage Slip Method

            Initialise();

            Console.Clear();

            Console.Write("[---------[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("View a Wage Slip");
            Console.ResetColor();
            Console.Write("]---------] \n");

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Would you like to view all wage slips or one specific wage slip? \n[A] All Wage Slips \n[B] Specific Wage Slip");
            ConsoleKeyInfo myKey = Console.ReadKey();

            Console.ResetColor();

            if (myKey.Key == ConsoleKey.A)
            {

                Console.Clear();

                int payslip_id = 1;

                string query = "SELECT * FROM wageslip";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while(dataReader.Read())
                {

                    Console.Write("\n---------------------------------------------");

                    Console.Write("\n PAYSLIP ID:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(payslip_id);
                    Console.ResetColor();

                    Console.Write("\n\n TITLE: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(dataReader["title"]);
                    Console.ResetColor();

                    Console.Write("          Name: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(dataReader["surname"]);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(", ");
                    Console.Write(dataReader["first_name"]);
                    Console.ResetColor();

                    Console.Write("\n\n National Insurance Number: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(dataReader["ni_number"]);
                    Console.ResetColor();

                    Console.Write("\n\n Hours Worked: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(dataReader["hoursworked"]);
                    Console.ResetColor();

                    Console.Write("\n\n Overtime: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(dataReader["difference"]);
                    Console.ResetColor();

                    Console.Write("\n\n Gross Pay: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(dataReader["gross"]);
                    Console.ResetColor();

                    Console.Write("\n\n National Insurance Pay: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(dataReader["ni_pay"]);
                    Console.ResetColor();

                    Console.Write("\n\n Tax Pay: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(dataReader["tax"]);
                    Console.ResetColor();

                    Console.Write("\n\n Net: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(dataReader["net"]);
                    Console.ResetColor();

                    Console.Write("\n\n Date: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(string.Format("{0:dd/MM/yyyy}", dataReader["date"]));
                    Console.ResetColor();

                    Console.Write("\n---------------------------------------------");

                    payslip_id++;
                }

                connection.Close();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Press ENTER to return to the main menu");
                Console.ResetColor();

                Console.ReadLine();
            }

            else if (myKey.Key == ConsoleKey.B)
            {

                Console.Clear();

                int payslip_id = 1;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter the Surname of the wage slip to be updated: ");
                Console.ResetColor();
                string choice = Console.ReadLine();

                string query = "SELECT * FROM wageslip WHERE surname LIKE '%" + choice + "'";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    Console.Write("\n---------------------------------------------");

                    Console.Write("\n PAYSLIP ID:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(payslip_id);
                    Console.ResetColor();

                    Console.Write("\n\n TITLE: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(dataReader["title"]);
                    Console.ResetColor();

                    Console.Write("          Name: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(dataReader["surname"]);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(", ");
                    Console.Write(dataReader["first_name"]);
                    Console.ResetColor();

                    Console.Write("\n\n National Insurance Number: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(dataReader["ni_number"]);
                    Console.ResetColor();

                    Console.Write("\n\n Hours Worked: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(dataReader["hoursworked"]);
                    Console.ResetColor();

                    Console.Write("\n\n Overtime: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(dataReader["difference"]);
                    Console.ResetColor();

                    Console.Write("\n\n Gross Pay: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(dataReader["gross"]);
                    Console.ResetColor();

                    Console.Write("\n\n National Insurance Pay: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(dataReader["ni_pay"]);
                    Console.ResetColor();

                    Console.Write("\n\n Tax Pay: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(dataReader["tax"]);
                    Console.ResetColor();

                    Console.Write("\n\n Net: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(dataReader["net"]);
                    Console.ResetColor();

                    Console.Write("\n\n Date: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(string.Format("{0:dd/MM/yyyy}", dataReader["date"]));
                    Console.ResetColor();

                    Console.Write("\n---------------------------------------------");

                    payslip_id++;
                }

                connection.Close();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Press ENTER to return to the main menu");
                Console.ResetColor();

                Console.ReadLine();
            }

        }//End of view Wage Slip Method

        static void updateWageSlip()
        {//Start of Update Wage Slip Method

            Initialise();

            Console.Clear();

            Console.Write("[---------[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Update a Wage Slip");
            Console.ResetColor();
            Console.Write("]---------] \n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Would you like to update a wage slip via the Employee ID or Surname?");
            Console.ResetColor();
            string choice = Console.ReadLine();

            if (choice.Equals("Employee ID"))
            {

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("Enter the ID of the wage slip to be updated: ");
                Console.ResetColor();
                int rowid = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Updating {0};\n", rowid);
                Console.ResetColor();

                Regex regex = new Regex(@"^[a-zA-Z -]*$");
                Regex regex2 = new Regex(@"^[a-zA-Z0-9 ]*$");

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Re-enter Title: \n");
                    Console.ResetColor();
                    title = Console.ReadLine();

                    if (string.IsNullOrEmpty(title))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letter and hyphens");
                        Console.ResetColor();
                    }
                    else if (regex.IsMatch(title))
                    {
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letter and hyphens");
                        Console.ResetColor();
                    }
                }

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Re-enter First Name: \n");
                    Console.ResetColor();
                    first_name = Console.ReadLine();

                    if (string.IsNullOrEmpty(first_name)) //The regex rule accepts null values
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letters and hyphens");
                        Console.ResetColor();
                    }

                    else if (regex.IsMatch(first_name))
                    {
                        break;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letters and hyphens");
                        Console.ResetColor();
                    }
                }

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Re-enter Surname: \n");
                    Console.ResetColor();
                    surname = Console.ReadLine();

                    if (string.IsNullOrEmpty(surname))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letters and hyphens");
                        Console.ResetColor();
                    }

                    else if (regex.IsMatch(surname))
                    {
                        break;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letters and hyphens");
                        Console.ResetColor();
                    }
                }

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Re-enter National Insurance Number: \n");
                    Console.ResetColor();
                    ni_number = Console.ReadLine();

                    if (string.IsNullOrEmpty(ni_number))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letters and numbers");
                        Console.ResetColor();
                    }

                    else if (regex2.IsMatch(ni_number))
                    {
                        break;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letters and numbers");
                        Console.ResetColor();
                    }
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("What is your job role? \n");
                Console.WriteLine("<A> Programmer");
                Console.WriteLine("<B> Administrators/Clerks");
                Console.WriteLine("<C> Project Leader/Manager");
                Console.WriteLine("<D> Other");
                Console.ResetColor();
                ConsoleKeyInfo myKey = Console.ReadKey();

                if (myKey.Key == ConsoleKey.A)
                {//Start of Programmer Wage Method

                    Console.Clear();

                    double hourlyrate = 12.03;

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("Your hourly rate is £12.03 \n");
                    Console.WriteLine("Enter hours worked: ");
                    Console.ResetColor();
                    hoursworked = double.Parse(Console.ReadLine());

                    if (hoursworked >= 50) //Calcualtes overtime if worked more than 50 hours
                    {
                        difference = hoursworked - 50;
                        wage = 40 * hourlyrate;
                        overtimeone = 10 * (hourlyrate * 1.5);
                        overtimetwo = difference * (hourlyrate * 2);
                        gross = wage + overtimeone + overtimetwo;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else if (hoursworked >= 40 && hoursworked < 50) //Calculates overtime if worked more than 40 hours and less than 50
                    {
                        difference = hoursworked - 40;
                        wage = 40 * hourlyrate;
                        overtime = difference * (hourlyrate * 1.5);
                        gross = wage + overtime;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else
                    {
                        gross = hoursworked * hourlyrate;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }
                }//End of Programmer Wage Method

                if (myKey.Key == ConsoleKey.B)
                {//Start of Administrators/Clerks Wage Method

                    Console.Clear();

                    double hourlyrate = 8.07;

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("Your hourly rate is £8.07 \n");
                    Console.WriteLine("Enter hours worked: ");
                    Console.ResetColor();
                    hoursworked = double.Parse(Console.ReadLine());

                    if (hoursworked >= 50) //Calcualtes overtime if worked more than 50 hours
                    {
                        difference = hoursworked - 50;
                        wage = 40 * hourlyrate;
                        overtimeone = 10 * (hourlyrate * 1.5);
                        overtimetwo = difference * (hourlyrate * 2);
                        gross = wage + overtimeone + overtimetwo;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else if (hoursworked >= 40 && hoursworked < 50) //Calculates overtime if worked more than 40 hours and less than 50
                    {
                        difference = hoursworked - 40;
                        wage = 40 * hourlyrate;
                        overtime = difference * (hourlyrate * 1.5);
                        gross = wage + overtime;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else
                    {
                        gross = hoursworked * hourlyrate;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }
                }//End of Administrators/Clerks Wage Method

                if (myKey.Key == ConsoleKey.C)
                {//Start of Project Leader/Manager Wage Method

                    Console.Clear();

                    double hourlyrate = 22.54;

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("Your hourly rate is £22.54 \n");
                    Console.WriteLine("Enter hours worked: ");
                    Console.ResetColor();
                    hoursworked = double.Parse(Console.ReadLine());

                    if (hoursworked >= 50) //Calcualtes overtime if worked more than 50 hours
                    {
                        difference = hoursworked - 50;
                        wage = 40 * hourlyrate;
                        overtimeone = 10 * (hourlyrate * 1.5);
                        overtimetwo = difference * (hourlyrate * 2);
                        gross = wage + overtimeone + overtimetwo;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else if (hoursworked >= 40 && hoursworked < 50) //Calculates overtime if worked more than 40 hours and less than 50
                    {
                        difference = hoursworked - 40;
                        wage = 40 * hourlyrate;
                        overtime = difference * (hourlyrate * 1.5);
                        gross = wage + overtime;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else
                    {
                        gross = hoursworked * hourlyrate;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }
                }//End of Project Leader/Manager Wage Method

                if (myKey.Key == ConsoleKey.D)
                {//Start of Other Wage Method

                    Console.Clear();

                    double hourlyrate = 0;
                    string job_title;

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("Additional information is required to complete this payslip \n");
                    Console.WriteLine("Enter your job title: \n");
                    Console.ResetColor();
                    job_title = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter hours worked: \n");
                    Console.ResetColor();
                    hoursworked = double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter hourly rate: \n");
                    Console.ResetColor();
                    hourlyrate = double.Parse(Console.ReadLine());

                    if (hoursworked >= 50) //Calcualtes overtime if worked more than 50 hours
                    {
                        difference = hoursworked - 50;
                        wage = 40 * hourlyrate;
                        overtimeone = 10 * (hourlyrate * 1.5);
                        overtimetwo = difference * (hourlyrate * 2);
                        gross = wage + overtimeone + overtimetwo;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else if (hoursworked >= 40 && hoursworked < 50) //Calculates overtime if worked more than 40 hours and less than 50
                    {
                        difference = hoursworked - 40;
                        wage = 40 * hourlyrate;
                        overtime = difference * (hourlyrate * 1.5);
                        gross = wage + overtime;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else
                    {
                        gross = hoursworked * hourlyrate;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }
                }//End of Other Wage Method

                string query = "UPDATE wageslip SET title='" + title + "', first_name='" + first_name + "', surname='" + surname + "', ni_number='" + ni_number + "', hoursworked='" + hoursworked + "', difference='" + difference + "', gross='" + gross + "', ni_pay='" + ni_pay + "', tax='" + tax + "', net='" + net + "', date=NOW() WHERE employee_id='" + rowid + "'";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("\n Update Successful Press ENTER To Continue...");
            }

            else if (choice.Equals("Surname"))
            {

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter the surname of the wage slip to be updated: ");
                Console.ResetColor();
                surname = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Updating {0};\n", surname);
                Console.ResetColor();

                Regex regex = new Regex(@"^[a-zA-Z -]*$");
                Regex regex2 = new Regex(@"^[a-zA-Z0-9 ]*$");

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Re-enter Title: \n");
                    Console.ResetColor();
                    title = Console.ReadLine();

                    if (string.IsNullOrEmpty(title))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letter and hyphens");
                        Console.ResetColor();
                    }
                    else if (regex.IsMatch(title))
                    {
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letter and hyphens");
                        Console.ResetColor();
                    }
                }

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Re-enter First Name: \n");
                    Console.ResetColor();
                    first_name = Console.ReadLine();

                    if (string.IsNullOrEmpty(first_name)) //The regex rule accepts null values
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letters and hyphens");
                        Console.ResetColor();
                    }

                    else if (regex.IsMatch(first_name))
                    {
                        break;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letters and hyphens");
                        Console.ResetColor();
                    }
                }

                string new_surname = "";
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Re-enter Surname: \n");
                    Console.ResetColor();
                    new_surname = Console.ReadLine();

                    if (string.IsNullOrEmpty(surname))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letters and hyphens");
                        Console.ResetColor();
                    }

                    else if (regex.IsMatch(surname))
                    {
                        break;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letters and hyphens");
                        Console.ResetColor();
                    }
                }

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Re-enter National Insurance Number: \n");
                    Console.ResetColor();
                    ni_number = Console.ReadLine();

                    if (string.IsNullOrEmpty(ni_number))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letters and numbers");
                        Console.ResetColor();
                    }

                    else if (regex2.IsMatch(ni_number))
                    {
                        break;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only letters and numbers");
                        Console.ResetColor();
                    }
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("What is your job role? \n");
                Console.WriteLine("<A> Programmer");
                Console.WriteLine("<B> Administrators/Clerks");
                Console.WriteLine("<C> Project Leader/Manager");
                Console.WriteLine("<D> Other");
                Console.ResetColor();
                ConsoleKeyInfo myKey = Console.ReadKey();

                if (myKey.Key == ConsoleKey.A)
                {//Start of Programmer Wage Method

                    Console.Clear();

                    double hourlyrate = 12.03;

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("Your hourly rate is £12.03 \n");
                    Console.WriteLine("Enter hours worked: ");
                    Console.ResetColor();
                    hoursworked = double.Parse(Console.ReadLine());

                    if (hoursworked >= 50) //Calcualtes overtime if worked more than 50 hours
                    {
                        difference = hoursworked - 50;
                        wage = 40 * hourlyrate;
                        overtimeone = 10 * (hourlyrate * 1.5);
                        overtimetwo = difference * (hourlyrate * 2);
                        gross = wage + overtimeone + overtimetwo;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else if (hoursworked >= 40 && hoursworked < 50) //Calculates overtime if worked more than 40 hours and less than 50
                    {
                        difference = hoursworked - 40;
                        wage = 40 * hourlyrate;
                        overtime = difference * (hourlyrate * 1.5);
                        gross = wage + overtime;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else
                    {
                        gross = hoursworked * hourlyrate;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }
                }//End of Programmer Wage Method

                if (myKey.Key == ConsoleKey.B)
                {//Start of Administrators/Clerks Wage Method

                    Console.Clear();

                    double hourlyrate = 8.07;

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("Your hourly rate is £8.07 \n");
                    Console.WriteLine("Enter hours worked: ");
                    Console.ResetColor();
                    hoursworked = double.Parse(Console.ReadLine());

                    if (hoursworked >= 50) //Calcualtes overtime if worked more than 50 hours
                    {
                        difference = hoursworked - 50;
                        wage = 40 * hourlyrate;
                        overtimeone = 10 * (hourlyrate * 1.5);
                        overtimetwo = difference * (hourlyrate * 2);
                        gross = wage + overtimeone + overtimetwo;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else if (hoursworked >= 40 && hoursworked < 50) //Calculates overtime if worked more than 40 hours and less than 50
                    {
                        difference = hoursworked - 40;
                        wage = 40 * hourlyrate;
                        overtime = difference * (hourlyrate * 1.5);
                        gross = wage + overtime;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else
                    {
                        gross = hoursworked * hourlyrate;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }
                }//End of Administrators/Clerks Wage Method

                if (myKey.Key == ConsoleKey.C)
                {//Start of Project Leader/Manager Wage Method

                    Console.Clear();

                    double hourlyrate = 22.54;

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("Your hourly rate is £22.54 \n");
                    Console.WriteLine("Enter hours worked: ");
                    Console.ResetColor();
                    hoursworked = double.Parse(Console.ReadLine());

                    if (hoursworked >= 50) //Calcualtes overtime if worked more than 50 hours
                    {
                        difference = hoursworked - 50;
                        wage = 40 * hourlyrate;
                        overtimeone = 10 * (hourlyrate * 1.5);
                        overtimetwo = difference * (hourlyrate * 2);
                        gross = wage + overtimeone + overtimetwo;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else if (hoursworked >= 40 && hoursworked < 50) //Calculates overtime if worked more than 40 hours and less than 50
                    {
                        difference = hoursworked - 40;
                        wage = 40 * hourlyrate;
                        overtime = difference * (hourlyrate * 1.5);
                        gross = wage + overtime;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else
                    {
                        gross = hoursworked * hourlyrate;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }
                }//End of Project Leader/Manager Wage Method

                if (myKey.Key == ConsoleKey.D)
                {//Start of Other Wage Method

                    Console.Clear();

                    double hourlyrate = 0;
                    string job_title;

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("Additional information is required to complete this payslip \n");
                    Console.WriteLine("Enter your job title: \n");
                    Console.ResetColor();
                    job_title = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter hours worked: \n");
                    Console.ResetColor();
                    hoursworked = double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter hourly rate: \n");
                    Console.ResetColor();
                    hourlyrate = double.Parse(Console.ReadLine());

                    if (hoursworked >= 50) //Calcualtes overtime if worked more than 50 hours
                    {
                        difference = hoursworked - 50;
                        wage = 40 * hourlyrate;
                        overtimeone = 10 * (hourlyrate * 1.5);
                        overtimetwo = difference * (hourlyrate * 2);
                        gross = wage + overtimeone + overtimetwo;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else if (hoursworked >= 40 && hoursworked < 50) //Calculates overtime if worked more than 40 hours and less than 50
                    {
                        difference = hoursworked - 40;
                        wage = 40 * hourlyrate;
                        overtime = difference * (hourlyrate * 1.5);
                        gross = wage + overtime;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }

                    else
                    {
                        gross = hoursworked * hourlyrate;
                        gross = Math.Round(gross, 2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total gross: {0}", gross);
                        Console.ResetColor();
                        ni_pay = gross * 0.11;
                        ni_pay = Math.Round(ni_pay, 2);
                        tax = (gross - ni_pay) * 0.25;
                        tax = Math.Round(tax, 2);
                        net = gross - ni_pay - tax;
                        net = Math.Round(net, 2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total net pay after deductions: {0} \n", net);
                        Console.ResetColor();
                    }
                }//End of Other Wage Method

                string query = "UPDATE wageslip SET title='" + title + "', first_name='" + first_name + "', surname='" + surname + "', ni_number='" + ni_number + "', hoursworked='" + hoursworked + "', difference='" + difference + "', gross='" + gross + "', ni_pay='" + ni_pay + "', tax='" + tax + "', net='" + net + "', date=NOW() WHERE surname='" + new_surname + "'";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                connection.Close();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Update Successful Press ENTER To Continue...");
                Console.ResetColor();
            }

            Console.ReadLine();
        }//End of Update Wage Slip Method

        static void deleteWageSlip()
        {//Start of delete Wage Slip Method

            Initialise(); //Connects to the initialise method, establishing connection to the database

            Console.Clear();

            //Heading of console
            Console.Write("[---------[");
            Console.ForegroundColor = ConsoleColor.Green; //Changes colour of the text to green
            Console.Write("Delete a Wage Slip");
            Console.ResetColor(); //Resets the colour of the text to grey
            Console.Write("]---------] \n");
            //End of console heading

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Would you like to delete a wage slip via the employee ID of Nationl Insurance Number?");
            Console.ResetColor();
            string choice = Console.ReadLine(); //Reads and stores the input of the user within the choice variable

            if (choice.Equals("Employee ID"))
            { //Start of If statement

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter the ID of the wage slip to be deleted: ");
                Console.ResetColor();
                int rowid = int.Parse(Console.ReadLine()); //Reads and stores the input of the user within the rowid variable
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} Wage Slip Deleted!;\n", rowid); //Displays the user input 
                Console.ResetColor();

                string query = "DELETE FROM wageslip WHERE employee_id='" + rowid + "'"; //Creates a SQL statement to be used by the database
                connection.Open(); //Opens the connection to the database
                MySqlCommand cmd = new MySqlCommand(query, connection); //Creates a SQL command using the inforamtion contained within the variables query and connection
                cmd.ExecuteNonQuery();
                connection.Close(); //Closes the connection to the database
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPress ENTER To Continue...");
                Console.ResetColor();
                Console.ReadLine();
            }

            else if (choice.Equals("National Insurance Number"))
            {

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please enter the National Insurance Number of the wage slip to be deleted;");
                Console.ResetColor();
                ni_number = Console.ReadLine(); //Reads and stores the input of the user within the rowid variable
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} Wage Slip Deleted!;\n", ni_number); //Displays the user input
                Console.ResetColor();

                string query = "DELETE FROM wageslip WHERE ni_number='" + ni_number + "'"; //Creates a SQL statement to be used by the database
                connection.Open(); //Opens the connection to the database
                MySqlCommand cmd = new MySqlCommand(query, connection); //Creates a SQL command using the inforamtion contained within the variables query and connection
                cmd.ExecuteNonQuery();
                connection.Close(); //Closes the connection to the database
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPress ENTER To Continue...");
                Console.ResetColor();
                Console.ReadLine();
            }


        }//End of delete Wage Slip Method

        static void help()
        {//Start of help Method
            Console.Clear();

            //Heading of console
            Console.Write("[---------[");
            Console.ForegroundColor = ConsoleColor.Green; //Changes colour of the text to green
            Console.Write("Help");
            Console.ResetColor(); //Resets the colour of the text to grey
            Console.Write("]---------] \n");
            //End of console heading

            Console.ForegroundColor = ConsoleColor.Yellow; //Changes colour of the text to yellow

            Console.WriteLine("Net - Amount earnt after tax and National Insurance deductions \n");
            Console.WriteLine("To access the create a wage slip section, click the A button on the keyboard, the user will then be taken to the appropriate screen where they must enter the correct information as prompted. \n");
            Console.WriteLine("To access the view a wage slip section, click the B button on the keyboard, the user will then be able to view all the wage slips stored within database. \n");
            Console.WriteLine("To access the update a wage slip section, click the C button on the keyboard, the user will then be taken to the appropriate screen, where the user must re-enter the correct information as prompted. \n");
            Console.WriteLine("To access the delete a wage slip section, click the D button, the user will then be prompted to enter the ID of the wage slip to be deleted. \n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press ENTER to return to the main menu");
            Console.ResetColor(); //Resets the colour to the text to grey

            Console.ReadLine();

        }//End of help Method
    }
}
