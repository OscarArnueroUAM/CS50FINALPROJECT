using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctagonHelpdesk.Models
{
    public class Role
    {
        public int IDRole;

        public string RoleName;
        public bool AdminPerms { get; set; }
        public bool ITPerms { get; set; }
        public bool BasicPerms { get; set; }
    }
}
