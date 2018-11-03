using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Handler3
    {
        public static void ShowMessage(object sender, WorkerEventArgs e)
        {
            Console.WriteLine($"Handler 3. Work is Done, count is {e.Count.ToString()}");
        }
    }
}
