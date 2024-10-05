using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAC.Service.Commands
{
    public class UpdateRole: BaseCommand
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string ModifiedBy { get; set; }
    }
}
