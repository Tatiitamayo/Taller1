using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }

        public float Quantity { get; set; }
        public override decimal GetValueToPay()
        {
            decimal TotalV1 = 0;
            decimal TotalV2 = 0;
            TotalV1 = Price * (decimal)Quantity;
            TotalV2 = TotalV1 * (decimal)Tax;
            return TotalV1 + TotalV2;
        }

        public override string ToString()
        {
            return $"{Id} {Description}" +
                 $"\n\tMeasurement: {$"{Measurement}",16} " +
                 $"\n\tQuantity...: {$"{Quantity:C2}",16} " +
                 $"\n\tPrice......: {$"{Price:C2}",16} " + //C2-P2-N2
                 $"\n\tTax........: {$"{Tax:P2}",16} " +
                 $"\n\tValue......: {$"{GetValueToPay:C2}",16} ";

        }

    }

}


