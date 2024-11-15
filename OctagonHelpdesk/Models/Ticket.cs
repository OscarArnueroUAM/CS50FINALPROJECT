using OctagonHelpdesk.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctagonHelpdesk.Models
{
    public class Ticket
    {
        public int IDTicket { get; set; }
        public bool ActiveState { get; set; }
        public int CreadorPor { get; private set; }
        public string Subject { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaCierre { get; set; }
        public State StateProcess { get; set; }
        public Priority Prioridad { get; set; }
        public string AsignadoA { get; set; }




        public Ticket()
        {
            FechaCreacion = DateTime.Now;
        }
        public Ticket(int creadorPorID)
        {
            CreadorPor = creadorPorID;
            FechaCreacion = DateTime.Now;

        }

    }

}
