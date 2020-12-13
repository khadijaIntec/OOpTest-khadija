using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOpTest_khadija.Interface;

namespace OOpTest_khadija.Models
{
    public class ReisReservatie : ILoggable
    {
        private Persoon lOUIS;
        private Reisbureau vakantieLOUIS;
        private object uRLM;
        private object vakantieLOUIS1;

        public Reisbureau Reisbureau { get; set; }
        public Persoon Persoon { get; set; }
        public Reis Reis { get; set; }

        LogMessage ILoggable.LogMessage => throw new NotImplementedException();

        public ReisReservatie(Reis reis, Reisbureau reisbureau, Persoon persoon)
        {
            Reis = reis;
            Reisbureau = reisbureau;
            Persoon = persoon;
            LoggerService.AddLogMessage(LogMessage());
        }

        public ReisReservatie(object khadija, object vakantiekhadija, Reisbureau aSPL)
        {
        }

        public ReisReservatie(Persoon lOUIS, Reisbureau vakantieLOUIS, object uRLM)
        {
            this.lOUIS = lOUIS;
            this.vakantieLOUIS = vakantieLOUIS;
            this.uRLM = uRLM;
        }

        public ReisReservatie(Persoon lOUIS, object vakantieLOUIS1, object uRLM)
        {
            this.lOUIS = lOUIS;
            this.vakantieLOUIS1 = vakantieLOUIS1;
            this.uRLM = uRLM;
        }

        public LogMessage LogMessage()
        {
            return new LogMessage($"{Reisbureau} {Reis} {Persoon}");
        }
    }
}
