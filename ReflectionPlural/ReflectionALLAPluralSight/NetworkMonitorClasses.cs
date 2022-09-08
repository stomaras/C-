using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionALLAPluralSight
{

    /*
     *    A class which contains all the configuration in
     * 1) WarningService string: contains the name of the service used to warn
     * 2) MethodToExecute string: contains the method to use on that service.
     * 3) Property Bag Dictionary: contains a potential list of parameters for that method.
     * 
     * 
     */
    public class NetWorkMonitorSettings
    {

        // WarningService string contains the name of the service used to warn. 
        public string WarningService { get; set; }

        // MethodToExecute string contains the method to use on that service
        public string MethodToExecute { get; set; }

        // contains a potential list of parameters for that method.
        public Dictionary<string, object> PropertyBag { get; set; } = 
            new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
    }

    // service 1
    public class MailService
    {
        /// <summary>
        /// The address to send the mail to and the subject.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="subject"></param>
        public void SendMail(string address, string subject)
        {
            Console.WriteLine($"Sending a warning mail to {address} with subject {subject}.");
        }
    }


    // service 2-- existing services that call into other components.
    public class SoundHornService
    {
        /// <summary>
        /// expects one parameter the volume.
        /// </summary>
        /// <param name="volumne"></param>
        public void SoundHorn(string volumne)
        {
            Console.WriteLine($"Making noise with the volume turned up to {volumne}.");
        }
    }
}
