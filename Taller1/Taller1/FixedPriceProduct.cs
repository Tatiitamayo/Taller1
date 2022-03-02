namespace Taller1
{
    public class FixedPriceProduct : Product
    {

        public override decimal ValueToPay()
        {
            decimal TotalFixed = 0;
            return TotalFixed = (Price * (decimal)Tax) + Price;
        }


        public override string ToString()
        {
            return $"{Id} {Description}" +
                $"\n\tPrice......: {$"{Price:C2}",16} " + //C2-P2-N2
                $"\n\tTax........: {$"{Tax:P2}",16} " +
                $"\n\tValue......: {$"{ValueToPay:C2}",16} ";
        }


    }
}
