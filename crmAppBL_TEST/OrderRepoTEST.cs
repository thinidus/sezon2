using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using crmAppBL;

namespace crmAppBL_TEST
{
    [TestClass]
    public class OrderRepoTEST
    {
        [TestMethod]
        public void GetOrderTest()
        {

            //Arrange 
            var orderRepo = new OrderRepo();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0))

            };




            //Act

            var current = orderRepo.GetOrder(10);

            //Asserts

            Assert.AreEqual(expected.OrderID, current.OrderID);
            Assert.AreEqual(expected.OrderDate, current.OrderDate);


        }


    }
}
