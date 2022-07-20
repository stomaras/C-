using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EshopStrategy
{
    public interface IVariationStrategy
    {
        int Cost(Tshirt tshirt);
    }
}
