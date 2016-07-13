using Microsoft.VisualStudio.TestTools.UnitTesting;
using _91TDDHomeWork2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

namespace _91TDDHomeWork2.Tests
{
  
    [TestClass()]
    public class ProductTests
    {
        ProductGroupClass halibote_book = new ProductGroupClass
        {
            GroupClassName = "哈利波特套書",
            GroupClassCode = "哈利波特套書",
            GroupCount = 5
        };
        [TestMethod()]
        public void DivideProductGroupTest_single()
        {
            // arrange
            List<Product> target =
             new List<Product>
             {
                    new Product { ProductName = "哈利波特1",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"}
             };
            var excepted =
            new List<ProductGroup>
            {
                    new ProductGroup { GroupID=0, GroupCount=1,GroupPrice=100}
            };

            BuyCar MyBuyCar = new BuyCar();

            // act
            var actual = Product.DivideProductGroup(target, halibote_book);

            // assert           
            excepted.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void DivideProductGroupTest()
        {
            // arrange
            List<Product> target =
             new List<Product>
             {
                    new Product { ProductName = "哈利波特1",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特2",SellPrice=100, ProductCount=2, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特3",SellPrice=100, ProductCount=2, ProductGroupCode="哈利波特套書"}
             };
            var excepted =
            new List<ProductGroup>
            {
                    new ProductGroup { GroupID=0, GroupCount=3,GroupPrice=300},
                    new ProductGroup { GroupID=1, GroupCount=2,GroupPrice=200},
            };

            BuyCar MyBuyCar = new BuyCar();

            // act
            var actual = Product.DivideProductGroup(target, halibote_book);

            // assert           
            excepted.ToExpectedObject().ShouldEqual(actual);
        }
    }
}