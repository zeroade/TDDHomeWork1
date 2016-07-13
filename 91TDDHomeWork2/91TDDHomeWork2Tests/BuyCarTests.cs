using Microsoft.VisualStudio.TestTools.UnitTesting;
using _91TDDHomeWork2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91TDDHomeWork2.Tests
{
    [TestClass()]
    public class BuyCarTests
    {      
        [TestMethod()]
        public void 第一集買了一本_其他都沒買_價格應為100元()
        {
            // arrange
            List<Product> target =
             new List<Product>
             {
                    new Product { ProductName = "哈利波特1",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"}
             };

            BuyCar MyBuyCar = new BuyCar();
            double excepted = 100;
            // act
            double actual = MyBuyCar.ComputeEndSalePrice(target);

            // assert           
            Assert.AreEqual<double>(excepted, actual);
        }

        [TestMethod()]
        public void 第一集買了一本_第二集也買了一本_價格應為190元()
        {
            List<Product> target =
             new List<Product>
             {
                    new Product { ProductName = "哈利波特1",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特2",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"}
             };

            BuyCar MyBuyCar = new BuyCar();
            double excepted = 190;
            // act
            double actual = MyBuyCar.ComputeEndSalePrice(target);

            // assert           
            Assert.AreEqual<double>(excepted, actual);
        }

        [TestMethod()]
        public void 一二三集各買了一本_價格應為270元()
        {
            List<Product> target =
             new List<Product>
             {
                    new Product { ProductName = "哈利波特1",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特2",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特3",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
             };

            BuyCar MyBuyCar = new BuyCar();
            double excepted = 270;
            // act
            double actual = MyBuyCar.ComputeEndSalePrice(target);

            // assert           
            Assert.AreEqual<double>(excepted, actual);
        }

        [TestMethod()]
        public void 一次買了整套_價格應為375元()
        {
            List<Product> target =
             new List<Product>
             {
                    new Product { ProductName = "哈利波特1",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特2",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特3",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特4",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特5",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"}
             };

            BuyCar MyBuyCar = new BuyCar();
            double excepted = 375;
            // act
            double actual = MyBuyCar.ComputeEndSalePrice(target);

            // assert           
            Assert.AreEqual<double>(excepted, actual);
        }

        [TestMethod()]
        public void 一二三四集各買了一本_價格應為320元()
        {
            List<Product> target =
             new List<Product>
             {
                    new Product { ProductName = "哈利波特1",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特2",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特3",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特4",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"}
             };

            BuyCar MyBuyCar = new BuyCar();
            double excepted = 320;
            // act
            double actual = MyBuyCar.ComputeEndSalePrice(target);

            // assert           
            Assert.AreEqual<double>(excepted, actual);
        }

        [TestMethod()]
        public void 一二集各買了一本_第三集買了兩本_價格應為370元()
        {
            List<Product> target =
             new List<Product>
             {
                    new Product { ProductName = "哈利波特1",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特2",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特3",SellPrice=100, ProductCount=2, ProductGroupCode="哈利波特套書"}
             };

            BuyCar MyBuyCar = new BuyCar();
            double excepted = 370;
            // act
            double actual = MyBuyCar.ComputeEndSalePrice(target);

            // assert           
            Assert.AreEqual<double>(excepted, actual);
        }

        [TestMethod()]
        public void 第一集買了一本_第二三集各買了兩本_價格應為460元()
        {
            List<Product> target =
               new List<Product>
               {
                    new Product { ProductName = "哈利波特1",SellPrice=100, ProductCount=1, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特2",SellPrice=100, ProductCount=2, ProductGroupCode="哈利波特套書"},
                    new Product { ProductName = "哈利波特3",SellPrice=100, ProductCount=2, ProductGroupCode="哈利波特套書"}
               };

            BuyCar MyBuyCar = new BuyCar();
            double excepted = 460;
            // act
            double actual = MyBuyCar.ComputeEndSalePrice(target);

            // assert           
            Assert.AreEqual<double>(excepted, actual);
        }
    }
}