using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public interface ICard
    {
        void GetCardType();
        void GetCreditLimit();
    }
}
