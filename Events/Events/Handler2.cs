using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Handler2
    {
        public static void ShowMessage(int count)
        {
            Console.WriteLine($"Handler 2. Work is Done, count is {count.ToString()}");
        }
    }
}
