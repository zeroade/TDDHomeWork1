using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDHomeWork1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

namespace TDDHomeWork1.Tests
{
    [TestClass()]
    public class PagingGroupTests
    {
        List<Order> testdata =
                new List<Order>
                {
                    new Order { Id = 1, Cost = 1,Revence=11,SellPrice= 21},
                    new Order { Id = 2, Cost = 2,Revence=12,SellPrice= 22},
                    new Order { Id = 3, Cost = 3,Revence=13,SellPrice= 23},
                    new Order { Id = 4, Cost = 4,Revence=14,SellPrice= 24},
                    new Order { Id = 5, Cost = 5,Revence=15,SellPrice= 25},
                    new Order { Id = 6, Cost = 6,Revence=16,SellPrice= 26},
                    new Order { Id = 7, Cost = 7,Revence=17,SellPrice= 27},
                    new Order { Id = 8, Cost = 8,Revence=18,SellPrice= 28},
                    new Order { Id = 9, Cost = 9,Revence=19,SellPrice= 29},
                    new Order { Id = 10, Cost = 10,Revence=20,SellPrice= 30},
                    new Order { Id = 11, Cost = 11,Revence=21,SellPrice= 31}
                };

        [TestMethod()]
        public void pagingcount為3時Cost為6_15_24_21()
        {
            // arrange
            var target = new PagingGroup();
            var expected = new[] { 6, 15, 24, 21 };

            //var testData = GetOrders();
            var fieldname = "Cost";
            var pagingcount = 3;

            // act
            var actual = target.GroupingFieldValues(testdata, fieldname, pagingcount);

            // assert           
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void pagingcount為4時Revenue為50_66_60()
        {
            // arrange
            var testcase = new PagingGroup();
            var expected = new[] { 50, 66, 60 };

            //var testData = GetOrders();
            var fieldname = "Revenue";
            var pagingcount = 4;

            // act
            var actual = testcase.GroupingFieldValues(testdata, fieldname, pagingcount);

            // assert           
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}