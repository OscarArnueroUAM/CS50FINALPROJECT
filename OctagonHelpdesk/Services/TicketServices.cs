using OctagonHelpdesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctagonHelpdesk.Services
{
    internal class TicketServices
    {
        List<Ticket> tickets = new List<Ticket>();
        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }
        public List<Ticket> GetTickets()
        {
            return tickets;
        }
        public void RemoveTicket(int idTicket)
        {
            
        }
    }
}
