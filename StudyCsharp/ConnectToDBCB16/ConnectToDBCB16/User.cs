using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToDBCB16
{
    class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder
                    .Append($"User ID is {ID} ")
                    .Append($"UserName is {Name} ")
                    .Append($"Password is {Password} ");
            return builder.ToString();
        }
    }
}
