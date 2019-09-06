using crmAppBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace crmAppBL_TEST
{
    [TestClass]
    public class ClientRepoTEST

    {
        [TestMethod]
        public void TestGetClient()
        {

            //Arrange

            ClientRepo clientRepo = new ClientRepo();

            var expected = new Client(1)
            {
                Addressemail = "artur@sury.pl",
                Name = "Artur",
                Surname = "Sury"

            };


            //Act

            var current = clientRepo.GetClient(1);

            //Asserts

            Assert.AreEqual(expected.ClientID, current.ClientID);
            Assert.AreEqual(expected.Addressemail, current.Addressemail);
            Assert.AreEqual(expected.Name, current.Name);
            Assert.AreEqual(expected.Surname, current.Surname);
            

        }
    }
}
