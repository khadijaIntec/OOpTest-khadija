using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpTest_khadija.Models
{
   public  class LogMessage
    {

        public string Boodschap { get; private set; }
        public int ID { get; private set; }
        private static int _counter { get; set; }
        private int GenereerID()
        {
            _counter++;
            return _counter;
        }
        public LogMessage(string boodschap)
        {
            Boodschap = boodschap;
            ID = GenereerID();
        }
        public override string ToString()
        {
            return $"*******************\nLOG:{ID} {Boodschap}\n";
        }
    }
}
    
