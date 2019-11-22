using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp125
{ [Serializable]
    public class Samochod
    {
        private string marka;
        private string model;
        private Silnik silnik;
        public int ilosckilometrow;
        private double licznik;

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public Silnik Silnik { get => silnik; set => silnik = value; }

        public Samochod(string marka, string model, double pojemnosc, double iloscbenzyny, double pojemnoscbaku)
        {
            this.Marka = marka;
            this.model = model;

            Silnik test =new Silnik(pojemnosc,iloscbenzyny,pojemnoscbaku);
            Silnik = test;



        }

        public Samochod(string marka, string model,double pojemnosc , double iloscbenzyny)
        {
            this.Marka = marka;
            this.model = model;
            Silnik test1 = new Silnik(pojemnosc, iloscbenzyny);
            Silnik = test1;
            

        }

        public Samochod(string marka, string model, Silnik silnik)
        {
            this.Marka = marka;
            this.model = model;
            this.silnik = silnik;
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
        Console.WriteLine( "Stan baku po odpaleniu " + Silnik.iloscPaliwa);
            double spalanieSamochodu = ilosckilometrow * 4 * Silnik.pojemnosc;
            Silnik.IloscPaliwa = (Silnik.IloscPaliwa - spalanieSamochodu);

            Console.WriteLine("Stan baku po przejechaniu drogi"+ Silnik.iloscPaliwa );
          }

        //public Samochod Binary(Samochod test)
        //{
        //    BinaryFormatter binFormatter = new BinaryFormatter();

        //    using (Stream fstream = new FileStream("mojedane.dat", FileMode.Create, FileAccess.Write))
        //    {
        //        binFormatter.Serialize(fstream, test);
        //    }
        //    return test;

        //}

        //public Samochod DeBinary(Samochod test)
        //{
        //    BinaryFormatter binFormatter = new BinaryFormatter();

        //    using (Stream fstream = new FileStream("mojedane.dat", FileMode.Open, FileAccess.Read))
        //    {
        //        test = (Samochod)binFormatter.Deserialize(fstream);
        //    }
        //    return test;
        //}

        public Samochod XML(Samochod test)
        {
            XmlFormatter XMLFormatter = new XmlFormatter(typeof(Samochod));
            using (Stream fstream = new FileStream("mojedane.dat", FileMode.Create, FileAccess.Write))
            {
                XMLFormatter.Serialize(fstream, test);
            }
            return test;
        }

        public Samochod DeXml(Samochod test)
        {
            
                    XmlFormatter XMLFormatter = new XmlFormatter(typeof(Samochod));
            
                  using (Stream fstream = new FileStream("mojedane.xml", FileMode.Open, FileAccess.Read))
                   {
                       test = (Samochod)XMLFormatter.Deserialize(fstream);
                  }

                return test;
        }
    }
}
