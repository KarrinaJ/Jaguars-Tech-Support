using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TicketList<Ticket>:List<Ticket>
    {
        private List<Ticket> tickets;
        public List<Ticket> Tickets
        {
            get; set;
        }

        public TicketList()
        {
           Tickets = new List<Ticket>();
        }
       
    }
}
