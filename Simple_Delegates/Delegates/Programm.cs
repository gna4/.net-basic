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
            //simple delegate
            w.StartWork1(MessageHandler1.ShowMassageInConsole);
            w.StartWork1(MessageHandler2.ShowMassageInConsole);

            // Action delegate
            w.StartWork2(MessageHandler1.ShowMassageInConsole);
            w.StartWork2(MessageHandler2.ShowMassageInConsole);

            // Func delegate
            w.StartWork3(MessageHandler1.ShowMassageInConsoleAndReturnValue);
        }
    }
}
