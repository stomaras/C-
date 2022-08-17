using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    /*
     * The RatingEngine reads the policy application details from a file 
     * and produces a numeric rating value based on the details.\
     * 
     * With Many Responsibilities is difficult to write unit tests for them 
     * Tests Become 
     * Longer
     * More Complex
     * Brittle
     * Coupled To Implementation 
     */
    public class RatingEngine
    {
        public ConsoleLogger Logger { get; set; } = new ConsoleLogger();
        public FilePolicySource PolicySource { get; set; } = new FilePolicySource();
        public decimal Rating { get; set; }
        public void Rate()
        {
            // First Single Responsibility 
            // Logging
            Logger.Log("Starting rate.");
            Logger.Log("Loading policy.");


            // load policy - open file policy.json
            // Persistence Responsibility, how to input policy in the application 
            // delegating the details into other classes
            string policyJson = PolicySource.GetPolicyFromSource();


            // how to deserialize policy responsibiity 
            var policy = JsonConvert.DeserializeObject<Policy>(policyJson,
                new StringEnumConverter());

            // Type of policy
            //switch (policy.Type)
            //{
            //    case PolicyType.Auto:
            //        var rater = new AutoPolicyRater(this, this.Logger);
            //        rater.Rate(policy);
            //        break;

            //    case PolicyType.Land:
            //        var rater2 = new LandPolicyRater(this, this.Logger);
            //        rater2.Rate(policy);
            //        break;

            //    case PolicyType.Life:
            //        var rater3 = new LifePolicyRater(this, this.Logger);
            //        rater3.Rate(policy);
            //        break;

            //    default:
            //        Logger.Log("Unknown policy type");
            //        break;
            //}
            var factory = new RaterFactory();

            var rater = factory.Create(policy, this);
            rater.Rate(policy);

            Logger.Log("Rating completed.");
            
        }
        }
}
