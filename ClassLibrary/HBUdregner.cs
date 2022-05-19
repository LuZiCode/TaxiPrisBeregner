using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class HBUdregner
    {
        public object TjekningAfOmråde(decimal antalmin, string område)
        {
            if (område == "Vejle")
            {
                return VejleUdregning(antalmin);
            }
            if (område == "Århus")
            {
                return ÅrhusUdregning(antalmin);
            }
            if (område == "København")
            {
                return KøbenhavnUdregning(antalmin);
            }
            if (område == "Øvrig")
            {
                return ØvrigUdregning(antalmin);
            }
            else return 0;
        }

        private decimal ØvrigUdregning(decimal antalmin)
        {
            decimal prisPrMin = 13.33m;
            decimal result = antalmin * prisPrMin;
            return result;

        }

        private decimal KøbenhavnUdregning(decimal antalmin)
        {
            decimal prisPrMin = 6.583m;
            decimal result = antalmin * prisPrMin;
            return result;
        }

        private decimal ÅrhusUdregning(decimal antalmin)
        {
            decimal prisPrMin = 15m;
            decimal result = antalmin * prisPrMin;
            return result;
        }

        private decimal VejleUdregning(decimal antalmin)
        {
            decimal prisPrMin = 16.67m;
            decimal result = antalmin * prisPrMin;
            return result;
        }
    }
}
