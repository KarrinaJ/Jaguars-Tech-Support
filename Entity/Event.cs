using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Event //Used to store successful logins and logouts of each user
    {
        private int eNo;
        private string type;
        private string dTime;  
        private string accountID;

        private static readonly Random random = new Random();
        private static readonly HashSet<int> generatedNumbers = new HashSet<int>();
        public int ENo
        {
            get
            {
                return eNo;
            }
            set
            {
                if (value > int.MaxValue || value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    eNo = value;
                }
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public string DTime
        {
            get
            {
                return dTime;
            }
            set
            {
                dTime = value;
            }
        }

        public string AccountID
        {
            get 
            {
                return accountID;
            }

            set
            {
                accountID = value;
            }
        }
        public Event()
        {
            //default constructor
        }
        public Event(string type, string accountID )
        {

            ENo = GenerateRandom5DigitNumber();
            Type = type;
            
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            DTime = formattedDateTime;
           
            AccountID = accountID;
        }

        public static int GenerateRandom5DigitNumber()
        {
            int randomNumber;
            do
            {
                randomNumber = random.Next(10000, 99999);
            } while (!generatedNumbers.Add(randomNumber));

            return randomNumber;
        }
    }
}


