using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAC.Service.ICommands
{
    public interface ICommand
    {
        Guid CommandId { get; }
    }
}
