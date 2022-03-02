Console.WriteLine("**** Taller POO ****");

//INSTANCIAR DE LA CLASE 
Product product1 = new FixedPriceProduct()
{
    Description = "Vino Gato Negro",
    Id = 1010,
    Price = 46000M,
    Tax = 0.19F
};
Product product2 = new FixedPriceProduct()
{
    Description = "Pan Bimbo Artesanal",
    Id = 2020,
    Price = 1560M,
    Tax = 0.19F
};
Product product3 = new VariablePriceProduct()
{
    Description = "Queso Holandes",
    Id = 3030,
    Measurement = "Kilo",
    Price = 32000M,
    Quantity = 0.536F,
    Tax = 0.19F
};
Product product4 = new VariablePriceProduct()
{
    Description = "Cabano",
    Id = 4040,
    Measurement = "Kilo",
    Price = 18000M,
    Quantity = 0.389F,
    Tax = 0.19F
};
Product product5 = new ComposedProduct()
{
    Description = "Ancheta #1",
    Discount = 0.12F,
    Id = 5050,
    Products = new List<Product>() { product1, product2, product3, product4 }
};
Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);
Console.WriteLine(product4);
Console.WriteLine(product5);

Invoice invoice = new Invoice();
invoice.AddProduct(product1);
invoice.AddProduct(product3);
invoice.AddProduct(product5);
Console.WriteLine(invoice);

VARIABLEPRICEPRODUCT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    public class VariablePriceProduct : Product
    {
        public decimal Measurement { get; set; }

        public decimal Quantity { get; set; }

        public override decimal GetValueToPay()
        {
            decimal TotalV1 = 0;
            decimal TotalV2 = 0;
            TotalV1 = (Price * Quantity);
            TotalV2 = TotalV1 * Tax;
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
