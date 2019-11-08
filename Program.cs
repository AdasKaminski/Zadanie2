using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp125
{
    class Program
    {
        public static void Main(string[] args)
        {
            Silnik silnik = new Silnik();
            Console.WriteLine(silnik.PojemnoscZbiornikaPaliwa);
        }
    }
}
