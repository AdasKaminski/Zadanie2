using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp125
{
    class Samochod : Silnik
    {
        static string marka;
        static string model;
        public int ilosckilometrow;

        public static string Model { get => model; set => model = value; }
        public static string Marka { get => marka; set => marka = value; }

        public Samochod(double Pojemnosc, double IloscPaliwa, double pojemnoscbaku) : base(Pojemnosc, IloscPaliwa, pojemnoscbaku)
        {
           

        }



        public void Jedz(int kilometry)
        {
            Console.WriteLine("Jade");


            Thread.Sleep(kilometry * 100);
            ilosckilometrow = kilometry / 100;

            Dzialaj();
            Console.WriteLine("Jestem");
        }




        public void Dzialaj()
        {
        Console.WriteLine( "Stan baku po odpaleniu " + IloscPaliwa);
            double spalanieSamochodu = ilosckilometrow * 4 * Silnik.Pojemnosc;
            Console.WriteLine("Stan baku po przejechaniu drogi"+ Silnik.IloscPaliwa );
          }
    }
}
