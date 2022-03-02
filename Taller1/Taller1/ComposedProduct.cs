using System.Collections;

namespace Taller1
{
    public class ComposedProduct : Product
    {

        public float Discount { get; set; }
        public ICollection Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal totalDisc0 = 0;
            decimal totalDisc1 = 0;
            decimal sum = 0;

            foreach (Product product in Products)
            {

                totalDisc0 = product.ValueToPay();
                totalDisc1 = totalDisc0 * (decimal)Discount;

            }
            return sum += totalDisc0 - totalDisc1;
        }

        public override string ToString()
        {
            return $"{Id} {Description}" +
                $"\n\tProducts...: {Products}" +
                $"\n\tDiscount...: {$"{Discount:P2}",16} " +
                $"\n\tValue......: {$"{ValueToPay():C2}",16} ";
        }


    }
}

