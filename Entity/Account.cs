using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;

namespace Entity
{
    public class Account
    {
        private string email;
        private string password;
        private string userType;
        private string name;

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (isValidEmail(value))
                {
                    email = value;
                }

                else
                {
                    throw new FormatException("Invalid credentials.");
                }
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                if (isValidPassword(value))
                    password = value;

                else
                {
                    throw new ArgumentException("Invalid credentials.");
                }
            }
        }

        public string UserType
        {
            get
            {
                return userType;
            }

            set
            {
                if(value == "Customer" || value == "Technician")
                {
                    userType = value;
                }

                else
                {
                    throw new ArgumentException("Invalid user type");
                } 
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Account(string email_param, string password_param, string userType_param, string name_param)
        {
            Email = email_param;
            Password = password_param;
            UserType = userType_param;
            Name = name_param;
        }

        public Account()
        {

        }

        //Email validation. Making sure user emails follow a certain format
        //Source https://www.youtube.com/watch?v=2ujFcfybwhw
        public static bool isValidEmail(string email)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            var isValid = emailRegex.IsMatch(email);
            if (!isValid)
            {
                Console.WriteLine("Invalid email format.");
            }
            return isValid;
        }

        //Password Policy each account must adhere to
        public static bool isValidPassword(string password)
        {
            var input = password;
            var containsNumber = new Regex(@"[0-9]+"); //password should contain at least 1 number
            var containsUpperCase = new Regex(@"[A-Z]+"); //password should contain at least 1 uppercase letter
            var containsSpecialChar = new Regex(@"[!@#$%^&*()_?=]+"); //password should contain at least 1 special character
            var isValid = containsNumber.IsMatch(input) && containsUpperCase.IsMatch(input) && containsSpecialChar.IsMatch(input) && input.Length > 11; //password should also have 12 or more characters
            if (!isValid) 
            {
                Console.WriteLine("Password must contain: \n12 or more Characters\n1 or more Uppercase Letter(s)\n1 or more Number(s)\n1 or more of the following special characters: (!@#$%^&*()_?=)");
            }
            return isValid;
        }
    }
}