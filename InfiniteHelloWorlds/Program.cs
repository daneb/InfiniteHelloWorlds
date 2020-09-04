
using System;
using System.Threading.Tasks;

namespace InfiniteHelloWorlds
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Task.Delay(500).Wait();
                Console.WriteLine("Hello World!");
            }
           
        }
    }
}