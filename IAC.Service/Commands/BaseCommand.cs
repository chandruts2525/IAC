using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IAC.Service.ICommands;

namespace IAC.Service.Commands
{
    public abstract class BaseCommand : ICommand
    {
        public BaseCommand()
        {
            this.CommandId = new Guid();
        }
        public Guid CommandId { get; }
    }
}
