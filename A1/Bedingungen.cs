using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Bedingungen
    {
        public static void ZaehlerNull(int counter)
        {
            if (counter == 0)
                Aktionen.ZaehlerNull();
        }

        public static void ZaehlerGroesserTausend(int counter)
        {
            if (counter > 1000)
                Aktionen.ZaehlerGroesserTausend();
        }

        public static void ZaehlerGerade(int counter)
        {
            if ((counter % 2) == 0)
                Aktionen.ZaehlerGerade();
        }

        public static void ZaehlerUngerade(int counter)
        {
            if ((counter % 2) != 0)
                Aktionen.ZaehlerUngerade();
        }
    }
}
