using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsConsole.Views
{
    interface IPrintView
    {

        int EnterANumber();

        string EnterAString();

        void EnterNumericValueMessage();
        void EnterStringValueNotNullAndBetween1And10CharsLong();

        string ConvertBooleanToString(bool b);

        void OutPutBoolean(string n);
    }
}
