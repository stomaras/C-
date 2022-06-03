using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencynversion
{
    /*
     * Is going to new up instances when i need them
     * I create a class which generates four new types of instances
     * that i need to have. Whenever you see a new anywhere --> tight coupling but we want loose coupling (we want talk to just interfaces)
     * 
     * 
     */
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMessageSender());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessageSender CreateMessageSender()
        {
            return new Emailer();
        }



    }
}
