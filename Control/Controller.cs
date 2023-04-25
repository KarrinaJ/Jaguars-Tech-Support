using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Jaguars_Tech_Support.Boundary;

namespace Control
{
    abstract class Controller
    {
        private Form1 form;
        private TicketList<Ticket> list;
        private Controller controller;
        private Ticket ticket;

        public Controller()
        {

        }

    }
}
