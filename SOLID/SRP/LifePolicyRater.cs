using SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class LifePolicyRater : Rater
    {

        private readonly RatingEngine _engine;
        private ConsoleLogger _logger;

        public LifePolicyRater(RatingEngine engine, ConsoleLogger logger)
        {
            _engine = engine;
            _logger = logger;
        }

        public decimal Rating { get; private set; }

        public void Rate(Policy policy)
        {
            _logger.Log("Rating LIFE policy...");
            _logger.Log("Validating policy.");
            if (policy.DateOfBirth == DateTime.MinValue)
            {
                _logger.Log("Life policy must include Date of Birth.");

                return;
            }
            if (policy.DateOfBirth < DateTime.Today.AddYears(-100))
            {
                _logger.Log("Centenarians are not eligible for coverage.");

                return;
            }
            if (policy.Amount == 0)
            {
                _logger.Log("Life policy must include an Amount.");

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
        }

    }
}
