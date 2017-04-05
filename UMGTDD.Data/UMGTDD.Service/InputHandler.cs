using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMGTDD.Service
{
    public class InputHandler : CommandHandler
    {
        public override void HandleCommand(string command)
        {
            List<string> commandParts = new List<string>();
            commandParts.Add(command.Substring(0, command.IndexOf(" ")));
            commandParts.Add(command.Substring(command.IndexOf(" ")));
        }
    }
}
