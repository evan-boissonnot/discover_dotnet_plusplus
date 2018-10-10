using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverParallele
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, i => Parallel.For(0, 10, j => Console.WriteLine((i + j))));
        }
    }
}
