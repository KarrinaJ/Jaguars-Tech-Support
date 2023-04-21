using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Event //Used to store successful logins and logouts of each user
    {
        private int eNo; //int?
        private string type;
        private string date;
        private string time;
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
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }
        public Event()
        {
            //default constructor
        }
        public Event(string type)
        {
            Type = type;
        }
    }
}

