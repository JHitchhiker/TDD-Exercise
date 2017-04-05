using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMGTDD.Service;

namespace UMGTDD.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a Partner and Effective Date for a list of available Tracks");
            var command = "";
            var inputHandler = new InputHandler();
            while (command != "exit")
            {
                
                command = Console.ReadLine();
                try
                {
                    Console.Clear();
                    var results = inputHandler.HandleCommand(command);

                    foreach (var result in results)
                    {
                        Console.WriteLine(result);
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Input Supplied. Please try again - [PARTNER] [1st Jan 2012]");
                }
                
            }
        }
    }
}
