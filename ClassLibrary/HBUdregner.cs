using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class HBUdregner
    {
        public void TjekningAfOmråde(decimal antalmin, string område)
        {
            if (område == "Vejle")
            {
                VejleUdregning(område, antalmin)
            }
        }

        private void VejleUdregning(string område, decimal antamin)
        {
            throw new NotImplementedException();
        }
    }
}
