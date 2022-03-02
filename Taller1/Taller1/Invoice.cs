using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    public class Invoice : IPay
    {
        private string _products;

        public Invoice(string product)
        {
            _products = AddProduct(product);
        }

        public string AddProduct(string product)
        {
            throw new NotImplementedException();
        }
        public decimal ValueToPay()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{_products}";
        }

     
    }
}

