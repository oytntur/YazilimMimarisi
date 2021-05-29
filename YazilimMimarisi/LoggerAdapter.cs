using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    class LoggerAdapter : ILogger
    {
        private htmlLogger htmlLogger;
        public void LogAt(Rapor rapor)
        {
            htmlLogger = new htmlLogger();
            htmlLogger.htmlLogla(rapor);
        }
    }
}
