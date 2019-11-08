using System;

namespace ConsoleApp125
{
    class Silnik
    {
        double Pojemnosc;
        double IloscPaliwa;
        private double pojemnoscZbiornikaPaliwa;
        static double pojemnoscbaku = 40;

        public Silnik(double Pojemnosc, double IloscPaliwa, double pojemnoscbaku)
        {
            this.Pojemnosc = Pojemnosc;
            this.IloscPaliwa = IloscPaliwa;
            pojemnoscZbiornikaPaliwa = pojemnoscbaku;
        }

        public double PojemnoscZbiornikaPaliwa

        {
            get

            {
                pojemnoscZbiornikaPaliwa = Pojemnosc;
                return PojemnoscZbiornikaPaliwa;


            }

        }


        public void Nalitry(double mpg)
        {
            double litry;
            litry = 235.2 / mpg;
            Console.WriteLine("Litry=" + litry);
            Console.WriteLine("MPG=" + mpg);

        }
        public void Nagalony(double litry)
        {
            double mpg;
            mpg = litry / 235.2;
            Console.WriteLine("Litry=" + litry);
            Console.WriteLine("MPG=" + mpg);

        }
       
    }
}

