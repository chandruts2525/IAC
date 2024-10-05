using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IAC.Service.Commands;
using IAC.Service.IHandler;

namespace IAC.Service.Handler
{
    public class CreateRoleHandler : IHandler<CreateRole>
    {
        public bool Handle(CreateRole t)
        {
            //Repository
            throw new NotImplementedException();
        }
    }
}
