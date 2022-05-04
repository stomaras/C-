using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalIDs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonId<string, ID>> keyValuePairs = new List<PersonId<string, ID>>();
            keyValuePairs.Add(new PersonId<string, ID>("PASPARAKIS GEORGIOS", new ID()));
            Console.WriteLine(keyValuePairs[0]);
        }

        struct PersonId<Name, ID>
        {
            public PersonId(Name name, ID ids)
            {

            }
        }
    }
}
