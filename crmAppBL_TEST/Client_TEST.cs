using crmAppBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace crmAppBL_TEST
{
    [TestClass]
    public class Client_TEST
    {
        [TestMethod]
        
        public void TestFullName()
        {
            //Arrange
            Client client = new Client();
            client.Name = "Artur";
            client.Surname = "Sury";
            string expectedFullName = "Artur Sury";


            //Act

            string current = client.FullName;


            //Assert
            Assert.AreEqual(expectedFullName, current);
        }

        [TestMethod]
        public void TestEmptyName()
        {
            //Arrange
            Client client = new Client();

            client.Surname = "Sury";
            string expectedEmptyName = "Sury";


            //Act

            string current = client.FullName;


            //Assert
            Assert.AreEqual(expectedEmptyName, current);
        }

        [TestMethod]
        public void TestEmptySurname()
        {
            //Arrange
            Client client = new Client();
            client.Name = "Artur";

            string expectedEmptyName = "Artur";


            //Act

            string current = client.FullName;


            //Assert
            Assert.AreEqual(expectedEmptyName, current);
        }

        [TestMethod]
        public void TestValidate()
        {
            //Arrange

            Client client = new Client();
            client.Addressemail = "artur@sury.pl";
            client.Surname = "Sury";

            bool expectedResultTestValidate = true;

            //Act

            var resultTestValidate = client.Validate();

            //Assert
            Assert.AreEqual(expectedResultTestValidate, resultTestValidate);


        }

        [TestMethod]
        public void TestValidateNoSurname()
        {
            //Arrange

            Client client = new Client();
            client.Addressemail = "artur@sury.pl";
            

            bool expectedResultTestValidate = false;

            //Act

            var resultTestValidate = client.Validate();

            //Assert
            Assert.AreEqual(expectedResultTestValidate, resultTestValidate);


        }

        [TestMethod]
        public void TestValidateNoEmail()
        {
            //Arrange

            Client client = new Client(5);
            client.Surname = "Sury";


            bool expectedResultTestValidate = false;

            //Act

            var resultTestValidate = client.Validate();

            //Assert
            Assert.AreEqual(expectedResultTestValidate, resultTestValidate);


        }

    }
}
