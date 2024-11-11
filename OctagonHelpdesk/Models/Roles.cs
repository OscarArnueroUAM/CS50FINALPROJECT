using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctagonHelpdesk.Models
{
    public class Roles
    {
        public int rolesid;
        public bool AdminPerms { get; set; }
        public bool ITperms { get; set; }
        public bool BasicPerms { get; set; }
    }
}
