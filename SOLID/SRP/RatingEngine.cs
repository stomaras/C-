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
            switch (policy.Type)
            {
                case PolicyType.Auto:
                    Logger.Log("Rating AUTO policy...");
                    Logger.Log("Validating policy.");
                    

                    // Validations
                    if (String.IsNullOrEmpty(policy.Make))
                    {
                        
                        Logger.Log("Auto policy must specify Make");
                        return;
                    }
                    if (policy.Make == "BMW")
                    {
                        if (policy.Deductible < 500)
                        {
                            Rating = 1000m;
                        }
                        Rating = 900m;
                    }
                    break;

                case PolicyType.Land:
                    Logger.Log("Rating LAND policy...");
                    Logger.Log("Validating policy.");
                    
                    
                    if (policy.BondAmount == 0 || policy.Valuation == 0)
                    {
                        Logger.Log("Land policy must specify Bond Amount and Valuation.");
                        
                        return;
                    }
                    if (policy.BondAmount < 0.8m * policy.Valuation)
                    {
                        Logger.Log("Insufficient bond amount.");
                        
                        return;
                    }
                    Rating = policy.BondAmount * 0.05m;
                    break;

                case PolicyType.Life:
                    Logger.Log("Rating LIFE policy...");
                    Logger.Log("Validating policy.");
                    if (policy.DateOfBirth == DateTime.MinValue)
                    {
                        Logger.Log("Life policy must include Date of Birth.");
                       
                        return;
                    }
                    if (policy.DateOfBirth < DateTime.Today.AddYears(-100))
                    {
                        Logger.Log("Centenarians are not eligible for coverage.");
                       
                        return;
                    }
                    if (policy.Amount == 0)
                    {
                        Logger.Log("Life policy must include an Amount.");
                       
                        return;
                    }
                    // Age calculation responsibility
                    int age = DateTime.Today.Year - policy.DateOfBirth.Year;
                    if (policy.DateOfBirth.Month == DateTime.Today.Month &&
                        DateTime.Today.Day < policy.DateOfBirth.Day ||
                        DateTime.Today.Month < policy.DateOfBirth.Month)
                    {
                        age--;
                    }
                    decimal baseRate = policy.Amount * age / 200;
                    if (policy.IsSmoker)
                    {
                        Rating = baseRate * 2;
                        break;
                    }
                    Rating = baseRate;
                    break;

                default:
                    Logger.Log("Unknown policy type");
                    
                    break;
            }
            Logger.Log("Rating completed.");
            
        }
        }
}
