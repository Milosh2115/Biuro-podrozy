using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro_podrozy
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcja, CenaZaNoc;
            string Kontynent;
            int koszt_przelotu = 0;



            Random rnd = new Random();
            List<Hotel> Hotele = new List<Hotel>();
            Hotele.Add(new Hotel { Nazwa = "Cancun Bay Resort", Kraj = "Meksyk", Kategoria = "(****)", Cena = 450, Kont = "Ameryka" });
            Hotele.Add(new Hotel { Nazwa = "Iberostar Quetzal", Kraj = "Meksyk", Kategoria = "(*****)", Cena = 690, Kont = "Ameryka" });
            Hotele.Add(new Hotel { Nazwa = "Imperial Laguna by Faranda", Kraj = "Meksyk", Kategoria = "(***)", Cena = 320, Kont = "Ameryka" });
            Hotele.Add(new Hotel { Nazwa = "Playacalida", Kraj = "Hiszpania", Kategoria = "(*****)", Cena = 600, Kont = "Europa" });
            Hotele.Add(new Hotel { Nazwa = "Palia Puerto del Sol", Kraj = "Hiszpania", Kategoria = "(***)", Cena = 240, Kont = "Europa" });
            Hotele.Add(new Hotel { Nazwa = "Playa Real Resort", Kraj = "Hiszpania", Kategoria = "(****)", Cena = 380, Kont = "Europa" });
            Hotele.Add(new Hotel { Nazwa = "Sea Gull", Kraj = "Egipt", Kategoria = "(***)", Cena = 270, Kont = "Afryka" });
            Hotele.Add(new Hotel { Nazwa = "Continental Hurghada", Kraj = "Egipt", Kategoria = "(****)", Cena = 360, Kont = "Afryka" });
            Hotele.Add(new Hotel { Nazwa = "Sharm Grand Plaza", Kraj = "Egipt", Kategoria = "(*****)", Cena = 620, Kont = "Afryka" });
            Hotele.Add(new Hotel { Nazwa = "Ikaros Hotel", Kraj = "Grecja", Kategoria = "(***)", Cena = 220, Kont = "Europa" });
            Hotele.Add(new Hotel { Nazwa = "Labranda Sandy Beach Resort", Kraj = "Grecja", Kategoria = "(*****)", Cena = 580, Kont = "Europa" });
            Hotele.Add(new Hotel { Nazwa = "Lida Corfu", Kraj = "Grecja", Kategoria = "(****)", Cena = 310, Kont = "Europa" });
            Hotele.Add(new Hotel { Nazwa = "Mytt Beach Hotel", Kraj = "Tajlandia", Kategoria = "(*****)", Cena = 720, Kont = "Azja" });
            Hotele.Add(new Hotel { Nazwa = "Novotel Rayong", Kraj = "Tajlandia", Kategoria = "(****)", Cena = 410, Kont = "Azja" });
            Hotele.Add(new Hotel { Nazwa = "Cholchan Pattaya Resort", Kraj = "Tajlandia", Kategoria = "(***)", Cena = 290, Kont = "Azja" });

            List<Hotel> WylosowaneHotele = new List<Hotel>();
            int LosujHotel = rnd.Next(Hotele.Count);
            WylosowaneHotele.Add(new Hotel { Nazwa = Hotele[LosujHotel].Nazwa, Kraj = Hotele[LosujHotel].Kraj, Kategoria = Hotele[LosujHotel].Kategoria, Cena = Hotele[LosujHotel].Cena, Kont = Hotele[LosujHotel].Kont });

            Console.WriteLine("Sugerowane hotele: ");
            Console.WriteLine("----------------------------");
            Console.WriteLine("NUMER: 1");
            Console.WriteLine("KRAJ: " + WylosowaneHotele[0].Kraj);
            Console.WriteLine("TERMIN: " + "7 dni");
            Console.WriteLine("HOTEL: " + WylosowaneHotele[0].Nazwa + " " + WylosowaneHotele[0].Kategoria);
            Console.WriteLine("wYŻYWIENIE: śniadania");
            Console.WriteLine("CENA: " + WylosowaneHotele[0].Cena * 7 + "PLN/os");
            Console.WriteLine("----------------------------");


            LosujHotel = rnd.Next(Hotele.Count);
            WylosowaneHotele.Add(new Hotel { Nazwa = Hotele[LosujHotel].Nazwa, Kraj = Hotele[LosujHotel].Kraj, Kategoria = Hotele[LosujHotel].Kategoria, Cena = Hotele[LosujHotel].Cena, Kont = Hotele[LosujHotel].Kont });

            Console.WriteLine("NUMER: 2");
            Console.WriteLine("KRAJ: " + WylosowaneHotele[1].Kraj);
            Console.WriteLine("TERMIN: " + "10 dni");
            Console.WriteLine("HOTEL: " + WylosowaneHotele[1].Nazwa + " " + WylosowaneHotele[1].Kategoria);
            Console.WriteLine("wYŻYWIENIE: All Inclusive");
            Console.WriteLine("CENA: " + WylosowaneHotele[1].Cena * 10 + "PLN/os");
            Console.WriteLine("----------------------------");

            LosujHotel = rnd.Next(Hotele.Count);
            WylosowaneHotele.Add(new Hotel { Nazwa = Hotele[LosujHotel].Nazwa, Kraj = Hotele[LosujHotel].Kraj, Kategoria = Hotele[LosujHotel].Kategoria, Cena = Hotele[LosujHotel].Cena, Kont = Hotele[LosujHotel].Kont });

            Console.WriteLine("NUMER: 3");
            Console.WriteLine("KRAJ: " + WylosowaneHotele[2].Kraj);
            Console.WriteLine("TERMIN: " + "14 dni");
            Console.WriteLine("HOTEL: " + WylosowaneHotele[2].Nazwa + " " + WylosowaneHotele[2].Kategoria);
            Console.WriteLine("WYŻYWIENIE: All Inclusive");
            Console.WriteLine("CENA: " + WylosowaneHotele[2].Cena * 14 + "PLN/os");
            Console.WriteLine("----------------------------");
            Console.WriteLine("PROSZĘ PODAĆ NUMER WYBRANEJ OFERTY: ");


            opcja = int.Parse(Console.ReadLine());
            if (opcja == 1)
            {
                Kontynent = WylosowaneHotele[0].Kont;
                if (Kontynent == "Ameryka")
                {
                    koszt_przelotu = 2500;
                }
                else if (Kontynent == "Europa")
                {
                    koszt_przelotu = 1000;
                }
                else if (Kontynent == "Azja")
                {
                    koszt_przelotu = 2000;
                }
                else if (Kontynent == "Afryka")
                {
                    koszt_przelotu = 1500;
                }
                CenaZaNoc = WylosowaneHotele[0].Cena;
                int kwota_pobytu, ilosc_doroslych, ilosc_dzieci;
                Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ OSÓB DOROSŁYCH: ");
                ilosc_doroslych = int.Parse(Console.ReadLine());
                Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ DZIECI: ");
                ilosc_dzieci = int.Parse(Console.ReadLine());
                kwota_pobytu = 7 * (ilosc_doroslych * CenaZaNoc + ilosc_dzieci * (CenaZaNoc / 2));
                kwota_pobytu = kwota_pobytu + koszt_przelotu;
                Console.WriteLine("CAŁKOWITY KOSZT POBYTU: " + kwota_pobytu + "PLN");
            }
            else if (opcja == 2)
            {
                Kontynent = WylosowaneHotele[0].Kont;
                if (Kontynent == "Ameryka")
                {
                    koszt_przelotu = 2500;
                }
                else if (Kontynent == "Europa")
                {
                    koszt_przelotu = 1000;
                }
                else if (Kontynent == "Azja")
                {
                    koszt_przelotu = 2000;
                }
                else if (Kontynent == "Afryka")
                {
                    koszt_przelotu = 1500;
                }
                CenaZaNoc = WylosowaneHotele[0].Cena;
                int kwota_pobytu, ilosc_doroslych, ilosc_dzieci;
                Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ OSÓB DOROSŁYCH: ");
                ilosc_doroslych = int.Parse(Console.ReadLine());
                Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ DZIECI: ");
                ilosc_dzieci = int.Parse(Console.ReadLine());
                kwota_pobytu = 10 * (ilosc_doroslych * CenaZaNoc + ilosc_dzieci * (CenaZaNoc / 2));
                kwota_pobytu = kwota_pobytu + koszt_przelotu + 1200;
                Console.WriteLine("CAŁKOWITY KOSZT POBYTU: " + kwota_pobytu + "PLN");
            }
            else if (opcja == 3)
            {
                Kontynent = WylosowaneHotele[0].Kont;
                if (Kontynent == "Ameryka")
                {
                    koszt_przelotu = 2500;
                }
                else if (Kontynent == "Europa")
                {
                    koszt_przelotu = 1000;
                }
                else if (Kontynent == "Azja")
                {
                    koszt_przelotu = 2000;
                }
                else if (Kontynent == "Afryka")
                {
                    koszt_przelotu = 1500;
                }
                CenaZaNoc = WylosowaneHotele[0].Cena;
                int kwota_pobytu, ilosc_doroslych, ilosc_dzieci;
                Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ OSÓB DOROSŁYCH: ");
                ilosc_doroslych = int.Parse(Console.ReadLine());
                Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ DZIECI: ");
                ilosc_dzieci = int.Parse(Console.ReadLine());
                kwota_pobytu = 14 * (ilosc_doroslych * CenaZaNoc + ilosc_dzieci * (CenaZaNoc / 2));
                kwota_pobytu = kwota_pobytu + koszt_przelotu + 1200;
                Console.WriteLine("CAŁKOWITY KOSZT POBYTU: " + kwota_pobytu + "PLN");
            }


        }



    }
    public class Hotel
    {
        public string Nazwa { get; set; }
        public string Kraj { get; set; }
        public string Kategoria { get; set; }
        public int Cena { get; set; }
        public string Kont { get; internal set; }
        public int koszt_przelotu { get; set; }

    }


}
