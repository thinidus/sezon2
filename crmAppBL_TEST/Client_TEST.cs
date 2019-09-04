using System;
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
            string expected = "Artur Sury";


            //Act

            string current = client.FullName;


            //Assert
            Assert.AreEqual(expected, current);
        }

        [TestMethod]
        public void TestEmptyName()
        {
            //Arrange
            Client client = new Client();
            
            client.Surname = "Sury";
            string expected = "Sury";


            //Act

            string current = client.FullName;


            //Assert
            Assert.AreEqual(expected, current);
        }

        [TestMethod]
        public void TestEmptySurname()
        {
            //Arrange
            Client client = new Client();
            client.Name = "Artur";
            
            string expected = "Artur";


            //Act

            string current = client.FullName;


            //Assert
            Assert.AreEqual(expected, current);
        }

        [TestMethod]

        public void TestStaticProp()
        {

            //Arrange
            var client1 = new Client();
            client1.Name = "Jacek";

            var client2 = new Client();
            client1.Name = "Placek";

            var client3 = new Client();
            client1.Name = "Pankracy";

            //Act

            //Assert

            Assert.AreEqual(6, Client.Licznik);




        }

    }
}
