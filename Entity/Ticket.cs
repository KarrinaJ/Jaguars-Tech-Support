using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entity
{
    public class Ticket
    {
        private string name;
        private string email;
        private string techName;
        private int ticketNo = 1170; //starting place for our system
        private string ticketSubject;
        private string status;
        private string ticketDescription;

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
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public string TechName
        {
            get
            {
                return techName;
            }

            set
            {
                techName = value;
            }
        }
        public int TicketNo
        {
            get
            {
                return ticketNo;
            }

            set
            {
                if (value > int.MaxValue || value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                else
                {
                    ticketNo = value;
                }
            }
        }
        public string TicketSubject
        {
            get
            {
                return ticketSubject;
            }

            set
            {
                ticketSubject = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
        public string TicketDescription
        {
            get
            {
                return ticketDescription;
            }

            set
            {
                ticketDescription = value;
            }
        }

        //When a customer opens the "Create a Ticket" page. Ticket subject and description are set by the user.
        public Ticket(string email_param)
        {
            Email = email_param; //Tickets are attached to the user's email when they create a new one.
            TechName = "Unassigned"; //Default value for tech for a new ticket
            Status = "Open"; //Default value for status of new ticket
            TicketNo = ++ticketNo;
        }

        //This constructor is used in the DBConnector.GetTickets(usr) method
        public Ticket(string name, string email, string techName, int ticketNo, string ticketSub, string ticketDesc, string status)
        {
            Name = name;
            Email = email;
            TechName = techName;
            TicketNo = ticketNo;
            TicketSubject = ticketSub;
            TicketDescription = ticketDesc;
            Status = status;
        }

        public Ticket()
        {
            //default for DBConnector to add to ticketList when Calling DBConnector.GetTickets()
        }

        //Printing ticket info
        public override string ToString()
        {
            return $"Name: {Name}\nEmail: {Email}\nTechnician: {TechName}\nTicket No: {TicketNo}\nStatus: {Status}\nSubject: {TicketSubject} \nDescription: {TicketDescription}";
        }

    }
}
