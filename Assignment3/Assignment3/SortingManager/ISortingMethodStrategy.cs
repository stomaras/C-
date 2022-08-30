using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.SortingManager
{
    public interface ISortingMethodStrategy
    {
        List<TShirt> SortAsc(List<TShirt> tshirts);
        List<TShirt> SortDesc(List<TShirt> tshirts);
    }
}
