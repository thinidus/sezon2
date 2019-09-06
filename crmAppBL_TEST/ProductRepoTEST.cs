using crmAppBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace crmAppBL_TEST
{
    [TestClass]
    public class ProductRepoTEST
    {
        [TestMethod]
        public void GetProductTEST()
        {


            //Arrange 
            var productRepo = new ProductRepo();
            var expected = new Product(5)
            {
                ProductName = "Klocki LEGO",
                Describe = "No klocki jak w mordę strzelił",
                CurrentPrice = 200.00M


            };



            //Act

            var current = productRepo.GetProduct(5);

            //Asserts

            Assert.AreEqual(expected.ProductID, current.ProductID);
            Assert.AreEqual(expected.ProductName, current.ProductName);
            Assert.AreEqual(expected.Describe, current.Describe);
            Assert.AreEqual(expected.CurrentPrice, current.CurrentPrice);


        }
    }
}
