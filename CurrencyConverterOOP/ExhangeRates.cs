using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterOOP
{
    public static class ExhangeRates
    {
        // Exchange rates correct at 30/03/2019 - Find a way of updating via URL?
        public static double euroToDollar = 1.20;
        public static double euroToPound = 0.86;
        public static double euroToYen = 12.24;

        public static double dollarToEuro = 0.89;
        public static double dollarToPound = 0.76;
        public static double dollarToYen = 110.73;

        public static double poundToEuro = 1.74;
        public static double poundToDollar = 131.00;
        public static double poundToYen = 145.04;

        public static double yenToEuro = 0.0080;
        public static double yenToDollar = 0.0090;
        public static double yenToPound = 0.0069;
    }

}
