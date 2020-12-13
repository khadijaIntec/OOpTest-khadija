using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpTest_khadija.Models
{
   public class VliegtuigVakantie :Reis
    {

        public double VliegtuigTicketPrijs { get; private set; }
        public VliegtuigVakantie(int aantalPersonen, DateTime vertrekDatum, DateTime terugkeerDatum, double vliegtuigTicketPrijs) : base(aantalPersonen, vertrekDatum, terugkeerDatum)
        {
            VliegtuigTicketPrijs = vliegtuigTicketPrijs;
        }
        public override double BerekenPrijs()
        {
            return base.BerekenPrijs() + VliegtuigTicketPrijs;
        }
    }
}