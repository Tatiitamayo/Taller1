using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    public class ComposedProduct : Product
    {

        public float Discount { get; set; }
        public string Products { get; set; }

        public override decimal GetValueToPay()
        {
            foreach (Product product in Products)
            {

            }
        }
    }

        public override string ToString()
        {
            return $"{Id} {Description}" +
                $"\n\tProducts...: {Products}" +
                $"\n\tDiscount...: {$"{Discount:P2}",16} " +
                $"\n\tValue......: {$"{GetValueToPay:C2}",16} ";
        }

    
}

