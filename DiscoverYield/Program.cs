using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoverYield
{
    class Program
    {
        private static IEnumerable<int> GetData()
        {
            yield return 0;
            yield return 1;
            yield return 2;
            yield return 3;
        }

        static void Main(string[] args)
        {
            foreach (var item in GetData())
            {
                Console.WriteLine(item);
            }
        }
    }
}
