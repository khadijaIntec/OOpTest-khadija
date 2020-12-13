﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpTest_khadija.Models
{
   public  class Cruise : Reis
    {
        private const double CRUISEPRIJSEXTRADAGKOST = 10;
        public bool VIP { get; private set; }
        public Cruise(int aantalPersonen, DateTime vertrekDatum, DateTime terugkeerDatum, bool vip)
            : base(aantalPersonen, vertrekDatum, terugkeerDatum)
        {
            VIP = vip;
        }
        public override double BerekenPrijs()
        {
            if (VIP)
            {
                return base.BerekenPrijs() + (CRUISEPRIJSEXTRADAGKOST * AantalPersonen) * 1.5;
            }
            else
            {
                return base.BerekenPrijs() + (CRUISEPRIJSEXTRADAGKOST * AantalPersonen);
            }

        }
    }
}
    
