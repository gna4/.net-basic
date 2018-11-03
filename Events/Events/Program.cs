using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker();

            w.OnWorkIsDone1 += Handler1.ShowMessage;

            w.OnWorkIsDone2 += Handler2.ShowMessage;

            w.OnWorkIsDone3 += Handler3.ShowMessage;

            w.StartWork1();
        }
    }
}
