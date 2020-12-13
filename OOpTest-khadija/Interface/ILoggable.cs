using OOpTest_khadija.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpTest_khadija.Interface
{
  public  interface ILoggable
    {
        LogMessage LogMessage { get; }
    }
}
