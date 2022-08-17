using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    /*
     * This help us to cover single responsibility principle 
     * we move switch statement inside Factory Class
     * Because Rating Enfgine is not now responsible for determing 
     * which type and which logic to be used
     */
    public class RaterFactory
    {
        public Rater Create(Policy policy, RatingEngine engine)
        {
            switch (policy.Type)
            {
                case PolicyType.Life:
                    return new AutoPolicyRater(engine, engine.Logger);
                case PolicyType.Land:
                    return new LandPolicyRater(engine, engine.Logger);
                    
                case PolicyType.Auto:
                    return new AutoPolicyRater(engine, engine.Logger);
                default:
                    return null;
            }
        }
    }
}
