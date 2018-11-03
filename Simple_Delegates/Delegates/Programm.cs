using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegates
{
    class Programm
    {
        static void Main(string[] args)
        {
            Worker w = new Worker();
            w.StartWork(MessageHandler1.ShowMassageInConsole);

            w.StartWork(MessageHandler2.ShowMassageInConsole);
        }
    }
}
