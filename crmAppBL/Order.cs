using System;
using System.Collections.Generic;

namespace crmAppBL
{
    public class Order
    {

        public Order()
        {

        }

        public Order(int orderID)
        {
            OrderID = orderID;
        }

        public int OrderID { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public bool Validate()
        {


            var status = true;

            if (OrderDate == null) { status = false; }

            return status;

        }


        



    }
}
