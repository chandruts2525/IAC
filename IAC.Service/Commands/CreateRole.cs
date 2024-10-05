using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace IAC.Service.Commands
{
    public class CreateRole: BaseCommand
    {
        public string RoleName { get; set; }
        public int RoleType { get; set; }

    }
}
