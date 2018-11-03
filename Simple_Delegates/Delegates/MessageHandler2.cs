using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class MessageHandler2
    {
        public static void ShowMassageInConsole(string msg)
        {
            Console.WriteLine("By handler 2: " + msg);
        }
    }
}
