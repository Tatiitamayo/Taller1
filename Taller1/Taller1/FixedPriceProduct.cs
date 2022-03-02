using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    public class FixedPriceProduct : Product
    {

        public override decimal GetValueToPay()
        {
            decimal TotalFixed = 0;
            return TotalFixed = (Price * (decimal)Tax) + Price;
        }


        public override string ToString()
        {
            return $"{Id} {Description}" +
                $"\n\tPrice......: {$"{Price:C2}",16} " + //C2-P2-N2
                $"\n\tTax........: {$"{Tax:P2}",16} " +
                $"\n\tValue......: {$"{GetValueToPay:C2}",16} ";
        }


    }
}
