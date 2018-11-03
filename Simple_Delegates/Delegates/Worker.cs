using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Delegates
{
    class Worker
    {
        public delegate void MessageHandlerDelegat(string msg);

        public void StartWork(MessageHandlerDelegat MessageHandler)
        {
            int count = 0;

            while (true)
            {
                count++;
                MessageHandler(count.ToString());
                if (count >= 10)
                {
                    MessageHandler("Work is done");
                    return;
                }
                Thread.Sleep(100);
            }
        }
    }
}
