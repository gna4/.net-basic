using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class MessageHandler1
    {
        public static void ShowMassageInConsole(string msg)
        {
            Console.WriteLine("By handler 1: " + msg);
        }

        public static int ShowMassageInConsoleAndReturnValue(string msg)
        {
            Console.WriteLine("By handler 1: " + msg);
            return 0;
        }
    }
}
