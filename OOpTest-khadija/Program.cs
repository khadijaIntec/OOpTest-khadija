using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOpTest_khadija.Models;

namespace OOpTest_khadija
{
    class Program
    {
        static void Main(string[] args)
        {
            Reisbureau[] reisBureau = newReisbureau();
            Persoon[] persoons = newpersson();

        }
        private static Reisbureau[] newReisbureau()
        {
            Reisbureau[] reisBureau = new Reisbureau[3];
            reisBureau[0] = new Reisbureau
            {
                Naam = "ASPL",
                Adres = new Adres()
                {
                    Gemeente = "ASPLEAA",
                    Straat = "AsPLStraat ",
                    HuisNr = "11",
                    Postcode = 1020
                }
            };
            reisBureau[1] = new Reisbureau
            {
                Naam = "GlobeCA",
                Adres = new Adres()
                {
                    Gemeente = "hall",
                    Straat = "GlobalStraat ",
                    HuisNr = "3",
                    Postcode = 1080
                }
            };

            reisBureau[2] = new Reisbureau
            {
                Naam = "CIC Reis",
                Adres = new Adres()
                {
                    Gemeente = "Jette",
                    Straat = "CICstraat ",
                    HuisNr = "20",
                    Postcode = 9102
                }
            };

            Console.WriteLine();
            Console.WriteLine($"reisBureau name : {reisBureau[0].Naam}\n Gemeente : {reisBureau[0].Adres.Gemeente}\n straat : {reisBureau[0].Adres.Straat}\n huisNr : {reisBureau[0].Adres.HuisNr}\n poscode : {reisBureau[0].Adres.Postcode}");
            Console.WriteLine("\n*****************");
            Console.WriteLine();
            Console.WriteLine($"reisBureau name : {reisBureau[1].Naam}\n Gemeente : {reisBureau[1].Adres.Gemeente}\n straat : {reisBureau[1].Adres.Straat}\n huisNr : {reisBureau[1].Adres.HuisNr}\n poscode : {reisBureau[1].Adres.Postcode}");
            Console.WriteLine("\n******************");
            Console.WriteLine();
            Console.WriteLine($"reisBureau name : {reisBureau[2].Naam}\n Gemeente : {reisBureau[2].Adres.Gemeente}\n straat : {reisBureau[2].Adres.Straat}\n huisNr : {reisBureau[2].Adres.HuisNr}\n poscode : {reisBureau[2].Adres.Postcode}");
            Console.WriteLine();

            return reisBureau;
        }

        private static Persoon[] newpersson()
        {
            Persoon[] persoons = new Persoon[5];
            persoons[0] = new Persoon
            {
                Voornaam = "KHADIJA",
                Familienaam = "SADKI",

                Adres = new Adres
                {
                    Gemeente = "Scharbeek",
                    HuisNr = "12",
                    Postcode = 1020,
                    Straat = "Cloostraat"
                }
                 
            };
            Console.WriteLine("\n*****************************************");
            Console.WriteLine();

            persoons[1] = new Persoon
            {
                Voornaam = "BILAL",
                Familienaam = "AKHMACH",

                Adres = new Adres
                {
                    Postcode = 1080,
                    Gemeente = "BRUSSEL",
                    Straat = "StraatBrus",
                    HuisNr = "3"
                }
            };
            
            persoons[2] = new Persoon
            {
                Voornaam = "Kenan",
                Familienaam = "Kurda",

                Adres = new Adres
                {
                    Postcode = 1999,
                    Gemeente = "Forst",
                    Straat = "Straat9",
                    HuisNr = "25"
                }
            };
           

            persoons[3] = new Persoon
            {
                Voornaam = "LAGSOUN",
                Familienaam = "NAWAL",

                Adres = new Adres
                {
                    Postcode = 1070,
                    Gemeente = "Brugge",
                    Straat = "StraatB",
                    HuisNr = "62"
                }
            };



            Console.WriteLine();
            Console.WriteLine($"name : {persoons[0].Naam}\n Gemeente : {persoons[0].Adres.Gemeente}\n straat : {persoons[0].Adres.Straat}\n huisNr : {persoons[0].Adres.HuisNr}\n poscode : {persoons[0].Adres.Postcode}");
            Console.WriteLine("\n****************************************");
            Console.WriteLine();
            Console.WriteLine($"name : {persoons[1].Naam}\n Gemeente : {persoons[1].Adres.Gemeente}\n straat : {persoons[1].Adres.Straat}\n huisNr : {persoons[1].Adres.HuisNr}\n poscode : {persoons[1].Adres.Postcode}");
            Console.WriteLine("\n****************************************");
            Console.WriteLine();
            Console.WriteLine($"name : {persoons[2].Naam}\n Gemeente : {persoons[2].Adres.Gemeente}\n straat : {persoons[2].Adres.Straat}\n huisNr : {persoons[2].Adres.HuisNr}\n poscode : {persoons[2].Adres.Postcode}");
            Console.WriteLine("\n****************************************");
            Console.WriteLine();
            Console.WriteLine($"name : {persoons[3].Naam}\n Gemeente : {persoons[3].Adres.Gemeente}\n straat : {persoons[3].Adres.Straat}\n huisNr : {persoons[3].Adres.HuisNr}\n poscode : {persoons[3].Adres.Postcode}");
            Console.WriteLine("\n****************************************");
            Console.WriteLine();
            Console.ReadKey();
            return persoons;
        }
    }
}
