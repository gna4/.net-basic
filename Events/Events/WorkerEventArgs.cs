using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class WorkerEventArgs: EventArgs
    {
        public WorkerEventArgs(int count)
        {
            Count = count;
        }

        public int Count { get; private set; }
    }
}
