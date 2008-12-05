using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Aktionen
    {
        public static void ZaehlerNull()
        {
            Aktionen.PrintMessage("Zähler ist 0");
        }

        public static void ZaehlerGroesserTausend()
        {
            Aktionen.PrintMessage("Zähler ist größer 1000");
        }

        public static void ZaehlerGerade()
        {
            Aktionen.PrintMessage("Zähler ist gerade");
        }

        public static void ZaehlerUngerade()
        {
            Aktionen.PrintMessage("Zähler ist ungerade");
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine("[Aktion:]\t{0}", message);
        }

    }
}
