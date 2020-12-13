using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpTest_khadija.Models
{
  public  class Autovakantie : Reis
    {
        private const double _extraPrijsHuurAuto = 10;
        private bool v;

        public bool EigenWagen { get; set; }
        public DateTime TerugKeerDatum { get; }

        public override double BerekenPrijs()
        {
            if (EigenWagen)
            {
                return base.BerekenPrijs();
            }
            else if (AantalPersonen > 5 || EigenWagen)
            {
                return base.BerekenPrijs() + AantalDagen * (_extraPrijsHuurAuto + _extraPrijsHuurAuto);
            }
            else
            {
                return base.BerekenPrijs() + AantalDagen * _extraPrijsHuurAuto;
            }
        }
        public Autovakantie(int v, DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen)
            : base(vertrekDatum, terugkeerDatum, aantalPersonen)
        {
            this.VertrekDatum = vertrekDatum;
            this.TerugKeerDatum = terugkeerDatum;
            this.AantalPersonen = aantalPersonen;
        }

        public Autovakantie(int aantalPersonen, DateTime vertrekDatum, DateTime terugkeerDatum, bool v) : base(aantalPersonen, vertrekDatum, terugkeerDatum)
        {
            this.v = v;
        }
    }
}