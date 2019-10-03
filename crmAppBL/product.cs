using System;
using System.Collections.Generic;

namespace crmAppBL
{
    public class Product : BaseClass
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

        //Methods
        public override  bool Validate()
        {
            

            var status = true;

            if (string.IsNullOrWhiteSpace(ProductName)) { status = false; }
            if (CurrentPrice == null) { status = false; }


            return status;

        }

        public override string ToString()
        {
            return ProductName;
        }



    }
}
