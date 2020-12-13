using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpTest_khadija.Models
{
    public abstract class Reis
    {
        private double BASISDAGPRIJS = 40d;
        private DateTime vertrekDatum;
        private DateTime terugkeerDatum;
        public int AantalDagen
        {
            get
            {
                TimeSpan timeSpan = TerugkeerDatum - VertrekDatum;
                return timeSpan.Days;
            }
        }
        public int AantalPersonen { get; set; }
        public DateTime VertrekDatum
        {
            get { return vertrekDatum; }
            set
            {
                if (value < DateTime.Now)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Ingegeven datum is in het verleden .");
                    
                    Console.ReadLine();
                }
                else
                {
                    vertrekDatum = value;
                }
            }
        }
        public DateTime TerugkeerDatum
        {
            get { return terugkeerDatum; }
            set
            {
                if (value < DateTime.Now || value < VertrekDatum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Terugkeerdatum niet geldig! Ingegeven datum is vroeger dan de vertrekdatum!");
                    Console.ResetColor();
                    Console.ReadLine();
                }
                else
                {
                    terugkeerDatum = value;
                }
            }
        }
        public Reis(int aantalPersonen, DateTime vertrekDatum, DateTime terugkeerDatum)
        {
            AantalPersonen = aantalPersonen;
            VertrekDatum = vertrekDatum;
            TerugkeerDatum = terugkeerDatum;
        }

        protected Reis(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen)
        {
            VertrekDatum = vertrekDatum;
            TerugkeerDatum = terugkeerDatum;
            AantalPersonen = aantalPersonen;
        }

        public virtual double BerekenPrijs()
        {
            return AantalDagen * BASISDAGPRIJS;
        }
        public override string ToString()
        {
            return $"Aantal personen:{AantalPersonen}\nVertrekdatum: {VertrekDatum.Day}/{VertrekDatum.Month}/{VertrekDatum.Year}" +
                $"\nTerugkeerdatum: {TerugkeerDatum.Day}/{TerugkeerDatum.Month}/{TerugkeerDatum.Year}" +
                $"\nPrijs: {BerekenPrijs()} EUR";
        }
    }
}
   


   
