using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    public class ComposedProduct : Product
    {

        public decimal Discount { get; set; }
        public string Products { get; set; }

        public override decimal ValueToPay()
        {
            foreach (Product product in Products)
            {
                decimal totalDisc0 = 0;
                float totalDisc = 0;

                totalDisc0 = product.ValueToPay();
                totalDisc = totalDisc0 * Discount;

            }
            return GetValueToPay += totalDisc0 - totalDisc;

        }

        public override string ToString()
        {
            return $"{Id} {Description}" +
                $"\n\tProducts...: {Products}" +
                $"\n\tDiscount...: {$"{Discount:P2}",16} " +
                $"\n\tValue......: {$"{GetValueToPay:C2}",16} ";
        }

    }
}
}
