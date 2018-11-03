using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Events
{
    class Worker
    {
        // example 1
        public delegate void WokIsDoneDelegate(int count);
        public event WokIsDoneDelegate OnWorkIsDone1;

        // example 2
        public event Action<int> OnWorkIsDone2;

        // example 3
        public event EventHandler<WorkerEventArgs> OnWorkIsDone3;

        public void StartWork1()
        {
            int count = 0;

            while (true)
            {
                count++;
                if (count >= 10)
                {
                    if (OnWorkIsDone1 != null)
                    {
                        OnWorkIsDone1(count);
                    }

                    if (OnWorkIsDone2 != null)
                    {
                        OnWorkIsDone2(count);
                    }

                    if (OnWorkIsDone3 != null)
                    {
                        OnWorkIsDone3(this, new WorkerEventArgs(count));
                    }

                    return;
                }
                Thread.Sleep(100);
            }
        }
    }
}
