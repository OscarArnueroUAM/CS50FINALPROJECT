using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctagonHelpdesk.Models
{
    internal class Ticket
    {
        public int TicketID { get; set; }
        public int CreadorPor { get; private set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Ticket(int creadorPorID)
        {
            CreadorPor = creadorPorID;
            FechaCreacion = DateTime.Now;
        }

    }

}
