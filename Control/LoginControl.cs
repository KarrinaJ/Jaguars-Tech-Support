using Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control;
using GUIForJTS;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.ApplicationServices;
using Jaguars_Tech_Support.Boundary;
using System.Diagnostics;

namespace Control
{
    internal class LoginControl
    {
        public static void Submit(string email, string pwd)
        {
            if (Validate(email, pwd) == true) //First make sure email and password are in correct format and that neither are malicious.
            {
                Account user = DBConnector.GetUser(email, pwd); //If this passes, send email and password to the database to see if it matches an account
                
                TicketList<Ticket> txList = DBConnector.GetTickets(user); //If the account exists, get the tickets associated with it
                if (user.UserType == "Customer")
                {
                    CustomerScreen custView = new CustomerScreen(txList, user);
                    custView.Display(txList);
                    custView.Show();
                    DBConnector.SaveLogin(user.Email);
                    LoginForm obj = (LoginForm)Application.OpenForms["LoginForm"];
                    obj.Close();
                }

                else if (user.UserType == "Technician")
                {
                    TechnicianScreen techView = new TechnicianScreen(txList, user);
                    techView.Display(txList);
                    techView.Show();
                    DBConnector.SaveLogin(user.Email);
                    LoginForm obj = (LoginForm)Application.OpenForms["LoginForm"];
                    obj.Close();
                }
            }

            else
            {
                MessageBox.Show("Email or password format invalid.");
            }

        }
        public static bool Validate(string email, string pwd)
        {
            if (Account.isValidEmail(email) == true && Account.isValidPassword(pwd) == true)
            {
                return true;
            }

            else
                return false;
        }
    }
}
