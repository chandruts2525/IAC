using IAC.Service.ICommands;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAC.Service.IHandler
{
    public interface IHandler<TCommand> where TCommand : ICommand
    {
        bool Handle(TCommand t);
    }
}
