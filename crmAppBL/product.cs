using System;
using System.Collections.Generic;

namespace crmAppBL
{
    class Product
    {

        public Product()
        {

        }

        public Product(int productID)
        {
            productID = ProductID;
        }

        //Propertis

        public int ProductID { get; private set; }
        public decimal? CurrentPrice { get; set; }
        public string Describe { get; set; }
        public string ProductName { get; set; }

        public bool Validate()
        {
            

            var status = true;

            if (string.IsNullOrWhiteSpace(ProductName)) { status = false; }
            if (CurrentPrice == null) { status = false; }


            return status;

        }


        public bool SaveProduct()
        {
            /// <summary>
            /// Funkcja zapisująca
            /// </summary>
            /// <returns></returns>
            return true;

        }

        public Client GetProduct(int productID)
        {
            /// <summary>
            /// Funkcja pobierająca produkt po ID
            /// </summary>
            /// <returns></returns>
            return new Client();

        }

        public List<Product> GetProduct()
        {
            /// <summary>
            /// Funkcja pobierająca wszystkie produkty
            /// </summary>
            /// <returns></returns>
            return new List<Product>();

        }


    }
}
