using System.Collections;

namespace Taller1
{
    public class ComposedProduct : Product
    {

        public float Discount { get; set; }
        public ICollection Products { get; set; }

        private string _prod { get; set; }

        public override decimal ValueToPay()
        {
            decimal Total = 0;

            foreach (Product product in Products)
            {
                decimal totalDisc0 = 0;
                decimal prod;

                prod = product.ValueToPay();
                totalDisc0 = prod * (decimal)Discount;
                Total = prod - (decimal)totalDisc0;

            }
            return Total;
        }

        public override string ToString()
        {
            foreach (Product product in Products)
            {
                _prod += product.Description + ",";

            }


            return $"{Id} {Description}" +
                $"\n\tProducts...: {$"{_prod}",16}" +
                $"\n\tDiscount...: {$"{Discount:P2}",16} " +
                $"\n\tValue......: {$"{ValueToPay():C2}",16} ";
        }


    }
}

