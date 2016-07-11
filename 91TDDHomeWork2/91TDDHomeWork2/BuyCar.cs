using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91TDDHomeWork2
{
    public class BuyCar
    {
        private double _EndSalePrice = 0;
        public double ComputeEndSalePrice(List<Product> SelectedProduct)
        {
            _EndSalePrice = SelectedProduct.Sum(x => x.SellPrice);
            return _EndSalePrice;
        }
    }

    public class Product
    {
        public double SellPrice { get; set; }
        public string ProductName { get; set; }
    }

    
}
