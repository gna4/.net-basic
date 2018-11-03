using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s = Singleton.Instance;

            s.Count = 42;

            Console.WriteLine(s.Count.ToString());

            test();
        }

        static void test()
        {
            Singleton s = Singleton.Instance;
            Console.WriteLine(s.Count.ToString());
        }

    }

    class Singleton
    {
        public int Count { get; set; }

        private static Singleton _singleton;

        static Singleton()
        {
            Console.WriteLine("static Singleton");
            _singleton = new Singleton();
        }

        public static Singleton Instance
        {
            get { return _singleton; }
        }

        private Singleton()
        {
        }
    }
}
