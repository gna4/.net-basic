using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Handler1
    {
        public static void ShowMessage(int count)
        {
            Console.WriteLine($"Handler 1. Work is Done, count is {count.ToString()}");
        }
    }
}
