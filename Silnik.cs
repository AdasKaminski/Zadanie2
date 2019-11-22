using System;

namespace ConsoleApp125
{ [Serializable]
   public class Silnik
    {
        public  double pojemnosc;
        public  double iloscPaliwa;
        public  double pojemnoscZbiornikaPaliwa;
       

        public double Pojemnosc { get => pojemnosc; set => pojemnosc = value; }
        public double IloscPaliwa { get => iloscPaliwa; set => iloscPaliwa = value; }
        public double PojemnoscZbiornikaPaliwa { get => pojemnoscZbiornikaPaliwa; set => pojemnoscZbiornikaPaliwa = value; }

        public Silnik(double Pojemnosc, double IloscPaliwa)
        {
            this.Pojemnosc = Pojemnosc;
            this.IloscPaliwa = IloscPaliwa;
        }

        public Silnik(double Pojemnosc, double IloscPaliwa, double pojemnoscbaku)
        {
            this.Pojemnosc = Pojemnosc;
            this.IloscPaliwa = IloscPaliwa;
            this.pojemnoscZbiornikaPaliwa = pojemnoscbaku;

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

