using CodeWarsConsole.Helpers.Helpers.HelpersFundamentals;
using CodeWarsConsole.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsConsole.Factory
{
    static class Factory
    {

        public static PrintView CreatePrintView()
        {
            return new PrintView();
        }

        public static HelperFundamentals CreateHelperFundamentals()
        {
            return new HelperFundamentals();
        }
    }
}
