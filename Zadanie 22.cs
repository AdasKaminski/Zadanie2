using System;

namespace ConsoleApp125
{
    class Program
    {
        enum Menu1 { Nowy_klient = 1, Wczytaj_ostatni_zapis = 2 , Koniec = 3};
        enum Menu2 { Jedż = 1, Zapisz = 2, Licznik = 3, Koniec = 4 }
        public static void Main(string[] args)
        {

            
            //test.Jedz(100);
            //test = test.Binary(test);
            //test = test.DeBinary(test);
            //Console.WriteLine(test.Marka);



            bool konty = true;
            while (konty == true)
            {

                Console.WriteLine("1.Nowy klient\n2.Wczytaj osatni zapis\n3.Koniec");


                Menu1 start;
                bool poprawnamenu1 = Enum.TryParse<Menu1>(Console.ReadLine(), out start);
                if (!poprawnamenu1)
                {
                    Console.WriteLine("Wybrałeś nie poprawną opcję. Wybierz jeszcze raz");
                }
                switch (start)
                {
                    case Menu1.Nowy_klient:
                        Console.WriteLine("Podaj swoje imie");
                        string imieKierowcy = Console.ReadLine();
                        Console.WriteLine("Podaj markę");
                        string markaSamochodu = Console.ReadLine();
                        Console.WriteLine("Podaj model");
                        string modelSamochodu = Console.ReadLine();

                        double pojemnoscSilnika;
                        do
                        {
                            Console.WriteLine("Podaj pojemnosc silnika ");

                        }

                        while (!double.TryParse(Console.ReadLine(), out pojemnoscSilnika));
                        int pojemnoscZbiornika;
                        do
                        {
                            Console.WriteLine("Podaj pojemność zbiornika");

                        }
                        while (!int.TryParse(Console.ReadLine(), out pojemnoscZbiornika));

                        double ileLitrowWSamochodzie;
                        do
                        {
                            Console.WriteLine("Podaj ile jest obecnie litrów w baku");
                        }
                        while (!double.TryParse(Console.ReadLine(), out ileLitrowWSamochodzie));

                        Console.Clear();
                        Silnik testsilnika = new Silnik(2, 20, 40);
                        Samochod test = new Samochod("Audi", "Astra", 2, 20);
                        Console.WriteLine(imieKierowcy+ " " +markaSamochodu +" "+ modelSamochodu+" "+ pojemnoscSilnika+ " " + pojemnoscZbiornika+ " " + ileLitrowWSamochodzie );
                        test = test.XML(test);

                        Console.ReadLine();
                        break;
                    case Menu1.Wczytaj_ostatni_zapis:
                        Samochod test1 = new Samochod("","",1,1,1);
                        test = test1.DeXml(test1);
                        Console.WriteLine();
                        break;
                    case Menu1.Koniec:
                        Console.WriteLine("Koniec");
                        konty = false;

                        Console.Clear();


                        break;
                    default:
                        break;
                }
            }

        }
    }
}

