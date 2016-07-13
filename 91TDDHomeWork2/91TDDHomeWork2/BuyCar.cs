using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91TDDHomeWork2
{
    public class BuyCar
    {
        private double EndSalePrice = 0;
        //此處考量到方便性將ProductGroupClass寫死在方法內，在產品上不可這樣寫
        public double ComputeEndSalePrice(List<Product> product_list)
        {
            ProductGroupClass halibote_book = new ProductGroupClass
            {
                GroupClassName = "哈利波特套書",
                GroupClassCode = "哈利波特套書",
                GroupCount = 5
            };

            List<ProductGroup> product_groups = Product.DivideProductGroup(product_list, halibote_book);
            foreach (var item in product_groups)
            {
                EndSalePrice += Discount.GroupCountDiscount(item);
            }
            return EndSalePrice;
        }        
    }

    public class Product
    {
        public double SellPrice { get; set; }
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public string ProductGroupCode { get; set; }

        //將group產品的方法抽出，有over design的可能
        public static List<ProductGroup> DivideProductGroup(List<Product> SelectedProduct, ProductGroupClass halibote_book)
        {
                               
            List<Product> GetGroupOfSelectedProduct = SelectedProduct.Where(x => x.ProductGroupCode == halibote_book.GroupClassCode).ToList();
            int MaxGroupCount = 0;
            MaxGroupCount =GetGroupOfSelectedProduct.Max(x =>x.ProductCount);
        
            double[] product_price = GetGroupOfSelectedProduct.Select(x => x.SellPrice).ToArray<double>();
            int[] product_count = GetGroupOfSelectedProduct.Select(x => x.ProductCount).ToArray<int>();
            List<ProductGroup> ReturnProductGroup = new List<ProductGroup>();
            for (int i = 0; i < MaxGroupCount; i++)
            {
                ProductGroup TempPG = new ProductGroup();
                TempPG.GroupID = i;
                for (int j = 0; j < product_count.Length; j++)
                {
                    if (product_count[j] > 0)
                    {
                        TempPG.GroupCount++;
                        TempPG.GroupPrice += product_price[j];
                        product_count[j]--;
                    }                    
                }                
                ReturnProductGroup.Add(TempPG);
            }            
            return ReturnProductGroup;
        }
    }

    public class ProductGroup
    {
        public int GroupID { get; set; }
        public List<Product> GroupItem { get; set; }
        public double GroupPrice { get; set; }
        public int GroupCount { get; set; }
    }

    public class ProductGroupClass
    {
        public string GroupClassName { get; set; }
        public string GroupClassCode { get; set; }
        public int GroupCount { get; set; }
    }

    public class Discount
    {
        //折扣應該有狀態，此次無相關的案例因此先不考慮避免over design
        //折扣很常見應該有常見的實作可參考，此次考量開發時程先不考慮
        //折扣應做多型，此次考量開發時程先不考慮

        public static double GroupCountDiscount(ProductGroup product_group)
        {
            double EndPrice = 0;
            switch (product_group.GroupCount)
            {
                case 1:
                    EndPrice = product_group.GroupPrice * 1;
                    break;
                case 2:
                    EndPrice = product_group.GroupPrice * 0.95;
                    break;
                case 3:
                    EndPrice = product_group.GroupPrice * 0.9;
                    break;
                case 4:
                    EndPrice = product_group.GroupPrice * 0.8;
                    break;
                case 5:
                    EndPrice = product_group.GroupPrice * 0.75;
                    break;               
            }
            return EndPrice;
        }
    }    
}
